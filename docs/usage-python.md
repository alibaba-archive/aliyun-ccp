![](https://aliyunsdk-pages.alicdn.com/icons/AlibabaCloud.svg)

# 下载地址

> *https://github.com/aliyun/aliyun-ccp*

# 要求

- Python版本 >= 3.4.

# 安装步骤

CCP Path

```bash
pip install alibabacloud_ccppath_sdk
```

OSS Path

```bash
pip install alibabacloud_osspath_sdk
```

# 初始化Client

## AK & SK 初始化客户端

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import Config

config = Config(
            access_key_id='access_key_id',
            access_key_secret='access_key_secret',
            domain_id='domain_id',
            protocol='https'
        )
client = Client(config)
```

## ClientID & Client Secret 初始化客户端

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import Config

config = Config(
            client_id='client_id',
            client_secret='client_secret',
            access_token='access_token',
            refresh_token='refresh_token',
            expire_time='expire_time',
            domain_id='domain_id',
            protocol='https'
        )
client = Client(config)
```

# 构造请求

## Account 相关 API

### 获取图片验证码

- 以下代码用于获取图片验证码，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    GetCaptchaRequest,
    GetCaptchaRequestModel
)

config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)

runtime = RuntimeOptions()
client = Client(config)

request = GetCaptchaRequest(
    app_id='app_id'
)
model = GetCaptchaRequestModel(
    headers={},
    body=request
)

response = client.get_captcha(model, runtime)
```

### 获取短信验证码

- 以下代码用于获取短信验证码，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    MobileSendSmsCodeRequest,
    MobileSendSmsCodeRequestModel
)

config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)

runtime = RuntimeOptions()
client = Client(config)
request = MobileSendSmsCodeRequest(
    app_id='app_id',
    phone_number='phone_number',
    type='login'
)
model = MobileSendSmsCodeRequestModel(
    headers={},
    body=request
)
response = client.mobile_send_sms_code(model, runtime)
```

### 验证手机号是否注册

- 以下代码用于验证手机号是否注册，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    MobileCheckExistRequest,
    CheckExistRequestModel
)

config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)

runtime = RuntimeOptions()
client = Client(config)
request = MobileCheckExistRequest(
    app_id='app_id',
    phone_number='phone_number'
)
model = CheckExistRequestModel(
    headers={},
    body=request
)
response = client.check_exist(model, runtime)
```

### 手机号注册

- 以下代码用于手机号注册，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    MobileRegisterRequest,
    RegisterRequestModel
)

config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)

runtime = RuntimeOptions()
client = Client(config)
request = MobileRegisterRequest(
    app_id='app_id',
    phone_number='phone_number',
    sms_code='sms_code',
    sms_code_id='sms_code_id',
)
model = RegisterRequestModel(
    headers={},
    body=request
)
response = client.register(model, runtime)
```

### 手机号短信登录

- 以下代码用于手机号短信登录，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    MobileLoginRequest,
    LoginRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = MobileLoginRequest(
    app_id='app_id',
    phone_number='phone_number',
    sms_code='sms_code',
    sms_code_id='sms_code_id',
)
model = LoginRequestModel(
    headers={},
    body=request
)
response = client.login(model, runtime)
```

### 设置登录密码

- 以下代码用于设置登录密码，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    DefaultSetPasswordRequest,
    SetPasswordRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = DefaultSetPasswordRequest(
    app_id='app_id',
    state='state',
    new_password='new_password'
)
model = SetPasswordRequestModel(
    headers={},
    body=request
)
response = client.set_password(model, runtime)
```

### 密码登录

- 以下代码用于密码登录，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    MobileLoginRequest,
    LoginRequestModel,
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = MobileLoginRequest(
    app_id='app_id',
    phone_number='phone_number',
    password='password'
)
model = LoginRequestModel(
    headers={},
    body=request
)
response = client.login(model, runtime)
```

### 修改登录密码

- 以下代码用于修改登录密码，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    DefaultChangePasswordRequest,
    ChangePasswordRequestModel,
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = DefaultChangePasswordRequest(
    app_id='app_id',
    phone_number='phone_number',
    new_password='password'
)
model = ChangePasswordRequestModel(
    headers={},
    body=request
)
response = client.change_password(model, runtime)
```

