// This file is auto-generated, don't edit it. Thanks.
package client

import (
	"github.com/alibabacloud-go/tea/tea"
	accesstokencredential "github.com/aliyun/aliyun-ccp/credential/golang/service"
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
	DomainId        *string `json:"domainId" xml:"domainId" require:"true"`
	Protocol        *string `json:"protocol" xml:"protocol"`
	CredentialType  *string `json:"credentialType" xml:"credentialType"`
	SecurityToken   *string `json:"securityToken" xml:"securityToken"`
	AccessKeyId     *string `json:"accessKeyId" xml:"accessKeyId"`
	AccessKeySecret *string `json:"accessKeySecret" xml:"accessKeySecret"`
	ClientId        *string `json:"clientId" xml:"clientId"`
	RefreshToken    *string `json:"refreshToken" xml:"refreshToken"`
	ClientSecret    *string `json:"clientSecret" xml:"clientSecret"`
	AccessToken     *string `json:"accessToken" xml:"accessToken"`
	ExpireTime      *string `json:"expireTime" xml:"expireTime"`
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

func (s *Config) SetDomainId(v string) *Config {
	s.DomainId = &v
	return s
}

func (s *Config) SetProtocol(v string) *Config {
	s.Protocol = &v
	return s
}

func (s *Config) SetCredentialType(v string) *Config {
	s.CredentialType = &v
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

func (s *Config) SetClientId(v string) *Config {
	s.ClientId = &v
	return s
}

func (s *Config) SetRefreshToken(v string) *Config {
	s.RefreshToken = &v
	return s
}

func (s *Config) SetClientSecret(v string) *Config {
	s.ClientSecret = &v
	return s
}

func (s *Config) SetAccessToken(v string) *Config {
	s.AccessToken = &v
	return s
}

func (s *Config) SetExpireTime(v string) *Config {
	s.ExpireTime = &v
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

type AccountAccessTokenResponse struct {
	RequestId      *string     `json:"requestId" xml:"requestId"`
	AccessToken    *string     `json:"access_token" xml:"access_token" require:"true"`
	Avatar         *string     `json:"avatar" xml:"avatar"`
	DefaultDriveId *string     `json:"default_drive_id" xml:"default_drive_id"`
	ExistLink      []*LinkInfo `json:"exist_link" xml:"exist_link" type:"Repeated"`
	ExpireTime     *string     `json:"expire_time" xml:"expire_time"`
	ExpiresIn      *int64      `json:"expires_in" xml:"expires_in"`
	NeedLink       *bool       `json:"need_link" xml:"need_link" require:"true"`
	NickName       *string     `json:"nick_name" xml:"nick_name"`
	RefreshToken   *string     `json:"refresh_token" xml:"refresh_token"`
	Role           *string     `json:"role" xml:"role"`
	State          *string     `json:"state" xml:"state"`
	TokenType      *string     `json:"token_type" xml:"token_type"`
	UserId         *string     `json:"user_id" xml:"user_id"`
	UserName       *string     `json:"user_name" xml:"user_name"`
}

func (s AccountAccessTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s AccountAccessTokenResponse) GoString() string {
	return s.String()
}

func (s *AccountAccessTokenResponse) SetRequestId(v string) *AccountAccessTokenResponse {
	s.RequestId = &v
	return s
}

func (s *AccountAccessTokenResponse) SetAccessToken(v string) *AccountAccessTokenResponse {
	s.AccessToken = &v
	return s
}

func (s *AccountAccessTokenResponse) SetAvatar(v string) *AccountAccessTokenResponse {
	s.Avatar = &v
	return s
}

func (s *AccountAccessTokenResponse) SetDefaultDriveId(v string) *AccountAccessTokenResponse {
	s.DefaultDriveId = &v
	return s
}

func (s *AccountAccessTokenResponse) SetExistLink(v []*LinkInfo) *AccountAccessTokenResponse {
	s.ExistLink = v
	return s
}

func (s *AccountAccessTokenResponse) SetExpireTime(v string) *AccountAccessTokenResponse {
	s.ExpireTime = &v
	return s
}

func (s *AccountAccessTokenResponse) SetExpiresIn(v int64) *AccountAccessTokenResponse {
	s.ExpiresIn = &v
	return s
}

func (s *AccountAccessTokenResponse) SetNeedLink(v bool) *AccountAccessTokenResponse {
	s.NeedLink = &v
	return s
}

func (s *AccountAccessTokenResponse) SetNickName(v string) *AccountAccessTokenResponse {
	s.NickName = &v
	return s
}

func (s *AccountAccessTokenResponse) SetRefreshToken(v string) *AccountAccessTokenResponse {
	s.RefreshToken = &v
	return s
}

func (s *AccountAccessTokenResponse) SetRole(v string) *AccountAccessTokenResponse {
	s.Role = &v
	return s
}

func (s *AccountAccessTokenResponse) SetState(v string) *AccountAccessTokenResponse {
	s.State = &v
	return s
}

func (s *AccountAccessTokenResponse) SetTokenType(v string) *AccountAccessTokenResponse {
	s.TokenType = &v
	return s
}

func (s *AccountAccessTokenResponse) SetUserId(v string) *AccountAccessTokenResponse {
	s.UserId = &v
	return s
}

func (s *AccountAccessTokenResponse) SetUserName(v string) *AccountAccessTokenResponse {
	s.UserName = &v
	return s
}

type AccountLinkRequest struct {
	Header   *AccountLinkRequestHeader `json:"header" xml:"header" type:"Struct"`
	Detail   *string                   `json:"detail" xml:"detail"`
	Identity *string                   `json:"identity" xml:"identity" require:"true"`
	Status   *string                   `json:"status" xml:"status"`
	Type     *string                   `json:"type" xml:"type" require:"true"`
	UserId   *string                   `json:"user_id" xml:"user_id" require:"true"`
}

func (s AccountLinkRequest) String() string {
	return tea.Prettify(s)
}

func (s AccountLinkRequest) GoString() string {
	return s.String()
}

func (s *AccountLinkRequest) SetHeader(v *AccountLinkRequestHeader) *AccountLinkRequest {
	s.Header = v
	return s
}

func (s *AccountLinkRequest) SetDetail(v string) *AccountLinkRequest {
	s.Detail = &v
	return s
}

func (s *AccountLinkRequest) SetIdentity(v string) *AccountLinkRequest {
	s.Identity = &v
	return s
}

func (s *AccountLinkRequest) SetStatus(v string) *AccountLinkRequest {
	s.Status = &v
	return s
}

func (s *AccountLinkRequest) SetType(v string) *AccountLinkRequest {
	s.Type = &v
	return s
}

func (s *AccountLinkRequest) SetUserId(v string) *AccountLinkRequest {
	s.UserId = &v
	return s
}

type AccountLinkRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s AccountLinkRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s AccountLinkRequestHeader) GoString() string {
	return s.String()
}

func (s *AccountLinkRequestHeader) SetTraceId(v string) *AccountLinkRequestHeader {
	s.TraceId = &v
	return s
}

func (s *AccountLinkRequestHeader) SetDeviceId(v string) *AccountLinkRequestHeader {
	s.DeviceId = &v
	return s
}

type AddStoreRequest struct {
	Header    *AddStoreRequestHeader `json:"header" xml:"header" type:"Struct"`
	BasePath  *string                `json:"base_path" xml:"base_path"`
	Bucket    *string                `json:"bucket" xml:"bucket"`
	DomainId  *string                `json:"domain_id" xml:"domain_id" require:"true"`
	Endpoint  *string                `json:"endpoint" xml:"endpoint" require:"true"`
	Ownership *string                `json:"ownership" xml:"ownership"`
	RoleArn   *string                `json:"role_arn" xml:"role_arn"`
	Type      *string                `json:"type" xml:"type" require:"true"`
}

func (s AddStoreRequest) String() string {
	return tea.Prettify(s)
}

func (s AddStoreRequest) GoString() string {
	return s.String()
}

func (s *AddStoreRequest) SetHeader(v *AddStoreRequestHeader) *AddStoreRequest {
	s.Header = v
	return s
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

type AddStoreRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s AddStoreRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s AddStoreRequestHeader) GoString() string {
	return s.String()
}

func (s *AddStoreRequestHeader) SetTraceId(v string) *AddStoreRequestHeader {
	s.TraceId = &v
	return s
}

func (s *AddStoreRequestHeader) SetDeviceId(v string) *AddStoreRequestHeader {
	s.DeviceId = &v
	return s
}

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

type AuthConfig struct {
	AppId        *string `json:"app_id" xml:"app_id"`
	AppSecret    *string `json:"app_secret" xml:"app_secret"`
	Enable       *bool   `json:"enable" xml:"enable"`
	Endpoint     *string `json:"endpoint" xml:"endpoint"`
	EnterpriseId *string `json:"enterprise_id" xml:"enterprise_id"`
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

type BaseCCPFileResponse struct {
	RequestId          *string             `json:"requestId" xml:"requestId"`
	Category           *string             `json:"category" xml:"category"`
	ContentHash        *string             `json:"content_hash" xml:"content_hash"`
	ContentHashName    *string             `json:"content_hash_name" xml:"content_hash_name"`
	ContentType        *string             `json:"content_type" xml:"content_type"`
	Crc64Hash          *string             `json:"crc64_hash" xml:"crc64_hash"`
	CreatedAt          *string             `json:"created_at" xml:"created_at"`
	Description        *string             `json:"description" xml:"description"`
	DomainId           *string             `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DownloadUrl        *string             `json:"download_url" xml:"download_url"`
	DriveId            *string             `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileExtension      *string             `json:"file_extension" xml:"file_extension"`
	FileId             *string             `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	Hidden             *bool               `json:"hidden" xml:"hidden"`
	ImageMediaMetadata *ImageMediaResponse `json:"image_media_metadata" xml:"image_media_metadata"`
	Labels             []*string           `json:"labels" xml:"labels" type:"Repeated"`
	Meta               *string             `json:"meta" xml:"meta"`
	Name               *string             `json:"name" xml:"name" require:"true" pattern:"[a-zA-Z0-9.-]{1,1024}"`
	ParentFileId       *string             `json:"parent_file_id" xml:"parent_file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	Size               *int64              `json:"size" xml:"size"`
	Starred            *bool               `json:"starred" xml:"starred"`
	Status             *string             `json:"status" xml:"status"`
	Thumbnail          *string             `json:"thumbnail" xml:"thumbnail"`
	TrashedAt          *string             `json:"trashed_at" xml:"trashed_at"`
	Type               *string             `json:"type" xml:"type"`
	UpdatedAt          *string             `json:"updated_at" xml:"updated_at"`
	UploadId           *string             `json:"upload_id" xml:"upload_id"`
	Url                *string             `json:"url" xml:"url"`
}

func (s BaseCCPFileResponse) String() string {
	return tea.Prettify(s)
}

func (s BaseCCPFileResponse) GoString() string {
	return s.String()
}

func (s *BaseCCPFileResponse) SetRequestId(v string) *BaseCCPFileResponse {
	s.RequestId = &v
	return s
}

func (s *BaseCCPFileResponse) SetCategory(v string) *BaseCCPFileResponse {
	s.Category = &v
	return s
}

func (s *BaseCCPFileResponse) SetContentHash(v string) *BaseCCPFileResponse {
	s.ContentHash = &v
	return s
}

func (s *BaseCCPFileResponse) SetContentHashName(v string) *BaseCCPFileResponse {
	s.ContentHashName = &v
	return s
}

func (s *BaseCCPFileResponse) SetContentType(v string) *BaseCCPFileResponse {
	s.ContentType = &v
	return s
}

func (s *BaseCCPFileResponse) SetCrc64Hash(v string) *BaseCCPFileResponse {
	s.Crc64Hash = &v
	return s
}

func (s *BaseCCPFileResponse) SetCreatedAt(v string) *BaseCCPFileResponse {
	s.CreatedAt = &v
	return s
}

func (s *BaseCCPFileResponse) SetDescription(v string) *BaseCCPFileResponse {
	s.Description = &v
	return s
}

func (s *BaseCCPFileResponse) SetDomainId(v string) *BaseCCPFileResponse {
	s.DomainId = &v
	return s
}

func (s *BaseCCPFileResponse) SetDownloadUrl(v string) *BaseCCPFileResponse {
	s.DownloadUrl = &v
	return s
}

func (s *BaseCCPFileResponse) SetDriveId(v string) *BaseCCPFileResponse {
	s.DriveId = &v
	return s
}

func (s *BaseCCPFileResponse) SetFileExtension(v string) *BaseCCPFileResponse {
	s.FileExtension = &v
	return s
}

func (s *BaseCCPFileResponse) SetFileId(v string) *BaseCCPFileResponse {
	s.FileId = &v
	return s
}

func (s *BaseCCPFileResponse) SetHidden(v bool) *BaseCCPFileResponse {
	s.Hidden = &v
	return s
}

func (s *BaseCCPFileResponse) SetImageMediaMetadata(v *ImageMediaResponse) *BaseCCPFileResponse {
	s.ImageMediaMetadata = v
	return s
}

func (s *BaseCCPFileResponse) SetLabels(v []*string) *BaseCCPFileResponse {
	s.Labels = v
	return s
}

func (s *BaseCCPFileResponse) SetMeta(v string) *BaseCCPFileResponse {
	s.Meta = &v
	return s
}

func (s *BaseCCPFileResponse) SetName(v string) *BaseCCPFileResponse {
	s.Name = &v
	return s
}

func (s *BaseCCPFileResponse) SetParentFileId(v string) *BaseCCPFileResponse {
	s.ParentFileId = &v
	return s
}

func (s *BaseCCPFileResponse) SetSize(v int64) *BaseCCPFileResponse {
	s.Size = &v
	return s
}

func (s *BaseCCPFileResponse) SetStarred(v bool) *BaseCCPFileResponse {
	s.Starred = &v
	return s
}

func (s *BaseCCPFileResponse) SetStatus(v string) *BaseCCPFileResponse {
	s.Status = &v
	return s
}

func (s *BaseCCPFileResponse) SetThumbnail(v string) *BaseCCPFileResponse {
	s.Thumbnail = &v
	return s
}

func (s *BaseCCPFileResponse) SetTrashedAt(v string) *BaseCCPFileResponse {
	s.TrashedAt = &v
	return s
}

func (s *BaseCCPFileResponse) SetType(v string) *BaseCCPFileResponse {
	s.Type = &v
	return s
}

func (s *BaseCCPFileResponse) SetUpdatedAt(v string) *BaseCCPFileResponse {
	s.UpdatedAt = &v
	return s
}

func (s *BaseCCPFileResponse) SetUploadId(v string) *BaseCCPFileResponse {
	s.UploadId = &v
	return s
}

func (s *BaseCCPFileResponse) SetUrl(v string) *BaseCCPFileResponse {
	s.Url = &v
	return s
}

type BaseDriveResponse struct {
	RequestId    *string `json:"requestId" xml:"requestId"`
	Creator      *string `json:"creator" xml:"creator"`
	Description  *string `json:"description" xml:"description"`
	DomainId     *string `json:"domain_id" xml:"domain_id"`
	DriveId      *string `json:"drive_id" xml:"drive_id"`
	DriveName    *string `json:"drive_name" xml:"drive_name"`
	DriveType    *string `json:"drive_type" xml:"drive_type"`
	Owner        *string `json:"owner" xml:"owner"`
	RelativePath *string `json:"relative_path" xml:"relative_path"`
	Status       *string `json:"status" xml:"status"`
	StoreId      *string `json:"store_id" xml:"store_id"`
	TotalSize    *int64  `json:"total_size" xml:"total_size"`
	UsedSize     *int64  `json:"used_size" xml:"used_size"`
}

func (s BaseDriveResponse) String() string {
	return tea.Prettify(s)
}

func (s BaseDriveResponse) GoString() string {
	return s.String()
}

func (s *BaseDriveResponse) SetRequestId(v string) *BaseDriveResponse {
	s.RequestId = &v
	return s
}

func (s *BaseDriveResponse) SetCreator(v string) *BaseDriveResponse {
	s.Creator = &v
	return s
}

func (s *BaseDriveResponse) SetDescription(v string) *BaseDriveResponse {
	s.Description = &v
	return s
}

func (s *BaseDriveResponse) SetDomainId(v string) *BaseDriveResponse {
	s.DomainId = &v
	return s
}

func (s *BaseDriveResponse) SetDriveId(v string) *BaseDriveResponse {
	s.DriveId = &v
	return s
}

func (s *BaseDriveResponse) SetDriveName(v string) *BaseDriveResponse {
	s.DriveName = &v
	return s
}

func (s *BaseDriveResponse) SetDriveType(v string) *BaseDriveResponse {
	s.DriveType = &v
	return s
}

func (s *BaseDriveResponse) SetOwner(v string) *BaseDriveResponse {
	s.Owner = &v
	return s
}

func (s *BaseDriveResponse) SetRelativePath(v string) *BaseDriveResponse {
	s.RelativePath = &v
	return s
}

func (s *BaseDriveResponse) SetStatus(v string) *BaseDriveResponse {
	s.Status = &v
	return s
}

func (s *BaseDriveResponse) SetStoreId(v string) *BaseDriveResponse {
	s.StoreId = &v
	return s
}

func (s *BaseDriveResponse) SetTotalSize(v int64) *BaseDriveResponse {
	s.TotalSize = &v
	return s
}

func (s *BaseDriveResponse) SetUsedSize(v int64) *BaseDriveResponse {
	s.UsedSize = &v
	return s
}

type BaseOSSFileResponse struct {
	RequestId       *string `json:"requestId" xml:"requestId"`
	ContentHash     *string `json:"content_hash" xml:"content_hash"`
	ContentHashName *string `json:"content_hash_name" xml:"content_hash_name"`
	ContentType     *string `json:"content_type" xml:"content_type"`
	Crc64Hash       *string `json:"crc64_hash" xml:"crc64_hash"`
	CreatedAt       *string `json:"created_at" xml:"created_at"`
	Description     *string `json:"description" xml:"description"`
	DomainId        *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DownloadUrl     *string `json:"download_url" xml:"download_url"`
	DriveId         *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileExtension   *string `json:"file_extension" xml:"file_extension"`
	FilePath        *string `json:"file_path" xml:"file_path"`
	Name            *string `json:"name" xml:"name" require:"true" pattern:"[a-zA-Z0-9.-]{1,1024}"`
	ParentFilePath  *string `json:"parent_file_path" xml:"parent_file_path" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	ShareId         *string `json:"share_id" xml:"share_id" pattern:"[0-9]+"`
	Size            *int64  `json:"size" xml:"size"`
	Status          *string `json:"status" xml:"status"`
	Thumbnail       *string `json:"thumbnail" xml:"thumbnail"`
	TrashedAt       *string `json:"trashed_at" xml:"trashed_at"`
	Type            *string `json:"type" xml:"type"`
	UpdatedAt       *string `json:"updated_at" xml:"updated_at"`
	UploadId        *string `json:"upload_id" xml:"upload_id"`
	Url             *string `json:"url" xml:"url"`
}

func (s BaseOSSFileResponse) String() string {
	return tea.Prettify(s)
}

func (s BaseOSSFileResponse) GoString() string {
	return s.String()
}

func (s *BaseOSSFileResponse) SetRequestId(v string) *BaseOSSFileResponse {
	s.RequestId = &v
	return s
}

func (s *BaseOSSFileResponse) SetContentHash(v string) *BaseOSSFileResponse {
	s.ContentHash = &v
	return s
}

func (s *BaseOSSFileResponse) SetContentHashName(v string) *BaseOSSFileResponse {
	s.ContentHashName = &v
	return s
}

func (s *BaseOSSFileResponse) SetContentType(v string) *BaseOSSFileResponse {
	s.ContentType = &v
	return s
}

func (s *BaseOSSFileResponse) SetCrc64Hash(v string) *BaseOSSFileResponse {
	s.Crc64Hash = &v
	return s
}

func (s *BaseOSSFileResponse) SetCreatedAt(v string) *BaseOSSFileResponse {
	s.CreatedAt = &v
	return s
}

func (s *BaseOSSFileResponse) SetDescription(v string) *BaseOSSFileResponse {
	s.Description = &v
	return s
}

func (s *BaseOSSFileResponse) SetDomainId(v string) *BaseOSSFileResponse {
	s.DomainId = &v
	return s
}

func (s *BaseOSSFileResponse) SetDownloadUrl(v string) *BaseOSSFileResponse {
	s.DownloadUrl = &v
	return s
}

func (s *BaseOSSFileResponse) SetDriveId(v string) *BaseOSSFileResponse {
	s.DriveId = &v
	return s
}

func (s *BaseOSSFileResponse) SetFileExtension(v string) *BaseOSSFileResponse {
	s.FileExtension = &v
	return s
}

func (s *BaseOSSFileResponse) SetFilePath(v string) *BaseOSSFileResponse {
	s.FilePath = &v
	return s
}

func (s *BaseOSSFileResponse) SetName(v string) *BaseOSSFileResponse {
	s.Name = &v
	return s
}

func (s *BaseOSSFileResponse) SetParentFilePath(v string) *BaseOSSFileResponse {
	s.ParentFilePath = &v
	return s
}

func (s *BaseOSSFileResponse) SetShareId(v string) *BaseOSSFileResponse {
	s.ShareId = &v
	return s
}

func (s *BaseOSSFileResponse) SetSize(v int64) *BaseOSSFileResponse {
	s.Size = &v
	return s
}

func (s *BaseOSSFileResponse) SetStatus(v string) *BaseOSSFileResponse {
	s.Status = &v
	return s
}

func (s *BaseOSSFileResponse) SetThumbnail(v string) *BaseOSSFileResponse {
	s.Thumbnail = &v
	return s
}

func (s *BaseOSSFileResponse) SetTrashedAt(v string) *BaseOSSFileResponse {
	s.TrashedAt = &v
	return s
}

func (s *BaseOSSFileResponse) SetType(v string) *BaseOSSFileResponse {
	s.Type = &v
	return s
}

func (s *BaseOSSFileResponse) SetUpdatedAt(v string) *BaseOSSFileResponse {
	s.UpdatedAt = &v
	return s
}

func (s *BaseOSSFileResponse) SetUploadId(v string) *BaseOSSFileResponse {
	s.UploadId = &v
	return s
}

func (s *BaseOSSFileResponse) SetUrl(v string) *BaseOSSFileResponse {
	s.Url = &v
	return s
}

type BaseShareResponse struct {
	RequestId     *string   `json:"requestId" xml:"requestId"`
	CreatedAt     *string   `json:"created_at" xml:"created_at"`
	Creator       *string   `json:"creator" xml:"creator"`
	Description   *string   `json:"description" xml:"description"`
	DomainId      *string   `json:"domain_id" xml:"domain_id"`
	DriveId       *string   `json:"drive_id" xml:"drive_id"`
	Expiration    *string   `json:"expiration" xml:"expiration"`
	Expired       *bool     `json:"expired" xml:"expired"`
	Owner         *string   `json:"owner" xml:"owner"`
	Permissions   []*string `json:"permissions" xml:"permissions" type:"Repeated"`
	ShareFilePath *string   `json:"share_file_path" xml:"share_file_path"`
	ShareId       *string   `json:"share_id" xml:"share_id"`
	ShareName     *string   `json:"share_name" xml:"share_name"`
	Status        *string   `json:"status" xml:"status"`
	UpdatedAt     *string   `json:"updated_at" xml:"updated_at"`
}

func (s BaseShareResponse) String() string {
	return tea.Prettify(s)
}

func (s BaseShareResponse) GoString() string {
	return s.String()
}

func (s *BaseShareResponse) SetRequestId(v string) *BaseShareResponse {
	s.RequestId = &v
	return s
}

func (s *BaseShareResponse) SetCreatedAt(v string) *BaseShareResponse {
	s.CreatedAt = &v
	return s
}

func (s *BaseShareResponse) SetCreator(v string) *BaseShareResponse {
	s.Creator = &v
	return s
}

func (s *BaseShareResponse) SetDescription(v string) *BaseShareResponse {
	s.Description = &v
	return s
}

func (s *BaseShareResponse) SetDomainId(v string) *BaseShareResponse {
	s.DomainId = &v
	return s
}

func (s *BaseShareResponse) SetDriveId(v string) *BaseShareResponse {
	s.DriveId = &v
	return s
}

func (s *BaseShareResponse) SetExpiration(v string) *BaseShareResponse {
	s.Expiration = &v
	return s
}

func (s *BaseShareResponse) SetExpired(v bool) *BaseShareResponse {
	s.Expired = &v
	return s
}

func (s *BaseShareResponse) SetOwner(v string) *BaseShareResponse {
	s.Owner = &v
	return s
}

func (s *BaseShareResponse) SetPermissions(v []*string) *BaseShareResponse {
	s.Permissions = v
	return s
}

func (s *BaseShareResponse) SetShareFilePath(v string) *BaseShareResponse {
	s.ShareFilePath = &v
	return s
}

func (s *BaseShareResponse) SetShareId(v string) *BaseShareResponse {
	s.ShareId = &v
	return s
}

func (s *BaseShareResponse) SetShareName(v string) *BaseShareResponse {
	s.ShareName = &v
	return s
}

func (s *BaseShareResponse) SetStatus(v string) *BaseShareResponse {
	s.Status = &v
	return s
}

func (s *BaseShareResponse) SetUpdatedAt(v string) *BaseShareResponse {
	s.UpdatedAt = &v
	return s
}

type BatchSubResponse struct {
	RequestId *string                `json:"requestId" xml:"requestId"`
	Body      map[string]interface{} `json:"body" xml:"body"`
	Id        *string                `json:"id" xml:"id"`
	Status    *int64                 `json:"status" xml:"status"`
}

func (s BatchSubResponse) String() string {
	return tea.Prettify(s)
}

func (s BatchSubResponse) GoString() string {
	return s.String()
}

func (s *BatchSubResponse) SetRequestId(v string) *BatchSubResponse {
	s.RequestId = &v
	return s
}

func (s *BatchSubResponse) SetBody(v map[string]interface{}) *BatchSubResponse {
	s.Body = v
	return s
}

func (s *BatchSubResponse) SetId(v string) *BatchSubResponse {
	s.Id = &v
	return s
}

func (s *BatchSubResponse) SetStatus(v int64) *BatchSubResponse {
	s.Status = &v
	return s
}

type CCPBatchResponse struct {
	RequestId *string             `json:"requestId" xml:"requestId"`
	Responses []*BatchSubResponse `json:"responses" xml:"responses" type:"Repeated"`
}

func (s CCPBatchResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPBatchResponse) GoString() string {
	return s.String()
}

func (s *CCPBatchResponse) SetRequestId(v string) *CCPBatchResponse {
	s.RequestId = &v
	return s
}

func (s *CCPBatchResponse) SetResponses(v []*BatchSubResponse) *CCPBatchResponse {
	s.Responses = v
	return s
}

type CCPCompleteFileResponse struct {
	RequestId          *string             `json:"requestId" xml:"requestId"`
	Category           *string             `json:"category" xml:"category"`
	ContentHash        *string             `json:"content_hash" xml:"content_hash"`
	ContentHashName    *string             `json:"content_hash_name" xml:"content_hash_name"`
	ContentType        *string             `json:"content_type" xml:"content_type"`
	Crc64Hash          *string             `json:"crc64_hash" xml:"crc64_hash"`
	CreatedAt          *string             `json:"created_at" xml:"created_at"`
	Description        *string             `json:"description" xml:"description"`
	DomainId           *string             `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DownloadUrl        *string             `json:"download_url" xml:"download_url"`
	DriveId            *string             `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileExtension      *string             `json:"file_extension" xml:"file_extension"`
	FileId             *string             `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	Hidden             *bool               `json:"hidden" xml:"hidden"`
	ImageMediaMetadata *ImageMediaResponse `json:"image_media_metadata" xml:"image_media_metadata"`
	Labels             []*string           `json:"labels" xml:"labels" type:"Repeated"`
	Meta               *string             `json:"meta" xml:"meta"`
	Name               *string             `json:"name" xml:"name" pattern:"[a-zA-Z0-9.-]{1,1024}"`
	ParentFileId       *string             `json:"parent_file_id" xml:"parent_file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	Size               *int64              `json:"size" xml:"size"`
	Starred            *bool               `json:"starred" xml:"starred"`
	Status             *string             `json:"status" xml:"status"`
	Thumbnail          *string             `json:"thumbnail" xml:"thumbnail"`
	TrashedAt          *string             `json:"trashed_at" xml:"trashed_at"`
	Type               *string             `json:"type" xml:"type"`
	UpdatedAt          *string             `json:"updated_at" xml:"updated_at"`
	UploadId           *string             `json:"upload_id" xml:"upload_id"`
	Url                *string             `json:"url" xml:"url"`
	Crc                *string             `json:"crc" xml:"crc"`
}

func (s CCPCompleteFileResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPCompleteFileResponse) GoString() string {
	return s.String()
}

func (s *CCPCompleteFileResponse) SetRequestId(v string) *CCPCompleteFileResponse {
	s.RequestId = &v
	return s
}

func (s *CCPCompleteFileResponse) SetCategory(v string) *CCPCompleteFileResponse {
	s.Category = &v
	return s
}

func (s *CCPCompleteFileResponse) SetContentHash(v string) *CCPCompleteFileResponse {
	s.ContentHash = &v
	return s
}

func (s *CCPCompleteFileResponse) SetContentHashName(v string) *CCPCompleteFileResponse {
	s.ContentHashName = &v
	return s
}

func (s *CCPCompleteFileResponse) SetContentType(v string) *CCPCompleteFileResponse {
	s.ContentType = &v
	return s
}

func (s *CCPCompleteFileResponse) SetCrc64Hash(v string) *CCPCompleteFileResponse {
	s.Crc64Hash = &v
	return s
}

func (s *CCPCompleteFileResponse) SetCreatedAt(v string) *CCPCompleteFileResponse {
	s.CreatedAt = &v
	return s
}

func (s *CCPCompleteFileResponse) SetDescription(v string) *CCPCompleteFileResponse {
	s.Description = &v
	return s
}

func (s *CCPCompleteFileResponse) SetDomainId(v string) *CCPCompleteFileResponse {
	s.DomainId = &v
	return s
}

func (s *CCPCompleteFileResponse) SetDownloadUrl(v string) *CCPCompleteFileResponse {
	s.DownloadUrl = &v
	return s
}

func (s *CCPCompleteFileResponse) SetDriveId(v string) *CCPCompleteFileResponse {
	s.DriveId = &v
	return s
}

func (s *CCPCompleteFileResponse) SetFileExtension(v string) *CCPCompleteFileResponse {
	s.FileExtension = &v
	return s
}

func (s *CCPCompleteFileResponse) SetFileId(v string) *CCPCompleteFileResponse {
	s.FileId = &v
	return s
}

func (s *CCPCompleteFileResponse) SetHidden(v bool) *CCPCompleteFileResponse {
	s.Hidden = &v
	return s
}

func (s *CCPCompleteFileResponse) SetImageMediaMetadata(v *ImageMediaResponse) *CCPCompleteFileResponse {
	s.ImageMediaMetadata = v
	return s
}

func (s *CCPCompleteFileResponse) SetLabels(v []*string) *CCPCompleteFileResponse {
	s.Labels = v
	return s
}

func (s *CCPCompleteFileResponse) SetMeta(v string) *CCPCompleteFileResponse {
	s.Meta = &v
	return s
}

func (s *CCPCompleteFileResponse) SetName(v string) *CCPCompleteFileResponse {
	s.Name = &v
	return s
}

func (s *CCPCompleteFileResponse) SetParentFileId(v string) *CCPCompleteFileResponse {
	s.ParentFileId = &v
	return s
}

func (s *CCPCompleteFileResponse) SetSize(v int64) *CCPCompleteFileResponse {
	s.Size = &v
	return s
}

func (s *CCPCompleteFileResponse) SetStarred(v bool) *CCPCompleteFileResponse {
	s.Starred = &v
	return s
}

func (s *CCPCompleteFileResponse) SetStatus(v string) *CCPCompleteFileResponse {
	s.Status = &v
	return s
}

func (s *CCPCompleteFileResponse) SetThumbnail(v string) *CCPCompleteFileResponse {
	s.Thumbnail = &v
	return s
}

func (s *CCPCompleteFileResponse) SetTrashedAt(v string) *CCPCompleteFileResponse {
	s.TrashedAt = &v
	return s
}

func (s *CCPCompleteFileResponse) SetType(v string) *CCPCompleteFileResponse {
	s.Type = &v
	return s
}

func (s *CCPCompleteFileResponse) SetUpdatedAt(v string) *CCPCompleteFileResponse {
	s.UpdatedAt = &v
	return s
}

func (s *CCPCompleteFileResponse) SetUploadId(v string) *CCPCompleteFileResponse {
	s.UploadId = &v
	return s
}

func (s *CCPCompleteFileResponse) SetUrl(v string) *CCPCompleteFileResponse {
	s.Url = &v
	return s
}

func (s *CCPCompleteFileResponse) SetCrc(v string) *CCPCompleteFileResponse {
	s.Crc = &v
	return s
}

type CCPCopyFileResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AsyncTaskId *string `json:"async_task_id" xml:"async_task_id"`
	DomainId    *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DriveId     *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileId      *string `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
}

func (s CCPCopyFileResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPCopyFileResponse) GoString() string {
	return s.String()
}

func (s *CCPCopyFileResponse) SetRequestId(v string) *CCPCopyFileResponse {
	s.RequestId = &v
	return s
}

func (s *CCPCopyFileResponse) SetAsyncTaskId(v string) *CCPCopyFileResponse {
	s.AsyncTaskId = &v
	return s
}

func (s *CCPCopyFileResponse) SetDomainId(v string) *CCPCopyFileResponse {
	s.DomainId = &v
	return s
}

func (s *CCPCopyFileResponse) SetDriveId(v string) *CCPCopyFileResponse {
	s.DriveId = &v
	return s
}

func (s *CCPCopyFileResponse) SetFileId(v string) *CCPCopyFileResponse {
	s.FileId = &v
	return s
}

type CCPCreateFileResponse struct {
	RequestId    *string           `json:"requestId" xml:"requestId"`
	DomainId     *string           `json:"domain_id" xml:"domain_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	DriveId      *string           `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileId       *string           `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	ParentFileId *string           `json:"parent_file_id" xml:"parent_file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	PartInfoList []*UploadPartInfo `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	RapidUpload  *bool             `json:"rapid_upload" xml:"rapid_upload"`
	Type         *string           `json:"type" xml:"type"`
	UploadId     *string           `json:"upload_id" xml:"upload_id"`
}

func (s CCPCreateFileResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPCreateFileResponse) GoString() string {
	return s.String()
}

func (s *CCPCreateFileResponse) SetRequestId(v string) *CCPCreateFileResponse {
	s.RequestId = &v
	return s
}

func (s *CCPCreateFileResponse) SetDomainId(v string) *CCPCreateFileResponse {
	s.DomainId = &v
	return s
}

func (s *CCPCreateFileResponse) SetDriveId(v string) *CCPCreateFileResponse {
	s.DriveId = &v
	return s
}

func (s *CCPCreateFileResponse) SetFileId(v string) *CCPCreateFileResponse {
	s.FileId = &v
	return s
}

func (s *CCPCreateFileResponse) SetParentFileId(v string) *CCPCreateFileResponse {
	s.ParentFileId = &v
	return s
}

func (s *CCPCreateFileResponse) SetPartInfoList(v []*UploadPartInfo) *CCPCreateFileResponse {
	s.PartInfoList = v
	return s
}

func (s *CCPCreateFileResponse) SetRapidUpload(v bool) *CCPCreateFileResponse {
	s.RapidUpload = &v
	return s
}

func (s *CCPCreateFileResponse) SetType(v string) *CCPCreateFileResponse {
	s.Type = &v
	return s
}

func (s *CCPCreateFileResponse) SetUploadId(v string) *CCPCreateFileResponse {
	s.UploadId = &v
	return s
}

type CCPDeleteFileResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AsyncTaskId *string `json:"async_task_id" xml:"async_task_id"`
	DomainId    *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DriveId     *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileId      *string `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
}

func (s CCPDeleteFileResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPDeleteFileResponse) GoString() string {
	return s.String()
}

func (s *CCPDeleteFileResponse) SetRequestId(v string) *CCPDeleteFileResponse {
	s.RequestId = &v
	return s
}

func (s *CCPDeleteFileResponse) SetAsyncTaskId(v string) *CCPDeleteFileResponse {
	s.AsyncTaskId = &v
	return s
}

func (s *CCPDeleteFileResponse) SetDomainId(v string) *CCPDeleteFileResponse {
	s.DomainId = &v
	return s
}

func (s *CCPDeleteFileResponse) SetDriveId(v string) *CCPDeleteFileResponse {
	s.DriveId = &v
	return s
}

func (s *CCPDeleteFileResponse) SetFileId(v string) *CCPDeleteFileResponse {
	s.FileId = &v
	return s
}

type CCPDeleteFilesResponse struct {
	RequestId         *string   `json:"requestId" xml:"requestId"`
	DeletedFileIdList []*string `json:"deleted_file_id_list" xml:"deleted_file_id_list" type:"Repeated"`
	DomainId          *string   `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DriveId           *string   `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
}

func (s CCPDeleteFilesResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPDeleteFilesResponse) GoString() string {
	return s.String()
}

func (s *CCPDeleteFilesResponse) SetRequestId(v string) *CCPDeleteFilesResponse {
	s.RequestId = &v
	return s
}

func (s *CCPDeleteFilesResponse) SetDeletedFileIdList(v []*string) *CCPDeleteFilesResponse {
	s.DeletedFileIdList = v
	return s
}

func (s *CCPDeleteFilesResponse) SetDomainId(v string) *CCPDeleteFilesResponse {
	s.DomainId = &v
	return s
}

func (s *CCPDeleteFilesResponse) SetDriveId(v string) *CCPDeleteFilesResponse {
	s.DriveId = &v
	return s
}

type CCPGetAsyncTaskResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AsyncTaskId *string `json:"async_task_id" xml:"async_task_id"`
	Message     *string `json:"message" xml:"message"`
	State       *string `json:"state" xml:"state"`
}

func (s CCPGetAsyncTaskResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPGetAsyncTaskResponse) GoString() string {
	return s.String()
}

func (s *CCPGetAsyncTaskResponse) SetRequestId(v string) *CCPGetAsyncTaskResponse {
	s.RequestId = &v
	return s
}

func (s *CCPGetAsyncTaskResponse) SetAsyncTaskId(v string) *CCPGetAsyncTaskResponse {
	s.AsyncTaskId = &v
	return s
}

func (s *CCPGetAsyncTaskResponse) SetMessage(v string) *CCPGetAsyncTaskResponse {
	s.Message = &v
	return s
}

func (s *CCPGetAsyncTaskResponse) SetState(v string) *CCPGetAsyncTaskResponse {
	s.State = &v
	return s
}

type CCPGetDownloadUrlResponse struct {
	RequestId  *string `json:"requestId" xml:"requestId"`
	Expiration *string `json:"expiration" xml:"expiration"`
	Method     *string `json:"method" xml:"method"`
	Url        *string `json:"url" xml:"url"`
}

func (s CCPGetDownloadUrlResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPGetDownloadUrlResponse) GoString() string {
	return s.String()
}

func (s *CCPGetDownloadUrlResponse) SetRequestId(v string) *CCPGetDownloadUrlResponse {
	s.RequestId = &v
	return s
}

func (s *CCPGetDownloadUrlResponse) SetExpiration(v string) *CCPGetDownloadUrlResponse {
	s.Expiration = &v
	return s
}

func (s *CCPGetDownloadUrlResponse) SetMethod(v string) *CCPGetDownloadUrlResponse {
	s.Method = &v
	return s
}

func (s *CCPGetDownloadUrlResponse) SetUrl(v string) *CCPGetDownloadUrlResponse {
	s.Url = &v
	return s
}

type CCPGetFileResponse struct {
	RequestId          *string             `json:"requestId" xml:"requestId"`
	Category           *string             `json:"category" xml:"category"`
	ContentHash        *string             `json:"content_hash" xml:"content_hash"`
	ContentHashName    *string             `json:"content_hash_name" xml:"content_hash_name"`
	ContentType        *string             `json:"content_type" xml:"content_type"`
	Crc64Hash          *string             `json:"crc64_hash" xml:"crc64_hash"`
	CreatedAt          *string             `json:"created_at" xml:"created_at"`
	Description        *string             `json:"description" xml:"description"`
	DomainId           *string             `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DownloadUrl        *string             `json:"download_url" xml:"download_url"`
	DriveId            *string             `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileExtension      *string             `json:"file_extension" xml:"file_extension"`
	FileId             *string             `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	Hidden             *bool               `json:"hidden" xml:"hidden"`
	ImageMediaMetadata *ImageMediaResponse `json:"image_media_metadata" xml:"image_media_metadata"`
	Labels             []*string           `json:"labels" xml:"labels" type:"Repeated"`
	Meta               *string             `json:"meta" xml:"meta"`
	Name               *string             `json:"name" xml:"name" pattern:"[a-zA-Z0-9.-]{1,1024}"`
	ParentFileId       *string             `json:"parent_file_id" xml:"parent_file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	Size               *int64              `json:"size" xml:"size"`
	Starred            *bool               `json:"starred" xml:"starred"`
	Status             *string             `json:"status" xml:"status"`
	Thumbnail          *string             `json:"thumbnail" xml:"thumbnail"`
	TrashedAt          *string             `json:"trashed_at" xml:"trashed_at"`
	Type               *string             `json:"type" xml:"type"`
	UpdatedAt          *string             `json:"updated_at" xml:"updated_at"`
	UploadId           *string             `json:"upload_id" xml:"upload_id"`
	Url                *string             `json:"url" xml:"url"`
}

func (s CCPGetFileResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPGetFileResponse) GoString() string {
	return s.String()
}

func (s *CCPGetFileResponse) SetRequestId(v string) *CCPGetFileResponse {
	s.RequestId = &v
	return s
}

func (s *CCPGetFileResponse) SetCategory(v string) *CCPGetFileResponse {
	s.Category = &v
	return s
}

func (s *CCPGetFileResponse) SetContentHash(v string) *CCPGetFileResponse {
	s.ContentHash = &v
	return s
}

func (s *CCPGetFileResponse) SetContentHashName(v string) *CCPGetFileResponse {
	s.ContentHashName = &v
	return s
}

func (s *CCPGetFileResponse) SetContentType(v string) *CCPGetFileResponse {
	s.ContentType = &v
	return s
}

func (s *CCPGetFileResponse) SetCrc64Hash(v string) *CCPGetFileResponse {
	s.Crc64Hash = &v
	return s
}

func (s *CCPGetFileResponse) SetCreatedAt(v string) *CCPGetFileResponse {
	s.CreatedAt = &v
	return s
}

func (s *CCPGetFileResponse) SetDescription(v string) *CCPGetFileResponse {
	s.Description = &v
	return s
}

func (s *CCPGetFileResponse) SetDomainId(v string) *CCPGetFileResponse {
	s.DomainId = &v
	return s
}

func (s *CCPGetFileResponse) SetDownloadUrl(v string) *CCPGetFileResponse {
	s.DownloadUrl = &v
	return s
}

func (s *CCPGetFileResponse) SetDriveId(v string) *CCPGetFileResponse {
	s.DriveId = &v
	return s
}

func (s *CCPGetFileResponse) SetFileExtension(v string) *CCPGetFileResponse {
	s.FileExtension = &v
	return s
}

func (s *CCPGetFileResponse) SetFileId(v string) *CCPGetFileResponse {
	s.FileId = &v
	return s
}

func (s *CCPGetFileResponse) SetHidden(v bool) *CCPGetFileResponse {
	s.Hidden = &v
	return s
}

func (s *CCPGetFileResponse) SetImageMediaMetadata(v *ImageMediaResponse) *CCPGetFileResponse {
	s.ImageMediaMetadata = v
	return s
}

func (s *CCPGetFileResponse) SetLabels(v []*string) *CCPGetFileResponse {
	s.Labels = v
	return s
}

func (s *CCPGetFileResponse) SetMeta(v string) *CCPGetFileResponse {
	s.Meta = &v
	return s
}

func (s *CCPGetFileResponse) SetName(v string) *CCPGetFileResponse {
	s.Name = &v
	return s
}

func (s *CCPGetFileResponse) SetParentFileId(v string) *CCPGetFileResponse {
	s.ParentFileId = &v
	return s
}

func (s *CCPGetFileResponse) SetSize(v int64) *CCPGetFileResponse {
	s.Size = &v
	return s
}

func (s *CCPGetFileResponse) SetStarred(v bool) *CCPGetFileResponse {
	s.Starred = &v
	return s
}

func (s *CCPGetFileResponse) SetStatus(v string) *CCPGetFileResponse {
	s.Status = &v
	return s
}

func (s *CCPGetFileResponse) SetThumbnail(v string) *CCPGetFileResponse {
	s.Thumbnail = &v
	return s
}

func (s *CCPGetFileResponse) SetTrashedAt(v string) *CCPGetFileResponse {
	s.TrashedAt = &v
	return s
}

func (s *CCPGetFileResponse) SetType(v string) *CCPGetFileResponse {
	s.Type = &v
	return s
}

func (s *CCPGetFileResponse) SetUpdatedAt(v string) *CCPGetFileResponse {
	s.UpdatedAt = &v
	return s
}

func (s *CCPGetFileResponse) SetUploadId(v string) *CCPGetFileResponse {
	s.UploadId = &v
	return s
}

func (s *CCPGetFileResponse) SetUrl(v string) *CCPGetFileResponse {
	s.Url = &v
	return s
}

type CCPGetUploadUrlResponse struct {
	RequestId    *string           `json:"requestId" xml:"requestId"`
	CreateAt     *string           `json:"create_at" xml:"create_at"`
	DomainId     *string           `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DriveId      *string           `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileId       *string           `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	PartInfoList []*UploadPartInfo `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	UploadId     *string           `json:"upload_id" xml:"upload_id"`
}

func (s CCPGetUploadUrlResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPGetUploadUrlResponse) GoString() string {
	return s.String()
}

func (s *CCPGetUploadUrlResponse) SetRequestId(v string) *CCPGetUploadUrlResponse {
	s.RequestId = &v
	return s
}

func (s *CCPGetUploadUrlResponse) SetCreateAt(v string) *CCPGetUploadUrlResponse {
	s.CreateAt = &v
	return s
}

func (s *CCPGetUploadUrlResponse) SetDomainId(v string) *CCPGetUploadUrlResponse {
	s.DomainId = &v
	return s
}

func (s *CCPGetUploadUrlResponse) SetDriveId(v string) *CCPGetUploadUrlResponse {
	s.DriveId = &v
	return s
}

func (s *CCPGetUploadUrlResponse) SetFileId(v string) *CCPGetUploadUrlResponse {
	s.FileId = &v
	return s
}

func (s *CCPGetUploadUrlResponse) SetPartInfoList(v []*UploadPartInfo) *CCPGetUploadUrlResponse {
	s.PartInfoList = v
	return s
}

func (s *CCPGetUploadUrlResponse) SetUploadId(v string) *CCPGetUploadUrlResponse {
	s.UploadId = &v
	return s
}

type CCPListFileResponse struct {
	RequestId  *string                `json:"requestId" xml:"requestId"`
	Items      []*BaseCCPFileResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string                `json:"next_marker" xml:"next_marker"`
}

func (s CCPListFileResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPListFileResponse) GoString() string {
	return s.String()
}

func (s *CCPListFileResponse) SetRequestId(v string) *CCPListFileResponse {
	s.RequestId = &v
	return s
}

func (s *CCPListFileResponse) SetItems(v []*BaseCCPFileResponse) *CCPListFileResponse {
	s.Items = v
	return s
}

func (s *CCPListFileResponse) SetNextMarker(v string) *CCPListFileResponse {
	s.NextMarker = &v
	return s
}

type CCPListUploadedPartResponse struct {
	RequestId            *string           `json:"requestId" xml:"requestId"`
	FileId               *string           `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	NextPartNumberMarker *string           `json:"next_part_number_marker" xml:"next_part_number_marker"`
	UploadId             *string           `json:"upload_id" xml:"upload_id"`
	UploadedParts        []*UploadPartInfo `json:"uploaded_parts" xml:"uploaded_parts" type:"Repeated"`
}

func (s CCPListUploadedPartResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPListUploadedPartResponse) GoString() string {
	return s.String()
}

func (s *CCPListUploadedPartResponse) SetRequestId(v string) *CCPListUploadedPartResponse {
	s.RequestId = &v
	return s
}

func (s *CCPListUploadedPartResponse) SetFileId(v string) *CCPListUploadedPartResponse {
	s.FileId = &v
	return s
}

func (s *CCPListUploadedPartResponse) SetNextPartNumberMarker(v string) *CCPListUploadedPartResponse {
	s.NextPartNumberMarker = &v
	return s
}

func (s *CCPListUploadedPartResponse) SetUploadId(v string) *CCPListUploadedPartResponse {
	s.UploadId = &v
	return s
}

func (s *CCPListUploadedPartResponse) SetUploadedParts(v []*UploadPartInfo) *CCPListUploadedPartResponse {
	s.UploadedParts = v
	return s
}

type CCPMoveFileResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AsyncTaskId *string `json:"async_task_id" xml:"async_task_id"`
	DomainId    *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DriveId     *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileId      *string `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
}

func (s CCPMoveFileResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPMoveFileResponse) GoString() string {
	return s.String()
}

func (s *CCPMoveFileResponse) SetRequestId(v string) *CCPMoveFileResponse {
	s.RequestId = &v
	return s
}

func (s *CCPMoveFileResponse) SetAsyncTaskId(v string) *CCPMoveFileResponse {
	s.AsyncTaskId = &v
	return s
}

func (s *CCPMoveFileResponse) SetDomainId(v string) *CCPMoveFileResponse {
	s.DomainId = &v
	return s
}

func (s *CCPMoveFileResponse) SetDriveId(v string) *CCPMoveFileResponse {
	s.DriveId = &v
	return s
}

func (s *CCPMoveFileResponse) SetFileId(v string) *CCPMoveFileResponse {
	s.FileId = &v
	return s
}

type CCPSearchFileResponse struct {
	RequestId  *string                `json:"requestId" xml:"requestId"`
	Items      []*BaseCCPFileResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string                `json:"next_marker" xml:"next_marker"`
}

func (s CCPSearchFileResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPSearchFileResponse) GoString() string {
	return s.String()
}

func (s *CCPSearchFileResponse) SetRequestId(v string) *CCPSearchFileResponse {
	s.RequestId = &v
	return s
}

func (s *CCPSearchFileResponse) SetItems(v []*BaseCCPFileResponse) *CCPSearchFileResponse {
	s.Items = v
	return s
}

func (s *CCPSearchFileResponse) SetNextMarker(v string) *CCPSearchFileResponse {
	s.NextMarker = &v
	return s
}

type CCPUpdateFileMetaResponse struct {
	RequestId          *string             `json:"requestId" xml:"requestId"`
	Category           *string             `json:"category" xml:"category"`
	ContentHash        *string             `json:"content_hash" xml:"content_hash"`
	ContentHashName    *string             `json:"content_hash_name" xml:"content_hash_name"`
	ContentType        *string             `json:"content_type" xml:"content_type"`
	Crc64Hash          *string             `json:"crc64_hash" xml:"crc64_hash"`
	CreatedAt          *string             `json:"created_at" xml:"created_at"`
	Description        *string             `json:"description" xml:"description"`
	DomainId           *string             `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DownloadUrl        *string             `json:"download_url" xml:"download_url"`
	DriveId            *string             `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileExtension      *string             `json:"file_extension" xml:"file_extension"`
	FileId             *string             `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	Hidden             *bool               `json:"hidden" xml:"hidden"`
	ImageMediaMetadata *ImageMediaResponse `json:"image_media_metadata" xml:"image_media_metadata"`
	Labels             []*string           `json:"labels" xml:"labels" type:"Repeated"`
	Meta               *string             `json:"meta" xml:"meta"`
	Name               *string             `json:"name" xml:"name" pattern:"[a-zA-Z0-9.-]{1,1024}"`
	ParentFileId       *string             `json:"parent_file_id" xml:"parent_file_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	Size               *int64              `json:"size" xml:"size"`
	Starred            *bool               `json:"starred" xml:"starred"`
	Status             *string             `json:"status" xml:"status"`
	Thumbnail          *string             `json:"thumbnail" xml:"thumbnail"`
	TrashedAt          *string             `json:"trashed_at" xml:"trashed_at"`
	Type               *string             `json:"type" xml:"type"`
	UpdatedAt          *string             `json:"updated_at" xml:"updated_at"`
	UploadId           *string             `json:"upload_id" xml:"upload_id"`
	Url                *string             `json:"url" xml:"url"`
}

func (s CCPUpdateFileMetaResponse) String() string {
	return tea.Prettify(s)
}

func (s CCPUpdateFileMetaResponse) GoString() string {
	return s.String()
}

func (s *CCPUpdateFileMetaResponse) SetRequestId(v string) *CCPUpdateFileMetaResponse {
	s.RequestId = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetCategory(v string) *CCPUpdateFileMetaResponse {
	s.Category = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetContentHash(v string) *CCPUpdateFileMetaResponse {
	s.ContentHash = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetContentHashName(v string) *CCPUpdateFileMetaResponse {
	s.ContentHashName = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetContentType(v string) *CCPUpdateFileMetaResponse {
	s.ContentType = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetCrc64Hash(v string) *CCPUpdateFileMetaResponse {
	s.Crc64Hash = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetCreatedAt(v string) *CCPUpdateFileMetaResponse {
	s.CreatedAt = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetDescription(v string) *CCPUpdateFileMetaResponse {
	s.Description = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetDomainId(v string) *CCPUpdateFileMetaResponse {
	s.DomainId = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetDownloadUrl(v string) *CCPUpdateFileMetaResponse {
	s.DownloadUrl = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetDriveId(v string) *CCPUpdateFileMetaResponse {
	s.DriveId = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetFileExtension(v string) *CCPUpdateFileMetaResponse {
	s.FileExtension = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetFileId(v string) *CCPUpdateFileMetaResponse {
	s.FileId = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetHidden(v bool) *CCPUpdateFileMetaResponse {
	s.Hidden = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetImageMediaMetadata(v *ImageMediaResponse) *CCPUpdateFileMetaResponse {
	s.ImageMediaMetadata = v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetLabels(v []*string) *CCPUpdateFileMetaResponse {
	s.Labels = v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetMeta(v string) *CCPUpdateFileMetaResponse {
	s.Meta = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetName(v string) *CCPUpdateFileMetaResponse {
	s.Name = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetParentFileId(v string) *CCPUpdateFileMetaResponse {
	s.ParentFileId = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetSize(v int64) *CCPUpdateFileMetaResponse {
	s.Size = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetStarred(v bool) *CCPUpdateFileMetaResponse {
	s.Starred = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetStatus(v string) *CCPUpdateFileMetaResponse {
	s.Status = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetThumbnail(v string) *CCPUpdateFileMetaResponse {
	s.Thumbnail = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetTrashedAt(v string) *CCPUpdateFileMetaResponse {
	s.TrashedAt = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetType(v string) *CCPUpdateFileMetaResponse {
	s.Type = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetUpdatedAt(v string) *CCPUpdateFileMetaResponse {
	s.UpdatedAt = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetUploadId(v string) *CCPUpdateFileMetaResponse {
	s.UploadId = &v
	return s
}

func (s *CCPUpdateFileMetaResponse) SetUrl(v string) *CCPUpdateFileMetaResponse {
	s.Url = &v
	return s
}

type CancelLinkRequest struct {
	Header         *CancelLinkRequestHeader `json:"header" xml:"header" type:"Struct"`
	TemporaryToken *string                  `json:"temporary_token" xml:"temporary_token" require:"true"`
}

func (s CancelLinkRequest) String() string {
	return tea.Prettify(s)
}

func (s CancelLinkRequest) GoString() string {
	return s.String()
}

func (s *CancelLinkRequest) SetHeader(v *CancelLinkRequestHeader) *CancelLinkRequest {
	s.Header = v
	return s
}

func (s *CancelLinkRequest) SetTemporaryToken(v string) *CancelLinkRequest {
	s.TemporaryToken = &v
	return s
}

type CancelLinkRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CancelLinkRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CancelLinkRequestHeader) GoString() string {
	return s.String()
}

func (s *CancelLinkRequestHeader) SetTraceId(v string) *CancelLinkRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CancelLinkRequestHeader) SetDeviceId(v string) *CancelLinkRequestHeader {
	s.DeviceId = &v
	return s
}

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

type ConfirmLinkRequest struct {
	Header         *ConfirmLinkRequestHeader `json:"header" xml:"header" type:"Struct"`
	TemporaryToken *string                   `json:"temporary_token" xml:"temporary_token" require:"true"`
}

func (s ConfirmLinkRequest) String() string {
	return tea.Prettify(s)
}

func (s ConfirmLinkRequest) GoString() string {
	return s.String()
}

func (s *ConfirmLinkRequest) SetHeader(v *ConfirmLinkRequestHeader) *ConfirmLinkRequest {
	s.Header = v
	return s
}

func (s *ConfirmLinkRequest) SetTemporaryToken(v string) *ConfirmLinkRequest {
	s.TemporaryToken = &v
	return s
}

type ConfirmLinkRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ConfirmLinkRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ConfirmLinkRequestHeader) GoString() string {
	return s.String()
}

func (s *ConfirmLinkRequestHeader) SetTraceId(v string) *ConfirmLinkRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ConfirmLinkRequestHeader) SetDeviceId(v string) *ConfirmLinkRequestHeader {
	s.DeviceId = &v
	return s
}

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

type CreateAppRequest struct {
	Header       *CreateAppRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppName      *string                 `json:"app_name" xml:"app_name" require:"true" maxLength:"128"`
	Description  *string                 `json:"description" xml:"description" maxLength:"128"`
	IsThirdParty *bool                   `json:"is_third_party" xml:"is_third_party"`
	Logo         *string                 `json:"logo" xml:"logo" require:"true"`
	RedirectUri  *string                 `json:"redirect_uri" xml:"redirect_uri"`
	Scope        []*string               `json:"scope" xml:"scope" require:"true" type:"Repeated"`
	Type         *string                 `json:"type" xml:"type" require:"true"`
}

func (s CreateAppRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateAppRequest) GoString() string {
	return s.String()
}

func (s *CreateAppRequest) SetHeader(v *CreateAppRequestHeader) *CreateAppRequest {
	s.Header = v
	return s
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

type CreateAppRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CreateAppRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CreateAppRequestHeader) GoString() string {
	return s.String()
}

func (s *CreateAppRequestHeader) SetTraceId(v string) *CreateAppRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CreateAppRequestHeader) SetDeviceId(v string) *CreateAppRequestHeader {
	s.DeviceId = &v
	return s
}

type CreateDomainRequest struct {
	Header                     *CreateDomainRequestHeader `json:"header" xml:"header" type:"Struct"`
	AuthAlipayAppId            *string                    `json:"auth_alipay_app_id" xml:"auth_alipay_app_id"`
	AuthAlipayEnbale           *bool                      `json:"auth_alipay_enbale" xml:"auth_alipay_enbale"`
	AuthAlipayPrivateKey       *string                    `json:"auth_alipay_private_key" xml:"auth_alipay_private_key"`
	AuthConfig                 map[string]interface{}     `json:"auth_config" xml:"auth_config"`
	AuthDingdingAppId          *string                    `json:"auth_dingding_app_id" xml:"auth_dingding_app_id"`
	AuthDingdingAppSecret      *string                    `json:"auth_dingding_app_secret" xml:"auth_dingding_app_secret"`
	AuthDingdingEnable         *bool                      `json:"auth_dingding_enable" xml:"auth_dingding_enable"`
	AuthEndpointEnable         *bool                      `json:"auth_endpoint_enable" xml:"auth_endpoint_enable"`
	AuthRamAppId               *string                    `json:"auth_ram_app_id" xml:"auth_ram_app_id"`
	AuthRamAppSecret           *string                    `json:"auth_ram_app_secret" xml:"auth_ram_app_secret"`
	AuthRamEnable              *bool                      `json:"auth_ram_enable" xml:"auth_ram_enable"`
	DataHashName               *string                    `json:"data_hash_name" xml:"data_hash_name"`
	Description                *string                    `json:"description" xml:"description"`
	DomainName                 *string                    `json:"domain_name" xml:"domain_name" require:"true"`
	EventFilenameMatches       *string                    `json:"event_filename_matches" xml:"event_filename_matches"`
	EventMnsEndpoint           *string                    `json:"event_mns_endpoint" xml:"event_mns_endpoint"`
	EventMnsTopic              *string                    `json:"event_mns_topic" xml:"event_mns_topic"`
	EventNames                 []*string                  `json:"event_names" xml:"event_names" type:"Repeated"`
	EventRoleArn               *string                    `json:"event_role_arn" xml:"event_role_arn"`
	InitDriveEnable            *bool                      `json:"init_drive_enable" xml:"init_drive_enable"`
	InitDriveSize              *int64                     `json:"init_drive_size" xml:"init_drive_size"`
	PathType                   *string                    `json:"path_type" xml:"path_type" require:"true"`
	PublishedAppAccessStrategy *AppAccessStrategy         `json:"published_app_access_strategy" xml:"published_app_access_strategy"`
	Sharable                   *bool                      `json:"sharable" xml:"sharable"`
	StoreLevel                 *string                    `json:"store_level" xml:"store_level"`
	StoreRegionList            []*string                  `json:"store_region_list" xml:"store_region_list" require:"true" type:"Repeated"`
}

func (s CreateDomainRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateDomainRequest) GoString() string {
	return s.String()
}

func (s *CreateDomainRequest) SetHeader(v *CreateDomainRequestHeader) *CreateDomainRequest {
	s.Header = v
	return s
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

type CreateDomainRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CreateDomainRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CreateDomainRequestHeader) GoString() string {
	return s.String()
}

func (s *CreateDomainRequestHeader) SetTraceId(v string) *CreateDomainRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CreateDomainRequestHeader) SetDeviceId(v string) *CreateDomainRequestHeader {
	s.DeviceId = &v
	return s
}

type CreateDriveResponse struct {
	RequestId *string `json:"requestId" xml:"requestId"`
	DomainId  *string `json:"domain_id" xml:"domain_id"`
	DriveId   *string `json:"drive_id" xml:"drive_id"`
}

func (s CreateDriveResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateDriveResponse) GoString() string {
	return s.String()
}

func (s *CreateDriveResponse) SetRequestId(v string) *CreateDriveResponse {
	s.RequestId = &v
	return s
}

func (s *CreateDriveResponse) SetDomainId(v string) *CreateDriveResponse {
	s.DomainId = &v
	return s
}

func (s *CreateDriveResponse) SetDriveId(v string) *CreateDriveResponse {
	s.DriveId = &v
	return s
}

type CreateShareResponse struct {
	RequestId *string `json:"requestId" xml:"requestId"`
	DomainId  *string `json:"domain_id" xml:"domain_id"`
	ShareId   *string `json:"share_id" xml:"share_id"`
}

func (s CreateShareResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateShareResponse) GoString() string {
	return s.String()
}

func (s *CreateShareResponse) SetRequestId(v string) *CreateShareResponse {
	s.RequestId = &v
	return s
}

func (s *CreateShareResponse) SetDomainId(v string) *CreateShareResponse {
	s.DomainId = &v
	return s
}

func (s *CreateShareResponse) SetShareId(v string) *CreateShareResponse {
	s.ShareId = &v
	return s
}

type DefaultChangePasswordRequest struct {
	Header      *DefaultChangePasswordRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId       *string                             `json:"app_id" xml:"app_id" require:"true"`
	NewPassword *string                             `json:"new_password" xml:"new_password" require:"true"`
	PhoneNumber *string                             `json:"phone_number" xml:"phone_number" require:"true"`
	SmsCode     *string                             `json:"sms_code" xml:"sms_code" require:"true"`
	SmsCodeId   *string                             `json:"sms_code_id" xml:"sms_code_id" require:"true"`
}

func (s DefaultChangePasswordRequest) String() string {
	return tea.Prettify(s)
}

func (s DefaultChangePasswordRequest) GoString() string {
	return s.String()
}

func (s *DefaultChangePasswordRequest) SetHeader(v *DefaultChangePasswordRequestHeader) *DefaultChangePasswordRequest {
	s.Header = v
	return s
}

func (s *DefaultChangePasswordRequest) SetAppId(v string) *DefaultChangePasswordRequest {
	s.AppId = &v
	return s
}

func (s *DefaultChangePasswordRequest) SetNewPassword(v string) *DefaultChangePasswordRequest {
	s.NewPassword = &v
	return s
}

func (s *DefaultChangePasswordRequest) SetPhoneNumber(v string) *DefaultChangePasswordRequest {
	s.PhoneNumber = &v
	return s
}

func (s *DefaultChangePasswordRequest) SetSmsCode(v string) *DefaultChangePasswordRequest {
	s.SmsCode = &v
	return s
}

func (s *DefaultChangePasswordRequest) SetSmsCodeId(v string) *DefaultChangePasswordRequest {
	s.SmsCodeId = &v
	return s
}

type DefaultChangePasswordRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DefaultChangePasswordRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DefaultChangePasswordRequestHeader) GoString() string {
	return s.String()
}

func (s *DefaultChangePasswordRequestHeader) SetTraceId(v string) *DefaultChangePasswordRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DefaultChangePasswordRequestHeader) SetDeviceId(v string) *DefaultChangePasswordRequestHeader {
	s.DeviceId = &v
	return s
}

type DefaultSetPasswordRequest struct {
	Header      *DefaultSetPasswordRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId       *string                          `json:"app_id" xml:"app_id" require:"true"`
	NewPassword *string                          `json:"new_password" xml:"new_password" require:"true"`
	State       *string                          `json:"state" xml:"state" require:"true"`
}

func (s DefaultSetPasswordRequest) String() string {
	return tea.Prettify(s)
}

func (s DefaultSetPasswordRequest) GoString() string {
	return s.String()
}

func (s *DefaultSetPasswordRequest) SetHeader(v *DefaultSetPasswordRequestHeader) *DefaultSetPasswordRequest {
	s.Header = v
	return s
}

func (s *DefaultSetPasswordRequest) SetAppId(v string) *DefaultSetPasswordRequest {
	s.AppId = &v
	return s
}

func (s *DefaultSetPasswordRequest) SetNewPassword(v string) *DefaultSetPasswordRequest {
	s.NewPassword = &v
	return s
}

func (s *DefaultSetPasswordRequest) SetState(v string) *DefaultSetPasswordRequest {
	s.State = &v
	return s
}

type DefaultSetPasswordRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DefaultSetPasswordRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DefaultSetPasswordRequestHeader) GoString() string {
	return s.String()
}

func (s *DefaultSetPasswordRequestHeader) SetTraceId(v string) *DefaultSetPasswordRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DefaultSetPasswordRequestHeader) SetDeviceId(v string) *DefaultSetPasswordRequestHeader {
	s.DeviceId = &v
	return s
}

type DeleteAppRequest struct {
	Header *DeleteAppRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId  *string                 `json:"app_id" xml:"app_id" require:"true"`
}

func (s DeleteAppRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteAppRequest) GoString() string {
	return s.String()
}

func (s *DeleteAppRequest) SetHeader(v *DeleteAppRequestHeader) *DeleteAppRequest {
	s.Header = v
	return s
}

func (s *DeleteAppRequest) SetAppId(v string) *DeleteAppRequest {
	s.AppId = &v
	return s
}

type DeleteAppRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DeleteAppRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DeleteAppRequestHeader) GoString() string {
	return s.String()
}

func (s *DeleteAppRequestHeader) SetTraceId(v string) *DeleteAppRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DeleteAppRequestHeader) SetDeviceId(v string) *DeleteAppRequestHeader {
	s.DeviceId = &v
	return s
}

type DeleteDomainRequest struct {
	Header   *DeleteDomainRequestHeader `json:"header" xml:"header" type:"Struct"`
	DomainId *string                    `json:"domain_id" xml:"domain_id" require:"true"`
}

func (s DeleteDomainRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteDomainRequest) GoString() string {
	return s.String()
}

func (s *DeleteDomainRequest) SetHeader(v *DeleteDomainRequestHeader) *DeleteDomainRequest {
	s.Header = v
	return s
}

func (s *DeleteDomainRequest) SetDomainId(v string) *DeleteDomainRequest {
	s.DomainId = &v
	return s
}

type DeleteDomainRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DeleteDomainRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DeleteDomainRequestHeader) GoString() string {
	return s.String()
}

func (s *DeleteDomainRequestHeader) SetTraceId(v string) *DeleteDomainRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DeleteDomainRequestHeader) SetDeviceId(v string) *DeleteDomainRequestHeader {
	s.DeviceId = &v
	return s
}

type DeleteDriveResponse struct {
	RequestId *string `json:"requestId" xml:"requestId"`
}

func (s DeleteDriveResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteDriveResponse) GoString() string {
	return s.String()
}

func (s *DeleteDriveResponse) SetRequestId(v string) *DeleteDriveResponse {
	s.RequestId = &v
	return s
}

type GetAccessTokenByLinkInfoRequest struct {
	Header   *GetAccessTokenByLinkInfoRequestHeader `json:"header" xml:"header" type:"Struct"`
	Identity *string                                `json:"identity" xml:"identity" require:"true"`
	Type     *string                                `json:"type" xml:"type" require:"true"`
}

func (s GetAccessTokenByLinkInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAccessTokenByLinkInfoRequest) GoString() string {
	return s.String()
}

func (s *GetAccessTokenByLinkInfoRequest) SetHeader(v *GetAccessTokenByLinkInfoRequestHeader) *GetAccessTokenByLinkInfoRequest {
	s.Header = v
	return s
}

func (s *GetAccessTokenByLinkInfoRequest) SetIdentity(v string) *GetAccessTokenByLinkInfoRequest {
	s.Identity = &v
	return s
}

func (s *GetAccessTokenByLinkInfoRequest) SetType(v string) *GetAccessTokenByLinkInfoRequest {
	s.Type = &v
	return s
}

type GetAccessTokenByLinkInfoRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetAccessTokenByLinkInfoRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetAccessTokenByLinkInfoRequestHeader) GoString() string {
	return s.String()
}

func (s *GetAccessTokenByLinkInfoRequestHeader) SetTraceId(v string) *GetAccessTokenByLinkInfoRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetAccessTokenByLinkInfoRequestHeader) SetDeviceId(v string) *GetAccessTokenByLinkInfoRequestHeader {
	s.DeviceId = &v
	return s
}

type GetAppRequest struct {
	Header *GetAppRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId  *string              `json:"app_id" xml:"app_id" require:"true"`
}

func (s GetAppRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAppRequest) GoString() string {
	return s.String()
}

func (s *GetAppRequest) SetHeader(v *GetAppRequestHeader) *GetAppRequest {
	s.Header = v
	return s
}

func (s *GetAppRequest) SetAppId(v string) *GetAppRequest {
	s.AppId = &v
	return s
}

type GetAppRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetAppRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetAppRequestHeader) GoString() string {
	return s.String()
}

func (s *GetAppRequestHeader) SetTraceId(v string) *GetAppRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetAppRequestHeader) SetDeviceId(v string) *GetAppRequestHeader {
	s.DeviceId = &v
	return s
}

type GetByLinkInfoRequest struct {
	Header   *GetByLinkInfoRequestHeader `json:"header" xml:"header" type:"Struct"`
	Identity *string                     `json:"identity" xml:"identity" require:"true"`
	Type     *string                     `json:"type" xml:"type" require:"true"`
}

func (s GetByLinkInfoRequest) String() string {
	return tea.Prettify(s)
}

func (s GetByLinkInfoRequest) GoString() string {
	return s.String()
}

func (s *GetByLinkInfoRequest) SetHeader(v *GetByLinkInfoRequestHeader) *GetByLinkInfoRequest {
	s.Header = v
	return s
}

func (s *GetByLinkInfoRequest) SetIdentity(v string) *GetByLinkInfoRequest {
	s.Identity = &v
	return s
}

func (s *GetByLinkInfoRequest) SetType(v string) *GetByLinkInfoRequest {
	s.Type = &v
	return s
}

type GetByLinkInfoRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetByLinkInfoRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetByLinkInfoRequestHeader) GoString() string {
	return s.String()
}

func (s *GetByLinkInfoRequestHeader) SetTraceId(v string) *GetByLinkInfoRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetByLinkInfoRequestHeader) SetDeviceId(v string) *GetByLinkInfoRequestHeader {
	s.DeviceId = &v
	return s
}

type GetCaptchaRequest struct {
	Header *GetCaptchaRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId  *string                  `json:"app_id" xml:"app_id" require:"true"`
}

func (s GetCaptchaRequest) String() string {
	return tea.Prettify(s)
}

func (s GetCaptchaRequest) GoString() string {
	return s.String()
}

func (s *GetCaptchaRequest) SetHeader(v *GetCaptchaRequestHeader) *GetCaptchaRequest {
	s.Header = v
	return s
}

func (s *GetCaptchaRequest) SetAppId(v string) *GetCaptchaRequest {
	s.AppId = &v
	return s
}

type GetCaptchaRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetCaptchaRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetCaptchaRequestHeader) GoString() string {
	return s.String()
}

func (s *GetCaptchaRequestHeader) SetTraceId(v string) *GetCaptchaRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetCaptchaRequestHeader) SetDeviceId(v string) *GetCaptchaRequestHeader {
	s.DeviceId = &v
	return s
}

type GetDomainRequest struct {
	Header   *GetDomainRequestHeader `json:"header" xml:"header" type:"Struct"`
	DomainId *string                 `json:"domain_id" xml:"domain_id" require:"true"`
}

func (s GetDomainRequest) String() string {
	return tea.Prettify(s)
}

func (s GetDomainRequest) GoString() string {
	return s.String()
}

func (s *GetDomainRequest) SetHeader(v *GetDomainRequestHeader) *GetDomainRequest {
	s.Header = v
	return s
}

func (s *GetDomainRequest) SetDomainId(v string) *GetDomainRequest {
	s.DomainId = &v
	return s
}

type GetDomainRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetDomainRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetDomainRequestHeader) GoString() string {
	return s.String()
}

func (s *GetDomainRequestHeader) SetTraceId(v string) *GetDomainRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetDomainRequestHeader) SetDeviceId(v string) *GetDomainRequestHeader {
	s.DeviceId = &v
	return s
}

type GetDriveResponse struct {
	RequestId    *string `json:"requestId" xml:"requestId"`
	Creator      *string `json:"creator" xml:"creator"`
	Description  *string `json:"description" xml:"description"`
	DomainId     *string `json:"domain_id" xml:"domain_id"`
	DriveId      *string `json:"drive_id" xml:"drive_id"`
	DriveName    *string `json:"drive_name" xml:"drive_name"`
	DriveType    *string `json:"drive_type" xml:"drive_type"`
	Owner        *string `json:"owner" xml:"owner"`
	RelativePath *string `json:"relative_path" xml:"relative_path"`
	Status       *string `json:"status" xml:"status"`
	StoreId      *string `json:"store_id" xml:"store_id"`
	TotalSize    *int64  `json:"total_size" xml:"total_size"`
	UsedSize     *int64  `json:"used_size" xml:"used_size"`
}

func (s GetDriveResponse) String() string {
	return tea.Prettify(s)
}

func (s GetDriveResponse) GoString() string {
	return s.String()
}

func (s *GetDriveResponse) SetRequestId(v string) *GetDriveResponse {
	s.RequestId = &v
	return s
}

func (s *GetDriveResponse) SetCreator(v string) *GetDriveResponse {
	s.Creator = &v
	return s
}

func (s *GetDriveResponse) SetDescription(v string) *GetDriveResponse {
	s.Description = &v
	return s
}

func (s *GetDriveResponse) SetDomainId(v string) *GetDriveResponse {
	s.DomainId = &v
	return s
}

func (s *GetDriveResponse) SetDriveId(v string) *GetDriveResponse {
	s.DriveId = &v
	return s
}

func (s *GetDriveResponse) SetDriveName(v string) *GetDriveResponse {
	s.DriveName = &v
	return s
}

func (s *GetDriveResponse) SetDriveType(v string) *GetDriveResponse {
	s.DriveType = &v
	return s
}

func (s *GetDriveResponse) SetOwner(v string) *GetDriveResponse {
	s.Owner = &v
	return s
}

func (s *GetDriveResponse) SetRelativePath(v string) *GetDriveResponse {
	s.RelativePath = &v
	return s
}

func (s *GetDriveResponse) SetStatus(v string) *GetDriveResponse {
	s.Status = &v
	return s
}

func (s *GetDriveResponse) SetStoreId(v string) *GetDriveResponse {
	s.StoreId = &v
	return s
}

func (s *GetDriveResponse) SetTotalSize(v int64) *GetDriveResponse {
	s.TotalSize = &v
	return s
}

func (s *GetDriveResponse) SetUsedSize(v int64) *GetDriveResponse {
	s.UsedSize = &v
	return s
}

type GetLinkInfoByUserIDRequest struct {
	Header *GetLinkInfoByUserIDRequestHeader `json:"header" xml:"header" type:"Struct"`
	UserId *string                           `json:"user_id" xml:"user_id" require:"true"`
}

func (s GetLinkInfoByUserIDRequest) String() string {
	return tea.Prettify(s)
}

func (s GetLinkInfoByUserIDRequest) GoString() string {
	return s.String()
}

func (s *GetLinkInfoByUserIDRequest) SetHeader(v *GetLinkInfoByUserIDRequestHeader) *GetLinkInfoByUserIDRequest {
	s.Header = v
	return s
}

func (s *GetLinkInfoByUserIDRequest) SetUserId(v string) *GetLinkInfoByUserIDRequest {
	s.UserId = &v
	return s
}

type GetLinkInfoByUserIDRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetLinkInfoByUserIDRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetLinkInfoByUserIDRequestHeader) GoString() string {
	return s.String()
}

func (s *GetLinkInfoByUserIDRequestHeader) SetTraceId(v string) *GetLinkInfoByUserIDRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetLinkInfoByUserIDRequestHeader) SetDeviceId(v string) *GetLinkInfoByUserIDRequestHeader {
	s.DeviceId = &v
	return s
}

type GetShareResponse struct {
	RequestId     *string   `json:"requestId" xml:"requestId"`
	CreatedAt     *string   `json:"created_at" xml:"created_at"`
	Creator       *string   `json:"creator" xml:"creator"`
	Description   *string   `json:"description" xml:"description"`
	DomainId      *string   `json:"domain_id" xml:"domain_id"`
	DriveId       *string   `json:"drive_id" xml:"drive_id"`
	Expiration    *string   `json:"expiration" xml:"expiration"`
	Expired       *bool     `json:"expired" xml:"expired"`
	Owner         *string   `json:"owner" xml:"owner"`
	Permissions   []*string `json:"permissions" xml:"permissions" type:"Repeated"`
	ShareFilePath *string   `json:"share_file_path" xml:"share_file_path"`
	ShareId       *string   `json:"share_id" xml:"share_id"`
	ShareName     *string   `json:"share_name" xml:"share_name"`
	Status        *string   `json:"status" xml:"status"`
	UpdatedAt     *string   `json:"updated_at" xml:"updated_at"`
}

func (s GetShareResponse) String() string {
	return tea.Prettify(s)
}

func (s GetShareResponse) GoString() string {
	return s.String()
}

func (s *GetShareResponse) SetRequestId(v string) *GetShareResponse {
	s.RequestId = &v
	return s
}

func (s *GetShareResponse) SetCreatedAt(v string) *GetShareResponse {
	s.CreatedAt = &v
	return s
}

func (s *GetShareResponse) SetCreator(v string) *GetShareResponse {
	s.Creator = &v
	return s
}

func (s *GetShareResponse) SetDescription(v string) *GetShareResponse {
	s.Description = &v
	return s
}

func (s *GetShareResponse) SetDomainId(v string) *GetShareResponse {
	s.DomainId = &v
	return s
}

func (s *GetShareResponse) SetDriveId(v string) *GetShareResponse {
	s.DriveId = &v
	return s
}

func (s *GetShareResponse) SetExpiration(v string) *GetShareResponse {
	s.Expiration = &v
	return s
}

func (s *GetShareResponse) SetExpired(v bool) *GetShareResponse {
	s.Expired = &v
	return s
}

func (s *GetShareResponse) SetOwner(v string) *GetShareResponse {
	s.Owner = &v
	return s
}

func (s *GetShareResponse) SetPermissions(v []*string) *GetShareResponse {
	s.Permissions = v
	return s
}

func (s *GetShareResponse) SetShareFilePath(v string) *GetShareResponse {
	s.ShareFilePath = &v
	return s
}

func (s *GetShareResponse) SetShareId(v string) *GetShareResponse {
	s.ShareId = &v
	return s
}

func (s *GetShareResponse) SetShareName(v string) *GetShareResponse {
	s.ShareName = &v
	return s
}

func (s *GetShareResponse) SetStatus(v string) *GetShareResponse {
	s.Status = &v
	return s
}

func (s *GetShareResponse) SetUpdatedAt(v string) *GetShareResponse {
	s.UpdatedAt = &v
	return s
}

type ImageMediaResponse struct {
	RequestId *string `json:"requestId" xml:"requestId"`
	Height    *int64  `json:"height" xml:"height"`
	Time      *string `json:"time" xml:"time"`
	Width     *int64  `json:"width" xml:"width"`
}

func (s ImageMediaResponse) String() string {
	return tea.Prettify(s)
}

func (s ImageMediaResponse) GoString() string {
	return s.String()
}

func (s *ImageMediaResponse) SetRequestId(v string) *ImageMediaResponse {
	s.RequestId = &v
	return s
}

func (s *ImageMediaResponse) SetHeight(v int64) *ImageMediaResponse {
	s.Height = &v
	return s
}

func (s *ImageMediaResponse) SetTime(v string) *ImageMediaResponse {
	s.Time = &v
	return s
}

func (s *ImageMediaResponse) SetWidth(v int64) *ImageMediaResponse {
	s.Width = &v
	return s
}

type LinkInfo struct {
	Identity *string `json:"identity" xml:"identity"`
	Type     *string `json:"type" xml:"type"`
}

func (s LinkInfo) String() string {
	return tea.Prettify(s)
}

func (s LinkInfo) GoString() string {
	return s.String()
}

func (s *LinkInfo) SetIdentity(v string) *LinkInfo {
	s.Identity = &v
	return s
}

func (s *LinkInfo) SetType(v string) *LinkInfo {
	s.Type = &v
	return s
}

type LinkInfoListResponse struct {
	RequestId *string             `json:"requestId" xml:"requestId"`
	Items     []*LinkInfoResponse `json:"items" xml:"items" require:"true" type:"Repeated"`
}

func (s LinkInfoListResponse) String() string {
	return tea.Prettify(s)
}

func (s LinkInfoListResponse) GoString() string {
	return s.String()
}

func (s *LinkInfoListResponse) SetRequestId(v string) *LinkInfoListResponse {
	s.RequestId = &v
	return s
}

func (s *LinkInfoListResponse) SetItems(v []*LinkInfoResponse) *LinkInfoListResponse {
	s.Items = v
	return s
}

type LinkInfoResponse struct {
	RequestId          *string `json:"requestId" xml:"requestId"`
	AuthenticationType *string `json:"authentication_type" xml:"authentication_type" require:"true"`
	CreatedAt          *int64  `json:"created_at" xml:"created_at" require:"true"`
	DomainId           *string `json:"domain_id" xml:"domain_id" require:"true"`
	Identity           *string `json:"identity" xml:"identity" require:"true"`
	LastLoginTime      *int64  `json:"last_login_time" xml:"last_login_time" require:"true"`
	Status             *string `json:"status" xml:"status" require:"true"`
	UserId             *string `json:"user_id" xml:"user_id" require:"true"`
}

func (s LinkInfoResponse) String() string {
	return tea.Prettify(s)
}

func (s LinkInfoResponse) GoString() string {
	return s.String()
}

func (s *LinkInfoResponse) SetRequestId(v string) *LinkInfoResponse {
	s.RequestId = &v
	return s
}

func (s *LinkInfoResponse) SetAuthenticationType(v string) *LinkInfoResponse {
	s.AuthenticationType = &v
	return s
}

func (s *LinkInfoResponse) SetCreatedAt(v int64) *LinkInfoResponse {
	s.CreatedAt = &v
	return s
}

func (s *LinkInfoResponse) SetDomainId(v string) *LinkInfoResponse {
	s.DomainId = &v
	return s
}

func (s *LinkInfoResponse) SetIdentity(v string) *LinkInfoResponse {
	s.Identity = &v
	return s
}

func (s *LinkInfoResponse) SetLastLoginTime(v int64) *LinkInfoResponse {
	s.LastLoginTime = &v
	return s
}

func (s *LinkInfoResponse) SetStatus(v string) *LinkInfoResponse {
	s.Status = &v
	return s
}

func (s *LinkInfoResponse) SetUserId(v string) *LinkInfoResponse {
	s.UserId = &v
	return s
}

type ListAppsRequest struct {
	Header *ListAppsRequestHeader `json:"header" xml:"header" type:"Struct"`
	Limit  *int                   `json:"limit" xml:"limit"`
	Marker *string                `json:"marker" xml:"marker"`
}

func (s ListAppsRequest) String() string {
	return tea.Prettify(s)
}

func (s ListAppsRequest) GoString() string {
	return s.String()
}

func (s *ListAppsRequest) SetHeader(v *ListAppsRequestHeader) *ListAppsRequest {
	s.Header = v
	return s
}

func (s *ListAppsRequest) SetLimit(v int) *ListAppsRequest {
	s.Limit = &v
	return s
}

func (s *ListAppsRequest) SetMarker(v string) *ListAppsRequest {
	s.Marker = &v
	return s
}

type ListAppsRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListAppsRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListAppsRequestHeader) GoString() string {
	return s.String()
}

func (s *ListAppsRequestHeader) SetTraceId(v string) *ListAppsRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListAppsRequestHeader) SetDeviceId(v string) *ListAppsRequestHeader {
	s.DeviceId = &v
	return s
}

type ListDomainsRequest struct {
	Header *ListDomainsRequestHeader `json:"header" xml:"header" type:"Struct"`
	Limit  *int                      `json:"limit" xml:"limit"`
	Marker *string                   `json:"marker" xml:"marker"`
}

func (s ListDomainsRequest) String() string {
	return tea.Prettify(s)
}

func (s ListDomainsRequest) GoString() string {
	return s.String()
}

func (s *ListDomainsRequest) SetHeader(v *ListDomainsRequestHeader) *ListDomainsRequest {
	s.Header = v
	return s
}

func (s *ListDomainsRequest) SetLimit(v int) *ListDomainsRequest {
	s.Limit = &v
	return s
}

func (s *ListDomainsRequest) SetMarker(v string) *ListDomainsRequest {
	s.Marker = &v
	return s
}

type ListDomainsRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListDomainsRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListDomainsRequestHeader) GoString() string {
	return s.String()
}

func (s *ListDomainsRequestHeader) SetTraceId(v string) *ListDomainsRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListDomainsRequestHeader) SetDeviceId(v string) *ListDomainsRequestHeader {
	s.DeviceId = &v
	return s
}

type ListDriveResponse struct {
	RequestId  *string              `json:"requestId" xml:"requestId"`
	Items      []*BaseDriveResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string              `json:"next_marker" xml:"next_marker"`
}

func (s ListDriveResponse) String() string {
	return tea.Prettify(s)
}

func (s ListDriveResponse) GoString() string {
	return s.String()
}

func (s *ListDriveResponse) SetRequestId(v string) *ListDriveResponse {
	s.RequestId = &v
	return s
}

func (s *ListDriveResponse) SetItems(v []*BaseDriveResponse) *ListDriveResponse {
	s.Items = v
	return s
}

func (s *ListDriveResponse) SetNextMarker(v string) *ListDriveResponse {
	s.NextMarker = &v
	return s
}

type ListShareResponse struct {
	RequestId  *string              `json:"requestId" xml:"requestId"`
	Items      []*BaseShareResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string              `json:"next_marker" xml:"next_marker"`
}

func (s ListShareResponse) String() string {
	return tea.Prettify(s)
}

func (s ListShareResponse) GoString() string {
	return s.String()
}

func (s *ListShareResponse) SetRequestId(v string) *ListShareResponse {
	s.RequestId = &v
	return s
}

func (s *ListShareResponse) SetItems(v []*BaseShareResponse) *ListShareResponse {
	s.Items = v
	return s
}

func (s *ListShareResponse) SetNextMarker(v string) *ListShareResponse {
	s.NextMarker = &v
	return s
}

type ListStoreFileResponse struct {
	RequestId  *string      `json:"requestId" xml:"requestId"`
	Items      []*StoreFile `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string      `json:"next_marker" xml:"next_marker"`
}

func (s ListStoreFileResponse) String() string {
	return tea.Prettify(s)
}

func (s ListStoreFileResponse) GoString() string {
	return s.String()
}

func (s *ListStoreFileResponse) SetRequestId(v string) *ListStoreFileResponse {
	s.RequestId = &v
	return s
}

func (s *ListStoreFileResponse) SetItems(v []*StoreFile) *ListStoreFileResponse {
	s.Items = v
	return s
}

func (s *ListStoreFileResponse) SetNextMarker(v string) *ListStoreFileResponse {
	s.NextMarker = &v
	return s
}

type ListStoreResponse struct {
	RequestId *string              `json:"requestId" xml:"requestId"`
	Items     []*StoreItemResponse `json:"items" xml:"items" type:"Repeated"`
}

func (s ListStoreResponse) String() string {
	return tea.Prettify(s)
}

func (s ListStoreResponse) GoString() string {
	return s.String()
}

func (s *ListStoreResponse) SetRequestId(v string) *ListStoreResponse {
	s.RequestId = &v
	return s
}

func (s *ListStoreResponse) SetItems(v []*StoreItemResponse) *ListStoreResponse {
	s.Items = v
	return s
}

type ListStoresRequest struct {
	Header   *ListStoresRequestHeader `json:"header" xml:"header" type:"Struct"`
	DomainId *string                  `json:"domain_id" xml:"domain_id" require:"true"`
}

func (s ListStoresRequest) String() string {
	return tea.Prettify(s)
}

func (s ListStoresRequest) GoString() string {
	return s.String()
}

func (s *ListStoresRequest) SetHeader(v *ListStoresRequestHeader) *ListStoresRequest {
	s.Header = v
	return s
}

func (s *ListStoresRequest) SetDomainId(v string) *ListStoresRequest {
	s.DomainId = &v
	return s
}

type ListStoresRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListStoresRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListStoresRequestHeader) GoString() string {
	return s.String()
}

