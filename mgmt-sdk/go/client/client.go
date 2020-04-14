// This file is auto-generated, don't edit it. Thanks.
/**
 *
 */
package client

import (
	"github.com/alibabacloud-go/tea/tea"
	credential "github.com/aliyun/credentials-go/credentials"
	roautil "github.com/aliyun/tea-roa-util/golang/service"
	util "github.com/aliyun/tea-util/golang/service"
)

type RuntimeOptions struct {
	Autoretry      *bool   `json:"autoretry" xml:"autoretry"`
	IgnoreSSL      *bool   `json:"ignoreSSL" xml:"ignoreSSL"`
	MaxAttempts    *int    `json:"maxAttempts" xml:"maxAttempts"`
	BackoffPolicy  *string `json:"backoffPolicy" xml:"backoffPolicy"`
	BackoffPeriod  *int    `json:"backoffPeriod" xml:"backoffPeriod"`
	ReadTimeout    *int    `json:"readTimeout" xml:"readTimeout"`
	ConnectTimeout *int    `json:"connectTimeout" xml:"connectTimeout"`
	HttpProxy      *string `json:"httpProxy" xml:"httpProxy"`
	HttpsProxy     *string `json:"httpsProxy" xml:"httpsProxy"`
	NoProxy        *string `json:"noProxy" xml:"noProxy"`
	MaxIdleConns   *int    `json:"maxIdleConns" xml:"maxIdleConns"`
	LocalAddr      *string `json:"localAddr" xml:"localAddr"`
	Socks5Proxy    *string `json:"socks5Proxy" xml:"socks5Proxy"`
	Socks5NetWork  *string `json:"socks5NetWork" xml:"socks5NetWork"`
}

func (s RuntimeOptions) String() string {
	return tea.Prettify(s)
}

func (s RuntimeOptions) GoString() string {
	return s.String()
}

func (s *RuntimeOptions) SetAutoretry(v bool) *RuntimeOptions {
	s.Autoretry = &v
	return s
}

func (s *RuntimeOptions) SetIgnoreSSL(v bool) *RuntimeOptions {
	s.IgnoreSSL = &v
	return s
}

func (s *RuntimeOptions) SetMaxAttempts(v int) *RuntimeOptions {
	s.MaxAttempts = &v
	return s
}

func (s *RuntimeOptions) SetBackoffPolicy(v string) *RuntimeOptions {
	s.BackoffPolicy = &v
	return s
}

func (s *RuntimeOptions) SetBackoffPeriod(v int) *RuntimeOptions {
	s.BackoffPeriod = &v
	return s
}

func (s *RuntimeOptions) SetReadTimeout(v int) *RuntimeOptions {
	s.ReadTimeout = &v
	return s
}

func (s *RuntimeOptions) SetConnectTimeout(v int) *RuntimeOptions {
	s.ConnectTimeout = &v
	return s
}

func (s *RuntimeOptions) SetHttpProxy(v string) *RuntimeOptions {
	s.HttpProxy = &v
	return s
}

func (s *RuntimeOptions) SetHttpsProxy(v string) *RuntimeOptions {
	s.HttpsProxy = &v
	return s
}

func (s *RuntimeOptions) SetNoProxy(v string) *RuntimeOptions {
	s.NoProxy = &v
	return s
}

func (s *RuntimeOptions) SetMaxIdleConns(v int) *RuntimeOptions {
	s.MaxIdleConns = &v
	return s
}

func (s *RuntimeOptions) SetLocalAddr(v string) *RuntimeOptions {
	s.LocalAddr = &v
	return s
}

func (s *RuntimeOptions) SetSocks5Proxy(v string) *RuntimeOptions {
	s.Socks5Proxy = &v
	return s
}

func (s *RuntimeOptions) SetSocks5NetWork(v string) *RuntimeOptions {
	s.Socks5NetWork = &v
	return s
}

type Config struct {
	Endpoint        *string `json:"endpoint" xml:"endpoint"`
	Region          *string `json:"region" xml:"region"`
	Protocol        *string `json:"protocol" xml:"protocol"`
	Type            *string `json:"type" xml:"type"`
	SecurityToken   *string `json:"securityToken" xml:"securityToken"`
	AccessKeyId     *string `json:"accessKeyId" xml:"accessKeyId"`
	AccessKeySecret *string `json:"accessKeySecret" xml:"accessKeySecret"`
	Nickname        *string `json:"nickname" xml:"nickname"`
	UserAgent       *string `json:"userAgent" xml:"userAgent"`
}

func (s Config) String() string {
	return tea.Prettify(s)
}

func (s Config) GoString() string {
	return s.String()
}

func (s *Config) SetEndpoint(v string) *Config {
	s.Endpoint = &v
	return s
}

func (s *Config) SetRegion(v string) *Config {
	s.Region = &v
	return s
}

func (s *Config) SetProtocol(v string) *Config {
	s.Protocol = &v
	return s
}

func (s *Config) SetType(v string) *Config {
	s.Type = &v
	return s
}

func (s *Config) SetSecurityToken(v string) *Config {
	s.SecurityToken = &v
	return s
}

func (s *Config) SetAccessKeyId(v string) *Config {
	s.AccessKeyId = &v
	return s
}

func (s *Config) SetAccessKeySecret(v string) *Config {
	s.AccessKeySecret = &v
	return s
}

func (s *Config) SetNickname(v string) *Config {
	s.Nickname = &v
	return s
}

func (s *Config) SetUserAgent(v string) *Config {
	s.UserAgent = &v
	return s
}

type CreateAppRequestModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *CreateAppRequest `json:"body" xml:"body" require:"true"`
}

func (s CreateAppRequestModel) String() string {
	return tea.Prettify(s)
}

func (s CreateAppRequestModel) GoString() string {
	return s.String()
}

func (s *CreateAppRequestModel) SetHeaders(v map[string]string) *CreateAppRequestModel {
	s.Headers = v
	return s
}

func (s *CreateAppRequestModel) SetBody(v *CreateAppRequest) *CreateAppRequestModel {
	s.Body = v
	return s
}

type CreateAppModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *GetAppResponse   `json:"body" xml:"body" require:"true"`
}

func (s CreateAppModel) String() string {
	return tea.Prettify(s)
}

func (s CreateAppModel) GoString() string {
	return s.String()
}

func (s *CreateAppModel) SetHeaders(v map[string]string) *CreateAppModel {
	s.Headers = v
	return s
}

func (s *CreateAppModel) SetBody(v *GetAppResponse) *CreateAppModel {
	s.Body = v
	return s
}

type DeleteAppRequestModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *DeleteAppRequest `json:"body" xml:"body" require:"true"`
}

func (s DeleteAppRequestModel) String() string {
	return tea.Prettify(s)
}

func (s DeleteAppRequestModel) GoString() string {
	return s.String()
}

func (s *DeleteAppRequestModel) SetHeaders(v map[string]string) *DeleteAppRequestModel {
	s.Headers = v
	return s
}

func (s *DeleteAppRequestModel) SetBody(v *DeleteAppRequest) *DeleteAppRequestModel {
	s.Body = v
	return s
}

type DeleteAppModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
}

func (s DeleteAppModel) String() string {
	return tea.Prettify(s)
}

func (s DeleteAppModel) GoString() string {
	return s.String()
}

func (s *DeleteAppModel) SetHeaders(v map[string]string) *DeleteAppModel {
	s.Headers = v
	return s
}

type GetAppRequestModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *GetAppRequest    `json:"body" xml:"body" require:"true"`
}

func (s GetAppRequestModel) String() string {
	return tea.Prettify(s)
}

func (s GetAppRequestModel) GoString() string {
	return s.String()
}

func (s *GetAppRequestModel) SetHeaders(v map[string]string) *GetAppRequestModel {
	s.Headers = v
	return s
}

func (s *GetAppRequestModel) SetBody(v *GetAppRequest) *GetAppRequestModel {
	s.Body = v
	return s
}

type GetAppModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *GetAppResponse   `json:"body" xml:"body" require:"true"`
}

func (s GetAppModel) String() string {
	return tea.Prettify(s)
}

func (s GetAppModel) GoString() string {
	return s.String()
}

func (s *GetAppModel) SetHeaders(v map[string]string) *GetAppModel {
	s.Headers = v
	return s
}

func (s *GetAppModel) SetBody(v *GetAppResponse) *GetAppModel {
	s.Body = v
	return s
}

type GetPublicKeyRequestModel struct {
	Headers map[string]string       `json:"headers" xml:"headers"`
	Body    *GetAppPublicKeyRequest `json:"body" xml:"body" require:"true"`
}

func (s GetPublicKeyRequestModel) String() string {
	return tea.Prettify(s)
}

func (s GetPublicKeyRequestModel) GoString() string {
	return s.String()
}

func (s *GetPublicKeyRequestModel) SetHeaders(v map[string]string) *GetPublicKeyRequestModel {
	s.Headers = v
	return s
}

func (s *GetPublicKeyRequestModel) SetBody(v *GetAppPublicKeyRequest) *GetPublicKeyRequestModel {
	s.Body = v
	return s
}

type GetPublicKeyModel struct {
	Headers map[string]string        `json:"headers" xml:"headers"`
	Body    *GetAppPublicKeyResponse `json:"body" xml:"body" require:"true"`
}

func (s GetPublicKeyModel) String() string {
	return tea.Prettify(s)
}

func (s GetPublicKeyModel) GoString() string {
	return s.String()
}

func (s *GetPublicKeyModel) SetHeaders(v map[string]string) *GetPublicKeyModel {
	s.Headers = v
	return s
}

func (s *GetPublicKeyModel) SetBody(v *GetAppPublicKeyResponse) *GetPublicKeyModel {
	s.Body = v
	return s
}

type ListAppRequestModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *ListAppsRequest  `json:"body" xml:"body" require:"true"`
}

func (s ListAppRequestModel) String() string {
	return tea.Prettify(s)
}

func (s ListAppRequestModel) GoString() string {
	return s.String()
}

func (s *ListAppRequestModel) SetHeaders(v map[string]string) *ListAppRequestModel {
	s.Headers = v
	return s
}

func (s *ListAppRequestModel) SetBody(v *ListAppsRequest) *ListAppRequestModel {
	s.Body = v
	return s
}

type ListAppModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *ListAppsResponse `json:"body" xml:"body" require:"true"`
}

func (s ListAppModel) String() string {
	return tea.Prettify(s)
}

func (s ListAppModel) GoString() string {
	return s.String()
}

func (s *ListAppModel) SetHeaders(v map[string]string) *ListAppModel {
	s.Headers = v
	return s
}

func (s *ListAppModel) SetBody(v *ListAppsResponse) *ListAppModel {
	s.Body = v
	return s
}

type ListPublishedAppRequestModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *ListAppsRequest  `json:"body" xml:"body" require:"true"`
}

func (s ListPublishedAppRequestModel) String() string {
	return tea.Prettify(s)
}

func (s ListPublishedAppRequestModel) GoString() string {
	return s.String()
}

func (s *ListPublishedAppRequestModel) SetHeaders(v map[string]string) *ListPublishedAppRequestModel {
	s.Headers = v
	return s
}

func (s *ListPublishedAppRequestModel) SetBody(v *ListAppsRequest) *ListPublishedAppRequestModel {
	s.Body = v
	return s
}

type ListPublishedAppModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *ListAppsResponse `json:"body" xml:"body" require:"true"`
}

func (s ListPublishedAppModel) String() string {
	return tea.Prettify(s)
}

func (s ListPublishedAppModel) GoString() string {
	return s.String()
}

func (s *ListPublishedAppModel) SetHeaders(v map[string]string) *ListPublishedAppModel {
	s.Headers = v
	return s
}

func (s *ListPublishedAppModel) SetBody(v *ListAppsResponse) *ListPublishedAppModel {
	s.Body = v
	return s
}

type SetPublicKeyRequestModel struct {
	Headers map[string]string       `json:"headers" xml:"headers"`
	Body    *GetAppPublicKeyRequest `json:"body" xml:"body" require:"true"`
}

func (s SetPublicKeyRequestModel) String() string {
	return tea.Prettify(s)
}

func (s SetPublicKeyRequestModel) GoString() string {
	return s.String()
}

func (s *SetPublicKeyRequestModel) SetHeaders(v map[string]string) *SetPublicKeyRequestModel {
	s.Headers = v
	return s
}

func (s *SetPublicKeyRequestModel) SetBody(v *GetAppPublicKeyRequest) *SetPublicKeyRequestModel {
	s.Body = v
	return s
}

type SetPublicKeyModel struct {
	Headers map[string]string        `json:"headers" xml:"headers"`
	Body    *GetAppPublicKeyResponse `json:"body" xml:"body" require:"true"`
}

func (s SetPublicKeyModel) String() string {
	return tea.Prettify(s)
}

func (s SetPublicKeyModel) GoString() string {
	return s.String()
}

func (s *SetPublicKeyModel) SetHeaders(v map[string]string) *SetPublicKeyModel {
	s.Headers = v
	return s
}

func (s *SetPublicKeyModel) SetBody(v *GetAppPublicKeyResponse) *SetPublicKeyModel {
	s.Body = v
	return s
}

type UpdateAppRequestModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *UpdateAppRequest `json:"body" xml:"body" require:"true"`
}

func (s UpdateAppRequestModel) String() string {
	return tea.Prettify(s)
}

func (s UpdateAppRequestModel) GoString() string {
	return s.String()
}

func (s *UpdateAppRequestModel) SetHeaders(v map[string]string) *UpdateAppRequestModel {
	s.Headers = v
	return s
}