### 通过刷新令牌获取访问令牌

- 以下代码用于通过刷新令牌获取访问令牌，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    TokenRequest,
    AccountTokenRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = TokenRequest(
    app_id='app_id',
    refresh_token='refresh_token',
    grant_type='grant_type'
)
model = AccountTokenRequestModel(
    headers={},
    body=request
)
response = client.account_token(model, runtime)
```

### 通过账号获取访问令牌

> 此接口需要 ak，sk 调用， 请使用 ak, sk 初始化客户端

- 以下代码用于通过账号获取访问令牌，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    GetAccessTokenByLinkInfoRequest,
    GetAccessTokenByLinkInfoRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = GetAccessTokenByLinkInfoRequest(
    type='type',
    identity='identity'
)
model = GetAccessTokenByLinkInfoRequestModel(
    headers={},
    body=request
)
response = client.get_access_token_by_link_info(model, runtime)
```

### 获取用户绑定信息

> 此接口需要 ak，sk 调用， 请使用 ak, sk 初始化客户端

- 以下代码用于获取用户绑定信息，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    GetLinkInfoByUserIDRequest,
    GetLinkInfoByUserIdRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = GetLinkInfoByUserIDRequest(
    user_id='user_id'
)
model = GetLinkInfoByUserIdRequestModel(
    headers={},
    body=request
)
response = client.get_link_info_by_user_id(model, runtime)
```

### 获取用户认证方式

> 此接口需要 ak，sk 调用， 请使用 ak, sk 初始化客户端

- 以下代码用于获取用户认证方式，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    GetByLinkInfoRequest,
    GetLinkInfoRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = GetByLinkInfoRequest(
    type='type',
    identity='identity'
)
model = GetLinkInfoRequestModel(
    headers={},
    body=request
)
response = client.get_link_info(model, runtime)
```

### 绑定用户认证方式

> 此接口需要 ak，sk 调用， 请使用 ak, sk 初始化客户端

- 以下代码用于绑定用户认证方式，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    AccountLinkRequest,
    LinkRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = AccountLinkRequest(
    type='type',
    identity='identity',
    user_id='user_id'
)
model = LinkRequestModel(
    headers={},
    body=request
)
response = client.link(model, runtime)
```

### 取消绑定关系

- 以下代码用于取消绑定关系，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CancelLinkRequest,
    CancelLinkRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CancelLinkRequest(
    temporary_token='temporary_token'
)
model = CancelLinkRequestModel(
    headers={},
    body=request
)
response = client.cancel_link(model, runtime)
```

### 确定绑定关系

> 此接口需要 accessToken 调用， 请使用 clientId，ClientSecret 初始化客户端

- 以下代码用于确定绑定关系，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    ConfirmLinkRequest,
    ConfirmLinkRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = ConfirmLinkRequest(
    temporary_token='temporary_token'
)
model = ConfirmLinkRequestModel(
    headers={},
    body=request
)
client.confirm_link(model, runtime)

```

## User 相关 API

### 创建 User

- 以下代码用于创建 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CreateUserRequest,
    CreateUserRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CreateUserRequest(
    user_id='user_id'
)
model = CreateUserRequestModel(
    headers={},
    body=request
)
client.create_user(model, runtime)
```

### 获取 User

- 以下代码用于获取 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    GetUserRequest,
    GetUserRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = GetUserRequest(
    user_id='user_id'
)
model = GetUserRequestModel(
    headers={},
    body=request
)
client.get_user(model, runtime)
```

### 列举 User

- 以下代码用于列举 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    ListUserRequest,
    ListUsersRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = ListUserRequest(
    marker='marker'
)
model = ListUsersRequestModel(
    headers={},
    body=request
)
client.list_users(model, runtime)
```