func (s *ListStoresRequestHeader) SetTraceId(v string) *ListStoresRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListStoresRequestHeader) SetDeviceId(v string) *ListStoresRequestHeader {
	s.DeviceId = &v
	return s
}

type LoginByCodeRequest struct {
	Header      *LoginByCodeRequestHeader `json:"header" xml:"header" type:"Struct"`
	AccessToken *string                   `json:"access_token" xml:"access_token"`
	AppId       *string                   `json:"app_id" xml:"app_id" require:"true"`
	AuthCode    *string                   `json:"auth_code" xml:"auth_code"`
	Type        *string                   `json:"type" xml:"type" require:"true"`
}

func (s LoginByCodeRequest) String() string {
	return tea.Prettify(s)
}

func (s LoginByCodeRequest) GoString() string {
	return s.String()
}

func (s *LoginByCodeRequest) SetHeader(v *LoginByCodeRequestHeader) *LoginByCodeRequest {
	s.Header = v
	return s
}

func (s *LoginByCodeRequest) SetAccessToken(v string) *LoginByCodeRequest {
	s.AccessToken = &v
	return s
}

func (s *LoginByCodeRequest) SetAppId(v string) *LoginByCodeRequest {
	s.AppId = &v
	return s
}

func (s *LoginByCodeRequest) SetAuthCode(v string) *LoginByCodeRequest {
	s.AuthCode = &v
	return s
}

