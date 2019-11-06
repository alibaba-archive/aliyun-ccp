package service

import (
	"encoding/json"
	"fmt"
	"io"
	"reflect"
	"runtime"
	"strings"
	"time"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/aliyun-ccp/baseclient/go/utils"
	"github.com/aliyun/credentials-go/credentials"
)

var defaultUserAgent = fmt.Sprintf("AlibabaCloud (%s; %s) Golang/%s Core/%s", runtime.GOOS, runtime.GOARCH, strings.Trim(runtime.Version(), "go"), "0.01")

type BaseClient struct {
	RegionId     string `json:"regionId" xml:"regionId"`
	Protocol     string `json:"protocol" xml:"protocol"`
	Endpoint     string `json:"endpoint" xml:"endpoint"`
	DomainId     string `json:"domainId" xml:"domainId"`
	ClientId     string `json:"clientId" xml:"clientId"`
	UserAgent    string `json:"useragent" xml:"useragent"`
	ClientSecret string `json:"clientSecret" xml:"clientSecret"`
	credential   credentials.Credential
	accessToken  *AccessTokenCredential
}

type AccessTokenCredential struct {
	*credentialUpdater
	AccessToken  string
	RefreshToken string
}

func (client *BaseClient) InitClient(config map[string]string) error {
	byt, _ := json.Marshal(config)
	err := json.Unmarshal(byt, &client)
	if err != nil {
		return err
	}

	configuration := &credentials.Configuration{
		Type:            config["credentialType"],
		AccessKeyID:     config["accessKeyId"],
		AccessKeySecret: config["accessKeySecret"],
		SecurityToken:   config["securityToken"],
	}
	if configuration.Type == "" {
		configuration.Type = "access_key"
	}
	if configuration.AccessKeyID != "" && configuration.AccessKeySecret != "" {
		credential, err := credentials.NewCredential(configuration)
		if err != nil {
			return err
		}
		client.credential = credential
	}

	if config["refreshToken"] != "" || config["accessToken"] != "" {
		client.accessToken = &AccessTokenCredential{
			RefreshToken:      config["refreshToken"],
			AccessToken:       config["accessToken"],
			credentialUpdater: new(credentialUpdater),
		}
		if config["expireTime"] != "" {
			expiretime, err := time.Parse(time.RFC3339, config["expireTime"])
			if err != nil {
				return err
			}
			unix := expiretime.Unix()
			client.accessToken.credentialUpdater.ExpireTime = &unix
		}
	}
	return nil
}

func (client *BaseClient) SetExpireTime(expireTime string) error {
	if client.accessToken == nil {
		client.accessToken = &AccessTokenCredential{
			credentialUpdater: new(credentialUpdater),
		}
	}
	expiretime, err := time.Parse(time.RFC3339, expireTime)
	if err != nil {
		return err
	}
	unix := expiretime.Unix()
	client.accessToken.credentialUpdater.ExpireTime = &unix
	return nil
}

func (client *BaseClient) SetUserAgent(useragent string) {
	client.UserAgent = useragent
}

func (client *BaseClient) AppendUserAgent(useragent string) {
	client.UserAgent = client.UserAgent + " " + useragent
}

func (client *BaseClient) GetUserAgent() string {
	if client.UserAgent != "" {
		return defaultUserAgent + " " + client.UserAgent
	}
	return defaultUserAgent
}

func (client *BaseClient) GetExpireTime() string {
	if client.accessToken == nil || client.accessToken.ExpireTime == nil {
		return ""
	}
	timeUTC := time.Unix(*client.accessToken.ExpireTime, 0)
	return timeUTC.Format(time.RFC3339)
}

func (client *BaseClient) SetRefreshToken(token string) {
	if client.accessToken == nil {
		client.accessToken = &AccessTokenCredential{
			credentialUpdater: new(credentialUpdater),
		}
	}
	client.accessToken.RefreshToken = token
}

