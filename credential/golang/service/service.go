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
	*credentialUpdater
	AccessToken  *string
	RefreshToken *string
	Endpoint     *string
	DomainId     *string
	ClientId     *string
	ClientSecret *string
}

type accessTokenResponse struct {
	AccessToken  string `json:"access_token"`
	RefreshToken string `json:"refresh_token"`
	ExpireTime   string `json:"expire_time"`
}

type credentialUpdater struct {
	ExpireTime *int64
}

func (a *AccessTokenCredential) SetExpireTime(expireTime string) error {
	expiretime, err := time.Parse(time.RFC3339, expireTime)
	if err != nil {
		return err
	}
	unix := expiretime.Unix()
	a.ExpireTime = &unix
	return nil
}

func (a *AccessTokenCredential) GetExpireTime() string {
	if a.ExpireTime == nil {
		return ""
	}
	timeUTC := time.Unix(*a.ExpireTime, 0)
	return timeUTC.Format(time.RFC3339)
}

func (a *AccessTokenCredential) SetRefreshToken(token string) {
	a.RefreshToken = &token
}

func (a *AccessTokenCredential) GetRefreshToken() string {
	return tea.StringValue(a.RefreshToken)
}

func (a *AccessTokenCredential) SetAccessToken(token string) {
	a.AccessToken = &token
}

func (a *AccessTokenCredential) GetAccessToken() (string, error) {
	if a == nil {
		return "", nil
	}

	mutex.Lock()
	if a.needUpdateCredential() && tea.StringValue(a.RefreshToken) != "" {
		accessToken, refreshToken, update, err :=
			refreshAccessToken(tea.StringValue(a.Endpoint), tea.StringValue(a.DomainId),
				tea.StringValue(a.RefreshToken), tea.StringValue(a.ClientId), tea.StringValue(a.ClientSecret))
		if accessToken != "" && refreshToken != "" && update != nil {
			a.AccessToken = &accessToken
			a.RefreshToken = &refreshToken
			a.credentialUpdater = update
			mutex.Unlock()
			return accessToken, nil
		}
		mutex.Unlock()
		return "", err
	} else {
		mutex.Unlock()
		return tea.StringValue(a.AccessToken), nil
	}

}

func (updater *credentialUpdater) needUpdateCredential() bool {
	if updater.ExpireTime == nil {
		return false
	}
	return *updater.ExpireTime-time.Now().Unix() <= 5
}

func getRFC2616Date() string {
	gmt := time.FixedZone("GMT", 0)
	return time.Now().In(gmt).Format("Mon, 02 Jan 2006 15:04:05 GMT")
}

func refreshAccessToken(endpoint, domainId, refreshToken, clientId, clientSecret string) (string, string, *credentialUpdater, error) {
	request := tea.NewRequest()
	request.Protocol = "http"
	request.Method = "POST"
	request.Pathname = "/v2/oauth/token"
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
		return "", "", nil, err
	}

	body, err := response.ReadBody()
	if err != nil {
		RefreshFailCallbackFn(err)
		return "", "", nil, err
	}

	if response.StatusCode != 200 {
		err = errors.New(string(body))
		RefreshFailCallbackFn(err)
		return "", "", nil, err
	}

	accessToken := new(accessTokenResponse)
	err = json.Unmarshal(body, &accessToken)
	if err != nil {
		RefreshFailCallbackFn(err)
		return "", "", nil, err
	}

	expiretime, err := time.Parse(time.RFC3339, accessToken.ExpireTime)
	if err != nil {
		RefreshFailCallbackFn(err)
		return "", "", nil, err
	}
	expireTime := expiretime.Unix()
	update := &credentialUpdater{
		ExpireTime: &expireTime,
	}
	RefreshCallbackFn(accessToken.RefreshToken, accessToken.AccessToken, accessToken.ExpireTime)
	return accessToken.AccessToken, accessToken.RefreshToken, update, nil
}
