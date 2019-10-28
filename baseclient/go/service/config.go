package service

import (
	"bytes"
	"crypto/hmac"
	"crypto/sha1"
	"encoding/base64"
	"encoding/json"
	"errors"
	"fmt"
	"hash"
	"io"
	"reflect"
	"regexp"
	"sort"
	"strconv"
	"strings"
	"time"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/aliyun-ccp/baseclient/go/utils"
)

// Common basic types
var basicTypes = []string{
	"int", "int64", "float32", "float64", "string", "bool", "uint64",
}

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

var validatorParams = []string{"require", "pattern", "maxLength"}

// Verify whether the parameters meet the requirements
func validator(dataValue reflect.Value) error {
	if strings.HasPrefix(dataValue.Type().String(), "*") { // Determines whether the input is a structure object or a pointer object
		if dataValue.IsNil() {
			return nil
		}
		dataValue = dataValue.Elem()
	}
	dataType := dataValue.Type()
	for i := 0; i < dataType.NumField(); i++ {
		field := dataType.Field(i)
		valueField := dataValue.Field(i)
		for _, value := range validatorParams {
			err := validatorParam(field, valueField, value)
			if err != nil {
				return err
			}
		}
	}
	return nil
}

func validatorParam(field reflect.StructField, valueField reflect.Value, tagName string) error {
	tag, containsTag := field.Tag.Lookup(tagName) // Take out the checked regular expression
	if containsTag && tagName == "require" {
		err := checkRequire(field, valueField)
		if err != nil {
			return err
		}
	}
	if strings.HasPrefix(field.Type.String(), "[]") { // Verify the parameters of the array type
		err := validatorSlice(valueField, containsTag, tag, tagName)
		if err != nil {
			return err
		}
	} else if valueField.Kind() == reflect.Ptr { // Determines whether it is a pointer object
		err := validatorPtr(valueField, containsTag, tag, tagName)
		if err != nil {
			return err
		}
	}
	return nil
}

func validatorSlice(valueField reflect.Value, containsregexpTag bool, tag, tagName string) error {
	if valueField.IsValid() && !valueField.IsNil() { // Determines whether the parameter has a value
		for m := 0; m < valueField.Len(); m++ {
			elementValue := valueField.Index(m)
			if elementValue.Type().Kind() == reflect.Ptr { // Determines whether the child elements of an array are of a basic type
				err := validatorPtr(elementValue, containsregexpTag, tag, tagName)
				if err != nil {
					return err
				}
			}
		}
	}
	return nil
}

func validatorPtr(elementValue reflect.Value, containsregexpTag bool, tag, tagName string) error {
	if elementValue.IsNil() {
		return nil
	}

	if isFilterType(elementValue.Elem().Type().String(), basicTypes) {
		if containsregexpTag {
			if tagName == "pattern" {
				err := checkPattern(elementValue.Elem(), tag)
				if err != nil {
					return err
				}
			}

			if tagName == "maxLength" {
				err := checkMaxLength(elementValue.Elem(), tag)
				if err != nil {
					return err
				}
			}
		}
	} else {
		err := validator(elementValue)
		if err != nil {
			return err
		}
	}
	return nil
}

func checkRequire(field reflect.StructField, valueField reflect.Value) error {
	name, _ := field.Tag.Lookup("json")
	if !valueField.IsNil() && valueField.IsValid() {
		return nil
	}
	return errors.New(name + " should be setted")
}

func checkPattern(valueField reflect.Value, tag string) error {
	if valueField.IsValid() && valueField.String() != "" {
		value := valueField.String()
		if match, _ := regexp.MatchString(tag, value); !match { // Determines whether the parameter value satisfies the regular expression or not, and throws an error
			return errors.New(value + " is not matched " + tag)
		}
	}
	return nil
}

func checkMaxLength(valueField reflect.Value, tag string) error {
	if valueField.IsValid() && valueField.String() != "" {
		maxLength, err := strconv.Atoi(tag)
		if err != nil {
			return err
		}
		if maxLength < valueField.Len() {
			errMsg := fmt.Sprintf("Length of %s is more than %d", valueField.String(), maxLength)
			return errors.New(errMsg)
		}
	}
	return nil
}

// Determines whether realType is in filterTypes
func isFilterType(realType string, filterTypes []string) bool {
	for _, value := range filterTypes {
		if value == realType {
			return true
		}
	}
	return false
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
	_, err := io.WriteString(h, signStr)
	if err != nil {
		return ""
	}
	signedStr := base64.StdEncoding.EncodeToString(h.Sum(nil))

	return signedStr
}

func flatRepeatedList(dataValue reflect.Value, result map[string]string, prefix string) (err error) {
	if !dataValue.IsValid() {
		return
	}

	dataType := dataValue.Type()
	if dataType.Kind().String() == "slice" {
		err = handleRepeatedParams(dataValue, result, prefix)
		if err != nil {
			return
		}
	} else if dataType.Kind().String() == "map" {
		err = handleMap(dataValue, result, prefix)
		if err != nil {
			return
		}
	} else {
		result[prefix] = fmt.Sprintf("%v", dataValue.Interface())
	}
	return
}

func handleRepeatedParams(repeatedFieldValue reflect.Value, result map[string]string, prefix string) (err error) {
	if repeatedFieldValue.IsValid() && !repeatedFieldValue.IsNil() {
		for m := 0; m < repeatedFieldValue.Len(); m++ {
			elementValue := repeatedFieldValue.Index(m)
			key := prefix + "." + strconv.Itoa(m+1)
			fieldValue := reflect.ValueOf(elementValue.Interface())
			if fieldValue.Kind().String() == "map" {
				err = handleMap(fieldValue, result, key)
				if err != nil {
					return
				}
			} else {
				result[key] = fmt.Sprintf("%v", fieldValue.Interface())
			}
		}
	}
	return nil
}

func handleMap(valueField reflect.Value, result map[string]string, prefix string) (err error) {
	if valueField.IsValid() && valueField.String() != "" {
		valueFieldType := valueField.Type()
		if valueFieldType.Kind().String() == "map" {
			var byt []byte
			byt, err = json.Marshal(valueField.Interface())
			if err != nil {
				return
			}
			cache := make(map[string]interface{})
			err = json.Unmarshal(byt, &cache)
			if err != nil {
				return
			}
			for key, value := range cache {
				pre := prefix + "." + key
				fieldValue := reflect.ValueOf(value)
				err = flatRepeatedList(fieldValue, result, pre)
				if err != nil {
					return
				}
			}
		}
	}
	return nil
}

func refreshAccessToken(domainId, refreshToken, clientId, clientSecret string) (string, string, *credentialUpdater, error) {
	request := tea.NewRequest()
	request.Protocol = "http"
	request.Method = "POST"
	request.Pathname = "/v2/oauth/token"
	request.Headers = map[string]string{
		"host":                    domainId + ".api.alicloudccp.com",
		"date":                    utils.GetRFC2616Date(),
		"content-type":            "application/x-www-form-urlencoded",
		"accept":                  "application/json",
		"x-acs-signature-method":  "HMAC-SHA1",
		"x-acs-signature-version": "1.0",
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