func (client *BaseClient) GetRefreshToken() string {
	if client.accessToken == nil {
		return ""
	}
	return client.accessToken.RefreshToken
}

func (client *BaseClient) SetAccessToken(token string) {
	if client.accessToken == nil {
		client.accessToken = &AccessTokenCredential{
			credentialUpdater: new(credentialUpdater),
		}
	}
	client.accessToken.AccessToken = token
}

// Verify whether the parameters meet the requirements
func (client *BaseClient) Validator(params interface{}) error {
	requestValue := reflect.ValueOf(params).Elem()
	err := validator(requestValue)
	return err
}

func (client *BaseClient) GetProtocol(protocol, defaultValue string) string {
	if protocol != "" {
		return protocol
	}
	return defaultValue
}

func (client *BaseClient) GetHost(host, defaultValue string) string {
	if host != "" {
		return host
	}
	return defaultValue
}

func (client *BaseClient) NotEmpty(value string) bool {
	return value != ""
}

func (client *BaseClient) GetRFC2616Date() string {
	time := utils.GetRFC2616Date()
	return time
}

func (client *BaseClient) GetSignature(request *tea.Request) string {
	token, err := client.credential.GetSecurityToken()
	if err == nil && token != "" {
		request.Headers["x-acs-security-token"] = token
	}

	secret, _ := client.GetAccessKeySecret()
	return getSignature(request, secret)
}

func (client *BaseClient) GetAccessKeyId() (string, error) {
	if client.credential == nil {
		return "", nil
	}
	accesskey, _ := client.credential.GetAccessKeyID()
	return accesskey, nil
}

func (client *BaseClient) GetAccessToken() (string, error) {
	if client.accessToken == nil {
		return "", nil
	}
	if client.accessToken.AccessToken != "" && !client.accessToken.needUpdateCredential() {
		return client.accessToken.AccessToken, nil
	}

	if client.accessToken.needUpdateCredential() && client.accessToken.RefreshToken != "" {
		accessToken, refreshToken, update, err := refreshAccessToken(client.Endpoint, client.DomainId, client.accessToken.RefreshToken, client.ClientId, client.ClientSecret)
		if accessToken != "" && refreshToken != "" && update != nil {
			client.accessToken.AccessToken = accessToken
			client.accessToken.RefreshToken = refreshToken
			client.accessToken.credentialUpdater = update
			return accessToken, nil
		}
		return "", err
	}

	return "", nil
}

func (client *BaseClient) GetAccessKeySecret() (string, error) {
	if client.credential == nil {
		return "", nil
	}
	secret, _ := client.credential.GetAccessSecret()
	return secret, nil
}

func (client *BaseClient) ToJSONString(request interface{}) io.Reader {
	byt, _ := json.Marshal(request)

	return strings.NewReader(string(byt))
}

func (client *BaseClient) IsStatusCode(response *tea.Response, code int) bool {
	return response.StatusCode == code
}

func (client *BaseClient) ToQuery(request interface{}) map[string]string {
	tmp := make(map[string]interface{})
	byt, _ := json.Marshal(request)
	_ = json.Unmarshal(byt, &tmp)

	result := make(map[string]string)
	for key, value := range tmp {
		filterValue := reflect.ValueOf(value)
		flatRepeatedList(filterValue, result, key)
	}

	return result
}

func (client *BaseClient) ReadAsJSON(response *tea.Response) map[string]interface{} {
	tmp := make(map[string]interface{})
	body, err := response.ReadBody()
	if err != nil {
		return tmp
	}

	err = json.Unmarshal(body, &tmp)
	if err != nil {
		return tmp
	}
	return tmp
}

func (client *BaseClient) DefaultNumber(realNum, defaultNum int) int {
	if realNum == 0 {
		return defaultNum
	}

	return realNum
}

func (client *BaseClient) Default(realStr, defaultStr string) string {
	if realStr == "" {
		return defaultStr
	}

	return realStr
}
