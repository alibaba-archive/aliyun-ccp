package service

import (
	"encoding/json"
	"errors"
	"strings"
	"sync"
	"time"

	"github.com/alibabacloud-go/tea/tea"
)

var mutex sync.Mutex

var hookdo = func(response *tea.Response, err error) (*tea.Response, error) {
	return response, err
}

var RefreshCallbackFn = func(refreshToken string, accessToken string, expireTime string) {
}

var RefreshFailCallbackFn = func(err error) {
}

type AccessTokenCredential struct {
	AccessToken   *string
	RefreshToken  *string
	Endpoint      *string
	DomainId      *string
	ClientId      *string
	ClientSecret  *string
	ExpireTime    *int64
	ExpireTimeRaw *string
}

type Config struct {
	AccessToken  *string
	RefreshToken *string
	Endpoint     *string
	DomainId     *string
	ClientId     *string
	ClientSecret *string
	ExpireTime   *string
}

type accessTokenResponse struct {
	AccessToken  string `json:"access_token"`
	RefreshToken string `json:"refresh_token"`
	ExpireTime   string `json:"expire_time"`
}

type credentialUpdater struct {
	ExpireTime *int64
}

func NewAccessTokenCredential(config *Config) (a *AccessTokenCredential, err error) {
	a = new(AccessTokenCredential)
	a.AccessToken = config.AccessToken
	a.RefreshToken = config.RefreshToken
	a.Endpoint = config.Endpoint
	a.ClientId = config.ClientId
	a.ClientSecret = config.ClientSecret
	a.DomainId = config.DomainId
	if config.ExpireTime != nil {
		err = a.SetExpireTime(config.ExpireTime)
	}
	return a, err
}

func (a *AccessTokenCredential) SetExpireTime(expireTime *string) error {
	expiretime, err := time.Parse(time.RFC3339, tea.StringValue(expireTime))
	if err != nil {
		return err
	}
	unix := expiretime.Unix()
	a.ExpireTime = &unix
	a.ExpireTimeRaw = expireTime
	return nil
}

func (a *AccessTokenCredential) GetExpireTime() *string {
	return a.ExpireTimeRaw
}

func (a *AccessTokenCredential) SetRefreshToken(token *string) {
	a.RefreshToken = token
}

func (a *AccessTokenCredential) GetRefreshToken() *string {
	return a.RefreshToken
}

func (a *AccessTokenCredential) SetAccessToken(token *string) {
	a.AccessToken = token
}

func (a *AccessTokenCredential) GetAccessToken() (*string, error) {
	if a == nil {
		return tea.String(""), nil
	}

	mutex.Lock()
	if a.needUpdateCredential() && tea.StringValue(a.RefreshToken) != "" {
		accessToken, refreshToken, expireTimeRaw, expireTime, err :=
			refreshAccessToken(tea.StringValue(a.Endpoint), tea.StringValue(a.DomainId),
				tea.StringValue(a.RefreshToken), tea.StringValue(a.ClientId), tea.StringValue(a.ClientSecret))
		if accessToken != "" && refreshToken != "" {
			a.AccessToken = &accessToken
			a.RefreshToken = &refreshToken
			a.ExpireTime = &expireTime
			a.ExpireTimeRaw = &expireTimeRaw
			mutex.Unlock()
			return tea.String(accessToken), nil
		}
		mutex.Unlock()
		return tea.String(""), err
	} else {
		mutex.Unlock()
		return a.AccessToken, nil
	}

}

func (a *AccessTokenCredential) needUpdateCredential() bool {
	if a.ExpireTime == nil {
		return false
	}
	return *a.ExpireTime-time.Now().Unix() <= 5
}

func getRFC2616Date() string {
	gmt := time.FixedZone("GMT", 0)
	return time.Now().In(gmt).Format("Mon, 02 Jan 2006 15:04:05 GMT")
}

func refreshAccessToken(endpoint, domainId, refreshToken, clientId, clientSecret string) (string, string, string, int64, error) {
	request := tea.NewRequest()
	request.Protocol = tea.String("http")
	request.Method = tea.String("POST")
	request.Pathname = tea.String("/v2/oauth/token")
	request.Headers = map[string]string{
		"date":                    getRFC2616Date(),
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
	if err != nil {
		RefreshFailCallbackFn(err)
		return "", "", "", 0, err
	}

	body, err := response.ReadBody()
	if err != nil {
		RefreshFailCallbackFn(err)
		return "", "", "", 0, err
	}

	if tea.IntValue(response.StatusCode) != 200 {
		err = errors.New(string(body))
		RefreshFailCallbackFn(err)
		return "", "", "", 0, err
	}

	accessToken := new(accessTokenResponse)
	err = json.Unmarshal(body, &accessToken)
	if err != nil {
		RefreshFailCallbackFn(err)
		return "", "", "", 0, err
	}

	expiretime, err := time.Parse(time.RFC3339, accessToken.ExpireTime)
	if err != nil {
		RefreshFailCallbackFn(err)
		return "", "", "", 0, err
	}
	expireTime := expiretime.Unix()
	RefreshCallbackFn(accessToken.RefreshToken, accessToken.AccessToken, accessToken.ExpireTime)
	return accessToken.AccessToken, accessToken.RefreshToken, accessToken.ExpireTime, expireTime, nil
}
