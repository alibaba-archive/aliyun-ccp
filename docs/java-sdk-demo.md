

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
    <artifactId>ccp-baseclient</artifactId>
    <version>1.0-SNAPSHOT</version>
</dependency>
<dependency>
    <groupId>com.aliyun</groupId>
    <artifactId>ccp-client</artifactId>
    <version>1.0-SNAPSHOT</version>
</dependency>
```

OSSPath

~~~xml
<dependency>
    <groupId>com.aliyun</groupId>
    <artifactId>ccp-baseclient</artifactId>
    <version>1.0-SNAPSHOT</version>
</dependency>
<dependency>
    <groupId>com.aliyun</groupId>
    <artifactId>ccp-oss-client</artifactId>
    <version>1.0-SNAPSHOT</version>
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
// 密码登录
public static void getCaptcha() throws Exception {
    try {
        MobileLoginRequest mobileLoginRequest = new MobileLoginRequest();
        mobileLoginRequest.appId = appId;
        mobileLoginRequest.phoneNumber = "13*****225";
        mobileLoginRequest.password = "*********";
        AccountAccessTokenResponse tokenResponse = client.login(mobileLoginRequest, runtime);

        //  打印返回结果
        System.out.println(new Gson().tojson(tokenResponse));

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
        MobileSendSmsCodeRequest sendSmsCodeRequest = new MobileSendSmsCodeRequest();
        sendSmsCodeRequest.appId = appId;
        sendSmsCodeRequest.phoneNumber = "132*****25";
        sendSmsCodeRequest.type = "login";

        MobileSendSmsCodeResponse response = client.mobileSendSmsCode(sendSmsCodeRequest, runtime);

        System.out.println(new Gson().toJson(response));
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
    "requestId":"07A5175C-E124-42EC-9304-2294DC2CEFAC",
    "smsCodeId":"b40bba70b37d74**********************6j3IW7HP"
}
~~~



### 验证手机号是否注册

- 以下代码用于验证手机号是否存在，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void checkMobileIsExist() throws Exception {
    try {
        MobileCheckExistRequest checkExistRequest = new MobileCheckExistRequest();
        checkExistRequest.appId = appId;
        checkExistRequest.phoneNumber = "13****25";
        MobileCheckExistResponse checkExistResponse = client.checkExist(checkExistRequest, runtime);
        
        System.out.println(new Gson().toJson(checkExistResponse));
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
    "requestId":"4DB78761-20AE-4724-8960-ADD225F35A0F",
    "isExist":true,
    "phoneNumber":"13****25"
}
~~~



### 手机号注册

- 以下代码用于手机号注册，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
public void register() throws Exception {
    try {

        // get register mns Code
        MobileSendSmsCodeRequest sendSmsCodeRequest = new MobileSendSmsCodeRequest();
        sendSmsCodeRequest.appId = appId;
        sendSmsCodeRequest.phoneNumber = "13****25";
        sendSmsCodeRequest.type = "change_password";
        MobileSendSmsCodeResponse response = client.mobileSendSmsCode(sendSmsCodeRequest, runtime);
        String changePasswordCode = response.smsCodeId;

        // mobile register
        MobileRegisterRequest registerRequest = new MobileRegisterRequest();
        registerRequest.appId = appId;
        registerRequest.phoneNumber = "132*****225";
        registerRequest.smsCode = "123456";
        registerRequest.smsCodeId = changePasswordCode;

        AccountAccessTokenResponse tokenResponse = client.register(registerRequest, runtime);

        System.out.println(new Gson().toJson(tokenResponse));
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
        // get login mns Code
        MobileSendSmsCodeRequest sendSmsCodeRequest = new MobileSendSmsCodeRequest();
        sendSmsCodeRequest.appId = appId;
        sendSmsCodeRequest.phoneNumber = "13****25";
        sendSmsCodeRequest.type = "change_password";
        MobileSendSmsCodeResponse response = client.mobileSendSmsCode(sendSmsCodeRequest, runtime);
        String changePasswordCode = response.smsCodeId;


        // mns login
        MobileLoginRequest mobileLoginRequest = new MobileLoginRequest();
        mobileLoginRequest.appId = appId;
        mobileLoginRequest.phoneNumber = "13297039225";
        mobileLoginRequest.smsCode = "123456";
        mobileLoginRequest.smsCodeId = changePasswordCode;
        AccountAccessTokenResponse tokenResponse = client.login(mobileLoginRequest, runtime);
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
        DefaultSetPasswordRequest setPasswordRequest = new DefaultSetPasswordRequest();
        setPasswordRequest.appId = appId;
        setPasswordRequest.newPassword = "1234567";
        setPasswordRequest.state = "aKsdfGoeasd***ksFasds";
        client.setPassword(setPasswordRequest, runtime);
        
        // 此结果不返回body
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
        MobileLoginRequest mobileLoginRequest = new MobileLoginRequest();
        mobileLoginRequest.appId = appId;
        mobileLoginRequest.phoneNumber = "13*****225";
        mobileLoginRequest.password = "*********";
        AccountAccessTokenResponse tokenResponse = client.login(mobileLoginRequest, runtime);

        //  打印返回结果
        System.out.println(new Gson().tojson(tokenResponse));

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
        // get change passowrd mns Code
        MobileSendSmsCodeRequest sendSmsCodeRequest = new MobileSendSmsCodeRequest();
        sendSmsCodeRequest.appId = appId;
        sendSmsCodeRequest.phoneNumber = "13****25";
        sendSmsCodeRequest.type = "change_password";
        MobileSendSmsCodeResponse response = client.mobileSendSmsCode(sendSmsCodeRequest, runtime);

        String changePasswordCode = response.smsCodeId;

        // chang password
        DefaultChangePasswordRequest changePasswordRequest = new DefaultChangePasswordRequest();
        changePasswordRequest.appId = appId;
        changePasswordRequest.phoneNumber = "13****25";
        changePasswordRequest.newPassword = "1234567";
        changePasswordRequest.smsCode = "13124353";
        changePasswordRequest.smsCodeId = changePasswordCode;

        client.changePassword(changePasswordRequest, runtime);
        
        //此接口不返回body
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
        TokenRequest tokenRequest = new TokenRequest();
        tokenRequest.appId = appId;
        tokenRequest.grantType = "refresh_token";
        tokenRequest.refreshToken = "Dln*******Tcpz";

        AccountAccessTokenResponse tokenResponse = client.token(tokenRequest, runtime);
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
        GetAccessTokenByLinkInfoRequest getAccessTokenByLinkInfoRequest = new GetAccessTokenByLinkInfoRequest();
        getAccessTokenByLinkInfoRequest.identity = "13297039225";
        getAccessTokenByLinkInfoRequest.type = "mobile";

        AccountAccessTokenResponse tokenResponse = client.getAccessTokenByLinkInfo(getAccessTokenByLinkInfoRequest, runtime);
        System.out.println(new Gson().toJson(tokenResponse));
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
        GetLinkInfoByUserIDRequest linkInfoByUserIDRequest = new GetLinkInfoByUserIDRequest();
        linkInfoByUserIDRequest.userId = "6c23c********5211";
        LinkInfoListResponse listResponse = client.getLinkInfoByUserId(linkInfoByUserIDRequest, runtime);
        
        System.out.println(new Gson().toJson(listResponse));
    } catch (TeaException e) {
        System.out.println(e.getCode());
        System.out.println(e.getMessage());
        System.out.println(e.getData());
    }


```