func (s *UpdateAppRequestModel) SetBody(v *UpdateAppRequest) *UpdateAppRequestModel {
	s.Body = v
	return s
}

type UpdateAppModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *GetAppResponse   `json:"body" xml:"body" require:"true"`
}

func (s UpdateAppModel) String() string {
	return tea.Prettify(s)
}

func (s UpdateAppModel) GoString() string {
	return s.String()
}

func (s *UpdateAppModel) SetHeaders(v map[string]string) *UpdateAppModel {
	s.Headers = v
	return s
}

func (s *UpdateAppModel) SetBody(v *GetAppResponse) *UpdateAppModel {
	s.Body = v
	return s
}

type AddStoreRequestModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *AddStoreRequest  `json:"body" xml:"body" require:"true"`
}

func (s AddStoreRequestModel) String() string {
	return tea.Prettify(s)
}

func (s AddStoreRequestModel) GoString() string {
	return s.String()
}

func (s *AddStoreRequestModel) SetHeaders(v map[string]string) *AddStoreRequestModel {
	s.Headers = v
	return s
}

func (s *AddStoreRequestModel) SetBody(v *AddStoreRequest) *AddStoreRequestModel {
	s.Body = v
	return s
}

type AddStoreModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *AddStoreResponse `json:"body" xml:"body" require:"true"`
}

func (s AddStoreModel) String() string {
	return tea.Prettify(s)
}

func (s AddStoreModel) GoString() string {
	return s.String()
}

func (s *AddStoreModel) SetHeaders(v map[string]string) *AddStoreModel {
	s.Headers = v
	return s
}

func (s *AddStoreModel) SetBody(v *AddStoreResponse) *AddStoreModel {
	s.Body = v
	return s
}

type CreateDomainRequestModel struct {
	Headers map[string]string    `json:"headers" xml:"headers"`
	Body    *CreateDomainRequest `json:"body" xml:"body" require:"true"`
}

func (s CreateDomainRequestModel) String() string {
	return tea.Prettify(s)
}

func (s CreateDomainRequestModel) GoString() string {
	return s.String()
}

func (s *CreateDomainRequestModel) SetHeaders(v map[string]string) *CreateDomainRequestModel {
	s.Headers = v
	return s
}

func (s *CreateDomainRequestModel) SetBody(v *CreateDomainRequest) *CreateDomainRequestModel {
	s.Body = v
	return s
}

type CreateDomainModel struct {
	Headers map[string]string     `json:"headers" xml:"headers"`
	Body    *CreateDomainResponse `json:"body" xml:"body" require:"true"`
}

func (s CreateDomainModel) String() string {
	return tea.Prettify(s)
}

func (s CreateDomainModel) GoString() string {
	return s.String()
}

func (s *CreateDomainModel) SetHeaders(v map[string]string) *CreateDomainModel {
	s.Headers = v
	return s
}

func (s *CreateDomainModel) SetBody(v *CreateDomainResponse) *CreateDomainModel {
	s.Body = v
	return s
}

type DeleteDomainRequestModel struct {
	Headers map[string]string    `json:"headers" xml:"headers"`
	Body    *DeleteDomainRequest `json:"body" xml:"body" require:"true"`
}

func (s DeleteDomainRequestModel) String() string {
	return tea.Prettify(s)
}

func (s DeleteDomainRequestModel) GoString() string {
	return s.String()
}

func (s *DeleteDomainRequestModel) SetHeaders(v map[string]string) *DeleteDomainRequestModel {
	s.Headers = v
	return s
}

func (s *DeleteDomainRequestModel) SetBody(v *DeleteDomainRequest) *DeleteDomainRequestModel {
	s.Body = v
	return s
}

type DeleteDomainModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
}

func (s DeleteDomainModel) String() string {
	return tea.Prettify(s)
}

func (s DeleteDomainModel) GoString() string {
	return s.String()
}

func (s *DeleteDomainModel) SetHeaders(v map[string]string) *DeleteDomainModel {
	s.Headers = v
	return s
}

type GetDomainRequestModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
	Body    *GetDomainRequest `json:"body" xml:"body" require:"true"`
}

func (s GetDomainRequestModel) String() string {
	return tea.Prettify(s)
}

func (s GetDomainRequestModel) GoString() string {
	return s.String()
}

func (s *GetDomainRequestModel) SetHeaders(v map[string]string) *GetDomainRequestModel {
	s.Headers = v
	return s
}

func (s *GetDomainRequestModel) SetBody(v *GetDomainRequest) *GetDomainRequestModel {
	s.Body = v
	return s
}

type GetDomainModel struct {
	Headers map[string]string  `json:"headers" xml:"headers"`
	Body    *GetDomainResponse `json:"body" xml:"body" require:"true"`
}

func (s GetDomainModel) String() string {
	return tea.Prettify(s)
}

func (s GetDomainModel) GoString() string {
	return s.String()
}

func (s *GetDomainModel) SetHeaders(v map[string]string) *GetDomainModel {
	s.Headers = v
	return s
}

func (s *GetDomainModel) SetBody(v *GetDomainResponse) *GetDomainModel {
	s.Body = v
	return s
}

type GetCorsRuleListRequestModel struct {
	Headers map[string]string       `json:"headers" xml:"headers"`
	Body    *GetCorsRuleListRequest `json:"body" xml:"body" require:"true"`
}

func (s GetCorsRuleListRequestModel) String() string {
	return tea.Prettify(s)
}

func (s GetCorsRuleListRequestModel) GoString() string {
	return s.String()
}

func (s *GetCorsRuleListRequestModel) SetHeaders(v map[string]string) *GetCorsRuleListRequestModel {
	s.Headers = v
	return s
}

func (s *GetCorsRuleListRequestModel) SetBody(v *GetCorsRuleListRequest) *GetCorsRuleListRequestModel {
	s.Body = v
	return s
}

type GetCorsRuleListModel struct {
	Headers map[string]string           `json:"headers" xml:"headers"`
	Body    *ListDomainCORSRuleResponse `json:"body" xml:"body" require:"true"`
}

func (s GetCorsRuleListModel) String() string {
	return tea.Prettify(s)
}

func (s GetCorsRuleListModel) GoString() string {
	return s.String()
}

func (s *GetCorsRuleListModel) SetHeaders(v map[string]string) *GetCorsRuleListModel {
	s.Headers = v
	return s
}

func (s *GetCorsRuleListModel) SetBody(v *ListDomainCORSRuleResponse) *GetCorsRuleListModel {
	s.Body = v
	return s
}

type ListDomainRequestModel struct {
	Headers map[string]string   `json:"headers" xml:"headers"`
	Body    *ListDomainsRequest `json:"body" xml:"body" require:"true"`
}

func (s ListDomainRequestModel) String() string {
	return tea.Prettify(s)
}

func (s ListDomainRequestModel) GoString() string {
	return s.String()
}

func (s *ListDomainRequestModel) SetHeaders(v map[string]string) *ListDomainRequestModel {
	s.Headers = v
	return s
}

func (s *ListDomainRequestModel) SetBody(v *ListDomainsRequest) *ListDomainRequestModel {
	s.Body = v
	return s
}

type ListDomainModel struct {
	Headers map[string]string    `json:"headers" xml:"headers"`
	Body    *ListDomainsResponse `json:"body" xml:"body" require:"true"`
}

func (s ListDomainModel) String() string {
	return tea.Prettify(s)
}

func (s ListDomainModel) GoString() string {
	return s.String()
}

func (s *ListDomainModel) SetHeaders(v map[string]string) *ListDomainModel {
	s.Headers = v
	return s
}

func (s *ListDomainModel) SetBody(v *ListDomainsResponse) *ListDomainModel {
	s.Body = v
	return s
}

type ListStoresRequestModel struct {
	Headers map[string]string  `json:"headers" xml:"headers"`
	Body    *ListStoresRequest `json:"body" xml:"body" require:"true"`
}

func (s ListStoresRequestModel) String() string {
	return tea.Prettify(s)
}

func (s ListStoresRequestModel) GoString() string {
	return s.String()
}

func (s *ListStoresRequestModel) SetHeaders(v map[string]string) *ListStoresRequestModel {
	s.Headers = v
	return s
}

func (s *ListStoresRequestModel) SetBody(v *ListStoresRequest) *ListStoresRequestModel {
	s.Body = v
	return s
}

type ListStoresModel struct {
	Headers map[string]string   `json:"headers" xml:"headers"`
	Body    *ListStoresResponse `json:"body" xml:"body" require:"true"`
}

func (s ListStoresModel) String() string {
	return tea.Prettify(s)
}

func (s ListStoresModel) GoString() string {
	return s.String()
}

func (s *ListStoresModel) SetHeaders(v map[string]string) *ListStoresModel {
	s.Headers = v
	return s
}

func (s *ListStoresModel) SetBody(v *ListStoresResponse) *ListStoresModel {
	s.Body = v
	return s
}

type RemoveStoreRequestModel struct {
	Headers map[string]string   `json:"headers" xml:"headers"`
	Body    *RemoveStoreRequest `json:"body" xml:"body" require:"true"`
}

func (s RemoveStoreRequestModel) String() string {
	return tea.Prettify(s)
}

func (s RemoveStoreRequestModel) GoString() string {
	return s.String()
}

func (s *RemoveStoreRequestModel) SetHeaders(v map[string]string) *RemoveStoreRequestModel {
	s.Headers = v
	return s
}

func (s *RemoveStoreRequestModel) SetBody(v *RemoveStoreRequest) *RemoveStoreRequestModel {
	s.Body = v
	return s
}

type RemoveStoreModel struct {
	Headers map[string]string `json:"headers" xml:"headers"`
}

func (s RemoveStoreModel) String() string {
	return tea.Prettify(s)
}

func (s RemoveStoreModel) GoString() string {
	return s.String()
}

func (s *RemoveStoreModel) SetHeaders(v map[string]string) *RemoveStoreModel {
	s.Headers = v
	return s
}

type SetCorsRuleListRequestModel struct {
	Headers map[string]string       `json:"headers" xml:"headers"`
	Body    *SetCorsRuleListRequest `json:"body" xml:"body" require:"true"`
}

func (s SetCorsRuleListRequestModel) String() string {
	return tea.Prettify(s)
}

func (s SetCorsRuleListRequestModel) GoString() string {
	return s.String()
}

func (s *SetCorsRuleListRequestModel) SetHeaders(v map[string]string) *SetCorsRuleListRequestModel {
	s.Headers = v
	return s
}

func (s *SetCorsRuleListRequestModel) SetBody(v *SetCorsRuleListRequest) *SetCorsRuleListRequestModel {
	s.Body = v
	return s
}

type SetCorsRuleListModel struct {
	Headers map[string]string           `json:"headers" xml:"headers"`
	Body    *ListDomainCORSRuleResponse `json:"body" xml:"body" require:"true"`
}

func (s SetCorsRuleListModel) String() string {
	return tea.Prettify(s)
}

func (s SetCorsRuleListModel) GoString() string {
	return s.String()
}

func (s *SetCorsRuleListModel) SetHeaders(v map[string]string) *SetCorsRuleListModel {
	s.Headers = v
	return s
}

func (s *SetCorsRuleListModel) SetBody(v *ListDomainCORSRuleResponse) *SetCorsRuleListModel {
	s.Body = v
	return s
}

type UpdateDomainRequestModel struct {
	Headers map[string]string    `json:"headers" xml:"headers"`
	Body    *UpdateDomainRequest `json:"body" xml:"body" require:"true"`
}

func (s UpdateDomainRequestModel) String() string {
	return tea.Prettify(s)
}

func (s UpdateDomainRequestModel) GoString() string {
	return s.String()
}

func (s *UpdateDomainRequestModel) SetHeaders(v map[string]string) *UpdateDomainRequestModel {
	s.Headers = v
	return s
}

func (s *UpdateDomainRequestModel) SetBody(v *UpdateDomainRequest) *UpdateDomainRequestModel {
	s.Body = v
	return s
}

type UpdateDomainModel struct {
	Headers map[string]string     `json:"headers" xml:"headers"`
	Body    *UpdateDomainResponse `json:"body" xml:"body" require:"true"`
}

func (s UpdateDomainModel) String() string {
	return tea.Prettify(s)
}

func (s UpdateDomainModel) GoString() string {
	return s.String()
}

func (s *UpdateDomainModel) SetHeaders(v map[string]string) *UpdateDomainModel {
	s.Headers = v
	return s
}

func (s *UpdateDomainModel) SetBody(v *UpdateDomainResponse) *UpdateDomainModel {
	s.Body = v
	return s
}

/**
 *
 */
type AddStoreRequest struct {
	BasePath  *string `json:"base_path" xml:"base_path"`
	Bucket    *string `json:"bucket" xml:"bucket"`
	DomainId  *string `json:"domain_id" xml:"domain_id" require:"true"`
	Endpoint  *string `json:"endpoint" xml:"endpoint" require:"true"`
	Ownership *string `json:"ownership" xml:"ownership"`
	RoleArn   *string `json:"role_arn" xml:"role_arn"`
	Type      *string `json:"type" xml:"type" require:"true"`
}

func (s AddStoreRequest) String() string {
	return tea.Prettify(s)
}

func (s AddStoreRequest) GoString() string {
	return s.String()
}

func (s *AddStoreRequest) SetBasePath(v string) *AddStoreRequest {
	s.BasePath = &v
	return s
}

func (s *AddStoreRequest) SetBucket(v string) *AddStoreRequest {
	s.Bucket = &v
	return s
}

func (s *AddStoreRequest) SetDomainId(v string) *AddStoreRequest {
	s.DomainId = &v
	return s
}

