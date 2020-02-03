package service

import (
	"io/ioutil"
	"net/http"
	"strings"
	"sync"
	"testing"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/aliyun/aliyun-ccp/baseclient/go/utils"
)

var client *BaseClient

func Test_InitClient(t *testing.T) {
	config := map[string]interface{}{
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

	config = map[string]interface{}{
		"accessKeyId":     "AccessKeyId",
		"accessKeySecret": "AccessKeySecret",
		"refreshToken":    "refreshToken",
		"expireTime":      "2006-01-T15:04:05Z",
	}
	err = client.InitClient(config)
	utils.AssertEqual(t, `parsing time "2006-01-T15:04:05Z" as "2006-01-02T15:04:05Z07:00": cannot parse "T15:04:05Z" as "02"`, err.Error())

	config = map[string]interface{}{
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

func Test_GetPathname(t *testing.T) {
	pathName := client.GetPathname("", "/v2")
	utils.AssertEqual(t, "/v2", pathName)

	pathName = client.GetPathname("ccp", "/v2")
	utils.AssertEqual(t, "/ccp/v2", pathName)
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
	input := map[string]interface{}{
		"key":    "ccp",
		"value":  "ok",
		"number": 1,
	}
	out := client.ToQuery(input)
	utils.AssertEqual(t, "ccp", out["key"])
	utils.AssertEqual(t, "ok", out["value"])
	utils.AssertEqual(t, "1", out["number"])
}

func Test_ReadAsJSON(t *testing.T) {
	body := client.ToJSONString("ccp")
	readCloser := ioutil.NopCloser(body)
	httpResponse := &http.Response{
		Body: readCloser,
	}
	response := tea.NewResponse(httpResponse)
	result, err := client.ReadAsJSON(response)
	utils.AssertNotNil(t, err)
	utils.AssertEqual(t, 0, len(result))

	body = client.ToJSONString(map[string]string{
		"key": "ccp",
	})
	readCloser = ioutil.NopCloser(body)
	httpResponse.Body = readCloser
	response = tea.NewResponse(httpResponse)
	result, err = client.ReadAsJSON(response)
	utils.AssertNil(t, err)
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

func Test_RefreshTokenWithConcurrent(t *testing.T) {
	originTestHookDo := hookdo
	defer func() { hookdo = originTestHookDo }()
	hookdo = func(resp *tea.Response, err error) (*tea.Response, error) {
		tmp := `{"expire_time": "2006-01-02T15:04:05Z","access_token":"access_token","refresh_token":"refresh_token"}`
		httpresponse := &http.Response{
			StatusCode: 200,
			Body:       ioutil.NopCloser(strings.NewReader(tmp)),
		}
		resp = tea.NewResponse(httpresponse)
		return resp, nil
	}
	originTest := RefreshCallbackFn
	var refre, access, expire string
	defer func() { RefreshCallbackFn = originTest }()
	RefreshCallbackFn = func(refreshToken, accessToken, expireTime string) {
		refre = refreshToken
		access = accessToken
		expire = expireTime
		return
	}
	var wg sync.WaitGroup
	for i := 0; i < 50; i++ {
		wg.Add(1)
		go func() {
			accesstoken, err := client.GetAccessToken()
			utils.AssertNil(t, err)
			utils.AssertEqual(t, "access_token", accesstoken)
			wg.Done()
		}()
	}
	wg.Wait()
	utils.AssertEqual(t, "refresh_token", refre)
	utils.AssertEqual(t, "access_token", access)
	utils.AssertEqual(t, "2006-01-02T15:04:05Z", expire)
}

func Test_GetAccessToken(t *testing.T) {
	originhook := hookdo
	defer func() {
		hookdo = originhook
	}()

	originTest := RefreshFailCallbackFn
	var err1 error
	defer func() { RefreshFailCallbackFn = originTest }()
	RefreshFailCallbackFn = func(err error) {
		err1 = err
		return
	}

	hookdo = func(resp *tea.Response, err error) (*tea.Response, error) {
		tmp := `{"expire_time": "2006-01-T15:04:05Z"}`
		httpresponse := &http.Response{
			StatusCode: 200,
			Body:       ioutil.NopCloser(strings.NewReader(tmp)),
		}
		resp = tea.NewResponse(httpresponse)
		return resp, nil
	}
	accesstoken, err := client.GetAccessToken()
	utils.AssertEqual(t, err.Error(), `parsing time "2006-01-T15:04:05Z" as "2006-01-02T15:04:05Z07:00": cannot parse "T15:04:05Z" as "02"`)
	utils.AssertEqual(t, accesstoken, "")
	utils.AssertEqual(t, err1.Error(), `parsing time "2006-01-T15:04:05Z" as "2006-01-02T15:04:05Z07:00": cannot parse "T15:04:05Z" as "02"`)

	hookdo = func(resp *tea.Response, err error) (*tea.Response, error) {
		tmp := `{"expire_time": "2006-01-02T15:04:05Z","access_token":"access_token","refresh_token":"refresh_token"}`
		httpresponse := &http.Response{
			StatusCode: 200,
			Body:       ioutil.NopCloser(strings.NewReader(tmp)),
		}
		resp = tea.NewResponse(httpresponse)
		return resp, nil
	}
	accesstoken, err = client.GetAccessToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, accesstoken, "access_token")

	client.accessToken.ExpireTime = nil
	accesstoken, err = client.GetAccessToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, accesstoken, "access_token")

	client.accessToken.AccessToken = ""
	accesstoken, err = client.GetAccessToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, accesstoken, "")

	client.accessToken = nil
	accesstoken, err = client.GetAccessToken()
	utils.AssertNil(t, err)
	utils.AssertEqual(t, accesstoken, "")
}

func Test_UserAgent(t *testing.T) {
	utils.AssertContains(t, client.GetUserAgent(), "AlibabaCloud")

	client.SetUserAgent("test")
	utils.AssertContains(t, client.GetUserAgent(), "test")

	client.AppendUserAgent("ccp")
	utils.AssertContains(t, client.GetUserAgent(), "test ccp")
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
	utils.AssertContains(t, expiretime, "2006-01-02T")

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