func (s *LoginByCodeRequest) SetType(v string) *LoginByCodeRequest {
	s.Type = &v
	return s
}

type LoginByCodeRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s LoginByCodeRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s LoginByCodeRequestHeader) GoString() string {
	return s.String()
}

func (s *LoginByCodeRequestHeader) SetTraceId(v string) *LoginByCodeRequestHeader {
	s.TraceId = &v
	return s
}

func (s *LoginByCodeRequestHeader) SetDeviceId(v string) *LoginByCodeRequestHeader {
	s.DeviceId = &v
	return s
}

type MobileCheckExistRequest struct {
	Header      *MobileCheckExistRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId       *string                        `json:"app_id" xml:"app_id" require:"true"`
	PhoneNumber *string                        `json:"phone_number" xml:"phone_number" require:"true"`
}

func (s MobileCheckExistRequest) String() string {
	return tea.Prettify(s)
}

func (s MobileCheckExistRequest) GoString() string {
	return s.String()
}

func (s *MobileCheckExistRequest) SetHeader(v *MobileCheckExistRequestHeader) *MobileCheckExistRequest {
	s.Header = v
	return s
}

func (s *MobileCheckExistRequest) SetAppId(v string) *MobileCheckExistRequest {
	s.AppId = &v
	return s
}

func (s *MobileCheckExistRequest) SetPhoneNumber(v string) *MobileCheckExistRequest {
	s.PhoneNumber = &v
	return s
}

type MobileCheckExistRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s MobileCheckExistRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s MobileCheckExistRequestHeader) GoString() string {
	return s.String()
}

func (s *MobileCheckExistRequestHeader) SetTraceId(v string) *MobileCheckExistRequestHeader {
	s.TraceId = &v
	return s
}

func (s *MobileCheckExistRequestHeader) SetDeviceId(v string) *MobileCheckExistRequestHeader {
	s.DeviceId = &v
	return s
}

type MobileCheckExistResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	IsExist     *bool   `json:"is_exist" xml:"is_exist" require:"true"`
	PhoneNumber *string `json:"phone_number" xml:"phone_number" require:"true"`
}

func (s MobileCheckExistResponse) String() string {
	return tea.Prettify(s)
}

func (s MobileCheckExistResponse) GoString() string {
	return s.String()
}

func (s *MobileCheckExistResponse) SetRequestId(v string) *MobileCheckExistResponse {
	s.RequestId = &v
	return s
}

func (s *MobileCheckExistResponse) SetIsExist(v bool) *MobileCheckExistResponse {
	s.IsExist = &v
	return s
}

func (s *MobileCheckExistResponse) SetPhoneNumber(v string) *MobileCheckExistResponse {
	s.PhoneNumber = &v
	return s
}

type MobileLoginRequest struct {
	Header       *MobileLoginRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId        *string                   `json:"app_id" xml:"app_id" require:"true"`
	AutoRegister *bool                     `json:"auto_register" xml:"auto_register"`
	CaptchaId    *string                   `json:"captcha_id" xml:"captcha_id"`
	CaptchaText  *string                   `json:"captcha_text" xml:"captcha_text"`
	Password     *string                   `json:"password" xml:"password"`
	PhoneNumber  *string                   `json:"phone_number" xml:"phone_number" require:"true"`
	SmsCode      *string                   `json:"sms_code" xml:"sms_code"`
	SmsCodeId    *string                   `json:"sms_code_id" xml:"sms_code_id"`
}

func (s MobileLoginRequest) String() string {
	return tea.Prettify(s)
}

func (s MobileLoginRequest) GoString() string {
	return s.String()
}

func (s *MobileLoginRequest) SetHeader(v *MobileLoginRequestHeader) *MobileLoginRequest {
	s.Header = v
	return s
}

func (s *MobileLoginRequest) SetAppId(v string) *MobileLoginRequest {
	s.AppId = &v
	return s
}

func (s *MobileLoginRequest) SetAutoRegister(v bool) *MobileLoginRequest {
	s.AutoRegister = &v
	return s
}

func (s *MobileLoginRequest) SetCaptchaId(v string) *MobileLoginRequest {
	s.CaptchaId = &v
	return s
}

func (s *MobileLoginRequest) SetCaptchaText(v string) *MobileLoginRequest {
	s.CaptchaText = &v
	return s
}

func (s *MobileLoginRequest) SetPassword(v string) *MobileLoginRequest {
	s.Password = &v
	return s
}

func (s *MobileLoginRequest) SetPhoneNumber(v string) *MobileLoginRequest {
	s.PhoneNumber = &v
	return s
}

func (s *MobileLoginRequest) SetSmsCode(v string) *MobileLoginRequest {
	s.SmsCode = &v
	return s
}

func (s *MobileLoginRequest) SetSmsCodeId(v string) *MobileLoginRequest {
	s.SmsCodeId = &v
	return s
}

type MobileLoginRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s MobileLoginRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s MobileLoginRequestHeader) GoString() string {
	return s.String()
}

func (s *MobileLoginRequestHeader) SetTraceId(v string) *MobileLoginRequestHeader {
	s.TraceId = &v
	return s
}

func (s *MobileLoginRequestHeader) SetDeviceId(v string) *MobileLoginRequestHeader {
	s.DeviceId = &v
	return s
}

type MobileRegisterRequest struct {
	Header      *MobileRegisterRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId       *string                      `json:"app_id" xml:"app_id" require:"true"`
	PhoneNumber *string                      `json:"phone_number" xml:"phone_number" require:"true"`
	SmsCode     *string                      `json:"sms_code" xml:"sms_code" require:"true"`
	SmsCodeId   *string                      `json:"sms_code_id" xml:"sms_code_id" require:"true"`
}

func (s MobileRegisterRequest) String() string {
	return tea.Prettify(s)
}

func (s MobileRegisterRequest) GoString() string {
	return s.String()
}

func (s *MobileRegisterRequest) SetHeader(v *MobileRegisterRequestHeader) *MobileRegisterRequest {
	s.Header = v
	return s
}

func (s *MobileRegisterRequest) SetAppId(v string) *MobileRegisterRequest {
	s.AppId = &v
	return s
}

func (s *MobileRegisterRequest) SetPhoneNumber(v string) *MobileRegisterRequest {
	s.PhoneNumber = &v
	return s
}

func (s *MobileRegisterRequest) SetSmsCode(v string) *MobileRegisterRequest {
	s.SmsCode = &v
	return s
}

func (s *MobileRegisterRequest) SetSmsCodeId(v string) *MobileRegisterRequest {
	s.SmsCodeId = &v
	return s
}

type MobileRegisterRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s MobileRegisterRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s MobileRegisterRequestHeader) GoString() string {
	return s.String()
}

func (s *MobileRegisterRequestHeader) SetTraceId(v string) *MobileRegisterRequestHeader {
	s.TraceId = &v
	return s
}

func (s *MobileRegisterRequestHeader) SetDeviceId(v string) *MobileRegisterRequestHeader {
	s.DeviceId = &v
	return s
}

type MobileSendSmsCodeRequest struct {
	Header      *MobileSendSmsCodeRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId       *string                         `json:"app_id" xml:"app_id" require:"true"`
	CaptchaId   *string                         `json:"captcha_id" xml:"captcha_id"`
	CaptchaText *string                         `json:"captcha_text" xml:"captcha_text"`
	PhoneNumber *string                         `json:"phone_number" xml:"phone_number" require:"true"`
	Type        *string                         `json:"type" xml:"type" require:"true"`
}

func (s MobileSendSmsCodeRequest) String() string {
	return tea.Prettify(s)
}

func (s MobileSendSmsCodeRequest) GoString() string {
	return s.String()
}

func (s *MobileSendSmsCodeRequest) SetHeader(v *MobileSendSmsCodeRequestHeader) *MobileSendSmsCodeRequest {
	s.Header = v
	return s
}

func (s *MobileSendSmsCodeRequest) SetAppId(v string) *MobileSendSmsCodeRequest {
	s.AppId = &v
	return s
}

func (s *MobileSendSmsCodeRequest) SetCaptchaId(v string) *MobileSendSmsCodeRequest {
	s.CaptchaId = &v
	return s
}

func (s *MobileSendSmsCodeRequest) SetCaptchaText(v string) *MobileSendSmsCodeRequest {
	s.CaptchaText = &v
	return s
}

func (s *MobileSendSmsCodeRequest) SetPhoneNumber(v string) *MobileSendSmsCodeRequest {
	s.PhoneNumber = &v
	return s
}

func (s *MobileSendSmsCodeRequest) SetType(v string) *MobileSendSmsCodeRequest {
	s.Type = &v
	return s
}

type MobileSendSmsCodeRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s MobileSendSmsCodeRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s MobileSendSmsCodeRequestHeader) GoString() string {
	return s.String()
}

func (s *MobileSendSmsCodeRequestHeader) SetTraceId(v string) *MobileSendSmsCodeRequestHeader {
	s.TraceId = &v
	return s
}

func (s *MobileSendSmsCodeRequestHeader) SetDeviceId(v string) *MobileSendSmsCodeRequestHeader {
	s.DeviceId = &v
	return s
}

type MobileSendSmsCodeResponse struct {
	RequestId *string `json:"requestId" xml:"requestId"`
	SmsCodeId *string `json:"sms_code_id" xml:"sms_code_id" require:"true"`
}

func (s MobileSendSmsCodeResponse) String() string {
	return tea.Prettify(s)
}

func (s MobileSendSmsCodeResponse) GoString() string {
	return s.String()
}

func (s *MobileSendSmsCodeResponse) SetRequestId(v string) *MobileSendSmsCodeResponse {
	s.RequestId = &v
	return s
}

func (s *MobileSendSmsCodeResponse) SetSmsCodeId(v string) *MobileSendSmsCodeResponse {
	s.SmsCodeId = &v
	return s
}

type OSSCompleteFileResponse struct {
	RequestId       *string `json:"requestId" xml:"requestId"`
	ContentHash     *string `json:"content_hash" xml:"content_hash"`
	ContentHashName *string `json:"content_hash_name" xml:"content_hash_name"`
	ContentType     *string `json:"content_type" xml:"content_type"`
	Crc64Hash       *string `json:"crc64_hash" xml:"crc64_hash"`
	CreatedAt       *string `json:"created_at" xml:"created_at"`
	Description     *string `json:"description" xml:"description"`
	DomainId        *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DownloadUrl     *string `json:"download_url" xml:"download_url"`
	DriveId         *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileExtension   *string `json:"file_extension" xml:"file_extension"`
	FilePath        *string `json:"file_path" xml:"file_path"`
	Name            *string `json:"name" xml:"name" pattern:"[a-zA-Z0-9.-]{1,1024}"`
	ParentFilePath  *string `json:"parent_file_path" xml:"parent_file_path" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	ShareId         *string `json:"share_id" xml:"share_id" pattern:"[0-9]+"`
	Size            *int64  `json:"size" xml:"size"`
	Status          *string `json:"status" xml:"status"`
	Thumbnail       *string `json:"thumbnail" xml:"thumbnail"`
	TrashedAt       *string `json:"trashed_at" xml:"trashed_at"`
	Type            *string `json:"type" xml:"type"`
	UpdatedAt       *string `json:"updated_at" xml:"updated_at"`
	UploadId        *string `json:"upload_id" xml:"upload_id"`
	Url             *string `json:"url" xml:"url"`
	Crc             *string `json:"crc" xml:"crc"`
}

func (s OSSCompleteFileResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSCompleteFileResponse) GoString() string {
	return s.String()
}

func (s *OSSCompleteFileResponse) SetRequestId(v string) *OSSCompleteFileResponse {
	s.RequestId = &v
	return s
}

func (s *OSSCompleteFileResponse) SetContentHash(v string) *OSSCompleteFileResponse {
	s.ContentHash = &v
	return s
}

func (s *OSSCompleteFileResponse) SetContentHashName(v string) *OSSCompleteFileResponse {
	s.ContentHashName = &v
	return s
}

func (s *OSSCompleteFileResponse) SetContentType(v string) *OSSCompleteFileResponse {
	s.ContentType = &v
	return s
}

func (s *OSSCompleteFileResponse) SetCrc64Hash(v string) *OSSCompleteFileResponse {
	s.Crc64Hash = &v
	return s
}

func (s *OSSCompleteFileResponse) SetCreatedAt(v string) *OSSCompleteFileResponse {
	s.CreatedAt = &v
	return s
}

func (s *OSSCompleteFileResponse) SetDescription(v string) *OSSCompleteFileResponse {
	s.Description = &v
	return s
}

func (s *OSSCompleteFileResponse) SetDomainId(v string) *OSSCompleteFileResponse {
	s.DomainId = &v
	return s
}

func (s *OSSCompleteFileResponse) SetDownloadUrl(v string) *OSSCompleteFileResponse {
	s.DownloadUrl = &v
	return s
}

func (s *OSSCompleteFileResponse) SetDriveId(v string) *OSSCompleteFileResponse {
	s.DriveId = &v
	return s
}

func (s *OSSCompleteFileResponse) SetFileExtension(v string) *OSSCompleteFileResponse {
	s.FileExtension = &v
	return s
}

func (s *OSSCompleteFileResponse) SetFilePath(v string) *OSSCompleteFileResponse {
	s.FilePath = &v
	return s
}

func (s *OSSCompleteFileResponse) SetName(v string) *OSSCompleteFileResponse {
	s.Name = &v
	return s
}

func (s *OSSCompleteFileResponse) SetParentFilePath(v string) *OSSCompleteFileResponse {
	s.ParentFilePath = &v
	return s
}

func (s *OSSCompleteFileResponse) SetShareId(v string) *OSSCompleteFileResponse {
	s.ShareId = &v
	return s
}

func (s *OSSCompleteFileResponse) SetSize(v int64) *OSSCompleteFileResponse {
	s.Size = &v
	return s
}

func (s *OSSCompleteFileResponse) SetStatus(v string) *OSSCompleteFileResponse {
	s.Status = &v
	return s
}

func (s *OSSCompleteFileResponse) SetThumbnail(v string) *OSSCompleteFileResponse {
	s.Thumbnail = &v
	return s
}

func (s *OSSCompleteFileResponse) SetTrashedAt(v string) *OSSCompleteFileResponse {
	s.TrashedAt = &v
	return s
}

func (s *OSSCompleteFileResponse) SetType(v string) *OSSCompleteFileResponse {
	s.Type = &v
	return s
}

func (s *OSSCompleteFileResponse) SetUpdatedAt(v string) *OSSCompleteFileResponse {
	s.UpdatedAt = &v
	return s
}

func (s *OSSCompleteFileResponse) SetUploadId(v string) *OSSCompleteFileResponse {
	s.UploadId = &v
	return s
}

func (s *OSSCompleteFileResponse) SetUrl(v string) *OSSCompleteFileResponse {
	s.Url = &v
	return s
}

func (s *OSSCompleteFileResponse) SetCrc(v string) *OSSCompleteFileResponse {
	s.Crc = &v
	return s
}

type OSSCopyFileResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AsyncTaskId *string `json:"async_task_id" xml:"async_task_id"`
	DomainId    *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z-]+"`
	DriveId     *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath    *string `json:"file_path" xml:"file_path"`
	ShareId     *string `json:"share_id" xml:"share_id" pattern:"[a-z0-9A-Z]+"`
}

func (s OSSCopyFileResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSCopyFileResponse) GoString() string {
	return s.String()
}

func (s *OSSCopyFileResponse) SetRequestId(v string) *OSSCopyFileResponse {
	s.RequestId = &v
	return s
}

func (s *OSSCopyFileResponse) SetAsyncTaskId(v string) *OSSCopyFileResponse {
	s.AsyncTaskId = &v
	return s
}

func (s *OSSCopyFileResponse) SetDomainId(v string) *OSSCopyFileResponse {
	s.DomainId = &v
	return s
}

func (s *OSSCopyFileResponse) SetDriveId(v string) *OSSCopyFileResponse {
	s.DriveId = &v
	return s
}

func (s *OSSCopyFileResponse) SetFilePath(v string) *OSSCopyFileResponse {
	s.FilePath = &v
	return s
}

func (s *OSSCopyFileResponse) SetShareId(v string) *OSSCopyFileResponse {
	s.ShareId = &v
	return s
}

type OSSCreateFileResponse struct {
	RequestId    *string           `json:"requestId" xml:"requestId"`
	DomainId     *string           `json:"domain_id" xml:"domain_id" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	DriveId      *string           `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath     *string           `json:"file_path" xml:"file_path"`
	PartInfoList []*UploadPartInfo `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	ShareId      *string           `json:"share_id" xml:"share_id" pattern:"[0-9]+"`
	Type         *string           `json:"type" xml:"type"`
	UploadId     *string           `json:"upload_id" xml:"upload_id"`
}

func (s OSSCreateFileResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSCreateFileResponse) GoString() string {
	return s.String()
}

func (s *OSSCreateFileResponse) SetRequestId(v string) *OSSCreateFileResponse {
	s.RequestId = &v
	return s
}

func (s *OSSCreateFileResponse) SetDomainId(v string) *OSSCreateFileResponse {
	s.DomainId = &v
	return s
}

func (s *OSSCreateFileResponse) SetDriveId(v string) *OSSCreateFileResponse {
	s.DriveId = &v
	return s
}

func (s *OSSCreateFileResponse) SetFilePath(v string) *OSSCreateFileResponse {
	s.FilePath = &v
	return s
}

func (s *OSSCreateFileResponse) SetPartInfoList(v []*UploadPartInfo) *OSSCreateFileResponse {
	s.PartInfoList = v
	return s
}

func (s *OSSCreateFileResponse) SetShareId(v string) *OSSCreateFileResponse {
	s.ShareId = &v
	return s
}

func (s *OSSCreateFileResponse) SetType(v string) *OSSCreateFileResponse {
	s.Type = &v
	return s
}

func (s *OSSCreateFileResponse) SetUploadId(v string) *OSSCreateFileResponse {
	s.UploadId = &v
	return s
}

type OSSDeleteFileResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AsyncTaskId *string `json:"async_task_id" xml:"async_task_id"`
	DomainId    *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DriveId     *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath    *string `json:"file_path" xml:"file_path"`
	ShareId     *string `json:"share_id" xml:"share_id" pattern:"[a-z0-9A-Z]+"`
}

func (s OSSDeleteFileResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSDeleteFileResponse) GoString() string {
	return s.String()
}

func (s *OSSDeleteFileResponse) SetRequestId(v string) *OSSDeleteFileResponse {
	s.RequestId = &v
	return s
}

func (s *OSSDeleteFileResponse) SetAsyncTaskId(v string) *OSSDeleteFileResponse {
	s.AsyncTaskId = &v
	return s
}

func (s *OSSDeleteFileResponse) SetDomainId(v string) *OSSDeleteFileResponse {
	s.DomainId = &v
	return s
}

func (s *OSSDeleteFileResponse) SetDriveId(v string) *OSSDeleteFileResponse {
	s.DriveId = &v
	return s
}

func (s *OSSDeleteFileResponse) SetFilePath(v string) *OSSDeleteFileResponse {
	s.FilePath = &v
	return s
}

func (s *OSSDeleteFileResponse) SetShareId(v string) *OSSDeleteFileResponse {
	s.ShareId = &v
	return s
}

type OSSDeleteFilesResponse struct {
	RequestId         *string   `json:"requestId" xml:"requestId"`
	DeletedFileIdList []*string `json:"deleted_file_id_list" xml:"deleted_file_id_list" type:"Repeated"`
	DomainId          *string   `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DriveId           *string   `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ShareId           *string   `json:"share_id" xml:"share_id" pattern:"[0-9]+"`
}

func (s OSSDeleteFilesResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSDeleteFilesResponse) GoString() string {
	return s.String()
}

func (s *OSSDeleteFilesResponse) SetRequestId(v string) *OSSDeleteFilesResponse {
	s.RequestId = &v
	return s
}

func (s *OSSDeleteFilesResponse) SetDeletedFileIdList(v []*string) *OSSDeleteFilesResponse {
	s.DeletedFileIdList = v
	return s
}

func (s *OSSDeleteFilesResponse) SetDomainId(v string) *OSSDeleteFilesResponse {
	s.DomainId = &v
	return s
}

func (s *OSSDeleteFilesResponse) SetDriveId(v string) *OSSDeleteFilesResponse {
	s.DriveId = &v
	return s
}

func (s *OSSDeleteFilesResponse) SetShareId(v string) *OSSDeleteFilesResponse {
	s.ShareId = &v
	return s
}

type OSSGetDownloadUrlResponse struct {
	RequestId  *string `json:"requestId" xml:"requestId"`
	Expiration *string `json:"expiration" xml:"expiration"`
	Method     *string `json:"method" xml:"method"`
	Url        *string `json:"url" xml:"url"`
}

func (s OSSGetDownloadUrlResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSGetDownloadUrlResponse) GoString() string {
	return s.String()
}

func (s *OSSGetDownloadUrlResponse) SetRequestId(v string) *OSSGetDownloadUrlResponse {
	s.RequestId = &v
	return s
}

func (s *OSSGetDownloadUrlResponse) SetExpiration(v string) *OSSGetDownloadUrlResponse {
	s.Expiration = &v
	return s
}

func (s *OSSGetDownloadUrlResponse) SetMethod(v string) *OSSGetDownloadUrlResponse {
	s.Method = &v
	return s
}

func (s *OSSGetDownloadUrlResponse) SetUrl(v string) *OSSGetDownloadUrlResponse {
	s.Url = &v
	return s
}

type OSSGetFileResponse struct {
	RequestId       *string `json:"requestId" xml:"requestId"`
	ContentHash     *string `json:"content_hash" xml:"content_hash"`
	ContentHashName *string `json:"content_hash_name" xml:"content_hash_name"`
	ContentType     *string `json:"content_type" xml:"content_type"`
	Crc64Hash       *string `json:"crc64_hash" xml:"crc64_hash"`
	CreatedAt       *string `json:"created_at" xml:"created_at"`
	Description     *string `json:"description" xml:"description"`
	DomainId        *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DownloadUrl     *string `json:"download_url" xml:"download_url"`
	DriveId         *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileExtension   *string `json:"file_extension" xml:"file_extension"`
	FilePath        *string `json:"file_path" xml:"file_path"`
	Name            *string `json:"name" xml:"name" pattern:"[a-zA-Z0-9.-]{1,1024}"`
	ParentFilePath  *string `json:"parent_file_path" xml:"parent_file_path" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	ShareId         *string `json:"share_id" xml:"share_id" pattern:"[0-9]+"`
	Size            *int64  `json:"size" xml:"size"`
	Status          *string `json:"status" xml:"status"`
	Thumbnail       *string `json:"thumbnail" xml:"thumbnail"`
	TrashedAt       *string `json:"trashed_at" xml:"trashed_at"`
	Type            *string `json:"type" xml:"type"`
	UpdatedAt       *string `json:"updated_at" xml:"updated_at"`
	UploadId        *string `json:"upload_id" xml:"upload_id"`
	Url             *string `json:"url" xml:"url"`
}

func (s OSSGetFileResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSGetFileResponse) GoString() string {
	return s.String()
}

func (s *OSSGetFileResponse) SetRequestId(v string) *OSSGetFileResponse {
	s.RequestId = &v
	return s
}

func (s *OSSGetFileResponse) SetContentHash(v string) *OSSGetFileResponse {
	s.ContentHash = &v
	return s
}

func (s *OSSGetFileResponse) SetContentHashName(v string) *OSSGetFileResponse {
	s.ContentHashName = &v
	return s
}

func (s *OSSGetFileResponse) SetContentType(v string) *OSSGetFileResponse {
	s.ContentType = &v
	return s
}

func (s *OSSGetFileResponse) SetCrc64Hash(v string) *OSSGetFileResponse {
	s.Crc64Hash = &v
	return s
}

func (s *OSSGetFileResponse) SetCreatedAt(v string) *OSSGetFileResponse {
	s.CreatedAt = &v
	return s
}

func (s *OSSGetFileResponse) SetDescription(v string) *OSSGetFileResponse {
	s.Description = &v
	return s
}

func (s *OSSGetFileResponse) SetDomainId(v string) *OSSGetFileResponse {
	s.DomainId = &v
	return s
}

func (s *OSSGetFileResponse) SetDownloadUrl(v string) *OSSGetFileResponse {
	s.DownloadUrl = &v
	return s
}

func (s *OSSGetFileResponse) SetDriveId(v string) *OSSGetFileResponse {
	s.DriveId = &v
	return s
}

func (s *OSSGetFileResponse) SetFileExtension(v string) *OSSGetFileResponse {
	s.FileExtension = &v
	return s
}

func (s *OSSGetFileResponse) SetFilePath(v string) *OSSGetFileResponse {
	s.FilePath = &v
	return s
}

func (s *OSSGetFileResponse) SetName(v string) *OSSGetFileResponse {
	s.Name = &v
	return s
}

func (s *OSSGetFileResponse) SetParentFilePath(v string) *OSSGetFileResponse {
	s.ParentFilePath = &v
	return s
}

func (s *OSSGetFileResponse) SetShareId(v string) *OSSGetFileResponse {
	s.ShareId = &v
	return s
}

func (s *OSSGetFileResponse) SetSize(v int64) *OSSGetFileResponse {
	s.Size = &v
	return s
}

func (s *OSSGetFileResponse) SetStatus(v string) *OSSGetFileResponse {
	s.Status = &v
	return s
}

func (s *OSSGetFileResponse) SetThumbnail(v string) *OSSGetFileResponse {
	s.Thumbnail = &v
	return s
}

func (s *OSSGetFileResponse) SetTrashedAt(v string) *OSSGetFileResponse {
	s.TrashedAt = &v
	return s
}

func (s *OSSGetFileResponse) SetType(v string) *OSSGetFileResponse {
	s.Type = &v
	return s
}

func (s *OSSGetFileResponse) SetUpdatedAt(v string) *OSSGetFileResponse {
	s.UpdatedAt = &v
	return s
}

func (s *OSSGetFileResponse) SetUploadId(v string) *OSSGetFileResponse {
	s.UploadId = &v
	return s
}

func (s *OSSGetFileResponse) SetUrl(v string) *OSSGetFileResponse {
	s.Url = &v
	return s
}