func (s *AddStoreRequest) SetEndpoint(v string) *AddStoreRequest {
	s.Endpoint = &v
	return s
}

func (s *AddStoreRequest) SetOwnership(v string) *AddStoreRequest {
	s.Ownership = &v
	return s
}

func (s *AddStoreRequest) SetRoleArn(v string) *AddStoreRequest {
	s.RoleArn = &v
	return s
}

func (s *AddStoreRequest) SetType(v string) *AddStoreRequest {
	s.Type = &v
	return s
}

/**
 *
 */
type AddStoreResponse struct {
	AccelerateEndpoint *string `json:"accelerate_endpoint" xml:"accelerate_endpoint"`
	BasePath           *string `json:"base_path" xml:"base_path"`
	Bucket             *string `json:"bucket" xml:"bucket" require:"true"`
	CustomizedEndpoint *string `json:"customized_endpoint" xml:"customized_endpoint"`
	DomainId           *string `json:"domain_id" xml:"domain_id" require:"true"`
	Endpoint           *string `json:"endpoint" xml:"endpoint" require:"true"`
	InternalEndpoint   *string `json:"internal_endpoint" xml:"internal_endpoint"`
	Ownership          *string `json:"ownership" xml:"ownership" require:"true"`
	Policy             *string `json:"policy" xml:"policy" require:"true"`
	RoleArn            *string `json:"role_arn" xml:"role_arn"`
	StoreId            *string `json:"store_id" xml:"store_id" require:"true"`
	Type               *string `json:"type" xml:"type" require:"true"`
}

func (s AddStoreResponse) String() string {
	return tea.Prettify(s)
}

func (s AddStoreResponse) GoString() string {
	return s.String()
}

func (s *AddStoreResponse) SetAccelerateEndpoint(v string) *AddStoreResponse {
	s.AccelerateEndpoint = &v
	return s
}

func (s *AddStoreResponse) SetBasePath(v string) *AddStoreResponse {
	s.BasePath = &v
	return s
}

func (s *AddStoreResponse) SetBucket(v string) *AddStoreResponse {
	s.Bucket = &v
	return s
}

func (s *AddStoreResponse) SetCustomizedEndpoint(v string) *AddStoreResponse {
	s.CustomizedEndpoint = &v
	return s
}

func (s *AddStoreResponse) SetDomainId(v string) *AddStoreResponse {
	s.DomainId = &v
	return s
}

func (s *AddStoreResponse) SetEndpoint(v string) *AddStoreResponse {
	s.Endpoint = &v
	return s
}

func (s *AddStoreResponse) SetInternalEndpoint(v string) *AddStoreResponse {
	s.InternalEndpoint = &v
	return s
}

func (s *AddStoreResponse) SetOwnership(v string) *AddStoreResponse {
	s.Ownership = &v
	return s
}

func (s *AddStoreResponse) SetPolicy(v string) *AddStoreResponse {
	s.Policy = &v
	return s
}

func (s *AddStoreResponse) SetRoleArn(v string) *AddStoreResponse {
	s.RoleArn = &v
	return s
}

func (s *AddStoreResponse) SetStoreId(v string) *AddStoreResponse {
	s.StoreId = &v
	return s
}

func (s *AddStoreResponse) SetType(v string) *AddStoreResponse {
	s.Type = &v
	return s
}

/**
 *
 */
type AppAccessStrategy struct {
	Effect          *string   `json:"effect" xml:"effect"`
	ExceptAppIdList []*string `json:"except_app_id_list" xml:"except_app_id_list" type:"Repeated"`
}

func (s AppAccessStrategy) String() string {
	return tea.Prettify(s)
}

func (s AppAccessStrategy) GoString() string {
	return s.String()
}

func (s *AppAccessStrategy) SetEffect(v string) *AppAccessStrategy {
	s.Effect = &v
	return s
}

func (s *AppAccessStrategy) SetExceptAppIdList(v []*string) *AppAccessStrategy {
	s.ExceptAppIdList = v
	return s
}

/**
 *
 */
type AuthConfig struct {
	AppId            *string `json:"app_id" xml:"app_id"`
	AppSecret        *string `json:"app_secret" xml:"app_secret"`
	CallbackSecurity *bool   `json:"callback_security" xml:"callback_security"`
	Enable           *bool   `json:"enable" xml:"enable"`
	Endpoint         *string `json:"endpoint" xml:"endpoint"`
	EnterpriseId     *string `json:"enterprise_id" xml:"enterprise_id"`
}

func (s AuthConfig) String() string {
	return tea.Prettify(s)
}

func (s AuthConfig) GoString() string {
	return s.String()
}

func (s *AuthConfig) SetAppId(v string) *AuthConfig {
	s.AppId = &v
	return s
}

func (s *AuthConfig) SetAppSecret(v string) *AuthConfig {
	s.AppSecret = &v
	return s
}

func (s *AuthConfig) SetCallbackSecurity(v bool) *AuthConfig {
	s.CallbackSecurity = &v
	return s
}

func (s *AuthConfig) SetEnable(v bool) *AuthConfig {
	s.Enable = &v
	return s
}

func (s *AuthConfig) SetEndpoint(v string) *AuthConfig {
	s.Endpoint = &v
	return s
}

func (s *AuthConfig) SetEnterpriseId(v string) *AuthConfig {
	s.EnterpriseId = &v
	return s
}

/**
 * base domain response
 */
type BaseDomainResponse struct {
	AuthAlipayAppId            *string                `json:"auth_alipay_app_id" xml:"auth_alipay_app_id"`
	AuthAlipayEnable           *bool                  `json:"auth_alipay_enable" xml:"auth_alipay_enable"`
	AuthAlipayPrivateKey       *string                `json:"auth_alipay_private_key" xml:"auth_alipay_private_key"`
	AuthConfig                 map[string]interface{} `json:"auth_config" xml:"auth_config"`
	AuthDingdingAppId          *string                `json:"auth_dingding_app_id" xml:"auth_dingding_app_id"`
	AuthDingdingAppSecret      *string                `json:"auth_dingding_app_secret" xml:"auth_dingding_app_secret"`
	AuthDingdingEnable         *bool                  `json:"auth_dingding_enable" xml:"auth_dingding_enable"`
	AuthEndpointEnable         *bool                  `json:"auth_endpoint_enable" xml:"auth_endpoint_enable"`
	AuthRamAppId               *string                `json:"auth_ram_app_id" xml:"auth_ram_app_id"`
	AuthRamAppSecret           *string                `json:"auth_ram_app_secret" xml:"auth_ram_app_secret"`
	AuthRamEnable              *bool                  `json:"auth_ram_enable" xml:"auth_ram_enable"`
	CreatedAt                  *string                `json:"created_at" xml:"created_at"`
	DataHashName               *string                `json:"data_hash_name" xml:"data_hash_name"`
	Description                *string                `json:"description" xml:"description"`
	DomainId                   *string                `json:"domain_id" xml:"domain_id"`
	DomainName                 *string                `json:"domain_name" xml:"domain_name"`
	EventFilenameMatches       *string                `json:"event_filename_matches" xml:"event_filename_matches"`
	EventMnsEndpoint           *string                `json:"event_mns_endpoint" xml:"event_mns_endpoint"`
	EventMnsTopic              *string                `json:"event_mns_topic" xml:"event_mns_topic"`
	EventNames                 []*string              `json:"event_names" xml:"event_names" type:"Repeated"`
	EventRoleArn               *string                `json:"event_role_arn" xml:"event_role_arn"`
	InitDriveEnable            *bool                  `json:"init_drive_enable" xml:"init_drive_enable"`
	InitDriveSize              *int64                 `json:"init_drive_size" xml:"init_drive_size"`
	InitDriveStoreId           *string                `json:"init_drive_store_id" xml:"init_drive_store_id"`
	PathType                   *string                `json:"path_type" xml:"path_type"`
	PublishedAppAccessStrategy *AppAccessStrategy     `json:"published_app_access_strategy" xml:"published_app_access_strategy"`
	Sharable                   *bool                  `json:"sharable" xml:"sharable"`
	StoreLevel                 *string                `json:"store_level" xml:"store_level"`
	StoreRegionList            []*string              `json:"store_region_list" xml:"store_region_list" type:"Repeated"`
	UpdatedAt                  *string                `json:"updated_at" xml:"updated_at"`
}

func (s BaseDomainResponse) String() string {
	return tea.Prettify(s)
}

func (s BaseDomainResponse) GoString() string {
	return s.String()
}

func (s *BaseDomainResponse) SetAuthAlipayAppId(v string) *BaseDomainResponse {
	s.AuthAlipayAppId = &v
	return s
}

func (s *BaseDomainResponse) SetAuthAlipayEnable(v bool) *BaseDomainResponse {
	s.AuthAlipayEnable = &v
	return s
}

func (s *BaseDomainResponse) SetAuthAlipayPrivateKey(v string) *BaseDomainResponse {
	s.AuthAlipayPrivateKey = &v
	return s
}

func (s *BaseDomainResponse) SetAuthConfig(v map[string]interface{}) *BaseDomainResponse {
	s.AuthConfig = v
	return s
}

func (s *BaseDomainResponse) SetAuthDingdingAppId(v string) *BaseDomainResponse {
	s.AuthDingdingAppId = &v
	return s
}

func (s *BaseDomainResponse) SetAuthDingdingAppSecret(v string) *BaseDomainResponse {
	s.AuthDingdingAppSecret = &v
	return s
}

func (s *BaseDomainResponse) SetAuthDingdingEnable(v bool) *BaseDomainResponse {
	s.AuthDingdingEnable = &v
	return s
}

func (s *BaseDomainResponse) SetAuthEndpointEnable(v bool) *BaseDomainResponse {
	s.AuthEndpointEnable = &v
	return s
}

func (s *BaseDomainResponse) SetAuthRamAppId(v string) *BaseDomainResponse {
	s.AuthRamAppId = &v
	return s
}

func (s *BaseDomainResponse) SetAuthRamAppSecret(v string) *BaseDomainResponse {
	s.AuthRamAppSecret = &v
	return s
}

func (s *BaseDomainResponse) SetAuthRamEnable(v bool) *BaseDomainResponse {
	s.AuthRamEnable = &v
	return s
}

func (s *BaseDomainResponse) SetCreatedAt(v string) *BaseDomainResponse {
	s.CreatedAt = &v
	return s
}

func (s *BaseDomainResponse) SetDataHashName(v string) *BaseDomainResponse {
	s.DataHashName = &v
	return s
}

func (s *BaseDomainResponse) SetDescription(v string) *BaseDomainResponse {
	s.Description = &v
	return s
}

func (s *BaseDomainResponse) SetDomainId(v string) *BaseDomainResponse {
	s.DomainId = &v
	return s
}

func (s *BaseDomainResponse) SetDomainName(v string) *BaseDomainResponse {
	s.DomainName = &v
	return s
}

func (s *BaseDomainResponse) SetEventFilenameMatches(v string) *BaseDomainResponse {
	s.EventFilenameMatches = &v
	return s
}

func (s *BaseDomainResponse) SetEventMnsEndpoint(v string) *BaseDomainResponse {
	s.EventMnsEndpoint = &v
	return s
}

func (s *BaseDomainResponse) SetEventMnsTopic(v string) *BaseDomainResponse {
	s.EventMnsTopic = &v
	return s
}

func (s *BaseDomainResponse) SetEventNames(v []*string) *BaseDomainResponse {
	s.EventNames = v
	return s
}

func (s *BaseDomainResponse) SetEventRoleArn(v string) *BaseDomainResponse {
	s.EventRoleArn = &v
	return s
}

func (s *BaseDomainResponse) SetInitDriveEnable(v bool) *BaseDomainResponse {
	s.InitDriveEnable = &v
	return s
}

func (s *BaseDomainResponse) SetInitDriveSize(v int64) *BaseDomainResponse {
	s.InitDriveSize = &v
	return s
}

func (s *BaseDomainResponse) SetInitDriveStoreId(v string) *BaseDomainResponse {
	s.InitDriveStoreId = &v
	return s
}

func (s *BaseDomainResponse) SetPathType(v string) *BaseDomainResponse {
	s.PathType = &v
	return s
}

func (s *BaseDomainResponse) SetPublishedAppAccessStrategy(v *AppAccessStrategy) *BaseDomainResponse {
	s.PublishedAppAccessStrategy = v
	return s
}

func (s *BaseDomainResponse) SetSharable(v bool) *BaseDomainResponse {
	s.Sharable = &v
	return s
}

func (s *BaseDomainResponse) SetStoreLevel(v string) *BaseDomainResponse {
	s.StoreLevel = &v
	return s
}

func (s *BaseDomainResponse) SetStoreRegionList(v []*string) *BaseDomainResponse {
	s.StoreRegionList = v
	return s
}

func (s *BaseDomainResponse) SetUpdatedAt(v string) *BaseDomainResponse {
	s.UpdatedAt = &v
	return s
}

/**
 *
 */
type Captcha struct {
	Captcha       *string `json:"captcha" xml:"captcha" require:"true"`
	CaptchaFormat *string `json:"captcha_format" xml:"captcha_format" require:"true"`
	CaptchaId     *string `json:"captcha_id" xml:"captcha_id" require:"true"`
}

func (s Captcha) String() string {
	return tea.Prettify(s)
}

func (s Captcha) GoString() string {
	return s.String()
}

func (s *Captcha) SetCaptcha(v string) *Captcha {
	s.Captcha = &v
	return s
}

func (s *Captcha) SetCaptchaFormat(v string) *Captcha {
	s.CaptchaFormat = &v
	return s
}

