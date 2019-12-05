package service

import (
	"bytes"
	"crypto/hmac"
	"crypto/sha1"
	"encoding/base64"
	"encoding/json"
	"fmt"
	"hash"
	"io"
	"reflect"
	"sort"
	"strconv"
	"strings"
	"time"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/aliyun-ccp/baseclient/go/utils"
)

var hookdo = func(response *tea.Response, err error) (*tea.Response, error) {
	return response, err
}

// Sorter defines the key-value structure for storing the sorted data in signHeader.
type Sorter struct {
	Keys []string
	Vals []string
}

type AccessTokenResponse struct {
	AccessToken  string `json:"access_token"`
	RefreshToken string `json:"refresh_token"`
	ExpireTime   string `json:"expires_time"`
}

type credentialUpdater struct {
	ExpireTime *int64
}

func (updater *credentialUpdater) needUpdateCredential() bool {
	if updater.ExpireTime == nil {
		return false
	}
	return *updater.ExpireTime-time.Now().Unix() <= 5
}

// newSorter is an additional function for function Sign.
func newSorter(m map[string]string) *Sorter {
	hs := &Sorter{
		Keys: make([]string, 0, len(m)),
		Vals: make([]string, 0, len(m)),
	}

	for k, v := range m {
		hs.Keys = append(hs.Keys, k)
		hs.Vals = append(hs.Vals, v)
	}
	return hs
}

// Sort is an additional function for function SignHeader.
func (hs *Sorter) Sort() {
	sort.Sort(hs)
}

// Len is an additional function for function SignHeader.
func (hs *Sorter) Len() int {
	return len(hs.Vals)
}

// Less is an additional function for function SignHeader.
func (hs *Sorter) Less(i, j int) bool {
	return bytes.Compare([]byte(hs.Keys[i]), []byte(hs.Keys[j])) < 0
}

// Swap is an additional function for function SignHeader.
func (hs *Sorter) Swap(i, j int) {
	hs.Vals[i], hs.Vals[j] = hs.Vals[j], hs.Vals[i]
	hs.Keys[i], hs.Keys[j] = hs.Keys[j], hs.Keys[i]
}

func getSignature(request *tea.Request, accessKeySecret string) string {
	resource := request.Pathname
	tmp := ""
	for key, value := range request.Query {
		if value != "" {
			tmp = tmp + "&" + key + "=" + value
		}
	}
	if tmp != "" {
		resource = resource + "?" + tmp
	}
	return getSignedStr(request, resource, accessKeySecret)
}

func getSignedStr(req *tea.Request, canonicalizedResource, accessKeySecret string) string {
	temp := make(map[string]string)

	for k, v := range req.Headers {
		if strings.HasPrefix(strings.ToLower(k), "x-acs-") {
			temp[strings.ToLower(k)] = v
		}
	}
	hs := newSorter(temp)

	// Sort the temp by the ascending order
	hs.Sort()

	// Get the canonicalizedOSSHeaders
	canonicalizedOSSHeaders := ""
	for i := range hs.Keys {
		canonicalizedOSSHeaders += hs.Keys[i] + ":" + hs.Vals[i] + "\n"
	}

	// Give other parameters values
	// when sign URL, date is expires
	date := req.Headers["date"]
	accept := req.Headers["accept"]
	contentType := req.Headers["content-type"]
	contentMd5 := req.Headers["content-md5"]

	signStr := req.Method + "\n" + accept + "\n" + contentMd5 + "\n" + contentType + "\n" + date + "\n" + canonicalizedOSSHeaders + canonicalizedResource
	h := hmac.New(func() hash.Hash { return sha1.New() }, []byte(accessKeySecret))
	_, _ = io.WriteString(h, signStr)
	signedStr := base64.StdEncoding.EncodeToString(h.Sum(nil))

	return signedStr
}