type OSSGetUploadUrlResponse struct {
	RequestId    *string           `json:"requestId" xml:"requestId"`
	CreateAt     *string           `json:"create_at" xml:"create_at"`
	DomainId     *string           `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DriveId      *string           `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath     *string           `json:"file_path" xml:"file_path"`
	PartInfoList []*UploadPartInfo `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	UploadId     *string           `json:"upload_id" xml:"upload_id"`
}

func (s OSSGetUploadUrlResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSGetUploadUrlResponse) GoString() string {
	return s.String()
}

func (s *OSSGetUploadUrlResponse) SetRequestId(v string) *OSSGetUploadUrlResponse {
	s.RequestId = &v
	return s
}

func (s *OSSGetUploadUrlResponse) SetCreateAt(v string) *OSSGetUploadUrlResponse {
	s.CreateAt = &v
	return s
}

func (s *OSSGetUploadUrlResponse) SetDomainId(v string) *OSSGetUploadUrlResponse {
	s.DomainId = &v
	return s
}

func (s *OSSGetUploadUrlResponse) SetDriveId(v string) *OSSGetUploadUrlResponse {
	s.DriveId = &v
	return s
}

func (s *OSSGetUploadUrlResponse) SetFilePath(v string) *OSSGetUploadUrlResponse {
	s.FilePath = &v
	return s
}

func (s *OSSGetUploadUrlResponse) SetPartInfoList(v []*UploadPartInfo) *OSSGetUploadUrlResponse {
	s.PartInfoList = v
	return s
}

func (s *OSSGetUploadUrlResponse) SetUploadId(v string) *OSSGetUploadUrlResponse {
	s.UploadId = &v
	return s
}

type OSSListFileResponse struct {
	RequestId  *string                `json:"requestId" xml:"requestId"`
	Items      []*BaseOSSFileResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string                `json:"next_marker" xml:"next_marker"`
}

func (s OSSListFileResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSListFileResponse) GoString() string {
	return s.String()
}

func (s *OSSListFileResponse) SetRequestId(v string) *OSSListFileResponse {
	s.RequestId = &v
	return s
}

func (s *OSSListFileResponse) SetItems(v []*BaseOSSFileResponse) *OSSListFileResponse {
	s.Items = v
	return s
}

func (s *OSSListFileResponse) SetNextMarker(v string) *OSSListFileResponse {
	s.NextMarker = &v
	return s
}

type OSSListUploadedPartResponse struct {
	RequestId            *string           `json:"requestId" xml:"requestId"`
	FilePath             *string           `json:"file_path" xml:"file_path"`
	NextPartNumberMarker *string           `json:"next_part_number_marker" xml:"next_part_number_marker"`
	UploadId             *string           `json:"upload_id" xml:"upload_id"`
	UploadedParts        []*UploadPartInfo `json:"uploaded_parts" xml:"uploaded_parts" type:"Repeated"`
}

func (s OSSListUploadedPartResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSListUploadedPartResponse) GoString() string {
	return s.String()
}

func (s *OSSListUploadedPartResponse) SetRequestId(v string) *OSSListUploadedPartResponse {
	s.RequestId = &v
	return s
}

func (s *OSSListUploadedPartResponse) SetFilePath(v string) *OSSListUploadedPartResponse {
	s.FilePath = &v
	return s
}

func (s *OSSListUploadedPartResponse) SetNextPartNumberMarker(v string) *OSSListUploadedPartResponse {
	s.NextPartNumberMarker = &v
	return s
}

func (s *OSSListUploadedPartResponse) SetUploadId(v string) *OSSListUploadedPartResponse {
	s.UploadId = &v
	return s
}

func (s *OSSListUploadedPartResponse) SetUploadedParts(v []*UploadPartInfo) *OSSListUploadedPartResponse {
	s.UploadedParts = v
	return s
}

type OSSMoveFileResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AsyncTaskId *string `json:"async_task_id" xml:"async_task_id"`
	DomainId    *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z-]+"`
	DriveId     *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath    *string `json:"file_path" xml:"file_path"`
	ShareId     *string `json:"share_id" xml:"share_id" pattern:"[a-z0-9A-Z]+"`
}

func (s OSSMoveFileResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSMoveFileResponse) GoString() string {
	return s.String()
}

func (s *OSSMoveFileResponse) SetRequestId(v string) *OSSMoveFileResponse {
	s.RequestId = &v
	return s
}

func (s *OSSMoveFileResponse) SetAsyncTaskId(v string) *OSSMoveFileResponse {
	s.AsyncTaskId = &v
	return s
}

func (s *OSSMoveFileResponse) SetDomainId(v string) *OSSMoveFileResponse {
	s.DomainId = &v
	return s
}

func (s *OSSMoveFileResponse) SetDriveId(v string) *OSSMoveFileResponse {
	s.DriveId = &v
	return s
}

func (s *OSSMoveFileResponse) SetFilePath(v string) *OSSMoveFileResponse {
	s.FilePath = &v
	return s
}

func (s *OSSMoveFileResponse) SetShareId(v string) *OSSMoveFileResponse {
	s.ShareId = &v
	return s
}

type OSSSearchFileResponse struct {
	RequestId  *string                `json:"requestId" xml:"requestId"`
	Items      []*BaseOSSFileResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string                `json:"next_marker" xml:"next_marker"`
}

func (s OSSSearchFileResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSSearchFileResponse) GoString() string {
	return s.String()
}

func (s *OSSSearchFileResponse) SetRequestId(v string) *OSSSearchFileResponse {
	s.RequestId = &v
	return s
}

func (s *OSSSearchFileResponse) SetItems(v []*BaseOSSFileResponse) *OSSSearchFileResponse {
	s.Items = v
	return s
}

func (s *OSSSearchFileResponse) SetNextMarker(v string) *OSSSearchFileResponse {
	s.NextMarker = &v
	return s
}

type OSSUpdateFileMetaResponse struct {
	RequestId       *string `json:"requestId" xml:"requestId"`
	ContentHash     *string `json:"content_hash" xml:"content_hash"`
	ContentHashName *string `json:"content_hash_name" xml:"content_hash_name"`
	ContentType     *string `json:"content_type" xml:"content_type"`
	Crc64Hash       *string `json:"crc64_hash" xml:"crc64_hash"`
	CreatedAt       *string `json:"created_at" xml:"created_at"`
	Description     *string `json:"description" xml:"description"`
	DomainId        *string `json:"domain_id" xml:"domain_id" pattern:"[a-z0-9A-Z]+"`
	DownloadUrl     *string `json:"download_url" xml:"download_url"`
	DriveId         *string `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FileExtension   *string `json:"file_extension" xml:"file_extension"`
	FilePath        *string `json:"file_path" xml:"file_path"`
	Name            *string `json:"name" xml:"name" pattern:"[a-zA-Z0-9.-]{1,1024}"`
	ParentFilePath  *string `json:"parent_file_path" xml:"parent_file_path" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	ShareId         *string `json:"share_id" xml:"share_id" pattern:"[0-9]+"`
	Size            *int64  `json:"size" xml:"size"`
	Status          *string `json:"status" xml:"status"`
	Thumbnail       *string `json:"thumbnail" xml:"thumbnail"`
	TrashedAt       *string `json:"trashed_at" xml:"trashed_at"`
	Type            *string `json:"type" xml:"type"`
	UpdatedAt       *string `json:"updated_at" xml:"updated_at"`
	UploadId        *string `json:"upload_id" xml:"upload_id"`
	Url             *string `json:"url" xml:"url"`
}

func (s OSSUpdateFileMetaResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSUpdateFileMetaResponse) GoString() string {
	return s.String()
}