### 更新 User

- 以下代码用于更新 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    UpdateUserRequest,
    UpdateUserRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = UpdateUserRequest(
    user_id='user_id'
)
model = UpdateUserRequestModel(
    headers={},
    body=request
)
client.update_user(model, runtime)

```

### 搜索 User

- 以下代码用于搜索 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    SearchUserRequest,
    SearchUserRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = SearchUserRequest(
    user_name='user_name'
)
model = SearchUserRequestModel(
    headers={},
    body=request
)
client.search_user(model, runtime)

```

### 删除 User

- 以下代码用于删除 User，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    DeleteUserRequest,
    DeleteUserRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = DeleteUserRequest(
    user_id='user_id'
)
model = DeleteUserRequestModel(
    headers={},
    body=request
)
client.delete_user(model, runtime)
```

## OSSPath Drive 相关API

### 说明

- OSSPath 创建drive 需要先拿到 `store_id`，需要先调用 `AdminListStores` 的接口。

### 创建 drive

- 以下代码用于创建 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    AdminListStoresRequest,
    AdminListStoresRequestModel,
    CreateDriveRequest,
    CreateDriveRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)

# Admin List Stores
request = AdminListStoresRequest()
model = AdminListStoresRequestModel(
    headers={},
    body=request
)
response = client.admin_list_stores(model, runtime)
store_id = response.body.items[0].store_id

# Create Drive
drive_request = CreateDriveRequest(
    drive_name='drive_name',
    owner='owner',
    store_id=store_id
)
drive_model = CreateDriveRequestModel(
    body=drive_request
)
client.create_drive(drive_model, runtime)
```

### 查询 drive

- 以下代码用于查询 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    GetDriveRequest,
    GetDriveRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = GetDriveRequest(
    drive_id='drive_id'
)
model = GetDriveRequestModel(
    headers={},
    body=request
)
response = client.get_drive(model, runtime)

```

### 列举 drive

- 以下代码用于列举 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    ListDriveRequest,
    ListDrivesRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = ListDriveRequest()
model = ListDrivesRequestModel(
    headers={},
    body=request
)
response = client.list_drives(model, runtime)
```

### 更新 drive

- 以下代码用于更新 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    UpdateDriveRequest,
    UpdateDriveRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = UpdateDriveRequest(
    drive_id='drive_id'
)
model = UpdateDriveRequestModel(
    headers={},
    body=request
)
response = client.update_drive(model, runtime)
```

### 删除 drive

- 以下代码用于删除 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    DeleteDriveRequest,
    DeleteDriveRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = DeleteDriveRequest(
    drive_id='drive_id'
)
model = DeleteDriveRequestModel(
    headers={},
    body=request
)
response = client.delete_drive(model, runtime)
```

## OSSPath Share 相关 API

### 创建 Share

- 以下代码用于创建 Share，此处的示例，目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    CreateShareRequest,
    CreateShareRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CreateShareRequest(
    drive_id='drive_id',
    owner='owner',
    share_file_path='share_file_path'
)
model = CreateShareRequestModel(
    headers={},
    body=request
)
response = client.create_share(model, runtime)
```

### 查询 Share

- 以下代码用于查询 Share，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    GetShareRequest,
    GetShareRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = GetShareRequest(
    share_id='share_id'
)
model = GetShareRequestModel(
    headers={},
    body=request
)
response = client.get_share(model, runtime)

```

### 列举 Share

- 以下代码用于列举 Share，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    ListShareRequest,
    ListShareRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = ListShareRequest(
    drive_id='drive_id',
    limit='limit'
)
model = ListShareRequestModel(
    headers={},
    body=request
)
response = client.list_share(model, runtime)

```

### 更新 Share

- 以下代码用于更新 Share，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    UpdateShareRequest,
    UpdateShareRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = UpdateShareRequest(
    share_id='share_id',
    description='description'
)
model = UpdateShareRequestModel(
    headers={},
    body=request
)
response = client.update_share(model, runtime)
```