func (s *Captcha) SetCaptchaId(v string) *Captcha {
	s.CaptchaId = &v
	return s
}

/**
 *
 */
type CorsRule struct {
	AllowedHeader []*string `json:"allowed_header" xml:"allowed_header" type:"Repeated"`
	AllowedMethod []*string `json:"allowed_method" xml:"allowed_method" type:"Repeated"`
	AllowedOrigin []*string `json:"allowed_origin" xml:"allowed_origin" type:"Repeated"`
	ExposeHeader  []*string `json:"expose_header" xml:"expose_header" type:"Repeated"`
	MaxAgeSeconds *int64    `json:"max_age_seconds" xml:"max_age_seconds"`
}

func (s CorsRule) String() string {
	return tea.Prettify(s)
}

func (s CorsRule) GoString() string {
	return s.String()
}

func (s *CorsRule) SetAllowedHeader(v []*string) *CorsRule {
	s.AllowedHeader = v
	return s
}

func (s *CorsRule) SetAllowedMethod(v []*string) *CorsRule {
	s.AllowedMethod = v
	return s
}

func (s *CorsRule) SetAllowedOrigin(v []*string) *CorsRule {
	s.AllowedOrigin = v
	return s
}

func (s *CorsRule) SetExposeHeader(v []*string) *CorsRule {
	s.ExposeHeader = v
	return s
}

func (s *CorsRule) SetMaxAgeSeconds(v int64) *CorsRule {
	s.MaxAgeSeconds = &v
	return s
}

/**
 *
 */
type CreateAppRequest struct {
	AppName      *string   `json:"app_name" xml:"app_name" require:"true" maxLength:"128"`
	Description  *string   `json:"description" xml:"description" maxLength:"128"`
	IsThirdParty *bool     `json:"is_third_party" xml:"is_third_party"`
	Logo         *string   `json:"logo" xml:"logo" require:"true"`
	RedirectUri  *string   `json:"redirect_uri" xml:"redirect_uri"`
	Scope        []*string `json:"scope" xml:"scope" require:"true" type:"Repeated"`
	Type         *string   `json:"type" xml:"type" require:"true"`
}

func (s CreateAppRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateAppRequest) GoString() string {
	return s.String()
}

func (s *CreateAppRequest) SetAppName(v string) *CreateAppRequest {
	s.AppName = &v
	return s
}

func (s *CreateAppRequest) SetDescription(v string) *CreateAppRequest {
	s.Description = &v
	return s
}

func (s *CreateAppRequest) SetIsThirdParty(v bool) *CreateAppRequest {
	s.IsThirdParty = &v
	return s
}

func (s *CreateAppRequest) SetLogo(v string) *CreateAppRequest {
	s.Logo = &v
	return s
}

func (s *CreateAppRequest) SetRedirectUri(v string) *CreateAppRequest {
	s.RedirectUri = &v
	return s
}

func (s *CreateAppRequest) SetScope(v []*string) *CreateAppRequest {
	s.Scope = v
	return s
}

func (s *CreateAppRequest) SetType(v string) *CreateAppRequest {
	s.Type = &v
	return s
}

/**
 * create domain request
 */
type CreateDomainRequest struct {
	AuthAlipayAppId            *string                `json:"auth_alipay_app_id" xml:"auth_alipay_app_id"`
	AuthAlipayEnbale           *bool                  `json:"auth_alipay_enbale" xml:"auth_alipay_enbale"`
	AuthAlipayPrivateKey       *string                `json:"auth_alipay_private_key" xml:"auth_alipay_private_key"`
	AuthConfig                 map[string]interface{} `json:"auth_config" xml:"auth_config"`
	AuthDingdingAppId          *string                `json:"auth_dingding_app_id" xml:"auth_dingding_app_id"`
	AuthDingdingAppSecret      *string                `json:"auth_dingding_app_secret" xml:"auth_dingding_app_secret"`
	AuthDingdingEnable         *bool                  `json:"auth_dingding_enable" xml:"auth_dingding_enable"`
	AuthEndpointEnable         *bool                  `json:"auth_endpoint_enable" xml:"auth_endpoint_enable"`
	AuthRamAppId               *string                `json:"auth_ram_app_id" xml:"auth_ram_app_id"`
	AuthRamAppSecret           *string                `json:"auth_ram_app_secret" xml:"auth_ram_app_secret"`
	AuthRamEnable              *bool                  `json:"auth_ram_enable" xml:"auth_ram_enable"`
	DataHashName               *string                `json:"data_hash_name" xml:"data_hash_name"`
	Description                *string                `json:"description" xml:"description"`
	DomainName                 *string                `json:"domain_name" xml:"domain_name" require:"true"`
	EventFilenameMatches       *string                `json:"event_filename_matches" xml:"event_filename_matches"`
	EventMnsEndpoint           *string                `json:"event_mns_endpoint" xml:"event_mns_endpoint"`
	EventMnsTopic              *string                `json:"event_mns_topic" xml:"event_mns_topic"`
	EventNames                 []*string              `json:"event_names" xml:"event_names" type:"Repeated"`
	EventRoleArn               *string                `json:"event_role_arn" xml:"event_role_arn"`
	InitDriveEnable            *bool                  `json:"init_drive_enable" xml:"init_drive_enable"`
	InitDriveSize              *int64                 `json:"init_drive_size" xml:"init_drive_size"`
	PathType                   *string                `json:"path_type" xml:"path_type" require:"true"`
	PublishedAppAccessStrategy *AppAccessStrategy     `json:"published_app_access_strategy" xml:"published_app_access_strategy"`
	Sharable                   *bool                  `json:"sharable" xml:"sharable"`
	StoreLevel                 *string                `json:"store_level" xml:"store_level"`
	StoreRegionList            []*string              `json:"store_region_list" xml:"store_region_list" require:"true" type:"Repeated"`
}

func (s CreateDomainRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateDomainRequest) GoString() string {
	return s.String()
}

func (s *CreateDomainRequest) SetAuthAlipayAppId(v string) *CreateDomainRequest {
	s.AuthAlipayAppId = &v
	return s
}

func (s *CreateDomainRequest) SetAuthAlipayEnbale(v bool) *CreateDomainRequest {
	s.AuthAlipayEnbale = &v
	return s
}

func (s *CreateDomainRequest) SetAuthAlipayPrivateKey(v string) *CreateDomainRequest {
	s.AuthAlipayPrivateKey = &v
	return s
}

func (s *CreateDomainRequest) SetAuthConfig(v map[string]interface{}) *CreateDomainRequest {
	s.AuthConfig = v
	return s
}

func (s *CreateDomainRequest) SetAuthDingdingAppId(v string) *CreateDomainRequest {
	s.AuthDingdingAppId = &v
	return s
}

func (s *CreateDomainRequest) SetAuthDingdingAppSecret(v string) *CreateDomainRequest {
	s.AuthDingdingAppSecret = &v
	return s
}

func (s *CreateDomainRequest) SetAuthDingdingEnable(v bool) *CreateDomainRequest {
	s.AuthDingdingEnable = &v
	return s
}

func (s *CreateDomainRequest) SetAuthEndpointEnable(v bool) *CreateDomainRequest {
	s.AuthEndpointEnable = &v
	return s
}

func (s *CreateDomainRequest) SetAuthRamAppId(v string) *CreateDomainRequest {
	s.AuthRamAppId = &v
	return s
}

func (s *CreateDomainRequest) SetAuthRamAppSecret(v string) *CreateDomainRequest {
	s.AuthRamAppSecret = &v
	return s
}

func (s *CreateDomainRequest) SetAuthRamEnable(v bool) *CreateDomainRequest {
	s.AuthRamEnable = &v
	return s
}

func (s *CreateDomainRequest) SetDataHashName(v string) *CreateDomainRequest {
	s.DataHashName = &v
	return s
}

func (s *CreateDomainRequest) SetDescription(v string) *CreateDomainRequest {
	s.Description = &v
	return s
}

func (s *CreateDomainRequest) SetDomainName(v string) *CreateDomainRequest {
	s.DomainName = &v
	return s
}

func (s *CreateDomainRequest) SetEventFilenameMatches(v string) *CreateDomainRequest {
	s.EventFilenameMatches = &v
	return s
}

func (s *CreateDomainRequest) SetEventMnsEndpoint(v string) *CreateDomainRequest {
	s.EventMnsEndpoint = &v
	return s
}

func (s *CreateDomainRequest) SetEventMnsTopic(v string) *CreateDomainRequest {
	s.EventMnsTopic = &v
	return s
}

func (s *CreateDomainRequest) SetEventNames(v []*string) *CreateDomainRequest {
	s.EventNames = v
	return s
}

func (s *CreateDomainRequest) SetEventRoleArn(v string) *CreateDomainRequest {
	s.EventRoleArn = &v
	return s
}

func (s *CreateDomainRequest) SetInitDriveEnable(v bool) *CreateDomainRequest {
	s.InitDriveEnable = &v
	return s
}

func (s *CreateDomainRequest) SetInitDriveSize(v int64) *CreateDomainRequest {
	s.InitDriveSize = &v
	return s
}

func (s *CreateDomainRequest) SetPathType(v string) *CreateDomainRequest {
	s.PathType = &v
	return s
}

func (s *CreateDomainRequest) SetPublishedAppAccessStrategy(v *AppAccessStrategy) *CreateDomainRequest {
	s.PublishedAppAccessStrategy = v
	return s
}

func (s *CreateDomainRequest) SetSharable(v bool) *CreateDomainRequest {
	s.Sharable = &v
	return s
}

func (s *CreateDomainRequest) SetStoreLevel(v string) *CreateDomainRequest {
	s.StoreLevel = &v
	return s
}

func (s *CreateDomainRequest) SetStoreRegionList(v []*string) *CreateDomainRequest {
	s.StoreRegionList = v
	return s
}

/**
 * create domain response
 */
type CreateDomainResponse struct {
	AuthAlipayAppId            *string                `json:"auth_alipay_app_id" xml:"auth_alipay_app_id"`
	AuthAlipayEnable           *bool                  `json:"auth_alipay_enable" xml:"auth_alipay_enable"`
	AuthAlipayPrivateKey       *string                `json:"auth_alipay_private_key" xml:"auth_alipay_private_key"`
	AuthConfig                 map[string]interface{} `json:"auth_config" xml:"auth_config"`
	AuthDingdingAppId          *string                `json:"auth_dingding_app_id" xml:"auth_dingding_app_id"`
	AuthDingdingAppSecret      *string                `json:"auth_dingding_app_secret" xml:"auth_dingding_app_secret"`
	AuthDingdingEnable         *bool                  `json:"auth_dingding_enable" xml:"auth_dingding_enable"`
	AuthEndpointEnable         *bool                  `json:"auth_endpoint_enable" xml:"auth_endpoint_enable"`
	AuthRamAppId               *string                `json:"auth_ram_app_id" xml:"auth_ram_app_id"`
	AuthRamAppSecret           *string                `json:"auth_ram_app_secret" xml:"auth_ram_app_secret"`
	AuthRamEnable              *bool                  `json:"auth_ram_enable" xml:"auth_ram_enable"`
	CreatedAt                  *string                `json:"created_at" xml:"created_at"`
	DataHashName               *string                `json:"data_hash_name" xml:"data_hash_name"`
	Description                *string                `json:"description" xml:"description"`
	DomainId                   *string                `json:"domain_id" xml:"domain_id"`
	DomainName                 *string                `json:"domain_name" xml:"domain_name"`
	EventFilenameMatches       *string                `json:"event_filename_matches" xml:"event_filename_matches"`
	EventMnsEndpoint           *string                `json:"event_mns_endpoint" xml:"event_mns_endpoint"`
	EventMnsTopic              *string                `json:"event_mns_topic" xml:"event_mns_topic"`
	EventNames                 []*string              `json:"event_names" xml:"event_names" type:"Repeated"`
	EventRoleArn               *string                `json:"event_role_arn" xml:"event_role_arn"`
	InitDriveEnable            *bool                  `json:"init_drive_enable" xml:"init_drive_enable"`
	InitDriveSize              *int64                 `json:"init_drive_size" xml:"init_drive_size"`
	InitDriveStoreId           *string                `json:"init_drive_store_id" xml:"init_drive_store_id"`
	PathType                   *string                `json:"path_type" xml:"path_type"`
	PublishedAppAccessStrategy *AppAccessStrategy     `json:"published_app_access_strategy" xml:"published_app_access_strategy"`
	Sharable                   *bool                  `json:"sharable" xml:"sharable"`
	StoreLevel                 *string                `json:"store_level" xml:"store_level"`
	StoreRegionList            []*string              `json:"store_region_list" xml:"store_region_list" type:"Repeated"`
	UpdatedAt                  *string                `json:"updated_at" xml:"updated_at"`
}

func (s CreateDomainResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateDomainResponse) GoString() string {
	return s.String()
}

func (s *CreateDomainResponse) SetAuthAlipayAppId(v string) *CreateDomainResponse {
	s.AuthAlipayAppId = &v
	return s
}

func (s *CreateDomainResponse) SetAuthAlipayEnable(v bool) *CreateDomainResponse {
	s.AuthAlipayEnable = &v
	return s
}

func (s *CreateDomainResponse) SetAuthAlipayPrivateKey(v string) *CreateDomainResponse {
	s.AuthAlipayPrivateKey = &v
	return s
}

func (s *CreateDomainResponse) SetAuthConfig(v map[string]interface{}) *CreateDomainResponse {
	s.AuthConfig = v
	return s
}

