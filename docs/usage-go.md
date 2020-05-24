![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

# 下载地址

>  *https://github.com/aliyun/aliyun-ccp* 

# 要求
- 您需要确保本地安装的 go 环境版本大于 1.12.0.

# 安装步骤

## 安装 Go 开发环境

您可以从 [golang官方网站](https://golang.org/dl/) 下载并按说明安装 golang 开发环境。

## 安装 CCP Go SDK 

安装完 Go 开发环境后，你需要执行以下操作获取最新的 CCP SDK

CCP Path 

~~~go
go get  github.com/alibabacloud-go/ccppath-sdk/ccppath-sdk
~~~

OSS Path

~~~go
go get  github.com/alibabacloud-go/ccppath-sdk/osspath-sdk
~~~

# 初始化Client

## AK & SK 初始化客户端

~~~go
var akConfig = new(client.Config).
    SetDomainId("your domain id").
    SetProtocol("https").
    SetAccessKeyId(os.Getenv("ACCESS_KEY_ID")).
    SetAccessKeySecret(os.Getenv("ACCESS_KEY_SECRET"))

// initial runtimeOptions
var runtime = new(client.RuntimeOptions)

// initial akClient
var akClient, _ = client.NewClient(akConfig)
~~~

## ClientID & Client Secret 初始化客户端

~~~go
var accessTokenConfig = new(client.Config).
	SetDomainId("your domain id").
	SetProtocol("https").
	SetClientId(os.Getenv("CLIENT_ID")).
	SetClientSecret(os.Getenv("CLIENT_SECRET")).
	SetAccessToken("ejy***************1asf").
	SetRefreshToken("O00*********MHb").
	SetExpireTime("2019-11-05T03:29:09Z")

// initial runtimeOptions
var runtime = new(client.RuntimeOptions)

// initial tokenClient
var tokenClient, _ = client.NewClient(accessTokenConfig)
~~~

# 构造请求

## Account 相关 API

### 说明

> 客户端需要初始化如下

~~~go
// {domainId} 替换成自己的domainId
var authConfig = new(client.Config).
	SetEndpoint("{domainId}.auth.alicloudccp.com").  
	SetProtocol("https").
	SetAccessKeyId(os.Getenv("ACCESS_KEY_ID")).
	SetAccessKeySecret(os.Getenv("ACCESS_KEY_SECRET"))

// initial runtimeOptions
var runtime = new(client.RuntimeOptions)

// initial authClient
var authClient, _ = client.NewClient(authConfig)
~~~

### 获取图片验证码

-  以下代码用于获取图片验证码，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。 

~~~go
// 获取图片验证码
func GetCaptcha() {
	getCaptchaModel := new(client.GetCaptchaRequestModel)
	getCaptchaRequest := new(client.GetCaptchaRequest)
	getCaptchaRequest.SetAppId(os.Getenv("APP_KEY"))
	getCaptchaModel.SetBody(getCaptchaRequest)

	response, err := authClient.GetCaptcha(getCaptchaModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "captcha": "iVBORw0KGgoAAAANSUhEUgAAAFAAAAAaCAIAAACvsEzwAAABQ0lEQVR42u3Yyw3CMAwA0Nw4IjZhAW7cYQQGQEKVGJDNSqRKUfAvjp1CWlr5QtWGPmInLmH8syNs4A28MvDwfGxg+ri8riDk64+3cx4dpbTSjMExuHuBtom5STJWg7E/3p4CgNODTh/zK2OcDncQXYPxmZwNppScYQzmzPthFwM8ajppWaU15iI4HwekMZnPQFgFtmldYG7pwmaugA3gaXyz9mMfLprJRUsotiqwXMO50KP1got7EpneXA0Lo/0SzFUv1oIBsVm/SiekUwtbS9lM1rAfrK9hv9YFFswph7lFmxNy5rlmuHZb0piFdcsAblnDBvA0gUqzclsqgp1m7+uhskvDvaet0/KbG7wP683F1lKzLbVpLZ2tudmsPDibwRxw4pnNi/gvgdiWnOzlgZ0zVnvXl3+jIH/9+syh55yc42HeYJ3SI2GdJBoAAAAASUVORK5CYII=",
   "captcha_format": "png",
   "captcha_id": "ff5db7ecd9988915ee56bebb52ed055aqSD2Cqce646"
}
~~~

### 获取短信验证码

-  以下代码用于获取短信验证码，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。 

~~~go
// 获取短信验证码
func GetMnsCode() {
	getMnsCodeModel := new(client.MobileSendSmsCodeRequestModel)
	getMnsCodeRequest := new(client.MobileSendSmsCodeRequest)
	getMnsCodeRequest.SetAppId(os.Getenv("APP_KEY"))
	getMnsCodeRequest.SetPhoneNumber("1****5")
	getMnsCodeRequest.SetType("login")
	getMnsCodeModel.SetBody(getMnsCodeRequest)

	response, err := authClient.MobileSendSmsCode(getMnsCodeModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "4CF58428-912F-4F4F-BE1D-4C06FE559097",
   "sms_code_id": "16340***************Slzf"
}
~~~

### 验证手机号是否注册

- 以下代码用于验证手机号是否注册，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func CheckMobileIsExist() {
	mobileCheckExistModel := new(client.MobileCheckExistRequestModel)
	mobileCheckExistRequest := new(client.MobileCheckExistRequest)
	mobileCheckExistRequest.SetAppId(os.Getenv("APP_KEY"))
	mobileCheckExistRequest.SetPhoneNumber("1****5")
	mobileCheckExistModel.SetBody(mobileCheckExistRequest)

	response, err := authClient.CheckExist(mobileCheckExistModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果 

~~~JavaScript
{
   "requestId": "0BF59873-1433-4D62-A465-93B7250BD698",
   "is_exist": true,
   "phone_number": "132*****225"
}

~~~

### 手机号注册

-  以下代码用于手机号注册，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。 

~~~go
// 手机号注册
func MobileRegister() {
	mobileRegisterModel := new(client.MobileRegisterRequestModel)
	mobileRegisterRequest := new(client.MobileRegisterRequest)
	mobileRegisterRequest.SetAppId(os.Getenv("APP_KEY"))
	mobileRegisterRequest.SetPhoneNumber("1*******21")
	mobileRegisterRequest.SetSmsCode("xxx")
	mobileRegisterRequest.SetSmsCodeId("xxx")
	mobileRegisterModel.SetBody(mobileRegisterRequest)

	response, err := authClient.Register(mobileRegisterModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "525FCA71-4C4A-4C35-AC72-24A4DC181646",
   "access_token": "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpX********P0ER7E-ASrJI",
   "avatar": null,
   "default_drive_id": null,
   "exist_link": [],
   "expire_time": "2019-11-04T11:50:06Z",
   "expires_in": 7200,
   "need_link": false,
   "nick_name": "132***225",
   "refresh_token": "A2lpoPv********1XRhl78",
   "role": "admin",
   "state": null,
   "token_type": "Bearer",
   "user_id": "6c23c98d36dc4b44b56b7d8b3f9f5211",
   "user_name": "132***225"
}
~~~

### 手机号短信登录

- 以下代码用于手机号短信登录，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func MnsCodeLogin() {
	mobileLoginModel := new(client.MobileLoginRequestModel)
	mobileLoginRequest := new(client.MobileLoginRequest)
	mobileLoginRequest.SetAppId(os.Getenv("APP_KEY"))
	mobileLoginRequest.SetSmsCode("****")
	mobileLoginRequest.SetSmsCodeId("******")
	mobileLoginRequest.SetPhoneNumber("132********25")
	mobileLoginModel.SetBody(mobileLoginRequest)

	response, err := authClient.Login(mobileLoginModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果参见[手机号注册的返回结果](#手机号注册)

### 设置登录密码

- 以下代码用于设置登录密码，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func SetPassword() {
	setPasswordModel := new(client.DefaultSetPasswordRequestModel)
	setPasswordRequest := new(client.DefaultSetPasswordRequest)
	setPasswordRequest.SetAppId(os.Getenv("APP_KEY"))
	setPasswordRequest.SetNewPassword("xx")
	setPasswordRequest.SetState("xxx")
	setPasswordModel.SetBody(setPasswordRequest)

	response, err := authClient.SetPassword(setPasswordModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)

}
~~~

### 密码登录

- 以下代码用于密码登录，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func PasswordLogin() {
	passwordLoginModel := new(client.MobileLoginRequestModel)
	passwordLoginRequest := new(client.MobileLoginRequest)
	passwordLoginRequest.SetPhoneNumber("1****12")
	passwordLoginRequest.SetPassword("1****12")
	passwordLoginRequest.SetAppId(os.Getenv("APP_KEY"))
	passwordLoginModel.SetBody(passwordLoginRequest)

	response, err := authClient.Login(passwordLoginModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)

}
~~~

- 返回结果参见[手机号注册的返回结果](#手机号注册) 

### 修改登录密码

- 以下代码用于修改登录密码，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func ChangePassword() {
	changePasswordModel := new(client.DefaultChangePasswordRequestModel)
	changePasswordRequest := new(client.DefaultChangePasswordRequest)
	changePasswordRequest.SetAppId(os.Getenv("APP_KEY"))
	changePasswordRequest.SetNewPassword("new")
	changePasswordRequest.SetPhoneNumber("1****13")
	changePasswordRequest.SetSmsCodeId("xx")
	changePasswordRequest.SetSmsCode("xxx")
	changePasswordModel.SetBody(changePasswordRequest)

	response, err := authClient.ChangePassword(changePasswordModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~



### 通过刷新令牌获取访问令牌

- 以下代码用于通过刷新令牌获取访问令牌，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetTokenByRefreshToken() {
	getTokenByRefreshTokenModel := new(client.TokenRequestModel)
	getTokenByRefreshTokenRequest := new(client.TokenRequest)
	getTokenByRefreshTokenRequest.SetAppId(os.Getenv("APP_KEY"))
	getTokenByRefreshTokenRequest.SetRefreshToken("xxx")
	getTokenByRefreshTokenRequest.SetGrantType("refresh_token")
	getTokenByRefreshTokenModel.SetBody(getTokenByRefreshTokenRequest)

	response, err := authClient.Token(getTokenByRefreshTokenModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果参见[手机号注册的返回结果](#手机号注册) 

### 通过账号获取访问令牌

>  此接口需要 ak，sk 调用， 请使用 ak, sk 初始化客户端

- 以下代码用于通过账号获取访问令牌，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetAccessTokenByLinkInfo() {
	getAccessTokenByLinkInfoModel := new(client.GetAccessTokenByLinkInfoRequestModel)
	getAccessTokenByLinkInfoRequest := new(client.GetAccessTokenByLinkInfoRequest)
	getAccessTokenByLinkInfoRequest.SetType("mobile")
	getAccessTokenByLinkInfoRequest.SetIdentity("13*****225")
	getAccessTokenByLinkInfoModel.SetBody(getAccessTokenByLinkInfoRequest)

	response, err := authClient.GetAccessTokenByLinkInfo(getAccessTokenByLinkInfoModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果参见[手机号注册的返回结果](#手机号注册) 

### 获取用户绑定信息

>  此接口需要 ak，sk 调用， 请使用 ak, sk 初始化客户端

- 以下代码用于获取用户绑定信息，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetLinkInfoByUserId() {
	getLinkInfoByUserIdModel := new(client.GetLinkInfoByUserIDRequestModel)
	getLinkInfoByUserIdRequest := new(client.GetLinkInfoByUserIDRequest)
	getLinkInfoByUserIdRequest.SetUserId("****")
	getLinkInfoByUserIdModel.SetBody(getLinkInfoByUserIdRequest)

	response, err := authClient.GetLinkInfoByUserId(getLinkInfoByUserIdModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "793162FD-F1F2-4658-9DF2-B14213987B9F",
   "items": [
      {
         "requestId": null,
         "authentication_type": "ding",
         "created_at": 1571915575496,
         "domain_id": "dai****5",
         "identity": "g3QxL*****QiEiE",
         "last_login_time": 1571915575496,
         "status": "normal",
         "user_id": "5190***********bf5"
      }
   ]
}
~~~

### 获取用户认证方式

>  此接口需要 ak，sk 调用， 请使用 ak, sk 初始化客户端

- 以下代码用于获取用户认证方式，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetLinkInfo() {
	getLinkInfoModel := new(client.GetByLinkInfoRequestModel)
	getLinkInfoRequest := new(client.GetByLinkInfoRequest)
	getLinkInfoRequest.SetIdentity("1*******1")
	getLinkInfoRequest.SetType("mobile")
	getLinkInfoModel.SetBody(getLinkInfoRequest)

	response, err := authClient.GetLinkInfo(getLinkInfoModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "BFB8B3C4-7727-401D-9B65-495337FF5ADD",
   "authentication_type": "mobile",
   "created_at": 1571905906341,
   "domain_id": "daily1405",
   "identity": "13******225",
   "last_login_time": 1571905906341,
   "status": "normal",
   "user_id": "6c23c9***************5211"
}
~~~

### 绑定用户认证方式

> 此接口需要 ak，sk 调用， 请使用 ak, sk 初始化客户端

- 以下代码用于绑定用户认证方式，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~~go
func AccountLink() {
	accountLinkModel := new(client.AccountLinkRequestModel)
	accountLinkRequest := new(client.AccountLinkRequest)
	accountLinkRequest.SetType("taobao")
	accountLinkRequest.SetIdentity("1233445")
	accountLinkRequest.SetUserId("12344556")
	accountLinkRequest.SetStatus("wait_link")
	accountLinkModel.SetBody(accountLinkRequest)

	response, err := authClient.Link(accountLinkModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)

}
~~~~

- 返回结果

~~~javascript
{
   "requestId": "8A62ABC5-92D4-4CF3-A22F-D6FD908D24C6",
   "access_token": "eyJhbGciOiJSUzI1NiIsIn****LvWYRJiG29hUiUhjZvD2vS0EdItpSiXMucOBk3J5z1EuN9aeycHaTcA",
   "avatar": null,
   "default_drive_id": null,
   "exist_link": [
      {
         "identity": "15******29",
         "type": "mobile"
      }
   ],
   "expire_time": null,
   "expires_in": 300,
   "need_link": true,
   "nick_name": null,
   "refresh_token": null,
   "role": null,
   "state": null,
   "token_type": "Bearer",
   "user_id": null,
   "user_name": null
}
~~~

### 取消绑定关系

- 以下代码用于取消绑定关系，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~~go
func CancelLink() {
	cancelLinkModel := new(client.CancelLinkRequestModel)
	cancelLinkRequest := new(client.CancelLinkRequest)
	cancelLinkRequest.SetTemporaryToken("xxx")
	cancelLinkModel.SetBody(cancelLinkRequest)

	response, err := authClient.CancelLink(cancelLinkModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~~

- 返回结果参见[手机号注册的返回结果](#手机号注册) 

### 确定绑定关系

>  此接口需要 accessToken 调用， 请使用 clientId，ClientSecret 初始化客户端

- 以下代码用于确定绑定关系，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func ConfirmLink() {
	confirmLinkModel := new(client.ConfirmLinkRequestModel)
	confirmLinkRequest := new(client.ConfirmLinkRequest)
	confirmLinkRequest.SetTemporaryToken("****")
	confirmLinkModel.SetBody(confirmLinkRequest)

	response, err := authClient.ConfirmLink(confirmLinkModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response)
}
~~~

- 返回结果参见[手机号注册的返回结果](#手机号注册) 

## User 相关 API

### 创建 User

- 以下代码用于创建 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func CreateUserExample() {
	createUserModel := new(client.CreateUserRequestModel)
	createUserRequest := new(client.CreateUserRequest)
	createUserRequest.SetUserId("xxx")
	createUserRequest.SetUserName("xxx")
	createUserRequest.SetRole("user")
	createUserModel.SetBody(createUserRequest)

	response, err := ossClient.CreateUser(createUserModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)

}
~~~

- 返回结果

~~~javascript
{
   "requestId": "A2808B75-251C-426E-9727-116081F41AC3",
   "avatar": null,
   "created_at": 1573089204640,
   "default_drive_id": "1301",
   "description": null,
   "domain_id": "daily1404",
   "email": null,
   "nick_name": null,
   "phone": null,
   "role": "user",
   "status": "enabled",
   "updated_at": 0,
   "user_id": "test_user",
   "user_name": "test_user"
}
~~~

### 获取 User

- 以下代码用于获取 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetUserExample() {
	getUserModel := new(client.GetUserRequestModel)
	getUserRequest := new(client.GetUserRequest)
	getUserRequest.SetUserId("xxx")
	getUserModel.SetBody(getUserRequest)

	response, err := ossClient.GetUser(getUserModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "2678D6FC-1090-4724-A070-AA0B57811581",
   "avatar": null,
   "created_at": 1573089204640,
   "default_drive_id": "1301",
   "description": null,
   "domain_id": "daily1404",
   "email": null,
   "nick_name": null,
   "phone": null,
   "role": "user",
   "status": "enabled",
   "updated_at": 1573089204655,
   "user_id": "test_user",
   "user_name": "test_user"
}
~~~

### 列举 User

- 以下代码用于列举 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func ListUserExample() {
	listUserModel := new(client.ListUserRequestModel)
	listUserRequest := new(client.ListUserRequest)
	listUserRequest.SetLimit(10)
	listUserRequest.SetMarker("xx")
	listUserModel.SetBody(listUserRequest)

	response, err := ossClient.ListUsers(listUserModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "8E399439-B244-434B-A212-3BF702891692",
   "items": [
      {
         "requestId": null,
         "avatar": "",
         "created_at": 1572340950210,
         "default_drive_id": "901",
         "description": "",
         "domain_id": "daily1404",
         "email": "",
         "nick_name": "root",
         "phone": "",
         "role": "user",
         "status": "enabled",
         "updated_at": 1572340950225,
         "user_id": "10c58ee7455a418a90f4454cc85a372e",
         "user_name": "root"
      },
      {
         "requestId": null,
         "avatar": "",
         "created_at": 1573089204640,
         "default_drive_id": "1301",
         "description": "",
         "domain_id": "daily1404",
         "email": "",
         "nick_name": "",
         "phone": "",
         "role": "user",
         "status": "enabled",
         "updated_at": 1573089204655,
         "user_id": "test_user",
         "user_name": "test_user"
      }
   ],
   "next_marker": null
}
~~~

### 更新 User

- 以下代码用于更新 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func UpdateUserExample() {
	updateUserModel := new(client.UpdateUserRequestModel)
	updateUserRequest := new(client.UpdateUserRequest)
	updateUserRequest.SetUserId("xx")
	updateUserRequest.SetDescription("changed_user")
	updateUserModel.SetBody(updateUserRequest)

	response, err := ossClient.UpdateUser(updateUserModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "B81E6A92-53C7-4715-AD9F-D3DB10154D78",
   "avatar": null,
   "created_at": 1573089204640,
   "default_drive_id": "1301",
   "description": "changed_user",
   "domain_id": "daily1404",
   "email": null,
   "nick_name": null,
   "phone": null,
   "role": "user",
   "status": "enabled",
   "updated_at": 1573089205333,
   "user_id": "test_user",
   "user_name": "test_user"
}
~~~

### 搜索 User

- 以下代码用于搜索 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func SearchUserExample() {
	searchUserModel := new(client.SearchUserRequestModel)
	searchUserRequest := new(client.SearchUserRequest)
	searchUserRequest.SetLimit(10)
	searchUserRequest.SetMarker("xx")
	searchUserRequest.SetUserName("test_user")
	searchUserModel.SetBody(searchUserRequest)

	response, err := ossClient.SearchUser(searchUserModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "C292180C-9DC9-4EC1-9C64-AD0FE215E159",
   "items": [
      {
         "requestId": null,
         "avatar": "",
         "created_at": 1573089204640,
         "default_drive_id": "1301",
         "description": "changed_user",
         "domain_id": "daily1404",
         "email": "",
         "nick_name": "",
         "phone": "",
         "role": "user",
         "status": "enabled",
         "updated_at": 1573089576836,
         "user_id": "test_user",
         "user_name": "test_user"
      }
   ],
   "next_marker": null
}
~~~

### 删除 User

- 以下代码用于删除 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func DeleteUserExample() {
	deleteUserModel := new(client.DeleteUserRequestModel)
	deleteUserRequest := new(client.DeleteUserRequest)
	deleteUserRequest.SetUserId("test_user")
	deleteUserModel.SetBody(deleteUserRequest)

	response, err := ossClient.DeleteUser(deleteUserModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Headers) // deleteUser接口不返回body，若需获取RequestID，请从Headers中获取
}
~~~

## OSSPath Drive 相关API

### 说明

- OSSPath 创建drive 需要先拿到 `store_id`，需要先调用 `AdminListStores` 的接口。

### 创建 drive

- 以下代码用于创建 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
// list stores
func AdminListStoresExample() {
	listStoresModel := new(client.AdminListStoresRequestModel)
	listStoresRequest := new(client.AdminListStoresRequest)
	listStoresModel.SetBody(listStoresRequest)

	response, err := ossClient.AdminListStores(listStoresModel, runtime)
	if err != nil {
		fmt.Println(err.Error())
	}
	if response != nil {
		fmt.Println("storeId is", *response.Body.Items[0].StoreId)
	}
}
// create drive
func CreateDriveExample() {
	createDriveModel := new(client.CreateDriveRequestModel)
	createDriveRequest := new(client.CreateDriveRequest)
	createDriveRequest.SetDriveType("normal")
	createDriveRequest.SetDriveName("your drive name")
	createDriveRequest.SetTotalSize(10240000)
	createDriveRequest.SetOwner("your accout id")
	createDriveRequest.SetRelativePath("/abc/")
	createDriveRequest.SetStoreId("your store id")
	createDriveRequest.SetDescription("test")
	createDriveModel.SetBody(createDriveRequest)

	resp, err := ossClient.CreateDrive(createDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(resp.Body)
}
~~~

- 返回结果

~~~javascript
// list stores result
{
   "requestId": "FD9BA144-FBE6-47DC-8C24-834F68FA0881",
   "items": [
      {
         "accelerate_endpoint": "",
         "base_path": "",
         "bucket": "ccp-daily-test",
         "customized_endpoint": "",
         "endpoint": "https://oss-cn-hangzhou.aliyuncs.com",
         "internal_endpoint": "",
         "ownership": "custom",
         "policy": "",
         "role_arn": "",
         "store_id": "90fb***************1d9b",
         "type": "oss"
      }
   ]
}

// create drive result
{
   "requestId": "78A0512B-DBF5-40A2-8147-7F0EE414B1C0",
   "domain_id": "daily1405",
   "drive_id": "2501"
}
~~~



### 查询 drive

- 以下代码用于查询 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func GetDriveExample() {
	getDriveModel := new(client.GetDriveRequestModel)
	getDriveReq := new(client.GetDriveRequest)
	getDriveReq.SetDriveId("301")
	getDriveModel.SetBody(getDriveReq)

	resp, err := ossClient.GetDrive(getDriveModel, &client.RuntimeOptions{})
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(resp.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "414050C9-C05B-4FFA-BB46-9E891CE3153C",
   "creator": null,
   "description": "测试",
   "domain_id": "d***",
   "drive_id": "2501",
   "drive_name": "测试",
   "drive_type": "normal",
   "owner": "5190*************dbf5",
   "relative_path": "/ldh/",
   "status": "enabled",
   "store_id": "90f**************d9b",
   "total_size": 100000000,
   "used_size": 0
}
~~~

### 列举 drive

- 以下代码用于列举 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func ListDriveExample() {
	listDriveModel := new(client.ListDriveRequestModel)
	listDriveRequest := new(client.ListDriveRequest)
	listDriveRequest.SetLimit(10)
	listDriveRequest.SetOwner("your accout id")
	listDriveModel.SetBody(listDriveRequest)

	response, err := ossClient.ListDrives(listDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~JavaScript
{
   "requestId": "6DB486F0-CDF5-46CD-B5B6-7B3D819174E8",
   "items": [
      {
         "requestId": null,
         "creator": "",
         "description": "test_drive",
         "domain_id": "daily****",
         "drive_id": "2201",
         "drive_name": "test_drive",
         "drive_type": "normal",
         "owner": "51901a4********2edbf5",
         "relative_path": "/test_drive/",
         "status": "enabled",
         "store_id": "90fba*******d9b",
         "total_size": 100000000,
         "used_size": 0
      }
   ],
   "next_marker": null
}
~~~

### 更新 drive

- 以下代码用于更新 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```go
func UpdateDriveExample() {
	updateDriveModel := new(client.UpdateDriveRequestModel)
	updateDriveRequest := new(client.UpdateDriveRequest)
	updateDriveRequest.SetDriveId("your drive id")
	updateDriveRequest.SetDescription("changed drive")

	response, err := ossClient.UpdateDrive(updateDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}

	fmt.Println(response.Body)
}
```

- 返回结果

~~~javascript
{
   "requestId": "251478CD-3AB2-4DA0-B0DE-A6D3BF3933D1",
   "creator": null,
   "description": "changed_drive",
   "domain_id": "daily1405",
   "drive_id": "2501",
   "drive_name": "测试",
   "drive_type": "normal",
   "owner": "51901a43476d4a5a98141ca8c12edbf5",
   "relative_path": "/ldh/",
   "status": "enabled",
   "store_id": "90fba27e9c40452d91d83b204aee1d9b",
   "total_size": 100000000,
   "used_size": 0
}
~~~

### 删除 drive

- 以下代码用于删除 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func DeleteDriveExample() {
	deleteDriveModel := new(client.DeleteDriveRequestModel)
	deleteDriveRequest := new(client.DeleteDriveRequest)
	deleteDriveRequest.SetDriveId("your drive id ")

	response, err := ossClient.DeleteDrive(deleteDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Headers) // deleteDrive接口不返回body，若需获取RequestID，请从Headers中获取
}
~~~

## OSSPath Share 相关 API

### 创建 Share

- 以下代码用于创建 Share，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func getExpireTime() string {
	now := time.Now().UTC()
	h, _ := time.ParseDuration("1h")
	expireTime := now.Add(h).Format("2006-01-02T15:04:05Z")
	return expireTime
}

func CreateShareExample() {
	permissions := []*string{ptrString("FILE.LIST")}
	createShareModel := new(client.CreateShareRequestModel)
	createShareRequest := new(client.CreateShareRequest)
	createShareRequest.SetDriveId("xx")
	createShareRequest.SetOwner("xxx")
	createShareRequest.SetShareName("xxx")
	createShareRequest.SetPermissions(permissions)
	createShareRequest.SetShareFilePath("/xxx/")
	createShareRequest.SetExpiration(getExpireTime())
	createShareModel.SetBody(createShareRequest)

	response, err := ossClient.CreateShare(createShareModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "50774D14-AFA6-4997-84EF-F4C951056276",
   "domain_id": "dai***1",
   "share_id": "04902f6d-cc3a-4afd-af6d-d34f430db840"
}
~~~

### 查询 Share

- 以下代码用于查询 Share，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func GetShareExample() {
	getShareModel := new(client.GetShareRequestModel)
	getShareRequest := new(client.GetShareRequest)
	getShareRequest.SetShareId("xxx")
	getShareModel.SetBody(getShareRequest)

	response, err := ossClient.GetShare(getShareModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "429C2A82-1327-460C-829A-4434729F72CD",
   "created_at": "2019-11-07T01:45:31.609Z",
   "creator": "6c23*******f5211",
   "description": null,
   "domain_id": "dai***05",
   "drive_id": "2201",
   "expiration": "2019-11-07T02:45:31Z",
   "expired": false,
   "owner": "51901a4******edbf5",
   "permissions": [
      "FILE.LIST"
   ],
   "share_file_path": "/test_share/",
   "share_id": "04902f6d-cc3a-4afd-af6d-d34f430db840",
   "share_name": "test_share",
   "status": "enabled",
   "updated_at": "2019-11-07T01:45:31.609Z"
}
~~~

### 列举 Share

- 以下代码用于列举 Share，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func ListShareExample() {
	listShareModel := new(client.ListShareRequestModel)
	listShareRequest := new(client.ListShareRequest)
	listShareRequest.SetLimit(10)
	listShareRequest.SetOwner("xxx")
	listShareRequest.SetCreator("xxx")
	listShareModel.SetBody(listShareRequest)

	response, err := ossClient.ListShare(listShareModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "0CBADEC0-9739-4A1E-89B5-70CF5AEE7E32",
   "items": [
      {
         "requestId": null,
         "created_at": "2019-11-07T01:49:39.215Z",
         "creator": "6c23c98d*******9f5211",
         "description": "",
         "domain_id": "da*****5",
         "drive_id": "2201",
         "expiration": "2019-11-07T02:49:39Z",
         "expired": false,
         "owner": "51901a4*******12edbf5",
         "permissions": [
            "FILE.LIST"
         ],
         "share_file_path": "/test_share/",
         "share_id": "0e5ee6e1-9640-4c22-93f4-b3362d355b1e",
         "share_name": "test_share",
         "status": "enabled",
         "updated_at": "2019-11-07T01:49:39.215Z"
      }
   ],
   "next_marker": null
}
~~~

### 更新 Share

- 以下代码用于更新 Share，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```go
func UpdateShareExample() {
	updateShareModel := new(client.UpdateShareRequestModel)
	updateShareRequest := new(client.UpdateShareRequest)
	updateShareRequest.SetShareId("xxx")
	updateShareRequest.SetDescription("changed_share")
	updateShareModel.SetBody(updateShareRequest)

	response, err := ossClient.UpdateShare(updateShareModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}

```

- 返回结果

~~~javascript
{
   "requestId": "3F484A79-0578-4683-97D6-FBFC5D747506",
   "created_at": "2019-11-07T01:49:39.215Z",
   "creator": "6c23c9*********211",
   "description": "changed_share",
   "domain_id": "dai****1",
   "drive_id": "2201",
   "expiration": "2019-11-07T02:49:39Z",
   "expired": false,
   "owner": "51901a****************bf5",
   "permissions": [],
   "share_file_path": "/test_share/",
   "share_id": "0e5ee6e1-9640-4c22-93f4-b3362d355b1e",
   "share_name": "test_share",
   "status": "enabled",
   "updated_at": "2019-11-07T01:49:39.215Z"
}
~~~

### 删除 Share

- 以下代码用于删除 Share，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```go
func DeleteShareExample() {
	deleteShareModel := new(client.DeleteShareRequestModel)
	deleteShareRequest := new(client.DeleteShareRequest)
	deleteShareRequest.SetShareId("1")
	deleteShareModel.SetBody(deleteShareRequest)

	response, err := ossClient.DeleteShare(deleteShareModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Headers) // deleteShare接口不返回body，若需获取RequestID，请从Headers中获取
}

```

## OSSPath File 相关 API

### 创建 File

- 以下代码用于创建 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

- 说明：此处创建 File 还需要上传文件到 OSS， 具体操作详见最佳实践。

~~~go
func CreateFileExample() {
	createFileModel := new(client.OSSCreateFileRequestModel)
	createFileRequest := new(client.OSSCreateFileRequest).SetDriveId("2201").
		SetName("b.txt").
		SetType("file").
		SetParentFilePath("/").
		SetContentType("text/plain")
	createFileModel.SetBody(createFileRequest)

	response, err := ossClient.CreateFile(createFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "8249D5E8-3D07-4D56-AE69-7E337C6B4659",
   "domain_id": "dai***05",
   "drive_id": "2201",
   "file_path": "/a.jpg",
   "part_info_list": [
      {
         "etag": null,
         "part_number": 1,
         "part_size": null,
         "upload_url": "https://ccp-daily-test.oss-cn-hangzhou.aliyuncs.com/test_drive%2Fa.jpg?E911F0FBD3"
      }
   ],
   "share_id": null,
   "type": "file",
   "upload_id": "35EE8647048349D09A950DE911F0FBD3"
}
~~~

### 列举 File

- 以下代码用于列举 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func ListFileExample() {
	listFileModel := new(client.OSSListFileRequestModel)
	listFileRequest := new(client.OSSListFileRequest)
	listFileRequest.SetParentFilePath("/")
	listFileRequest.SetDriveId("xxx")
	listFileModel.SetBody(listFileRequest)

	response, err := ossClient.ListFile(listFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}

~~~

- 返回结果

~~~javascript
{
   "requestId": "8BA9F8EA-E1A3-4E58-90A8-339336EC8A64",
   "items": [
      {
         "requestId": null,
         "content_hash": null,
         "content_hash_name": null,
         "content_type": "",
         "crc64_hash": null,
         "created_at": null,
         "description": null,
         "domain_id": "dai***05",
         "download_url": null,
         "drive_id": "2201",
         "file_extension": "",
         "file_path": "/test_folder/",
         "name": "test_folder",
         "parent_file_path": "/",
         "share_id": null,
         "size": null,
         "status": "available",
         "thumbnail": null,
         "trashed_at": null,
         "type": "folder",
         "updated_at": null,
         "upload_id": null,
         "url": null
      },
      {
         "requestId": null,
         "content_hash": null,
         "content_hash_name": null,
         "content_type": "",
         "crc64_hash": null,
         "created_at": null,
         "description": null,
         "domain_id": "daily1405",
         "download_url": "https://ccp-da*********",
         "drive_id": "2201",
         "file_extension": "jpg",
         "file_path": "/a.jpg",
         "name": "a.jpg",
         "parent_file_path": "/",
         "share_id": null,
         "size": 3448250,
         "status": "available",
         "thumbnail": "https://ccp-daily-t******0",
         "trashed_at": null,
         "type": "file",
         "updated_at": "2019-11-07T06:49:08Z",
         "upload_id": null,
         "url": "https://ccp-daily-test.oss-cn-hangzhou.aliyuncs.com/te***%3D"
      }
   ],
   "next_marker": null
}
~~~

### 查询 File

- 以下代码用于查询 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetFileExample() {
	getFileModel := new(client.OSSGetFileRequestModel)
	getFileRequest := new(client.OSSGetFileRequest)
	getFileRequest.SetFilePath("xxx")
	getFileRequest.SetDriveId("xxx")
	getFileModel.SetBody(getFileRequest)

	response, err := ossClient.GetFile(getFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~~javascript
{
   "requestId": "7D044402-4A39-40B6-8A21-5D1A2741F5FC",
   "content_hash": null,
   "content_hash_name": null,
   "content_type": "image/jpg",
   "crc64_hash": null,
   "created_at": null,
   "description": null,
   "domain_id": "daily1405",
   "download_url": "https://ccp-d*********eg%3D",
   "drive_id": "2201",
   "file_extension": null,
   "file_path": "/a.jpg",
   "name": "a.jpg",
   "parent_file_path": "/",
   "share_id": null,
   "size": 3448250,
   "status": "available",
   "thumbnail": null,
   "trashed_at": null,
   "type": "file",
   "updated_at": "2019-11-07T06:49:08Z",
   "upload_id": null,
   "url": "https://ccp-daily-***QQkX8PWQ0JFdcQfhvY0WfEv2P0JdFAz93aYgXDZn0AjAdL1JNz3G6BGcjaaBOmrsERm9J1NnFeg%3D"
}
~~~~

### 移动 File

- 以下代码用于移动 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func MoveFileExample() {
	moveFileModel := new(client.OSSMoveFileRequestModel)
	moveFileRequest := new(client.OSSMoveFileRequest)
	moveFileRequest.SetToParentFilePath("/")
	moveFileRequest.SetFilePath("/xxxx/")
	moveFileRequest.SetDriveId("xxx")
	moveFileModel.SetBody(moveFileRequest)

	response, err := ossClient.MoveFile(moveFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "675E40E6-1BFF-4A53-8A81-B300F03102C4",
   "async_task_id": null,
   "domain_id": "daily1405",
   "drive_id": "2201",
   "file_path": "/test_folder/a.jpg",
   "share_id": null
}
~~~

### 复制 File

- 以下代码用于复制 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func CopyFileExample() {
	copyFileModel := new(client.OSSCopyFileRequestModel)
	copyFileRequest := new(client.OSSCopyFileRequest)
	copyFileRequest.SetToParentFilePath("/")
	copyFileRequest.SetFilePath("/xxxx/")
	copyFileRequest.SetDriveId("xxx")
	copyFileModel.SetBody(copyFileRequest)

	response, err := ossClient.CopyFile(copyFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "205CB077-F075-43D2-A181-4114587B4694",
   "async_task_id": null,
   "domain_id": "daily1405",
   "drive_id": "2201",
   "file_path": "/a.jpg",
   "share_id": null
}
~~~

### 获取 File 上传地址

- 以下代码用于获取 File 上传地址，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetUploadUrlExample() {
	var uploadInfo = new(client.UploadPartInfo)

	getFileUploadUrlModel := new(client.OSSGetUploadUrlRequestModel)
	getFileUploadUrlRequest := new(client.OSSGetUploadUrlRequest)
	getFileUploadUrlRequest.SetUploadId("xxx")
	getFileUploadUrlRequest.SetFilePath("/xxxx/")
	getFileUploadUrlRequest.SetDriveId("xxx")
	getFileUploadUrlRequest.SetPartInfoList([]*client.UploadPartInfo{uploadInfo})

	getFileUploadUrlModel.SetBody(getFileUploadUrlRequest)

	response, err := ossClient.GetUploadUrl(getFileUploadUrlModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "0A433A26-D29E-4038-ACEB-1359615C3C58",
   "create_at": "2019-11-07T06:49:07.304Z",
   "domain_id": "daily1405",
   "drive_id": "2201",
   "file_path": "/a.jpg",
   "part_info_list": [
      {
         "etag": null,
         "part_number": 1,
         "part_size": null,
         "upload_url": "https://ccp-daily-test.oss-cn-hangzhou.aliyuncs.com/test_drive%2Fa.jpg?Expires=1573112947\u0026OSSAc****ploadId=35EE8647048349D09A950DE911F0FBD3"
      }
   ],
   "upload_id": "35EE8647048349D09A950DE911F0FBD3"
}
~~~

### 获取 File 下载地址

- 以下代码用于获取 File 下载地址，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetDownloadUrlExample() {
	getDownloadUrlModel := new(client.OSSGetDownloadUrlRequestModel)
	getDownloadUrlRequest := new(client.OSSGetDownloadUrlRequest)
	getDownloadUrlRequest.SetFilePath("xxx")
	getDownloadUrlRequest.SetDriveId("xxx")
	getDownloadUrlRequest.SetExpireSec(3600)
	getDownloadUrlModel.SetBody(getDownloadUrlRequest)

	response, err := ossClient.GetDownloadUrl(getDownloadUrlModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "ECDF23DD-7EFC-4C09-A89B-4747D08212CA",
   "expiration": "2019-11-07T07:04:08.488Z",
   "method": "GET",
   "url": "https://ccp-daily-test.oss-cn-hangzhou.aliyuncs.com/test_drive%2Fa.jpg?Expires=1573110248\u0026OSSAcce****NnFeg%3D"
}
~~~

### Complete File

- 以下代码用于 Complete File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func CompleteFileExample() {
	completeFileModel := new(client.OSSCompleteFileRequestModel)
	completeFileRequest := new(client.OSSCompleteFileRequest)
	completeFileRequest.SetDriveId("2201")
	completeFileRequest.SetFilePath("xxx")
	completeFileRequest.SetUploadId("xxx")
	completeFileRequest.SetPartInfoList([]*client.UploadPartInfo{})
	completeFileModel.SetBody(completeFileRequest)

	response, err := ossClient.CompleteFile(completeFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "F89A859B-6FC3-4791-B7A2-BB2F0AB78709",
   "content_hash": null,
   "content_hash_name": null,
   "content_type": "image/jpg",
   "crc64_hash": "1864830531212108369",
   "created_at": null,
   "description": null,
   "domain_id": "daily1405",
   "download_url": null,
   "drive_id": "2201",
   "file_extension": null,
   "file_path": "/a.jpg",
   "name": "a.jpg",
   "parent_file_path": "/",
   "share_id": null,
   "size": 0,
   "status": "uploading",
   "thumbnail": null,
   "trashed_at": null,
   "type": "file",
   "updated_at": null,
   "upload_id": "35EE8647048349D09A950DE911F0FBD3",
   "url": null,
   "crc": "1864830531212108369"
}
~~~

### 删除 File

- 以下代码用于删除 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func DeleteFileExample() {
	deleteFileModel := new(client.OSSDeleteFileRequestModel)
	deleteFileRequest := new(client.OSSDeleteFileRequest)
	deleteFileRequest.SetDriveId("1")
	deleteFileRequest.SetFilePath("xxx")
	deleteFileModel.SetBody(deleteFileRequest)

	response, err := ossClient.DeleteFile(deleteFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Headers) // deleteFile接口不返回body，若需获取RequestID，请从Headers中获取
}
~~~

### 列举 Stores File

- 以下代码用于列举 Stores File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func ListStoreFilesExample() {
	listStoreFileModel := new(client.ListStoreFileRequestModel)
	listStoreFileRequest := new(client.ListStoreFileRequest)
	listStoreFileRequest.SetStoreId("xxx")
	listStoreFileRequest.SetParentFilePath("xxx")
	listStoreFileModel.SetBody(listStoreFileRequest)

	response, err := ossClient.ListStorefile(listStoreFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "1536E018-5F86-4927-91E2-89171EDBF792",
   "items": [
      {
         "domain_id": "",
         "name": "bky",
         "parent_file_path": "/",
         "store_id": "90fba2**************ee1d9b",
         "type": "folder"
      },
      {
         "domain_id": "",
         "name": "superadmin",
         "parent_file_path": "/",
         "store_id": "90fba2**************ee1d9b",
         "type": "folder"
      },
      {
         "domain_id": "",
         "name": "test",
         "parent_file_path": "/",
         "store_id": "90fba2**************ee1d9b",
         "type": "folder"
      },
      {
         "domain_id": "",
         "name": "test_drive",
         "parent_file_path": "/",
         "store_id": "90fba2**************ee1d9b",
         "type": "folder"
      }
   ],
   "next_marker": null
}
~~~

## CCPPath Drive 相关API

### 创建 drive

- 以下代码用于创建 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func CreateDriveExample() {
	createDriveModel := new(client.CreateDriveRequestModel)
	createDriveRequest := new(client.CreateDriveRequest)
	createDriveRequest.SetDriveType("normal")
	createDriveRequest.SetDriveName("your drive name")
	createDriveRequest.SetTotalSize(10240000)
	createDriveRequest.SetOwner("your accout id")
	createDriveRequest.SetDescription("test")
	createDriveModel.SetBody(createDriveRequest)

	resp, err := ossClient.CreateDrive(createDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(resp.Body)
}
~~~

- 返回结果

~~~JavaScript
{
   "requestId": "DFACCE19-F046-4739-AFBE-6ABBF0D2DA52",
   "domain_id": "dai****04",
   "drive_id": "1401"
}
~~~

### 列举 drive

- 以下代码用于列举 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func ListDriveExample() {
	listDriveModel := new(client.ListDriveRequestModel)
	listDriveRequest := new(client.ListDriveRequest)
	listDriveRequest.SetLimit(10)
	listDriveRequest.SetOwner("your accout id")

	response, err := ossClient.ListDrives(listDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "F84761E7-03BD-4DEF-875E-7809C1578DD7",
   "items": [
      {
         "requestId": null,
         "creator": "System",
         "description": "Created by system",
         "domain_id": "daily1404",
         "drive_id": "1",
         "drive_name": "Default",
         "drive_type": "normal",
         "owner": "superadmin",
         "relative_path": "",
         "status": "enabled",
         "store_id": "55ff60f************46904",
         "total_size": 1073741824,
         "used_size": 5212716
      }
   ],
   "next_marker": null
}
~~~

### 查询 drive

- 以下代码用于查询 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetDriveExample() {
	getDriveModel := new(client.GetDriveRequestModel)
	getDriveReq := new(client.GetDriveRequest)
	getDriveReq.SetDriveId("301")
	getDriveModel.SetBody(getDriveReq)

	resp, err := ossClient.GetDrive(getDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(resp.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "91F9CCE0-2576-4D85-925A-630B1013B98D",
   "creator": null,
   "description": "测试",
   "domain_id": "dai***1",
   "drive_id": "1401",
   "drive_name": "测试",
   "drive_type": "normal",
   "owner": "superadmin",
   "relative_path": null,
   "status": "enabled",
   "store_id": "55ff6************904",
   "total_size": 100000000,
   "used_size": 0
}
~~~

### 更新 drive

- 以下代码用于更新 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func UpdateDriveExample() {
	updateDriveModel := new(client.UpdateDriveRequestModel)
	updateDriveRequest := new(client.UpdateDriveRequest)
	updateDriveRequest.SetDriveId("your drive id")
	updateDriveRequest.SetDescription("changed drive")

	response, err := ossClient.UpdateDrive(updateDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}

	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "B9B9D80D-932B-4BE2-A106-F2DBC8AEFD3B",
   "creator": null,
   "description": "changed_drive",
   "domain_id": "daily1404",
   "drive_id": "1401",
   "drive_name": "测试",
   "drive_type": "normal",
   "owner": "superadmin",
   "relative_path": null,
   "status": "enabled",
   "store_id": "55ff60f************946904",
   "total_size": 100000000,
   "used_size": 0
}
~~~

### 删除 drive

- 以下代码用于删除 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~~go
func DeleteDriveExample() {
	deleteDriveModel := new(client.DeleteDriveRequestModel)
	deleteDriveRequest := new(client.DeleteDriveRequest)
	deleteDriveRequest.SetDriveId("your drive id ")

	response, err := ossClient.DeleteDrive(deleteDriveModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Headers) // deleteDrive接口不返回body，若需获取RequestID，请从Headers中获取
}
~~~~

## CCPPath File 相关 API

### 创建 File

- 以下代码用于创建 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func CreateFileExample() {
	createFileModel := new(client.CCPCreateFileRequestModel)
	createFileRequest := new(client.CCPCreateFileRequest).SetDriveId("2201").
		SetName("b.txt").
		SetType("file").
		SetParentFileId("/").
		SetContentType("text/plain")
	createFileModel.SetBody(createFileRequest)

	response, err := ccpClient.CreateFile(createFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "1087FD69-4F94-424C-890C-024212DAFB5D",
   "domain_id": "dai***s04",
   "drive_id": "1",
   "file_id": "5dc38ecb4e247b6d547b4335971642f2152fb560",
   "parent_file_id": "root",
   "part_info_list": [
      {
         "etag": null,
         "part_number": 1,
         "part_size": null,
         "upload_url": "https://ccp-daily1404-hz-1571887934.oss-cn-***A4FCFA"
      }
   ],
   "rapid_upload": false,
   "type": "file",
   "upload_id": "6057AF147DA741C29424D537BCA4FCFA"
}
~~~

### 列举 File

- 以下代码用于列举 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func ListFileExample() {
	listFileModel := new(client.CCPListFileRequestModel)
	listFileRequest := new(client.CCPListFileRequest)
	listFileRequest.SetParentFileId("/")
	listFileRequest.SetDriveId("xxx")
	listFileModel.SetBody(listFileRequest)

	response, err := ccpClient.ListFile(listFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}

~~~

- 返回结果

~~~javascript
{
   "requestId": "9427C190-0258-4D76-950E-E3A3BAF1DA00",
   "items": [
      {
         "requestId": null,
         "category": "",
         "content_hash": null,
         "content_hash_name": null,
         "content_type": "",
         "crc64_hash": null,
         "created_at": "2019-11-07T08:09:52.833Z",
         "description": null,
         "domain_id": "daily1404",
         "download_url": null,
         "drive_id": "1",
         "file_extension": "",
         "file_id": "5dc3d150a1571d350f12492096bca248a9f47336",
         "hidden": false,
         "image_media_metadata": null,
         "labels": null,
         "meta": null,
         "name": "test_folder",
         "parent_file_id": "root",
         "size": null,
         "starred": false,
         "status": "available",
         "thumbnail": null,
         "trashed_at": null,
         "type": "folder",
         "updated_at": "2019-11-07T08:09:52.833Z",
         "upload_id": null,
         "url": null
      },
      {
         "requestId": null,
         "category": "image",
         "content_hash": "CB1CFD826047EA301C84BBA1964DE573C57383E3",
         "content_hash_name": "sha1",
         "content_type": "",
         "crc64_hash": null,
         "created_at": "2019-11-07T08:09:52.877Z",
         "description": null,
         "domain_id": "daily1404",
         "download_url": "https://ccp-d***jpg",
         "drive_id": "1",
         "file_extension": "jpg",
         "file_id": "5dc3d150b89a2ee80ac74bc08d18ba5ec1a86568",
         "hidden": false,
         "image_media_metadata": null,
         "labels": null,
         "meta": null,
         "name": "a.jpg",
         "parent_file_id": "root",
         "size": 3448250,
         "starred": false,
         "status": "available",
         "thumbnail": "https://cc****w_128%2Climit_0",
         "trashed_at": null,
         "type": "file",
         "updated_at": "2019-11-07T08:09:54.877Z",
         "upload_id": null,
         "url": "https://ccp-dail**8eyId=LTAIi5kx6X0mwR8k\u0026Signature=WhbAImqKrMmXgJyBzNZ4EWGcBEY%3D"
      }
   ],
   "next_marker": null
}
~~~

### 查询 File

- 以下代码用于查询 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetFileExample() {
	getFileModel := new(client.CCPGetFileRequestModel)
	getFileRequest := new(client.CCPGetFileRequest)
	getFileRequest.SetFileId("xxx")
	getFileRequest.SetDriveId("xxx")
	getFileModel.SetBody(getFileRequest)

	response, err := ccpClient.GetFile(getFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~go
{
   "requestId": "2D44D3FB-97A1-4D78-AD56-B68FE3EF5845",
   "category": "image",
   "content_hash": "CB1CFD826047EA301C84BBA1964DE573C57383E3",
   "content_hash_name": "sha1",
   "content_type": "image/jpg",
   "crc64_hash": "1864830531212108369",
   "created_at": "2019-11-07T08:09:52.877Z",
   "description": "changed_file",
   "domain_id": "daily1404",
   "download_url": "https://ccp-daily1******u0026response-content-disposition=attachment%3Bfilename%3Da.jpg",
   "drive_id": "1",
   "file_extension": "jpg",
   "file_id": "5dc3d150b89a2ee80ac74bc08d18ba5ec1a86568",
   "hidden": false,
   "image_media_metadata": null,
   "labels": null,
   "meta": null,
   "name": "a.jpg",
   "parent_file_id": "root",
   "size": 3448250,
   "starred": false,
   "status": "available",
   "thumbnail": "https://ccp-daily1404-h***28%2Climit_0",
   "trashed_at": null,
   "type": "file",
   "updated_at": "2019-11-07T08:09:54.877Z",
   "upload_id": "CF977B42DE8D4CA38F4EB8334F0C759A",
   "url": "https://ccp-daily1404-hz-1571887934.oss-cn-hangzhou.aliyuncs.com/5db***3D"
}
~~~

### 移动 File

- 以下代码用于移动 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func MoveFileExample() {
	moveFileModel := new(client.CCPMoveFileRequestModel)
	moveFileRequest := new(client.CCPMoveFileRequest)
	moveFileRequest.SetToParentFileId("/")
	moveFileRequest.SetFileId("/xxxx/")
	moveFileRequest.SetDriveId("xxx")
	moveFileModel.SetBody(moveFileRequest)

	response, err := ccpClient.MoveFile(moveFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "BBF646CE-73DF-4A82-A637-5F419E9D220D",
   "async_task_id": null,
   "domain_id": "daily1404",
   "drive_id": "1",
   "file_id": "5dc3d150b89a2ee80ac74bc08d18ba5ec1a86568"
}
~~~

### 复制 File

- 以下代码用于复制 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func CopyFileExample() {
	copyFileModel := new(client.CCPCopyFileRequestModel)
	copyFileRequest := new(client.CCPCopyFileRequest)
	copyFileRequest.SetToParentFileId("/")
	copyFileRequest.SetFileId("/xxxx/")
	copyFileRequest.SetDriveId("xxx")
	copyFileModel.SetBody(copyFileRequest)

	response, err := ccpClient.CopyFile(copyFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "2913878A-663E-4B6B-AD9D-53406AAC7DAB",
   "async_task_id": null,
   "domain_id": "daily1404",
   "drive_id": "1",
   "file_id": "5dc3d15d9d751fdd49d44924b98baf430e84e612"
}
~~~

### 获取 File 上传地址

- 以下代码用于获取 File 上传地址，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetUploadUrlExample() {
	var uploadInfo = new(client.UploadPartInfo)

	getFileUploadUrlModel := new(client.CCPGetUploadUrlRequestModel)
	getFileUploadUrlRequest := new(client.CCPGetUploadUrlRequest)
	getFileUploadUrlRequest.SetUploadId("xxx")
	getFileUploadUrlRequest.SetFileId("/xxxx/")
	getFileUploadUrlRequest.SetDriveId("xxx")
	getFileUploadUrlRequest.SetPartInfoList([]*client.UploadPartInfo{uploadInfo})

	getFileUploadUrlModel.SetBody(getFileUploadUrlRequest)

	response, err := ccpClient.GetUploadUrl(getFileUploadUrlModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "DECE883C-F54C-4B6E-B860-EB02D84BEA53",
   "create_at": "2019-11-07T08:09:53.098Z",
   "domain_id": "daily1404",
   "drive_id": "1",
   "file_id": "5dc3d150b89a2ee80ac74bc08d18ba5ec1a86568",
   "part_info_list": [
      {
         "etag": null,
         "part_number": 1,
         "part_size": null,
         "upload_url": "https://ccp-daily1404-hz-1571887934.oss-cn-hangzhou.aliyuncs.com/5***0026uploadId=CF977B42DE8D4CA38F4EB8334F0C759A"
      }
   ],
   "upload_id": "CF977B42DE8D4CA38F4EB8334F0C759A"
}
~~~

### 获取 File 下载地址

- 以下代码用于获取 File 下载地址，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func GetDownloadUrlExample() {
	getDownloadUrlModel := new(client.CCPGetDownloadUrlRequestModel)
	getDownloadUrlRequest := new(client.CCPGetDownloadUrlRequest)
	getDownloadUrlRequest.SetFileId("xxx")
	getDownloadUrlRequest.SetDriveId("xxx")
	getDownloadUrlRequest.SetExpireSec(3600)
	getDownloadUrlModel.SetBody(getDownloadUrlRequest)

	response, err := ccpClient.GetDownloadUrl(getDownloadUrlModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~JavaScript
{
   "requestId": "BC2B0E86-798A-4537-B621-AD91ECF91F9C",
   "expiration": "2019-11-07T08:24:54.437Z",
   "method": "GET",
   "url": "https://ccp-d*****3Da.jpg"
}
~~~

### Complete File

- 以下代码用于 Complete File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func CompleteFileExample() {
	completeFileModel := new(client.CCPCompleteFileRequestModel)
	completeFileRequest := new(client.CCPCompleteFileRequest)
	completeFileRequest.SetDriveId("2201")
	completeFileRequest.SetFileId("xxx")
	completeFileRequest.SetUploadId("xxx")
	completeFileRequest.SetPartInfoList([]*client.UploadPartInfo{})
	completeFileModel.SetBody(completeFileRequest)

	response, err := ccpClient.CompleteFile(completeFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "77F6CF69-3458-4A2F-9823-F3ED8F919723",
   "category": "image",
   "content_hash": "CB1CFD826047EA301C84BBA1964DE573C57383E3",
   "content_hash_name": "sha1",
   "content_type": "image/jpg",
   "crc64_hash": "1864830531212108369",
   "created_at": "2019-11-07T08:09:52.877Z",
   "description": null,
   "domain_id": "daily1404",
   "download_url": null,
   "drive_id": "1",
   "file_extension": "jpg",
   "file_id": "5dc3d150b89a2ee80ac74bc08d18ba5ec1a86568",
   "hidden": false,
   "image_media_metadata": null,
   "labels": null,
   "meta": null,
   "name": "a.jpg",
   "parent_file_id": "root",
   "size": 3448250,
   "starred": false,
   "status": "available",
   "thumbnail": null,
   "trashed_at": null,
   "type": "file",
   "updated_at": "2019-11-07T08:09:54.877Z",
   "upload_id": "CF977B42DE8D4CA38F4EB8334F0C759A",
   "url": null,
   "crc": null
}
~~~

### 更新 File

- 以下代码用于更新 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func UpdateFile(){
	updateFileModel := new(client.CCPUpdateFileMetaRequestModel)
	updateFileRequest := new(client.CCPUpdateFileMetaRequest)
	updateFileRequest.SetDriveId("1")
	updateFileRequest.SetFileId("xxx")
	updateFileRequest.SetDescription("Changed File")
	updateFileModel.SetBody(updateFileRequest)

	response, err := ccpClient.UpdateFile(updateFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
   "requestId": "5619DE43-D03F-451A-A299-C982C9CE1B3B",
   "category": "image",
   "content_hash": "CB1CFD826047EA301C84BBA1964DE573C57383E3",
   "content_hash_name": "sha1",
   "content_type": "image/jpg",
   "crc64_hash": "1864830531212108369",
   "created_at": "2019-11-07T08:09:52.877Z",
   "description": "changed_file",
   "domain_id": "daily1404",
   "download_url": "https://ccp****sponse-content-disposition=attachment%3Bfilename%3Da.jpg",
   "drive_id": "1",
   "file_extension": "jpg",
   "file_id": "5dc3d150b89a2ee80ac74bc08d18ba5ec1a86568",
   "hidden": false,
   "image_media_metadata": null,
   "labels": null,
   "meta": null,
   "name": "a.jpg",
   "parent_file_id": "root",
   "size": 3448250,
   "starred": false,
   "status": "available",
   "thumbnail": "https://ccp-daily1404-hz-1571887934.oss-cn-hangzhou.aliyuncs.com/5db80819d*****%2Climit_0",
   "trashed_at": null,
   "type": "file",
   "updated_at": "2019-11-07T08:09:54.877Z",
   "upload_id": "CF977B42DE8D4CA38F4EB8334F0C759A",
   "url": "https://ccp-daily1*******%3D"
}
~~~

### 搜索 File

- 以下代码用于搜索 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

~~~go
func SearchFilExample() {
	searchFileModel := new(client.CCPSearchFileRequestModel)
	searchFileRequest := new(client.CCPSearchFileRequest)
	searchFileRequest.SetDriveId("**")
	searchFileRequest.SetQuery(`name match "abc"`)
	searchFileModel.SetBody(searchFileRequest)

	response, err := ccpClient.SearchFile(searchFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
    "requestId": "5396BEA0-7F5C-4C3D-B37F-B1675377A825",
    "items": [
        {
            "requestId": "5619DE43-D03F-451A-A299-C982C9CE1B3B",
            "category": "image",
            "content_hash": "CB1CFD826047EA301C84BBA1964DE573C57383E3",
            "content_hash_name": "sha1",
            "content_type": "image/jpg",
            "crc64_hash": "1864830531212108369",
            "created_at": "2019-11-07T08:09:52.877Z",
            "description": "changed_file",
            "domain_id": "daily1404",
            "download_url": "https://ccp****sponse-content-disposition=attachment%3Bfilename%3Da.jpg",
            "drive_id": "1",
            "file_extension": "jpg",
            "file_id": "5dc3d150b89a2ee80ac74bc08d18ba5ec1a86568",
            "hidden": false,
            "image_media_metadata": null,
            "labels": null,
            "meta": null,
            "name": "a.jpg",
            "parent_file_id": "root",
            "size": 3448250,
            "starred": false,
            "status": "available",
            "thumbnail": "https://ccp-daily1404-hz-1571887934.oss-cn-hangzhou.aliyuncs.com/5db80819d*****%2Climit_0",
            "trashed_at": null,
            "type": "file",
            "updated_at": "2019-11-07T08:09:54.877Z",
            "upload_id": "CF977B42DE8D4CA38F4EB8334F0C759A",
            "url": "https://ccp-daily1*******%3D"
        }
    ],
    "next_marker": null
}
~~~

### 删除 File

- 以下代码用于删除 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```go
func DeleteFileExample() {
	deleteFileModel := new(client.CCPDeleteFileRequestModel)
	deleteFileRequest := new(client.CCPDeleteFileRequest)
	deleteFileRequest.SetDriveId("1")
	deleteFileRequest.SetFileId("xxx")
	deleteFileModel.SetBody(deleteFileRequest)

	response, err := ccpClient.DeleteFile(deleteFileModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Headers) // deleteFile接口不返回body，若需获取RequestID，请从Headers中获取
}
```

### 获取异步任务状态

- 以下代码用于获取一部，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func GetAsyncTaskExample() {
	getAsyncTaskModel := new(client.CCPGetAsyncTaskRequestModel)
	getAsyncTaskRequest := new(client.CCPGetAsyncTaskRequest)
	getAsyncTaskRequest.SetAsyncTaskId("**")
	getAsyncTaskModel.SetBody(getAsyncTaskRequest)

	response, err := ccpClient.GetAsyncTaskInfo(getAsyncTaskModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
  "async_task_id" : "000e89fb-cf8f-11e9-8ab4-b6e980803a3b",
  "message" : "task is running",
  "state" : "success"
}
~~~

### 批量任务

- 以下代码用于执行批量操作，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func BatchExample() {
	var subRequestBody map[string]interface{}

	subRequestBody = make(map[string]interface{})
	subRequestBody["drive_id"] = "**"
	subRequestBody["file_id"] = "***"

	sub := new(client.BatchSubRequest)
	sub.SetBody(subRequestBody)
	sub.SetUrl("/file/get")
	sub.SetMethod("POST")
	sub.SetId("uuid")

	batchModel := new(client.CCPBatchRequestModel)
	batchRequest := new(client.CCPBatchRequest)
	batchRequest.SetResource("file")
	batchRequest.SetRequests([]*client.BatchSubRequest{sub})
	batchModel.SetBody(batchRequest)

	response, err := ccpClient.Operation(batchModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
    "responses":[
        {
            "status":200,
            "body":{
                "file_extension":"txt",
                "updated_at":"2020-03-30T08:15:58.267Z",
                "content_hash":"FAA12FD40AAC1F492082C90C2CD6C03B9ABDB826",
                "domain_id":"hz22",
                "size":36,
                "category":"doc",
                "content_hash_name":"sha1",
                "download_url":"https://ccp-daily-default-c**n-han***Z8bG%2B9C4VII%3D",
                "crc64_hash":"13138712399852734283",
                "drive_id":"1",
                "hidden":false,
                "type":"file",
                "parent_file_id":"root",
                "status":"available",
                "description":"changed_file",
                "encrypt_mode":"none",
                "file_id":"5e81aabdae****d9836b36",
                "content_type":"application/oct-stream",
                "name":"testDJw8oWE6ef9464f66e5034f69aafd57cb2879170b.txt",
                "url":"https://ccp-daily-default-c**n-han***Z8bG%2B9C4VII%3D",
                "created_at":"2020-03-30T08:15:57.361Z",
                "upload_id":"DFD1DA39317F45EC8534FEA57AE420D1",
                "starred":false
            },
            "id":"624830fa2c2347be8c0d8afc76faa04d"
        }
    ]
}
~~~

### 列举已经上传的分片

- 以下代码用于执行批量操作，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

~~~go
func ListUploadedParts() {
	listUploadedPartsModel := new(client.CCPListUploadedPartRequestModel)
	listUploadedPartsRequest := new(client.CCPListUploadedPartRequest)
	listUploadedPartsRequest.SetDriveId("**")
	listUploadedPartsRequest.SetFileId("**")
	listUploadedPartsRequest.SetUploadId("***")
	listUploadedPartsModel.SetBody(listUploadedPartsRequest)

	response, err := ccpClient.ListUploadedParts(listUploadedPartsModel, runtime)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(response.Body)
}
~~~

- 返回结果

~~~javascript
{
  "drive_id" : "1",
  "file_id" : "5d5b846942cf94fa72324c14a4bda34e81da635d",
  "limit" : 1,
  "part_number_marker" : 1,
  "upload_id" : "00668396C0814D818D90F0A92B04B355"
}
~~~

# 附

## 创建 RAM 子用户(获取 AK，SK）

1. 注册阿里云账号，详见[阿里云账号注册流程](https://help.aliyun.com/document_detail/37195.html?spm=a2c4g.11186623.2.13.6a857007v5sxu1)。
2. 开启访问控制服务，详见[RAM访问控制](https://ram.console.aliyun.com/overview)，并根据提示操作。
3. 创建 RAM 子用户，并获取 AK，SK。详见[服务端调用接口接入](https://help.aliyun.com/document_detail/134467.html?spm=a2c4g.11186623.6.551.646a6d39hQ1bQt#h2-3-3)。SK要注意保密不要泄露。 

## 创建 APP(获取 ClientID, ClientSecret）

1.  首先，您需要开通内容协作平台(CCP）服务。如果没有开通，请到[产品详情页面](https://www.aliyun.com/product/ccp)开通 。
2.  您需要在CCP官网控制台创建一个域(Domain) 。详见创建[CCPath域实例](https://help.aliyun.com/document_detail/134467.html?spm=a2c4g.11186623.6.551.2f134190GNe6T2#h2-2-2)和创建[OSSPath域实例](https://help.aliyun.com/document_detail/135607.html?spm=a2c4g.11186623.6.552.26cd2c6ciSU8xM#h2-1-1)。
3.  创建 APP，选择类型为”Web服务应用”。确定 APP 的访问 Scope: [支持的Scope列表](https://help.aliyun.com/document_detail/135388.html), 这个Scope要在用户授权页面展示。创建完成，可以得到 APP ID(ClientID) 和 Secret(ClientSecret)。这个是授权认证的凭证，Secret 要注意保密不要泄露。 

## 参数说明
~~~go
type Config struct {
	Endpoint        *string // endpoint
	DomainId        *string // 域名
	Region          *string // region id
	Protocol        *string // 请求协议
	Type            *string // 凭证类型，如有疑问请参考 https://github.com/aliyun/credentials-go/blob/master/README-CN.md#%E5%87%AD%E8%AF%81%E7%B1%BB%E5%9E%8B
	SecurityToken   *string // Security Token
	AccessKeyId     *string // AccessKey Id
	AccessKeySecret *string // AccessKey Secret
	ClientId        *string // 客户端 ID
	RefreshToken    *string // refresh token
	ClientSecret    *string // 客户端密钥
	AccessToken     *string // access token
	ExpireTime      *string // 过期时间
	Nickname        *string // nick name
	UserAgent       *string // UserAgent
}

type RuntimeOptions struct {
	Autoretry        *bool       // 是否开启重试
	IgnoreSSL        *bool       // 是否忽略 SSL 校验
	MaxAttempts      *int        // 最大重试次数， 默认为 3
	BackoffPolicy    *string     // 重试休眠策略，默认为 no
	BackoffPeriod    *int        // 重试休眠时间， 默认为 1
	ReadTimeout      *int        // 读超时
	ConnectTimeout   *int        // 连接超时
	LocalAddr        *string     // 本地网卡 ip
	HttpProxy        *string     // http 的代理
	HttpsProxy       *string     // https 的代理
	NoProxy          *string     // 代理白名单
	MaxIdleConns     *int        // 最大连接数
	Socks5Proxy      *string     // socks5 代理
	Socks5NetWork    *string     // socks5 代理协议
}
~~~

## CCPPath 上传文件

~~~go
package main

import (
	"fmt"
	"net/http"
	"os"
	"strings"

	"github.com/alibabacloud-go/ccppath-sdk/client"
)

var clientConf = new(client.Config).
	SetDomainId("{Domain ID}").
	SetProtocol("https").
	SetAccessKeyId(os.Getenv("ACCESS_KEY_ID")).
	SetAccessKeySecret(os.Getenv("ACCESS_KEY_SECRET"))

var runtime = new(client.RuntimeOptions)

var ccpClient, _ = client.NewClient(clientConf)

func main() {
	createFile()
}

func createFile() {
	// create file
	fmt.Println("******************create file******************")
	createFileModel := new(client.CCPCreateFileRequestModel)
	createFileRequest := new(client.CCPCreateFileRequest).
		SetDriveId("1").
		SetName("b.txt").
		SetType("file").
		SetParentFileId("root").
		SetContentType("text/plain")
	createFileModel.SetBody(createFileRequest)
	response, err := ccpClient.CreateFile(createFileModel, runtime)
	if err != nil {
		fmt.Println(err.Error())
		return
	}
	var uploadUrl, uploadId, FileId *string
	fmt.Println(response.Body)
	if response != nil {
		uploadUrl = response.Body.PartInfoList[0].UploadUrl
		uploadId = response.Body.UploadId
		FileId = response.Body.FileId

		// upload file
		// 此处可以使用 os.Open() 上传本地文件， 具体使用请参考 os package。
		fmt.Println("******************upload file******************")
		content := strings.NewReader("12345678")
		req, _ := http.NewRequest("PUT", *uploadUrl, content)
		req.Header.Add("Content-Type", "")
		res, _ := http.DefaultClient.Do(req)

		Etag := res.Header.Get("ETag")
		uploadPartInfo := new(client.UploadPartInfo)
		uploadPartInfo.SetEtag(Etag)
		uploadPartInfo.SetPartNumber(1)

		// complete file
		fmt.Println("******************complete file******************")
		completeFileModel := new(client.CCPCompleteFileRequestModel)
		completeFileRequest := new(client.CCPCompleteFileRequest).
			SetDriveId("1").
			SetFileId(*FileId).
			SetUploadId(*uploadId).
			SetPartInfoList([]*client.UploadPartInfo{uploadPartInfo})
		completeFileModel.SetBody(completeFileRequest)

		completeResponse, completeErr := ccpClient.CompleteFile(completeFileModel, runtime)
		if completeErr != nil {
			fmt.Println(completeErr.Error())
		}
		if completeResponse != nil {
			fmt.Println(completeResponse.Body)
		}
	}
}
~~~