### 删除 Share

- 以下代码用于删除 Share，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    DeleteDriveRequest,
    DeleteDriveRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = DeleteDriveRequest(
    drive_id='drive_id'
)
model = DeleteDriveRequestModel(
    headers={},
    body=request
)
response = client.delete_share(model, runtime)
```

## OSSPath File 相关 API

### 创建 File

- 以下代码用于创建 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。
- 说明：此处创建 File 还需要上传文件到 OSS， 具体操作详见最佳实践。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSCreateFileRequest,
    CreateFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSCreateFileRequest(
    drive_id='drive_id'
)
model = CreateFileRequestModel(
    headers={},
    body=request
)
response = client.create_file(model, runtime)
```

### 列举 File

- 以下代码用于列举 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSListFileRequest,
    ListFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSListFileRequest(
    drive_id='drive_id'
)
model = ListFileRequestModel(
    headers={},
    body=request
)
response = client.list_file(model, runtime)
```

### 查询 File

- 以下代码用于查询 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSGetFileRequest,
    GetFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSGetFileRequest(
    file_path='file_path'
)
model = GetFileRequestModel(
    headers={},
    body=request
)
response = client.get_file(model, runtime)
```

### 移动 File

- 以下代码用于移动 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSMoveFileRequest,
    MoveFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSMoveFileRequest(
    drive_id='drive_id',
    file_path='file_path'
)
model = MoveFileRequestModel(
    headers={},
    body=request
)
response = client.move_file(model, runtime)
```

### 复制 File

- 以下代码用于复制 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSCopyFileRequest,
    CopyFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSCopyFileRequest(
    drive_id='drive_id',
    file_path='file_path'
)
model = CopyFileRequestModel(
    headers={},
    body=request
)
response = client.copy_file(model, runtime)
```

### 获取 File 上传地址

- 以下代码用于获取 File 上传地址，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSGetUploadUrlRequest,
    GetUploadUrlRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSGetUploadUrlRequest(
    drive_id='drive_id',
    file_path='file_path'
)
model = GetUploadUrlRequestModel(
    headers={},
    body=request
)
response = client.get_upload_url(model, runtime)
```

### 获取 File 下载地址

- 以下代码用于获取 File 下载地址，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSGetDownloadUrlRequest,
    GetDownloadUrlRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSGetDownloadUrlRequest(
    drive_id='drive_id',
    file_path='file_path'
)
model = GetDownloadUrlRequestModel(
    headers={},
    body=request
)
response = client.get_download_url(model, runtime)
```

### Complete File

- 以下代码用于 Complete File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSCompleteFileRequest,
    CompleteFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSCompleteFileRequest(
    drive_id='drive_id',
    file_path='file_path'
)
model = CompleteFileRequestModel(
    headers={},
    body=request
)
response = client.complete_file(model, runtime)
```

### 删除 File

- 以下代码用于删除 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    OSSDeleteFileRequest,
    DeleteFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = OSSDeleteFileRequest(
    drive_id='drive_id',
    file_path='file_path'
)
model = DeleteFileRequestModel(
    headers={},
    body=request
)
response = client.delete_file(model, runtime)
```

### 列举 Stores File