func flatRepeatedList(dataValue reflect.Value, result map[string]string, prefix string) {
	if !dataValue.IsValid() {
		return
	}

	dataType := dataValue.Type()
	if dataType.Kind().String() == "slice" {
		handleRepeatedParams(dataValue, result, prefix)
	} else if dataType.Kind().String() == "map" {
		handleMap(dataValue, result, prefix)
	} else {
		result[prefix] = fmt.Sprintf("%v", dataValue.Interface())
	}
}

func handleRepeatedParams(repeatedFieldValue reflect.Value, result map[string]string, prefix string) {
	if repeatedFieldValue.IsValid() && !repeatedFieldValue.IsNil() {
		for m := 0; m < repeatedFieldValue.Len(); m++ {
			elementValue := repeatedFieldValue.Index(m)
			key := prefix + "." + strconv.Itoa(m+1)
			fieldValue := reflect.ValueOf(elementValue.Interface())
			if fieldValue.Kind().String() == "map" {
				handleMap(fieldValue, result, key)
			} else {
				result[key] = fmt.Sprintf("%v", fieldValue.Interface())
			}
		}
	}
}

func handleMap(valueField reflect.Value, result map[string]string, prefix string) {
	if valueField.IsValid() && valueField.String() != "" {
		valueFieldType := valueField.Type()
		if valueFieldType.Kind().String() == "map" {
			var byt []byte
			byt, _ = json.Marshal(valueField.Interface())
			cache := make(map[string]interface{})
			_ = json.Unmarshal(byt, &cache)
			for key, value := range cache {
				pre := ""
				if prefix != "" {
					pre = prefix + "." + key
				} else {
					pre = key
				}
				fieldValue := reflect.ValueOf(value)
				flatRepeatedList(fieldValue, result, pre)
			}
		}
	}
}

func refreshAccessToken(endpoint, domainId, refreshToken, clientId, clientSecret string) (string, string, *credentialUpdater, error) {
	request := tea.NewRequest()
	request.Protocol = "http"
	request.Method = "POST"
	request.Pathname = "/v2/oauth/token"
	request.Headers = map[string]string{
		"date":                    utils.GetRFC2616Date(),
		"content-type":            "application/x-www-form-urlencoded",
		"accept":                  "application/json",
		"x-acs-signature-method":  "HMAC-SHA1",
		"x-acs-signature-version": "1.0",
	}
	request.Headers["host"] = domainId + ".api.alicloudccp.com"
	if endpoint != "" {
		request.Headers["host"] = endpoint
	}
	bodyStr := "grant_type=refresh_token&refresh_token=" + refreshToken + "&client_id=" + clientId + "&client_secret=" + clientSecret
	request.Body = strings.NewReader(bodyStr)
	response, err := hookdo(tea.DoRequest(request, nil))
	if err != nil || response.StatusCode != 200 {
		return "", "", nil, err
	}

	body, err := response.ReadBody()
	if err != nil {
		return "", "", nil, err
	}

	accessToken := new(AccessTokenResponse)
	err = json.Unmarshal(body, &accessToken)
	if err != nil {
		return "", "", nil, err
	}

	expiretime, err := time.Parse(time.RFC3339, accessToken.ExpireTime)
	if err != nil {
		return "", "", nil, err
	}
	expireTime := expiretime.Unix()
	update := &credentialUpdater{
		ExpireTime: &expireTime,
	}
	return accessToken.AccessToken, accessToken.RefreshToken, update, nil
}

func Prettify(i interface{}) string {
	resp, _ := json.MarshalIndent(i, "", "   ")
	return string(resp)
}

func getStringValue(obj interface{}) string {
	if obj == nil {
		return ""
	}
	return obj.(string)
}

func getIntValue(obj interface{}) int {
	if obj == nil {
		return 0
	}
	return obj.(int)
}

func getBoolValue(obj interface{}) bool {
	if obj == nil {
		return false
	}
	return obj.(bool)
}