func (s *CreateDomainResponse) SetAuthDingdingAppId(v string) *CreateDomainResponse {
	s.AuthDingdingAppId = &v
	return s
}

func (s *CreateDomainResponse) SetAuthDingdingAppSecret(v string) *CreateDomainResponse {
	s.AuthDingdingAppSecret = &v
	return s
}

func (s *CreateDomainResponse) SetAuthDingdingEnable(v bool) *CreateDomainResponse {
	s.AuthDingdingEnable = &v
	return s
}

func (s *CreateDomainResponse) SetAuthEndpointEnable(v bool) *CreateDomainResponse {
	s.AuthEndpointEnable = &v
	return s
}

func (s *CreateDomainResponse) SetAuthRamAppId(v string) *CreateDomainResponse {
	s.AuthRamAppId = &v
	return s
}

func (s *CreateDomainResponse) SetAuthRamAppSecret(v string) *CreateDomainResponse {
	s.AuthRamAppSecret = &v
	return s
}

func (s *CreateDomainResponse) SetAuthRamEnable(v bool) *CreateDomainResponse {
	s.AuthRamEnable = &v
	return s
}

func (s *CreateDomainResponse) SetCreatedAt(v string) *CreateDomainResponse {
	s.CreatedAt = &v
	return s
}

func (s *CreateDomainResponse) SetDataHashName(v string) *CreateDomainResponse {
	s.DataHashName = &v
	return s
}

func (s *CreateDomainResponse) SetDescription(v string) *CreateDomainResponse {
	s.Description = &v
	return s
}

func (s *CreateDomainResponse) SetDomainId(v string) *CreateDomainResponse {
	s.DomainId = &v
	return s
}

func (s *CreateDomainResponse) SetDomainName(v string) *CreateDomainResponse {
	s.DomainName = &v
	return s
}

func (s *CreateDomainResponse) SetEventFilenameMatches(v string) *CreateDomainResponse {
	s.EventFilenameMatches = &v
	return s
}

func (s *CreateDomainResponse) SetEventMnsEndpoint(v string) *CreateDomainResponse {
	s.EventMnsEndpoint = &v
	return s
}

func (s *CreateDomainResponse) SetEventMnsTopic(v string) *CreateDomainResponse {
	s.EventMnsTopic = &v
	return s
}

func (s *CreateDomainResponse) SetEventNames(v []*string) *CreateDomainResponse {
	s.EventNames = v
	return s
}

func (s *CreateDomainResponse) SetEventRoleArn(v string) *CreateDomainResponse {
	s.EventRoleArn = &v
	return s
}

func (s *CreateDomainResponse) SetInitDriveEnable(v bool) *CreateDomainResponse {
	s.InitDriveEnable = &v
	return s
}

func (s *CreateDomainResponse) SetInitDriveSize(v int64) *CreateDomainResponse {
	s.InitDriveSize = &v
	return s
}

func (s *CreateDomainResponse) SetInitDriveStoreId(v string) *CreateDomainResponse {
	s.InitDriveStoreId = &v
	return s
}

func (s *CreateDomainResponse) SetPathType(v string) *CreateDomainResponse {
	s.PathType = &v
	return s
}

func (s *CreateDomainResponse) SetPublishedAppAccessStrategy(v *AppAccessStrategy) *CreateDomainResponse {
	s.PublishedAppAccessStrategy = v
	return s
}

func (s *CreateDomainResponse) SetSharable(v bool) *CreateDomainResponse {
	s.Sharable = &v
	return s
}

func (s *CreateDomainResponse) SetStoreLevel(v string) *CreateDomainResponse {
	s.StoreLevel = &v
	return s
}

func (s *CreateDomainResponse) SetStoreRegionList(v []*string) *CreateDomainResponse {
	s.StoreRegionList = v
	return s
}

func (s *CreateDomainResponse) SetUpdatedAt(v string) *CreateDomainResponse {
	s.UpdatedAt = &v
	return s
}

/**
 *
 */
type DeleteAppRequest struct {
	AppId *string `json:"app_id" xml:"app_id" require:"true"`
}

func (s DeleteAppRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteAppRequest) GoString() string {
	return s.String()
}

func (s *DeleteAppRequest) SetAppId(v string) *DeleteAppRequest {
	s.AppId = &v
	return s
}

/**
 * delete domain request
 */
type DeleteDomainRequest struct {
	DomainId *string `json:"domain_id" xml:"domain_id" require:"true"`
}

func (s DeleteDomainRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteDomainRequest) GoString() string {
	return s.String()
}

func (s *DeleteDomainRequest) SetDomainId(v string) *DeleteDomainRequest {
	s.DomainId = &v
	return s
}

/**
 *
 */
type GetAppPublicKeyRequest struct {
	AppId *string `json:"app_id" xml:"app_id" require:"true"`
}

func (s GetAppPublicKeyRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAppPublicKeyRequest) GoString() string {
	return s.String()
}

func (s *GetAppPublicKeyRequest) SetAppId(v string) *GetAppPublicKeyRequest {
	s.AppId = &v
	return s
}

/**
 *
 */
type GetAppPublicKeyResponse struct {
	AppId     *string `json:"app_id" xml:"app_id" require:"true"`
	PublicKey *string `json:"public_key" xml:"public_key" require:"true"`
}

func (s GetAppPublicKeyResponse) String() string {
	return tea.Prettify(s)
}

func (s GetAppPublicKeyResponse) GoString() string {
	return s.String()
}

func (s *GetAppPublicKeyResponse) SetAppId(v string) *GetAppPublicKeyResponse {
	s.AppId = &v
	return s
}

func (s *GetAppPublicKeyResponse) SetPublicKey(v string) *GetAppPublicKeyResponse {
	s.PublicKey = &v
	return s
}

/**
 *
 */
type GetAppRequest struct {
	AppId *string `json:"app_id" xml:"app_id" require:"true"`
}

func (s GetAppRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAppRequest) GoString() string {
	return s.String()
}

func (s *GetAppRequest) SetAppId(v string) *GetAppRequest {
	s.AppId = &v
	return s
}

/**
 *
 */
type GetAppResponse struct {
	AliOwnerId  *string   `json:"ali_owner_id" xml:"ali_owner_id" require:"true"`
	AppId       *string   `json:"app_id" xml:"app_id" require:"true"`
	AppName     *string   `json:"app_name" xml:"app_name" require:"true" maxLength:"128" pattern:"[0-9a-zA-Z]+"`
	AppSecret   *string   `json:"app_secret" xml:"app_secret" require:"true"`
	CreatedAt   *string   `json:"created_at" xml:"created_at" require:"true"`
	Description *string   `json:"description" xml:"description" require:"true" maxLength:"128"`
	Logo        *string   `json:"logo" xml:"logo" require:"true"`
	Provider    *string   `json:"provider" xml:"provider" require:"true"`
	RedirectUri *string   `json:"redirect_uri" xml:"redirect_uri" require:"true"`
	Scope       []*string `json:"scope" xml:"scope" require:"true" type:"Repeated"`
	Screenshots []*string `json:"screenshots" xml:"screenshots" require:"true" type:"Repeated"`
	Stage       *string   `json:"stage" xml:"stage" require:"true"`
	Type        *string   `json:"type" xml:"type" require:"true"`
	UpdatedAt   *string   `json:"updated_at" xml:"updated_at" require:"true"`
}

func (s GetAppResponse) String() string {
	return tea.Prettify(s)
}

func (s GetAppResponse) GoString() string {
	return s.String()
}

func (s *GetAppResponse) SetAliOwnerId(v string) *GetAppResponse {
	s.AliOwnerId = &v
	return s
}

func (s *GetAppResponse) SetAppId(v string) *GetAppResponse {
	s.AppId = &v
	return s
}

func (s *GetAppResponse) SetAppName(v string) *GetAppResponse {
	s.AppName = &v
	return s
}

func (s *GetAppResponse) SetAppSecret(v string) *GetAppResponse {
	s.AppSecret = &v
	return s
}

func (s *GetAppResponse) SetCreatedAt(v string) *GetAppResponse {
	s.CreatedAt = &v
	return s
}

func (s *GetAppResponse) SetDescription(v string) *GetAppResponse {
	s.Description = &v
	return s
}

func (s *GetAppResponse) SetLogo(v string) *GetAppResponse {
	s.Logo = &v
	return s
}

func (s *GetAppResponse) SetProvider(v string) *GetAppResponse {
	s.Provider = &v
	return s
}

func (s *GetAppResponse) SetRedirectUri(v string) *GetAppResponse {
	s.RedirectUri = &v
	return s
}

func (s *GetAppResponse) SetScope(v []*string) *GetAppResponse {
	s.Scope = v
	return s
}

func (s *GetAppResponse) SetScreenshots(v []*string) *GetAppResponse {
	s.Screenshots = v
	return s
}

func (s *GetAppResponse) SetStage(v string) *GetAppResponse {
	s.Stage = &v
	return s
}

func (s *GetAppResponse) SetType(v string) *GetAppResponse {
	s.Type = &v
	return s
}

func (s *GetAppResponse) SetUpdatedAt(v string) *GetAppResponse {
	s.UpdatedAt = &v
	return s
}

/**
 *
 */
type GetCorsRuleListRequest struct {
	DomainId *string `json:"domain_id" xml:"domain_id" require:"true"`
}

func (s GetCorsRuleListRequest) String() string {
	return tea.Prettify(s)
}

func (s GetCorsRuleListRequest) GoString() string {
	return s.String()
}

func (s *GetCorsRuleListRequest) SetDomainId(v string) *GetCorsRuleListRequest {
	s.DomainId = &v
	return s
}

/**
 * get domain request
 */
type GetDomainRequest struct {
	DomainId *string `json:"domain_id" xml:"domain_id" require:"true"`
}

func (s GetDomainRequest) String() string {
	return tea.Prettify(s)
}

func (s GetDomainRequest) GoString() string {
	return s.String()
}

func (s *GetDomainRequest) SetDomainId(v string) *GetDomainRequest {
	s.DomainId = &v
	return s
}

/**
 * get domain response
 */
type GetDomainResponse struct {
	AuthAlipayAppId            *string                `json:"auth_alipay_app_id" xml:"auth_alipay_app_id"`
	AuthAlipayEnable           *bool                  `json:"auth_alipay_enable" xml:"auth_alipay_enable"`
	AuthAlipayPrivateKey       *string                `json:"auth_alipay_private_key" xml:"auth_alipay_private_key"`
	AuthConfig                 map[string]interface{} `json:"auth_config" xml:"auth_config"`
	AuthDingdingAppId          *string                `json:"auth_dingding_app_id" xml:"auth_dingding_app_id"`
	AuthDingdingAppSecret      *string                `json:"auth_dingding_app_secret" xml:"auth_dingding_app_secret"`
	AuthDingdingEnable         *bool                  `json:"auth_dingding_enable" xml:"auth_dingding_enable"`
	AuthEndpointEnable         *bool                  `json:"auth_endpoint_enable" xml:"auth_endpoint_enable"`
	AuthRamAppId               *string                `json:"auth_ram_app_id" xml:"auth_ram_app_id"`
	AuthRamAppSecret           *string                `json:"auth_ram_app_secret" xml:"auth_ram_app_secret"`
	AuthRamEnable              *bool                  `json:"auth_ram_enable" xml:"auth_ram_enable"`
	CreatedAt                  *string                `json:"created_at" xml:"created_at"`
	DataHashName               *string                `json:"data_hash_name" xml:"data_hash_name"`
	Description                *string                `json:"description" xml:"description"`
	DomainId                   *string                `json:"domain_id" xml:"domain_id"`
	DomainName                 *string                `json:"domain_name" xml:"domain_name"`
	EventFilenameMatches       *string                `json:"event_filename_matches" xml:"event_filename_matches"`
	EventMnsEndpoint           *string                `json:"event_mns_endpoint" xml:"event_mns_endpoint"`
	EventMnsTopic              *string                `json:"event_mns_topic" xml:"event_mns_topic"`
	EventNames                 []*string              `json:"event_names" xml:"event_names" type:"Repeated"`
	EventRoleArn               *string                `json:"event_role_arn" xml:"event_role_arn"`
	InitDriveEnable            *bool                  `json:"init_drive_enable" xml:"init_drive_enable"`
	InitDriveSize              *int64                 `json:"init_drive_size" xml:"init_drive_size"`
	InitDriveStoreId           *string                `json:"init_drive_store_id" xml:"init_drive_store_id"`
	PathType                   *string                `json:"path_type" xml:"path_type"`
	PublishedAppAccessStrategy *AppAccessStrategy     `json:"published_app_access_strategy" xml:"published_app_access_strategy"`
	Sharable                   *bool                  `json:"sharable" xml:"sharable"`
	StoreLevel                 *string                `json:"store_level" xml:"store_level"`
	StoreRegionList            []*string              `json:"store_region_list" xml:"store_region_list" type:"Repeated"`
	UpdatedAt                  *string                `json:"updated_at" xml:"updated_at"`
}

func (s GetDomainResponse) String() string {
	return tea.Prettify(s)
}

func (s GetDomainResponse) GoString() string {
	return s.String()
}

func (s *GetDomainResponse) SetAuthAlipayAppId(v string) *GetDomainResponse {
	s.AuthAlipayAppId = &v
	return s
}

func (s *GetDomainResponse) SetAuthAlipayEnable(v bool) *GetDomainResponse {
	s.AuthAlipayEnable = &v
	return s
}

func (s *GetDomainResponse) SetAuthAlipayPrivateKey(v string) *GetDomainResponse {
	s.AuthAlipayPrivateKey = &v
	return s
}