func (s *OSSUpdateFileMetaResponse) SetRequestId(v string) *OSSUpdateFileMetaResponse {
	s.RequestId = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetContentHash(v string) *OSSUpdateFileMetaResponse {
	s.ContentHash = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetContentHashName(v string) *OSSUpdateFileMetaResponse {
	s.ContentHashName = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetContentType(v string) *OSSUpdateFileMetaResponse {
	s.ContentType = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetCrc64Hash(v string) *OSSUpdateFileMetaResponse {
	s.Crc64Hash = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetCreatedAt(v string) *OSSUpdateFileMetaResponse {
	s.CreatedAt = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetDescription(v string) *OSSUpdateFileMetaResponse {
	s.Description = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetDomainId(v string) *OSSUpdateFileMetaResponse {
	s.DomainId = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetDownloadUrl(v string) *OSSUpdateFileMetaResponse {
	s.DownloadUrl = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetDriveId(v string) *OSSUpdateFileMetaResponse {
	s.DriveId = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetFileExtension(v string) *OSSUpdateFileMetaResponse {
	s.FileExtension = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetFilePath(v string) *OSSUpdateFileMetaResponse {
	s.FilePath = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetName(v string) *OSSUpdateFileMetaResponse {
	s.Name = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetParentFilePath(v string) *OSSUpdateFileMetaResponse {
	s.ParentFilePath = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetShareId(v string) *OSSUpdateFileMetaResponse {
	s.ShareId = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetSize(v int64) *OSSUpdateFileMetaResponse {
	s.Size = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetStatus(v string) *OSSUpdateFileMetaResponse {
	s.Status = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetThumbnail(v string) *OSSUpdateFileMetaResponse {
	s.Thumbnail = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetTrashedAt(v string) *OSSUpdateFileMetaResponse {
	s.TrashedAt = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetType(v string) *OSSUpdateFileMetaResponse {
	s.Type = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetUpdatedAt(v string) *OSSUpdateFileMetaResponse {
	s.UpdatedAt = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetUploadId(v string) *OSSUpdateFileMetaResponse {
	s.UploadId = &v
	return s
}

func (s *OSSUpdateFileMetaResponse) SetUrl(v string) *OSSUpdateFileMetaResponse {
	s.Url = &v
	return s
}

type PreHashCheckSuccessResponse struct {
	RequestId    *string `json:"requestId" xml:"requestId"`
	Code         *string `json:"code" xml:"code"`
	FileName     *string `json:"file_name" xml:"file_name"`
	Message      *string `json:"message" xml:"message"`
	ParentFileId *string `json:"parent_file_id" xml:"parent_file_id" require:"true" maxLength:"50" pattern:"[a-z0-9]{1, 50}"`
	PreHash      *string `json:"pre_hash" xml:"pre_hash"`
}

func (s PreHashCheckSuccessResponse) String() string {
	return tea.Prettify(s)
}

func (s PreHashCheckSuccessResponse) GoString() string {
	return s.String()
}

func (s *PreHashCheckSuccessResponse) SetRequestId(v string) *PreHashCheckSuccessResponse {
	s.RequestId = &v
	return s
}

func (s *PreHashCheckSuccessResponse) SetCode(v string) *PreHashCheckSuccessResponse {
	s.Code = &v
	return s
}

func (s *PreHashCheckSuccessResponse) SetFileName(v string) *PreHashCheckSuccessResponse {
	s.FileName = &v
	return s
}

func (s *PreHashCheckSuccessResponse) SetMessage(v string) *PreHashCheckSuccessResponse {
	s.Message = &v
	return s
}

func (s *PreHashCheckSuccessResponse) SetParentFileId(v string) *PreHashCheckSuccessResponse {
	s.ParentFileId = &v
	return s
}

func (s *PreHashCheckSuccessResponse) SetPreHash(v string) *PreHashCheckSuccessResponse {
	s.PreHash = &v
	return s
}

type RemoveStoreRequest struct {
	Header   *RemoveStoreRequestHeader `json:"header" xml:"header" type:"Struct"`
	DomainId *string                   `json:"domain_id" xml:"domain_id" require:"true"`
	StoreId  *string                   `json:"store_id" xml:"store_id" require:"true"`
}

func (s RemoveStoreRequest) String() string {
	return tea.Prettify(s)
}

func (s RemoveStoreRequest) GoString() string {
	return s.String()
}

func (s *RemoveStoreRequest) SetHeader(v *RemoveStoreRequestHeader) *RemoveStoreRequest {
	s.Header = v
	return s
}

func (s *RemoveStoreRequest) SetDomainId(v string) *RemoveStoreRequest {
	s.DomainId = &v
	return s
}

func (s *RemoveStoreRequest) SetStoreId(v string) *RemoveStoreRequest {
	s.StoreId = &v
	return s
}

type RemoveStoreRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s RemoveStoreRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s RemoveStoreRequestHeader) GoString() string {
	return s.String()
}

func (s *RemoveStoreRequestHeader) SetTraceId(v string) *RemoveStoreRequestHeader {
	s.TraceId = &v
	return s
}

func (s *RemoveStoreRequestHeader) SetDeviceId(v string) *RemoveStoreRequestHeader {
	s.DeviceId = &v
	return s
}

type SetStoreCorsRequest struct {
	Header   *SetStoreCorsRequestHeader `json:"header" xml:"header" type:"Struct"`
	CorsRule *CorsRule                  `json:"cors_rule" xml:"cors_rule" require:"true"`
	DomainId *string                    `json:"domain_id" xml:"domain_id" require:"true"`
	StoreId  *string                    `json:"store_id" xml:"store_id" require:"true"`
}

func (s SetStoreCorsRequest) String() string {
	return tea.Prettify(s)
}

func (s SetStoreCorsRequest) GoString() string {
	return s.String()
}

func (s *SetStoreCorsRequest) SetHeader(v *SetStoreCorsRequestHeader) *SetStoreCorsRequest {
	s.Header = v
	return s
}

func (s *SetStoreCorsRequest) SetCorsRule(v *CorsRule) *SetStoreCorsRequest {
	s.CorsRule = v
	return s
}

func (s *SetStoreCorsRequest) SetDomainId(v string) *SetStoreCorsRequest {
	s.DomainId = &v
	return s
}

func (s *SetStoreCorsRequest) SetStoreId(v string) *SetStoreCorsRequest {
	s.StoreId = &v
	return s
}

type SetStoreCorsRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s SetStoreCorsRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s SetStoreCorsRequestHeader) GoString() string {
	return s.String()
}

func (s *SetStoreCorsRequestHeader) SetTraceId(v string) *SetStoreCorsRequestHeader {
	s.TraceId = &v
	return s
}

func (s *SetStoreCorsRequestHeader) SetDeviceId(v string) *SetStoreCorsRequestHeader {
	s.DeviceId = &v
	return s
}

type StoreFile struct {
	DomainId       *string `json:"domain_id" xml:"domain_id"`
	Name           *string `json:"name" xml:"name"`
	ParentFilePath *string `json:"parent_file_path" xml:"parent_file_path"`
	StoreId        *string `json:"store_id" xml:"store_id"`
	Type           *string `json:"type" xml:"type"`
}

func (s StoreFile) String() string {
	return tea.Prettify(s)
}

func (s StoreFile) GoString() string {
	return s.String()
}

func (s *StoreFile) SetDomainId(v string) *StoreFile {
	s.DomainId = &v
	return s
}

func (s *StoreFile) SetName(v string) *StoreFile {
	s.Name = &v
	return s
}

func (s *StoreFile) SetParentFilePath(v string) *StoreFile {
	s.ParentFilePath = &v
	return s
}

func (s *StoreFile) SetStoreId(v string) *StoreFile {
	s.StoreId = &v
	return s
}

func (s *StoreFile) SetType(v string) *StoreFile {
	s.Type = &v
	return s
}

type StoreItemResponse struct {
	RequestId          *string `json:"requestId" xml:"requestId"`
	AccelerateEndpoint *string `json:"accelerate_endpoint" xml:"accelerate_endpoint"`
	BasePath           *string `json:"base_path" xml:"base_path"`
	Bucket             *string `json:"bucket" xml:"bucket" require:"true"`
	CustomizedEndpoint *string `json:"customized_endpoint" xml:"customized_endpoint"`
	DomainId           *string `json:"domain_id" xml:"domain_id"`
	Endpoint           *string `json:"endpoint" xml:"endpoint" require:"true"`
	InternalEndpoint   *string `json:"internal_endpoint" xml:"internal_endpoint"`
	Ownership          *string `json:"ownership" xml:"ownership" require:"true"`
	Policy             *string `json:"policy" xml:"policy" require:"true"`
	RoleArn            *string `json:"role_arn" xml:"role_arn"`
	StoreId            *string `json:"store_id" xml:"store_id" require:"true"`
	Type               *string `json:"type" xml:"type" require:"true"`
}

func (s StoreItemResponse) String() string {
	return tea.Prettify(s)
}

func (s StoreItemResponse) GoString() string {
	return s.String()
}

func (s *StoreItemResponse) SetRequestId(v string) *StoreItemResponse {
	s.RequestId = &v
	return s
}

func (s *StoreItemResponse) SetAccelerateEndpoint(v string) *StoreItemResponse {
	s.AccelerateEndpoint = &v
	return s
}

func (s *StoreItemResponse) SetBasePath(v string) *StoreItemResponse {
	s.BasePath = &v
	return s
}

func (s *StoreItemResponse) SetBucket(v string) *StoreItemResponse {
	s.Bucket = &v
	return s
}

func (s *StoreItemResponse) SetCustomizedEndpoint(v string) *StoreItemResponse {
	s.CustomizedEndpoint = &v
	return s
}

func (s *StoreItemResponse) SetDomainId(v string) *StoreItemResponse {
	s.DomainId = &v
	return s
}

func (s *StoreItemResponse) SetEndpoint(v string) *StoreItemResponse {
	s.Endpoint = &v
	return s
}

func (s *StoreItemResponse) SetInternalEndpoint(v string) *StoreItemResponse {
	s.InternalEndpoint = &v
	return s
}

func (s *StoreItemResponse) SetOwnership(v string) *StoreItemResponse {
	s.Ownership = &v
	return s
}

func (s *StoreItemResponse) SetPolicy(v string) *StoreItemResponse {
	s.Policy = &v
	return s
}

func (s *StoreItemResponse) SetRoleArn(v string) *StoreItemResponse {
	s.RoleArn = &v
	return s
}

func (s *StoreItemResponse) SetStoreId(v string) *StoreItemResponse {
	s.StoreId = &v
	return s
}

func (s *StoreItemResponse) SetType(v string) *StoreItemResponse {
	s.Type = &v
	return s
}

type TokenRequest struct {
	Header       *TokenRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId        *string             `json:"app_id" xml:"app_id" require:"true"`
	GrantType    *string             `json:"grant_type" xml:"grant_type" require:"true"`
	RefreshToken *string             `json:"refresh_token" xml:"refresh_token" require:"true"`
}

func (s TokenRequest) String() string {
	return tea.Prettify(s)
}

func (s TokenRequest) GoString() string {
	return s.String()
}

func (s *TokenRequest) SetHeader(v *TokenRequestHeader) *TokenRequest {
	s.Header = v
	return s
}

func (s *TokenRequest) SetAppId(v string) *TokenRequest {
	s.AppId = &v
	return s
}

func (s *TokenRequest) SetGrantType(v string) *TokenRequest {
	s.GrantType = &v
	return s
}

func (s *TokenRequest) SetRefreshToken(v string) *TokenRequest {
	s.RefreshToken = &v
	return s
}

type TokenRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s TokenRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s TokenRequestHeader) GoString() string {
	return s.String()
}

func (s *TokenRequestHeader) SetTraceId(v string) *TokenRequestHeader {
	s.TraceId = &v
	return s
}

func (s *TokenRequestHeader) SetDeviceId(v string) *TokenRequestHeader {
	s.DeviceId = &v
	return s
}

type UpdateAppRequest struct {
	Header       *UpdateAppRequestHeader `json:"header" xml:"header" type:"Struct"`
	AppId        *string                 `json:"app_id" xml:"app_id" require:"true"`
	AppName      *string                 `json:"app_name" xml:"app_name" require:"true" maxLength:"128" pattern:"[0-9a-zA-Z]+"`
	Description  *string                 `json:"description" xml:"description" maxLength:"128"`
	IsThirdParty *bool                   `json:"is_third_party" xml:"is_third_party" require:"true"`
	Logo         *string                 `json:"logo" xml:"logo" require:"true"`
	RedirectUri  *string                 `json:"redirect_uri" xml:"redirect_uri" require:"true"`
	Scope        []*string               `json:"scope" xml:"scope" require:"true" type:"Repeated"`
	Type         *string                 `json:"type" xml:"type" require:"true"`
}

func (s UpdateAppRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateAppRequest) GoString() string {
	return s.String()
}

func (s *UpdateAppRequest) SetHeader(v *UpdateAppRequestHeader) *UpdateAppRequest {
	s.Header = v
	return s
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

func (s *UpdateAppRequest) SetIsThirdParty(v bool) *UpdateAppRequest {
	s.IsThirdParty = &v
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

type UpdateAppRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s UpdateAppRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UpdateAppRequestHeader) GoString() string {
	return s.String()
}

func (s *UpdateAppRequestHeader) SetTraceId(v string) *UpdateAppRequestHeader {
	s.TraceId = &v
	return s
}

func (s *UpdateAppRequestHeader) SetDeviceId(v string) *UpdateAppRequestHeader {
	s.DeviceId = &v
	return s
}

type UpdateDomainRequest struct {
	Header                     *UpdateDomainRequestHeader `json:"header" xml:"header" type:"Struct"`
	AuthAlipayAppId            *string                    `json:"auth_alipay_app_id" xml:"auth_alipay_app_id"`
	AuthAlipayEnbale           *bool                      `json:"auth_alipay_enbale" xml:"auth_alipay_enbale"`
	AuthAlipayPrivateKey       *string                    `json:"auth_alipay_private_key" xml:"auth_alipay_private_key"`
	AuthConfig                 map[string]interface{}     `json:"auth_config" xml:"auth_config"`
	AuthDingdingAppId          *string                    `json:"auth_dingding_app_id" xml:"auth_dingding_app_id"`
	AuthDingdingAppSecret      *string                    `json:"auth_dingding_app_secret" xml:"auth_dingding_app_secret"`
	AuthDingdingEnable         *bool                      `json:"auth_dingding_enable" xml:"auth_dingding_enable"`
	AuthEndpointEnable         *bool                      `json:"auth_endpoint_enable" xml:"auth_endpoint_enable"`
	AuthRamAppId               *string                    `json:"auth_ram_app_id" xml:"auth_ram_app_id"`
	AuthRamAppSecret           *string                    `json:"auth_ram_app_secret" xml:"auth_ram_app_secret"`
	AuthRamEnable              *bool                      `json:"auth_ram_enable" xml:"auth_ram_enable"`
	DataHashName               *string                    `json:"data_hash_name" xml:"data_hash_name"`
	Description                *string                    `json:"description" xml:"description"`
	DomainId                   *string                    `json:"domain_id" xml:"domain_id" require:"true"`
	DomainName                 *string                    `json:"domain_name" xml:"domain_name"`
	EventFilenameMatches       *string                    `json:"event_filename_matches" xml:"event_filename_matches"`
	EventMnsEndpoint           *string                    `json:"event_mns_endpoint" xml:"event_mns_endpoint"`
	EventMnsTopic              *string                    `json:"event_mns_topic" xml:"event_mns_topic"`
	EventNames                 []*string                  `json:"event_names" xml:"event_names" type:"Repeated"`
	EventRoleArn               *string                    `json:"event_role_arn" xml:"event_role_arn"`
	InitDriveEnable            *bool                      `json:"init_drive_enable" xml:"init_drive_enable"`
	InitDriveSize              *int64                     `json:"init_drive_size" xml:"init_drive_size"`
	InitDriveStoreId           *string                    `json:"init_drive_store_id" xml:"init_drive_store_id"`
	PublishedAppAccessStrategy *AppAccessStrategy         `json:"published_app_access_strategy" xml:"published_app_access_strategy"`
	Sharable                   *bool                      `json:"sharable" xml:"sharable"`
}

func (s UpdateDomainRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateDomainRequest) GoString() string {
	return s.String()
}

func (s *UpdateDomainRequest) SetHeader(v *UpdateDomainRequestHeader) *UpdateDomainRequest {
	s.Header = v
	return s
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

type UpdateDomainRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s UpdateDomainRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UpdateDomainRequestHeader) GoString() string {
	return s.String()
}

func (s *UpdateDomainRequestHeader) SetTraceId(v string) *UpdateDomainRequestHeader {
	s.TraceId = &v
	return s
}

func (s *UpdateDomainRequestHeader) SetDeviceId(v string) *UpdateDomainRequestHeader {
	s.DeviceId = &v
	return s
}

type UpdateDriveResponse struct {
	RequestId    *string `json:"requestId" xml:"requestId"`
	Creator      *string `json:"creator" xml:"creator"`
	Description  *string `json:"description" xml:"description"`
	DomainId     *string `json:"domain_id" xml:"domain_id"`
	DriveId      *string `json:"drive_id" xml:"drive_id"`
	DriveName    *string `json:"drive_name" xml:"drive_name"`
	DriveType    *string `json:"drive_type" xml:"drive_type"`
	Owner        *string `json:"owner" xml:"owner"`
	RelativePath *string `json:"relative_path" xml:"relative_path"`
	Status       *string `json:"status" xml:"status"`
	StoreId      *string `json:"store_id" xml:"store_id"`
	TotalSize    *int64  `json:"total_size" xml:"total_size"`
	UsedSize     *int64  `json:"used_size" xml:"used_size"`
}

func (s UpdateDriveResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateDriveResponse) GoString() string {
	return s.String()
}

func (s *UpdateDriveResponse) SetRequestId(v string) *UpdateDriveResponse {
	s.RequestId = &v
	return s
}

func (s *UpdateDriveResponse) SetCreator(v string) *UpdateDriveResponse {
	s.Creator = &v
	return s
}

func (s *UpdateDriveResponse) SetDescription(v string) *UpdateDriveResponse {
	s.Description = &v
	return s
}

func (s *UpdateDriveResponse) SetDomainId(v string) *UpdateDriveResponse {
	s.DomainId = &v
	return s
}

func (s *UpdateDriveResponse) SetDriveId(v string) *UpdateDriveResponse {
	s.DriveId = &v
	return s
}

func (s *UpdateDriveResponse) SetDriveName(v string) *UpdateDriveResponse {
	s.DriveName = &v
	return s
}

func (s *UpdateDriveResponse) SetDriveType(v string) *UpdateDriveResponse {
	s.DriveType = &v
	return s
}

func (s *UpdateDriveResponse) SetOwner(v string) *UpdateDriveResponse {
	s.Owner = &v
	return s
}

func (s *UpdateDriveResponse) SetRelativePath(v string) *UpdateDriveResponse {
	s.RelativePath = &v
	return s
}

func (s *UpdateDriveResponse) SetStatus(v string) *UpdateDriveResponse {
	s.Status = &v
	return s
}

func (s *UpdateDriveResponse) SetStoreId(v string) *UpdateDriveResponse {
	s.StoreId = &v
	return s
}

func (s *UpdateDriveResponse) SetTotalSize(v int64) *UpdateDriveResponse {
	s.TotalSize = &v
	return s
}

func (s *UpdateDriveResponse) SetUsedSize(v int64) *UpdateDriveResponse {
	s.UsedSize = &v
	return s
}

type UpdateShareResponse struct {
	RequestId     *string   `json:"requestId" xml:"requestId"`
	CreatedAt     *string   `json:"created_at" xml:"created_at"`
	Creator       *string   `json:"creator" xml:"creator"`
	Description   *string   `json:"description" xml:"description"`
	DomainId      *string   `json:"domain_id" xml:"domain_id"`
	DriveId       *string   `json:"drive_id" xml:"drive_id"`
	Expiration    *string   `json:"expiration" xml:"expiration"`
	Expired       *bool     `json:"expired" xml:"expired"`
	Owner         *string   `json:"owner" xml:"owner"`
	Permissions   []*string `json:"permissions" xml:"permissions" type:"Repeated"`
	ShareFilePath *string   `json:"share_file_path" xml:"share_file_path"`
	ShareId       *string   `json:"share_id" xml:"share_id"`
	ShareName     *string   `json:"share_name" xml:"share_name"`
	Status        *string   `json:"status" xml:"status"`
	UpdatedAt     *string   `json:"updated_at" xml:"updated_at"`
}

func (s UpdateShareResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateShareResponse) GoString() string {
	return s.String()
}

func (s *UpdateShareResponse) SetRequestId(v string) *UpdateShareResponse {
	s.RequestId = &v
	return s
}

func (s *UpdateShareResponse) SetCreatedAt(v string) *UpdateShareResponse {
	s.CreatedAt = &v
	return s
}

func (s *UpdateShareResponse) SetCreator(v string) *UpdateShareResponse {
	s.Creator = &v
	return s
}

func (s *UpdateShareResponse) SetDescription(v string) *UpdateShareResponse {
	s.Description = &v
	return s
}

func (s *UpdateShareResponse) SetDomainId(v string) *UpdateShareResponse {
	s.DomainId = &v
	return s
}

func (s *UpdateShareResponse) SetDriveId(v string) *UpdateShareResponse {
	s.DriveId = &v
	return s
}

func (s *UpdateShareResponse) SetExpiration(v string) *UpdateShareResponse {
	s.Expiration = &v
	return s
}

func (s *UpdateShareResponse) SetExpired(v bool) *UpdateShareResponse {
	s.Expired = &v
	return s
}

func (s *UpdateShareResponse) SetOwner(v string) *UpdateShareResponse {
	s.Owner = &v
	return s
}

func (s *UpdateShareResponse) SetPermissions(v []*string) *UpdateShareResponse {
	s.Permissions = v
	return s
}

func (s *UpdateShareResponse) SetShareFilePath(v string) *UpdateShareResponse {
	s.ShareFilePath = &v
	return s
}

func (s *UpdateShareResponse) SetShareId(v string) *UpdateShareResponse {
	s.ShareId = &v
	return s
}

func (s *UpdateShareResponse) SetShareName(v string) *UpdateShareResponse {
	s.ShareName = &v
	return s
}

func (s *UpdateShareResponse) SetStatus(v string) *UpdateShareResponse {
	s.Status = &v
	return s
}

func (s *UpdateShareResponse) SetUpdatedAt(v string) *UpdateShareResponse {
	s.UpdatedAt = &v
	return s
}

type UploadPartInfo struct {
	Etag       *string `json:"etag" xml:"etag"`
	PartNumber *int64  `json:"part_number" xml:"part_number" pattern:"[0-9]+"`
	PartSize   *int64  `json:"part_size" xml:"part_size"`
	UploadUrl  *string `json:"upload_url" xml:"upload_url"`
}

func (s UploadPartInfo) String() string {
	return tea.Prettify(s)
}

func (s UploadPartInfo) GoString() string {
	return s.String()
}

func (s *UploadPartInfo) SetEtag(v string) *UploadPartInfo {
	s.Etag = &v
	return s
}

func (s *UploadPartInfo) SetPartNumber(v int64) *UploadPartInfo {
	s.PartNumber = &v
	return s
}

func (s *UploadPartInfo) SetPartSize(v int64) *UploadPartInfo {
	s.PartSize = &v
	return s
}

func (s *UploadPartInfo) SetUploadUrl(v string) *UploadPartInfo {
	s.UploadUrl = &v
	return s
}

type UserAuthentication struct {
	AuthenticationType *string `json:"AuthenticationType" xml:"AuthenticationType" require:"true"`
	CreatedAt          *int64  `json:"CreatedAt" xml:"CreatedAt" require:"true"`
	Detail             *string `json:"Detail" xml:"Detail" require:"true"`
	DomainID           *string `json:"DomainID" xml:"DomainID" require:"true"`
	Identity           *string `json:"Identity" xml:"Identity" require:"true"`
	LastLoginTime      *int64  `json:"LastLoginTime" xml:"LastLoginTime" require:"true"`
	Status             *string `json:"Status" xml:"Status" require:"true"`
	UserID             *string `json:"UserID" xml:"UserID" require:"true"`
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

type AccessTokenResponse struct {
	RequestId    *string `json:"requestId" xml:"requestId"`
	AccessToken  *string `json:"access_token" xml:"access_token" require:"true"`
	ExpireTime   *string `json:"expire_time" xml:"expire_time"`
	RefreshToken *string `json:"refresh_token" xml:"refresh_token"`
	Role         *string `json:"role" xml:"role"`
	TokenType    *string `json:"token_type" xml:"token_type"`
	UserId       *string `json:"user_id" xml:"user_id"`
}

func (s AccessTokenResponse) String() string {
	return tea.Prettify(s)
}

func (s AccessTokenResponse) GoString() string {
	return s.String()
}

func (s *AccessTokenResponse) SetRequestId(v string) *AccessTokenResponse {
	s.RequestId = &v
	return s
}

func (s *AccessTokenResponse) SetAccessToken(v string) *AccessTokenResponse {
	s.AccessToken = &v
	return s
}

func (s *AccessTokenResponse) SetExpireTime(v string) *AccessTokenResponse {
	s.ExpireTime = &v
	return s
}

func (s *AccessTokenResponse) SetRefreshToken(v string) *AccessTokenResponse {
	s.RefreshToken = &v
	return s
}

func (s *AccessTokenResponse) SetRole(v string) *AccessTokenResponse {
	s.Role = &v
	return s
}

func (s *AccessTokenResponse) SetTokenType(v string) *AccessTokenResponse {
	s.TokenType = &v
	return s
}

func (s *AccessTokenResponse) SetUserId(v string) *AccessTokenResponse {
	s.UserId = &v
	return s
}

type AddStoreResponse struct {
	RequestId          *string `json:"requestId" xml:"requestId"`
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

func (s *AddStoreResponse) SetRequestId(v string) *AddStoreResponse {
	s.RequestId = &v
	return s
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

type AdminListStoresRequest struct {
	Header *AdminListStoresRequestHeader `json:"header" xml:"header" type:"Struct"`
}

func (s AdminListStoresRequest) String() string {
	return tea.Prettify(s)
}

func (s AdminListStoresRequest) GoString() string {
	return s.String()
}

func (s *AdminListStoresRequest) SetHeader(v *AdminListStoresRequestHeader) *AdminListStoresRequest {
	s.Header = v
	return s
}

type AdminListStoresRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s AdminListStoresRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s AdminListStoresRequestHeader) GoString() string {
	return s.String()
}

func (s *AdminListStoresRequestHeader) SetTraceId(v string) *AdminListStoresRequestHeader {
	s.TraceId = &v
	return s
}

func (s *AdminListStoresRequestHeader) SetDeviceId(v string) *AdminListStoresRequestHeader {
	s.DeviceId = &v
	return s
}

type BaseDomainResponse struct {
	RequestId                  *string                `json:"requestId" xml:"requestId"`
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

func (s *BaseDomainResponse) SetRequestId(v string) *BaseDomainResponse {
	s.RequestId = &v
	return s
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

type CreateDomainResponse struct {
	RequestId                  *string                `json:"requestId" xml:"requestId"`
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

func (s *CreateDomainResponse) SetRequestId(v string) *CreateDomainResponse {
	s.RequestId = &v
	return s
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

type GetAppResponse struct {
	RequestId   *string   `json:"requestId" xml:"requestId"`
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

func (s *GetAppResponse) SetRequestId(v string) *GetAppResponse {
	s.RequestId = &v
	return s
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

type GetDomainResponse struct {
	RequestId                  *string                `json:"requestId" xml:"requestId"`
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

func (s *GetDomainResponse) SetRequestId(v string) *GetDomainResponse {
	s.RequestId = &v
	return s
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

type GetUserAccessTokenRequest struct {
	Header *GetUserAccessTokenRequestHeader `json:"header" xml:"header" type:"Struct"`
	Role   *string                          `json:"role" xml:"role"`
	UserId *string                          `json:"user_id" xml:"user_id" require:"true"`
}

func (s GetUserAccessTokenRequest) String() string {
	return tea.Prettify(s)
}

func (s GetUserAccessTokenRequest) GoString() string {
	return s.String()
}

func (s *GetUserAccessTokenRequest) SetHeader(v *GetUserAccessTokenRequestHeader) *GetUserAccessTokenRequest {
	s.Header = v
	return s
}

func (s *GetUserAccessTokenRequest) SetRole(v string) *GetUserAccessTokenRequest {
	s.Role = &v
	return s
}

func (s *GetUserAccessTokenRequest) SetUserId(v string) *GetUserAccessTokenRequest {
	s.UserId = &v
	return s
}

type GetUserAccessTokenRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetUserAccessTokenRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetUserAccessTokenRequestHeader) GoString() string {
	return s.String()
}

func (s *GetUserAccessTokenRequestHeader) SetTraceId(v string) *GetUserAccessTokenRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetUserAccessTokenRequestHeader) SetDeviceId(v string) *GetUserAccessTokenRequestHeader {
	s.DeviceId = &v
	return s
}

type ListAppsResponse struct {
	RequestId  *string           `json:"requestId" xml:"requestId"`
	Items      []*GetAppResponse `json:"items" xml:"items" require:"true" type:"Repeated"`
	NextMarker *string           `json:"next_marker" xml:"next_marker"`
}

func (s ListAppsResponse) String() string {
	return tea.Prettify(s)
}

func (s ListAppsResponse) GoString() string {
	return s.String()
}

func (s *ListAppsResponse) SetRequestId(v string) *ListAppsResponse {
	s.RequestId = &v
	return s
}

func (s *ListAppsResponse) SetItems(v []*GetAppResponse) *ListAppsResponse {
	s.Items = v
	return s
}

func (s *ListAppsResponse) SetNextMarker(v string) *ListAppsResponse {
	s.NextMarker = &v
	return s
}

type ListDomainsResponse struct {
	RequestId  *string               `json:"requestId" xml:"requestId"`
	Items      []*BaseDomainResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string               `json:"next_marker" xml:"next_marker"`
}

func (s ListDomainsResponse) String() string {
	return tea.Prettify(s)
}

func (s ListDomainsResponse) GoString() string {
	return s.String()
}

func (s *ListDomainsResponse) SetRequestId(v string) *ListDomainsResponse {
	s.RequestId = &v
	return s
}

func (s *ListDomainsResponse) SetItems(v []*BaseDomainResponse) *ListDomainsResponse {
	s.Items = v
	return s
}

func (s *ListDomainsResponse) SetNextMarker(v string) *ListDomainsResponse {
	s.NextMarker = &v
	return s
}

type ListStoresResponse struct {
	RequestId *string  `json:"requestId" xml:"requestId"`
	Items     []*Store `json:"items" xml:"items" require:"true" type:"Repeated"`
}

func (s ListStoresResponse) String() string {
	return tea.Prettify(s)
}

func (s ListStoresResponse) GoString() string {
	return s.String()
}

func (s *ListStoresResponse) SetRequestId(v string) *ListStoresResponse {
	s.RequestId = &v
	return s
}

func (s *ListStoresResponse) SetItems(v []*Store) *ListStoresResponse {
	s.Items = v
	return s
}

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

type UpdateDomainResponse struct {
	RequestId                  *string                `json:"requestId" xml:"requestId"`
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

func (s *UpdateDomainResponse) SetRequestId(v string) *UpdateDomainResponse {
	s.RequestId = &v
	return s
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

type BaseCompleteFileRequest struct {
	Header       *BaseCompleteFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId      *string                        `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	PartInfoList []*UploadPartInfo              `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	UploadId     *string                        `json:"upload_id" xml:"upload_id"`
}

func (s BaseCompleteFileRequest) String() string {
	return tea.Prettify(s)
}

func (s BaseCompleteFileRequest) GoString() string {
	return s.String()
}

func (s *BaseCompleteFileRequest) SetHeader(v *BaseCompleteFileRequestHeader) *BaseCompleteFileRequest {
	s.Header = v
	return s
}

func (s *BaseCompleteFileRequest) SetDriveId(v string) *BaseCompleteFileRequest {
	s.DriveId = &v
	return s
}

func (s *BaseCompleteFileRequest) SetPartInfoList(v []*UploadPartInfo) *BaseCompleteFileRequest {
	s.PartInfoList = v
	return s
}

func (s *BaseCompleteFileRequest) SetUploadId(v string) *BaseCompleteFileRequest {
	s.UploadId = &v
	return s
}

type BaseCompleteFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s BaseCompleteFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s BaseCompleteFileRequestHeader) GoString() string {
	return s.String()
}

func (s *BaseCompleteFileRequestHeader) SetTraceId(v string) *BaseCompleteFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *BaseCompleteFileRequestHeader) SetDeviceId(v string) *BaseCompleteFileRequestHeader {
	s.DeviceId = &v
	return s
}

type BaseCreateFileRequest struct {
	Header       *BaseCreateFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	ContentMd5   *string                      `json:"content_md5" xml:"content_md5" require:"true"`
	ContentType  *string                      `json:"content_type" xml:"content_type" require:"true"`
	Name         *string                      `json:"name" xml:"name" require:"true"`
	PartInfoList []*UploadPartInfo            `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	Size         *int64                       `json:"size" xml:"size" require:"true"`
	Type         *string                      `json:"type" xml:"type" require:"true"`
}

func (s BaseCreateFileRequest) String() string {
	return tea.Prettify(s)
}

func (s BaseCreateFileRequest) GoString() string {
	return s.String()
}

func (s *BaseCreateFileRequest) SetHeader(v *BaseCreateFileRequestHeader) *BaseCreateFileRequest {
	s.Header = v
	return s
}

func (s *BaseCreateFileRequest) SetContentMd5(v string) *BaseCreateFileRequest {
	s.ContentMd5 = &v
	return s
}

func (s *BaseCreateFileRequest) SetContentType(v string) *BaseCreateFileRequest {
	s.ContentType = &v
	return s
}

func (s *BaseCreateFileRequest) SetName(v string) *BaseCreateFileRequest {
	s.Name = &v
	return s
}

func (s *BaseCreateFileRequest) SetPartInfoList(v []*UploadPartInfo) *BaseCreateFileRequest {
	s.PartInfoList = v
	return s
}

func (s *BaseCreateFileRequest) SetSize(v int64) *BaseCreateFileRequest {
	s.Size = &v
	return s
}

func (s *BaseCreateFileRequest) SetType(v string) *BaseCreateFileRequest {
	s.Type = &v
	return s
}

type BaseCreateFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s BaseCreateFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s BaseCreateFileRequestHeader) GoString() string {
	return s.String()
}

func (s *BaseCreateFileRequestHeader) SetTraceId(v string) *BaseCreateFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *BaseCreateFileRequestHeader) SetDeviceId(v string) *BaseCreateFileRequestHeader {
	s.DeviceId = &v
	return s
}

type BaseGetUploadUrlRequest struct {
	Header       *BaseGetUploadUrlRequestHeader `json:"header" xml:"header" type:"Struct"`
	ContentMd5   *string                        `json:"content_md5" xml:"content_md5" maxLength:"32"`
	DriveId      *string                        `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	PartInfoList []*UploadPartInfo              `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	UploadId     *string                        `json:"upload_id" xml:"upload_id" require:"true"`
}

func (s BaseGetUploadUrlRequest) String() string {
	return tea.Prettify(s)
}

func (s BaseGetUploadUrlRequest) GoString() string {
	return s.String()
}

func (s *BaseGetUploadUrlRequest) SetHeader(v *BaseGetUploadUrlRequestHeader) *BaseGetUploadUrlRequest {
	s.Header = v
	return s
}

func (s *BaseGetUploadUrlRequest) SetContentMd5(v string) *BaseGetUploadUrlRequest {
	s.ContentMd5 = &v
	return s
}

func (s *BaseGetUploadUrlRequest) SetDriveId(v string) *BaseGetUploadUrlRequest {
	s.DriveId = &v
	return s
}

func (s *BaseGetUploadUrlRequest) SetPartInfoList(v []*UploadPartInfo) *BaseGetUploadUrlRequest {
	s.PartInfoList = v
	return s
}

func (s *BaseGetUploadUrlRequest) SetUploadId(v string) *BaseGetUploadUrlRequest {
	s.UploadId = &v
	return s
}

type BaseGetUploadUrlRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s BaseGetUploadUrlRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s BaseGetUploadUrlRequestHeader) GoString() string {
	return s.String()
}

func (s *BaseGetUploadUrlRequestHeader) SetTraceId(v string) *BaseGetUploadUrlRequestHeader {
	s.TraceId = &v
	return s
}

func (s *BaseGetUploadUrlRequestHeader) SetDeviceId(v string) *BaseGetUploadUrlRequestHeader {
	s.DeviceId = &v
	return s
}

type BaseListFileRequest struct {
	Header                *BaseListFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId               *string                    `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ImageThumbnailProcess *string                    `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string                    `json:"image_url_process" xml:"image_url_process"`
	Limit                 *int64                     `json:"limit" xml:"limit" pattern:"[0-9]{1,3}"`
	Marker                *string                    `json:"marker" xml:"marker"`
	VideoThumbnailProcess *string                    `json:"video_thumbnail_process" xml:"video_thumbnail_process"`
}

func (s BaseListFileRequest) String() string {
	return tea.Prettify(s)
}

func (s BaseListFileRequest) GoString() string {
	return s.String()
}

func (s *BaseListFileRequest) SetHeader(v *BaseListFileRequestHeader) *BaseListFileRequest {
	s.Header = v
	return s
}

func (s *BaseListFileRequest) SetDriveId(v string) *BaseListFileRequest {
	s.DriveId = &v
	return s
}

func (s *BaseListFileRequest) SetImageThumbnailProcess(v string) *BaseListFileRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *BaseListFileRequest) SetImageUrlProcess(v string) *BaseListFileRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *BaseListFileRequest) SetLimit(v int64) *BaseListFileRequest {
	s.Limit = &v
	return s
}

func (s *BaseListFileRequest) SetMarker(v string) *BaseListFileRequest {
	s.Marker = &v
	return s
}

func (s *BaseListFileRequest) SetVideoThumbnailProcess(v string) *BaseListFileRequest {
	s.VideoThumbnailProcess = &v
	return s
}

type BaseListFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s BaseListFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s BaseListFileRequestHeader) GoString() string {
	return s.String()
}

func (s *BaseListFileRequestHeader) SetTraceId(v string) *BaseListFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *BaseListFileRequestHeader) SetDeviceId(v string) *BaseListFileRequestHeader {
	s.DeviceId = &v
	return s
}

type BaseMediaResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AddressLine *string `json:"address_line" xml:"address_line"`
	City        *string `json:"city" xml:"city"`
	Country     *string `json:"country" xml:"country"`
	District    *string `json:"district" xml:"district"`
	Location    *string `json:"location" xml:"location"`
	Province    *string `json:"province" xml:"province"`
	Time        *string `json:"time" xml:"time"`
	Township    *string `json:"township" xml:"township"`
}

func (s BaseMediaResponse) String() string {
	return tea.Prettify(s)
}

func (s BaseMediaResponse) GoString() string {
	return s.String()
}

func (s *BaseMediaResponse) SetRequestId(v string) *BaseMediaResponse {
	s.RequestId = &v
	return s
}

func (s *BaseMediaResponse) SetAddressLine(v string) *BaseMediaResponse {
	s.AddressLine = &v
	return s
}

func (s *BaseMediaResponse) SetCity(v string) *BaseMediaResponse {
	s.City = &v
	return s
}

func (s *BaseMediaResponse) SetCountry(v string) *BaseMediaResponse {
	s.Country = &v
	return s
}

func (s *BaseMediaResponse) SetDistrict(v string) *BaseMediaResponse {
	s.District = &v
	return s
}

func (s *BaseMediaResponse) SetLocation(v string) *BaseMediaResponse {
	s.Location = &v
	return s
}

func (s *BaseMediaResponse) SetProvince(v string) *BaseMediaResponse {
	s.Province = &v
	return s
}

func (s *BaseMediaResponse) SetTime(v string) *BaseMediaResponse {
	s.Time = &v
	return s
}

func (s *BaseMediaResponse) SetTownship(v string) *BaseMediaResponse {
	s.Township = &v
	return s
}

type BaseMoveFileRequest struct {
	Header    *BaseMoveFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId   *string                    `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	NewName   *string                    `json:"new_name" xml:"new_name" pattern:".{1,1000}"`
	Overwrite *bool                      `json:"overwrite" xml:"overwrite"`
}

func (s BaseMoveFileRequest) String() string {
	return tea.Prettify(s)
}

func (s BaseMoveFileRequest) GoString() string {
	return s.String()
}

func (s *BaseMoveFileRequest) SetHeader(v *BaseMoveFileRequestHeader) *BaseMoveFileRequest {
	s.Header = v
	return s
}

func (s *BaseMoveFileRequest) SetDriveId(v string) *BaseMoveFileRequest {
	s.DriveId = &v
	return s
}

func (s *BaseMoveFileRequest) SetNewName(v string) *BaseMoveFileRequest {
	s.NewName = &v
	return s
}

func (s *BaseMoveFileRequest) SetOverwrite(v bool) *BaseMoveFileRequest {
	s.Overwrite = &v
	return s
}

type BaseMoveFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s BaseMoveFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s BaseMoveFileRequestHeader) GoString() string {
	return s.String()
}

func (s *BaseMoveFileRequestHeader) SetTraceId(v string) *BaseMoveFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *BaseMoveFileRequestHeader) SetDeviceId(v string) *BaseMoveFileRequestHeader {
	s.DeviceId = &v
	return s
}

type BatchSubRequest struct {
	Header  *BatchSubRequestHeader `json:"header" xml:"header" type:"Struct"`
	Body    map[string]interface{} `json:"body" xml:"body"`
	Headers map[string]interface{} `json:"headers" xml:"headers"`
	Id      *string                `json:"id" xml:"id" require:"true"`
	Method  *string                `json:"method" xml:"method" require:"true"`
	Url     *string                `json:"url" xml:"url" require:"true"`
}

func (s BatchSubRequest) String() string {
	return tea.Prettify(s)
}

func (s BatchSubRequest) GoString() string {
	return s.String()
}

func (s *BatchSubRequest) SetHeader(v *BatchSubRequestHeader) *BatchSubRequest {
	s.Header = v
	return s
}

func (s *BatchSubRequest) SetBody(v map[string]interface{}) *BatchSubRequest {
	s.Body = v
	return s
}

func (s *BatchSubRequest) SetHeaders(v map[string]interface{}) *BatchSubRequest {
	s.Headers = v
	return s
}

func (s *BatchSubRequest) SetId(v string) *BatchSubRequest {
	s.Id = &v
	return s
}

func (s *BatchSubRequest) SetMethod(v string) *BatchSubRequest {
	s.Method = &v
	return s
}

func (s *BatchSubRequest) SetUrl(v string) *BatchSubRequest {
	s.Url = &v
	return s
}

type BatchSubRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s BatchSubRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s BatchSubRequestHeader) GoString() string {
	return s.String()
}

func (s *BatchSubRequestHeader) SetTraceId(v string) *BatchSubRequestHeader {
	s.TraceId = &v
	return s
}

func (s *BatchSubRequestHeader) SetDeviceId(v string) *BatchSubRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPBatchRequest struct {
	Header   *CCPBatchRequestHeader `json:"header" xml:"header" type:"Struct"`
	Requests []*BatchSubRequest     `json:"requests" xml:"requests" require:"true" type:"Repeated"`
	Resource *string                `json:"resource" xml:"resource" require:"true"`
}

func (s CCPBatchRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPBatchRequest) GoString() string {
	return s.String()
}

func (s *CCPBatchRequest) SetHeader(v *CCPBatchRequestHeader) *CCPBatchRequest {
	s.Header = v
	return s
}

func (s *CCPBatchRequest) SetRequests(v []*BatchSubRequest) *CCPBatchRequest {
	s.Requests = v
	return s
}

func (s *CCPBatchRequest) SetResource(v string) *CCPBatchRequest {
	s.Resource = &v
	return s
}

type CCPBatchRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPBatchRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPBatchRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPBatchRequestHeader) SetTraceId(v string) *CCPBatchRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPBatchRequestHeader) SetDeviceId(v string) *CCPBatchRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPCompleteFileRequest struct {
	Header       *CCPCompleteFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId      *string                       `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	PartInfoList []*UploadPartInfo             `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	UploadId     *string                       `json:"upload_id" xml:"upload_id"`
	FileId       *string                       `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1,50}"`
}

func (s CCPCompleteFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPCompleteFileRequest) GoString() string {
	return s.String()
}

func (s *CCPCompleteFileRequest) SetHeader(v *CCPCompleteFileRequestHeader) *CCPCompleteFileRequest {
	s.Header = v
	return s
}

func (s *CCPCompleteFileRequest) SetDriveId(v string) *CCPCompleteFileRequest {
	s.DriveId = &v
	return s
}

func (s *CCPCompleteFileRequest) SetPartInfoList(v []*UploadPartInfo) *CCPCompleteFileRequest {
	s.PartInfoList = v
	return s
}

func (s *CCPCompleteFileRequest) SetUploadId(v string) *CCPCompleteFileRequest {
	s.UploadId = &v
	return s
}

func (s *CCPCompleteFileRequest) SetFileId(v string) *CCPCompleteFileRequest {
	s.FileId = &v
	return s
}

type CCPCompleteFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPCompleteFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPCompleteFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPCompleteFileRequestHeader) SetTraceId(v string) *CCPCompleteFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPCompleteFileRequestHeader) SetDeviceId(v string) *CCPCompleteFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPCopyFileRequest struct {
	Header         *CCPCopyFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	AutoRename     *bool                     `json:"auto_rename" xml:"auto_rename"`
	DriveId        *string                   `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId         *string                   `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	NewName        *string                   `json:"new_name" xml:"new_name" pattern:".{1,1000}"`
	ToDriveId      *string                   `json:"to_drive_id" xml:"to_drive_id" pattern:"[0-9]+"`
	ToParentFileId *string                   `json:"to_parent_file_id" xml:"to_parent_file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
}

func (s CCPCopyFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPCopyFileRequest) GoString() string {
	return s.String()
}

func (s *CCPCopyFileRequest) SetHeader(v *CCPCopyFileRequestHeader) *CCPCopyFileRequest {
	s.Header = v
	return s
}

func (s *CCPCopyFileRequest) SetAutoRename(v bool) *CCPCopyFileRequest {
	s.AutoRename = &v
	return s
}

func (s *CCPCopyFileRequest) SetDriveId(v string) *CCPCopyFileRequest {
	s.DriveId = &v
	return s
}

func (s *CCPCopyFileRequest) SetFileId(v string) *CCPCopyFileRequest {
	s.FileId = &v
	return s
}

func (s *CCPCopyFileRequest) SetNewName(v string) *CCPCopyFileRequest {
	s.NewName = &v
	return s
}

func (s *CCPCopyFileRequest) SetToDriveId(v string) *CCPCopyFileRequest {
	s.ToDriveId = &v
	return s
}

func (s *CCPCopyFileRequest) SetToParentFileId(v string) *CCPCopyFileRequest {
	s.ToParentFileId = &v
	return s
}

type CCPCopyFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPCopyFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPCopyFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPCopyFileRequestHeader) SetTraceId(v string) *CCPCopyFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPCopyFileRequestHeader) SetDeviceId(v string) *CCPCopyFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPCreateFileRequest struct {
	Header          *CCPCreateFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	ContentMd5      *string                     `json:"content_md5" xml:"content_md5"`
	ContentType     *string                     `json:"content_type" xml:"content_type"`
	Name            *string                     `json:"name" xml:"name"`
	PartInfoList    []*UploadPartInfo           `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	Size            *int64                      `json:"size" xml:"size"`
	Type            *string                     `json:"type" xml:"type"`
	AutoRename      *bool                       `json:"auto_rename" xml:"auto_rename"`
	ContentHash     *string                     `json:"content_hash" xml:"content_hash"`
	ContentHashName *string                     `json:"content_hash_name" xml:"content_hash_name"`
	Description     *string                     `json:"description" xml:"description" maxLength:"0"`
	DriveId         *string                     `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	EncryptMode     *string                     `json:"encrypt_mode" xml:"encrypt_mode"`
	FileId          *string                     `json:"file_id" xml:"file_id"`
	Hidden          *bool                       `json:"hidden" xml:"hidden"`
	Labels          []*string                   `json:"labels" xml:"labels" type:"Repeated"`
	Meta            *string                     `json:"meta" xml:"meta"`
	ParentFileId    *string                     `json:"parent_file_id" xml:"parent_file_id" maxLength:"50" pattern:"[a-z0-9]{1,50}"`
	PreHash         *string                     `json:"pre_hash" xml:"pre_hash"`
}

func (s CCPCreateFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPCreateFileRequest) GoString() string {
	return s.String()
}

func (s *CCPCreateFileRequest) SetHeader(v *CCPCreateFileRequestHeader) *CCPCreateFileRequest {
	s.Header = v
	return s
}

func (s *CCPCreateFileRequest) SetContentMd5(v string) *CCPCreateFileRequest {
	s.ContentMd5 = &v
	return s
}

func (s *CCPCreateFileRequest) SetContentType(v string) *CCPCreateFileRequest {
	s.ContentType = &v
	return s
}

func (s *CCPCreateFileRequest) SetName(v string) *CCPCreateFileRequest {
	s.Name = &v
	return s
}

func (s *CCPCreateFileRequest) SetPartInfoList(v []*UploadPartInfo) *CCPCreateFileRequest {
	s.PartInfoList = v
	return s
}

func (s *CCPCreateFileRequest) SetSize(v int64) *CCPCreateFileRequest {
	s.Size = &v
	return s
}

func (s *CCPCreateFileRequest) SetType(v string) *CCPCreateFileRequest {
	s.Type = &v
	return s
}

func (s *CCPCreateFileRequest) SetAutoRename(v bool) *CCPCreateFileRequest {
	s.AutoRename = &v
	return s
}

func (s *CCPCreateFileRequest) SetContentHash(v string) *CCPCreateFileRequest {
	s.ContentHash = &v
	return s
}

func (s *CCPCreateFileRequest) SetContentHashName(v string) *CCPCreateFileRequest {
	s.ContentHashName = &v
	return s
}

func (s *CCPCreateFileRequest) SetDescription(v string) *CCPCreateFileRequest {
	s.Description = &v
	return s
}

func (s *CCPCreateFileRequest) SetDriveId(v string) *CCPCreateFileRequest {
	s.DriveId = &v
	return s
}

func (s *CCPCreateFileRequest) SetEncryptMode(v string) *CCPCreateFileRequest {
	s.EncryptMode = &v
	return s
}

func (s *CCPCreateFileRequest) SetFileId(v string) *CCPCreateFileRequest {
	s.FileId = &v
	return s
}

func (s *CCPCreateFileRequest) SetHidden(v bool) *CCPCreateFileRequest {
	s.Hidden = &v
	return s
}

func (s *CCPCreateFileRequest) SetLabels(v []*string) *CCPCreateFileRequest {
	s.Labels = v
	return s
}

func (s *CCPCreateFileRequest) SetMeta(v string) *CCPCreateFileRequest {
	s.Meta = &v
	return s
}

func (s *CCPCreateFileRequest) SetParentFileId(v string) *CCPCreateFileRequest {
	s.ParentFileId = &v
	return s
}

func (s *CCPCreateFileRequest) SetPreHash(v string) *CCPCreateFileRequest {
	s.PreHash = &v
	return s
}

type CCPCreateFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPCreateFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPCreateFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPCreateFileRequestHeader) SetTraceId(v string) *CCPCreateFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPCreateFileRequestHeader) SetDeviceId(v string) *CCPCreateFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPDeleteFileRequest struct {
	Header      *CCPDeleteFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId     *string                     `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId      *string                     `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	Permanently *bool                       `json:"permanently" xml:"permanently"`
}

func (s CCPDeleteFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPDeleteFileRequest) GoString() string {
	return s.String()
}

func (s *CCPDeleteFileRequest) SetHeader(v *CCPDeleteFileRequestHeader) *CCPDeleteFileRequest {
	s.Header = v
	return s
}

func (s *CCPDeleteFileRequest) SetDriveId(v string) *CCPDeleteFileRequest {
	s.DriveId = &v
	return s
}

func (s *CCPDeleteFileRequest) SetFileId(v string) *CCPDeleteFileRequest {
	s.FileId = &v
	return s
}

func (s *CCPDeleteFileRequest) SetPermanently(v bool) *CCPDeleteFileRequest {
	s.Permanently = &v
	return s
}

type CCPDeleteFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPDeleteFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPDeleteFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPDeleteFileRequestHeader) SetTraceId(v string) *CCPDeleteFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPDeleteFileRequestHeader) SetDeviceId(v string) *CCPDeleteFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPDeleteFilesRequest struct {
	Header     *CCPDeleteFilesRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId    *string                      `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileIdList []*string                    `json:"file_id_list" xml:"file_id_list" require:"true" type:"Repeated"`
}

func (s CCPDeleteFilesRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPDeleteFilesRequest) GoString() string {
	return s.String()
}

func (s *CCPDeleteFilesRequest) SetHeader(v *CCPDeleteFilesRequestHeader) *CCPDeleteFilesRequest {
	s.Header = v
	return s
}

func (s *CCPDeleteFilesRequest) SetDriveId(v string) *CCPDeleteFilesRequest {
	s.DriveId = &v
	return s
}

func (s *CCPDeleteFilesRequest) SetFileIdList(v []*string) *CCPDeleteFilesRequest {
	s.FileIdList = v
	return s
}

type CCPDeleteFilesRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPDeleteFilesRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPDeleteFilesRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPDeleteFilesRequestHeader) SetTraceId(v string) *CCPDeleteFilesRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPDeleteFilesRequestHeader) SetDeviceId(v string) *CCPDeleteFilesRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPGetAsyncTaskRequest struct {
	Header      *CCPGetAsyncTaskRequestHeader `json:"header" xml:"header" type:"Struct"`
	AsyncTaskId *string                       `json:"async_task_id" xml:"async_task_id"`
}

func (s CCPGetAsyncTaskRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPGetAsyncTaskRequest) GoString() string {
	return s.String()
}

func (s *CCPGetAsyncTaskRequest) SetHeader(v *CCPGetAsyncTaskRequestHeader) *CCPGetAsyncTaskRequest {
	s.Header = v
	return s
}

func (s *CCPGetAsyncTaskRequest) SetAsyncTaskId(v string) *CCPGetAsyncTaskRequest {
	s.AsyncTaskId = &v
	return s
}

type CCPGetAsyncTaskRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPGetAsyncTaskRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPGetAsyncTaskRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPGetAsyncTaskRequestHeader) SetTraceId(v string) *CCPGetAsyncTaskRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPGetAsyncTaskRequestHeader) SetDeviceId(v string) *CCPGetAsyncTaskRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPGetDownloadUrlRequest struct {
	Header    *CCPGetDownloadUrlRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId   *string                         `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	ExpireSec *int64                          `json:"expire_sec" xml:"expire_sec"`
	FileId    *string                         `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	FileName  *string                         `json:"file_name" xml:"file_name" pattern:".{1,1000}"`
}

func (s CCPGetDownloadUrlRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPGetDownloadUrlRequest) GoString() string {
	return s.String()
}

func (s *CCPGetDownloadUrlRequest) SetHeader(v *CCPGetDownloadUrlRequestHeader) *CCPGetDownloadUrlRequest {
	s.Header = v
	return s
}

func (s *CCPGetDownloadUrlRequest) SetDriveId(v string) *CCPGetDownloadUrlRequest {
	s.DriveId = &v
	return s
}

func (s *CCPGetDownloadUrlRequest) SetExpireSec(v int64) *CCPGetDownloadUrlRequest {
	s.ExpireSec = &v
	return s
}

func (s *CCPGetDownloadUrlRequest) SetFileId(v string) *CCPGetDownloadUrlRequest {
	s.FileId = &v
	return s
}

func (s *CCPGetDownloadUrlRequest) SetFileName(v string) *CCPGetDownloadUrlRequest {
	s.FileName = &v
	return s
}

type CCPGetDownloadUrlRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPGetDownloadUrlRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPGetDownloadUrlRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPGetDownloadUrlRequestHeader) SetTraceId(v string) *CCPGetDownloadUrlRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPGetDownloadUrlRequestHeader) SetDeviceId(v string) *CCPGetDownloadUrlRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPGetFileRequest struct {
	Header                *CCPGetFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId               *string                  `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId                *string                  `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	ImageThumbnailProcess *string                  `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string                  `json:"image_url_process" xml:"image_url_process"`
	UrlExpireSec          *int64                   `json:"url_expire_sec" xml:"url_expire_sec"`
	VideoThumbnailProcess *string                  `json:"video_thumbnail_process" xml:"video_thumbnail_process"`
}

func (s CCPGetFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPGetFileRequest) GoString() string {
	return s.String()
}

func (s *CCPGetFileRequest) SetHeader(v *CCPGetFileRequestHeader) *CCPGetFileRequest {
	s.Header = v
	return s
}

func (s *CCPGetFileRequest) SetDriveId(v string) *CCPGetFileRequest {
	s.DriveId = &v
	return s
}

func (s *CCPGetFileRequest) SetFileId(v string) *CCPGetFileRequest {
	s.FileId = &v
	return s
}

func (s *CCPGetFileRequest) SetImageThumbnailProcess(v string) *CCPGetFileRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *CCPGetFileRequest) SetImageUrlProcess(v string) *CCPGetFileRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *CCPGetFileRequest) SetUrlExpireSec(v int64) *CCPGetFileRequest {
	s.UrlExpireSec = &v
	return s
}

func (s *CCPGetFileRequest) SetVideoThumbnailProcess(v string) *CCPGetFileRequest {
	s.VideoThumbnailProcess = &v
	return s
}

type CCPGetFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPGetFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPGetFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPGetFileRequestHeader) SetTraceId(v string) *CCPGetFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPGetFileRequestHeader) SetDeviceId(v string) *CCPGetFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPGetUploadUrlRequest struct {
	Header       *CCPGetUploadUrlRequestHeader `json:"header" xml:"header" type:"Struct"`
	ContentMd5   *string                       `json:"content_md5" xml:"content_md5" maxLength:"32"`
	DriveId      *string                       `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	PartInfoList []*UploadPartInfo             `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	UploadId     *string                       `json:"upload_id" xml:"upload_id"`
	FileId       *string                       `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9]{1,50}"`
}

func (s CCPGetUploadUrlRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPGetUploadUrlRequest) GoString() string {
	return s.String()
}

func (s *CCPGetUploadUrlRequest) SetHeader(v *CCPGetUploadUrlRequestHeader) *CCPGetUploadUrlRequest {
	s.Header = v
	return s
}

func (s *CCPGetUploadUrlRequest) SetContentMd5(v string) *CCPGetUploadUrlRequest {
	s.ContentMd5 = &v
	return s
}

func (s *CCPGetUploadUrlRequest) SetDriveId(v string) *CCPGetUploadUrlRequest {
	s.DriveId = &v
	return s
}

func (s *CCPGetUploadUrlRequest) SetPartInfoList(v []*UploadPartInfo) *CCPGetUploadUrlRequest {
	s.PartInfoList = v
	return s
}

func (s *CCPGetUploadUrlRequest) SetUploadId(v string) *CCPGetUploadUrlRequest {
	s.UploadId = &v
	return s
}

func (s *CCPGetUploadUrlRequest) SetFileId(v string) *CCPGetUploadUrlRequest {
	s.FileId = &v
	return s
}

type CCPGetUploadUrlRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPGetUploadUrlRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPGetUploadUrlRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPGetUploadUrlRequestHeader) SetTraceId(v string) *CCPGetUploadUrlRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPGetUploadUrlRequestHeader) SetDeviceId(v string) *CCPGetUploadUrlRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPListFileByCustomIndexKeyRequest struct {
	Header                *CCPListFileByCustomIndexKeyRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId               *string                                   `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ImageThumbnailProcess *string                                   `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string                                   `json:"image_url_process" xml:"image_url_process"`
	Limit                 *int64                                    `json:"limit" xml:"limit" pattern:"[0-9]{1,3}"`
	Marker                *string                                   `json:"marker" xml:"marker"`
	VideoThumbnailProcess *string                                   `json:"video_thumbnail_process" xml:"video_thumbnail_process"`
	Starred               *bool                                     `json:"Starred" xml:"Starred"`
	Category              *string                                   `json:"category" xml:"category"`
	CustomIndexKey        *string                                   `json:"custom_index_key" xml:"custom_index_key"`
	EncryptMode           *string                                   `json:"encrypt_mode" xml:"encrypt_mode"`
	OrderDirection        *string                                   `json:"order_direction" xml:"order_direction"`
	Status                *string                                   `json:"status" xml:"status"`
	Type                  *string                                   `json:"type" xml:"type"`
	UrlExpireSec          *int64                                    `json:"url_expire_sec" xml:"url_expire_sec"`
}

func (s CCPListFileByCustomIndexKeyRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPListFileByCustomIndexKeyRequest) GoString() string {
	return s.String()
}

func (s *CCPListFileByCustomIndexKeyRequest) SetHeader(v *CCPListFileByCustomIndexKeyRequestHeader) *CCPListFileByCustomIndexKeyRequest {
	s.Header = v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetDriveId(v string) *CCPListFileByCustomIndexKeyRequest {
	s.DriveId = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetImageThumbnailProcess(v string) *CCPListFileByCustomIndexKeyRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetImageUrlProcess(v string) *CCPListFileByCustomIndexKeyRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetLimit(v int64) *CCPListFileByCustomIndexKeyRequest {
	s.Limit = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetMarker(v string) *CCPListFileByCustomIndexKeyRequest {
	s.Marker = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetVideoThumbnailProcess(v string) *CCPListFileByCustomIndexKeyRequest {
	s.VideoThumbnailProcess = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetStarred(v bool) *CCPListFileByCustomIndexKeyRequest {
	s.Starred = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetCategory(v string) *CCPListFileByCustomIndexKeyRequest {
	s.Category = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetCustomIndexKey(v string) *CCPListFileByCustomIndexKeyRequest {
	s.CustomIndexKey = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetEncryptMode(v string) *CCPListFileByCustomIndexKeyRequest {
	s.EncryptMode = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetOrderDirection(v string) *CCPListFileByCustomIndexKeyRequest {
	s.OrderDirection = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetStatus(v string) *CCPListFileByCustomIndexKeyRequest {
	s.Status = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetType(v string) *CCPListFileByCustomIndexKeyRequest {
	s.Type = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequest) SetUrlExpireSec(v int64) *CCPListFileByCustomIndexKeyRequest {
	s.UrlExpireSec = &v
	return s
}

type CCPListFileByCustomIndexKeyRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPListFileByCustomIndexKeyRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPListFileByCustomIndexKeyRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPListFileByCustomIndexKeyRequestHeader) SetTraceId(v string) *CCPListFileByCustomIndexKeyRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPListFileByCustomIndexKeyRequestHeader) SetDeviceId(v string) *CCPListFileByCustomIndexKeyRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPListFileRequest struct {
	Header                *CCPListFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId               *string                   `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ImageThumbnailProcess *string                   `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string                   `json:"image_url_process" xml:"image_url_process"`
	Limit                 *int64                    `json:"limit" xml:"limit" pattern:"[0-9]{1,3}"`
	Marker                *string                   `json:"marker" xml:"marker"`
	VideoThumbnailProcess *string                   `json:"video_thumbnail_process" xml:"video_thumbnail_process"`
	Starred               *bool                     `json:"Starred" xml:"Starred"`
	All                   *bool                     `json:"all" xml:"all"`
	Category              *string                   `json:"category" xml:"category"`
	OrderBy               *string                   `json:"order_by" xml:"order_by"`
	OrderDirection        *string                   `json:"order_direction" xml:"order_direction"`
	ParentFileId          *string                   `json:"parent_file_id" xml:"parent_file_id" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	Status                *string                   `json:"status" xml:"status"`
	Type                  *string                   `json:"type" xml:"type"`
	UrlExpireSec          *int64                    `json:"url_expire_sec" xml:"url_expire_sec"`
}

func (s CCPListFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPListFileRequest) GoString() string {
	return s.String()
}

func (s *CCPListFileRequest) SetHeader(v *CCPListFileRequestHeader) *CCPListFileRequest {
	s.Header = v
	return s
}

func (s *CCPListFileRequest) SetDriveId(v string) *CCPListFileRequest {
	s.DriveId = &v
	return s
}

func (s *CCPListFileRequest) SetImageThumbnailProcess(v string) *CCPListFileRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *CCPListFileRequest) SetImageUrlProcess(v string) *CCPListFileRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *CCPListFileRequest) SetLimit(v int64) *CCPListFileRequest {
	s.Limit = &v
	return s
}

func (s *CCPListFileRequest) SetMarker(v string) *CCPListFileRequest {
	s.Marker = &v
	return s
}

func (s *CCPListFileRequest) SetVideoThumbnailProcess(v string) *CCPListFileRequest {
	s.VideoThumbnailProcess = &v
	return s
}

func (s *CCPListFileRequest) SetStarred(v bool) *CCPListFileRequest {
	s.Starred = &v
	return s
}

func (s *CCPListFileRequest) SetAll(v bool) *CCPListFileRequest {
	s.All = &v
	return s
}

func (s *CCPListFileRequest) SetCategory(v string) *CCPListFileRequest {
	s.Category = &v
	return s
}

func (s *CCPListFileRequest) SetOrderBy(v string) *CCPListFileRequest {
	s.OrderBy = &v
	return s
}

func (s *CCPListFileRequest) SetOrderDirection(v string) *CCPListFileRequest {
	s.OrderDirection = &v
	return s
}

func (s *CCPListFileRequest) SetParentFileId(v string) *CCPListFileRequest {
	s.ParentFileId = &v
	return s
}

func (s *CCPListFileRequest) SetStatus(v string) *CCPListFileRequest {
	s.Status = &v
	return s
}

func (s *CCPListFileRequest) SetType(v string) *CCPListFileRequest {
	s.Type = &v
	return s
}

func (s *CCPListFileRequest) SetUrlExpireSec(v int64) *CCPListFileRequest {
	s.UrlExpireSec = &v
	return s
}

type CCPListFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPListFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPListFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPListFileRequestHeader) SetTraceId(v string) *CCPListFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPListFileRequestHeader) SetDeviceId(v string) *CCPListFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPListUploadedPartRequest struct {
	Header           *CCPListUploadedPartRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId          *string                           `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId           *string                           `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	Limit            *int64                            `json:"limit" xml:"limit" require:"true" pattern:"[0-9]+"`
	PartNumberMarker *int64                            `json:"part_number_marker" xml:"part_number_marker" pattern:"[0-9]+"`
	UploadId         *string                           `json:"upload_id" xml:"upload_id"`
}

func (s CCPListUploadedPartRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPListUploadedPartRequest) GoString() string {
	return s.String()
}

func (s *CCPListUploadedPartRequest) SetHeader(v *CCPListUploadedPartRequestHeader) *CCPListUploadedPartRequest {
	s.Header = v
	return s
}

func (s *CCPListUploadedPartRequest) SetDriveId(v string) *CCPListUploadedPartRequest {
	s.DriveId = &v
	return s
}

func (s *CCPListUploadedPartRequest) SetFileId(v string) *CCPListUploadedPartRequest {
	s.FileId = &v
	return s
}

func (s *CCPListUploadedPartRequest) SetLimit(v int64) *CCPListUploadedPartRequest {
	s.Limit = &v
	return s
}

func (s *CCPListUploadedPartRequest) SetPartNumberMarker(v int64) *CCPListUploadedPartRequest {
	s.PartNumberMarker = &v
	return s
}

func (s *CCPListUploadedPartRequest) SetUploadId(v string) *CCPListUploadedPartRequest {
	s.UploadId = &v
	return s
}

type CCPListUploadedPartRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPListUploadedPartRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPListUploadedPartRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPListUploadedPartRequestHeader) SetTraceId(v string) *CCPListUploadedPartRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPListUploadedPartRequestHeader) SetDeviceId(v string) *CCPListUploadedPartRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPMoveFileRequest struct {
	Header         *CCPMoveFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId        *string                   `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	NewName        *string                   `json:"new_name" xml:"new_name" pattern:".{1,1000}"`
	Overwrite      *bool                     `json:"overwrite" xml:"overwrite"`
	FileId         *string                   `json:"file_id" xml:"file_id" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	ToParentFileId *string                   `json:"to_parent_file_id" xml:"to_parent_file_id" maxLength:"50"`
}

func (s CCPMoveFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPMoveFileRequest) GoString() string {
	return s.String()
}

func (s *CCPMoveFileRequest) SetHeader(v *CCPMoveFileRequestHeader) *CCPMoveFileRequest {
	s.Header = v
	return s
}

func (s *CCPMoveFileRequest) SetDriveId(v string) *CCPMoveFileRequest {
	s.DriveId = &v
	return s
}

func (s *CCPMoveFileRequest) SetNewName(v string) *CCPMoveFileRequest {
	s.NewName = &v
	return s
}

func (s *CCPMoveFileRequest) SetOverwrite(v bool) *CCPMoveFileRequest {
	s.Overwrite = &v
	return s
}

func (s *CCPMoveFileRequest) SetFileId(v string) *CCPMoveFileRequest {
	s.FileId = &v
	return s
}

func (s *CCPMoveFileRequest) SetToParentFileId(v string) *CCPMoveFileRequest {
	s.ToParentFileId = &v
	return s
}

type CCPMoveFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPMoveFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPMoveFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPMoveFileRequestHeader) SetTraceId(v string) *CCPMoveFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPMoveFileRequestHeader) SetDeviceId(v string) *CCPMoveFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPSearchFileRequest struct {
	Header                *CCPSearchFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId               *string                     `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	ImageThumbnailProcess *string                     `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string                     `json:"image_url_process" xml:"image_url_process"`
	Limit                 *int                        `json:"limit" xml:"limit"`
	Marker                *string                     `json:"marker" xml:"marker"`
	OrderBy               *string                     `json:"order_by" xml:"order_by"`
	Query                 *string                     `json:"query" xml:"query" maxLength:"4096"`
	UrlExpireSec          *int64                      `json:"url_expire_sec" xml:"url_expire_sec"`
	VideoThumbnailProcess *string                     `json:"video_thumbnail_process" xml:"video_thumbnail_process"`
}

func (s CCPSearchFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPSearchFileRequest) GoString() string {
	return s.String()
}

func (s *CCPSearchFileRequest) SetHeader(v *CCPSearchFileRequestHeader) *CCPSearchFileRequest {
	s.Header = v
	return s
}

func (s *CCPSearchFileRequest) SetDriveId(v string) *CCPSearchFileRequest {
	s.DriveId = &v
	return s
}

func (s *CCPSearchFileRequest) SetImageThumbnailProcess(v string) *CCPSearchFileRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *CCPSearchFileRequest) SetImageUrlProcess(v string) *CCPSearchFileRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *CCPSearchFileRequest) SetLimit(v int) *CCPSearchFileRequest {
	s.Limit = &v
	return s
}

func (s *CCPSearchFileRequest) SetMarker(v string) *CCPSearchFileRequest {
	s.Marker = &v
	return s
}

func (s *CCPSearchFileRequest) SetOrderBy(v string) *CCPSearchFileRequest {
	s.OrderBy = &v
	return s
}

func (s *CCPSearchFileRequest) SetQuery(v string) *CCPSearchFileRequest {
	s.Query = &v
	return s
}

func (s *CCPSearchFileRequest) SetUrlExpireSec(v int64) *CCPSearchFileRequest {
	s.UrlExpireSec = &v
	return s
}

func (s *CCPSearchFileRequest) SetVideoThumbnailProcess(v string) *CCPSearchFileRequest {
	s.VideoThumbnailProcess = &v
	return s
}

type CCPSearchFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPSearchFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPSearchFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPSearchFileRequestHeader) SetTraceId(v string) *CCPSearchFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPSearchFileRequestHeader) SetDeviceId(v string) *CCPSearchFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CCPUpdateFileMetaRequest struct {
	Header         *CCPUpdateFileMetaRequestHeader `json:"header" xml:"header" type:"Struct"`
	CustomIndexKey *string                         `json:"custom_index_key" xml:"custom_index_key"`
	Description    *string                         `json:"description" xml:"description" maxLength:"1024"`
	DriveId        *string                         `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	EncryptMode    *string                         `json:"encrypt_mode" xml:"encrypt_mode"`
	FileId         *string                         `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	Hidden         *bool                           `json:"hidden" xml:"hidden"`
	Labels         []*string                       `json:"labels" xml:"labels" type:"Repeated"`
	Meta           *string                         `json:"meta" xml:"meta"`
	Name           *string                         `json:"name" xml:"name" pattern:".{1,1000}"`
	Starred        *bool                           `json:"starred" xml:"starred"`
}

func (s CCPUpdateFileMetaRequest) String() string {
	return tea.Prettify(s)
}

func (s CCPUpdateFileMetaRequest) GoString() string {
	return s.String()
}

func (s *CCPUpdateFileMetaRequest) SetHeader(v *CCPUpdateFileMetaRequestHeader) *CCPUpdateFileMetaRequest {
	s.Header = v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetCustomIndexKey(v string) *CCPUpdateFileMetaRequest {
	s.CustomIndexKey = &v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetDescription(v string) *CCPUpdateFileMetaRequest {
	s.Description = &v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetDriveId(v string) *CCPUpdateFileMetaRequest {
	s.DriveId = &v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetEncryptMode(v string) *CCPUpdateFileMetaRequest {
	s.EncryptMode = &v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetFileId(v string) *CCPUpdateFileMetaRequest {
	s.FileId = &v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetHidden(v bool) *CCPUpdateFileMetaRequest {
	s.Hidden = &v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetLabels(v []*string) *CCPUpdateFileMetaRequest {
	s.Labels = v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetMeta(v string) *CCPUpdateFileMetaRequest {
	s.Meta = &v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetName(v string) *CCPUpdateFileMetaRequest {
	s.Name = &v
	return s
}

func (s *CCPUpdateFileMetaRequest) SetStarred(v bool) *CCPUpdateFileMetaRequest {
	s.Starred = &v
	return s
}

type CCPUpdateFileMetaRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CCPUpdateFileMetaRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CCPUpdateFileMetaRequestHeader) GoString() string {
	return s.String()
}

func (s *CCPUpdateFileMetaRequestHeader) SetTraceId(v string) *CCPUpdateFileMetaRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CCPUpdateFileMetaRequestHeader) SetDeviceId(v string) *CCPUpdateFileMetaRequestHeader {
	s.DeviceId = &v
	return s
}

type CompleteFileRequest struct {
	Header       *CompleteFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId      *string                    `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId       *string                    `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9]{1,50}"`
	FilePath     *string                    `json:"file_path" xml:"file_path"`
	PartInfoList []*UploadPartInfo          `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	ShareId      *string                    `json:"share_id" xml:"share_id"`
	UploadId     *string                    `json:"upload_id" xml:"upload_id" require:"true"`
}

func (s CompleteFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CompleteFileRequest) GoString() string {
	return s.String()
}

func (s *CompleteFileRequest) SetHeader(v *CompleteFileRequestHeader) *CompleteFileRequest {
	s.Header = v
	return s
}

func (s *CompleteFileRequest) SetDriveId(v string) *CompleteFileRequest {
	s.DriveId = &v
	return s
}

func (s *CompleteFileRequest) SetFileId(v string) *CompleteFileRequest {
	s.FileId = &v
	return s
}

func (s *CompleteFileRequest) SetFilePath(v string) *CompleteFileRequest {
	s.FilePath = &v
	return s
}

func (s *CompleteFileRequest) SetPartInfoList(v []*UploadPartInfo) *CompleteFileRequest {
	s.PartInfoList = v
	return s
}

func (s *CompleteFileRequest) SetShareId(v string) *CompleteFileRequest {
	s.ShareId = &v
	return s
}

func (s *CompleteFileRequest) SetUploadId(v string) *CompleteFileRequest {
	s.UploadId = &v
	return s
}

type CompleteFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CompleteFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CompleteFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CompleteFileRequestHeader) SetTraceId(v string) *CompleteFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CompleteFileRequestHeader) SetDeviceId(v string) *CompleteFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CopyFileRequest struct {
	Header           *CopyFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId          *string                `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId           *string                `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	FilePath         *string                `json:"file_path" xml:"file_path"`
	NewName          *string                `json:"new_name" xml:"new_name" require:"true" pattern:"[a-zA-Z0-9.-]{1,1000}"`
	Overwrite        *bool                  `json:"overwrite" xml:"overwrite"`
	ShareId          *string                `json:"share_id" xml:"share_id"`
	ToParentFileId   *string                `json:"to_parent_file_id" xml:"to_parent_file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	ToParentFilePath *string                `json:"to_parent_file_path" xml:"to_parent_file_path"`
}

func (s CopyFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CopyFileRequest) GoString() string {
	return s.String()
}

func (s *CopyFileRequest) SetHeader(v *CopyFileRequestHeader) *CopyFileRequest {
	s.Header = v
	return s
}

func (s *CopyFileRequest) SetDriveId(v string) *CopyFileRequest {
	s.DriveId = &v
	return s
}

func (s *CopyFileRequest) SetFileId(v string) *CopyFileRequest {
	s.FileId = &v
	return s
}

func (s *CopyFileRequest) SetFilePath(v string) *CopyFileRequest {
	s.FilePath = &v
	return s
}

func (s *CopyFileRequest) SetNewName(v string) *CopyFileRequest {
	s.NewName = &v
	return s
}

func (s *CopyFileRequest) SetOverwrite(v bool) *CopyFileRequest {
	s.Overwrite = &v
	return s
}

func (s *CopyFileRequest) SetShareId(v string) *CopyFileRequest {
	s.ShareId = &v
	return s
}

func (s *CopyFileRequest) SetToParentFileId(v string) *CopyFileRequest {
	s.ToParentFileId = &v
	return s
}

func (s *CopyFileRequest) SetToParentFilePath(v string) *CopyFileRequest {
	s.ToParentFilePath = &v
	return s
}

type CopyFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CopyFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CopyFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CopyFileRequestHeader) SetTraceId(v string) *CopyFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CopyFileRequestHeader) SetDeviceId(v string) *CopyFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CreateDriveRequest struct {
	Header       *CreateDriveRequestHeader `json:"header" xml:"header" type:"Struct"`
	Default      *bool                     `json:"default" xml:"default"`
	Description  *string                   `json:"description" xml:"description"`
	DriveName    *string                   `json:"drive_name" xml:"drive_name" require:"true"`
	DriveType    *string                   `json:"drive_type" xml:"drive_type"`
	EncryptMode  *string                   `json:"encrypt_mode" xml:"encrypt_mode"`
	Owner        *string                   `json:"owner" xml:"owner" require:"true"`
	RelativePath *string                   `json:"relative_path" xml:"relative_path"`
	Status       *string                   `json:"status" xml:"status"`
	StoreId      *string                   `json:"store_id" xml:"store_id"`
	TotalSize    *int64                    `json:"total_size" xml:"total_size"`
}

func (s CreateDriveRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateDriveRequest) GoString() string {
	return s.String()
}

func (s *CreateDriveRequest) SetHeader(v *CreateDriveRequestHeader) *CreateDriveRequest {
	s.Header = v
	return s
}

func (s *CreateDriveRequest) SetDefault(v bool) *CreateDriveRequest {
	s.Default = &v
	return s
}

func (s *CreateDriveRequest) SetDescription(v string) *CreateDriveRequest {
	s.Description = &v
	return s
}

func (s *CreateDriveRequest) SetDriveName(v string) *CreateDriveRequest {
	s.DriveName = &v
	return s
}

func (s *CreateDriveRequest) SetDriveType(v string) *CreateDriveRequest {
	s.DriveType = &v
	return s
}

func (s *CreateDriveRequest) SetEncryptMode(v string) *CreateDriveRequest {
	s.EncryptMode = &v
	return s
}

func (s *CreateDriveRequest) SetOwner(v string) *CreateDriveRequest {
	s.Owner = &v
	return s
}

func (s *CreateDriveRequest) SetRelativePath(v string) *CreateDriveRequest {
	s.RelativePath = &v
	return s
}

func (s *CreateDriveRequest) SetStatus(v string) *CreateDriveRequest {
	s.Status = &v
	return s
}

func (s *CreateDriveRequest) SetStoreId(v string) *CreateDriveRequest {
	s.StoreId = &v
	return s
}

func (s *CreateDriveRequest) SetTotalSize(v int64) *CreateDriveRequest {
	s.TotalSize = &v
	return s
}

type CreateDriveRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CreateDriveRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CreateDriveRequestHeader) GoString() string {
	return s.String()
}

func (s *CreateDriveRequestHeader) SetTraceId(v string) *CreateDriveRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CreateDriveRequestHeader) SetDeviceId(v string) *CreateDriveRequestHeader {
	s.DeviceId = &v
	return s
}

type CreateFileRequest struct {
	Header          *CreateFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	ContentHash     *string                  `json:"content_hash" xml:"content_hash"`
	ContentHashName *string                  `json:"content_hash_name" xml:"content_hash_name"`
	ContentMd5      *string                  `json:"content_md5" xml:"content_md5" maxLength:"32"`
	ContentType     *string                  `json:"content_type" xml:"content_type" require:"true"`
	Description     *string                  `json:"description" xml:"description" maxLength:"0"`
	DriveId         *string                  `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	Hidden          *bool                    `json:"hidden" xml:"hidden"`
	Meta            *string                  `json:"meta" xml:"meta"`
	Name            *string                  `json:"name" xml:"name" require:"true"`
	ParentFileId    *string                  `json:"parent_file_id" xml:"parent_file_id" require:"true" maxLength:"50" pattern:"[a-z0-9]{1,50}"`
	ParentFilePath  *string                  `json:"parent_file_path" xml:"parent_file_path"`
	PartInfoList    []*UploadPartInfo        `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	PreHash         *string                  `json:"pre_hash" xml:"pre_hash"`
	ShareId         *string                  `json:"share_id" xml:"share_id"`
	Size            *int64                   `json:"size" xml:"size" require:"true"`
	Tags            map[string]interface{}   `json:"tags" xml:"tags"`
	Type            *string                  `json:"type" xml:"type" require:"true"`
}

func (s CreateFileRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateFileRequest) GoString() string {
	return s.String()
}

func (s *CreateFileRequest) SetHeader(v *CreateFileRequestHeader) *CreateFileRequest {
	s.Header = v
	return s
}

func (s *CreateFileRequest) SetContentHash(v string) *CreateFileRequest {
	s.ContentHash = &v
	return s
}

func (s *CreateFileRequest) SetContentHashName(v string) *CreateFileRequest {
	s.ContentHashName = &v
	return s
}

func (s *CreateFileRequest) SetContentMd5(v string) *CreateFileRequest {
	s.ContentMd5 = &v
	return s
}

func (s *CreateFileRequest) SetContentType(v string) *CreateFileRequest {
	s.ContentType = &v
	return s
}

func (s *CreateFileRequest) SetDescription(v string) *CreateFileRequest {
	s.Description = &v
	return s
}

func (s *CreateFileRequest) SetDriveId(v string) *CreateFileRequest {
	s.DriveId = &v
	return s
}

func (s *CreateFileRequest) SetHidden(v bool) *CreateFileRequest {
	s.Hidden = &v
	return s
}

func (s *CreateFileRequest) SetMeta(v string) *CreateFileRequest {
	s.Meta = &v
	return s
}

func (s *CreateFileRequest) SetName(v string) *CreateFileRequest {
	s.Name = &v
	return s
}

func (s *CreateFileRequest) SetParentFileId(v string) *CreateFileRequest {
	s.ParentFileId = &v
	return s
}

func (s *CreateFileRequest) SetParentFilePath(v string) *CreateFileRequest {
	s.ParentFilePath = &v
	return s
}

func (s *CreateFileRequest) SetPartInfoList(v []*UploadPartInfo) *CreateFileRequest {
	s.PartInfoList = v
	return s
}

func (s *CreateFileRequest) SetPreHash(v string) *CreateFileRequest {
	s.PreHash = &v
	return s
}

func (s *CreateFileRequest) SetShareId(v string) *CreateFileRequest {
	s.ShareId = &v
	return s
}

func (s *CreateFileRequest) SetSize(v int64) *CreateFileRequest {
	s.Size = &v
	return s
}

func (s *CreateFileRequest) SetTags(v map[string]interface{}) *CreateFileRequest {
	s.Tags = v
	return s
}

func (s *CreateFileRequest) SetType(v string) *CreateFileRequest {
	s.Type = &v
	return s
}

type CreateFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CreateFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CreateFileRequestHeader) GoString() string {
	return s.String()
}

func (s *CreateFileRequestHeader) SetTraceId(v string) *CreateFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CreateFileRequestHeader) SetDeviceId(v string) *CreateFileRequestHeader {
	s.DeviceId = &v
	return s
}

type CreateShareRequest struct {
	Header        *CreateShareRequestHeader `json:"header" xml:"header" type:"Struct"`
	Description   *string                   `json:"description" xml:"description"`
	DriveId       *string                   `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	Expiration    *string                   `json:"expiration" xml:"expiration"`
	Owner         *string                   `json:"owner" xml:"owner" require:"true"`
	Permissions   []*string                 `json:"permissions" xml:"permissions" type:"Repeated"`
	ShareFilePath *string                   `json:"share_file_path" xml:"share_file_path" require:"true"`
	ShareName     *string                   `json:"share_name" xml:"share_name"`
	SharePolicy   []*SharePermissionPolicy  `json:"share_policy" xml:"share_policy" type:"Repeated"`
	Status        *string                   `json:"status" xml:"status"`
}

func (s CreateShareRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateShareRequest) GoString() string {
	return s.String()
}

func (s *CreateShareRequest) SetHeader(v *CreateShareRequestHeader) *CreateShareRequest {
	s.Header = v
	return s
}

func (s *CreateShareRequest) SetDescription(v string) *CreateShareRequest {
	s.Description = &v
	return s
}

func (s *CreateShareRequest) SetDriveId(v string) *CreateShareRequest {
	s.DriveId = &v
	return s
}

func (s *CreateShareRequest) SetExpiration(v string) *CreateShareRequest {
	s.Expiration = &v
	return s
}

func (s *CreateShareRequest) SetOwner(v string) *CreateShareRequest {
	s.Owner = &v
	return s
}

func (s *CreateShareRequest) SetPermissions(v []*string) *CreateShareRequest {
	s.Permissions = v
	return s
}

func (s *CreateShareRequest) SetShareFilePath(v string) *CreateShareRequest {
	s.ShareFilePath = &v
	return s
}

func (s *CreateShareRequest) SetShareName(v string) *CreateShareRequest {
	s.ShareName = &v
	return s
}

func (s *CreateShareRequest) SetSharePolicy(v []*SharePermissionPolicy) *CreateShareRequest {
	s.SharePolicy = v
	return s
}

func (s *CreateShareRequest) SetStatus(v string) *CreateShareRequest {
	s.Status = &v
	return s
}

type CreateShareRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CreateShareRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CreateShareRequestHeader) GoString() string {
	return s.String()
}

func (s *CreateShareRequestHeader) SetTraceId(v string) *CreateShareRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CreateShareRequestHeader) SetDeviceId(v string) *CreateShareRequestHeader {
	s.DeviceId = &v
	return s
}

type DeleteDriveRequest struct {
	Header  *DeleteDriveRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId *string                   `json:"drive_id" xml:"drive_id" require:"true"`
}

func (s DeleteDriveRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteDriveRequest) GoString() string {
	return s.String()
}

func (s *DeleteDriveRequest) SetHeader(v *DeleteDriveRequestHeader) *DeleteDriveRequest {
	s.Header = v
	return s
}

func (s *DeleteDriveRequest) SetDriveId(v string) *DeleteDriveRequest {
	s.DriveId = &v
	return s
}

type DeleteDriveRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DeleteDriveRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DeleteDriveRequestHeader) GoString() string {
	return s.String()
}

func (s *DeleteDriveRequestHeader) SetTraceId(v string) *DeleteDriveRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DeleteDriveRequestHeader) SetDeviceId(v string) *DeleteDriveRequestHeader {
	s.DeviceId = &v
	return s
}

type DeleteFileRequest struct {
	Header      *DeleteFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId     *string                  `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId      *string                  `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	FilePath    *string                  `json:"file_path" xml:"file_path"`
	Permanently *bool                    `json:"permanently" xml:"permanently"`
	ShareId     *string                  `json:"share_id" xml:"share_id"`
}

func (s DeleteFileRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteFileRequest) GoString() string {
	return s.String()
}

func (s *DeleteFileRequest) SetHeader(v *DeleteFileRequestHeader) *DeleteFileRequest {
	s.Header = v
	return s
}

func (s *DeleteFileRequest) SetDriveId(v string) *DeleteFileRequest {
	s.DriveId = &v
	return s
}

func (s *DeleteFileRequest) SetFileId(v string) *DeleteFileRequest {
	s.FileId = &v
	return s
}

func (s *DeleteFileRequest) SetFilePath(v string) *DeleteFileRequest {
	s.FilePath = &v
	return s
}

func (s *DeleteFileRequest) SetPermanently(v bool) *DeleteFileRequest {
	s.Permanently = &v
	return s
}

func (s *DeleteFileRequest) SetShareId(v string) *DeleteFileRequest {
	s.ShareId = &v
	return s
}

type DeleteFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DeleteFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DeleteFileRequestHeader) GoString() string {
	return s.String()
}

func (s *DeleteFileRequestHeader) SetTraceId(v string) *DeleteFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DeleteFileRequestHeader) SetDeviceId(v string) *DeleteFileRequestHeader {
	s.DeviceId = &v
	return s
}

type DeleteShareRequest struct {
	Header  *DeleteShareRequestHeader `json:"header" xml:"header" type:"Struct"`
	ShareId *string                   `json:"share_id" xml:"share_id" require:"true"`
}

func (s DeleteShareRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteShareRequest) GoString() string {
	return s.String()
}

func (s *DeleteShareRequest) SetHeader(v *DeleteShareRequestHeader) *DeleteShareRequest {
	s.Header = v
	return s
}

func (s *DeleteShareRequest) SetShareId(v string) *DeleteShareRequest {
	s.ShareId = &v
	return s
}

type DeleteShareRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DeleteShareRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DeleteShareRequestHeader) GoString() string {
	return s.String()
}

func (s *DeleteShareRequestHeader) SetTraceId(v string) *DeleteShareRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DeleteShareRequestHeader) SetDeviceId(v string) *DeleteShareRequestHeader {
	s.DeviceId = &v
	return s
}

type DownloadRequest struct {
	Header       *DownloadRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveID      *string                `json:"DriveID" xml:"DriveID" require:"true" pattern:"[0-9]+"`
	FileID       *string                `json:"FileID" xml:"FileID" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	ImageProcess *string                `json:"ImageProcess" xml:"ImageProcess"`
	ShareID      *string                `json:"ShareID" xml:"ShareID"`
}

func (s DownloadRequest) String() string {
	return tea.Prettify(s)
}

func (s DownloadRequest) GoString() string {
	return s.String()
}

func (s *DownloadRequest) SetHeader(v *DownloadRequestHeader) *DownloadRequest {
	s.Header = v
	return s
}

func (s *DownloadRequest) SetDriveID(v string) *DownloadRequest {
	s.DriveID = &v
	return s
}

func (s *DownloadRequest) SetFileID(v string) *DownloadRequest {
	s.FileID = &v
	return s
}

func (s *DownloadRequest) SetImageProcess(v string) *DownloadRequest {
	s.ImageProcess = &v
	return s
}

func (s *DownloadRequest) SetShareID(v string) *DownloadRequest {
	s.ShareID = &v
	return s
}

type DownloadRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DownloadRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DownloadRequestHeader) GoString() string {
	return s.String()
}

func (s *DownloadRequestHeader) SetTraceId(v string) *DownloadRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DownloadRequestHeader) SetDeviceId(v string) *DownloadRequestHeader {
	s.DeviceId = &v
	return s
}

type GetAsyncTaskRequest struct {
	Header      *GetAsyncTaskRequestHeader `json:"header" xml:"header" type:"Struct"`
	AsyncTaskId *string                    `json:"async_task_id" xml:"async_task_id"`
}

func (s GetAsyncTaskRequest) String() string {
	return tea.Prettify(s)
}

func (s GetAsyncTaskRequest) GoString() string {
	return s.String()
}

func (s *GetAsyncTaskRequest) SetHeader(v *GetAsyncTaskRequestHeader) *GetAsyncTaskRequest {
	s.Header = v
	return s
}

func (s *GetAsyncTaskRequest) SetAsyncTaskId(v string) *GetAsyncTaskRequest {
	s.AsyncTaskId = &v
	return s
}

type GetAsyncTaskRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetAsyncTaskRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetAsyncTaskRequestHeader) GoString() string {
	return s.String()
}

func (s *GetAsyncTaskRequestHeader) SetTraceId(v string) *GetAsyncTaskRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetAsyncTaskRequestHeader) SetDeviceId(v string) *GetAsyncTaskRequestHeader {
	s.DeviceId = &v
	return s
}

type GetDefaultDriveRequest struct {
	Header *GetDefaultDriveRequestHeader `json:"header" xml:"header" type:"Struct"`
	UserId *string                       `json:"user_id" xml:"user_id"`
}

func (s GetDefaultDriveRequest) String() string {
	return tea.Prettify(s)
}

func (s GetDefaultDriveRequest) GoString() string {
	return s.String()
}

func (s *GetDefaultDriveRequest) SetHeader(v *GetDefaultDriveRequestHeader) *GetDefaultDriveRequest {
	s.Header = v
	return s
}

func (s *GetDefaultDriveRequest) SetUserId(v string) *GetDefaultDriveRequest {
	s.UserId = &v
	return s
}

type GetDefaultDriveRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetDefaultDriveRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetDefaultDriveRequestHeader) GoString() string {
	return s.String()
}

func (s *GetDefaultDriveRequestHeader) SetTraceId(v string) *GetDefaultDriveRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetDefaultDriveRequestHeader) SetDeviceId(v string) *GetDefaultDriveRequestHeader {
	s.DeviceId = &v
	return s
}

type GetDownloadUrlRequest struct {
	Header    *GetDownloadUrlRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId   *string                      `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	ExpireSec *int64                       `json:"expire_sec" xml:"expire_sec"`
	FileId    *string                      `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	FileName  *string                      `json:"file_name" xml:"file_name" pattern:"[a-zA-Z0-9.-]{1,1000}"`
	FilePath  *string                      `json:"file_path" xml:"file_path"`
	ShareId   *string                      `json:"share_id" xml:"share_id"`
}

func (s GetDownloadUrlRequest) String() string {
	return tea.Prettify(s)
}

func (s GetDownloadUrlRequest) GoString() string {
	return s.String()
}

func (s *GetDownloadUrlRequest) SetHeader(v *GetDownloadUrlRequestHeader) *GetDownloadUrlRequest {
	s.Header = v
	return s
}

func (s *GetDownloadUrlRequest) SetDriveId(v string) *GetDownloadUrlRequest {
	s.DriveId = &v
	return s
}

func (s *GetDownloadUrlRequest) SetExpireSec(v int64) *GetDownloadUrlRequest {
	s.ExpireSec = &v
	return s
}

func (s *GetDownloadUrlRequest) SetFileId(v string) *GetDownloadUrlRequest {
	s.FileId = &v
	return s
}

func (s *GetDownloadUrlRequest) SetFileName(v string) *GetDownloadUrlRequest {
	s.FileName = &v
	return s
}

func (s *GetDownloadUrlRequest) SetFilePath(v string) *GetDownloadUrlRequest {
	s.FilePath = &v
	return s
}

func (s *GetDownloadUrlRequest) SetShareId(v string) *GetDownloadUrlRequest {
	s.ShareId = &v
	return s
}

type GetDownloadUrlRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetDownloadUrlRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetDownloadUrlRequestHeader) GoString() string {
	return s.String()
}

func (s *GetDownloadUrlRequestHeader) SetTraceId(v string) *GetDownloadUrlRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetDownloadUrlRequestHeader) SetDeviceId(v string) *GetDownloadUrlRequestHeader {
	s.DeviceId = &v
	return s
}

type GetDriveRequest struct {
	Header  *GetDriveRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId *string                `json:"drive_id" xml:"drive_id" require:"true"`
}

func (s GetDriveRequest) String() string {
	return tea.Prettify(s)
}

func (s GetDriveRequest) GoString() string {
	return s.String()
}

func (s *GetDriveRequest) SetHeader(v *GetDriveRequestHeader) *GetDriveRequest {
	s.Header = v
	return s
}

func (s *GetDriveRequest) SetDriveId(v string) *GetDriveRequest {
	s.DriveId = &v
	return s
}

type GetDriveRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetDriveRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetDriveRequestHeader) GoString() string {
	return s.String()
}

func (s *GetDriveRequestHeader) SetTraceId(v string) *GetDriveRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetDriveRequestHeader) SetDeviceId(v string) *GetDriveRequestHeader {
	s.DeviceId = &v
	return s
}

type GetFileRequest struct {
	Header                *GetFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId               *string               `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId                *string               `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	FilePath              *string               `json:"file_path" xml:"file_path"`
	ImageThumbnailProcess *string               `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string               `json:"image_url_process" xml:"image_url_process"`
	ShareId               *string               `json:"share_id" xml:"share_id"`
}

func (s GetFileRequest) String() string {
	return tea.Prettify(s)
}

func (s GetFileRequest) GoString() string {
	return s.String()
}

func (s *GetFileRequest) SetHeader(v *GetFileRequestHeader) *GetFileRequest {
	s.Header = v
	return s
}

func (s *GetFileRequest) SetDriveId(v string) *GetFileRequest {
	s.DriveId = &v
	return s
}

func (s *GetFileRequest) SetFileId(v string) *GetFileRequest {
	s.FileId = &v
	return s
}

func (s *GetFileRequest) SetFilePath(v string) *GetFileRequest {
	s.FilePath = &v
	return s
}

func (s *GetFileRequest) SetImageThumbnailProcess(v string) *GetFileRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *GetFileRequest) SetImageUrlProcess(v string) *GetFileRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *GetFileRequest) SetShareId(v string) *GetFileRequest {
	s.ShareId = &v
	return s
}

type GetFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetFileRequestHeader) GoString() string {
	return s.String()
}

func (s *GetFileRequestHeader) SetTraceId(v string) *GetFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetFileRequestHeader) SetDeviceId(v string) *GetFileRequestHeader {
	s.DeviceId = &v
	return s
}

type GetShareRequest struct {
	Header  *GetShareRequestHeader `json:"header" xml:"header" type:"Struct"`
	ShareId *string                `json:"share_id" xml:"share_id"`
}

func (s GetShareRequest) String() string {
	return tea.Prettify(s)
}

func (s GetShareRequest) GoString() string {
	return s.String()
}

func (s *GetShareRequest) SetHeader(v *GetShareRequestHeader) *GetShareRequest {
	s.Header = v
	return s
}

func (s *GetShareRequest) SetShareId(v string) *GetShareRequest {
	s.ShareId = &v
	return s
}

type GetShareRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetShareRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetShareRequestHeader) GoString() string {
	return s.String()
}

func (s *GetShareRequestHeader) SetTraceId(v string) *GetShareRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetShareRequestHeader) SetDeviceId(v string) *GetShareRequestHeader {
	s.DeviceId = &v
	return s
}

type GetUploadUrlRequest struct {
	Header       *GetUploadUrlRequestHeader `json:"header" xml:"header" type:"Struct"`
	ContentMd5   *string                    `json:"content_md5" xml:"content_md5" maxLength:"32"`
	DriveId      *string                    `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId       *string                    `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9]{1,50}"`
	FilePath     *string                    `json:"file_path" xml:"file_path"`
	PartInfoList []*UploadPartInfo          `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	ShareId      *string                    `json:"share_id" xml:"share_id"`
	UploadId     *string                    `json:"upload_id" xml:"upload_id" require:"true"`
}

func (s GetUploadUrlRequest) String() string {
	return tea.Prettify(s)
}

func (s GetUploadUrlRequest) GoString() string {
	return s.String()
}

func (s *GetUploadUrlRequest) SetHeader(v *GetUploadUrlRequestHeader) *GetUploadUrlRequest {
	s.Header = v
	return s
}

func (s *GetUploadUrlRequest) SetContentMd5(v string) *GetUploadUrlRequest {
	s.ContentMd5 = &v
	return s
}

func (s *GetUploadUrlRequest) SetDriveId(v string) *GetUploadUrlRequest {
	s.DriveId = &v
	return s
}

func (s *GetUploadUrlRequest) SetFileId(v string) *GetUploadUrlRequest {
	s.FileId = &v
	return s
}

func (s *GetUploadUrlRequest) SetFilePath(v string) *GetUploadUrlRequest {
	s.FilePath = &v
	return s
}

func (s *GetUploadUrlRequest) SetPartInfoList(v []*UploadPartInfo) *GetUploadUrlRequest {
	s.PartInfoList = v
	return s
}

func (s *GetUploadUrlRequest) SetShareId(v string) *GetUploadUrlRequest {
	s.ShareId = &v
	return s
}

func (s *GetUploadUrlRequest) SetUploadId(v string) *GetUploadUrlRequest {
	s.UploadId = &v
	return s
}

type GetUploadUrlRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetUploadUrlRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetUploadUrlRequestHeader) GoString() string {
	return s.String()
}

func (s *GetUploadUrlRequestHeader) SetTraceId(v string) *GetUploadUrlRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetUploadUrlRequestHeader) SetDeviceId(v string) *GetUploadUrlRequestHeader {
	s.DeviceId = &v
	return s
}

type ListDriveRequest struct {
	Header *ListDriveRequestHeader `json:"header" xml:"header" type:"Struct"`
	Limit  *int                    `json:"limit" xml:"limit"`
	Marker *string                 `json:"marker" xml:"marker"`
	Owner  *string                 `json:"owner" xml:"owner"`
}

func (s ListDriveRequest) String() string {
	return tea.Prettify(s)
}

func (s ListDriveRequest) GoString() string {
	return s.String()
}

func (s *ListDriveRequest) SetHeader(v *ListDriveRequestHeader) *ListDriveRequest {
	s.Header = v
	return s
}

func (s *ListDriveRequest) SetLimit(v int) *ListDriveRequest {
	s.Limit = &v
	return s
}

func (s *ListDriveRequest) SetMarker(v string) *ListDriveRequest {
	s.Marker = &v
	return s
}

func (s *ListDriveRequest) SetOwner(v string) *ListDriveRequest {
	s.Owner = &v
	return s
}

type ListDriveRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListDriveRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListDriveRequestHeader) GoString() string {
	return s.String()
}

func (s *ListDriveRequestHeader) SetTraceId(v string) *ListDriveRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListDriveRequestHeader) SetDeviceId(v string) *ListDriveRequestHeader {
	s.DeviceId = &v
	return s
}

type ListFileRequest struct {
	Header                *ListFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	All                   *bool                  `json:"all" xml:"all"`
	DriveId               *string                `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	ImageThumbnailProcess *string                `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string                `json:"image_url_process" xml:"image_url_process"`
	Limit                 *int64                 `json:"limit" xml:"limit" pattern:"[0-9]{1,3}"`
	Marker                *string                `json:"marker" xml:"marker"`
	ParentFileId          *string                `json:"parent_file_id" xml:"parent_file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	ParentFilePath        *string                `json:"parent_file_path" xml:"parent_file_path"`
	ShareId               *string                `json:"share_id" xml:"share_id"`
	Status                *string                `json:"status" xml:"status"`
}

func (s ListFileRequest) String() string {
	return tea.Prettify(s)
}

func (s ListFileRequest) GoString() string {
	return s.String()
}

func (s *ListFileRequest) SetHeader(v *ListFileRequestHeader) *ListFileRequest {
	s.Header = v
	return s
}

func (s *ListFileRequest) SetAll(v bool) *ListFileRequest {
	s.All = &v
	return s
}

func (s *ListFileRequest) SetDriveId(v string) *ListFileRequest {
	s.DriveId = &v
	return s
}

func (s *ListFileRequest) SetImageThumbnailProcess(v string) *ListFileRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *ListFileRequest) SetImageUrlProcess(v string) *ListFileRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *ListFileRequest) SetLimit(v int64) *ListFileRequest {
	s.Limit = &v
	return s
}

func (s *ListFileRequest) SetMarker(v string) *ListFileRequest {
	s.Marker = &v
	return s
}

func (s *ListFileRequest) SetParentFileId(v string) *ListFileRequest {
	s.ParentFileId = &v
	return s
}

func (s *ListFileRequest) SetParentFilePath(v string) *ListFileRequest {
	s.ParentFilePath = &v
	return s
}

func (s *ListFileRequest) SetShareId(v string) *ListFileRequest {
	s.ShareId = &v
	return s
}

func (s *ListFileRequest) SetStatus(v string) *ListFileRequest {
	s.Status = &v
	return s
}

type ListFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListFileRequestHeader) GoString() string {
	return s.String()
}

func (s *ListFileRequestHeader) SetTraceId(v string) *ListFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListFileRequestHeader) SetDeviceId(v string) *ListFileRequestHeader {
	s.DeviceId = &v
	return s
}