- 返回结果

~~~javascript
{
    "requestId":"F19338F6-55B6-45D4-9D29-3B950125B175",
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
        GetByLinkInfoRequest getByLinkInfoRequest = new GetByLinkInfoRequest();
        getByLinkInfoRequest.identity = "adsfqwrsfad";
        getByLinkInfoRequest.type = "ding";

        LinkInfoResponse linkInfoResponse = client.getLinkInfo(getByLinkInfoRequest, runtime);
        System.out.println(new Gson().toJson(linkInfoResponse));
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
    "requestId":"61AC56AD-E048-4292-8898-053287220B98",
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
        AccountLinkRequest linkInfo = new AccountLinkRequest();
        linkInfo.type = "taobao";
        linkInfo.identity = "1234";
        linkInfo.userId = "1eb*********08cb";
        linkInfo.status ="wait_link";

        AccountAccessTokenResponse tokenResponse = client.link(linkInfo, runtime);

        System.out.println(new Gson().toJson(tokenResponse));
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
    "requestId":"2DB728B5-6468-4E41-9BDE-677433FFCE16",
    "accessToken":"eyJ*****igpwc",
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
        CancelLinkRequest cancelLinkRequest = new CancelLinkRequest();
        cancelLinkRequest.temporaryToken = "einR5cCI6IkpX****asfsdfdf";
        AccountAccessTokenResponse tokenResponse = client.cancelLink(cancelLinkRequest, runtime);

        System.out.println(new Gson().toJson(tokenResponse));
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
public void confirmlLink() throws Exception {
    try {
        CancelLinkRequest cancelLinkRequest = new CancelLinkRequest();
        cancelLinkRequest.temporaryToken = "einR5cCI6IkpX****asfsdfdf";
        AccountAccessTokenResponse tokenResponse = client.cancelLink(cancelLinkRequest, runtime);

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
        CreateUserRequest createUserRequest = new CreateUserRequest();
        createUserRequest.userId = "test_user";
        createUserRequest.role = "user";
        createUserRequest.userName = "test_user";
        CreateUserResponse createUserResponse = client.createUser(createUserRequest, runtime);

        //  打印返回结果
        System.out.println(new Gson().tojson(createUserResponse));

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
    "requestId":"44AF1DB3-119D-4A2E-B9F1-6155C613C9A9",
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
        GetUserRequest getUserRequest = new GetUserRequest();
        getUserRequest.userId = userId;
        GetUserResponse getUserResponse = client.getUser(getUserRequest, runtime);

        //  打印返回结果
        System.out.println(new Gson().tojson(getUserResponse));

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
    "requestId":"2E4824D1-AF73-4F3B-B8C0-C9F446DE4198",
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
        ListUserRequest listUserRequest = new ListUserRequest();
        listUserRequest.limit = 10;
        ListUserResponse listUserResponse = client.listUsers(listUserRequest, runtime);

        //  打印返回结果
        System.out.println(new Gson().tojson(listUserResponse));

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
    "requestId":"BD84CB38-20A2-4652-ABE8-E35580D77DC7",
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
            "nickName":"13297039225",
            "phone":"13297039225",
            "role":"admin",
            "status":"enabled",
            "updatedAt":1571907859554,
            "userId":"6c23c98****************f5211",
            "userName":"13297039225"
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
        UpdateUserRequest updateUserRequest = new UpdateUserRequest();
        updateUserRequest.description = "test_user";
        // userId为之前创建的user
        updateUserRequest.userId = userId; 
        UpdateUserResponse updateUserResponse = client.updateUser(updateUserRequest, runtime);

        //  打印返回结果
        System.out.println(new Gson().tojson(updateUserResponse));
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
    "requestId":"56FEFF5B-9E88-403B-AED4-92B051BE4E74",
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
        SearchUserRequest searchUserRequest  = new SearchUserRequest();
        searchUserRequest.userName  = "刘";
        ListUserResponse listUserResponse = client.searchUser(searchUserRequest,runtimeOptions);


        //  打印返回结果
        System.out.println(new Gson().toJson(listUserResponse));
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
    "requestId":"0CCADE95-61CC-41BC-9047-39145CC50054",
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
        DeleteUserRequest deleteUserRequest = new DeleteUserRequest();
        deleteUserRequest.userId = userId;
        client.deleteUser(deleteUserRequest, runtimeOptions);
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
        ListStoresRequest listStoresRequest = new ListStoresRequest();
        listStoresRequest.domainId = "daily1405";
        ListStoresResponse listStoresResponse = client.listStores(listStoresRequest, runtime);

        //打印结果
        System.out.println(new Gson().tojson(listStoresResponse));

        // 根据自己的需求从返回的结果中选择store_id
        String storeId = listStoresResponse.items[0].storeIdstore_id;

        //创建drive
        CreateDriveRequest createDriveRequest = new CreateDriveRequest();
        createDriveRequest.totalSize = 1000000L;
        createDriveRequest.driveName = "test_drive";
        createDriveRequest.description = "test_drive";
        createDriveRequest.driveType = "normal";
        createDriveRequest.relativePath = "/test_drive/";
        createDriveRequest.storeId = storeId;
        createDriveRequest.owner = userId;
        CreateDriveResponse createDriveResponse = client.createDrive(createDriveRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(createDriveResponse));
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
    "requestId":"84BDA281-9B83-477B-B2CC-41D47C8FD982",
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
        ListDriveRequest listDriveRequest = new ListDriveRequest();
        listDriveRequest.limit = 1;
        listDriveRequest.owner = userId;
        ListDriveResponse listDriveResponse = client.listDrives(listDriveRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listDriveResponse));
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
    "requestId":"871949D9-12A4-4220-B078-D6E937F90699",
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
        GetDriveRequest getDriveRequest = new GetDriveRequest();
        getDriveRequest.driveId = driveId;
        GetDriveResponse getDriveResponse = client.getDrive(getDriveRequest, runtime);

        //打印结果
        System.out.println(new Gson().toJson(getDriveResponse));
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
    "requestId":"C50006A6-D23B-43AA-B634-3656CB23D542",
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
        ListDriveRequest listDriveRequest = new ListDriveRequest();
        listDriveRequest.limit = 1;
        listDriveRequest.owner = userId;
        ListDriveResponse listDriveResponse = client.listDrives(listDriveRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listDriveResponse));
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
    "requestId":"51C9C618-25CE-487B-8A28-33827AF6DC99",
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
        UpdateDriveRequest updateDriveRequest = new UpdateDriveRequest();
        updateDriveRequest.driveId = driveId;
        updateDriveRequest.description = "changed_drive";
        updateDriveRequest.totalSize = 1000000L;
        UpdateDriveResponse updateDriveResponse = client.updateDrive(updateDriveRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(updateDriveResponse));
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
        DeleteDriveRequest deleteDriveRequest = new DeleteDriveRequest();
        deleteDriveRequest.driveId = driveId;
        client.deleteDrive(deleteDriveRequest, runtime);
        // 此接口不返回body
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
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
        CreateShareRequest createShareRequest = new CreateShareRequest();
        createShareRequest.shareFilePath = "/test_share/";
        createShareRequest.owner = userId;
        createShareRequest.shareName = "test_share";
        createShareRequest.permissions = new String[]{"FILE.LIST"};
        createShareRequest.expiration = nowAsISO;
        createShareRequest.driveId = driveId;

        CreateShareResponse createShareResponse = client.createShare(createShareRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(createShareResponse));

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
    "requestId":"CD01D212-D12A-4250-A773-8296E01B226A",
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
        ListShareRequest listShareRequest = new ListShareRequest();
        listShareRequest.owner = userId;
        ListShareResponse listShareResponse = client.listShare(listShareRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listShareResponse));
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
    "requestId":"4A5EF007-CA9B-49E2-A2A9-68108E34F7F7",
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
        GetShareRequest getShareRequest = new GetShareRequest();
        getShareRequest.shareId = shareID;
        GetShareResponse getShareResponse = client.getShare(getShareRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(getShareResponse));
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
    "requestId":"3DC7F2B1-68D4-4B1D-BF12-3F3814C22278",
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
        UpdateShareRequest updateShareRequest = new UpdateShareRequest();
        updateShareRequest.shareId = shareID;
        updateShareRequest.description = "changed_share";
        UpdateShareResponse updateShareResponse = client.updateShare(updateShareRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(updateShareResponse));
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
    "requestId":"F693F9EB-863E-49AF-AE0D-AD158B3613D5",
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
        DeleteShareRequest deleteShareRequest = new DeleteShareRequest();
        deleteShareRequest.shareId = shareID;
        client.deleteShare(deleteShareRequest,runtime);
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
        OSSCreateFileRequest ossCreateFileRequest = new OSSCreateFileRequest();
        ossCreateFileRequest.type = "file";
        ossCreateFileRequest.name = "a.txt";
        ossCreateFileRequest.driveId = driveId;
        ossCreateFileRequest.parentFilePath = "/";
        ossCreateFileRequest.contentType = "text/plain";

        OSSCreateFileResponse ossCreateFileResponse = client.createFile(ossCreateFileRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossCreateFileResponse));
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
    "requestId":"E30F4EC3-0655-44DD-8A8A-8D71848CCC44",
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
        OSSCreateFileRequest ossCreateFileRequest = new OSSCreateFileRequest();
        ossCreateFileRequest.type = "file";
        ossCreateFileRequest.name = "a.txt";
        ossCreateFileRequest.driveId = driveId;
        ossCreateFileRequest.parentFilePath = "/";
        ossCreateFileRequest.contentType = "text/plain";

        OSSCreateFileResponse ossCreateFileResponse = client.createFile(ossCreateFileRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossCreateFileResponse));
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
    "requestId":"67AF911A-F8F8-4FD4-994C-797642468AFF",
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
        OSSGetFileRequest ossGetFileRequest = new OSSGetFileRequest();
        ossGetFileRequest.driveId = driveId;
        ossGetFileRequest.filePath = filePath;

        OSSGetFileResponse ossGetFileResponse = client.getFile(ossGetFileRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossGetFileResponse));
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
    "requestId":"0AC2633C-A0F1-402B-9CCD-EE98FAD573B7",
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
        OSSMoveFileRequest ossMoveFileRequest = new OSSMoveFileRequest();
        ossMoveFileRequest.driveId = driveId;
        ossMoveFileRequest.filePath = filePath;
        ossMoveFileRequest.toParentFilePath = folderPath;
        OSSMoveFileResponse ossMoveFileResponse = client.moveFile(ossMoveFileRequest, runtime);
        // 打印结果
        System.out.println(new Gson().toJson(ossMoveFileResponse));
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
    "requestId":"757C1547-9354-444B-92D2-127A83AEA470",
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
        OSSCopyFileRequest ossCopyFileRequest = new OSSCopyFileRequest();
        ossCopyFileRequest.filePath = movedFilePath;
        ossCopyFileRequest.driveId = driveId;
        ossCopyFileRequest.toParentFilePath = "/";

        OSSCopyFileResponse ossCopyFileResponse = client.copyFile(ossCopyFileRequest, runtime);
        // 打印结果
        System.out.println(new Gson().toJson(ossCopyFileResponse));
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
    "requestId":"24C7E91D-9715-4AE7-BDA1-4A082D7D3AA3",
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
        UploadPartInfo uploadPartInfo = new UploadPartInfo();
        uploadPartInfo.partNumber = 1L;
        OSSGetUploadUrlRequest ossGetUploadUrlRequest = new OSSGetUploadUrlRequest();
        ossGetUploadUrlRequest.driveId = driveId;
        ossGetUploadUrlRequest.filePath = filePath;
        ossGetUploadUrlRequest.uploadId = uploadId;
        ossGetUploadUrlRequest.partInfoList = new UploadPartInfo[]{uploadPartInfo};
        OSSGetUploadUrlResponse ossGetUploadUrlResponse = client.getUploadUrl(ossGetUploadUrlRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossGetUploadUrlResponse));
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
    "requestId":"64062AF5-7ADF-4F7D-9878-9E2FA6AABE53",
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
        OSSGetDownloadUrlRequest ossGetDownloadUrlRequest = new OSSGetDownloadUrlRequest();
        ossGetDownloadUrlRequest.driveId = driveId;
        ossGetDownloadUrlRequest.filePath = filePath;
        ossGetDownloadUrlRequest.expireSec = 3600L;

        OSSGetDownloadUrlResponse ossGetDownloadUrlResponse = client.getDownloadUrl(ossGetDownloadUrlRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossGetDownloadUrlResponse));
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
        UploadPartInfo uploadPartInfo1 = new UploadPartInfo();
        uploadPartInfo1.etag = etag;
        uploadPartInfo1.partNumber = 1L;
        OSSCompleteFileRequest ossCompleteFileRequest = new OSSCompleteFileRequest();
        ossCompleteFileRequest.driveId = driveId;
        ossCompleteFileRequest.filePath = filePath;
        ossCompleteFileRequest.uploadId = newUploadId;
        ossCompleteFileRequest.partInfoList = new UploadPartInfo[]{uploadPartInfo1};
        OSSCompleteFileResponse ossCompleteFileResponse = client.completeFile(ossCompleteFileRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ossCompleteFileResponse));
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
    "requestId":"B05D6ABD-AF30-4E10-B1FA-4168941EE750",
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
        OSSDeleteFileRequest ossDeleteFileRequest =  new OSSDeleteFileRequest();
        ossDeleteFileRequest.driveId = driveId;
        ossDeleteFileRequest.filePath = copiedFilePath;

        client.deleteFile(ossDeleteFileRequest, runtime);

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
        ListStorageRequest listStoresRequest = new ListStorageRequest();
        listStoresRequest.domainId = "daily1405";
        ListStorageResponse listStoresResponse = client.listStorage(listStoresRequest, runtime);
        System.out.println(new Gson().toJson(listStoresResponse));
        String storeId = listStoresResponse.items[0].storeId;

        ListStorageFileRequest listStorageFileRequest = new ListStorageFileRequest();
        listStorageFileRequest.storeId = storeId;
        listStorageFileRequest.limit = 10L;
		
        // list store_file
        ListStorageFileResponse listStorageFileResponse = client.listStoragefile(listStorageFileRequest,runtime);

       

        // 打印结果
        System.out.println(new Gson().toJson(listStorageFileResponse));
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
    "requestId":"DB0A660A-C4B6-4620-BF83-B6CFCA31162C",
    "items":[
        {
            "domainId":"",
            "name":"***y",
            "parentFilePath":"/",
            "storeId":"90fba27e9c40452d91d83b204aee1d9b",
            "type":"folder"
        },
        {
            "domainId":"",
            "name":"superadmin",
            "parentFilePath":"/",
            "storeId":"90fba27e9c40452d91d83b204aee1d9b",
            "type":"folder"
        },
        {
            "domainId":"",
            "name":"test",
            "parentFilePath":"/",
            "storeId":"90fba27e9c40452d91d83b204aee1d9b",
            "type":"folder"
        },
        {
            "domainId":"",
            "name":"test_drive",
            "parentFilePath":"/",
            "storeId":"90fba27e9c40452d91d83b204aee1d9b",
            "type":"folder"
        }
    ],
    "nextMarker":""
}
~~~