- 以下代码用于列举 Stores File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_osspath_sdk.client import Client
from alibabacloud_osspath_sdk.models import (
    Config,
    RuntimeOptions,
    ListStoreFileRequest,
    ListStorefileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = ListStoreFileRequest(
    store_id='store_id'
)
model = ListStorefileRequestModel(
    headers={},
    body=request
)
response = client.list_storefile(model, runtime)
```

## CCPPath Drive 相关API

### 创建 drive

- 以下代码用于创建 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```
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
```

### 列举 drive

- 以下代码用于列举 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```
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
```

### 查询 drive

- 以下代码用于查询 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```
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
```

### 更新 drive

- 以下代码用于更新 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```
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

### 删除 drive

- 以下代码用于删除 drive，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```
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
```

## CCPPath File 相关 API

### 创建 File

- 以下代码用于创建 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPCreateFileRequest,
    CreateFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPCreateFileRequest(
    name='name',
    type='type',
)
model = CreateFileRequestModel(
    headers={},
    body=request
)
response = client.create_file(model, runtime)
```

### 列举 File

- 以下代码用于列举 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPListFileRequest,
    ListFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPListFileRequest(
    drive_id='drive_id',
    type='type',
)
model = ListFileRequestModel(
    headers={},
    body=request
)
response = client.list_file(model, runtime)
```

### 查询 File

- 以下代码用于查询 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPGetFileRequest,
    GetFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPGetFileRequest(
    drive_id='drive_id',
)
model = GetFileRequestModel(
    headers={},
    body=request
)
response = client.get_file(model, runtime)
```

### 移动 File

- 以下代码用于移动 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPMoveFileRequest,
    MoveFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPMoveFileRequest(
    drive_id='drive_id',
    file_id='file_id'
)
model = MoveFileRequestModel(
    headers={},
    body=request
)
response = client.move_file(model, runtime)
```

### 复制 File

- 以下代码用于复制 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPCopyFileRequest,
    CopyFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPCopyFileRequest(
    drive_id='drive_id',
    file_id='file_id'
)
model = CopyFileRequestModel(
    headers={},
    body=request
)
response = client.copy_file(model, runtime)
```

### 获取 File 上传地址

- 以下代码用于获取 File 上传地址，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPGetUploadUrlRequest,
    GetUploadUrlRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPGetUploadUrlRequest(
    drive_id='drive_id',
    file_id='file_id'
)
model = GetUploadUrlRequestModel(
    headers={},
    body=request
)
response = client.get_upload_url(model, runtime)
```

### 获取 File 下载地址

- 以下代码用于获取 File 下载地址，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPGetDownloadUrlRequest,
    GetDownloadUrlRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPGetDownloadUrlRequest(
    drive_id='drive_id',
    file_id='file_id'
)
model = GetDownloadUrlRequestModel(
    headers={},
    body=request
)
response = client.get_download_url(model, runtime)
```

### Complete File

- 以下代码用于 Complete File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPCompleteFileRequest,
    CompleteFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPCompleteFileRequest(
    drive_id='drive_id',
    file_id='file_id'
)
model = CompleteFileRequestModel(
    headers={},
    body=request
)
response = client.complete_file(model, runtime)
```

### 更新 File

- 以下代码用于更新 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPUpdateFileMetaRequest,
    UpdateFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPUpdateFileMetaRequest(
    drive_id='drive_id',
    file_id='file_id'
)
model = UpdateFileRequestModel(
    headers={},
    body=request
)
response = client.update_file(model, runtime)
```

### 搜索 File

- 以下代码用于搜索 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档。

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPSearchFileRequest,
    SearchFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPSearchFileRequest(
    drive_id='drive_id',
)
model = SearchFileRequestModel(
    headers={},
    body=request
)
response = client.search_file(model, runtime)
```

### 删除 File

- 以下代码用于删除 File，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPDeleteFileRequest,
    DeleteFileRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)
request = CCPDeleteFileRequest(
    drive_id='drive_id',
)
model = DeleteFileRequestModel(
    headers={},
    body=request
)
response = client.delete_file(model, runtime)
```

### 获取异步任务状态

- 以下代码用于获取一部，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPGetAsyncTaskRequest,
    GetAsyncTaskInfoRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)

request = CCPGetAsyncTaskRequest(
    async_task_id='async_task_id',
)
model = GetAsyncTaskInfoRequestModel(
    body=request
)
response = client.get_async_task_info(model, runtime)
```

### 批量任务

- 以下代码用于执行批量操作，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    BatchSubRequest,
    CCPBatchRequest,
    BatchOperationRequestModel,
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)

sub = BatchSubRequest(
    body='body',
    url='url',
    method='method',
    id='id'
)