type ListMyDriveRequest struct {
	Header *ListMyDriveRequestHeader `json:"header" xml:"header" type:"Struct"`
	Limit  *int                      `json:"limit" xml:"limit"`
	Marker *string                   `json:"marker" xml:"marker"`
}

func (s ListMyDriveRequest) String() string {
	return tea.Prettify(s)
}

func (s ListMyDriveRequest) GoString() string {
	return s.String()
}

func (s *ListMyDriveRequest) SetHeader(v *ListMyDriveRequestHeader) *ListMyDriveRequest {
	s.Header = v
	return s
}

func (s *ListMyDriveRequest) SetLimit(v int) *ListMyDriveRequest {
	s.Limit = &v
	return s
}

func (s *ListMyDriveRequest) SetMarker(v string) *ListMyDriveRequest {
	s.Marker = &v
	return s
}

type ListMyDriveRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListMyDriveRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListMyDriveRequestHeader) GoString() string {
	return s.String()
}

func (s *ListMyDriveRequestHeader) SetTraceId(v string) *ListMyDriveRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListMyDriveRequestHeader) SetDeviceId(v string) *ListMyDriveRequestHeader {
	s.DeviceId = &v
	return s
}

type ListShareRequest struct {
	Header        *ListShareRequestHeader `json:"header" xml:"header" type:"Struct"`
	Creator       *string                 `json:"creator" xml:"creator"`
	DriveId       *string                 `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	Limit         *int                    `json:"limit" xml:"limit" require:"true"`
	Marker        *string                 `json:"marker" xml:"marker"`
	Owner         *string                 `json:"owner" xml:"owner"`
	ShareFilePath *string                 `json:"share_file_path" xml:"share_file_path"`
}

func (s ListShareRequest) String() string {
	return tea.Prettify(s)
}

func (s ListShareRequest) GoString() string {
	return s.String()
}

func (s *ListShareRequest) SetHeader(v *ListShareRequestHeader) *ListShareRequest {
	s.Header = v
	return s
}

func (s *ListShareRequest) SetCreator(v string) *ListShareRequest {
	s.Creator = &v
	return s
}

func (s *ListShareRequest) SetDriveId(v string) *ListShareRequest {
	s.DriveId = &v
	return s
}

func (s *ListShareRequest) SetLimit(v int) *ListShareRequest {
	s.Limit = &v
	return s
}

func (s *ListShareRequest) SetMarker(v string) *ListShareRequest {
	s.Marker = &v
	return s
}

func (s *ListShareRequest) SetOwner(v string) *ListShareRequest {
	s.Owner = &v
	return s
}

func (s *ListShareRequest) SetShareFilePath(v string) *ListShareRequest {
	s.ShareFilePath = &v
	return s
}

type ListShareRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListShareRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListShareRequestHeader) GoString() string {
	return s.String()
}

func (s *ListShareRequestHeader) SetTraceId(v string) *ListShareRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListShareRequestHeader) SetDeviceId(v string) *ListShareRequestHeader {
	s.DeviceId = &v
	return s
}

type ListStoreFileRequest struct {
	Header         *ListStoreFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	Limit          *int64                      `json:"limit" xml:"limit"`
	Marker         *string                     `json:"marker" xml:"marker"`
	ParentFilePath *string                     `json:"parent_file_path" xml:"parent_file_path"`
	StoreId        *string                     `json:"store_id" xml:"store_id"`
	Type           *string                     `json:"type" xml:"type"`
}

func (s ListStoreFileRequest) String() string {
	return tea.Prettify(s)
}

func (s ListStoreFileRequest) GoString() string {
	return s.String()
}

func (s *ListStoreFileRequest) SetHeader(v *ListStoreFileRequestHeader) *ListStoreFileRequest {
	s.Header = v
	return s
}

func (s *ListStoreFileRequest) SetLimit(v int64) *ListStoreFileRequest {
	s.Limit = &v
	return s
}

func (s *ListStoreFileRequest) SetMarker(v string) *ListStoreFileRequest {
	s.Marker = &v
	return s
}

func (s *ListStoreFileRequest) SetParentFilePath(v string) *ListStoreFileRequest {
	s.ParentFilePath = &v
	return s
}

func (s *ListStoreFileRequest) SetStoreId(v string) *ListStoreFileRequest {
	s.StoreId = &v
	return s
}

func (s *ListStoreFileRequest) SetType(v string) *ListStoreFileRequest {
	s.Type = &v
	return s
}

type ListStoreFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListStoreFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListStoreFileRequestHeader) GoString() string {
	return s.String()
}

func (s *ListStoreFileRequestHeader) SetTraceId(v string) *ListStoreFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListStoreFileRequestHeader) SetDeviceId(v string) *ListStoreFileRequestHeader {
	s.DeviceId = &v
	return s
}

type ListStoreRequest struct {
	Header   *ListStoreRequestHeader `json:"header" xml:"header" type:"Struct"`
	DomainId *string                 `json:"domain_id" xml:"domain_id"`
}

func (s ListStoreRequest) String() string {
	return tea.Prettify(s)
}

func (s ListStoreRequest) GoString() string {
	return s.String()
}

func (s *ListStoreRequest) SetHeader(v *ListStoreRequestHeader) *ListStoreRequest {
	s.Header = v
	return s
}

func (s *ListStoreRequest) SetDomainId(v string) *ListStoreRequest {
	s.DomainId = &v
	return s
}

type ListStoreRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListStoreRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListStoreRequestHeader) GoString() string {
	return s.String()
}

func (s *ListStoreRequestHeader) SetTraceId(v string) *ListStoreRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListStoreRequestHeader) SetDeviceId(v string) *ListStoreRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSCompleteFileRequest struct {
	Header       *OSSCompleteFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId      *string                       `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	PartInfoList []*UploadPartInfo             `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	UploadId     *string                       `json:"upload_id" xml:"upload_id"`
	FilePath     *string                       `json:"file_path" xml:"file_path"`
	ShareId      *string                       `json:"share_id" xml:"share_id"`
}

func (s OSSCompleteFileRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSCompleteFileRequest) GoString() string {
	return s.String()
}

func (s *OSSCompleteFileRequest) SetHeader(v *OSSCompleteFileRequestHeader) *OSSCompleteFileRequest {
	s.Header = v
	return s
}

func (s *OSSCompleteFileRequest) SetDriveId(v string) *OSSCompleteFileRequest {
	s.DriveId = &v
	return s
}

func (s *OSSCompleteFileRequest) SetPartInfoList(v []*UploadPartInfo) *OSSCompleteFileRequest {
	s.PartInfoList = v
	return s
}

func (s *OSSCompleteFileRequest) SetUploadId(v string) *OSSCompleteFileRequest {
	s.UploadId = &v
	return s
}

func (s *OSSCompleteFileRequest) SetFilePath(v string) *OSSCompleteFileRequest {
	s.FilePath = &v
	return s
}

func (s *OSSCompleteFileRequest) SetShareId(v string) *OSSCompleteFileRequest {
	s.ShareId = &v
	return s
}

type OSSCompleteFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSCompleteFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSCompleteFileRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSCompleteFileRequestHeader) SetTraceId(v string) *OSSCompleteFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSCompleteFileRequestHeader) SetDeviceId(v string) *OSSCompleteFileRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSCopyFileRequest struct {
	Header           *OSSCopyFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId          *string                   `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath         *string                   `json:"file_path" xml:"file_path"`
	NewName          *string                   `json:"new_name" xml:"new_name" pattern:"[a-zA-Z0-9.-]{1,1000}"`
	Overwrite        *bool                     `json:"overwrite" xml:"overwrite"`
	ShareId          *string                   `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
	ToDriveId        *string                   `json:"to_drive_id" xml:"to_drive_id" require:"true" pattern:"[0-9]+"`
	ToParentFilePath *string                   `json:"to_parent_file_path" xml:"to_parent_file_path" require:"true"`
	ToShareId        *string                   `json:"to_share_id" xml:"to_share_id"`
}

func (s OSSCopyFileRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSCopyFileRequest) GoString() string {
	return s.String()
}

func (s *OSSCopyFileRequest) SetHeader(v *OSSCopyFileRequestHeader) *OSSCopyFileRequest {
	s.Header = v
	return s
}

func (s *OSSCopyFileRequest) SetDriveId(v string) *OSSCopyFileRequest {
	s.DriveId = &v
	return s
}

func (s *OSSCopyFileRequest) SetFilePath(v string) *OSSCopyFileRequest {
	s.FilePath = &v
	return s
}

func (s *OSSCopyFileRequest) SetNewName(v string) *OSSCopyFileRequest {
	s.NewName = &v
	return s
}

func (s *OSSCopyFileRequest) SetOverwrite(v bool) *OSSCopyFileRequest {
	s.Overwrite = &v
	return s
}

func (s *OSSCopyFileRequest) SetShareId(v string) *OSSCopyFileRequest {
	s.ShareId = &v
	return s
}

func (s *OSSCopyFileRequest) SetToDriveId(v string) *OSSCopyFileRequest {
	s.ToDriveId = &v
	return s
}

func (s *OSSCopyFileRequest) SetToParentFilePath(v string) *OSSCopyFileRequest {
	s.ToParentFilePath = &v
	return s
}

func (s *OSSCopyFileRequest) SetToShareId(v string) *OSSCopyFileRequest {
	s.ToShareId = &v
	return s
}

type OSSCopyFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSCopyFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSCopyFileRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSCopyFileRequestHeader) SetTraceId(v string) *OSSCopyFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSCopyFileRequestHeader) SetDeviceId(v string) *OSSCopyFileRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSCreateFileRequest struct {
	Header         *OSSCreateFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	ContentMd5     *string                     `json:"content_md5" xml:"content_md5"`
	ContentType    *string                     `json:"content_type" xml:"content_type"`
	Name           *string                     `json:"name" xml:"name"`
	PartInfoList   []*UploadPartInfo           `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	Size           *int64                      `json:"size" xml:"size"`
	Type           *string                     `json:"type" xml:"type"`
	DriveId        *string                     `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ParentFilePath *string                     `json:"parent_file_path" xml:"parent_file_path"`
	ShareId        *string                     `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
}