func (s *GetDomainResponse) SetAuthConfig(v map[string]interface{}) *GetDomainResponse {
	s.AuthConfig = v
	return s
}

func (s *GetDomainResponse) SetAuthDingdingAppId(v string) *GetDomainResponse {
	s.AuthDingdingAppId = &v
	return s
}

func (s *GetDomainResponse) SetAuthDingdingAppSecret(v string) *GetDomainResponse {
	s.AuthDingdingAppSecret = &v
	return s
}

func (s *GetDomainResponse) SetAuthDingdingEnable(v bool) *GetDomainResponse {
	s.AuthDingdingEnable = &v
	return s
}

func (s *GetDomainResponse) SetAuthEndpointEnable(v bool) *GetDomainResponse {
	s.AuthEndpointEnable = &v
	return s
}

func (s *GetDomainResponse) SetAuthRamAppId(v string) *GetDomainResponse {
	s.AuthRamAppId = &v
	return s
}

func (s *GetDomainResponse) SetAuthRamAppSecret(v string) *GetDomainResponse {
	s.AuthRamAppSecret = &v
	return s
}

func (s *GetDomainResponse) SetAuthRamEnable(v bool) *GetDomainResponse {
	s.AuthRamEnable = &v
	return s
}

func (s *GetDomainResponse) SetCreatedAt(v string) *GetDomainResponse {
	s.CreatedAt = &v
	return s
}

func (s *GetDomainResponse) SetDataHashName(v string) *GetDomainResponse {
	s.DataHashName = &v
	return s
}

func (s *GetDomainResponse) SetDescription(v string) *GetDomainResponse {
	s.Description = &v
	return s
}

func (s *GetDomainResponse) SetDomainId(v string) *GetDomainResponse {
	s.DomainId = &v
	return s
}

func (s *GetDomainResponse) SetDomainName(v string) *GetDomainResponse {
	s.DomainName = &v
	return s
}

func (s *GetDomainResponse) SetEventFilenameMatches(v string) *GetDomainResponse {
	s.EventFilenameMatches = &v
	return s
}

func (s *GetDomainResponse) SetEventMnsEndpoint(v string) *GetDomainResponse {
	s.EventMnsEndpoint = &v
	return s
}

func (s *GetDomainResponse) SetEventMnsTopic(v string) *GetDomainResponse {
	s.EventMnsTopic = &v
	return s
}

func (s *GetDomainResponse) SetEventNames(v []*string) *GetDomainResponse {
	s.EventNames = v
	return s
}

func (s *GetDomainResponse) SetEventRoleArn(v string) *GetDomainResponse {
	s.EventRoleArn = &v
	return s
}

func (s *GetDomainResponse) SetInitDriveEnable(v bool) *GetDomainResponse {
	s.InitDriveEnable = &v
	return s
}

func (s *GetDomainResponse) SetInitDriveSize(v int64) *GetDomainResponse {
	s.InitDriveSize = &v
	return s
}

func (s *GetDomainResponse) SetInitDriveStoreId(v string) *GetDomainResponse {
	s.InitDriveStoreId = &v
	return s
}

func (s *GetDomainResponse) SetPathType(v string) *GetDomainResponse {
	s.PathType = &v
	return s
}

func (s *GetDomainResponse) SetPublishedAppAccessStrategy(v *AppAccessStrategy) *GetDomainResponse {
	s.PublishedAppAccessStrategy = v
	return s
}

func (s *GetDomainResponse) SetSharable(v bool) *GetDomainResponse {
	s.Sharable = &v
	return s
}

func (s *GetDomainResponse) SetStoreLevel(v string) *GetDomainResponse {
	s.StoreLevel = &v
	return s
}

func (s *GetDomainResponse) SetStoreRegionList(v []*string) *GetDomainResponse {
	s.StoreRegionList = v
	return s
}

func (s *GetDomainResponse) SetUpdatedAt(v string) *GetDomainResponse {
	s.UpdatedAt = &v
	return s
}

/**
 *
 */
type ListAppsRequest struct {
	Limit  *int    `json:"limit" xml:"limit"`
	Marker *string `json:"marker" xml:"marker"`
}

func (s ListAppsRequest) String() string {
	return tea.Prettify(s)
}

func (s ListAppsRequest) GoString() string {
	return s.String()
}

func (s *ListAppsRequest) SetLimit(v int) *ListAppsRequest {
	s.Limit = &v
	return s
}

func (s *ListAppsRequest) SetMarker(v string) *ListAppsRequest {
	s.Marker = &v
	return s
}

/**
 *
 */
type ListAppsResponse struct {
	Items      []*GetAppResponse `json:"items" xml:"items" require:"true" type:"Repeated"`
	NextMarker *string           `json:"next_marker" xml:"next_marker"`
}

func (s ListAppsResponse) String() string {
	return tea.Prettify(s)
}

func (s ListAppsResponse) GoString() string {
	return s.String()
}

func (s *ListAppsResponse) SetItems(v []*GetAppResponse) *ListAppsResponse {
	s.Items = v
	return s
}

func (s *ListAppsResponse) SetNextMarker(v string) *ListAppsResponse {
	s.NextMarker = &v
	return s
}

/**
 * list domain cors response
 */
type ListDomainCORSRuleResponse struct {
	CorsRuleList []*CorsRule `json:"cors_rule_list" xml:"cors_rule_list" type:"Repeated"`
	DomainId     *string     `json:"domain_id" xml:"domain_id"`
}

func (s ListDomainCORSRuleResponse) String() string {
	return tea.Prettify(s)
}

func (s ListDomainCORSRuleResponse) GoString() string {
	return s.String()
}

func (s *ListDomainCORSRuleResponse) SetCorsRuleList(v []*CorsRule) *ListDomainCORSRuleResponse {
	s.CorsRuleList = v
	return s
}

func (s *ListDomainCORSRuleResponse) SetDomainId(v string) *ListDomainCORSRuleResponse {
	s.DomainId = &v
	return s
}

/**
 * list domain request
 */
type ListDomainsRequest struct {
	Limit  *int    `json:"limit" xml:"limit"`
	Marker *string `json:"marker" xml:"marker"`
}

func (s ListDomainsRequest) String() string {
	return tea.Prettify(s)
}

func (s ListDomainsRequest) GoString() string {
	return s.String()
}

func (s *ListDomainsRequest) SetLimit(v int) *ListDomainsRequest {
	s.Limit = &v
	return s
}

func (s *ListDomainsRequest) SetMarker(v string) *ListDomainsRequest {
	s.Marker = &v
	return s
}

/**
 * list domain response
 */
type ListDomainsResponse struct {
	Items      []*BaseDomainResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string               `json:"next_marker" xml:"next_marker"`
}

func (s ListDomainsResponse) String() string {
	return tea.Prettify(s)
}

func (s ListDomainsResponse) GoString() string {
	return s.String()
}

func (s *ListDomainsResponse) SetItems(v []*BaseDomainResponse) *ListDomainsResponse {
	s.Items = v
	return s
}

func (s *ListDomainsResponse) SetNextMarker(v string) *ListDomainsResponse {
	s.NextMarker = &v
	return s
}

/**
 *
 */
type ListStoresRequest struct {
	DomainId *string `json:"domain_id" xml:"domain_id" require:"true"`
}

func (s ListStoresRequest) String() string {
	return tea.Prettify(s)
}

func (s ListStoresRequest) GoString() string {
	return s.String()
}

func (s *ListStoresRequest) SetDomainId(v string) *ListStoresRequest {
	s.DomainId = &v
	return s
}

/**
 *
 */
type ListStoresResponse struct {
	Items []*Store `json:"items" xml:"items" require:"true" type:"Repeated"`
}

func (s ListStoresResponse) String() string {
	return tea.Prettify(s)
}

func (s ListStoresResponse) GoString() string {
	return s.String()
}

func (s *ListStoresResponse) SetItems(v []*Store) *ListStoresResponse {
	s.Items = v
	return s
}

/**
 *
 */
type RemoveStoreRequest struct {
	DomainId *string `json:"domain_id" xml:"domain_id" require:"true"`
	StoreId  *string `json:"store_id" xml:"store_id" require:"true"`
}

func (s RemoveStoreRequest) String() string {
	return tea.Prettify(s)
}

func (s RemoveStoreRequest) GoString() string {
	return s.String()
}

func (s *RemoveStoreRequest) SetDomainId(v string) *RemoveStoreRequest {
	s.DomainId = &v
	return s
}

func (s *RemoveStoreRequest) SetStoreId(v string) *RemoveStoreRequest {
	s.StoreId = &v
	return s
}

/**
 *
 */
type SetAppPublicKeyRequest struct {
	AppId     *string `json:"app_id" xml:"app_id" require:"true"`
	PublicKey *string `json:"public_key" xml:"public_key" require:"true"`
}

func (s SetAppPublicKeyRequest) String() string {
	return tea.Prettify(s)
}

func (s SetAppPublicKeyRequest) GoString() string {
	return s.String()
}

func (s *SetAppPublicKeyRequest) SetAppId(v string) *SetAppPublicKeyRequest {
	s.AppId = &v
	return s
}

func (s *SetAppPublicKeyRequest) SetPublicKey(v string) *SetAppPublicKeyRequest {
	s.PublicKey = &v
	return s
}

/**
 *
 */
type SetCorsRuleListRequest struct {
	CorsRuleList []*CorsRule `json:"cors_rule_list" xml:"cors_rule_list" require:"true" type:"Repeated"`
	DomainId     *string     `json:"domain_id" xml:"domain_id" require:"true"`
}

func (s SetCorsRuleListRequest) String() string {
	return tea.Prettify(s)
}

func (s SetCorsRuleListRequest) GoString() string {
	return s.String()
}

func (s *SetCorsRuleListRequest) SetCorsRuleList(v []*CorsRule) *SetCorsRuleListRequest {
	s.CorsRuleList = v
	return s
}

func (s *SetCorsRuleListRequest) SetDomainId(v string) *SetCorsRuleListRequest {
	s.DomainId = &v
	return s
}

/**
 *
 */
type Store struct {
	AccelerateEndpoint *string `json:"accelerate_endpoint" xml:"accelerate_endpoint"`
	BasePath           *string `json:"base_path" xml:"base_path"`
	Bucket             *string `json:"bucket" xml:"bucket" require:"true"`
	CustomizedEndpoint *string `json:"customized_endpoint" xml:"customized_endpoint"`
	Endpoint           *string `json:"endpoint" xml:"endpoint" require:"true"`
	InternalEndpoint   *string `json:"internal_endpoint" xml:"internal_endpoint"`
	Ownership          *string `json:"ownership" xml:"ownership" require:"true"`
	Policy             *string `json:"policy" xml:"policy" require:"true"`
	RoleArn            *string `json:"role_arn" xml:"role_arn"`
	StoreId            *string `json:"store_id" xml:"store_id" require:"true"`
	Type               *string `json:"type" xml:"type" require:"true"`
}

func (s Store) String() string {
	return tea.Prettify(s)
}

func (s Store) GoString() string {
	return s.String()
}

func (s *Store) SetAccelerateEndpoint(v string) *Store {
	s.AccelerateEndpoint = &v
	return s
}

func (s *Store) SetBasePath(v string) *Store {
	s.BasePath = &v
	return s
}

func (s *Store) SetBucket(v string) *Store {
	s.Bucket = &v
	return s
}

func (s *Store) SetCustomizedEndpoint(v string) *Store {
	s.CustomizedEndpoint = &v
	return s
}

func (s *Store) SetEndpoint(v string) *Store {
	s.Endpoint = &v
	return s
}

func (s *Store) SetInternalEndpoint(v string) *Store {
	s.InternalEndpoint = &v
	return s
}

func (s *Store) SetOwnership(v string) *Store {
	s.Ownership = &v
	return s
}

func (s *Store) SetPolicy(v string) *Store {
	s.Policy = &v
	return s
}

func (s *Store) SetRoleArn(v string) *Store {
	s.RoleArn = &v
	return s
}

func (s *Store) SetStoreId(v string) *Store {
	s.StoreId = &v
	return s
}

func (s *Store) SetType(v string) *Store {
	s.Type = &v
	return s
}

/**
 *
 */
type UpdateAppRequest struct {
	AppId       *string   `json:"app_id" xml:"app_id" require:"true"`
	AppName     *string   `json:"app_name" xml:"app_name" require:"true" maxLength:"128"`
	Description *string   `json:"description" xml:"description" maxLength:"128"`
	Logo        *string   `json:"logo" xml:"logo" require:"true"`
	RedirectUri *string   `json:"redirect_uri" xml:"redirect_uri" require:"true"`
	Scope       []*string `json:"scope" xml:"scope" require:"true" type:"Repeated"`
	Type        *string   `json:"type" xml:"type" require:"true"`
}

func (s UpdateAppRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateAppRequest) GoString() string {
	return s.String()
}

func (s *UpdateAppRequest) SetAppId(v string) *UpdateAppRequest {
	s.AppId = &v
	return s
}

func (s *UpdateAppRequest) SetAppName(v string) *UpdateAppRequest {
	s.AppName = &v
	return s
}

func (s *UpdateAppRequest) SetDescription(v string) *UpdateAppRequest {
	s.Description = &v
	return s
}

func (s *UpdateAppRequest) SetLogo(v string) *UpdateAppRequest {
	s.Logo = &v
	return s
}

func (s *UpdateAppRequest) SetRedirectUri(v string) *UpdateAppRequest {
	s.RedirectUri = &v
	return s
}

func (s *UpdateAppRequest) SetScope(v []*string) *UpdateAppRequest {
	s.Scope = v
	return s
}

