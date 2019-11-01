package service

import (
	"io/ioutil"
	"net/http"
	"strings"
	"testing"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/aliyun-ccp/baseclient/go/utils"
)

var client *BaseClient

type configTest struct {
	AccessKeyId *string `json:"accesskeyid"`
}

func Test_InitClient(t *testing.T) {
	config := map[string]string{
		"accessKeyId":     "AccessKeyId",
		"accessKeySecret": "AccessKeySecret",
		"credentialType":  "no",
	}
	client = new(BaseClient)
	err := client.InitClient(config)
	utils.AssertEqual(t, "Invalid type option, support: access_key, sts, ecs_ram_role, ram_role_arn, rsa_key_pair", err.Error())

	accessKeyId, err := client.GetAccessKeyId()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "", accessKeyId)

	accessKeySecret, err := client.GetAccessKeySecret()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "", accessKeySecret)

	config = map[string]string{
		"accessKeyId":     "AccessKeyId",
		"accessKeySecret": "AccessKeySecret",
		"refreshToken":    "refreshToken",
		"expireTime":      "2006-01-T15:04:05Z",
	}
	err = client.InitClient(config)
	utils.AssertEqual(t, `parsing time "2006-01-T15:04:05Z" as "2006-01-02T15:04:05Z07:00": cannot parse "T15:04:05Z" as "02"`, err.Error())

	config = map[string]string{
		"accessKeyId":     "AccessKeyId",
		"accessKeySecret": "AccessKeySecret",
		"refreshToken":    "refreshToken",
		"expireTime":      "2006-01-02T15:04:05Z",
		"securityToken":   "securityToken",
		"credentialType":  "sts",
	}
	err = client.InitClient(config)
	utils.AssertNil(t, err)

	accessKeyId, err = client.GetAccessKeyId()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "AccessKeyId", accessKeyId)

	accessKeySecret, err = client.GetAccessKeySecret()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "AccessKeySecret", accessKeySecret)
}

func Test_Validator(t *testing.T) {
	str := "AccessKeyId"
	config := &configTest{
		AccessKeyId: &str,
	}
	err := client.Validator(config)
	utils.AssertNil(t, err)
}

func Test_GetProtocol(t *testing.T) {
	protocol := client.GetProtocol("", "defaultValue")
	utils.AssertEqual(t, "defaultValue", protocol)

	protocol = client.GetProtocol("protocol", "defaultValue")
	utils.AssertEqual(t, "protocol", protocol)
}

func Test_GetHost(t *testing.T) {
	host := client.GetHost("", "defaultValue")
	utils.AssertEqual(t, "defaultValue", host)

	host = client.GetHost("host", "defaultValue")
	utils.AssertEqual(t, "host", host)
}

func Test_NotEmpty(t *testing.T) {
	isEmpty := client.NotEmpty("")
	utils.AssertEqual(t, false, isEmpty)

	isEmpty = client.NotEmpty("host")
	utils.AssertEqual(t, true, isEmpty)
}

func Test_GetRFC2616Date(t *testing.T) {
	time := client.GetRFC2616Date()
	utils.AssertEqual(t, 29, len(time))
}

func Test_GetSignature(t *testing.T) {
	request := tea.NewRequest()
	signature := client.GetSignature(request)
	utils.AssertEqual(t, 28, len(signature))
}

func Test_ToJSONString(t *testing.T) {
	body := client.ToJSONString("ccp")
	byt, err := ioutil.ReadAll(body)
	utils.AssertNil(t, err)
	utils.AssertEqual(t, "\"ccp\"", string(byt))
}

func Test_IsStatusCode(t *testing.T) {
	response := &tea.Response{
		StatusCode: 200,
	}
	isEqual := client.IsStatusCode(response, 200)
	utils.AssertEqual(t, true, isEqual)
}

func Test_ToQuery(t *testing.T) {
	input := map[string]string{
		"key":   "ccp",
		"value": "ok",
	}
	out := client.ToQuery(input)
	utils.AssertEqual(t, "ccp", out["key"])
	utils.AssertEqual(t, "ok", out["value"])
}

