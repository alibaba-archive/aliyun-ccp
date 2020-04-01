# 下载地址

>  *https://github.com/aliyun/aliyun-ccp* 

# 安装步骤

## 安装 Java 开发环境

目前，CCPJava SDK 支持 J2SE 6.0 及以上的 Java 运行环境，您可以从 [Java 官方网站](http://developers.sun.com/downloads/) 下载并按说明安装 Java 开发环境。

## 安装 CCP Java SDK

安装完 Java 开发环境后，您需要安装CCP SDK，将下面的依赖加入 pom.xml 。

CCPPath

```xml
<dependency>
    <groupId>com.aliyun</groupId>
    <artifactId>ccp-client</artifactId>
    <version>RELEASE</version>
</dependency>
```

OSSPath

~~~xml
<dependency>
    <groupId>com.aliyun</groupId>
    <artifactId>ccp-oss-client</artifactId>
    <version>RELEASE</version>
</dependency>
~~~

**注意：请关注 [Git Hub](https://github.com/aliyun/aliyun-ccp)提供的最新版本，查看相关功能并选择使用。**

# 初始化Client

> 使用前提是您已经开通CCP服务， 并且在控制台创建了域实例。参见[快速搭建云盘服务](https://help.aliyun.com/document_detail/134414.html?spm=a2c4g.11186623.6.548.1dff3d920lbfQ9)。之后您可以按需初始化CCPClient 或者 OSSClient。

## AK & SK 初始化客户端

> AK, SK 的获取详见 [密钥管理页面](https://ak-console.aliyun.com/?spm=a2c4g.11186623.2.15.336a70074HZbUf)。选择一对用于 SDK 的访问密钥对。如果没有，请创建一对新访问密钥，且保证它处于启用状态。有关如何创建访问密钥，参见 [创建访问密钥](https://help.aliyun.com/document_detail/48930.html)。 

```java
import com.aliyun.ccp.ccpclient.Client;
import com.aliyun.ccp.ccpclient.models.*;

public class Demo {
    private static Client client;
    private static RuntimeOptions runtime;
    
    public static void createClient() throws IllegalAccessException {
        Config config = new Config();
        config.domainId = "your domainId";
        config.protocol = "https";
        config.accessKeyId = System.getenv("accessKeyId");
        config.accessKeySecret = System.getenv("accessKeySecret");
        client = new Client(config);
        runtime = new RuntimeOptions();
    }
}
```

## AccessToken & RefreshToken 初始化客户端

> clientId, clientSecret 的获取详见[应用接入指南](https://help.aliyun.com/document_detail/135390.html?spm=a2c4g.11186623.6.559.43b61f755UC71N)。

```java
import com.aliyun.ccp.ccpclient.Client;
import com.aliyun.ccp.ccpclient.models.*;

public class Demo {
    private static Client client;
    private static RuntimeOptions runtime;
    
    public static void createClient() throws IllegalAccessException {
        Config config = new Config();
        config.domainId = "your domainId";
        config.protocol = "https";
        config.clientId = System.getenv("clientId");
        config.clientSecret = System.getenv("clientSecret");
        config.accessToken = System.getenv("accessToken");
        config.refreshToken =  System.getenv("refreshToken");
        config.expireTime =   System.getenv("expireTime");
        client = new Client(config);
        runtime = new RuntimeOptions();
    }
}
```

**注意：AK & SK 模式 和 Access Token & Refresh Token 模式 同时只能存在一种**



# 构造请求

## Account 相关 API

### 获取图片验证码

- 以下代码用于获取图片验证码，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 获取图片验证码
public static void getCaptcha() throws Exception {
    try {
        GetCaptchaRequestModel requestModel = new GetCaptchaRequestModel();
        GetCaptchaRequest getCaptchaRequest = new GetCaptchaRequest();
        getCaptchaRequest.appId = "***********";
        requestModel.body = getCaptchaRequest;
        GetCaptchaModel captcha = client.getCaptcha(requestModel, runtime);
        // 打印结果
        System.out.println(new Gson().toJson(captcha.body.captcha));

    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(e.getData());
    }
}

~~~



- 返回结果

~~~JavaScript
{
    "captcha":"iVBORw0KGgoAAAANSUhEUgAAAFAAAAAaCAIAAACvsEzwAAABFUlEQVR42u3YwQ7CIAwGYOKDaLya7OBL+BDePRoT4/vPJSSEjFJ+2oEIW3oy0PHRDnVmHuwyO3gH93J9Xm85+PA4+REOmKYLGbGE5/vVBn/f2/O4hMZs9FrSjIMdtVEwKSSLTG7Bb8HZLc30MALmB7QLlmkHAiPa3sDIsE7AYHkbAtvvaw0YHNlQhRezZeee0nh5BWC/EkVamjHHtqAoWGbOe4ZtqZFfWrmHcxhIhYuD3Z2S2gpgmVn450G2u8i5mOzn1aFlV7LKwCQ0FRaqTOWcsSPazvUzZIPJbStaahCMT48lNIjHD0GpkQzKftkMzK9e8/yHecLPwZ0ihZuBK7yFKTq9uXdamp7/M7Df22JPcsxw4C/GgzEzOWpc1QAAAABJRU5ErkJggg==",
    "captchaFormat":"png",
    "captchaId":"f644d0b2a7d21a3caddb17377c90c28e8DPXYUIfvs3"
}
~~~



### 获取短信验证码

- 以下代码用于获取短信验证码，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void getMNSCode() throws Exception {
    try {
        MobileSendSmsCodeRequestModel requestModel = new MobileSendSmsCodeRequestModel();
        MobileSendSmsCodeRequest sendSmsCodeRequest = new MobileSendSmsCodeRequest();
        sendSmsCodeRequest.appId = appId;
        sendSmsCodeRequest.phoneNumber = "13**********5";
        sendSmsCodeRequest.type = "change_password";
        requestModel.body = sendSmsCodeRequest;

        MobileSendSmsCodeModel response = client.mobileSendSmsCode(requestModel, runtime);

        System.out.println(new Gson().toJson(response.body));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}
~~~



- 返回结果

~~~javascript
{
    "smsCodeId":"b40bba70b37d74**********************6j3IW7HP"
}
~~~



### 验证手机号是否注册

- 以下代码用于验证手机号是否存在，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void checkMobileIsExist() throws Exception {
    try {
        MobileCheckExistRequestModel requestModel = new MobileCheckExistRequestModel();
        MobileCheckExistRequest checkExistRequest = new MobileCheckExistRequest();
        checkExistRequest.appId = appId;
        checkExistRequest.phoneNumber = "13*****25";
        requestModel.body = checkExistRequest;
        CheckExistModel checkExistResponse = client.checkExist(requestModel, runtime);
        
        System.out.println(new Gson().toJson(checkExistResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }
}
~~~



- 返回结果

~~~javascript
{
    "isExist":true,
    "phoneNumber":"13****25"
}
~~~



### 手机号注册

- 以下代码用于手机号注册，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void register() throws Exception {
    try {
        MobileRegisterRequestModel requestModel = new MobileRegisterRequestModel();
        MobileRegisterRequest registerRequest = new MobileRegisterRequest();
        registerRequest.appId = appId;
        registerRequest.phoneNumber = "132****225";
        registerRequest.smsCode = "0****0";
        registerRequest.smsCodeId = "674e************JRuoQgRu0R";
        requestModel.body = registerRequest;

        RegisterModel tokenResponse = client.register(requestModel, runtime);

        System.out.println(new Gson().toJson(tokenResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}
~~~

- <span id="jump">返回结果</span>


~~~javascript
{
    "access_token": "eyJhbGc***************iOiJSUzI1NiI",
    "refresh_token": "fvw1FLZ************tGjXxJl",
    "expires_in": 7200,
    "token_type": "Bearer",
    "user_id": "6c23c98d3***************3f9f5211",
    "user_name": "132******225",
    "avatar": "",
    "nick_name": "1329*****225",
    "default_drive_id": "",
    "role": "admin",
    "expire_time": "2019-10-30T11:44:24Z",
    "state": "",
    "exist_link": [],
    "need_link": false,
    "user_data": {}
}
~~~



### 手机号短信登录

- 以下代码用于短信登录，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void mnsLogin() throws Exception {
    try {
        // mns login
        MobileLoginRequestModel requestModel = new MobileLoginRequestModel();
        MobileLoginRequest mobileLoginRequest = new MobileLoginRequest();
        mobileLoginRequest.appId = appId;
        mobileLoginRequest.phoneNumber = "132**********#=&";
        mobileLoginRequest.smsCode = "123456";
        mobileLoginRequest.smsCodeId = changePasswordCode;
        requestModel.body = mobileLoginRequest;
        LoginModel tokenResponse = client.login(requestModel, runtime);
        System.out.println(new Gson().toJson(tokenResponse));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }
}
~~~



- 返回结果参见[手机号注册的返回结果](#手机号注册)



### 设置登录密码

- 以下代码用于设置登录密码，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void setPassWord() throws Exception {
    try {
        DefaultSetPasswordRequestModel requestModel = new DefaultSetPasswordRequestModel();
        DefaultSetPasswordRequest setPasswordRequest = new DefaultSetPasswordRequest();
        setPasswordRequest.appId = appId;
        setPasswordRequest.newPassword = "1234567";
        setPasswordRequest.state = "";
        requestModel.body =setPasswordRequest;
        client.setPassword(requestModel, runtime);
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}

~~~



### 密码登录

- 以下代码用于密码登录，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java

// 密码登录
public static void passwordLogin() throws Exception {
    try {
        MobileLoginRequestModel requestModel = new MobileLoginRequestModel();
        MobileLoginRequest mobileLoginRequest = new MobileLoginRequest();
        mobileLoginRequest.appId = appId;
        mobileLoginRequest.phoneNumber = "132******25";
        mobileLoginRequest.password = "123********456";
        requestModel.body = mobileLoginRequest;
        LoginModel tokenResponse = client.login(requestModel, runtime);
        System.out.println(new Gson().toJson(tokenResponse.body));
        assertNotNull(tokenResponse.body.accessToken);

    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(e.getData());
    }
}

~~~



- 返回结果参见[手机号注册的返回结果](#手机号注册)



### 修改登录密码

- 以下代码用于修改登录密码，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void changePassWord() throws Exception {
    try {
        DefaultChangePasswordRequestModel requestModel = new DefaultChangePasswordRequestModel();
        DefaultChangePasswordRequest changePasswordRequest = new DefaultChangePasswordRequest();
        changePasswordRequest.appId = appId;
        changePasswordRequest.phoneNumber = "13*****25";
        changePasswordRequest.newPassword = "12*****9";
        changePasswordRequest.smsCode = "6*****73";
        changePasswordRequest.smsCodeId = "9751***********wru";
        requestModel.body = changePasswordRequest;

        client.changePassword(requestModel, runtime);
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}
~~~



### 通过刷新令牌获取访问令牌

- 以下代码用于刷新token，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void getTokenByRefreshToken() throws Exception {
    try {
        TokenRequestModel requestModel = new TokenRequestModel();
        TokenRequest tokenRequest = new TokenRequest();
        tokenRequest.appId = appId;
        tokenRequest.grantType = "refresh_token";
        tokenRequest.refreshToken = "CzuJktQK*********TAVTJorJa";
        requestModel.body = new TokenRequest();

        TokenModel tokenResponse = client.token(requestModel, runtime);
        System.out.println(new Gson().toJson(tokenResponse));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
    }

}
~~~



- 返回结果参见[手机号注册的返回结果](#手机号注册)



### 通过账号获取访问令牌

- 以下代码用于获取用户认证方式，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~JAVA
public void getAccessTokenByLinkInfo() throws Exception {
    try {
        // 此接口需要ak，sk调用， 请使用ak, sk初始化客户端
        GetAccessTokenByLinkInfoRequestModel requestModel = new GetAccessTokenByLinkInfoRequestModel();
        GetAccessTokenByLinkInfoRequest getAccessTokenByLinkInfoRequest = new GetAccessTokenByLinkInfoRequest();
        getAccessTokenByLinkInfoRequest.identity = "132********25";
        getAccessTokenByLinkInfoRequest.type = "mobile";
        requestModel.body = getAccessTokenByLinkInfoRequest;

        GetAccessTokenByLinkInfoModel tokenResponse = client.getAccessTokenByLinkInfo(requestModel, runtime);
        System.out.println(new Gson().toJson(tokenResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}
~~~

- 返回结果参见[手机号注册的返回结果](#手机号注册)


### 获取用户绑定信息

- 以下代码用于获取用户认证方式，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

```JAVA
public void getLinkInfoByUserId() throws Exception {
    try {
        // 此接口需要ak，sk调用， 请使用ak, sk初始化客户端
        GetLinkInfoByUserIDRequestModel requestModel = new GetLinkInfoByUserIDRequestModel();
        GetLinkInfoByUserIDRequest linkInfoByUserIDRequest = new GetLinkInfoByUserIDRequest();
        linkInfoByUserIDRequest.userId = "6c23*********5211";
        requestModel.body = linkInfoByUserIDRequest;
        GetLinkInfoByUserIdModel listResponse = client.getLinkInfoByUserId(requestModel, runtime);
        System.out.println(new Gson().toJson(listResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }


```

- 返回结果

~~~javascript
{
    "items":[
        {
            "authenticationType":"mobile",
            "createdAt":1571905906341,
            "domainId":"daily1405",
            "identity":"13******225",
            "lastLoginTime":1571905906341,
            "status":"normal",
            "userId":"6c23c9******3f9f5211"
        }
    ]
}
~~~



### 获取用户认证方式

- 以下代码用于获取用户认证方式，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void getLinkInfo() throws Exception {
    try {
        // 此接口需要ak，sk调用， 请使用ak, sk初始化客户端
        GetByLinkInfoRequestModel requestModel = new GetByLinkInfoRequestModel();
        GetByLinkInfoRequest getByLinkInfoRequest = new GetByLinkInfoRequest();
        getByLinkInfoRequest.identity = "adsfqwrsfad";
        getByLinkInfoRequest.type = "ding";
        requestModel.body = getByLinkInfoRequest;
        GetLinkInfoModel linkInfoResponse = client.getLinkInfo(requestModel, runtime);
        System.out.println(new Gson().toJson(linkInfoResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}
~~~



- 返回结果

~~~javascript
{
    "authenticationType":"ding",
    "createdAt":1572427460313,
    "domainId":"daily1405",
    "identity":"adsfqwrsfad",
    "lastLoginTime":1572427460313,
    "status":"wait_link",
    "userId":"6c23c98*****7d8b3f9f5211"
}
~~~

### 绑定用户认证方式

- 以下代码用于绑定用户认证方式，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~JAVA
public void userLinkInfo() throws Exception {
    try {
        // 此接口需要ak，sk调用， 请使用ak, sk初始化客户端
        AccountLinkRequestModel requestModel = new AccountLinkRequestModel();
        AccountLinkRequest linkInfo = new AccountLinkRequest();
        linkInfo.type = "taobao";
        linkInfo.identity = "1234";
        linkInfo.userId = "1eb15*************eff97708cb";
        linkInfo.status ="wait_link";
        requestModel.body = linkInfo;
        LinkModel tokenResponse = new_client.link(requestModel, runtime);
        System.out.println(new Gson().toJson(tokenResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}
~~~



- 返回结果

~~~javascript
{
    "avatar":"",
    "defaultDriveId":"",
    "existLink":[
        {
            "identity":"13*****225",
            "type":"mobile"
        }
    ],
    "expireTime":"",
    "expiresIn":300,
    "needLink":true,
    "nickName":"",
    "refreshToken":"",
    "role":"",
    "state":"",
    "tokenType":"Bearer",
    "userId":"",
    "userName":""
}
~~~



### 取消绑定关系

- 以下代码用于取消绑定关系，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void cancelLink() throws Exception {
    try {
        CancelLinkRequestModel requestModel = new CancelLinkRequestModel();
        CancelLinkRequest cancelLinkRequest = new CancelLinkRequest();
        cancelLinkRequest.temporaryToken = "eyJhbGciOiJSUzI1N*****pwc";
        requestModel.body = cancelLinkRequest;
        CancelLinkModel tokenResponse = client.cancelLink(requestModel, runtime);

        System.out.println(new Gson().toJson(tokenResponse.body));;
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}
~~~



- 返回结果参见[手机号注册的返回结果](#手机号注册)





### 确定绑定关系

- 以下代码用于确定绑定关系，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。
- 此接口只支持Access Token，不要使用AK，SK初始化客户端。

~~~java
public void confirmLink() throws Exception {
    try {
        ConfirmLinkRequestModel requestModel = new ConfirmLinkRequestModel();
        ConfirmLinkRequest confirmLinkRequest = new ConfirmLinkRequest();
        confirmLinkRequest.temporaryToken = "eyJhbGciOiJSUzI1NiIsI（***qE";
        requestModel.body = confirmLinkRequest;
        ConfirmLinkModel tokenResponse = client.confirmLink(requestModel, runtime);

        System.out.println(new Gson().toJson(tokenResponse));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }

}
~~~



- 返回结果参见[手机号注册的返回结果](#手机号注册)





## User 相关 API

### 创建User

- 以下代码用于创建User，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

```java

// 创建User
public static void createUser() throws Exception {
    try {
        CreateUserRequestModel requestModel = new CreateUserRequestModel();
        CreateUserRequest createUserRequest = new CreateUserRequest();
        createUserRequest.userId = "***";
        createUserRequest.role = "***";;
        createUserRequest.userName = "***";;
        requestModel.body = createUserRequest;
        CreateUserModel createUserResponse = client.createUser(requestModel, runtimeOptions);
        System.out.println(new Gson().toJson(createUserResponse.body));

    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

```

- 返回结果

```javascript
{
    "avatar":"",
    "createdAt":1572225460185,
    "defaultDriveId":"",
    "description":"",
    "domainId":"daily1405",
    "email":"",
    "nickName":"",
    "phone":"",
    "role":"user",
    "status":"enabled",
    "updatedAt":0,
    "userId":"test_user",
    "userName":"test_user"
}
```

### 获取User

- 以下代码用于获取User，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~~java
//获取User
public static void getUser() throws Exception {
    try {
        GetUserRequestModel requestModel = new GetUserRequestModel();
        GetUserRequest getUserRequest = new GetUserRequest();
        getUserRequest.userId = "****";
        requestModel.body = getUserRequest;
        GetUserModel getUserResponse = client.getUser(requestModel, runtimeOptions);

        System.out.println(new Gson().toJson(getUserResponse.body));

    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~~

- 返回结果

~~~javascript
{
    "avatar":"",
    "createdAt":1572226149810,
    "defaultDriveId":"",
    "description":"",
    "domainId":"daily1405",
    "email":"",
    "nickName":"",
    "phone":"",user
    "role":"user",
    "status":"enabled",
    "updatedAt":0,
    "userId":"test_user",
    "userName":"test_user"
}
~~~

### 列举User

- 以下代码用于列举User，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~~java
//列举User

public static void listUser() throws Exception {
    try {
        ListUserRequestModel requestModel = new ListUserRequestModel();
        ListUserRequest listUserRequest = new ListUserRequest();
        listUserRequest.limit = 10;
        requestModel.body = listUserRequest;
        ListUsersModel listUserResponse = client.listUsers(requestModel, runtimeOptions);
        
        System.out.println(new Gson().toJson(listUserResponse.body));

    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~~

- 返回结果

~~~javascript
{
    "items":[
        {
            "avatar":"",
            "createdAt":1571903980532,
            "defaultDriveId":"",
            "description":"",
            "domainId":"daily1405",
            "email":"",
            "nickName":"xxxxxx",
            "phone":"",
            "role":"user",
            "status":"enabled",
            "updatedAt":1571903980532,
            "userId":"1eb15a*****************8cb",
            "userName":"xxxxxx"
        },
        {
            "avatar":"",
            "createdAt":1571915575499,
            "defaultDriveId":"",
            "description":"",
            "domainId":"daily1405",
            "email":"",
            "nickName":"xxxxxx",
            "phone":"",
            "role":"user",
            "status":"enabled",
            "updatedAt":1571915575499,
            "userId":"51901a4************dbf5",
            "userName":"xxxxxx"
        },
        {
            "avatar":"",
            "createdAt":1571903776751,
            "defaultDriveId":"",
            "description":"",
            "domainId":"daily1405",
            "email":"",
            "nickName":"xxxxxx",
            "phone":"",
            "role":"user",
            "status":"enabled",
            "updatedAt":1571903776751,
            "userId":"621a3c***************8ecd",
            "userName":"xxxxxx"
        },
        {
            "avatar":"",
            "createdAt":1571905906346,
            "defaultDriveId":"",
            "description":"",
            "domainId":"daily1405",
            "email":"",
            "nickName":"1329***25",
            "phone":"132****25",
            "role":"admin",
            "status":"enabled",
            "updatedAt":1571907859554,
            "userId":"6c23c98****************f5211",
            "userName":"132**********5"
        },
        {
            "avatar":"",
            "createdAt":1572226835585,
            "defaultDriveId":"",
            "description":"",
            "domainId":"daily1405",
            "email":"",
            "nickName":"",
            "phone":"",
            "role":"admin",
            "status":"enabled",
            "updatedAt":0,
            "userId":"xxxxxx",
            "userName":"xxxxxx"
        },
        {
            "avatar":"",
            "createdAt":1571887988846,
            "defaultDriveId":"",
            "description":"",
            "domainId":"daily1405",
            "email":"",
            "nickName":"superadmin",
            "phone":"",
            "role":"superadmin",
            "status":"enabled",
            "updatedAt":0,
            "userId":"superadmin",
            "userName":"superadmin"
        }
    ],
    "nextMarker":""
}
~~~



### 更新User

- 以下代码用于更新User，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
//更新User
public static void updateUser() throws Exception {
    try {
        UpdateUserRequestModel requestModel = new UpdateUserRequestModel();
        UpdateUserRequest updateUserRequest = new UpdateUserRequest();
        updateUserRequest.description = "test_user";
        updateUserRequest.userId = "***";
        requestModel.body = updateUserRequest;
        UpdateUserModel updateUserResponse = client.updateUser(requestModel, runtimeOptions);

        System.out.println(new Gson().toJson(updateUserResponse.body));

    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~javascript
{
    "avatar":"",
    "createdAt":1572226835585,
    "defaultDriveId":"",
    "description":"test_user",
    "domainId":"daily1405",
    "email":"",
    "nickName":"",
    "phone":"",
    "role":"user",
    "status":"enabled",
    "updatedAt":1572226880276,
    "userId":"test_user",
    "userName":"test_user"
}
~~~



### 搜索User

- 以下代码用于搜索User，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// search user
public static void searchUser() throws Exception {
    try {
        SearchUserRequestModel requestModel = new SearchUserRequestModel();
        SearchUserRequest searchUserRequest = new SearchUserRequest();
        searchUserRequest.userName = "***";
        requestModel.body = searchUserRequest;
        SearchUserModel listUserResponse1 = client.searchUser(requestModel, runtimeOptions);
        
        System.out.println(new Gson().toJson(listUserResponse1.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}


~~~



- 返回结果

~~~javascript
{
    "items":[
        {
            "avatar":"",
            "createdAt":1571915575499,
            "defaultDriveId":"",
            "description":"",
            "domainId":"daily1405",
            "email":"",
            "nickName":"刘***",
            "phone":"",
            "role":"user",
            "status":"enabled",
            "updatedAt":1571915575499,
            "userId":"5190******************2edbf5",
            "userName":"刘***"
        }
    ],
    "nextMarker":""
}
~~~



### 删除User

- 以下代码用于删除User，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 删除User

public static void deleteUser() throws Exception {
    try {
        DeleteUserRequestModel requestModel = new DeleteUserRequestModel();
        DeleteUserRequest deleteUserRequest = new DeleteUserRequest();
        deleteUserRequest.userId = "***";
        requestModel.body = deleteUserRequest;

        DeleteUserModel deleteUserResponse = client.deleteUser(requestModel, runtimeOptions);

        //此接口没有返回body
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



## OSSPath Drive 相关API

### 说明

- OSSPath 创建drive 需要先拿到`store_id`，需要先调用`/v2/domain/list_stores`的接口。

### 创建drive

- 以下代码用于创建Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public static void createDrive() throws Exception {
    try {
        // 获取store_id
        AdminListStoresRequestModel requestModel = new AdminListStoresRequestModel();
        AdminListStoresRequest listStoresRequest = new AdminListStoresRequest();
        requestModel.body = listStoresRequest;
        AdminListStoresModel listStoresResponse = client.adminListStores(requestModel, runtime);
        //打印结果
        System.out.println(new Gson().toJson(listStoresResponse.body));

        // 根据自己的需求从返回的结果中选择store_id
        String storeId = listStoresResponse.body.items.get(0).storeId;

        //创建drive
        reateDriveRequestModel requestModel1 = new CreateDriveRequestModel();
        CreateDriveRequest createDriveRequest = new CreateDriveRequest();
        createDriveRequest.totalSize = 1000000L;
        createDriveRequest.driveName = "java-sdk-test_drive";
        createDriveRequest.description = "java-sdk-test_drive";
        createDriveRequest.driveType = "normal";
        createDriveRequest.relativePath = "/test_drive/";
        createDriveRequest.storeId = storeId;
        createDriveRequest.owner = userId;
        requestModel1.body = createDriveRequest;
        CreateDriveModel createDriveResponse = client.createDrive(requestModel1, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(createDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
// list_stores response
{
    "items":[
        {
            "accelerateEndpoint":"",
            "basePath":"",
            "bucket":"ccp-daily-test",
            "customizedEndpoint":"",
            "endpoint":"https://oss-cn-hangzhou.aliyuncs.com",
            "internalEndpoint":"",
            "ownership":"custom",
            "policy":"",
            "roleArn":"",
            "storeId":"90fba27e9c40452d91d83b204aee1d9b",
            "type":"oss"
        }
    ]
}

// create drive response
{
    "requestId":"E72DDD97-E99F-437D-B0B8-7C752C4E9548",
    "domainId":"daily1405",
    "driveId":"1902"
}
~~~



列举drive

- 以下代码用于列举Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

```java
// 列举 Drive 
public static void listDrive() throws Exception {
    try {
        ListDriveRequestModel requestModel = new ListDriveRequestModel();
        ListDriveRequest listDriveRequest = new ListDriveRequest();
        listDriveRequest.limit = 1;
        listDriveRequest.owner = userId;
        requestModel.body = listDriveRequest;
        ListDrivesModel listDriveResponse = client.listDrives(requestModel3, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}


```



- 返回结果

```javascript
{
    "items":[
        {
            "creator":"6c23c*************211",
            "description":"drive",
            "domainId":"daily1405",
            "driveId":"1902",
            "driveName":"test_drive",
            "driveType":"normal",
            "owner":"6c23c*************211",
            "relativePath":"/test_drive/",
            "status":"enabled",
            "storeId":"90fba27e9c40452d91d83b204aee1d9b",
            "totalSize":1000000,
            "usedSize":0
        }
    ],
    "nextMarker":""
}
```



### 查询drive

- 以下代码用于查询Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 查询 Drive
public static void getDrive() throws Exception {
    try {
        GetDriveRequestModel requestModel = new GetDriveRequestModel();
        GetDriveRequest getDriveRequest = new GetDriveRequest();
        getDriveRequest.driveId = "2801";
        requestModel.body = getDriveRequest;
        GetDriveModel getDriveResponse = client.getDrive(requestModel, runtime);

        System.out.println(new Gson().toJson(getDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~JavaScript
{
    "creator":"6c23c9*************f5211",
    "description":"test_drive",
    "domainId":"daily1405",
    "driveId":"1902",
    "driveName":"test_drive",
    "driveType":"normal",
    "owner":"6c23c9***************f5211",
    "relativePath":"/test_drive/",
    "status":"enabled",
    "storeId":"90fba27e9c40452d91d83b204aee1d9b",
    "totalSize":1000000,
    "usedSize":0
}
~~~

### 列举drive

- 以下代码用于更新Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 列举 Drive 
public static void listDrive() throws Exception {
    try {
        ListDriveRequestModel requestModel = new ListDriveRequestModel();
        ListDriveRequest listDriveRequest = new ListDriveRequest();
        listDriveRequest.limit = 1;
        listDriveRequest.owner = userId;
        requestModel.body = listDriveRequest;
        ListDrivesModel listDriveResponse = client.listDrives(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~javascript
{
    "items":[
        {
            "creator":"",
            "description":"",
            "domainId":"daily1405",
            "driveId":"603",
            "driveName":"test_drive",
            "driveType":"normal",
            "owner":"****",
            "relativePath":"/test_drive/",
            "status":"enabled",
            "storeId":"55ff********904",
            "totalSize":100000,
            "usedSize":0
        }
    ],
    "nextMarker":""
}

~~~



### 更新drive

- 以下代码用于更新Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 更新 Drive
public static void updateDrive() throws Exception {
    try {
        UpdateDriveRequestModel requestModel = new UpdateDriveRequestModel();
        UpdateDriveRequest updateDriveRequest = new UpdateDriveRequest();
        updateDriveRequest.driveId = "2801";
        updateDriveRequest.description = "changed_drive";
        updateDriveRequest.totalSize = 1000000L;
        requestModel.body = updateDriveRequest;
        UpdateDriveModel updateDriveResponse = client.updateDrive(requestModel0, runtime);


        // 打印结果
        System.out.println(new Gson().toJson(updateDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~JavaScript
{
    "requestId":"D88BC954-0BE8-4282-BDF3-6F964FC113DF",
    "creator":"6c23c**************9f5211",
    "description":"changed_drive",
    "domainId":"daily1405",
    "driveId":"1902",
    "driveName":"test_drive",
    "driveType":"normal",
    "owner":"6c23c9************5211",
    "relativePath":"/test_drive/",
    "status":"enabled",
    "storeId":"90fba27e9c40452d91d83b204aee1d9b",
    "totalSize":1000000,
    "usedSize":0
}
~~~



### 删除drive

- 以下代码用于创建Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 删除 Drive
public static void deleteDrive() throws Exception {
    try {
        DeleteDriveRequestModel requestModel = new DeleteDriveRequestModel();
        DeleteDriveRequest deleteDriveRequest = new DeleteDriveRequest();
        deleteDriveRequest.driveId= "1";
        requestModel.body = deleteDriveRequest;

        client.deleteDrive(requestModel, runtime);
        // 此接口不返回body
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~

### 列举Stores

​	说明：当前接口只支持accessToken调用， 请使用Accesstoken初始化客户端

- 以下代码用于列举Stores，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public static void listStores() throws Exception {
    try {
        AdminListStoresRequestModel requestModel = new AdminListStoresRequestModel();
        AdminListStoresRequest listStoresRequest = new AdminListStoresRequest();
        requestModel.body = listStoresRequest;

        AdminListStoresModel listStoresResponse = client.adminListStores(requestModel, runtime);
        System.out.println(new Gson().toJson(listStoresResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~

- 返回结果

~~~javascript
{
    "items":[
        {
            "accelerateEndpoint":"",
            "basePath":"",
            "bucket":"ccp-daily-test",
            "customizedEndpoint":"",
            "endpoint":"https://oss-cn-hangzhou.aliyuncs.com",
            "internalEndpoint":"",
            "ownership":"custom",
            "policy":"",
            "roleArn":"",
            "storeId":"90fba27e9c40452d91d83b204aee1d9b",
            "type":"oss"
        }
    ]
}
~~~



## OSSPath Share 相关 API

### 创建Share

- 以下代码用于创建Share，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 格式化过期时间
public static String getISOTime() {
    long currentTime = System.currentTimeMillis();
    currentTime += 30 * 60 * 1000;
    Date date = new Date(currentTime);
    TimeZone timeZone = TimeZone.getTimeZone("UTC");
    DateFormat dateFormat= new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss.SSS'Z'");
    dateFormat.setTimeZone(timeZone);
    String nowAsISO = dateFormat.format(date);

    return nowAsISO;
}


// 创建 Share
public static void createShare() throws Exception {
    try {
        String nowAsISO = getISOTime();
        CreateShareRequestModel requestModel = new CreateShareRequestModel();
        CreateShareRequest createShareRequest = new CreateShareRequest();
        createShareRequest.shareFilePath = "/test_share/";
        createShareRequest.owner = userId;
        createShareRequest.shareName = "test_share";
        createShareRequest.permissions = new ArrayList<>(Arrays.asList("FILE.LIST"));
        createShareRequest.expiration = nowAsISO;
        createShareRequest.driveId = driveId;
        requestModel.body = createShareRequest;
        CreateShareModel createShareResponse = client.createShare(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(createShareResponse.body));

    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~javascript
{
    "domainId":"daily1405",
    "shareId":"47057f7b-8182-4d2d-ba1a-09ede78782d7"
}
~~~



### 列举Share

- 以下代码用于列举Share，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 列举 Share
public static void listShare() throws Exception {
    try {
        ListShareRequestModel requestModel = new ListShareRequestModel();
        ListShareRequest listShareRequest = new ListShareRequest();
        listShareRequest.owner = userId;
        requestModel.body = listShareRequest;
        ListShareModel listShareResponse = client.listShare(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listShareResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~javascript
{
    "items":[
        {
            "createdAt":"2019-10-28T06:22:21.163Z",
            "creator":"6c23c*************9f5211",
            "description":"changed_share",
            "domainId":"daily1405",
            "driveId":"1902",
            "expiration":"2019-10-28T06:52:21.139Z",
            "expired":false,
            "owner":"6c23c*****************3f9f5211",
            "permissions":[

            ],
            "shareFilePath":"/test_share/",
            "shareId":"47057f7b-8182-4d2d-ba1a-09ede78782d7",
            "shareName":"test_share",
            "status":"enabled",
            "updatedAt":"2019-10-28T06:22:21.163Z"
        }
    ],
    "nextMarker":""
}
~~~



### 查询Share

- 以下代码用于查询Share，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 查询Share
public static void getShare() throws Exception {
    try {
        GetShareRequestModel requestModel = new GetShareRequestModel();
        GetShareRequest getShareRequest = new GetShareRequest();
        getShareRequest.shareId = shareID;
        requestModel.body = getShareRequest;
        GetShareModel getShareResponse = client.getShare(requestModel, runtime);


        // 打印结果
        System.out.println(new Gson().toJson(getShareResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~javascript
{
    "createdAt":"2019-10-28T06:22:21.163Z",
    "creator":"6c23*************9f5211",
    "description":"",
    "domainId":"daily1405",
    "driveId":"1902",
    "expiration":"2019-10-28T06:52:21.139Z",
    "expired":false,
    "owner":"6c23c*************9f5211",
    "permissions":[
        "FILE.LIST"
    ],
    "shareFilePath":"/test_share/",
    "shareId":"47057f7b-8182-4d2d-ba1a-09ede78782d7",
    "shareName":"test_share",
    "status":"enabled",
    "updatedAt":"2019-10-28T06:22:21.163Z"
}
~~~



### 更新Share

- 以下代码用于更新Share，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 更新 Share
public static void updateShare() throws Exception {
    try {
        UpdateShareRequestModel requestModel = new UpdateShareRequestModel();
        UpdateShareRequest updateShareRequest = new UpdateShareRequest();
        updateShareRequest.shareId = shareID;
        updateShareRequest.description = "changed_share";
        requestModel.body = updateShareRequest;
        UpdateShareModel updateShareResponse = client.updateShare(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(updateShareResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}


~~~



- 返回结果

~~~javascript
{
    "createdAt":"2019-10-28T06:22:21.163Z",
    "creator":"6c23c98********************f5211",
    "description":"changed_share",
    "domainId":"daily1405",
    "driveId":"1902",
    "expiration":"2019-10-28T06:52:21.139Z",
    "expired":false,
    "owner":"6c23c98********************f5211",
    "permissions":[
		"FILE.LIST"
    ],
    "shareFilePath":"/test_share/",
    "shareId":"47057f7b-8182-4d2d-ba1a-09ede78782d7",
    "shareName":"test_share",
    "status":"enabled",
    "updatedAt":"2019-10-28T06:22:21.163Z"
}
~~~



### 删除Share

- 以下代码用于删除Share，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 删除 Share

public static void deleteShare() throws Exception {
    try {
        DeleteShareRequestModel requestModel = new DeleteShareRequestModel();
        DeleteShareRequest deleteShareRequest = new DeleteShareRequest();
        deleteShareRequest.shareId = shareID;
        requestModel.body = deleteShareRequest;
        DeleteShareModel deleteShareResponses = client.deleteShare(requestModel, runtime);

        //此接口不返回body
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~

## OSSPath File相关 API

### 创建File

- 以下代码用于创建File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。
- 说明： 此处创建File 还需要上传文件到OSS， 具体操作详见最佳实践。

~~~java
// 创建文件
public static void createFile() throws Exception {
    try {
        OSSCreateFileRequestModel requestModel =new OSSCreateFileRequestModel();
        OSSCreateFileRequest ossCreateFileRequest = new OSSCreateFileRequest();
        ossCreateFileRequest.type = "file";
        ossCreateFileRequest.name = "a.txt";
        ossCreateFileRequest.driveId= "**";
        ossCreateFileRequest.parentFilePath = "/";
        ossCreateFileRequest.contentType = "text/plain";
        requestModel.body = ossCreateFileRequest;
        CreateFileModel ossCreateFileResponse = client.createFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossCreateFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
// 此处url省略部分，实际值详见接口调用返回的结果。
{
    "domainId":"daily1405",
    "driveId":"1902",
    "filePath":"/a.txt",
    "partInfoList":[
        {
            "partNumber":1,
            "uploadUrl":"https://********.oss-cn-hangzhou.aliyuncs.***********8FB16"
        }
    ],
    "type":"file",
    "uploadId":"872F52602EB343D0ADCE3E75D008FB16"
}
~~~



### 列举File

- 以下代码用于列举File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 列举文件
public static void listFile() throws Exception {
    try {
        OSSListFileRequestModel requestModel = new OSSListFileRequestModel();
        OSSListFileRequest ossListFileRequest = new OSSListFileRequest();
        ossListFileRequest.driveId= "***";
        ossListFileRequest.parentFilePath = folderPath;
        requestModel.body = ossListFileRequest;
        ListFileModel ossListFileResponse = client.listFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossListFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~JavaScript
// 此处url省略部分，实际值详见接口调用返回的结果。
{
    "items":[
        {
            "contentType":"",
            "domainId":"daily1405",
            "downloadUrl":"https://********.oss-cn-hangzhou.aliyuncs.***********8FB16",
            "driveId":"1902",
            "fileExtension":"txt",
            "filePath":"/test_folder/a.txt",
            "name":"a.txt",
            "parentFilePath":"/test_folder/",
            "size":8,
            "status":"available",
            "type":"file",
            "updatedAt":"2019-10-28T06:22:23Z",
            "url":"https://********.oss-cn-hangzhou.aliyuncs.***********8FB16"
        }
    ],
    "nextMarker":""
}
~~~



### 查询File

- 以下代码用于查询File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 查询File
public static void getFile() throws Exception {
    try {
        OSSGetFileRequestModel requestModel = new OSSGetFileRequestModel();
        OSSGetFileRequest ossGetFileRequest = new OSSGetFileRequest();
        ossGetFileRequest.driveId= "2801";
        ossGetFileRequest.filePath = filePath;
        requestModel.body = ossGetFileRequest;
        GetFileModel ossGetFileResponse = client.getFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossGetFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "contentType":"text/plain",
    "domainId":"daily1405",
    "downloadUrl":"https://********.oss-cn-hangzhou.aliyuncs.***********8FB16",
    "driveId":"1902",
    "fileExtension":"",
    "filePath":"/a.txt",
    "name":"a.txt",
    "parentFilePath":"/",
    "size":8,
    "status":"available",
    "type":"file",
    "updatedAt":"2019-10-28T06:22:23Z",
    "url":"https://********.oss-cn-hangzhou.aliyuncs.***********8FB16"
}
~~~

### 移动File

- 以下代码用于移动File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 移动 File
public static void moveFile() throws Exception {
    try {
        OSSMoveFileRequestModel requestModel = new OSSMoveFileRequestModel();
        OSSMoveFileRequest ossMoveFileRequest = new OSSMoveFileRequest();
        ossMoveFileRequest.driveId= "***";
        ossMoveFileRequest.filePath = filePath;
        ossMoveFileRequest.toParentFilePath = folderPath;
        requestModel.body = ossMoveFileRequest;
        MoveFileModel ossMoveFileResponse = client.moveFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossMoveFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "domainId":"daily1405",
    "driveId":"1902",
    "filePath":"/test_folder/a.txt"
}
~~~



### 复制File

- 以下代码用于复制File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 复制 File
public static void copyFile() throws Exception {
    try {
        OSSCopyFileRequestModel requestModel = new OSSCopyFileRequestModel();
        OSSCopyFileRequest ossCopyFileRequest = new OSSCopyFileRequest();
        ossCopyFileRequest.filePath = movedFilePath;
        ossCopyFileRequest.driveId= "***";
        ossCopyFileRequest.toParentFilePath = "/";
        requestModel.body =ossCopyFileRequest;
        CopyFileModel ossCopyFileResponse = client.copyFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossCopyFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "domainId":"daily1405",
    "driveId":"1902",
    "filePath":"/a.txt"
}
~~~



### 获取File上传地址

- 以下代码用于获取File上传地址，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 获取File上传地址
public static void getFileUploadUrl() throws Exception {
    try {
        OSSGetUploadUrlRequestModel requestModel = new OSSGetUploadUrlRequestModel();
        UploadPartInfo uploadPartInfo = new UploadPartInfo();
        uploadPartInfo.partNumber = 1L;
        OSSGetUploadUrlRequest ossGetUploadUrlRequest = new OSSGetUploadUrlRequest();
        ossGetUploadUrlRequest.driveId = driveId;
        ossGetUploadUrlRequest.filePath = filePath;
        ossGetUploadUrlRequest.uploadId = uploadId;
        ossGetUploadUrlRequest.partInfoList = new ArrayList<>(Arrays.asList(uploadPartInfo));
        requestModel.body = ossGetUploadUrlRequest;
        GetUploadUrlModel ossGetUploadUrlResponse = client.getUploadUrl(requestModel, runtime);


        // 打印结果
        System.out.println(new Gson().toJson(ossGetUploadUrlResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "createAt":"2019-10-28T06:22:22.231Z",
    "domainId":"daily1405",
    "driveId":"1902",
    "filePath":"/a.txt",
    "partInfoList":[
        {
            "partNumber":1,
            "uploadUrl":"https://********.oss-cn-hangzhou.aliyuncs.***********8FB16"
        }
    ],
    "uploadId":"872F52602EB343D0ADCE3E75D008FB16"
}
~~~



### 获取File下载地址

- 以下代码用于获取File下载地址，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 获取File下载地址
public static void getFileDownloadUrl() throws Exception {
    try {
        OSSGetDownloadUrlRequestModel requestModel = new OSSGetDownloadUrlRequestModel();
        OSSGetDownloadUrlRequest ossGetDownloadUrlRequest = new OSSGetDownloadUrlRequest();
        ossGetDownloadUrlRequest.driveId= "***";
        ossGetDownloadUrlRequest.filePath = filePath;
        ossGetDownloadUrlRequest.expireSec = 3600L;
        requestModel.body = ossGetDownloadUrlRequest;
        GetDownloadUrlModel ossGetDownloadUrlResponse = client.getDownloadUrl(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossGetDownloadUrlResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "requestId":"6760BC8F-AA33-4862-AA26-0F8FA57EAF39",
    "expiration":"2019-10-28T07:22:24.044Z",
    "method":"GET",
    "url":"https://********.oss-cn-hangzhou.aliyuncs.***********8FB16"
}
~~~



### Complete File

- 以下代码用于创建Complete File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。
- 说明： 此处请求参数中的ETag是请求uploadUrl上传完成后从返回的Response Headers中获取的，详见最佳实践。

~~~java
// 合并File分片
public static void completeFile() throws Exception {
    try {
        OSSCompleteFileRequestModel requestModel = new OSSCompleteFileRequestModel();
        UploadPartInfo uploadPartInfo1 = new UploadPartInfo();
        uploadPartInfo1.etag = etag;
        uploadPartInfo1.partNumber = 1L;
        OSSCompleteFileRequest ossCompleteFileRequest = new OSSCompleteFileRequest();
        ossCompleteFileRequest.driveId= "***";
        ossCompleteFileRequest.filePath = filePath;
        ossCompleteFileRequest.uploadId = newUploadId;
        ossCompleteFileRequest.partInfoList =new ArrayList<>(Arrays.asList(uploadPartInfo1));
        requestModel.body = ossCompleteFileRequest;
        CompleteFileModel ossCompleteFileResponse = client.completeFile(requestModel, runtime);
        
        // 打印结果
        System.out.println(new Gson().toJson(ossCompleteFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "contentType":"text/plain",
    "crc64Hash":"6668564720710875145",
    "domainId":"daily1405",
    "driveId":"1902",
    "fileExtension":"",
    "filePath":"/a.txt",
    "name":"a.txt",
    "parentFilePath":"/",
    "size":0,
    "status":"uploading",
    "type":"file",
    "uploadId":"872F52602EB343D0ADCE3E75D008FB16",
    "crc":"6668564720710875145"
}
~~~



### 删除File

- 以下代码用于删除File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 删除 file
public static void deleteFile() throws Exception {
    try {
        OSSDeleteFileRequestModel requestModel = new OSSDeleteFileRequestModel();
        OSSDeleteFileRequest ossDeleteFileRequest = new OSSDeleteFileRequest();
        ossDeleteFileRequest.driveId= "***";
        ossDeleteFileRequest.filePath = filePath;
        requestModel.body = ossDeleteFileRequest;

        client.deleteFile(requestModel, runtime);

        // 此接口不返回body
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~

### 列举Stores File

- 以下代码用于列举Stores File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档.

~~~java
// 列举 Stores File
public static void listStoreFiles() throws Exception {
    try {
        // list Stores
        AdminListStoresRequestModel requestModel = new AdminListStoresRequestModel();
        AdminListStoresRequest listStoresRequest = new AdminListStoresRequest();
        requestModel.body = listStoresRequest;
        AdminListStoresModel listStoresResponse = client.adminListStores(requestModel, runtime);
        String storeId = listStoresResponse.body.items.get(0).storeId;

        // list store_file
        ListStoreFileRequestModel requestModel = new ListStoreFileRequestModel();
        ListStoreFileRequest listStorageFileRequest = new ListStoreFileRequest();
        listStorageFileRequest.storeId = storeId;
        listStorageFileRequest.limit = 2L;
        requestModel.body = listStorageFileRequest;
        ListStorefileModel listStorageFileResponse = client.listStorefile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listStorageFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~javascript
{
    "items":[
        {
            "domainId":"",
            "name":"5733dbd6**********5c0",
            "parentFilePath":"/",
            "storeId":"90fba2***********e1d9b",
            "type":"folder"
        }
    ],
    "nextMarker":"5733db************86e75c0/"
}
~~~



## CCPPath Drive 相关API

### 创建drive

- 以下代码用于创建Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 创建 Drive
public static void createDrive() throws Exception {
    try {
        CreateDriveRequestModel requestModel = new CreateDriveRequestModel();
        CreateDriveRequest createDriveRequest = new CreateDriveRequest();
        createDriveRequest.totalSize = 100000L;
        createDriveRequest.driveName = "test_drive";
        createDriveRequest.driveType = "normal";
        createDriveRequest.owner = userId;
        requestModel.body = createDriveRequest;
        CreateDriveModel createDriveResponse = client.createDrive(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(createDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "domainId":"daily1404",
    "driveId":"603"
}
~~~



### 列举drive

- 以下代码用于列举drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 列举 Drive 
public static void listDrive() throws Exception {
    try {
        ListDriveRequestModel requestModel = new ListDriveRequestModel();
        ListDriveRequest listDriveRequest = new ListDriveRequest();
        listDriveRequest.limit = 1;
        listDriveRequest.owner = userId;
        requestModel.body = listDriveRequest;
        ListDrivesModel listDriveResponse = client.listDrives(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}


~~~



- 返回结果

~~~javascript
{
    "items":[
        {
            "creator":"",
            "description":"",
            "domainId":"daily1404",
            "driveId":"603",
            "driveName":"test_drive",
            "driveType":"normal",
            "owner":"ldh",
            "relativePath":"",
            "status":"enabled",
            "storeId":"55ff60f575b24a8c97378f1e0a946904",
            "totalSize":100000,
            "usedSize":0
        }
    ],
    "nextMarker":""
}
~~~



### 查询drive

- 以下代码用于查询drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 查询 Drive
public static void getDrive() throws Exception {
    try {
        GetDriveRequestModel requestModel = new GetDriveRequestModel();
        GetDriveRequest getDriveRequest = new GetDriveRequest();
        getDriveRequest.driveId = driveId;
        requestModel.body = getDriveRequest;
        GetDriveModel getDriveResponse = client.getDrive(requestModel, runtime);
        //打印结果
        System.out.println(new Gson().toJson(getDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~javascript
{
    "creator":"",
    "description":"",
    "domainId":"daily1404",
    "driveId":"603",
    "driveName":"test_drive",
    "driveType":"normal",
    "owner":"ldh",
    "relativePath":"",
    "status":"enabled",
    "storeId":"55ff60f575b24a8c97378f1e0a946904",
    "totalSize":100000,
    "usedSize":0
}
~~~



### 更新drive

- 以下代码用于更新drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 更新 Drive
public static void updateDrive() throws Exception {
    try {
        UpdateDriveRequestModel requestModel = new UpdateDriveRequestModel();
        UpdateDriveRequest updateDriveRequest = new UpdateDriveRequest();
        updateDriveRequest.driveId = driveId;
        updateDriveRequest.description = "changed_drive";
        updateDriveRequest.totalSize = 1000000L;
        requestModel.body = updateDriveRequest;
        UpdateDriveModel updateDriveResponse = client.updateDrive(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(updateDriveResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



- 返回结果

~~~javascript
{
    "creator":"",
    "description":"changed_drive",
    "domainId":"daily1404",
    "driveId":"603",
    "driveName":"test_drive",
    "driveType":"normal",
    "owner":"ldh",
    "relativePath":"",
    "status":"enabled",
    "storeId":"55ff60f575b24a8c97378f1e0a946904",
    "totalSize":1000000,
    "usedSize":0
}
~~~



### 删除drive

- 以下代码用于删除drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 删除 Drive
public static void deleteDrive() throws Exception {
    try {
        DeleteDriveRequestModel requestModel = new DeleteDriveRequestModel();
        DeleteDriveRequest deleteDriveRequest = new DeleteDriveRequest();
        deleteDriveRequest.driveId = driveId;
        requestModel.body = deleteDriveRequest;

        DeleteDriveModel deleteDriveResponse = client.deleteDrive(requestModel, runtime);

        // 此接口不返回body
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}

~~~



## CCPPath File 相关 API

### 创建File

- 以下代码用于创建Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 创建文件
public static void createFile() throws Exception {
    try {
        CCPCreateFileRequestModel requestModel = new CCPCreateFileRequestModel();
        CCPCreateFileRequest ccpCreateFileRequest = new CCPCreateFileRequest();
        ccpCreateFileRequest.type = "file";
        ccpCreateFileRequest.name = "a.txt";
        ccpCreateFileRequest.driveId = driveId;
        ccpCreateFileRequest.parentFileId = "root";
        ccpCreateFileRequest.contentType = "text/plain";
        requestModel.body = ccpCreateFileRequest;
        CreateFileModel ccpCreateFileResponse = client.createFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpCreateFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~JavaScript
{
    "domainId":"daily1404",
    "driveId":"603",
    "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f",
    "parentFileId":"root",
    "partInfoList":[
        {
            "partNumber":1,
            "uploadUrl":"https://*********.oss-cn-hangzhou.aliyuncs.com/*****F943"
        }
    ],
    "rapidUpload":false,
    "type":"file",
    "uploadId":"DEB65A38FCCA410BAC6DD23A8A11F943"
}
~~~



### 列举File

- 以下代码用于列举File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 列举文件
public static void listFile() throws Exception {
    try {
        CCPListFileRequestModel requestModel = new CCPListFileRequestModel();
        CCPListFileRequest ccpListFileRequest = new CCPListFileRequest();
        ccpListFileRequest.driveId = driveId;
        ccpListFileRequest.parentFileId = folderId;
        ccpListFileRequest.limit = 1L;
        requestModel.body = ccpListFileRequest;
        ListFileModel ccpListFileResponse = client.listFile(requestModel, runtime);
        
        // 打印结果
        System.out.println(new Gson().toJson(ccpListFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "items":[
        {
            "contentHash":"7C4A8D09CA3762AF61E59520943DC26494F8941B",
            "contentHashName":"sha1",
            "contentType":"",
            "createdAt":"2019-10-28T08:40:54.398Z",
            "domainId":"daily1404",
            "downloadUrl":"https://*********.oss-cn-hangzhou.aliyuncs.com/*****.txt",
            "driveId":"603",
            "fileExtension":"txt",
            "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f",
            "hidden":false,
            "name":"a.txt",
            "parentFileId":"5db6a996c7e9ae3a5e654a7798947b209989b963",
            "size":6,
            "starred":false,
            "status":"available",
            "type":"file",
            "updatedAt":"2019-10-28T08:40:55.398Z",
            "url":"https://*********.oss-cn-hangzhou.aliyuncs.com/*****F943"
        }
    ],
    "nextMarker":""
}
~~~



### 查询File

- 以下代码用于查询File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 查询File
public static void getFile() throws Exception {
    try {
        CCPGetFileRequestModel requestModel = new CCPGetFileRequestModel();
        CCPGetFileRequest ccpGetFileRequest = new CCPGetFileRequest();
        ccpGetFileRequest.driveId = driveId;
        ccpGetFileRequest.fileId = fileId;
        requestModel.body = ccpGetFileRequest;
        GetFileModel ccpGetFileResponse = client.getFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpGetFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "contentHash":"7C4A8D09CA3762AF61E59520943DC26494F8941B",
    "contentHashName":"sha1",
    "contentType":"text/plain",
    "crc64Hash":"318318745347147982",
    "createdAt":"2019-10-28T08:40:54.398Z",
    "domainId":"daily1404",
    "downloadUrl":"https://*********.oss-cn-hangzhou.aliyuncs.com/*****F943.txt",
    "driveId":"603",
    "fileExtension":"txt",
    "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f",
    "hidden":false,
    "name":"a.txt",
    "parentFileId":"root",
    "size":6,
    "starred":false,
    "status":"available",
    "type":"file",
    "updatedAt":"2019-10-28T08:40:55.398Z",
    "uploadId":"DEB65A38FCCA410BAC6DD23A8A11F943",
    "url":"https://*********.oss-cn-hangzhou.aliyuncs.com/*****F943"
}
~~~



### 移动File

- 以下代码用于移动File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 移动 File
public static void moveFile() throws Exception {
    try {
        CCPMoveFileRequestModel requestModel = new CCPMoveFileRequestModel();
        CCPMoveFileRequest ccpMoveFileRequest = new CCPMoveFileRequest();
        ccpMoveFileRequest.driveId = driveId;
        ccpMoveFileRequest.fileId = fileId;
        ccpMoveFileRequest.toParentFileId = folderId;
        requestModel.body = ccpMoveFileRequest;

        MoveFileModel ccpMoveFileResponse = client.moveFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpMoveFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "domainId":"daily1404",
    "driveId":"603",
    "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f"
}
~~~



### 复制File

- 以下代码用于复制File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 复制 File
public static void copyFile() throws Exception {
    try {
        CCPCopyFileRequestModel requestModel = new CCPCopyFileRequestModel();
        CCPCopyFileRequest ccpCopyFileRequest = new CCPCopyFileRequest();
        ccpCopyFileRequest.fileId = fileId;
        ccpCopyFileRequest.driveId = driveId;
        ccpCopyFileRequest.toParentFileId = "root";
        requestModel.body = ccpCopyFileRequest;
        CopyFileModel ccpCopyFileResponse = client.copyFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpCopyFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "domainId":"daily1404",
    "driveId":"603",
    "fileId":"5db6a997ce31eb635f2e4f4c9163ec3bd10af459"
}
~~~



### 获取File上传地址

- 以下代码用于获取File上传地址，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 获取File上传地址
public static void getFileUploadUrl() throws Exception {
    try {
        UploadPartInfo uploadPartInfo = new UploadPartInfo();
        uploadPartInfo.partNumber = 1L;
        CCPGetUploadUrlRequestModel requestModel = new CCPGetUploadUrlRequestModel();
        CCPGetUploadUrlRequest ccpGetUploadUrlRequest = new CCPGetUploadUrlRequest();
        ccpGetUploadUrlRequest.driveId = driveId;
        ccpGetUploadUrlRequest.fileId = fileId;
        ccpGetUploadUrlRequest.uploadId = uploadId;
        ccpGetUploadUrlRequest.partInfoList = new ArrayList<>(Arrays.asList(uploadPartInfo));
        requestModel.body = ccpGetUploadUrlRequest;
        GetUploadUrlModel ccpGetUploadUrlResponse = client.getUploadUrl(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpGetUploadUrlResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "createAt":"2019-10-28T08:40:54.519Z",
    "domainId":"daily1404",
    "driveId":"603",
    "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f",
    "partInfoList":[
        {
            "partNumber":1,
            "uploadUrl":"url":"https://****.oss-cn-hangzhou.aliyuncs.com/****wZM%3D"
        }
    ],
    "uploadId":"DEB65A38FCCA410BAC6DD23A8A11F943"
}
~~~



### 获取File下载地址

- 以下代码用于获取File下载地，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 获取File下载地址
public static void getFileDownloadUrl() throws Exception {
    try {
        CCPGetDownloadUrlRequestModel requestModel = new CCPGetDownloadUrlRequestModel();
        CCPGetDownloadUrlRequest ccpGetDownloadUrlRequest = new CCPGetDownloadUrlRequest();
        ccpGetDownloadUrlRequest.driveId = driveId;
        ccpGetDownloadUrlRequest.fileId = fileId;
        ccpGetDownloadUrlRequest.expireSec = 3600L;
        requestModel.body = ccpGetDownloadUrlRequest;
        GetDownloadUrlModel ccpGetDownloadUrlResponse = client.getDownloadUrl(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpGetDownloadUrlResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "expiration":"2019-10-28T09:40:55.716Z",
    "method":"GET",
    "url":"https://****.oss-cn-hangzhou.aliyuncs.com/****wZM%3D"
}
~~~



### Complete File

- 以下代码用于Complete File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 合并File分片
public static void completeFile() throws Exception {
    try {
        CCPCompleteFileRequestModel requestModel = new CCPCompleteFileRequestModel();
        CCPCompleteFileRequest ccpCompleteFileRequest = new CCPCompleteFileRequest();
        ccpCompleteFileRequest.driveId = driveId;
        ccpCompleteFileRequest.fileId = fileId;
        ccpCompleteFileRequest.uploadId = newUploadId;
        ccpCompleteFileRequest.partInfoList = new ArrayList<>(Arrays.asList(uploadPartInfo1));
        requestModel.body = ccpCompleteFileRequest;
        CompleteFileModel ccpCompleteFileResponse = client.completeFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpCompleteFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "contentHash":"7C4A8D09CA3762AF61E59520943DC26494F8941B",
    "contentHashName":"sha1",
    "contentType":"text/plain",
    "crc64Hash":"318318745347147982",
    "createdAt":"2019-10-28T08:40:54.398Z",
    "domainId":"daily1404",
    "driveId":"603",
    "fileExtension":"txt",
    "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f",
    "hidden":false,
    "name":"a.txt",
    "parentFileId":"root",
    "size":6,
    "starred":false,
    "status":"available",
    "type":"file",
    "updatedAt":"2019-10-28T08:40:55.398Z",
    "uploadId":"DEB65A38FCCA410BAC6DD23A8A11F943",
    "crc":""
}
~~~



### 更新File

- 以下代码用于更新File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 更新 file
public static void updateFile() throws Exception {
    try {
        CCPUpdateFileMetaRequestModel requestModel = new CCPUpdateFileMetaRequestModel();
        CCPUpdateFileMetaRequest ccpUpdateFileMetaRequest = new CCPUpdateFileMetaRequest();
        ccpUpdateFileMetaRequest.fileId = fileId;
        ccpUpdateFileMetaRequest.description = "changed_file";
        ccpUpdateFileMetaRequest.driveId = driveId;
        requestModel.body = ccpUpdateFileMetaRequest;

        UpdateFileModel ccpUpdateFileMetaResponse = client.updateFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpUpdateFileMetaResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~javascript
{
    "contentHash":"7C4A8D09CA3762AF61E59520943DC26494F8941B",
    "contentHashName":"sha1",
    "contentType":"text/plain",
    "crc64Hash":"318318745347147982",
    "createdAt":"2019-10-28T08:40:54.398Z",
    "description":"changed_file",
    "domainId":"daily1404",
    "downloadUrl":"https://******.oss-cn-hangzhou.aliyuncs.com/5****a.txt",
    "driveId":"603",
    "fileExtension":"txt",
    "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f",
    "hidden":false,
    "name":"a.txt",
    "parentFileId":"5db6a996c7e9ae3a5e654a7798947b209989b963",
    "size":6,
    "starred":false,
    "status":"available",
    "type":"file",
    "updatedAt":"2019-10-28T08:40:55.398Z",
    "uploadId":"DEB65A38FCCA410BAC6DD23A8A11F943",
    "url":"https://****.oss-cn-hangzhou.aliyuncs.com/****wZM%3D"
}
~~~



### 搜索File

- 以下代码用于搜索File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 搜索 file
public static void searchFile() throws Exception {
    try {
        CCPSearchFileRequestModel requestModel = new CCPSearchFileRequestModel();
        CCPSearchFileRequest ccpSearchFileRequest = new CCPSearchFileRequest();
        ccpSearchFileRequest.driveId = driveId;
        ccpSearchFileRequest.limit = 3;
        ccpSearchFileRequest.orderBy = "type DESC";
        ccpSearchFileRequest.query = "file_extension in [\"txt\"]";
        requestModel.body = ccpSearchFileRequest;
        SearchFileModel ccpSearchFileResponse = client.searchFile(requestModel, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpSearchFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }   
}
~~~



- 返回结果

~~~JavaScript
{
    "items":[
        {
            "contentHash":"7C4A8D09CA3762AF61E59520943DC26494F8941B",
            "contentHashName":"sha1",
            "contentType":"text/plain",
            "crc64Hash":"318318745347147982",
            "createdAt":"2019-10-28T08:40:54.398Z",
            "description":"changed_file",
            "domainId":"daily1404",
            "downloadUrl":"https://************.oss-cn-hangzhou.aliyuncs.com/***a.txt",
            "driveId":"603",
            "fileExtension":"txt",
            "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f",
            "hidden":false,
            "name":"a.txt",
            "parentFileId":"5db6a996c7e9ae3a5e654a7798947b209989b963",
            "size":6,
            "starred":false,
            "status":"available",
            "type":"file",
            "updatedAt":"2019-10-28T08:40:55.398Z",
            "uploadId":"DEB65A38FCCA410BAC6DD23A8A11F943",
            "url":"https://****.oss-cn-hangzhou.aliyuncs.com/****ZM%3D"
        }
    ],
    "nextMarker":""
}
~~~



### 删除File

- 以下代码用于删除file，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 删除 file
public static void deleteFile() throws Exception {
    try {
        CCPDeleteFileRequestModel requestModel = new CCPDeleteFileRequestModel();
        CCPDeleteFileRequest ccpDeleteFileRequest = new CCPDeleteFileRequest();
        ccpDeleteFileRequest.driveId = driveId;
        ccpDeleteFileRequest.fileId = fileId;
        requestModel.body = ccpDeleteFileRequest;
        DeleteFileModel deleteFileResponse = client.deleteFile(requestModel, runtime);
        
        System.out.println(new Gson().toJson(deleteFileResponse.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~

### 批量操作

- 以下代码用于批量操作，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void batch() throws Exception {
    try {
        CCPBatchRequestModel requestModel = new CCPBatchRequestModel();
        CCPBatchRequest ccpBatchRequest = new CCPBatchRequest();
        ccpBatchRequest.resource = "file";
        BatchSubRequest batchSubRequest = new BatchSubRequest();
        Map<String, Object> bodyMap = new HashMap<>();
        Map<String, Object> headerMap = new HashMap<>();
        bodyMap.put("drive_id", "1");
        bodyMap.put("file_id", "5e7e292b58fe324cd****7fce0f1c");
        bodyMap.put("description", "changed_file");
        headerMap.put("authorization", "eyJhbGciOiJSUz******5cCI6IkpXVCJ9");
        batchSubRequest.body = bodyMap;
        batchSubRequest.url = "/file/update";
        batchSubRequest.method = "POST";
        batchSubRequest.headers = headerMap;
        batchSubRequest.id = "uuid";
        ccpBatchRequest.requests = new ArrayList<>(Arrays.asList(batchSubRequest));
        requestModel.body = ccpBatchRequest;
        OperationModel response = client.operation(requestModel, runtime);
        System.out.println(new Gson().toJson(response.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
    }
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



### 获取file已经上传的分片

- 以下代码用于获取file已经上传的分片，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void listUploadedPart() throws Exception {
    try {
        CCPListUploadedPartRequestModel requestModel = new CCPListUploadedPartRequestModel();
        CCPListUploadedPartRequest ccpListUploadedPartRequest = new CCPListUploadedPartRequest();
        ccpListUploadedPartRequest.driveId = "1";
        ccpListUploadedPartRequest.fileId = "****";
        ccpListUploadedPartRequest.uploadId = "****";
        requestModel.body = ccpListUploadedPartRequest;
        ListUploadedPartsModel response = client.listUploadedParts(requestModel, runtime);
        System.out.println(new Gson().toJson(response.body));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
    }
}
~~~



- 返回结果

```javascript
{
  "drive_id" : "1",
  "file_id" : "5d5b846942cf94fa72324c14a4bda34e81da635d",
  "limit" : 1,
  "part_number_marker" : 1,
  "upload_id" : "00668396C0814D818D90F0A92B04B355"
}
```



### 获取异步信息

- 以下代码用于获取异步信息，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

```java
public void getAsyncTask() throws Exception {
    try {
        CCPGetAsyncTaskRequestModel requestModel = new CCPGetAsyncTaskRequestModel();
        CCPGetAsyncTaskRequest getAsyncTaskRequest = new CCPGetAsyncTaskRequest();
        getAsyncTaskRequest.asyncTaskId = "***";
        requestModel.body = getAsyncTaskRequest;
        GetAsyncTaskInfoModel response = client.getAsyncTaskInfo(requestModel, runtime);
        System.out.println(new Gson().toJson(response.headers));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
    }
}
```



- 返回结果

```javascript
{
  "async_task_id" : "000e89fb-cf8f-11e9-8ab4-b6e980803a3b",
  "message" : "task is running",
  "state" : "success"
}
```



# 附

## 创建RAM子用户(获取AK，SK）

1. 注册阿里云账号，详见[阿里云账号注册流程](https://help.aliyun.com/document_detail/37195.html?spm=a2c4g.11186623.2.13.6a857007v5sxu1)。
2. 开启访问控制服务，详见[RAM访问控制](https://ram.console.aliyun.com/overview)，并根据提示操作。
3. 创建RAM子用户，并获取AK，SK。详见[服务端调用接口接入](https://help.aliyun.com/document_detail/134467.html?spm=a2c4g.11186623.6.551.646a6d39hQ1bQt#h2-3-3)。SK要注意保密不要泄露。 

## 创建APP(获取ClientID, ClientSecret）

1.  首先，您需要开通内容协作平台（CCP）服务。如果没有开通，请到[产品详情页面](https://www.aliyun.com/product/ccp)开通 。
2.  您需要在CCP官网控制台创建一个域(Domain) 。详见创建[CCPath域实例](https://help.aliyun.com/document_detail/134467.html?spm=a2c4g.11186623.6.551.2f134190GNe6T2#h2-2-2)和创建[OSSPath域实例](https://help.aliyun.com/document_detail/135607.html?spm=a2c4g.11186623.6.552.26cd2c6ciSU8xM#h2-1-1)。
3.  创建APP，选择类型为”Web服务应用”。确定APP的访问Scope: [支持的Scope列表](https://help.aliyun.com/document_detail/135388.html), 这个Scope要在用户授权页面展示。创建完成，可以得到APP ID(ClientID) 和 Secret(ClientSecret)。这个是授权认证的凭证，Secret要注意保密不要泄露。 

## CCPPath 上传文件

~~~java
import com.aliyun.ccp.ccpclient.Client;
import com.aliyun.ccp.ccpclient.models.*;
import com.aliyun.tea.TeaException;
import com.google.gson.Gson;
import okhttp3.*;

import java.util.*;


public class Demo {
    private static Client client;
    private static RuntimeOptions runtime;

    public static void main(String[] args) throws  Exception{
        createClient();
        createFile();
    }

    public static  void createClient() throws Exception {
        Config config = new Config();
        config.domainId= "your domain id";
        config.protocol = "https";
        config.accessKeyId = "your accessKeyId";
        config.accessKeySecret = "your accessKeySecret";
        client = new Client(config);
        runtime = new RuntimeOptions();
    }

    public static  void createFile() throws Exception{
        try{
            System.out.println("-------------create file----------------");
            CCPCreateFileRequestModel requestModel = new CCPCreateFileRequestModel();
            CCPCreateFileRequest ccpCreateFileRequest = new CCPCreateFileRequest();
            ccpCreateFileRequest.type = "file";
            ccpCreateFileRequest.name = "a.txt";
            ccpCreateFileRequest.driveId = "1";
            ccpCreateFileRequest.parentFileId = "root";
            ccpCreateFileRequest.contentType = "text/plain";
            requestModel.body = ccpCreateFileRequest;
            CreateFileModel ccpCreateFileResponse = client.createFile(requestModel, runtime);
            System.out.println(new Gson().toJson(ccpCreateFileResponse.body));

            String uploadId = ccpCreateFileResponse.body.uploadId;
            String fileId = ccpCreateFileResponse.body.fileId;
            String uploadUrl = ccpCreateFileResponse.body.partInfoList.get(0).uploadUrl;


            // upload file
            System.out.println("-------------upload file----------------");
            Request.Builder requestBuilder = new Request.Builder();
            RequestBody body = RequestBody.create(MediaType.parse(""), "123456");
            requestBuilder.url(uploadUrl);
            requestBuilder.put(body);

            Request request = requestBuilder.build();
            OkHttpClient okHttpClient = new OkHttpClient.Builder().build();
            Response response = okHttpClient.newCall(request).execute();

            String etag = response.headers().get("ETag");
            System.out.println();

            // complete file
            System.out.println("-------------complete file----------------");
            UploadPartInfo uploadPartInfo1 = new UploadPartInfo();
            uploadPartInfo1.etag = etag;
            uploadPartInfo1.partNumber = 1L;
            CCPCompleteFileRequestModel requestModel1 = new CCPCompleteFileRequestModel();
            CCPCompleteFileRequest ccpCompleteFileRequest = new CCPCompleteFileRequest();
            ccpCompleteFileRequest.driveId = "1";
            ccpCompleteFileRequest.fileId = fileId;
            ccpCompleteFileRequest.uploadId = uploadId;
            ccpCompleteFileRequest.partInfoList = new ArrayList<>(Arrays.asList(uploadPartInfo1));
            requestModel1.body = ccpCompleteFileRequest;
            CompleteFileModel ccpCompleteFileResponse = client.completeFile(requestModel1, runtime);
            System.out.println(new Gson().toJson(ccpCompleteFileResponse.body));

        }catch (TeaException e) {
            System.out.println(e.getMessage());
            System.out.println(e.getCode());
            System.out.println(new Gson().toJson(e.getData()));
        }
    }
}
~~~