func (s *UpdateAppRequest) SetType(v string) *UpdateAppRequest {
	s.Type = &v
	return s
}

/**
 * update domain request
 */
type UpdateDomainRequest struct {
	AuthAlipayAppId            *string                `json:"auth_alipay_app_id" xml:"auth_alipay_app_id"`
	AuthAlipayEnbale           *bool                  `json:"auth_alipay_enbale" xml:"auth_alipay_enbale"`
	AuthAlipayPrivateKey       *string                `json:"auth_alipay_private_key" xml:"auth_alipay_private_key"`
	AuthConfig                 map[string]interface{} `json:"auth_config" xml:"auth_config"`
	AuthDingdingAppId          *string                `json:"auth_dingding_app_id" xml:"auth_dingding_app_id"`
	AuthDingdingAppSecret      *string                `json:"auth_dingding_app_secret" xml:"auth_dingding_app_secret"`
	AuthDingdingEnable         *bool                  `json:"auth_dingding_enable" xml:"auth_dingding_enable"`
	AuthEndpointEnable         *bool                  `json:"auth_endpoint_enable" xml:"auth_endpoint_enable"`
	AuthRamAppId               *string                `json:"auth_ram_app_id" xml:"auth_ram_app_id"`
	AuthRamAppSecret           *string                `json:"auth_ram_app_secret" xml:"auth_ram_app_secret"`
	AuthRamEnable              *bool                  `json:"auth_ram_enable" xml:"auth_ram_enable"`
	DataHashName               *string                `json:"data_hash_name" xml:"data_hash_name"`
	Description                *string                `json:"description" xml:"description"`
	DomainId                   *string                `json:"domain_id" xml:"domain_id" require:"true"`
	DomainName                 *string                `json:"domain_name" xml:"domain_name"`
	EventFilenameMatches       *string                `json:"event_filename_matches" xml:"event_filename_matches"`
	EventMnsEndpoint           *string                `json:"event_mns_endpoint" xml:"event_mns_endpoint"`
	EventMnsTopic              *string                `json:"event_mns_topic" xml:"event_mns_topic"`
	EventNames                 []*string              `json:"event_names" xml:"event_names" type:"Repeated"`
	EventRoleArn               *string                `json:"event_role_arn" xml:"event_role_arn"`
	InitDriveEnable            *bool                  `json:"init_drive_enable" xml:"init_drive_enable"`
	InitDriveSize              *int64                 `json:"init_drive_size" xml:"init_drive_size"`
	InitDriveStoreId           *string                `json:"init_drive_store_id" xml:"init_drive_store_id"`
	PublishedAppAccessStrategy *AppAccessStrategy     `json:"published_app_access_strategy" xml:"published_app_access_strategy"`
	Sharable                   *bool                  `json:"sharable" xml:"sharable"`
}

func (s UpdateDomainRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateDomainRequest) GoString() string {
	return s.String()
}