request = CCPBatchRequest(
    requests=[sub],
)
model = BatchOperationRequestModel(
    body=request
)
response = client.batch_operation(model, runtime)
```

### 列举已经上传的分片

- 以下代码用于执行批量操作，此处的示例目的是展示关键参数 ，其他参数请查看官方文档

```python
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPListUploadedPartRequest,
    ListUploadedPartsRequestModel
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)

request = CCPListUploadedPartRequest(
    drive_id='drive_id',
    file_id='file_id',
)
model = ListUploadedPartsRequestModel(
    body=request
)
response = client.list_uploaded_parts(model, runtime)
```

# 附

## 创建 RAM 子用户(获取 AK，SK）

1. 注册阿里云账号，详见[阿里云账号注册流程](https://help.aliyun.com/document_detail/37195.html?spm=a2c4g.11186623.2.13.6a857007v5sxu1)。
2. 开启访问控制服务，详见[RAM访问控制](https://ram.console.aliyun.com/overview)，并根据提示操作。
3. 创建 RAM 子用户，并获取 AK，SK。详见[服务端调用接口接入](https://help.aliyun.com/document_detail/134467.html?spm=a2c4g.11186623.6.551.646a6d39hQ1bQt#h2-3-3)。SK要注意保密不要泄露。

## 创建 APP(获取 ClientID, ClientSecret）

1. 首先，您需要开通内容协作平台(CCP）服务。如果没有开通，请到[产品详情页面](https://www.aliyun.com/product/ccp)开通 。
2. 您需要在CCP官网控制台创建一个域(Domain) 。详见创建[CCPath域实例](https://help.aliyun.com/document_detail/134467.html?spm=a2c4g.11186623.6.551.2f134190GNe6T2#h2-2-2)和创建[OSSPath域实例](https://help.aliyun.com/document_detail/135607.html?spm=a2c4g.11186623.6.552.26cd2c6ciSU8xM#h2-1-1)。
3. 创建 APP，选择类型为”Web服务应用”。确定 APP 的访问 Scope: [支持的Scope列表](https://help.aliyun.com/document_detail/135388.html), 这个Scope要在用户授权页面展示。创建完成，可以得到 APP ID(ClientID) 和 Secret(ClientSecret)。这个是授权认证的凭证，Secret 要注意保密不要泄露。

## CCPPath 上传文件

```python
import requests
from alibabacloud_ccppath_sdk.client import Client
from alibabacloud_ccppath_sdk.models import (
    Config,
    RuntimeOptions,
    CCPCreateFileRequest,
    CreateFileRequestModel,
    CCPCompleteFileRequest,
    CompleteFileRequestModel,
    UploadPartInfo,
)


config = Config(
    access_key_id='access_key_id',
    access_key_secret='access_key_secret',
    domain_id='domain_id',
    protocol='https'
)
runtime = RuntimeOptions()
client = Client(config)


def create_file():
    request = CCPCreateFileRequest(
        drive_id='1',
        name='test.txt',
        type='file',
        parent_file_id='root',
        content_type='text/plain',
    )
    model = CreateFileRequestModel(
        body=request
    )
    return client.create_file(model, runtime)


def complete_file(upload, file, info):
    request = CCPCompleteFileRequest(
        drive_id='1',
        upload_id=upload,
        file_id=file,
        part_info_list=[info]
    )
    model = CompleteFileRequestModel(
        body=request
    )
    return client.complete_file(model, runtime)


if __name__ == '__main__':
    resp = create_file()
    upload_url = resp.body.part_info_list[0].upload_url
    upload_id = resp.body.upload_id
    file_id = resp.body.file_id

    # upload file
    f = open('test.txt', 'rb')
    resp = requests.put(upload_url, data=f)
    upload_info = UploadPartInfo(
        etag=resp.headers.get('ETag'),
        part_number='1'
    )

    # complete file
    resp = complete_file(upload_id, file_id, upload_info)
    print(resp.body)
```