func Test_ReadAsJSON(t *testing.T) {
	body := client.ToJSONString("ccp")
	readCloser := ioutil.NopCloser(body)
	httpResponse := &http.Response{
		Body: readCloser,
	}
	response := tea.NewResponse(httpResponse)
	result := client.ReadAsJSON(response)
	utils.AssertEqual(t, 0, len(result))

	body = client.ToJSONString(map[string]string{
		"key": "ccp",
	})
	readCloser = ioutil.NopCloser(body)
	httpResponse.Body = readCloser
	response = tea.NewResponse(httpResponse)
	result = client.ReadAsJSON(response)
	utils.AssertEqual(t, 1, len(result))
}

func Test_Default(t *testing.T) {
	num := client.DefaultNumber(1, 2)
	utils.AssertEqual(t, 1, num)

	num = client.DefaultNumber(0, 2)
	utils.AssertEqual(t, 2, num)

	str := client.Default("1", "2")
	utils.AssertEqual(t, "1", str)

	str = client.Default("", "2")
	utils.AssertEqual(t, "2", str)
}

func Test_GetAccessToken(t *testing.T) {
	originhook := hookdo
	defer func() {
		hookdo = originhook
	}()

	hookdo = func(resp *tea.Response, err error) (*tea.Response, error) {
		tmp := `{"expires_time": "2006-01-T15:04:05Z"}`
		httpresponse := &http.Response{
			StatusCode: 200,
			Body:       ioutil.NopCloser(strings.NewReader(tmp)),
		}
		resp = tea.NewResponse(httpresponse)
		return resp, nil
	}
	accesstoken, err := client.GetSysAccessToken()
	utils.AssertEqual(t, err.Error(), `parsing time "2006-01-T15:04:05Z" as "2006-01-02T15:04:05Z07:00": cannot parse "T15:04:05Z" as "02"`)
	utils.AssertEqual(t, accesstoken, "")

	hookdo = func(resp *tea.Response, err error) (*tea.Response, error) {
		tmp := `{"expires_time": "2006-01-02T15:04:05Z","access_token":"access_token","refresh_token":"refresh_token"}`
		httpresponse := &http.Response{
			StatusCode: 200,
			Body:       ioutil.NopCloser(strings.NewReader(tmp)),
		}
		resp = tea.NewResponse(httpresponse)
		return resp, nil
	}
	accesstoken, err = client.GetSysAccessToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, accesstoken, "access_token")

	client.accessToken.ExpireTime = nil
	accesstoken, err = client.GetSysAccessToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, accesstoken, "access_token")

	client.accessToken.AccessToken = ""
	accesstoken, err = client.GetSysAccessToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, accesstoken, "")

	client.accessToken = nil
	accesstoken, err = client.GetSysAccessToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, accesstoken, "")
}

func Test_Expiretimme(t *testing.T) {
	client.accessToken = nil
	err := client.SetExpireTime("2006-01-T15:04:05Z")
	utils.AssertContains(t, err.Error(), `parsing time "2006-01-T15:04:05Z" as "2006-01-02T15:04:05Z07:00"`)

	expiretime := client.GetExpireTime()
	utils.AssertEqual(t, expiretime, "")

	err = client.SetExpireTime("2006-01-02T15:04:05Z")
	utils.AssertNil(t, err)

	expiretime = client.GetExpireTime()
	utils.AssertEqual(t, expiretime, "2006-01-02T23:04:05+08:00")

	client.accessToken = nil
	refreshtoken := client.GetRefreshToken()
	utils.AssertEqual(t, refreshtoken, "")

	client.SetRefreshToken("refreshtoken")
	refreshtoken = client.GetRefreshToken()
	utils.AssertEqual(t, refreshtoken, "refreshtoken")

	client.accessToken = nil
	client.SetAccessToken("accesstoken")
	utils.AssertEqual(t, client.accessToken.AccessToken, "accesstoken")
}