func (s *UpdateDomainRequest) SetAuthAlipayAppId(v string) *UpdateDomainRequest {
	s.AuthAlipayAppId = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthAlipayEnbale(v bool) *UpdateDomainRequest {
	s.AuthAlipayEnbale = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthAlipayPrivateKey(v string) *UpdateDomainRequest {
	s.AuthAlipayPrivateKey = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthConfig(v map[string]interface{}) *UpdateDomainRequest {
	s.AuthConfig = v
	return s
}

func (s *UpdateDomainRequest) SetAuthDingdingAppId(v string) *UpdateDomainRequest {
	s.AuthDingdingAppId = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthDingdingAppSecret(v string) *UpdateDomainRequest {
	s.AuthDingdingAppSecret = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthDingdingEnable(v bool) *UpdateDomainRequest {
	s.AuthDingdingEnable = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthEndpointEnable(v bool) *UpdateDomainRequest {
	s.AuthEndpointEnable = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthRamAppId(v string) *UpdateDomainRequest {
	s.AuthRamAppId = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthRamAppSecret(v string) *UpdateDomainRequest {
	s.AuthRamAppSecret = &v
	return s
}

func (s *UpdateDomainRequest) SetAuthRamEnable(v bool) *UpdateDomainRequest {
	s.AuthRamEnable = &v
	return s
}

func (s *UpdateDomainRequest) SetDataHashName(v string) *UpdateDomainRequest {
	s.DataHashName = &v
	return s
}

func (s *UpdateDomainRequest) SetDescription(v string) *UpdateDomainRequest {
	s.Description = &v
	return s
}

func (s *UpdateDomainRequest) SetDomainId(v string) *UpdateDomainRequest {
	s.DomainId = &v
	return s
}

func (s *UpdateDomainRequest) SetDomainName(v string) *UpdateDomainRequest {
	s.DomainName = &v
	return s
}

func (s *UpdateDomainRequest) SetEventFilenameMatches(v string) *UpdateDomainRequest {
	s.EventFilenameMatches = &v
	return s
}

func (s *UpdateDomainRequest) SetEventMnsEndpoint(v string) *UpdateDomainRequest {
	s.EventMnsEndpoint = &v
	return s
}

func (s *UpdateDomainRequest) SetEventMnsTopic(v string) *UpdateDomainRequest {
	s.EventMnsTopic = &v
	return s
}

func (s *UpdateDomainRequest) SetEventNames(v []*string) *UpdateDomainRequest {
	s.EventNames = v
	return s
}

func (s *UpdateDomainRequest) SetEventRoleArn(v string) *UpdateDomainRequest {
	s.EventRoleArn = &v
	return s
}

func (s *UpdateDomainRequest) SetInitDriveEnable(v bool) *UpdateDomainRequest {
	s.InitDriveEnable = &v
	return s
}

func (s *UpdateDomainRequest) SetInitDriveSize(v int64) *UpdateDomainRequest {
	s.InitDriveSize = &v
	return s
}

func (s *UpdateDomainRequest) SetInitDriveStoreId(v string) *UpdateDomainRequest {
	s.InitDriveStoreId = &v
	return s
}

func (s *UpdateDomainRequest) SetPublishedAppAccessStrategy(v *AppAccessStrategy) *UpdateDomainRequest {
	s.PublishedAppAccessStrategy = v
	return s
}

func (s *UpdateDomainRequest) SetSharable(v bool) *UpdateDomainRequest {
	s.Sharable = &v
	return s
}

/**
 * create domain response
 */
type UpdateDomainResponse struct {
	AuthAlipayAppId            *string                `json:"auth_alipay_app_id" xml:"auth_alipay_app_id"`
	AuthAlipayEnable           *bool                  `json:"auth_alipay_enable" xml:"auth_alipay_enable"`
	AuthAlipayPrivateKey       *string                `json:"auth_alipay_private_key" xml:"auth_alipay_private_key"`
	AuthConfig                 map[string]interface{} `json:"auth_config" xml:"auth_config"`
	AuthDingdingAppId          *string                `json:"auth_dingding_app_id" xml:"auth_dingding_app_id"`
	AuthDingdingAppSecret      *string                `json:"auth_dingding_app_secret" xml:"auth_dingding_app_secret"`
	AuthDingdingEnable         *bool                  `json:"auth_dingding_enable" xml:"auth_dingding_enable"`
	AuthEndpointEnable         *bool                  `json:"auth_endpoint_enable" xml:"auth_endpoint_enable"`
	AuthRamAppId               *string                `json:"auth_ram_app_id" xml:"auth_ram_app_id"`
	AuthRamAppSecret           *string                `json:"auth_ram_app_secret" xml:"auth_ram_app_secret"`
	AuthRamEnable              *bool                  `json:"auth_ram_enable" xml:"auth_ram_enable"`
	CreatedAt                  *string                `json:"created_at" xml:"created_at"`
	DataHashName               *string                `json:"data_hash_name" xml:"data_hash_name"`
	Description                *string                `json:"description" xml:"description"`
	DomainId                   *string                `json:"domain_id" xml:"domain_id"`
	DomainName                 *string                `json:"domain_name" xml:"domain_name"`
	EventFilenameMatches       *string                `json:"event_filename_matches" xml:"event_filename_matches"`
	EventMnsEndpoint           *string                `json:"event_mns_endpoint" xml:"event_mns_endpoint"`
	EventMnsTopic              *string                `json:"event_mns_topic" xml:"event_mns_topic"`
	EventNames                 []*string              `json:"event_names" xml:"event_names" type:"Repeated"`
	EventRoleArn               *string                `json:"event_role_arn" xml:"event_role_arn"`
	InitDriveEnable            *bool                  `json:"init_drive_enable" xml:"init_drive_enable"`
	InitDriveSize              *int64                 `json:"init_drive_size" xml:"init_drive_size"`
	InitDriveStoreId           *string                `json:"init_drive_store_id" xml:"init_drive_store_id"`
	PathType                   *string                `json:"path_type" xml:"path_type"`
	PublishedAppAccessStrategy *AppAccessStrategy     `json:"published_app_access_strategy" xml:"published_app_access_strategy"`
	Sharable                   *bool                  `json:"sharable" xml:"sharable"`
	StoreLevel                 *string                `json:"store_level" xml:"store_level"`
	StoreRegionList            []*string              `json:"store_region_list" xml:"store_region_list" type:"Repeated"`
	UpdatedAt                  *string                `json:"updated_at" xml:"updated_at"`
}

func (s UpdateDomainResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateDomainResponse) GoString() string {
	return s.String()
}

func (s *UpdateDomainResponse) SetAuthAlipayAppId(v string) *UpdateDomainResponse {
	s.AuthAlipayAppId = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthAlipayEnable(v bool) *UpdateDomainResponse {
	s.AuthAlipayEnable = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthAlipayPrivateKey(v string) *UpdateDomainResponse {
	s.AuthAlipayPrivateKey = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthConfig(v map[string]interface{}) *UpdateDomainResponse {
	s.AuthConfig = v
	return s
}

func (s *UpdateDomainResponse) SetAuthDingdingAppId(v string) *UpdateDomainResponse {
	s.AuthDingdingAppId = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthDingdingAppSecret(v string) *UpdateDomainResponse {
	s.AuthDingdingAppSecret = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthDingdingEnable(v bool) *UpdateDomainResponse {
	s.AuthDingdingEnable = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthEndpointEnable(v bool) *UpdateDomainResponse {
	s.AuthEndpointEnable = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthRamAppId(v string) *UpdateDomainResponse {
	s.AuthRamAppId = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthRamAppSecret(v string) *UpdateDomainResponse {
	s.AuthRamAppSecret = &v
	return s
}

func (s *UpdateDomainResponse) SetAuthRamEnable(v bool) *UpdateDomainResponse {
	s.AuthRamEnable = &v
	return s
}

func (s *UpdateDomainResponse) SetCreatedAt(v string) *UpdateDomainResponse {
	s.CreatedAt = &v
	return s
}

func (s *UpdateDomainResponse) SetDataHashName(v string) *UpdateDomainResponse {
	s.DataHashName = &v
	return s
}

func (s *UpdateDomainResponse) SetDescription(v string) *UpdateDomainResponse {
	s.Description = &v
	return s
}

func (s *UpdateDomainResponse) SetDomainId(v string) *UpdateDomainResponse {
	s.DomainId = &v
	return s
}

func (s *UpdateDomainResponse) SetDomainName(v string) *UpdateDomainResponse {
	s.DomainName = &v
	return s
}

func (s *UpdateDomainResponse) SetEventFilenameMatches(v string) *UpdateDomainResponse {
	s.EventFilenameMatches = &v
	return s
}

func (s *UpdateDomainResponse) SetEventMnsEndpoint(v string) *UpdateDomainResponse {
	s.EventMnsEndpoint = &v
	return s
}

func (s *UpdateDomainResponse) SetEventMnsTopic(v string) *UpdateDomainResponse {
	s.EventMnsTopic = &v
	return s
}

func (s *UpdateDomainResponse) SetEventNames(v []*string) *UpdateDomainResponse {
	s.EventNames = v
	return s
}

func (s *UpdateDomainResponse) SetEventRoleArn(v string) *UpdateDomainResponse {
	s.EventRoleArn = &v
	return s
}

func (s *UpdateDomainResponse) SetInitDriveEnable(v bool) *UpdateDomainResponse {
	s.InitDriveEnable = &v
	return s
}

func (s *UpdateDomainResponse) SetInitDriveSize(v int64) *UpdateDomainResponse {
	s.InitDriveSize = &v
	return s
}

func (s *UpdateDomainResponse) SetInitDriveStoreId(v string) *UpdateDomainResponse {
	s.InitDriveStoreId = &v
	return s
}

func (s *UpdateDomainResponse) SetPathType(v string) *UpdateDomainResponse {
	s.PathType = &v
	return s
}

func (s *UpdateDomainResponse) SetPublishedAppAccessStrategy(v *AppAccessStrategy) *UpdateDomainResponse {
	s.PublishedAppAccessStrategy = v
	return s
}

func (s *UpdateDomainResponse) SetSharable(v bool) *UpdateDomainResponse {
	s.Sharable = &v
	return s
}

func (s *UpdateDomainResponse) SetStoreLevel(v string) *UpdateDomainResponse {
	s.StoreLevel = &v
	return s
}

func (s *UpdateDomainResponse) SetStoreRegionList(v []*string) *UpdateDomainResponse {
	s.StoreRegionList = v
	return s
}

func (s *UpdateDomainResponse) SetUpdatedAt(v string) *UpdateDomainResponse {
	s.UpdatedAt = &v
	return s
}

/**
 *
 */
type UserAuthentication struct {
	AuthenticationType *string `json:"AuthenticationType" xml:"AuthenticationType" require:"true"`
	CreatedAt          *int64  `json:"CreatedAt" xml:"CreatedAt" require:"true"`
	Detail             *string `json:"Detail" xml:"Detail" require:"true"`
	DomainID           *string `json:"DomainID" xml:"DomainID" require:"true"`
	Identity           *string `json:"Identity" xml:"Identity" require:"true"`
	LastLoginTime      *int64  `json:"LastLoginTime" xml:"LastLoginTime" require:"true"`
	Status             *string `json:"Status" xml:"Status" require:"true"`
	UserID             *string `json:"UserID" xml:"UserID" require:"true"`
	Extra              *string `json:"extra" xml:"extra"`
}

func (s UserAuthentication) String() string {
	return tea.Prettify(s)
}

func (s UserAuthentication) GoString() string {
	return s.String()
}

func (s *UserAuthentication) SetAuthenticationType(v string) *UserAuthentication {
	s.AuthenticationType = &v
	return s
}

func (s *UserAuthentication) SetCreatedAt(v int64) *UserAuthentication {
	s.CreatedAt = &v
	return s
}

func (s *UserAuthentication) SetDetail(v string) *UserAuthentication {
	s.Detail = &v
	return s
}

func (s *UserAuthentication) SetDomainID(v string) *UserAuthentication {
	s.DomainID = &v
	return s
}

func (s *UserAuthentication) SetIdentity(v string) *UserAuthentication {
	s.Identity = &v
	return s
}

func (s *UserAuthentication) SetLastLoginTime(v int64) *UserAuthentication {
	s.LastLoginTime = &v
	return s
}

func (s *UserAuthentication) SetStatus(v string) *UserAuthentication {
	s.Status = &v
	return s
}

func (s *UserAuthentication) SetUserID(v string) *UserAuthentication {
	s.UserID = &v
	return s
}

func (s *UserAuthentication) SetExtra(v string) *UserAuthentication {
	s.Extra = &v
	return s
}

type Client struct {
	Region     string
	Endpoint   string
	Protocol   string
	Nickname   string
	UserAgent  string
	Credential credential.Credential
}

func NewClient(config *Config) (*Client, error) {
	client := new(Client)
	err := client.Init(config)
	return client, err
}

func (client *Client) Init(config *Config) (_err error) {
	if util.IsUnset(tea.ToMap(config)) {
		_err = tea.NewSDKError(map[string]interface{}{
			"name":    "ParameterMissing",
			"message": "'config' can not be unset",
		})
		return _err
	}

	if util.Empty(tea.StringValue(config.Region)) {
		_err = tea.NewSDKError(map[string]interface{}{
			"name":    "ParameterMissing",
			"message": "'config.region' can not be empty",
		})
		return _err
	}

	if !util.Empty(tea.StringValue(config.AccessKeyId)) {
		if util.Empty(tea.StringValue(config.Type)) {
			config.Type = tea.String("access_key")
		}

		credentialConfig := &credential.Config{
			AccessKeyId:     config.AccessKeyId,
			Type:            config.Type,
			AccessKeySecret: config.AccessKeySecret,
			SecurityToken:   config.SecurityToken,
		}
		client.Credential, _err = credential.NewCredential(credentialConfig)
		if _err != nil {
			return _err
		}

	}

	client.Endpoint = tea.StringValue(config.Endpoint)
	client.Protocol = tea.StringValue(config.Protocol)
	client.UserAgent = tea.StringValue(config.UserAgent)
	client.Nickname = tea.StringValue(config.Nickname)
	client.Region = tea.StringValue(config.Region)
	return nil
}

/**
 * 创建App
 * @tags app
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) CreateApp(request *CreateAppRequestModel, runtime *RuntimeOptions) (_result *CreateAppModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &CreateAppModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*CreateAppModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/app/create")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &CreateAppModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 删除App
 * @tags app
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error NotFound The resource {resource_name} cannot be found. Please check.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) DeleteApp(request *DeleteAppRequestModel, runtime *RuntimeOptions) (_result *DeleteAppModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteAppModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteAppModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/app/delete")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				_result = &DeleteAppModel{}
				_err = tea.Convert(map[string]map[string]string{
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 查询App
 * @tags app
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error NotFound The resource {resource_name} cannot be found. Please check.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) GetApp(request *GetAppRequestModel, runtime *RuntimeOptions) (_result *GetAppModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetAppModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetAppModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/app/get")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &GetAppModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 查询App设置的公钥
 * @tags app
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) GetPublicKey(request *GetPublicKeyRequestModel, runtime *RuntimeOptions) (_result *GetPublicKeyModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetPublicKeyModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetPublicKeyModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/app/get_public_key")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &GetPublicKeyModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 查询App列表
 * @tags app
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) ListApp(request *ListAppRequestModel, runtime *RuntimeOptions) (_result *ListAppModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &ListAppModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListAppModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/app/list")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &ListAppModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 查询已发布的App列表
 * @tags app
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) ListPublishedApp(request *ListPublishedAppRequestModel, runtime *RuntimeOptions) (_result *ListPublishedAppModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &ListPublishedAppModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListPublishedAppModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/app/list_published")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &ListPublishedAppModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 设置App公钥
 * @tags app
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) SetPublicKey(request *SetPublicKeyRequestModel, runtime *RuntimeOptions) (_result *SetPublicKeyModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &SetPublicKeyModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*SetPublicKeyModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/app/set_public_key")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &SetPublicKeyModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 修改App
 * @tags app
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error NotFound The resource {resource_name} cannot be found. Please check.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) UpdateApp(request *UpdateAppRequestModel, runtime *RuntimeOptions) (_result *UpdateAppModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &UpdateAppModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*UpdateAppModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/app/update")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &UpdateAppModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 添加Store
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) AddStore(request *AddStoreRequestModel, runtime *RuntimeOptions) (_result *AddStoreModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &AddStoreModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AddStoreModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/add_store")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &AddStoreModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 创建 Domain
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
 * @error InternalError The request has been failed due to some unknown error.
 * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
 */
func (client *Client) CreateDomain(request *CreateDomainRequestModel, runtime *RuntimeOptions) (_result *CreateDomainModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &CreateDomainModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*CreateDomainModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/create")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &CreateDomainModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 删除 Domain
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
 * @error NotFound The resource {resource_name} cannot be found. Please check.
 * @error InternalError The request has been failed due to some unknown error.
 * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
 */
func (client *Client) DeleteDomain(request *DeleteDomainRequestModel, runtime *RuntimeOptions) (_result *DeleteDomainModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &DeleteDomainModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*DeleteDomainModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/delete")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				_result = &DeleteDomainModel{}
				_err = tea.Convert(map[string]map[string]string{
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 获取 Domain
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
 * @error NotFound The resource {resource_name} cannot be found. Please check.
 * @error InternalError The request has been failed due to some unknown error.
 * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
 */
func (client *Client) GetDomain(request *GetDomainRequestModel, runtime *RuntimeOptions) (_result *GetDomainModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetDomainModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetDomainModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/get")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &GetDomainModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 获取 domain 跨域规则列表
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error NotFound The resource {resource_name} cannot be found. Please check.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) GetCorsRuleList(request *GetCorsRuleListRequestModel, runtime *RuntimeOptions) (_result *GetCorsRuleListModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &GetCorsRuleListModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetCorsRuleListModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/get_cors_rules")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &GetCorsRuleListModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 列举 Domain
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
 * @error InternalError The request has been failed due to some unknown error.
 * @error undefined undefined
 */
func (client *Client) ListDomain(request *ListDomainRequestModel, runtime *RuntimeOptions) (_result *ListDomainModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &ListDomainModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListDomainModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/list")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &ListDomainModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 查询Store列表
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) ListStores(request *ListStoresRequestModel, runtime *RuntimeOptions) (_result *ListStoresModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &ListStoresModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListStoresModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/list_stores")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &ListStoresModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 移除Store
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) RemoveStore(request *RemoveStoreRequestModel, runtime *RuntimeOptions) (_result *RemoveStoreModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &RemoveStoreModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*RemoveStoreModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/remove_store")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				_result = &RemoveStoreModel{}
				_err = tea.Convert(map[string]map[string]string{
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 增加 domain 跨域规则
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error Forbidden User not authorized to operate on the specified APIs.
 * @error NotFound The resource {resource_name} cannot be found. Please check.
 * @error InternalError The request has been failed due to some unknown error.
 */
func (client *Client) SetCorsRuleList(request *SetCorsRuleListRequestModel, runtime *RuntimeOptions) (_result *SetCorsRuleListModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &SetCorsRuleListModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*SetCorsRuleListModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/set_cors_rules")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &SetCorsRuleListModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

/**
 * 更新 Domain
 * @tags domain
 * @error InvalidParameter The input parameter {parameter_name} is not valid.
 * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
 * @error NotFound The resource {resource_name} cannot be found. Please check.
 * @error InternalError The request has been failed due to some unknown error.
 * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
 */
func (client *Client) UpdateDomain(request *UpdateDomainRequestModel, runtime *RuntimeOptions) (_result *UpdateDomainModel, _err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return nil, _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return nil, _err
	}
	_runtime := map[string]interface{}{
		"timeouted":      "retry",
		"readTimeout":    tea.IntValue(runtime.ReadTimeout),
		"connectTimeout": tea.IntValue(runtime.ConnectTimeout),
		"localAddr":      tea.StringValue(runtime.LocalAddr),
		"httpProxy":      tea.StringValue(runtime.HttpProxy),
		"httpsProxy":     tea.StringValue(runtime.HttpsProxy),
		"noProxy":        tea.StringValue(runtime.NoProxy),
		"maxIdleConns":   tea.IntValue(runtime.MaxIdleConns),
		"socks5Proxy":    tea.StringValue(runtime.Socks5Proxy),
		"socks5NetWork":  tea.StringValue(runtime.Socks5NetWork),
		"retry": map[string]interface{}{
			"retryable":   tea.BoolValue(runtime.Autoretry),
			"maxAttempts": util.DefaultNumber(tea.IntValue(runtime.MaxAttempts), 3),
		},
		"backoff": map[string]interface{}{
			"policy": util.DefaultString(tea.StringValue(runtime.BackoffPolicy), "no"),
			"period": util.DefaultNumber(tea.IntValue(runtime.BackoffPeriod), 1),
		},
		"ignoreSSL": tea.BoolValue(runtime.IgnoreSSL),
	}

	_resp := &UpdateDomainModel{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*UpdateDomainModel, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetSecurityToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/update")
			request_.Headers = tea.Merge(map[string]string{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.Region)+".admin.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Headers)
			if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
				if !util.Empty(securityToken) {
					request_.Headers["x-acs-security-token"] = securityToken
				}

				request_.Headers["date"] = util.GetDateUTCString()
				request_.Headers["accept"] = "application/json"
				request_.Headers["x-acs-signature-method"] = "HMAC-SHA1"
				request_.Headers["x-acs-signature-version"] = "1.0"
				stringToSign := roautil.GetStringToSign(request_)
				request_.Headers["authorization"] = "acs " + tea.ToString(accesskeyId) + ":" + tea.ToString(roautil.GetSignature(stringToSign, accessKeySecret))
			}

			request_.Body = tea.ToReader(util.ToJSONString(tea.ToMap(request.Body)))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &UpdateDomainModel{}
				_err = tea.Convert(map[string]interface{}{
					"body":    respMap,
					"headers": response_.Headers,
				}, &_result)
				return _result, _err
			}

			if !util.Empty(response_.Headers["x-ca-error-message"]) {
				_err = tea.NewSDKError(map[string]interface{}{
					"data": map[string]interface{}{
						"requestId":     response_.Headers["x-ca-request-id"],
						"statusCode":    response_.StatusCode,
						"statusMessage": response_.StatusMessage,
					},
					"message": response_.Headers["x-ca-error-message"],
				})
				return nil, _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return nil, _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return nil, _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _resp, _err
}

func (client *Client) GetPathname(nickname string, path string) (_result string) {
	if util.Empty(nickname) {
		_result = path
		return _result
	}

	_result = "/" + tea.ToString(nickname) + tea.ToString(path)
	return _result
}

func (client *Client) SetUserAgent(userAgent string) {
	client.UserAgent = userAgent
}

func (client *Client) AppendUserAgent(userAgent string) {
	client.UserAgent = tea.ToString(client.UserAgent) + " " + tea.ToString(userAgent)
}

func (client *Client) GetUserAgent() (_result string) {
	userAgent := util.GetUserAgent(client.UserAgent)
	_result = userAgent
	return _result
}

func (client *Client) GetAccessKeyId() (_result string, _err error) {
	if util.IsUnset(client.Credential) {
		return _result, _err
	}

	accessKeyId, _err := client.Credential.GetAccessKeyId()
	if _err != nil {
		return "", _err
	}

	_result = accessKeyId
	return _result, _err
}

func (client *Client) GetAccessKeySecret() (_result string, _err error) {
	if util.IsUnset(client.Credential) {
		return _result, _err
	}

	secret, _err := client.Credential.GetAccessKeySecret()
	if _err != nil {
		return "", _err
	}

	_result = secret
	return _result, _err
}

func (client *Client) GetSecurityToken() (_result string, _err error) {
	if util.IsUnset(client.Credential) {
		return _result, _err
	}

	token, _err := client.Credential.GetSecurityToken()
	if _err != nil {
		return "", _err
	}

	_result = token
	return _result, _err
}