func (s OSSCreateFileRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSCreateFileRequest) GoString() string {
	return s.String()
}

func (s *OSSCreateFileRequest) SetHeader(v *OSSCreateFileRequestHeader) *OSSCreateFileRequest {
	s.Header = v
	return s
}

func (s *OSSCreateFileRequest) SetContentMd5(v string) *OSSCreateFileRequest {
	s.ContentMd5 = &v
	return s
}

func (s *OSSCreateFileRequest) SetContentType(v string) *OSSCreateFileRequest {
	s.ContentType = &v
	return s
}

func (s *OSSCreateFileRequest) SetName(v string) *OSSCreateFileRequest {
	s.Name = &v
	return s
}

func (s *OSSCreateFileRequest) SetPartInfoList(v []*UploadPartInfo) *OSSCreateFileRequest {
	s.PartInfoList = v
	return s
}

func (s *OSSCreateFileRequest) SetSize(v int64) *OSSCreateFileRequest {
	s.Size = &v
	return s
}

func (s *OSSCreateFileRequest) SetType(v string) *OSSCreateFileRequest {
	s.Type = &v
	return s
}

func (s *OSSCreateFileRequest) SetDriveId(v string) *OSSCreateFileRequest {
	s.DriveId = &v
	return s
}

func (s *OSSCreateFileRequest) SetParentFilePath(v string) *OSSCreateFileRequest {
	s.ParentFilePath = &v
	return s
}

func (s *OSSCreateFileRequest) SetShareId(v string) *OSSCreateFileRequest {
	s.ShareId = &v
	return s
}

type OSSCreateFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSCreateFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSCreateFileRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSCreateFileRequestHeader) SetTraceId(v string) *OSSCreateFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSCreateFileRequestHeader) SetDeviceId(v string) *OSSCreateFileRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSDeleteFileRequest struct {
	Header      *OSSDeleteFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId     *string                     `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath    *string                     `json:"file_path" xml:"file_path" require:"true" maxLength:"1000"`
	Permanently *bool                       `json:"permanently" xml:"permanently"`
	ShareId     *string                     `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
}

func (s OSSDeleteFileRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSDeleteFileRequest) GoString() string {
	return s.String()
}

func (s *OSSDeleteFileRequest) SetHeader(v *OSSDeleteFileRequestHeader) *OSSDeleteFileRequest {
	s.Header = v
	return s
}

func (s *OSSDeleteFileRequest) SetDriveId(v string) *OSSDeleteFileRequest {
	s.DriveId = &v
	return s
}

func (s *OSSDeleteFileRequest) SetFilePath(v string) *OSSDeleteFileRequest {
	s.FilePath = &v
	return s
}

func (s *OSSDeleteFileRequest) SetPermanently(v bool) *OSSDeleteFileRequest {
	s.Permanently = &v
	return s
}

func (s *OSSDeleteFileRequest) SetShareId(v string) *OSSDeleteFileRequest {
	s.ShareId = &v
	return s
}

type OSSDeleteFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSDeleteFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSDeleteFileRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSDeleteFileRequestHeader) SetTraceId(v string) *OSSDeleteFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSDeleteFileRequestHeader) SetDeviceId(v string) *OSSDeleteFileRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSGetDownloadUrlRequest struct {
	Header    *OSSGetDownloadUrlRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId   *string                         `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ExpireSec *int64                          `json:"expire_sec" xml:"expire_sec"`
	FileName  *string                         `json:"file_name" xml:"file_name"`
	FilePath  *string                         `json:"file_path" xml:"file_path" require:"true" maxLength:"1000"`
	ShareId   *string                         `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
}

func (s OSSGetDownloadUrlRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSGetDownloadUrlRequest) GoString() string {
	return s.String()
}

func (s *OSSGetDownloadUrlRequest) SetHeader(v *OSSGetDownloadUrlRequestHeader) *OSSGetDownloadUrlRequest {
	s.Header = v
	return s
}

func (s *OSSGetDownloadUrlRequest) SetDriveId(v string) *OSSGetDownloadUrlRequest {
	s.DriveId = &v
	return s
}

func (s *OSSGetDownloadUrlRequest) SetExpireSec(v int64) *OSSGetDownloadUrlRequest {
	s.ExpireSec = &v
	return s
}

func (s *OSSGetDownloadUrlRequest) SetFileName(v string) *OSSGetDownloadUrlRequest {
	s.FileName = &v
	return s
}

func (s *OSSGetDownloadUrlRequest) SetFilePath(v string) *OSSGetDownloadUrlRequest {
	s.FilePath = &v
	return s
}

func (s *OSSGetDownloadUrlRequest) SetShareId(v string) *OSSGetDownloadUrlRequest {
	s.ShareId = &v
	return s
}

type OSSGetDownloadUrlRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSGetDownloadUrlRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSGetDownloadUrlRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSGetDownloadUrlRequestHeader) SetTraceId(v string) *OSSGetDownloadUrlRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSGetDownloadUrlRequestHeader) SetDeviceId(v string) *OSSGetDownloadUrlRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSGetFileRequest struct {
	Header                *OSSGetFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId               *string                  `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath              *string                  `json:"file_path" xml:"file_path" require:"true" maxLength:"1000"`
	ImageThumbnailProcess *string                  `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string                  `json:"image_url_process" xml:"image_url_process"`
	ShareId               *string                  `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
	UrlExpireSec          *int64                   `json:"url_expire_sec" xml:"url_expire_sec"`
}

func (s OSSGetFileRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSGetFileRequest) GoString() string {
	return s.String()
}

func (s *OSSGetFileRequest) SetHeader(v *OSSGetFileRequestHeader) *OSSGetFileRequest {
	s.Header = v
	return s
}

func (s *OSSGetFileRequest) SetDriveId(v string) *OSSGetFileRequest {
	s.DriveId = &v
	return s
}

func (s *OSSGetFileRequest) SetFilePath(v string) *OSSGetFileRequest {
	s.FilePath = &v
	return s
}

func (s *OSSGetFileRequest) SetImageThumbnailProcess(v string) *OSSGetFileRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *OSSGetFileRequest) SetImageUrlProcess(v string) *OSSGetFileRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *OSSGetFileRequest) SetShareId(v string) *OSSGetFileRequest {
	s.ShareId = &v
	return s
}

func (s *OSSGetFileRequest) SetUrlExpireSec(v int64) *OSSGetFileRequest {
	s.UrlExpireSec = &v
	return s
}

type OSSGetFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSGetFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSGetFileRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSGetFileRequestHeader) SetTraceId(v string) *OSSGetFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSGetFileRequestHeader) SetDeviceId(v string) *OSSGetFileRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSGetSecureUrlRequest struct {
	Header    *OSSGetSecureUrlRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId   *string                       `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ExpireSec *int64                        `json:"expire_sec" xml:"expire_sec"`
	FilePath  *string                       `json:"file_path" xml:"file_path" require:"true" maxLength:"1000"`
	SecureIp  *string                       `json:"secure_ip" xml:"secure_ip"`
	ShareId   *string                       `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
}

func (s OSSGetSecureUrlRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSGetSecureUrlRequest) GoString() string {
	return s.String()
}

func (s *OSSGetSecureUrlRequest) SetHeader(v *OSSGetSecureUrlRequestHeader) *OSSGetSecureUrlRequest {
	s.Header = v
	return s
}

func (s *OSSGetSecureUrlRequest) SetDriveId(v string) *OSSGetSecureUrlRequest {
	s.DriveId = &v
	return s
}

func (s *OSSGetSecureUrlRequest) SetExpireSec(v int64) *OSSGetSecureUrlRequest {
	s.ExpireSec = &v
	return s
}

func (s *OSSGetSecureUrlRequest) SetFilePath(v string) *OSSGetSecureUrlRequest {
	s.FilePath = &v
	return s
}

func (s *OSSGetSecureUrlRequest) SetSecureIp(v string) *OSSGetSecureUrlRequest {
	s.SecureIp = &v
	return s
}

func (s *OSSGetSecureUrlRequest) SetShareId(v string) *OSSGetSecureUrlRequest {
	s.ShareId = &v
	return s
}

type OSSGetSecureUrlRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSGetSecureUrlRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSGetSecureUrlRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSGetSecureUrlRequestHeader) SetTraceId(v string) *OSSGetSecureUrlRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSGetSecureUrlRequestHeader) SetDeviceId(v string) *OSSGetSecureUrlRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSGetSecureUrlResponse struct {
	RequestId  *string `json:"requestId" xml:"requestId"`
	Expiration *string `json:"expiration" xml:"expiration"`
	Url        *string `json:"url" xml:"url"`
}

func (s OSSGetSecureUrlResponse) String() string {
	return tea.Prettify(s)
}

func (s OSSGetSecureUrlResponse) GoString() string {
	return s.String()
}

func (s *OSSGetSecureUrlResponse) SetRequestId(v string) *OSSGetSecureUrlResponse {
	s.RequestId = &v
	return s
}

func (s *OSSGetSecureUrlResponse) SetExpiration(v string) *OSSGetSecureUrlResponse {
	s.Expiration = &v
	return s
}

func (s *OSSGetSecureUrlResponse) SetUrl(v string) *OSSGetSecureUrlResponse {
	s.Url = &v
	return s
}

type OSSGetUploadUrlRequest struct {
	Header       *OSSGetUploadUrlRequestHeader `json:"header" xml:"header" type:"Struct"`
	ContentMd5   *string                       `json:"content_md5" xml:"content_md5" maxLength:"32"`
	DriveId      *string                       `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	PartInfoList []*UploadPartInfo             `json:"part_info_list" xml:"part_info_list" type:"Repeated"`
	UploadId     *string                       `json:"upload_id" xml:"upload_id"`
	FilePath     *string                       `json:"file_path" xml:"file_path"`
	ShareId      *string                       `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
}

func (s OSSGetUploadUrlRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSGetUploadUrlRequest) GoString() string {
	return s.String()
}

func (s *OSSGetUploadUrlRequest) SetHeader(v *OSSGetUploadUrlRequestHeader) *OSSGetUploadUrlRequest {
	s.Header = v
	return s
}

func (s *OSSGetUploadUrlRequest) SetContentMd5(v string) *OSSGetUploadUrlRequest {
	s.ContentMd5 = &v
	return s
}

func (s *OSSGetUploadUrlRequest) SetDriveId(v string) *OSSGetUploadUrlRequest {
	s.DriveId = &v
	return s
}

func (s *OSSGetUploadUrlRequest) SetPartInfoList(v []*UploadPartInfo) *OSSGetUploadUrlRequest {
	s.PartInfoList = v
	return s
}

func (s *OSSGetUploadUrlRequest) SetUploadId(v string) *OSSGetUploadUrlRequest {
	s.UploadId = &v
	return s
}

func (s *OSSGetUploadUrlRequest) SetFilePath(v string) *OSSGetUploadUrlRequest {
	s.FilePath = &v
	return s
}

func (s *OSSGetUploadUrlRequest) SetShareId(v string) *OSSGetUploadUrlRequest {
	s.ShareId = &v
	return s
}

type OSSGetUploadUrlRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSGetUploadUrlRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSGetUploadUrlRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSGetUploadUrlRequestHeader) SetTraceId(v string) *OSSGetUploadUrlRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSGetUploadUrlRequestHeader) SetDeviceId(v string) *OSSGetUploadUrlRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSListFileRequest struct {
	Header                *OSSListFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId               *string                   `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ImageThumbnailProcess *string                   `json:"image_thumbnail_process" xml:"image_thumbnail_process"`
	ImageUrlProcess       *string                   `json:"image_url_process" xml:"image_url_process"`
	Limit                 *int64                    `json:"limit" xml:"limit" pattern:"[0-9]{1,3}"`
	Marker                *string                   `json:"marker" xml:"marker"`
	ParentFilePath        *string                   `json:"parent_file_path" xml:"parent_file_path" require:"true"`
	ShareId               *string                   `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
	UrlExpireSec          *int64                    `json:"url_expire_sec" xml:"url_expire_sec"`
	VideoThumbnailProcess *string                   `json:"video_thumbnail_process" xml:"video_thumbnail_process"`
}

func (s OSSListFileRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSListFileRequest) GoString() string {
	return s.String()
}

func (s *OSSListFileRequest) SetHeader(v *OSSListFileRequestHeader) *OSSListFileRequest {
	s.Header = v
	return s
}

func (s *OSSListFileRequest) SetDriveId(v string) *OSSListFileRequest {
	s.DriveId = &v
	return s
}

func (s *OSSListFileRequest) SetImageThumbnailProcess(v string) *OSSListFileRequest {
	s.ImageThumbnailProcess = &v
	return s
}

func (s *OSSListFileRequest) SetImageUrlProcess(v string) *OSSListFileRequest {
	s.ImageUrlProcess = &v
	return s
}

func (s *OSSListFileRequest) SetLimit(v int64) *OSSListFileRequest {
	s.Limit = &v
	return s
}

func (s *OSSListFileRequest) SetMarker(v string) *OSSListFileRequest {
	s.Marker = &v
	return s
}

func (s *OSSListFileRequest) SetParentFilePath(v string) *OSSListFileRequest {
	s.ParentFilePath = &v
	return s
}

func (s *OSSListFileRequest) SetShareId(v string) *OSSListFileRequest {
	s.ShareId = &v
	return s
}

func (s *OSSListFileRequest) SetUrlExpireSec(v int64) *OSSListFileRequest {
	s.UrlExpireSec = &v
	return s
}

func (s *OSSListFileRequest) SetVideoThumbnailProcess(v string) *OSSListFileRequest {
	s.VideoThumbnailProcess = &v
	return s
}

type OSSListFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSListFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSListFileRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSListFileRequestHeader) SetTraceId(v string) *OSSListFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSListFileRequestHeader) SetDeviceId(v string) *OSSListFileRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSListUploadedPartRequest struct {
	Header           *OSSListUploadedPartRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId          *string                           `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath         *string                           `json:"file_path" xml:"file_path" require:"true"`
	Limit            *int64                            `json:"limit" xml:"limit" require:"true" pattern:"[0-9]+"`
	PartNumberMarker *int64                            `json:"part_number_marker" xml:"part_number_marker" pattern:"[0-9]+"`
	ShareId          *string                           `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
	UploadId         *string                           `json:"upload_id" xml:"upload_id"`
}

func (s OSSListUploadedPartRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSListUploadedPartRequest) GoString() string {
	return s.String()
}

func (s *OSSListUploadedPartRequest) SetHeader(v *OSSListUploadedPartRequestHeader) *OSSListUploadedPartRequest {
	s.Header = v
	return s
}

func (s *OSSListUploadedPartRequest) SetDriveId(v string) *OSSListUploadedPartRequest {
	s.DriveId = &v
	return s
}

func (s *OSSListUploadedPartRequest) SetFilePath(v string) *OSSListUploadedPartRequest {
	s.FilePath = &v
	return s
}

func (s *OSSListUploadedPartRequest) SetLimit(v int64) *OSSListUploadedPartRequest {
	s.Limit = &v
	return s
}

func (s *OSSListUploadedPartRequest) SetPartNumberMarker(v int64) *OSSListUploadedPartRequest {
	s.PartNumberMarker = &v
	return s
}

func (s *OSSListUploadedPartRequest) SetShareId(v string) *OSSListUploadedPartRequest {
	s.ShareId = &v
	return s
}

func (s *OSSListUploadedPartRequest) SetUploadId(v string) *OSSListUploadedPartRequest {
	s.UploadId = &v
	return s
}

type OSSListUploadedPartRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSListUploadedPartRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSListUploadedPartRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSListUploadedPartRequestHeader) SetTraceId(v string) *OSSListUploadedPartRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSListUploadedPartRequestHeader) SetDeviceId(v string) *OSSListUploadedPartRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSMoveFileRequest struct {
	Header           *OSSMoveFileRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId          *string                   `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath         *string                   `json:"file_path" xml:"file_path"`
	NewName          *string                   `json:"new_name" xml:"new_name" require:"true"`
	Overwrite        *bool                     `json:"overwrite" xml:"overwrite"`
	ShareId          *string                   `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
	ToParentFilePath *string                   `json:"to_parent_file_path" xml:"to_parent_file_path"`
}

func (s OSSMoveFileRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSMoveFileRequest) GoString() string {
	return s.String()
}

func (s *OSSMoveFileRequest) SetHeader(v *OSSMoveFileRequestHeader) *OSSMoveFileRequest {
	s.Header = v
	return s
}

func (s *OSSMoveFileRequest) SetDriveId(v string) *OSSMoveFileRequest {
	s.DriveId = &v
	return s
}

func (s *OSSMoveFileRequest) SetFilePath(v string) *OSSMoveFileRequest {
	s.FilePath = &v
	return s
}

func (s *OSSMoveFileRequest) SetNewName(v string) *OSSMoveFileRequest {
	s.NewName = &v
	return s
}

func (s *OSSMoveFileRequest) SetOverwrite(v bool) *OSSMoveFileRequest {
	s.Overwrite = &v
	return s
}

func (s *OSSMoveFileRequest) SetShareId(v string) *OSSMoveFileRequest {
	s.ShareId = &v
	return s
}

func (s *OSSMoveFileRequest) SetToParentFilePath(v string) *OSSMoveFileRequest {
	s.ToParentFilePath = &v
	return s
}

type OSSMoveFileRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSMoveFileRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSMoveFileRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSMoveFileRequestHeader) SetTraceId(v string) *OSSMoveFileRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSMoveFileRequestHeader) SetDeviceId(v string) *OSSMoveFileRequestHeader {
	s.DeviceId = &v
	return s
}

type OSSVideoM3U8Request struct {
	Header    *OSSVideoM3U8RequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId   *string                    `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	ExpireSec *int64                     `json:"expire_sec" xml:"expire_sec"`
	FilePath  *string                    `json:"file_path" xml:"file_path" require:"true" maxLength:"1000"`
	ShareId   *string                    `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
	SignToken *string                    `json:"sign_token" xml:"sign_token" require:"true"`
}

func (s OSSVideoM3U8Request) String() string {
	return tea.Prettify(s)
}

func (s OSSVideoM3U8Request) GoString() string {
	return s.String()
}

func (s *OSSVideoM3U8Request) SetHeader(v *OSSVideoM3U8RequestHeader) *OSSVideoM3U8Request {
	s.Header = v
	return s
}

func (s *OSSVideoM3U8Request) SetDriveId(v string) *OSSVideoM3U8Request {
	s.DriveId = &v
	return s
}

func (s *OSSVideoM3U8Request) SetExpireSec(v int64) *OSSVideoM3U8Request {
	s.ExpireSec = &v
	return s
}

func (s *OSSVideoM3U8Request) SetFilePath(v string) *OSSVideoM3U8Request {
	s.FilePath = &v
	return s
}

func (s *OSSVideoM3U8Request) SetShareId(v string) *OSSVideoM3U8Request {
	s.ShareId = &v
	return s
}

func (s *OSSVideoM3U8Request) SetSignToken(v string) *OSSVideoM3U8Request {
	s.SignToken = &v
	return s
}

type OSSVideoM3U8RequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSVideoM3U8RequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSVideoM3U8RequestHeader) GoString() string {
	return s.String()
}

func (s *OSSVideoM3U8RequestHeader) SetTraceId(v string) *OSSVideoM3U8RequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSVideoM3U8RequestHeader) SetDeviceId(v string) *OSSVideoM3U8RequestHeader {
	s.DeviceId = &v
	return s
}

type OSSVideoTranscodeRequest struct {
	Header   *OSSVideoTranscodeRequestHeader `json:"header" xml:"header" type:"Struct"`
	DriveId  *string                         `json:"drive_id" xml:"drive_id" pattern:"[0-9]+"`
	FilePath *string                         `json:"file_path" xml:"file_path" require:"true" maxLength:"1000"`
	ShareId  *string                         `json:"share_id" xml:"share_id" pattern:"[0-9a-zA-Z-]+"`
}

func (s OSSVideoTranscodeRequest) String() string {
	return tea.Prettify(s)
}

func (s OSSVideoTranscodeRequest) GoString() string {
	return s.String()
}

func (s *OSSVideoTranscodeRequest) SetHeader(v *OSSVideoTranscodeRequestHeader) *OSSVideoTranscodeRequest {
	s.Header = v
	return s
}

func (s *OSSVideoTranscodeRequest) SetDriveId(v string) *OSSVideoTranscodeRequest {
	s.DriveId = &v
	return s
}

func (s *OSSVideoTranscodeRequest) SetFilePath(v string) *OSSVideoTranscodeRequest {
	s.FilePath = &v
	return s
}

func (s *OSSVideoTranscodeRequest) SetShareId(v string) *OSSVideoTranscodeRequest {
	s.ShareId = &v
	return s
}

type OSSVideoTranscodeRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s OSSVideoTranscodeRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s OSSVideoTranscodeRequestHeader) GoString() string {
	return s.String()
}

func (s *OSSVideoTranscodeRequestHeader) SetTraceId(v string) *OSSVideoTranscodeRequestHeader {
	s.TraceId = &v
	return s
}

func (s *OSSVideoTranscodeRequestHeader) SetDeviceId(v string) *OSSVideoTranscodeRequestHeader {
	s.DeviceId = &v
	return s
}

type SharePermissionPolicy struct {
	FilePath              *string   `json:"file_path" xml:"file_path"`
	PermissionInheritable *bool     `json:"permission_inheritable" xml:"permission_inheritable"`
	PermissionList        []*string `json:"permission_list" xml:"permission_list" type:"Repeated"`
	PermissionType        *string   `json:"permission_type" xml:"permission_type"`
}

func (s SharePermissionPolicy) String() string {
	return tea.Prettify(s)
}

func (s SharePermissionPolicy) GoString() string {
	return s.String()
}

func (s *SharePermissionPolicy) SetFilePath(v string) *SharePermissionPolicy {
	s.FilePath = &v
	return s
}

func (s *SharePermissionPolicy) SetPermissionInheritable(v bool) *SharePermissionPolicy {
	s.PermissionInheritable = &v
	return s
}

func (s *SharePermissionPolicy) SetPermissionList(v []*string) *SharePermissionPolicy {
	s.PermissionList = v
	return s
}

func (s *SharePermissionPolicy) SetPermissionType(v string) *SharePermissionPolicy {
	s.PermissionType = &v
	return s
}

type UCGetObjectInfoByObjectKeyRequest struct {
	Header    *UCGetObjectInfoByObjectKeyRequestHeader `json:"header" xml:"header" type:"Struct"`
	ObjectKey *string                                  `json:"object_key" xml:"object_key"`
}

func (s UCGetObjectInfoByObjectKeyRequest) String() string {
	return tea.Prettify(s)
}

func (s UCGetObjectInfoByObjectKeyRequest) GoString() string {
	return s.String()
}

func (s *UCGetObjectInfoByObjectKeyRequest) SetHeader(v *UCGetObjectInfoByObjectKeyRequestHeader) *UCGetObjectInfoByObjectKeyRequest {
	s.Header = v
	return s
}

func (s *UCGetObjectInfoByObjectKeyRequest) SetObjectKey(v string) *UCGetObjectInfoByObjectKeyRequest {
	s.ObjectKey = &v
	return s
}

type UCGetObjectInfoByObjectKeyRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s UCGetObjectInfoByObjectKeyRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UCGetObjectInfoByObjectKeyRequestHeader) GoString() string {
	return s.String()
}

func (s *UCGetObjectInfoByObjectKeyRequestHeader) SetTraceId(v string) *UCGetObjectInfoByObjectKeyRequestHeader {
	s.TraceId = &v
	return s
}

func (s *UCGetObjectInfoByObjectKeyRequestHeader) SetDeviceId(v string) *UCGetObjectInfoByObjectKeyRequestHeader {
	s.DeviceId = &v
	return s
}

type UCGetObjectInfoBySha1Request struct {
	Header *UCGetObjectInfoBySha1RequestHeader `json:"header" xml:"header" type:"Struct"`
	Sha1   *string                             `json:"sha1" xml:"sha1"`
}

func (s UCGetObjectInfoBySha1Request) String() string {
	return tea.Prettify(s)
}

func (s UCGetObjectInfoBySha1Request) GoString() string {
	return s.String()
}

func (s *UCGetObjectInfoBySha1Request) SetHeader(v *UCGetObjectInfoBySha1RequestHeader) *UCGetObjectInfoBySha1Request {
	s.Header = v
	return s
}

func (s *UCGetObjectInfoBySha1Request) SetSha1(v string) *UCGetObjectInfoBySha1Request {
	s.Sha1 = &v
	return s
}

type UCGetObjectInfoBySha1RequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s UCGetObjectInfoBySha1RequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UCGetObjectInfoBySha1RequestHeader) GoString() string {
	return s.String()
}

func (s *UCGetObjectInfoBySha1RequestHeader) SetTraceId(v string) *UCGetObjectInfoBySha1RequestHeader {
	s.TraceId = &v
	return s
}

func (s *UCGetObjectInfoBySha1RequestHeader) SetDeviceId(v string) *UCGetObjectInfoBySha1RequestHeader {
	s.DeviceId = &v
	return s
}

type UpdateDriveRequest struct {
	Header            *UpdateDriveRequestHeader `json:"header" xml:"header" type:"Struct"`
	Description       *string                   `json:"description" xml:"description"`
	DriveId           *string                   `json:"drive_id" xml:"drive_id" require:"true"`
	DriveName         *string                   `json:"drive_name" xml:"drive_name"`
	EncryptDataAccess *bool                     `json:"encrypt_data_access" xml:"encrypt_data_access"`
	EncryptMode       *string                   `json:"encrypt_mode" xml:"encrypt_mode"`
	Status            *string                   `json:"status" xml:"status"`
	TotalSize         *int64                    `json:"total_size" xml:"total_size"`
}

func (s UpdateDriveRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateDriveRequest) GoString() string {
	return s.String()
}

func (s *UpdateDriveRequest) SetHeader(v *UpdateDriveRequestHeader) *UpdateDriveRequest {
	s.Header = v
	return s
}

func (s *UpdateDriveRequest) SetDescription(v string) *UpdateDriveRequest {
	s.Description = &v
	return s
}

func (s *UpdateDriveRequest) SetDriveId(v string) *UpdateDriveRequest {
	s.DriveId = &v
	return s
}

func (s *UpdateDriveRequest) SetDriveName(v string) *UpdateDriveRequest {
	s.DriveName = &v
	return s
}

func (s *UpdateDriveRequest) SetEncryptDataAccess(v bool) *UpdateDriveRequest {
	s.EncryptDataAccess = &v
	return s
}

func (s *UpdateDriveRequest) SetEncryptMode(v string) *UpdateDriveRequest {
	s.EncryptMode = &v
	return s
}

func (s *UpdateDriveRequest) SetStatus(v string) *UpdateDriveRequest {
	s.Status = &v
	return s
}

func (s *UpdateDriveRequest) SetTotalSize(v int64) *UpdateDriveRequest {
	s.TotalSize = &v
	return s
}

type UpdateDriveRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s UpdateDriveRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UpdateDriveRequestHeader) GoString() string {
	return s.String()
}

func (s *UpdateDriveRequestHeader) SetTraceId(v string) *UpdateDriveRequestHeader {
	s.TraceId = &v
	return s
}

func (s *UpdateDriveRequestHeader) SetDeviceId(v string) *UpdateDriveRequestHeader {
	s.DeviceId = &v
	return s
}

type UpdateFileMetaRequest struct {
	Header      *UpdateFileMetaRequestHeader `json:"header" xml:"header" type:"Struct"`
	Description *string                      `json:"description" xml:"description" maxLength:"1000"`
	DriveId     *string                      `json:"drive_id" xml:"drive_id" require:"true" pattern:"[0-9]+"`
	FileId      *string                      `json:"file_id" xml:"file_id" require:"true" maxLength:"50" pattern:"[a-z0-9.-_]{1,50}"`
	Hidden      *bool                        `json:"hidden" xml:"hidden"`
	Meta        *string                      `json:"meta" xml:"meta"`
	Name        *string                      `json:"name" xml:"name" require:"true" pattern:"[a-zA-Z0-9.-]{1,1000}"`
	ShareId     *string                      `json:"share_id" xml:"share_id"`
	Starred     *bool                        `json:"starred" xml:"starred"`
	Tags        map[string]interface{}       `json:"tags" xml:"tags"`
}

func (s UpdateFileMetaRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateFileMetaRequest) GoString() string {
	return s.String()
}

func (s *UpdateFileMetaRequest) SetHeader(v *UpdateFileMetaRequestHeader) *UpdateFileMetaRequest {
	s.Header = v
	return s
}

func (s *UpdateFileMetaRequest) SetDescription(v string) *UpdateFileMetaRequest {
	s.Description = &v
	return s
}

func (s *UpdateFileMetaRequest) SetDriveId(v string) *UpdateFileMetaRequest {
	s.DriveId = &v
	return s
}

func (s *UpdateFileMetaRequest) SetFileId(v string) *UpdateFileMetaRequest {
	s.FileId = &v
	return s
}

func (s *UpdateFileMetaRequest) SetHidden(v bool) *UpdateFileMetaRequest {
	s.Hidden = &v
	return s
}

func (s *UpdateFileMetaRequest) SetMeta(v string) *UpdateFileMetaRequest {
	s.Meta = &v
	return s
}

func (s *UpdateFileMetaRequest) SetName(v string) *UpdateFileMetaRequest {
	s.Name = &v
	return s
}

func (s *UpdateFileMetaRequest) SetShareId(v string) *UpdateFileMetaRequest {
	s.ShareId = &v
	return s
}

func (s *UpdateFileMetaRequest) SetStarred(v bool) *UpdateFileMetaRequest {
	s.Starred = &v
	return s
}

func (s *UpdateFileMetaRequest) SetTags(v map[string]interface{}) *UpdateFileMetaRequest {
	s.Tags = v
	return s
}

type UpdateFileMetaRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s UpdateFileMetaRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UpdateFileMetaRequestHeader) GoString() string {
	return s.String()
}

func (s *UpdateFileMetaRequestHeader) SetTraceId(v string) *UpdateFileMetaRequestHeader {
	s.TraceId = &v
	return s
}

func (s *UpdateFileMetaRequestHeader) SetDeviceId(v string) *UpdateFileMetaRequestHeader {
	s.DeviceId = &v
	return s
}

type UpdateShareRequest struct {
	Header      *UpdateShareRequestHeader `json:"header" xml:"header" type:"Struct"`
	Description *string                   `json:"description" xml:"description" maxLength:"1024"`
	Expiration  *string                   `json:"expiration" xml:"expiration"`
	Permissions []*string                 `json:"permissions" xml:"permissions" type:"Repeated"`
	ShareId     *string                   `json:"share_id" xml:"share_id" require:"true"`
	ShareName   *string                   `json:"share_name" xml:"share_name"`
	SharePolicy []*SharePermissionPolicy  `json:"share_policy" xml:"share_policy" type:"Repeated"`
	Status      *string                   `json:"status" xml:"status"`
}

func (s UpdateShareRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateShareRequest) GoString() string {
	return s.String()
}

func (s *UpdateShareRequest) SetHeader(v *UpdateShareRequestHeader) *UpdateShareRequest {
	s.Header = v
	return s
}

func (s *UpdateShareRequest) SetDescription(v string) *UpdateShareRequest {
	s.Description = &v
	return s
}

func (s *UpdateShareRequest) SetExpiration(v string) *UpdateShareRequest {
	s.Expiration = &v
	return s
}

func (s *UpdateShareRequest) SetPermissions(v []*string) *UpdateShareRequest {
	s.Permissions = v
	return s
}

func (s *UpdateShareRequest) SetShareId(v string) *UpdateShareRequest {
	s.ShareId = &v
	return s
}

func (s *UpdateShareRequest) SetShareName(v string) *UpdateShareRequest {
	s.ShareName = &v
	return s
}

func (s *UpdateShareRequest) SetSharePolicy(v []*SharePermissionPolicy) *UpdateShareRequest {
	s.SharePolicy = v
	return s
}

func (s *UpdateShareRequest) SetStatus(v string) *UpdateShareRequest {
	s.Status = &v
	return s
}

type UpdateShareRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s UpdateShareRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UpdateShareRequestHeader) GoString() string {
	return s.String()
}

func (s *UpdateShareRequestHeader) SetTraceId(v string) *UpdateShareRequestHeader {
	s.TraceId = &v
	return s
}

func (s *UpdateShareRequestHeader) SetDeviceId(v string) *UpdateShareRequestHeader {
	s.DeviceId = &v
	return s
}

type VideoMediaResponse struct {
	RequestId   *string `json:"requestId" xml:"requestId"`
	AddressLine *string `json:"address_line" xml:"address_line"`
	City        *string `json:"city" xml:"city"`
	Country     *string `json:"country" xml:"country"`
	District    *string `json:"district" xml:"district"`
	Duration    *string `json:"duration" xml:"duration"`
	Location    *string `json:"location" xml:"location"`
	Province    *string `json:"province" xml:"province"`
	Time        *string `json:"time" xml:"time"`
	Township    *string `json:"township" xml:"township"`
}

func (s VideoMediaResponse) String() string {
	return tea.Prettify(s)
}

func (s VideoMediaResponse) GoString() string {
	return s.String()
}

func (s *VideoMediaResponse) SetRequestId(v string) *VideoMediaResponse {
	s.RequestId = &v
	return s
}

func (s *VideoMediaResponse) SetAddressLine(v string) *VideoMediaResponse {
	s.AddressLine = &v
	return s
}

func (s *VideoMediaResponse) SetCity(v string) *VideoMediaResponse {
	s.City = &v
	return s
}

func (s *VideoMediaResponse) SetCountry(v string) *VideoMediaResponse {
	s.Country = &v
	return s
}

func (s *VideoMediaResponse) SetDistrict(v string) *VideoMediaResponse {
	s.District = &v
	return s
}

func (s *VideoMediaResponse) SetDuration(v string) *VideoMediaResponse {
	s.Duration = &v
	return s
}

func (s *VideoMediaResponse) SetLocation(v string) *VideoMediaResponse {
	s.Location = &v
	return s
}

func (s *VideoMediaResponse) SetProvince(v string) *VideoMediaResponse {
	s.Province = &v
	return s
}

func (s *VideoMediaResponse) SetTime(v string) *VideoMediaResponse {
	s.Time = &v
	return s
}

func (s *VideoMediaResponse) SetTownship(v string) *VideoMediaResponse {
	s.Township = &v
	return s
}

type BaseUserResponse struct {
	RequestId      *string `json:"requestId" xml:"requestId"`
	Avatar         *string `json:"avatar" xml:"avatar"`
	CreatedAt      *int64  `json:"created_at" xml:"created_at"`
	DefaultDriveId *string `json:"default_drive_id" xml:"default_drive_id"`
	Description    *string `json:"description" xml:"description"`
	DomainId       *string `json:"domain_id" xml:"domain_id"`
	Email          *string `json:"email" xml:"email"`
	NickName       *string `json:"nick_name" xml:"nick_name"`
	Phone          *string `json:"phone" xml:"phone"`
	Role           *string `json:"role" xml:"role"`
	Status         *string `json:"status" xml:"status"`
	UpdatedAt      *int64  `json:"updated_at" xml:"updated_at"`
	UserId         *string `json:"user_id" xml:"user_id"`
	UserName       *string `json:"user_name" xml:"user_name"`
}

func (s BaseUserResponse) String() string {
	return tea.Prettify(s)
}

func (s BaseUserResponse) GoString() string {
	return s.String()
}

func (s *BaseUserResponse) SetRequestId(v string) *BaseUserResponse {
	s.RequestId = &v
	return s
}

func (s *BaseUserResponse) SetAvatar(v string) *BaseUserResponse {
	s.Avatar = &v
	return s
}

func (s *BaseUserResponse) SetCreatedAt(v int64) *BaseUserResponse {
	s.CreatedAt = &v
	return s
}

func (s *BaseUserResponse) SetDefaultDriveId(v string) *BaseUserResponse {
	s.DefaultDriveId = &v
	return s
}

func (s *BaseUserResponse) SetDescription(v string) *BaseUserResponse {
	s.Description = &v
	return s
}

func (s *BaseUserResponse) SetDomainId(v string) *BaseUserResponse {
	s.DomainId = &v
	return s
}

func (s *BaseUserResponse) SetEmail(v string) *BaseUserResponse {
	s.Email = &v
	return s
}

func (s *BaseUserResponse) SetNickName(v string) *BaseUserResponse {
	s.NickName = &v
	return s
}

func (s *BaseUserResponse) SetPhone(v string) *BaseUserResponse {
	s.Phone = &v
	return s
}

func (s *BaseUserResponse) SetRole(v string) *BaseUserResponse {
	s.Role = &v
	return s
}

func (s *BaseUserResponse) SetStatus(v string) *BaseUserResponse {
	s.Status = &v
	return s
}

func (s *BaseUserResponse) SetUpdatedAt(v int64) *BaseUserResponse {
	s.UpdatedAt = &v
	return s
}

func (s *BaseUserResponse) SetUserId(v string) *BaseUserResponse {
	s.UserId = &v
	return s
}

func (s *BaseUserResponse) SetUserName(v string) *BaseUserResponse {
	s.UserName = &v
	return s
}

type CreateUserRequest struct {
	Header      *CreateUserRequestHeader `json:"header" xml:"header" type:"Struct"`
	Avatar      *string                  `json:"avatar" xml:"avatar"`
	Description *string                  `json:"description" xml:"description"`
	Email       *string                  `json:"email" xml:"email"`
	NickName    *string                  `json:"nick_name" xml:"nick_name"`
	Phone       *string                  `json:"phone" xml:"phone"`
	Role        *string                  `json:"role" xml:"role"`
	Status      *string                  `json:"status" xml:"status"`
	UserId      *string                  `json:"user_id" xml:"user_id" require:"true"`
	UserName    *string                  `json:"user_name" xml:"user_name"`
}

func (s CreateUserRequest) String() string {
	return tea.Prettify(s)
}

func (s CreateUserRequest) GoString() string {
	return s.String()
}

func (s *CreateUserRequest) SetHeader(v *CreateUserRequestHeader) *CreateUserRequest {
	s.Header = v
	return s
}

func (s *CreateUserRequest) SetAvatar(v string) *CreateUserRequest {
	s.Avatar = &v
	return s
}

func (s *CreateUserRequest) SetDescription(v string) *CreateUserRequest {
	s.Description = &v
	return s
}

func (s *CreateUserRequest) SetEmail(v string) *CreateUserRequest {
	s.Email = &v
	return s
}

func (s *CreateUserRequest) SetNickName(v string) *CreateUserRequest {
	s.NickName = &v
	return s
}

func (s *CreateUserRequest) SetPhone(v string) *CreateUserRequest {
	s.Phone = &v
	return s
}

func (s *CreateUserRequest) SetRole(v string) *CreateUserRequest {
	s.Role = &v
	return s
}

func (s *CreateUserRequest) SetStatus(v string) *CreateUserRequest {
	s.Status = &v
	return s
}

func (s *CreateUserRequest) SetUserId(v string) *CreateUserRequest {
	s.UserId = &v
	return s
}

func (s *CreateUserRequest) SetUserName(v string) *CreateUserRequest {
	s.UserName = &v
	return s
}

type CreateUserRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s CreateUserRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s CreateUserRequestHeader) GoString() string {
	return s.String()
}

func (s *CreateUserRequestHeader) SetTraceId(v string) *CreateUserRequestHeader {
	s.TraceId = &v
	return s
}

func (s *CreateUserRequestHeader) SetDeviceId(v string) *CreateUserRequestHeader {
	s.DeviceId = &v
	return s
}

type CreateUserResponse struct {
	RequestId      *string `json:"requestId" xml:"requestId"`
	Avatar         *string `json:"avatar" xml:"avatar"`
	CreatedAt      *int64  `json:"created_at" xml:"created_at"`
	DefaultDriveId *string `json:"default_drive_id" xml:"default_drive_id"`
	Description    *string `json:"description" xml:"description"`
	DomainId       *string `json:"domain_id" xml:"domain_id"`
	Email          *string `json:"email" xml:"email"`
	NickName       *string `json:"nick_name" xml:"nick_name"`
	Phone          *string `json:"phone" xml:"phone"`
	Role           *string `json:"role" xml:"role"`
	Status         *string `json:"status" xml:"status"`
	UpdatedAt      *int64  `json:"updated_at" xml:"updated_at"`
	UserId         *string `json:"user_id" xml:"user_id"`
	UserName       *string `json:"user_name" xml:"user_name"`
}

func (s CreateUserResponse) String() string {
	return tea.Prettify(s)
}

func (s CreateUserResponse) GoString() string {
	return s.String()
}

func (s *CreateUserResponse) SetRequestId(v string) *CreateUserResponse {
	s.RequestId = &v
	return s
}

func (s *CreateUserResponse) SetAvatar(v string) *CreateUserResponse {
	s.Avatar = &v
	return s
}

func (s *CreateUserResponse) SetCreatedAt(v int64) *CreateUserResponse {
	s.CreatedAt = &v
	return s
}

func (s *CreateUserResponse) SetDefaultDriveId(v string) *CreateUserResponse {
	s.DefaultDriveId = &v
	return s
}

func (s *CreateUserResponse) SetDescription(v string) *CreateUserResponse {
	s.Description = &v
	return s
}

func (s *CreateUserResponse) SetDomainId(v string) *CreateUserResponse {
	s.DomainId = &v
	return s
}

func (s *CreateUserResponse) SetEmail(v string) *CreateUserResponse {
	s.Email = &v
	return s
}

func (s *CreateUserResponse) SetNickName(v string) *CreateUserResponse {
	s.NickName = &v
	return s
}

func (s *CreateUserResponse) SetPhone(v string) *CreateUserResponse {
	s.Phone = &v
	return s
}

func (s *CreateUserResponse) SetRole(v string) *CreateUserResponse {
	s.Role = &v
	return s
}

func (s *CreateUserResponse) SetStatus(v string) *CreateUserResponse {
	s.Status = &v
	return s
}

func (s *CreateUserResponse) SetUpdatedAt(v int64) *CreateUserResponse {
	s.UpdatedAt = &v
	return s
}

func (s *CreateUserResponse) SetUserId(v string) *CreateUserResponse {
	s.UserId = &v
	return s
}

func (s *CreateUserResponse) SetUserName(v string) *CreateUserResponse {
	s.UserName = &v
	return s
}

type DeleteUserRequest struct {
	Header *DeleteUserRequestHeader `json:"header" xml:"header" type:"Struct"`
	UserId *string                  `json:"user_id" xml:"user_id" require:"true"`
}

func (s DeleteUserRequest) String() string {
	return tea.Prettify(s)
}

func (s DeleteUserRequest) GoString() string {
	return s.String()
}

func (s *DeleteUserRequest) SetHeader(v *DeleteUserRequestHeader) *DeleteUserRequest {
	s.Header = v
	return s
}

func (s *DeleteUserRequest) SetUserId(v string) *DeleteUserRequest {
	s.UserId = &v
	return s
}

type DeleteUserRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s DeleteUserRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s DeleteUserRequestHeader) GoString() string {
	return s.String()
}

func (s *DeleteUserRequestHeader) SetTraceId(v string) *DeleteUserRequestHeader {
	s.TraceId = &v
	return s
}

func (s *DeleteUserRequestHeader) SetDeviceId(v string) *DeleteUserRequestHeader {
	s.DeviceId = &v
	return s
}

type DeleteUserResponse struct {
	RequestId *string `json:"requestId" xml:"requestId"`
}

func (s DeleteUserResponse) String() string {
	return tea.Prettify(s)
}

func (s DeleteUserResponse) GoString() string {
	return s.String()
}

func (s *DeleteUserResponse) SetRequestId(v string) *DeleteUserResponse {
	s.RequestId = &v
	return s
}

type GetUserRequest struct {
	Header *GetUserRequestHeader `json:"header" xml:"header" type:"Struct"`
	UserId *string               `json:"user_id" xml:"user_id"`
}

func (s GetUserRequest) String() string {
	return tea.Prettify(s)
}

func (s GetUserRequest) GoString() string {
	return s.String()
}

func (s *GetUserRequest) SetHeader(v *GetUserRequestHeader) *GetUserRequest {
	s.Header = v
	return s
}

func (s *GetUserRequest) SetUserId(v string) *GetUserRequest {
	s.UserId = &v
	return s
}

type GetUserRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s GetUserRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s GetUserRequestHeader) GoString() string {
	return s.String()
}

func (s *GetUserRequestHeader) SetTraceId(v string) *GetUserRequestHeader {
	s.TraceId = &v
	return s
}

func (s *GetUserRequestHeader) SetDeviceId(v string) *GetUserRequestHeader {
	s.DeviceId = &v
	return s
}

type GetUserResponse struct {
	RequestId      *string `json:"requestId" xml:"requestId"`
	Avatar         *string `json:"avatar" xml:"avatar"`
	CreatedAt      *int64  `json:"created_at" xml:"created_at"`
	DefaultDriveId *string `json:"default_drive_id" xml:"default_drive_id"`
	Description    *string `json:"description" xml:"description"`
	DomainId       *string `json:"domain_id" xml:"domain_id"`
	Email          *string `json:"email" xml:"email"`
	NickName       *string `json:"nick_name" xml:"nick_name"`
	Phone          *string `json:"phone" xml:"phone"`
	Role           *string `json:"role" xml:"role"`
	Status         *string `json:"status" xml:"status"`
	UpdatedAt      *int64  `json:"updated_at" xml:"updated_at"`
	UserId         *string `json:"user_id" xml:"user_id"`
	UserName       *string `json:"user_name" xml:"user_name"`
}

func (s GetUserResponse) String() string {
	return tea.Prettify(s)
}

func (s GetUserResponse) GoString() string {
	return s.String()
}

func (s *GetUserResponse) SetRequestId(v string) *GetUserResponse {
	s.RequestId = &v
	return s
}

func (s *GetUserResponse) SetAvatar(v string) *GetUserResponse {
	s.Avatar = &v
	return s
}

func (s *GetUserResponse) SetCreatedAt(v int64) *GetUserResponse {
	s.CreatedAt = &v
	return s
}

func (s *GetUserResponse) SetDefaultDriveId(v string) *GetUserResponse {
	s.DefaultDriveId = &v
	return s
}

func (s *GetUserResponse) SetDescription(v string) *GetUserResponse {
	s.Description = &v
	return s
}

func (s *GetUserResponse) SetDomainId(v string) *GetUserResponse {
	s.DomainId = &v
	return s
}

func (s *GetUserResponse) SetEmail(v string) *GetUserResponse {
	s.Email = &v
	return s
}

func (s *GetUserResponse) SetNickName(v string) *GetUserResponse {
	s.NickName = &v
	return s
}

func (s *GetUserResponse) SetPhone(v string) *GetUserResponse {
	s.Phone = &v
	return s
}

func (s *GetUserResponse) SetRole(v string) *GetUserResponse {
	s.Role = &v
	return s
}

func (s *GetUserResponse) SetStatus(v string) *GetUserResponse {
	s.Status = &v
	return s
}

func (s *GetUserResponse) SetUpdatedAt(v int64) *GetUserResponse {
	s.UpdatedAt = &v
	return s
}

func (s *GetUserResponse) SetUserId(v string) *GetUserResponse {
	s.UserId = &v
	return s
}

func (s *GetUserResponse) SetUserName(v string) *GetUserResponse {
	s.UserName = &v
	return s
}

type ListUserRequest struct {
	Header *ListUserRequestHeader `json:"header" xml:"header" type:"Struct"`
	Limit  *int                   `json:"limit" xml:"limit"`
	Marker *string                `json:"marker" xml:"marker"`
}

func (s ListUserRequest) String() string {
	return tea.Prettify(s)
}

func (s ListUserRequest) GoString() string {
	return s.String()
}

func (s *ListUserRequest) SetHeader(v *ListUserRequestHeader) *ListUserRequest {
	s.Header = v
	return s
}

func (s *ListUserRequest) SetLimit(v int) *ListUserRequest {
	s.Limit = &v
	return s
}

func (s *ListUserRequest) SetMarker(v string) *ListUserRequest {
	s.Marker = &v
	return s
}

type ListUserRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s ListUserRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s ListUserRequestHeader) GoString() string {
	return s.String()
}

func (s *ListUserRequestHeader) SetTraceId(v string) *ListUserRequestHeader {
	s.TraceId = &v
	return s
}

func (s *ListUserRequestHeader) SetDeviceId(v string) *ListUserRequestHeader {
	s.DeviceId = &v
	return s
}

type ListUserResponse struct {
	RequestId  *string             `json:"requestId" xml:"requestId"`
	Items      []*BaseUserResponse `json:"items" xml:"items" type:"Repeated"`
	NextMarker *string             `json:"next_marker" xml:"next_marker"`
}

func (s ListUserResponse) String() string {
	return tea.Prettify(s)
}

func (s ListUserResponse) GoString() string {
	return s.String()
}

func (s *ListUserResponse) SetRequestId(v string) *ListUserResponse {
	s.RequestId = &v
	return s
}

func (s *ListUserResponse) SetItems(v []*BaseUserResponse) *ListUserResponse {
	s.Items = v
	return s
}

func (s *ListUserResponse) SetNextMarker(v string) *ListUserResponse {
	s.NextMarker = &v
	return s
}

type SearchUserRequest struct {
	Header   *SearchUserRequestHeader `json:"header" xml:"header" type:"Struct"`
	Email    *string                  `json:"email" xml:"email"`
	Limit    *int                     `json:"limit" xml:"limit"`
	Marker   *string                  `json:"marker" xml:"marker"`
	NickName *string                  `json:"nick_name" xml:"nick_name"`
	Phone    *string                  `json:"phone" xml:"phone"`
	Role     *string                  `json:"role" xml:"role"`
	Status   *string                  `json:"status" xml:"status"`
	UserName *string                  `json:"user_name" xml:"user_name"`
}

func (s SearchUserRequest) String() string {
	return tea.Prettify(s)
}

func (s SearchUserRequest) GoString() string {
	return s.String()
}

func (s *SearchUserRequest) SetHeader(v *SearchUserRequestHeader) *SearchUserRequest {
	s.Header = v
	return s
}

func (s *SearchUserRequest) SetEmail(v string) *SearchUserRequest {
	s.Email = &v
	return s
}

func (s *SearchUserRequest) SetLimit(v int) *SearchUserRequest {
	s.Limit = &v
	return s
}

func (s *SearchUserRequest) SetMarker(v string) *SearchUserRequest {
	s.Marker = &v
	return s
}

func (s *SearchUserRequest) SetNickName(v string) *SearchUserRequest {
	s.NickName = &v
	return s
}

func (s *SearchUserRequest) SetPhone(v string) *SearchUserRequest {
	s.Phone = &v
	return s
}

func (s *SearchUserRequest) SetRole(v string) *SearchUserRequest {
	s.Role = &v
	return s
}

func (s *SearchUserRequest) SetStatus(v string) *SearchUserRequest {
	s.Status = &v
	return s
}

func (s *SearchUserRequest) SetUserName(v string) *SearchUserRequest {
	s.UserName = &v
	return s
}

type SearchUserRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s SearchUserRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s SearchUserRequestHeader) GoString() string {
	return s.String()
}

func (s *SearchUserRequestHeader) SetTraceId(v string) *SearchUserRequestHeader {
	s.TraceId = &v
	return s
}

func (s *SearchUserRequestHeader) SetDeviceId(v string) *SearchUserRequestHeader {
	s.DeviceId = &v
	return s
}

type UpdateUserRequest struct {
	Header      *UpdateUserRequestHeader `json:"header" xml:"header" type:"Struct"`
	Avatar      *string                  `json:"avatar" xml:"avatar"`
	Description *string                  `json:"description" xml:"description"`
	Email       *string                  `json:"email" xml:"email"`
	NickName    *string                  `json:"nick_name" xml:"nick_name"`
	Phone       *string                  `json:"phone" xml:"phone"`
	Role        *string                  `json:"role" xml:"role"`
	Status      *string                  `json:"status" xml:"status"`
	UserId      *string                  `json:"user_id" xml:"user_id" require:"true"`
}

func (s UpdateUserRequest) String() string {
	return tea.Prettify(s)
}

func (s UpdateUserRequest) GoString() string {
	return s.String()
}

func (s *UpdateUserRequest) SetHeader(v *UpdateUserRequestHeader) *UpdateUserRequest {
	s.Header = v
	return s
}

func (s *UpdateUserRequest) SetAvatar(v string) *UpdateUserRequest {
	s.Avatar = &v
	return s
}

func (s *UpdateUserRequest) SetDescription(v string) *UpdateUserRequest {
	s.Description = &v
	return s
}

func (s *UpdateUserRequest) SetEmail(v string) *UpdateUserRequest {
	s.Email = &v
	return s
}

func (s *UpdateUserRequest) SetNickName(v string) *UpdateUserRequest {
	s.NickName = &v
	return s
}

func (s *UpdateUserRequest) SetPhone(v string) *UpdateUserRequest {
	s.Phone = &v
	return s
}

func (s *UpdateUserRequest) SetRole(v string) *UpdateUserRequest {
	s.Role = &v
	return s
}

func (s *UpdateUserRequest) SetStatus(v string) *UpdateUserRequest {
	s.Status = &v
	return s
}

func (s *UpdateUserRequest) SetUserId(v string) *UpdateUserRequest {
	s.UserId = &v
	return s
}

type UpdateUserRequestHeader struct {
	TraceId  *string `json:"x-pds-trace-id" xml:"x-pds-trace-id"`
	DeviceId *string `json:"x-pds-device-id" xml:"x-pds-device-id"`
}

func (s UpdateUserRequestHeader) String() string {
	return tea.Prettify(s)
}

func (s UpdateUserRequestHeader) GoString() string {
	return s.String()
}

func (s *UpdateUserRequestHeader) SetTraceId(v string) *UpdateUserRequestHeader {
	s.TraceId = &v
	return s
}

func (s *UpdateUserRequestHeader) SetDeviceId(v string) *UpdateUserRequestHeader {
	s.DeviceId = &v
	return s
}

type UpdateUserResponse struct {
	RequestId      *string `json:"requestId" xml:"requestId"`
	Avatar         *string `json:"avatar" xml:"avatar"`
	CreatedAt      *int64  `json:"created_at" xml:"created_at"`
	DefaultDriveId *string `json:"default_drive_id" xml:"default_drive_id"`
	Description    *string `json:"description" xml:"description"`
	DomainId       *string `json:"domain_id" xml:"domain_id"`
	Email          *string `json:"email" xml:"email"`
	NickName       *string `json:"nick_name" xml:"nick_name"`
	Phone          *string `json:"phone" xml:"phone"`
	Role           *string `json:"role" xml:"role"`
	Status         *string `json:"status" xml:"status"`
	UpdatedAt      *int64  `json:"updated_at" xml:"updated_at"`
	UserId         *string `json:"user_id" xml:"user_id"`
	UserName       *string `json:"user_name" xml:"user_name"`
}

func (s UpdateUserResponse) String() string {
	return tea.Prettify(s)
}

func (s UpdateUserResponse) GoString() string {
	return s.String()
}

func (s *UpdateUserResponse) SetRequestId(v string) *UpdateUserResponse {
	s.RequestId = &v
	return s
}

func (s *UpdateUserResponse) SetAvatar(v string) *UpdateUserResponse {
	s.Avatar = &v
	return s
}

func (s *UpdateUserResponse) SetCreatedAt(v int64) *UpdateUserResponse {
	s.CreatedAt = &v
	return s
}

func (s *UpdateUserResponse) SetDefaultDriveId(v string) *UpdateUserResponse {
	s.DefaultDriveId = &v
	return s
}

func (s *UpdateUserResponse) SetDescription(v string) *UpdateUserResponse {
	s.Description = &v
	return s
}

func (s *UpdateUserResponse) SetDomainId(v string) *UpdateUserResponse {
	s.DomainId = &v
	return s
}

func (s *UpdateUserResponse) SetEmail(v string) *UpdateUserResponse {
	s.Email = &v
	return s
}

func (s *UpdateUserResponse) SetNickName(v string) *UpdateUserResponse {
	s.NickName = &v
	return s
}

func (s *UpdateUserResponse) SetPhone(v string) *UpdateUserResponse {
	s.Phone = &v
	return s
}

func (s *UpdateUserResponse) SetRole(v string) *UpdateUserResponse {
	s.Role = &v
	return s
}

func (s *UpdateUserResponse) SetStatus(v string) *UpdateUserResponse {
	s.Status = &v
	return s
}

func (s *UpdateUserResponse) SetUpdatedAt(v int64) *UpdateUserResponse {
	s.UpdatedAt = &v
	return s
}

func (s *UpdateUserResponse) SetUserId(v string) *UpdateUserResponse {
	s.UserId = &v
	return s
}

func (s *UpdateUserResponse) SetUserName(v string) *UpdateUserResponse {
	s.UserName = &v
	return s
}

type Client struct {
	DomainId              string
	Endpoint              string
	Protocol              string
	Nickname              string
	UserAgent             string
	Credential            credential.Credential
	AccessTokenCredential *accesstokencredential.AccessTokenCredential
}

func NewClient(config *Config) (*Client, error) {
	client := new(Client)
	err := client.init(config)
	return client, err
}

func (client *Client) init(config *Config) (_err error) {
	if util.IsUnset(tea.ToMap(config)) {
		_err = tea.NewSDKError(map[string]interface{}{
			"name":    "ParameterMissing",
			"message": "'config' can not be unset",
		})
		return _err
	}

	if util.Empty(tea.StringValue(config.DomainId)) {
		_err = tea.NewSDKError(map[string]interface{}{
			"name":    "ParameterMissing",
			"message": "'config.domainId' can not be empty",
		})
		return _err
	}

	if !util.Empty(tea.StringValue(config.AccessToken)) || !util.Empty(tea.StringValue(config.RefreshToken)) {
		accessConfig := &accesstokencredential.Config{
			AccessToken:  config.AccessToken,
			Endpoint:     config.Endpoint,
			DomainId:     config.DomainId,
			ClientId:     config.ClientId,
			RefreshToken: config.RefreshToken,
			ClientSecret: config.ClientSecret,
			ExpireTime:   config.ExpireTime,
		}
		client.AccessTokenCredential, _err = accesstokencredential.NewAccessTokenCredential(accessConfig)
		if _err != nil {
			return _err
		}

	}

	if !util.Empty(tea.StringValue(config.AccessKeyId)) {
		if util.Empty(tea.StringValue(config.CredentialType)) {
			config.CredentialType = tea.String("access_key")
		}

		credentialConfig := &credential.Config{
			AccessKeyId:     config.AccessKeyId,
			Type:            config.CredentialType,
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
	client.DomainId = tea.StringValue(config.DomainId)
	client.UserAgent = tea.StringValue(config.UserAgent)
	client.Nickname = tea.StringValue(config.Nickname)
	return nil
}

func (client *Client) CancelLink(request *CancelLinkRequest, runtime *RuntimeOptions) (_result *AccountAccessTokenResponse, _err error) {
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

	_resp := &AccountAccessTokenResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AccountAccessTokenResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/cancel_link")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &AccountAccessTokenResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ConfirmLink(request *ConfirmLinkRequest, runtime *RuntimeOptions) (_result *AccountAccessTokenResponse, _err error) {
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

	_resp := &AccountAccessTokenResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AccountAccessTokenResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/confirm_link")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &AccountAccessTokenResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ChangePassword(request *DefaultChangePasswordRequest, runtime *RuntimeOptions) (_err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _err
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

	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_err = func() error {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/default/change_password")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				return _err
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
				return _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _err
}

func (client *Client) SetPassword(request *DefaultSetPasswordRequest, runtime *RuntimeOptions) (_err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _err
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

	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_err = func() error {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/default/set_password")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				return _err
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
				return _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _err
}

func (client *Client) GetAccessTokenByLinkInfo(request *GetAccessTokenByLinkInfoRequest, runtime *RuntimeOptions) (_result *AccountAccessTokenResponse, _err error) {
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

	_resp := &AccountAccessTokenResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AccountAccessTokenResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/get_access_token_by_link_info")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &AccountAccessTokenResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) GetCaptcha(request *GetCaptchaRequest, runtime *RuntimeOptions) (_result *Captcha, _err error) {
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

	_resp := &Captcha{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*Captcha, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/get_captcha")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &Captcha{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) GetLinkInfo(request *GetByLinkInfoRequest, runtime *RuntimeOptions) (_result *LinkInfoResponse, _err error) {
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

	_resp := &LinkInfoResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*LinkInfoResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/get_link_info")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &LinkInfoResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) GetLinkInfoByUserId(request *GetLinkInfoByUserIDRequest, runtime *RuntimeOptions) (_result *LinkInfoListResponse, _err error) {
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

	_resp := &LinkInfoListResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*LinkInfoListResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/get_link_info_by_user_id")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &LinkInfoListResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) Link(request *AccountLinkRequest, runtime *RuntimeOptions) (_result *AccountAccessTokenResponse, _err error) {
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

	_resp := &AccountAccessTokenResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AccountAccessTokenResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/link")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &AccountAccessTokenResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) CheckExist(request *MobileCheckExistRequest, runtime *RuntimeOptions) (_result *MobileCheckExistResponse, _err error) {
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

	_resp := &MobileCheckExistResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*MobileCheckExistResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/mobile/check_exist")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &MobileCheckExistResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) Login(request *MobileLoginRequest, runtime *RuntimeOptions) (_result *AccountAccessTokenResponse, _err error) {
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

	_resp := &AccountAccessTokenResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AccountAccessTokenResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/mobile/login")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &AccountAccessTokenResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) Register(request *MobileRegisterRequest, runtime *RuntimeOptions) (_result *AccountAccessTokenResponse, _err error) {
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

	_resp := &AccountAccessTokenResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AccountAccessTokenResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/mobile/register")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &AccountAccessTokenResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) MobileSendSmsCode(request *MobileSendSmsCodeRequest, runtime *RuntimeOptions) (_result *MobileSendSmsCodeResponse, _err error) {
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

	_resp := &MobileSendSmsCodeResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*MobileSendSmsCodeResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/mobile/send_sms_code")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &MobileSendSmsCodeResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) Token(request *TokenRequest, runtime *RuntimeOptions) (_result *AccountAccessTokenResponse, _err error) {
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

	_resp := &AccountAccessTokenResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AccountAccessTokenResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/account/token")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".auth.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &AccountAccessTokenResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) AdminListStores(request *AdminListStoresRequest, runtime *RuntimeOptions) (_result *ListStoresResponse, _err error) {
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

	_resp := &ListStoresResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListStoresResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/domain/list_stores")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &ListStoresResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) GetUserAccessToken(request *GetUserAccessTokenRequest, runtime *RuntimeOptions) (_result *AccessTokenResponse, _err error) {
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

	_resp := &AccessTokenResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*AccessTokenResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/user/get_access_token")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &AccessTokenResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) CreateDrive(request *CreateDriveRequest, runtime *RuntimeOptions) (_result *CreateDriveResponse, _err error) {
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

	_resp := &CreateDriveResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*CreateDriveResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/drive/create")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 201) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &CreateDriveResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) DeleteDrive(request *DeleteDriveRequest, runtime *RuntimeOptions) (_err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _err
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

	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_err = func() error {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/drive/delete")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				return _err
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
				return _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _err
}

func (client *Client) GetDrive(request *GetDriveRequest, runtime *RuntimeOptions) (_result *GetDriveResponse, _err error) {
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

	_resp := &GetDriveResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetDriveResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/drive/get")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &GetDriveResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) GetDefaultDrive(request *GetDefaultDriveRequest, runtime *RuntimeOptions) (_result *GetDriveResponse, _err error) {
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

	_resp := &GetDriveResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetDriveResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/drive/get_default_drive")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &GetDriveResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ListDrives(request *ListDriveRequest, runtime *RuntimeOptions) (_result *ListDriveResponse, _err error) {
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

	_resp := &ListDriveResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListDriveResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/drive/list")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &ListDriveResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ListMyDrives(request *ListMyDriveRequest, runtime *RuntimeOptions) (_result *ListDriveResponse, _err error) {
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

	_resp := &ListDriveResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListDriveResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/drive/list_my_drives")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &ListDriveResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) UpdateDrive(request *UpdateDriveRequest, runtime *RuntimeOptions) (_result *UpdateDriveResponse, _err error) {
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

	_resp := &UpdateDriveResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*UpdateDriveResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/drive/update")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &UpdateDriveResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) CompleteFile(request *OSSCompleteFileRequest, runtime *RuntimeOptions) (_result *OSSCompleteFileResponse, _err error) {
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

	_resp := &OSSCompleteFileResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSCompleteFileResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/complete")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &OSSCompleteFileResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) CopyFile(request *OSSCopyFileRequest, runtime *RuntimeOptions) (_result *OSSCopyFileResponse, _err error) {
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

	_resp := &OSSCopyFileResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSCopyFileResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/copy")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 201) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &OSSCopyFileResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) CreateFile(request *OSSCreateFileRequest, runtime *RuntimeOptions) (_result *OSSCreateFileResponse, _err error) {
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

	_resp := &OSSCreateFileResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSCreateFileResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/create")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 201) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &OSSCreateFileResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) DeleteFile(request *OSSDeleteFileRequest, runtime *RuntimeOptions) (_err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _err
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

	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_err = func() error {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/delete")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				return _err
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
				return _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _err
}

func (client *Client) GetFile(request *OSSGetFileRequest, runtime *RuntimeOptions) (_result *OSSGetFileResponse, _err error) {
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

	_resp := &OSSGetFileResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSGetFileResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/get")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &OSSGetFileResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) GetDownloadUrl(request *OSSGetDownloadUrlRequest, runtime *RuntimeOptions) (_result *OSSGetDownloadUrlResponse, _err error) {
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

	_resp := &OSSGetDownloadUrlResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSGetDownloadUrlResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/get_download_url")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &OSSGetDownloadUrlResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) GetSecureUrl(request *OSSGetSecureUrlRequest, runtime *RuntimeOptions) (_result *OSSGetSecureUrlResponse, _err error) {
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

	_resp := &OSSGetSecureUrlResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSGetSecureUrlResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/get_secure_url")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &OSSGetSecureUrlResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) GetUploadUrl(request *OSSGetUploadUrlRequest, runtime *RuntimeOptions) (_result *OSSGetUploadUrlResponse, _err error) {
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

	_resp := &OSSGetUploadUrlResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSGetUploadUrlResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/get_upload_url")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &OSSGetUploadUrlResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ListFile(request *OSSListFileRequest, runtime *RuntimeOptions) (_result *OSSListFileResponse, _err error) {
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

	_resp := &OSSListFileResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSListFileResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/list")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &OSSListFileResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ListUploadedParts(request *OSSListUploadedPartRequest, runtime *RuntimeOptions) (_result *OSSListUploadedPartResponse, _err error) {
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

	_resp := &OSSListUploadedPartResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSListUploadedPartResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/list_uploaded_parts")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &OSSListUploadedPartResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) MoveFile(request *OSSMoveFileRequest, runtime *RuntimeOptions) (_result *OSSMoveFileResponse, _err error) {
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

	_resp := &OSSMoveFileResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*OSSMoveFileResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/move")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &OSSMoveFileResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) VideoM3u8(request *OSSVideoM3U8Request, runtime *RuntimeOptions) (_result []byte, _err error) {
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

	_resp := make([]byte, 0)
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() ([]byte, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/video_m3u8")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 200) {
				byt, _err := util.ReadAsBytes(response_.Body)
				if _err != nil {
					return nil, _err
				}

				_result = byt
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

func (client *Client) VideoTranscode(request *OSSVideoTranscodeRequest, runtime *RuntimeOptions) (_err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _err
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

	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_err = func() error {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/file/video_transcode")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				return _err
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
				return _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _err
}

func (client *Client) CreateShare(request *CreateShareRequest, runtime *RuntimeOptions) (_result *CreateShareResponse, _err error) {
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

	_resp := &CreateShareResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*CreateShareResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/share/create")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 201) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &CreateShareResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) DeleteShare(request *DeleteShareRequest, runtime *RuntimeOptions) (_err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _err
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

	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_err = func() error {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/share/delete")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				return _err
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
				return _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _err
}

func (client *Client) GetShare(request *GetShareRequest, runtime *RuntimeOptions) (_result *GetShareResponse, _err error) {
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

	_resp := &GetShareResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetShareResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/share/get")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &GetShareResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ListShare(request *ListShareRequest, runtime *RuntimeOptions) (_result *ListShareResponse, _err error) {
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

	_resp := &ListShareResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListShareResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/share/list")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &ListShareResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) UpdateShare(request *UpdateShareRequest, runtime *RuntimeOptions) (_result *UpdateShareResponse, _err error) {
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

	_resp := &UpdateShareResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*UpdateShareResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/share/update")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &UpdateShareResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ListStorefile(request *ListStoreFileRequest, runtime *RuntimeOptions) (_result *ListStoreFileResponse, _err error) {
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

	_resp := &ListStoreFileResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListStoreFileResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/osspath/store_file/list")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &ListStoreFileResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) CreateUser(request *CreateUserRequest, runtime *RuntimeOptions) (_result *CreateUserResponse, _err error) {
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

	_resp := &CreateUserResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*CreateUserResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/user/create")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return nil, _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 201) {
				obj, _err = util.ReadAsJSON(response_.Body)
				if _err != nil {
					return nil, _err
				}

				respMap = util.AssertAsMap(obj)
				_result = &CreateUserResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) DeleteUser(request *DeleteUserRequest, runtime *RuntimeOptions) (_err error) {
	_err = tea.Validate(request)
	if _err != nil {
		return _err
	}
	_err = tea.Validate(runtime)
	if _err != nil {
		return _err
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

	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_err = func() error {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/user/delete")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
			response_, _err := tea.DoRequest(request_, _runtime)
			if _err != nil {
				return _err
			}
			respMap := make(map[string]interface{})
			obj := interface{}(nil)
			if util.EqualNumber(response_.StatusCode, 204) {
				return _err
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
				return _err
			}

			obj, _err = util.ReadAsJSON(response_.Body)
			if _err != nil {
				return _err
			}

			respMap = util.AssertAsMap(obj)
			_err = tea.NewSDKError(tea.ToMap(map[string]interface{}{
				"data": map[string]interface{}{
					"requestId":     response_.Headers["x-ca-request-id"],
					"statusCode":    response_.StatusCode,
					"statusMessage": response_.StatusMessage,
				},
			}, respMap))
			return _err
		}()
		if !tea.Retryable(_err) {
			break
		}
	}

	return _err
}

func (client *Client) GetUser(request *GetUserRequest, runtime *RuntimeOptions) (_result *GetUserResponse, _err error) {
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

	_resp := &GetUserResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*GetUserResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/user/get")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &GetUserResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) ListUsers(request *ListUserRequest, runtime *RuntimeOptions) (_result *ListUserResponse, _err error) {
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

	_resp := &ListUserResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListUserResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/user/list")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &ListUserResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) SearchUser(request *SearchUserRequest, runtime *RuntimeOptions) (_result *ListUserResponse, _err error) {
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

	_resp := &ListUserResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*ListUserResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/user/search")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &ListUserResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

func (client *Client) UpdateUser(request *UpdateUserRequest, runtime *RuntimeOptions) (_result *UpdateUserResponse, _err error) {
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

	_resp := &UpdateUserResponse{}
	for _retryTimes := 0; tea.AllowRetry(_runtime["retry"], _retryTimes); _retryTimes++ {
		if _retryTimes > 0 {
			_backoffTime := tea.GetBackoffTime(_runtime["backoff"], _retryTimes)
			if _backoffTime > 0 {
				tea.Sleep(_backoffTime)
			}
		}

		_resp, _err = func() (*UpdateUserResponse, error) {
			request_ := tea.NewRequest()
			accesskeyId, _err := client.GetAccessKeyId()
			if _err != nil {
				return nil, _err
			}

			accessKeySecret, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			securityToken, _err := client.GetAccessKeySecret()
			if _err != nil {
				return nil, _err
			}

			accessToken, _err := client.GetAccessToken()
			if _err != nil {
				return nil, _err
			}

			request_.Protocol = util.DefaultString(client.Protocol, "https")
			request_.Method = "POST"
			request_.Pathname = client.GetPathname(client.Nickname, "/v2/user/update")
			request_.Headers = util.StringifyMapValue(tea.ToMap(map[string]interface{}{
				"user-agent":   client.GetUserAgent(),
				"host":         util.DefaultString(client.Endpoint, tea.ToString(client.DomainId)+".api.alicloudccp.com"),
				"content-type": "application/json; charset=utf-8",
			}, request.Header))
			if !util.Empty(accessToken) {
				request_.Headers["authorization"] = "Bearer " + tea.ToString(accessToken)
			} else if !util.Empty(accesskeyId) && !util.Empty(accessKeySecret) {
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

			request_.Body = tea.ToReader(util.ToJSONString(roautil.DeleteSpecialKey(tea.ToMap(request), "header")))
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
				_result = &UpdateUserResponse{}
				_err = tea.Convert(tea.ToMap(map[string]interface{}{
					"requestId": response_.Headers["x-ca-request-id"],
				}, respMap), &_result)
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

	_result = ""
	_result = "/" + tea.ToString(nickname) + tea.ToString(path)
	return _result
}

func (client *Client) SetExpireTime(expireTime string) (_err error) {
	if util.IsUnset(client.AccessTokenCredential) {
		return _err
	}

	_err = client.AccessTokenCredential.SetExpireTime(expireTime)
	if _err != nil {
		return
	}
	return _err
}

func (client *Client) GetExpireTime() (_result string) {
	if util.IsUnset(client.AccessTokenCredential) {
		_result = ""
		return _result
	}

	expireTime := client.AccessTokenCredential.GetExpireTime()
	_result = expireTime
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

func (client *Client) SetRefreshToken(token string) {
	if util.IsUnset(client.AccessTokenCredential) {
		return
	}

	client.AccessTokenCredential.SetRefreshToken(token)
}

func (client *Client) GetRefreshToken() (_result string) {
	if util.IsUnset(client.AccessTokenCredential) {
		_result = ""
		return _result
	}

	token := client.AccessTokenCredential.GetRefreshToken()
	_result = token
	return _result
}

func (client *Client) SetAccessToken(token string) {
	if util.IsUnset(client.AccessTokenCredential) {
		return
	}

	client.AccessTokenCredential.SetAccessToken(token)
}

func (client *Client) GetAccessToken() (_result string, _err error) {
	if util.IsUnset(client.AccessTokenCredential) {
		_result = ""
		return _result, _err
	}

	token, _err := client.AccessTokenCredential.GetAccessToken()
	if _err != nil {
		return "", _err
	}

	_result = token
	return _result, _err
}

func (client *Client) GetAccessKeyId() (_result string, _err error) {
	if util.IsUnset(client.Credential) {
		_result = ""
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
		_result = ""
		return _result, _err
	}

	secret, _err := client.Credential.GetAccessKeySecret()
	if _err != nil {
		return "", _err
	}

	_result = secret
	return _result, _err
}