## CCPPath Drive 相关API

### 创建drive

- 以下代码用于创建Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 创建 Drive
public static void createDrive() throws Exception {
    try {
        CreateDriveRequest createDriveRequest = new CreateDriveRequest();
        createDriveRequest.totalSize = 100000L;
        createDriveRequest.driveName = "test_drive";
        createDriveRequest.driveType = "normal";
        createDriveRequest.owner =  userId ;
        CreateDriveResponse createDriveResponse = client.createDrive(createDriveRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(createDriveResponse));
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
    "requestId":"6B556975-1A8D-4517-9227-D1CED662A24B",
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
        ListDriveRequest listDriveRequest = new ListDriveRequest();
        listDriveRequest.limit = 1;
        listDriveRequest.owner = userId;
        ListDriveResponse listDriveResponse = client.listDrives(listDriveRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(listDriveResponse));
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
    "requestId":"51C9C618-25CE-487B-8A28-33827AF6DC99",
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
        GetDriveRequest getDriveRequest = new GetDriveRequest();
        getDriveRequest.driveId = driveId;
        GetDriveResponse getDriveResponse = client.getDrive(getDriveRequest, runtime);

        //打印结果
        System.out.println(new Gson().toJson(getDriveResponse));
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
    "requestId":"2A361340-F298-4685-8C8B-B34C12EE2F41",
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
        UpdateDriveRequest updateDriveRequest = new UpdateDriveRequest();
        updateDriveRequest.driveId = driveId;
        updateDriveRequest.description = "changed_drive";
        updateDriveRequest.totalSize = 1000000L;
        UpdateDriveResponse updateDriveResponse = client.updateDrive(updateDriveRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(updateDriveResponse));
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
    "requestId":"501B210E-0D4C-46E9-9D35-F1E86074A1D8",
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
        DeleteDriveRequest deleteDriveRequest = new DeleteDriveRequest();
        deleteDriveRequest.driveId = driveId;
        client.deleteDrive(deleteDriveRequest, runtime);
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
        CCPCreateFileRequest ccpCreateFileRequest = new CCPCreateFileRequest();
        ccpCreateFileRequest.type = "file";
        ccpCreateFileRequest.name = "a.txt";
        ccpCreateFileRequest.driveId = driveId;
        ccpCreateFileRequest.parentFileId = "root";
        ccpCreateFileRequest.contentType = "text/plain";

        CCPCreateFileResponse ccpCreateFileResponse = client.createFile(ccpCreateFileRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpCreateFileResponse));
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
    "requestId":"70BC9CC0-A4E9-49A1-9384-6C9CEF286981",
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
        CCPListFileRequest ccpListFileRequest = new CCPListFileRequest();
        ccpListFileRequest.driveId = driveId;
        ccpListFileRequest.parentFileId = folderId;
        ccpListFileRequest.limit = 1L;

        CCPListFileResponse ccpListFileResponse = client.listFile(ccpListFileRequest, runtime);


        // 打印结果
        System.out.println(new Gson().toJson(ccpListFileResponse));;
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
    "requestId":"98B303D7-711B-4E98-BAAE-A09B49A4168D",
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
        CCPGetFileRequest ccpGetFileRequest = new CCPGetFileRequest();
        ccpGetFileRequest.driveId = driveId;
        ccpGetFileRequest.fileId = fileId;

        CCPGetFileResponse ccpGetFileResponse = client.getFile(ccpGetFileRequest, runtime);
        
        // 打印结果
        System.out.println(new Gson().toJson(ccpGetFileResponse));
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
    "requestId":"C32B9339-C65E-4AB6-86C9-AC4F172A0C63",
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
        CCPMoveFileRequest ccpMoveFileRequest = new CCPMoveFileRequest();
        ccpMoveFileRequest.driveId = driveId;
        ccpMoveFileRequest.fileId = fileId;
        ccpMoveFileRequest.toParentFileId = folderId;

        CCPMoveFileResponse ccpMoveFileResponse = client.moveFile(ccpMoveFileRequest, runtime);
        // 打印结果
        System.out.println(new Gson().toJson(ccpMoveFileResponse));
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
    "requestId":"B6E69EDE-D3C9-410E-B4D1-059355A38F34",
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
        CCPCopyFileRequest ccpCopyFileRequest = new CCPCopyFileRequest();
        ccpCopyFileRequest.fileId = fileId;
        ccpCopyFileRequest.driveId = driveId;
        ccpCopyFileRequest.toParentFileId = "root";

        CCPCopyFileResponse ccpCopyFileResponse = client.copyFile(ccpCopyFileRequest, runtime);
        // 打印结果
        System.out.println(new Gson().toJson(ccpCopyFileResponse));
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
    "requestId":"F001CD18-8BD8-481E-B1F1-8B804709A865",
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
        CCPGetUploadUrlRequest ccpGetUploadUrlRequest = new CCPGetUploadUrlRequest();
        ccpGetUploadUrlRequest.driveId = driveId;
        ccpGetUploadUrlRequest.fileId = fileId;
        ccpGetUploadUrlRequest.uploadId = uploadId;
        ccpGetUploadUrlRequest.partInfoList = new UploadPartInfo[]{uploadPartInfo};

        CCPGetUploadUrlResponse ccpGetUploadUrlResponse = client.getUploadUrl(ccpGetUploadUrlRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpGetUploadUrlResponse));
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
    "requestId":"8E80078C-0749-4C03-A3AB-F0274D652114",
    "createAt":"2019-10-28T08:40:54.519Z",
    "domainId":"daily1404",
    "driveId":"603",
    "fileId":"5db6a996aa1292d7563644f0bc4847107171ed7f",
    "partInfoList":[
        {
            "partNumber":1,
            "uploadUrl":"https://ccp-daily1404-hz-1571887934.oss-cn-hangzhou.aliyuncs.com/5db6a996aa1292d7563644f0bc4847107171ed7f%2F5db6a996e8f9ecd76fae49d196a93eeaf7009b09?Expires=1572252114&OSSAccessKeyId=LTAIi5kx6X0mwR8k&Signature=TOMPiGXx0733JZZEzSCPoDMUk%2FE%3D&partNumber=1&uploadId=DEB65A38FCCA410BAC6DD23A8A11F943"
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
        CCPGetDownloadUrlRequest ccpGetDownloadUrlRequest = new CCPGetDownloadUrlRequest();
        ccpGetDownloadUrlRequest.driveId = driveId;
        ccpGetDownloadUrlRequest.fileId = fileId;
        ccpGetDownloadUrlRequest.expireSec = 3600L;

        CCPGetDownloadUrlResponse ccpGetDownloadUrlResponse = client.getDownloadUrl(ccpGetDownloadUrlRequest, runtime);


        // 打印结果
        System.out.println(new Gson().toJson(ccpGetDownloadUrlResponse));
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
    "requestId":"29B59FA4-C6BD-44F6-809F-BF788F435145",
    "expiration":"2019-10-28T09:40:55.716Z",
    "method":"GET",
    "url":"https://ccp-daily1404-hz-1571887934.oss-cn-hangzhou.aliyuncs.com/5db5910348946ee1835e4c139165301333e5f743%2F5db59103967263443aef47799253e5e63970d7ce?Expires=1572252955&OSSAccessKeyId=LTAIi5kx6X0mwR8k&Signature=urIb%2BP03nvZg0%2Birshzeow5u6ow%3D&response-content-disposition=attachment%3Bfilename%3Da.txt"
}
~~~



### Complete File

- 以下代码用于Complete File，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 合并File分片
public static void completeFile() throws Exception {
    try {
        UploadPartInfo uploadPartInfo1 = new UploadPartInfo();
        uploadPartInfo1.etag = etag;
        uploadPartInfo1.partNumber = 1L;
        CCPCompleteFileRequest ccpCompleteFileRequest = new CCPCompleteFileRequest();
        ccpCompleteFileRequest.driveId = driveId;
        ccpCompleteFileRequest.fileId = fileId;
        ccpCompleteFileRequest.uploadId = newUploadId;
        ccpCompleteFileRequest.partInfoList = new UploadPartInfo[]{uploadPartInfo1};

        CCPCompleteFileResponse ccpCompleteFileResponse = client.completeFile(ccpCompleteFileRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpCompleteFileResponse));
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~



- 返回结果

~~~
{
    "requestId":"6E4FCA06-8554-425A-8447-1A3826B064CA",
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
        CCPUpdateFileMetaRequest ccpUpdateFileMetaRequest = new CCPUpdateFileMetaRequest();
        ccpUpdateFileMetaRequest.fileId = fileId;
        ccpUpdateFileMetaRequest.description = "changed_file";
        ccpUpdateFileMetaRequest.driveId = driveId;

        CCPUpdateFileMetaResponse ccpUpdateFileMetaResponse = client.updateFile(ccpUpdateFileMetaRequest, runtime);


        // 打印结果
        System.out.println(new Gson().toJson(ccpUpdateFileMetaResponse));
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
    "requestId":"C58CA3EC-A71B-4DEE-B319-C92E847C4702",
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
        CCPSearchFileRequest ccpSearchFileRequest = new CCPSearchFileRequest();
        ccpSearchFileRequest.driveId = driveId;
        ccpSearchFileRequest.limit = 10;
        ccpSearchFileRequest.orderBy = "type DESC";
        ccpSearchFileRequest.query = "file_extension in [\"txt\"]";
        CCPSearchFileResponse ccpSearchFileResponse = client.searchFile(ccpSearchFileRequest, runtime);

        // 打印结果
        System.out.println(new Gson().toJson(ccpSearchFileResponse));
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
    "requestId":"E285FC30-6414-4843-8F09-707DC610DA0B",
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



删除File

- 以下代码用于创建Drive，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档。

~~~java
// 删除 file
public static void deleteFile() throws Exception {
    try {
        CCPDeleteFileRequest ccpDeleteFileRequest1 = new CCPDeleteFileRequest();
        ccpDeleteFileRequest1.driveId = driveId;
        ccpDeleteFileRequest1.fileId = copiedFileId;

        client.deleteFile(ccpDeleteFileRequest1, runtime);
        // 此接口不返回body
    } catch (TeaException e) {
        System.out.println(e.getMessage());
        System.out.println(e.getCode());
        System.out.println(new Gson().toJson(e.getData()));
    }
}
~~~

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
import com.aliyun.ccp.ccpclient.models.*;
import com.aliyun.ccp.ccpclient.Client;
import com.aliyun.tea.TeaException;
import com.google.gson.Gson;
import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.RequestBody;
import okhttp3.Response;


public class Demo {
    private static Client client;
    private static RuntimeOptions runtime;

    public static void main(String[] args) throws  Exception{
        createClient();
        createFile();
    }

    public static  void createClient() throws IllegalAccessException {
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
            // create file
            CCPCreateFileRequest ccpCreateFileRequest = new CCPCreateFileRequest();
            ccpCreateFileRequest.type = "file";
            ccpCreateFileRequest.name = "a.txt";
            ccpCreateFileRequest.driveId = "1";
            ccpCreateFileRequest.parentFileId = "root";
            ccpCreateFileRequest.contentType = "text/plain";
            CCPCreateFileResponse ccpCreateFileResponse = client.createFile(ccpCreateFileRequest, runtime);

            // get upload parameter
            String uploadId = ccpCreateFileResponse.uploadId;
            String fileId = ccpCreateFileResponse.fileId;
            String uploadUrl = ccpCreateFileResponse.partInfoList[0].uploadUrl;


            // upload file
            Request.Builder requestBuilder = new Request.Builder();
            RequestBody body = RequestBody.create(null, "123456");
            requestBuilder.url(uploadUrl);
            requestBuilder.put(body);
            Request request = requestBuilder.build();
            OkHttpClient okHttpClient = new OkHttpClient.Builder().build();
            Response response = okHttpClient.newCall(request).execute();

            // get ETag
            String etag = response.headers().get("ETag");

            // complete file
            UploadPartInfo uploadPartInfo1 = new UploadPartInfo();
            uploadPartInfo1.etag = etag;
            uploadPartInfo1.partNumber = 1L;
            CCPCompleteFileRequest ccpCompleteFileRequest = new CCPCompleteFileRequest();
            ccpCompleteFileRequest.driveId = "1";
            ccpCompleteFileRequest.fileId = fileId;
            ccpCompleteFileRequest.uploadId = uploadId;
            ccpCompleteFileRequest.partInfoList = new UploadPartInfo[]{uploadPartInfo1};

            CCPCompleteFileResponse ccpCompleteFileResponse = client.completeFile(ccpCompleteFileRequest, runtime);

            // print result
            System.out.println(new Gson().toJson(ccpCompleteFileResponse));

        }catch (TeaException e) {
            System.out.println(e.getMessage());
            System.out.println(e.getCode());
            System.out.println(new Gson().toJson(e.getData()));
        }
    }
}
~~~

