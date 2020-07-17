# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel


class RuntimeOptions(TeaModel):
    def __init__(self, autoretry=None, ignore_ssl=None, max_attempts=None, backoff_policy=None, backoff_period=None, read_timeout=None, connect_timeout=None, http_proxy=None, https_proxy=None, no_proxy=None, max_idle_conns=None, local_addr=None, socks_5proxy=None, socks_5net_work=None):
        self.autoretry = autoretry
        self.ignore_ssl = ignore_ssl
        self.max_attempts = max_attempts
        self.backoff_policy = backoff_policy
        self.backoff_period = backoff_period
        self.read_timeout = read_timeout
        self.connect_timeout = connect_timeout
        self.http_proxy = http_proxy
        self.https_proxy = https_proxy
        self.no_proxy = no_proxy
        self.max_idle_conns = max_idle_conns
        self.local_addr = local_addr
        self.socks_5proxy = socks_5proxy
        self.socks_5net_work = socks_5net_work

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['autoretry'] = self.autoretry
        result['ignoreSSL'] = self.ignore_ssl
        result['maxAttempts'] = self.max_attempts
        result['backoffPolicy'] = self.backoff_policy
        result['backoffPeriod'] = self.backoff_period
        result['readTimeout'] = self.read_timeout
        result['connectTimeout'] = self.connect_timeout
        result['httpProxy'] = self.http_proxy
        result['httpsProxy'] = self.https_proxy
        result['noProxy'] = self.no_proxy
        result['maxIdleConns'] = self.max_idle_conns
        result['localAddr'] = self.local_addr
        result['socks5Proxy'] = self.socks_5proxy
        result['socks5NetWork'] = self.socks_5net_work
        return result

    def from_map(self, map={}):
        self.autoretry = map.get('autoretry')
        self.ignore_ssl = map.get('ignoreSSL')
        self.max_attempts = map.get('maxAttempts')
        self.backoff_policy = map.get('backoffPolicy')
        self.backoff_period = map.get('backoffPeriod')
        self.read_timeout = map.get('readTimeout')
        self.connect_timeout = map.get('connectTimeout')
        self.http_proxy = map.get('httpProxy')
        self.https_proxy = map.get('httpsProxy')
        self.no_proxy = map.get('noProxy')
        self.max_idle_conns = map.get('maxIdleConns')
        self.local_addr = map.get('localAddr')
        self.socks_5proxy = map.get('socks5Proxy')
        self.socks_5net_work = map.get('socks5NetWork')
        return self


class Config(TeaModel):
    def __init__(self, endpoint=None, domain_id=None, client_id=None, refresh_token=None, client_secret=None, access_token=None, expire_time=None, protocol=None, type=None, security_token=None, access_key_id=None, access_key_secret=None, nickname=None, user_agent=None):
        self.endpoint = endpoint
        self.domain_id = domain_id
        self.client_id = client_id
        self.refresh_token = refresh_token
        self.client_secret = client_secret
        self.access_token = access_token
        self.expire_time = expire_time
        self.protocol = protocol
        self.type = type
        self.security_token = security_token
        self.access_key_id = access_key_id
        self.access_key_secret = access_key_secret
        self.nickname = nickname
        self.user_agent = user_agent

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['endpoint'] = self.endpoint
        result['domainId'] = self.domain_id
        result['clientId'] = self.client_id
        result['refreshToken'] = self.refresh_token
        result['clientSecret'] = self.client_secret
        result['accessToken'] = self.access_token
        result['expireTime'] = self.expire_time
        result['protocol'] = self.protocol
        result['type'] = self.type
        result['securityToken'] = self.security_token
        result['accessKeyId'] = self.access_key_id
        result['accessKeySecret'] = self.access_key_secret
        result['nickname'] = self.nickname
        result['userAgent'] = self.user_agent
        return result

    def from_map(self, map={}):
        self.endpoint = map.get('endpoint')
        self.domain_id = map.get('domainId')
        self.client_id = map.get('clientId')
        self.refresh_token = map.get('refreshToken')
        self.client_secret = map.get('clientSecret')
        self.access_token = map.get('accessToken')
        self.expire_time = map.get('expireTime')
        self.protocol = map.get('protocol')
        self.type = map.get('type')
        self.security_token = map.get('securityToken')
        self.access_key_id = map.get('accessKeyId')
        self.access_key_secret = map.get('accessKeySecret')
        self.nickname = map.get('nickname')
        self.user_agent = map.get('userAgent')
        return self


class CancelLinkRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CancelLinkRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CancelLinkModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountAccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ConfirmLinkRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ConfirmLinkRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ConfirmLinkModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountAccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ChangePasswordRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = DefaultChangePasswordRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ChangePasswordModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountAccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class SetPasswordRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = DefaultSetPasswordRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class SetPasswordModel(TeaModel):
    def __init__(self, headers=None):
        self.headers = {}

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        return self


class VerifyCodeRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = VerifyCodeRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class VerifyCodeModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = VerifyCodeResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetAccessTokenByLinkInfoRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetAccessTokenByLinkInfoRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetAccessTokenByLinkInfoModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountAccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetCaptchaRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetCaptchaRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetCaptchaModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = Captcha()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetLinkInfoRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetByLinkInfoRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetLinkInfoModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = LinkInfoResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetLinkInfoByUserIdRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetLinkInfoByUserIDRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetLinkInfoByUserIdModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = LinkInfoListResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetPublicKeyRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetAppPublicKeyRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetPublicKeyModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetAppPublicKeyResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class LinkRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountLinkRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class LinkModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountAccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CheckExistRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = MobileCheckExistRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CheckExistModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = MobileCheckExistResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class LoginRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = MobileLoginRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class LoginModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountAccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class RegisterRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = MobileRegisterRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class RegisterModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountAccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class MobileSendSmsCodeRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = MobileSendSmsCodeRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class MobileSendSmsCodeModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = MobileSendSmsCodeResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class AccountRevokeRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = RevokeRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class AccountRevokeModel(TeaModel):
    def __init__(self, headers=None):
        self.headers = {}

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        return self


class AccountTokenRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = TokenRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class AccountTokenModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccountAccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class AccessTokenResponse(TeaModel):
    """
    *
    """
    def __init__(self, access_token=None, default_drive_id=None, expire_time=None, expires_in=None, refresh_token=None, role=None, token_type=None, user_id=None):
        self.access_token = access_token
        self.default_drive_id = default_drive_id
        self.expire_time = expire_time
        self.expires_in = expires_in
        self.refresh_token = refresh_token
        self.role = role
        self.token_type = token_type
        self.user_id = user_id

    def validate(self):
        self.validate_required(self.access_token, 'access_token')
        self.validate_required(self.default_drive_id, 'default_drive_id')
        self.validate_required(self.expire_time, 'expire_time')
        self.validate_required(self.expires_in, 'expires_in')
        self.validate_required(self.refresh_token, 'refresh_token')
        self.validate_required(self.role, 'role')
        self.validate_required(self.token_type, 'token_type')
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['access_token'] = self.access_token
        result['default_drive_id'] = self.default_drive_id
        result['expire_time'] = self.expire_time
        result['expires_in'] = self.expires_in
        result['refresh_token'] = self.refresh_token
        result['role'] = self.role
        result['token_type'] = self.token_type
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.access_token = map.get('access_token')
        self.default_drive_id = map.get('default_drive_id')
        self.expire_time = map.get('expire_time')
        self.expires_in = map.get('expires_in')
        self.refresh_token = map.get('refresh_token')
        self.role = map.get('role')
        self.token_type = map.get('token_type')
        self.user_id = map.get('user_id')
        return self


class AccountAccessTokenResponse(TeaModel):
    """
    *
    """
    def __init__(self, access_token=None, avatar=None, data_pin_saved=None, data_pin_setup=None, default_drive_id=None, exist_link=None, expire_time=None, expires_in=None, is_first_login=None, need_link=None, nick_name=None, refresh_token=None, role=None, state=None, token_type=None, user_data=None, user_id=None, user_name=None):
        self.access_token = access_token
        self.avatar = avatar
        self.data_pin_saved = data_pin_saved
        self.data_pin_setup = data_pin_setup
        self.default_drive_id = default_drive_id
        self.exist_link = []
        self.expire_time = expire_time
        self.expires_in = expires_in
        self.is_first_login = is_first_login
        self.need_link = need_link
        self.nick_name = nick_name
        self.refresh_token = refresh_token
        self.role = role
        self.state = state
        self.token_type = token_type
        self.user_data = user_data
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        self.validate_required(self.access_token, 'access_token')
        if self.exist_link:
            for k in self.exist_link:
                if k :
                    k.validate()
        self.validate_required(self.need_link, 'need_link')

    def to_map(self):
        result = {}
        result['access_token'] = self.access_token
        result['avatar'] = self.avatar
        result['data_pin_saved'] = self.data_pin_saved
        result['data_pin_setup'] = self.data_pin_setup
        result['default_drive_id'] = self.default_drive_id
        result['exist_link'] = []
        if self.exist_link is not None:
            for k in self.exist_link:
                result['exist_link'].append(k.to_map() if k else None)
        else:
            result['exist_link'] = None
        result['expire_time'] = self.expire_time
        result['expires_in'] = self.expires_in
        result['is_first_login'] = self.is_first_login
        result['need_link'] = self.need_link
        result['nick_name'] = self.nick_name
        result['refresh_token'] = self.refresh_token
        result['role'] = self.role
        result['state'] = self.state
        result['token_type'] = self.token_type
        result['user_data'] = self.user_data
        result['user_id'] = self.user_id
        result['user_name'] = self.user_name
        return result

    def from_map(self, map={}):
        self.access_token = map.get('access_token')
        self.avatar = map.get('avatar')
        self.data_pin_saved = map.get('data_pin_saved')
        self.data_pin_setup = map.get('data_pin_setup')
        self.default_drive_id = map.get('default_drive_id')
        self.exist_link = []
        if map.get('exist_link') is not None:
            for k in map.get('exist_link'):
                temp_model = LinkInfo()
                temp_model = temp_model.from_map(k)
                self.exist_link.append(temp_model)
        else:
            self.exist_link = None
        self.expire_time = map.get('expire_time')
        self.expires_in = map.get('expires_in')
        self.is_first_login = map.get('is_first_login')
        self.need_link = map.get('need_link')
        self.nick_name = map.get('nick_name')
        self.refresh_token = map.get('refresh_token')
        self.role = map.get('role')
        self.state = map.get('state')
        self.token_type = map.get('token_type')
        self.user_data = map.get('user_data')
        self.user_id = map.get('user_id')
        self.user_name = map.get('user_name')
        return self


class AccountLinkRequest(TeaModel):
    """
    *
    """
    def __init__(self, detail=None, extra=None, identity=None, status=None, type=None, user_id=None):
        self.detail = detail
        self.extra = extra
        self.identity = identity
        self.status = status
        self.type = type
        self.user_id = user_id

    def validate(self):
        self.validate_required(self.identity, 'identity')
        self.validate_required(self.type, 'type')
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['detail'] = self.detail
        result['extra'] = self.extra
        result['identity'] = self.identity
        result['status'] = self.status
        result['type'] = self.type
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.detail = map.get('detail')
        self.extra = map.get('extra')
        self.identity = map.get('identity')
        self.status = map.get('status')
        self.type = map.get('type')
        self.user_id = map.get('user_id')
        return self


class AuthorizeRequest(TeaModel):
    """
    *
    """
    def __init__(self, client_id=None, login_type=None, redirect_uri=None, response_type=None, scope=None, state=None):
        self.client_id = client_id
        self.login_type = login_type
        self.redirect_uri = redirect_uri
        self.response_type = response_type
        self.scope = []
        self.state = state

    def validate(self):
        self.validate_required(self.client_id, 'client_id')
        self.validate_required(self.redirect_uri, 'redirect_uri')
        self.validate_required(self.response_type, 'response_type')

    def to_map(self):
        result = {}
        result['ClientID'] = self.client_id
        result['LoginType'] = self.login_type
        result['RedirectUri'] = self.redirect_uri
        result['ResponseType'] = self.response_type
        result['Scope'] = []
        if self.scope is not None:
            for k in self.scope:
                result['Scope'].append(k)
        else:
            result['Scope'] = None
        result['State'] = self.state
        return result

    def from_map(self, map={}):
        self.client_id = map.get('ClientID')
        self.login_type = map.get('LoginType')
        self.redirect_uri = map.get('RedirectUri')
        self.response_type = map.get('ResponseType')
        self.scope = []
        if map.get('Scope') is not None:
            for k in map.get('Scope'):
                self.scope.append(k)
        else:
            self.scope = None
        self.state = map.get('State')
        return self


class BaseCCPFileResponse(TeaModel):
    """
    Base file response
    """
    def __init__(self, category=None, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, encrypt_mode=None, file_extension=None, file_id=None, hidden=None, image_media_metadata=None, labels=None, meta=None, name=None, parent_file_id=None, size=None, starred=None, status=None, streams_info=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None, user_meta=None, video_media_metadata=None, video_preview_metadata=None):
        self.category = category
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.encrypt_mode = encrypt_mode
        self.file_extension = file_extension
        self.file_id = file_id
        self.hidden = hidden
        self.image_media_metadata = image_media_metadata
        self.labels = []
        self.meta = meta
        self.name = name
        self.parent_file_id = parent_file_id
        self.size = size
        self.starred = starred
        self.status = status
        self.streams_info = streams_info
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url
        self.user_meta = user_meta
        self.video_media_metadata = video_media_metadata
        self.video_preview_metadata = video_preview_metadata

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.image_media_metadata:
            self.image_media_metadata.validate()
        self.validate_required(self.name, 'name')
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')
        if self.video_media_metadata:
            self.video_media_metadata.validate()
        if self.video_preview_metadata:
            self.video_preview_metadata.validate()

    def to_map(self):
        result = {}
        result['category'] = self.category
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['encrypt_mode'] = self.encrypt_mode
        result['file_extension'] = self.file_extension
        result['file_id'] = self.file_id
        result['hidden'] = self.hidden
        if self.image_media_metadata is not None:
            result['image_media_metadata'] = self.image_media_metadata.to_map()
        else:
            result['image_media_metadata'] = None
        result['labels'] = []
        if self.labels is not None:
            for k in self.labels:
                result['labels'].append(k)
        else:
            result['labels'] = None
        result['meta'] = self.meta
        result['name'] = self.name
        result['parent_file_id'] = self.parent_file_id
        result['size'] = self.size
        result['starred'] = self.starred
        result['status'] = self.status
        result['streams_info'] = self.streams_info
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        result['user_meta'] = self.user_meta
        if self.video_media_metadata is not None:
            result['video_media_metadata'] = self.video_media_metadata.to_map()
        else:
            result['video_media_metadata'] = None
        if self.video_preview_metadata is not None:
            result['video_preview_metadata'] = self.video_preview_metadata.to_map()
        else:
            result['video_preview_metadata'] = None
        return result

    def from_map(self, map={}):
        self.category = map.get('category')
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.encrypt_mode = map.get('encrypt_mode')
        self.file_extension = map.get('file_extension')
        self.file_id = map.get('file_id')
        self.hidden = map.get('hidden')
        if map.get('image_media_metadata') is not None:
            temp_model = ImageMediaResponse()
            self.image_media_metadata = temp_model.from_map(map['image_media_metadata'])
        else:
            self.image_media_metadata = None
        self.labels = []
        if map.get('labels') is not None:
            for k in map.get('labels'):
                self.labels.append(k)
        else:
            self.labels = None
        self.meta = map.get('meta')
        self.name = map.get('name')
        self.parent_file_id = map.get('parent_file_id')
        self.size = map.get('size')
        self.starred = map.get('starred')
        self.status = map.get('status')
        self.streams_info = map.get('streams_info')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        self.user_meta = map.get('user_meta')
        if map.get('video_media_metadata') is not None:
            temp_model = VideoMediaResponse()
            self.video_media_metadata = temp_model.from_map(map['video_media_metadata'])
        else:
            self.video_media_metadata = None
        if map.get('video_preview_metadata') is not None:
            temp_model = VideoPreviewResponse()
            self.video_preview_metadata = temp_model.from_map(map['video_preview_metadata'])
        else:
            self.video_preview_metadata = None
        return self


class BaseDriveResponse(TeaModel):
    """
    Base drive response
    """
    def __init__(self, creator=None, description=None, domain_id=None, drive_id=None, drive_name=None, drive_type=None, encrypt_data_access=None, encrypt_mode=None, owner=None, relative_path=None, status=None, store_id=None, total_size=None, used_size=None):
        self.creator = creator
        self.description = description
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.drive_name = drive_name
        self.drive_type = drive_type
        self.encrypt_data_access = encrypt_data_access
        self.encrypt_mode = encrypt_mode
        self.owner = owner
        self.relative_path = relative_path
        self.status = status
        self.store_id = store_id
        self.total_size = total_size
        self.used_size = used_size

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['creator'] = self.creator
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['drive_name'] = self.drive_name
        result['drive_type'] = self.drive_type
        result['encrypt_data_access'] = self.encrypt_data_access
        result['encrypt_mode'] = self.encrypt_mode
        result['owner'] = self.owner
        result['relative_path'] = self.relative_path
        result['status'] = self.status
        result['store_id'] = self.store_id
        result['total_size'] = self.total_size
        result['used_size'] = self.used_size
        return result

    def from_map(self, map={}):
        self.creator = map.get('creator')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.drive_name = map.get('drive_name')
        self.drive_type = map.get('drive_type')
        self.encrypt_data_access = map.get('encrypt_data_access')
        self.encrypt_mode = map.get('encrypt_mode')
        self.owner = map.get('owner')
        self.relative_path = map.get('relative_path')
        self.status = map.get('status')
        self.store_id = map.get('store_id')
        self.total_size = map.get('total_size')
        self.used_size = map.get('used_size')
        return self


class BaseOSSFileResponse(TeaModel):
    """
    Base file response
    """
    def __init__(self, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, file_extension=None, file_path=None, name=None, parent_file_path=None, share_id=None, size=None, status=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None):
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.file_extension = file_extension
        self.file_path = file_path
        self.name = name
        self.parent_file_path = parent_file_path
        self.share_id = share_id
        self.size = size
        self.status = status
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.name, 'name')
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_path:
            self.validate_pattern(self.parent_file_path, 'parent_file_path', '[a-z0-9]{1,50}')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['file_extension'] = self.file_extension
        result['file_path'] = self.file_path
        result['name'] = self.name
        result['parent_file_path'] = self.parent_file_path
        result['share_id'] = self.share_id
        result['size'] = self.size
        result['status'] = self.status
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.file_extension = map.get('file_extension')
        self.file_path = map.get('file_path')
        self.name = map.get('name')
        self.parent_file_path = map.get('parent_file_path')
        self.share_id = map.get('share_id')
        self.size = map.get('size')
        self.status = map.get('status')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        return self


class BaseShareResponse(TeaModel):
    """
    List share response
    """
    def __init__(self, created_at=None, creator=None, description=None, domain_id=None, drive_id=None, expiration=None, expired=None, owner=None, permissions=None, share_file_path=None, share_id=None, share_name=None, share_policy=None, status=None, updated_at=None):
        self.created_at = created_at
        self.creator = creator
        self.description = description
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.expiration = expiration
        self.expired = expired
        self.owner = owner
        self.permissions = []
        self.share_file_path = share_file_path
        self.share_id = share_id
        self.share_name = share_name
        self.share_policy = []
        self.status = status
        self.updated_at = updated_at

    def validate(self):
        if self.share_policy:
            for k in self.share_policy:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['created_at'] = self.created_at
        result['creator'] = self.creator
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['expiration'] = self.expiration
        result['expired'] = self.expired
        result['owner'] = self.owner
        result['permissions'] = []
        if self.permissions is not None:
            for k in self.permissions:
                result['permissions'].append(k)
        else:
            result['permissions'] = None
        result['share_file_path'] = self.share_file_path
        result['share_id'] = self.share_id
        result['share_name'] = self.share_name
        result['share_policy'] = []
        if self.share_policy is not None:
            for k in self.share_policy:
                result['share_policy'].append(k.to_map() if k else None)
        else:
            result['share_policy'] = None
        result['status'] = self.status
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.created_at = map.get('created_at')
        self.creator = map.get('creator')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.expiration = map.get('expiration')
        self.expired = map.get('expired')
        self.owner = map.get('owner')
        self.permissions = []
        if map.get('permissions') is not None:
            for k in map.get('permissions'):
                self.permissions.append(k)
        else:
            self.permissions = None
        self.share_file_path = map.get('share_file_path')
        self.share_id = map.get('share_id')
        self.share_name = map.get('share_name')
        self.share_policy = []
        if map.get('share_policy') is not None:
            for k in map.get('share_policy'):
                temp_model = SharePermissionPolicy()
                temp_model = temp_model.from_map(k)
                self.share_policy.append(temp_model)
        else:
            self.share_policy = None
        self.status = map.get('status')
        self.updated_at = map.get('updated_at')
        return self


class BatchSubResponse(TeaModel):
    """
    *
    """
    def __init__(self, body=None, id=None, status=None):
        self.body = body
        self.id = id
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['body'] = self.body
        result['id'] = self.id
        result['status'] = self.status
        return result

    def from_map(self, map={}):
        self.body = map.get('body')
        self.id = map.get('id')
        self.status = map.get('status')
        return self


class CCPBatchResponse(TeaModel):
    """
    batch operation response
    """
    def __init__(self, responses=None):
        self.responses = []

    def validate(self):
        if self.responses:
            for k in self.responses:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['responses'] = []
        if self.responses is not None:
            for k in self.responses:
                result['responses'].append(k.to_map() if k else None)
        else:
            result['responses'] = None
        return result

    def from_map(self, map={}):
        self.responses = []
        if map.get('responses') is not None:
            for k in map.get('responses'):
                temp_model = BatchSubResponse()
                temp_model = temp_model.from_map(k)
                self.responses.append(temp_model)
        else:
            self.responses = None
        return self


class CCPCompleteFileResponse(TeaModel):
    """
    complete file response
    """
    def __init__(self, category=None, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, encrypt_mode=None, file_extension=None, file_id=None, hidden=None, image_media_metadata=None, labels=None, meta=None, name=None, parent_file_id=None, size=None, starred=None, status=None, streams_info=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None, user_meta=None, video_media_metadata=None, video_preview_metadata=None):
        self.category = category
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.encrypt_mode = encrypt_mode
        self.file_extension = file_extension
        self.file_id = file_id
        self.hidden = hidden
        self.image_media_metadata = image_media_metadata
        self.labels = []
        self.meta = meta
        self.name = name
        self.parent_file_id = parent_file_id
        self.size = size
        self.starred = starred
        self.status = status
        self.streams_info = streams_info
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url
        self.user_meta = user_meta
        self.video_media_metadata = video_media_metadata
        self.video_preview_metadata = video_preview_metadata

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.image_media_metadata:
            self.image_media_metadata.validate()
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')
        if self.video_media_metadata:
            self.video_media_metadata.validate()
        if self.video_preview_metadata:
            self.video_preview_metadata.validate()

    def to_map(self):
        result = {}
        result['category'] = self.category
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['encrypt_mode'] = self.encrypt_mode
        result['file_extension'] = self.file_extension
        result['file_id'] = self.file_id
        result['hidden'] = self.hidden
        if self.image_media_metadata is not None:
            result['image_media_metadata'] = self.image_media_metadata.to_map()
        else:
            result['image_media_metadata'] = None
        result['labels'] = []
        if self.labels is not None:
            for k in self.labels:
                result['labels'].append(k)
        else:
            result['labels'] = None
        result['meta'] = self.meta
        result['name'] = self.name
        result['parent_file_id'] = self.parent_file_id
        result['size'] = self.size
        result['starred'] = self.starred
        result['status'] = self.status
        result['streams_info'] = self.streams_info
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        result['user_meta'] = self.user_meta
        if self.video_media_metadata is not None:
            result['video_media_metadata'] = self.video_media_metadata.to_map()
        else:
            result['video_media_metadata'] = None
        if self.video_preview_metadata is not None:
            result['video_preview_metadata'] = self.video_preview_metadata.to_map()
        else:
            result['video_preview_metadata'] = None
        return result

    def from_map(self, map={}):
        self.category = map.get('category')
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.encrypt_mode = map.get('encrypt_mode')
        self.file_extension = map.get('file_extension')
        self.file_id = map.get('file_id')
        self.hidden = map.get('hidden')
        if map.get('image_media_metadata') is not None:
            temp_model = ImageMediaResponse()
            self.image_media_metadata = temp_model.from_map(map['image_media_metadata'])
        else:
            self.image_media_metadata = None
        self.labels = []
        if map.get('labels') is not None:
            for k in map.get('labels'):
                self.labels.append(k)
        else:
            self.labels = None
        self.meta = map.get('meta')
        self.name = map.get('name')
        self.parent_file_id = map.get('parent_file_id')
        self.size = map.get('size')
        self.starred = map.get('starred')
        self.status = map.get('status')
        self.streams_info = map.get('streams_info')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        self.user_meta = map.get('user_meta')
        if map.get('video_media_metadata') is not None:
            temp_model = VideoMediaResponse()
            self.video_media_metadata = temp_model.from_map(map['video_media_metadata'])
        else:
            self.video_media_metadata = None
        if map.get('video_preview_metadata') is not None:
            temp_model = VideoPreviewResponse()
            self.video_preview_metadata = temp_model.from_map(map['video_preview_metadata'])
        else:
            self.video_preview_metadata = None
        return self


class CCPCopyFileResponse(TeaModel):
    """
    文件拷贝 response
    """
    def __init__(self, async_task_id=None, domain_id=None, drive_id=None, file_id=None):
        self.async_task_id = async_task_id
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_id = file_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        return self


class CCPCreateFileResponse(TeaModel):
    """
    Create file response
    """
    def __init__(self, domain_id=None, drive_id=None, encrypt_mode=None, exist=None, file_id=None, file_name=None, parent_file_id=None, part_info_list=None, rapid_upload=None, status=None, streams_upload_info=None, type=None, upload_id=None):
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.encrypt_mode = encrypt_mode
        self.exist = exist
        self.file_id = file_id
        self.file_name = file_name
        self.parent_file_id = parent_file_id
        self.part_info_list = []
        self.rapid_upload = rapid_upload
        self.status = status
        self.streams_upload_info = streams_upload_info
        self.type = type
        self.upload_id = upload_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9]{1,50}')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.file_name:
            self.validate_max_length(self.file_name, 'file_name', 255)
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['encrypt_mode'] = self.encrypt_mode
        result['exist'] = self.exist
        result['file_id'] = self.file_id
        result['file_name'] = self.file_name
        result['parent_file_id'] = self.parent_file_id
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['rapid_upload'] = self.rapid_upload
        result['status'] = self.status
        result['streams_upload_info'] = self.streams_upload_info
        result['type'] = self.type
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.encrypt_mode = map.get('encrypt_mode')
        self.exist = map.get('exist')
        self.file_id = map.get('file_id')
        self.file_name = map.get('file_name')
        self.parent_file_id = map.get('parent_file_id')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.rapid_upload = map.get('rapid_upload')
        self.status = map.get('status')
        self.streams_upload_info = map.get('streams_upload_info')
        self.type = map.get('type')
        self.upload_id = map.get('upload_id')
        return self


class CCPDeleteFileResponse(TeaModel):
    """
    删除文件 response
    """
    def __init__(self, async_task_id=None, domain_id=None, drive_id=None, file_id=None):
        self.async_task_id = async_task_id
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_id = file_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        return self


class CCPDeleteFilesResponse(TeaModel):
    """
    批量删除文件 response
    """
    def __init__(self, deleted_file_id_list=None, domain_id=None, drive_id=None):
        self.deleted_file_id_list = []
        self.domain_id = domain_id
        self.drive_id = drive_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['deleted_file_id_list'] = []
        if self.deleted_file_id_list is not None:
            for k in self.deleted_file_id_list:
                result['deleted_file_id_list'].append(k)
        else:
            result['deleted_file_id_list'] = None
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        return result

    def from_map(self, map={}):
        self.deleted_file_id_list = []
        if map.get('deleted_file_id_list') is not None:
            for k in map.get('deleted_file_id_list'):
                self.deleted_file_id_list.append(k)
        else:
            self.deleted_file_id_list = None
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        return self


class CCPGetAsyncTaskResponse(TeaModel):
    """
    Get AsyncTask Response
    """
    def __init__(self, async_task_id=None, message=None, state=None):
        self.async_task_id = async_task_id
        self.message = message
        self.state = state

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        result['message'] = self.message
        result['state'] = self.state
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        self.message = map.get('message')
        self.state = map.get('state')
        return self


class CCPGetDownloadUrlResponse(TeaModel):
    """
    获取download url response
    """
    def __init__(self, expiration=None, method=None, size=None, streams_url=None, url=None):
        self.expiration = expiration
        self.method = method
        self.size = size
        self.streams_url = streams_url
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['expiration'] = self.expiration
        result['method'] = self.method
        result['size'] = self.size
        result['streams_url'] = self.streams_url
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.expiration = map.get('expiration')
        self.method = map.get('method')
        self.size = map.get('size')
        self.streams_url = map.get('streams_url')
        self.url = map.get('url')
        return self


class CCPGetFileByPathResponse(TeaModel):
    """
    根据路径获取文件元数据response
    """
    def __init__(self, category=None, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, encrypt_mode=None, file_extension=None, file_id=None, hidden=None, image_media_metadata=None, labels=None, meta=None, name=None, parent_file_id=None, size=None, starred=None, status=None, streams_info=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None, user_meta=None, video_media_metadata=None, video_preview_metadata=None):
        self.category = category
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.encrypt_mode = encrypt_mode
        self.file_extension = file_extension
        self.file_id = file_id
        self.hidden = hidden
        self.image_media_metadata = image_media_metadata
        self.labels = []
        self.meta = meta
        self.name = name
        self.parent_file_id = parent_file_id
        self.size = size
        self.starred = starred
        self.status = status
        self.streams_info = streams_info
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url
        self.user_meta = user_meta
        self.video_media_metadata = video_media_metadata
        self.video_preview_metadata = video_preview_metadata

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.image_media_metadata:
            self.image_media_metadata.validate()
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')
        if self.video_media_metadata:
            self.video_media_metadata.validate()
        if self.video_preview_metadata:
            self.video_preview_metadata.validate()

    def to_map(self):
        result = {}
        result['category'] = self.category
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['encrypt_mode'] = self.encrypt_mode
        result['file_extension'] = self.file_extension
        result['file_id'] = self.file_id
        result['hidden'] = self.hidden
        if self.image_media_metadata is not None:
            result['image_media_metadata'] = self.image_media_metadata.to_map()
        else:
            result['image_media_metadata'] = None
        result['labels'] = []
        if self.labels is not None:
            for k in self.labels:
                result['labels'].append(k)
        else:
            result['labels'] = None
        result['meta'] = self.meta
        result['name'] = self.name
        result['parent_file_id'] = self.parent_file_id
        result['size'] = self.size
        result['starred'] = self.starred
        result['status'] = self.status
        result['streams_info'] = self.streams_info
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        result['user_meta'] = self.user_meta
        if self.video_media_metadata is not None:
            result['video_media_metadata'] = self.video_media_metadata.to_map()
        else:
            result['video_media_metadata'] = None
        if self.video_preview_metadata is not None:
            result['video_preview_metadata'] = self.video_preview_metadata.to_map()
        else:
            result['video_preview_metadata'] = None
        return result

    def from_map(self, map={}):
        self.category = map.get('category')
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.encrypt_mode = map.get('encrypt_mode')
        self.file_extension = map.get('file_extension')
        self.file_id = map.get('file_id')
        self.hidden = map.get('hidden')
        if map.get('image_media_metadata') is not None:
            temp_model = ImageMediaResponse()
            self.image_media_metadata = temp_model.from_map(map['image_media_metadata'])
        else:
            self.image_media_metadata = None
        self.labels = []
        if map.get('labels') is not None:
            for k in map.get('labels'):
                self.labels.append(k)
        else:
            self.labels = None
        self.meta = map.get('meta')
        self.name = map.get('name')
        self.parent_file_id = map.get('parent_file_id')
        self.size = map.get('size')
        self.starred = map.get('starred')
        self.status = map.get('status')
        self.streams_info = map.get('streams_info')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        self.user_meta = map.get('user_meta')
        if map.get('video_media_metadata') is not None:
            temp_model = VideoMediaResponse()
            self.video_media_metadata = temp_model.from_map(map['video_media_metadata'])
        else:
            self.video_media_metadata = None
        if map.get('video_preview_metadata') is not None:
            temp_model = VideoPreviewResponse()
            self.video_preview_metadata = temp_model.from_map(map['video_preview_metadata'])
        else:
            self.video_preview_metadata = None
        return self


class CCPGetFileResponse(TeaModel):
    """
    获取文件元数据response
    """
    def __init__(self, category=None, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, encrypt_mode=None, file_extension=None, file_id=None, hidden=None, image_media_metadata=None, labels=None, meta=None, name=None, parent_file_id=None, size=None, starred=None, status=None, streams_info=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None, user_meta=None, video_media_metadata=None, video_preview_metadata=None):
        self.category = category
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.encrypt_mode = encrypt_mode
        self.file_extension = file_extension
        self.file_id = file_id
        self.hidden = hidden
        self.image_media_metadata = image_media_metadata
        self.labels = []
        self.meta = meta
        self.name = name
        self.parent_file_id = parent_file_id
        self.size = size
        self.starred = starred
        self.status = status
        self.streams_info = streams_info
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url
        self.user_meta = user_meta
        self.video_media_metadata = video_media_metadata
        self.video_preview_metadata = video_preview_metadata

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.image_media_metadata:
            self.image_media_metadata.validate()
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')
        if self.video_media_metadata:
            self.video_media_metadata.validate()
        if self.video_preview_metadata:
            self.video_preview_metadata.validate()

    def to_map(self):
        result = {}
        result['category'] = self.category
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['encrypt_mode'] = self.encrypt_mode
        result['file_extension'] = self.file_extension
        result['file_id'] = self.file_id
        result['hidden'] = self.hidden
        if self.image_media_metadata is not None:
            result['image_media_metadata'] = self.image_media_metadata.to_map()
        else:
            result['image_media_metadata'] = None
        result['labels'] = []
        if self.labels is not None:
            for k in self.labels:
                result['labels'].append(k)
        else:
            result['labels'] = None
        result['meta'] = self.meta
        result['name'] = self.name
        result['parent_file_id'] = self.parent_file_id
        result['size'] = self.size
        result['starred'] = self.starred
        result['status'] = self.status
        result['streams_info'] = self.streams_info
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        result['user_meta'] = self.user_meta
        if self.video_media_metadata is not None:
            result['video_media_metadata'] = self.video_media_metadata.to_map()
        else:
            result['video_media_metadata'] = None
        if self.video_preview_metadata is not None:
            result['video_preview_metadata'] = self.video_preview_metadata.to_map()
        else:
            result['video_preview_metadata'] = None
        return result

    def from_map(self, map={}):
        self.category = map.get('category')
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.encrypt_mode = map.get('encrypt_mode')
        self.file_extension = map.get('file_extension')
        self.file_id = map.get('file_id')
        self.hidden = map.get('hidden')
        if map.get('image_media_metadata') is not None:
            temp_model = ImageMediaResponse()
            self.image_media_metadata = temp_model.from_map(map['image_media_metadata'])
        else:
            self.image_media_metadata = None
        self.labels = []
        if map.get('labels') is not None:
            for k in map.get('labels'):
                self.labels.append(k)
        else:
            self.labels = None
        self.meta = map.get('meta')
        self.name = map.get('name')
        self.parent_file_id = map.get('parent_file_id')
        self.size = map.get('size')
        self.starred = map.get('starred')
        self.status = map.get('status')
        self.streams_info = map.get('streams_info')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        self.user_meta = map.get('user_meta')
        if map.get('video_media_metadata') is not None:
            temp_model = VideoMediaResponse()
            self.video_media_metadata = temp_model.from_map(map['video_media_metadata'])
        else:
            self.video_media_metadata = None
        if map.get('video_preview_metadata') is not None:
            temp_model = VideoPreviewResponse()
            self.video_preview_metadata = temp_model.from_map(map['video_preview_metadata'])
        else:
            self.video_preview_metadata = None
        return self


class CCPGetUploadUrlResponse(TeaModel):
    """
    Get UploadUrl Response
    """
    def __init__(self, create_at=None, domain_id=None, drive_id=None, file_id=None, part_info_list=None, upload_id=None):
        self.create_at = create_at
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_id = file_id
        self.part_info_list = []
        self.upload_id = upload_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['create_at'] = self.create_at
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.create_at = map.get('create_at')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.upload_id = map.get('upload_id')
        return self


class CCPGetVideoPreviewSpriteURLResponse(TeaModel):
    """
    获取视频雪碧图地址 url response
    """
    def __init__(self, col=None, count=None, frame_count=None, frame_height=None, frame_width=None, row=None, sprite_url_list=None):
        self.col = col
        self.count = count
        self.frame_count = frame_count
        self.frame_height = frame_height
        self.frame_width = frame_width
        self.row = row
        self.sprite_url_list = []

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['col'] = self.col
        result['count'] = self.count
        result['frame_count'] = self.frame_count
        result['frame_height'] = self.frame_height
        result['frame_width'] = self.frame_width
        result['row'] = self.row
        result['sprite_url_list'] = []
        if self.sprite_url_list is not None:
            for k in self.sprite_url_list:
                result['sprite_url_list'].append(k)
        else:
            result['sprite_url_list'] = None
        return result

    def from_map(self, map={}):
        self.col = map.get('col')
        self.count = map.get('count')
        self.frame_count = map.get('frame_count')
        self.frame_height = map.get('frame_height')
        self.frame_width = map.get('frame_width')
        self.row = map.get('row')
        self.sprite_url_list = []
        if map.get('sprite_url_list') is not None:
            for k in map.get('sprite_url_list'):
                self.sprite_url_list.append(k)
        else:
            self.sprite_url_list = None
        return self


class CCPGetVideoPreviewURLResponse(TeaModel):
    """
    获取视频文件播放 url response
    """
    def __init__(self, preview_url=None):
        self.preview_url = preview_url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['preview_url'] = self.preview_url
        return result

    def from_map(self, map={}):
        self.preview_url = map.get('preview_url')
        return self


class CCPListFileResponse(TeaModel):
    """
    List file response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseCCPFileResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class CCPListUploadedPartResponse(TeaModel):
    """
    获取签名 response
    """
    def __init__(self, file_id=None, next_part_number_marker=None, upload_id=None, uploaded_parts=None):
        self.file_id = file_id
        self.next_part_number_marker = next_part_number_marker
        self.upload_id = upload_id
        self.uploaded_parts = []

    def validate(self):
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.uploaded_parts:
            for k in self.uploaded_parts:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['file_id'] = self.file_id
        result['next_part_number_marker'] = self.next_part_number_marker
        result['upload_id'] = self.upload_id
        result['uploaded_parts'] = []
        if self.uploaded_parts is not None:
            for k in self.uploaded_parts:
                result['uploaded_parts'].append(k.to_map() if k else None)
        else:
            result['uploaded_parts'] = None
        return result

    def from_map(self, map={}):
        self.file_id = map.get('file_id')
        self.next_part_number_marker = map.get('next_part_number_marker')
        self.upload_id = map.get('upload_id')
        self.uploaded_parts = []
        if map.get('uploaded_parts') is not None:
            for k in map.get('uploaded_parts'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.uploaded_parts.append(temp_model)
        else:
            self.uploaded_parts = None
        return self


class CCPMoveFileResponse(TeaModel):
    """
    文件移动 response
    """
    def __init__(self, async_task_id=None, domain_id=None, drive_id=None, file_id=None):
        self.async_task_id = async_task_id
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_id = file_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        return self


class CCPScanFileMetaResponse(TeaModel):
    """
    scan file meta response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseCCPFileResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class CCPSearchFileResponse(TeaModel):
    """
    search file response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseCCPFileResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class CCPUpdateFileMetaResponse(TeaModel):
    """
    更新文件元数据 response
    """
    def __init__(self, category=None, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, encrypt_mode=None, file_extension=None, file_id=None, hidden=None, image_media_metadata=None, labels=None, meta=None, name=None, parent_file_id=None, size=None, starred=None, status=None, streams_info=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None, user_meta=None, video_media_metadata=None, video_preview_metadata=None):
        self.category = category
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.encrypt_mode = encrypt_mode
        self.file_extension = file_extension
        self.file_id = file_id
        self.hidden = hidden
        self.image_media_metadata = image_media_metadata
        self.labels = []
        self.meta = meta
        self.name = name
        self.parent_file_id = parent_file_id
        self.size = size
        self.starred = starred
        self.status = status
        self.streams_info = streams_info
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url
        self.user_meta = user_meta
        self.video_media_metadata = video_media_metadata
        self.video_preview_metadata = video_preview_metadata

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.image_media_metadata:
            self.image_media_metadata.validate()
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')
        if self.video_media_metadata:
            self.video_media_metadata.validate()
        if self.video_preview_metadata:
            self.video_preview_metadata.validate()

    def to_map(self):
        result = {}
        result['category'] = self.category
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['encrypt_mode'] = self.encrypt_mode
        result['file_extension'] = self.file_extension
        result['file_id'] = self.file_id
        result['hidden'] = self.hidden
        if self.image_media_metadata is not None:
            result['image_media_metadata'] = self.image_media_metadata.to_map()
        else:
            result['image_media_metadata'] = None
        result['labels'] = []
        if self.labels is not None:
            for k in self.labels:
                result['labels'].append(k)
        else:
            result['labels'] = None
        result['meta'] = self.meta
        result['name'] = self.name
        result['parent_file_id'] = self.parent_file_id
        result['size'] = self.size
        result['starred'] = self.starred
        result['status'] = self.status
        result['streams_info'] = self.streams_info
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        result['user_meta'] = self.user_meta
        if self.video_media_metadata is not None:
            result['video_media_metadata'] = self.video_media_metadata.to_map()
        else:
            result['video_media_metadata'] = None
        if self.video_preview_metadata is not None:
            result['video_preview_metadata'] = self.video_preview_metadata.to_map()
        else:
            result['video_preview_metadata'] = None
        return result

    def from_map(self, map={}):
        self.category = map.get('category')
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.encrypt_mode = map.get('encrypt_mode')
        self.file_extension = map.get('file_extension')
        self.file_id = map.get('file_id')
        self.hidden = map.get('hidden')
        if map.get('image_media_metadata') is not None:
            temp_model = ImageMediaResponse()
            self.image_media_metadata = temp_model.from_map(map['image_media_metadata'])
        else:
            self.image_media_metadata = None
        self.labels = []
        if map.get('labels') is not None:
            for k in map.get('labels'):
                self.labels.append(k)
        else:
            self.labels = None
        self.meta = map.get('meta')
        self.name = map.get('name')
        self.parent_file_id = map.get('parent_file_id')
        self.size = map.get('size')
        self.starred = map.get('starred')
        self.status = map.get('status')
        self.streams_info = map.get('streams_info')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        self.user_meta = map.get('user_meta')
        if map.get('video_media_metadata') is not None:
            temp_model = VideoMediaResponse()
            self.video_media_metadata = temp_model.from_map(map['video_media_metadata'])
        else:
            self.video_media_metadata = None
        if map.get('video_preview_metadata') is not None:
            temp_model = VideoPreviewResponse()
            self.video_preview_metadata = temp_model.from_map(map['video_preview_metadata'])
        else:
            self.video_preview_metadata = None
        return self


class CancelLinkRequest(TeaModel):
    """
    *
    """
    def __init__(self, temporary_token=None):
        self.temporary_token = temporary_token

    def validate(self):
        self.validate_required(self.temporary_token, 'temporary_token')

    def to_map(self):
        result = {}
        result['temporary_token'] = self.temporary_token
        return result

    def from_map(self, map={}):
        self.temporary_token = map.get('temporary_token')
        return self


class Captcha(TeaModel):
    """
    *
    """
    def __init__(self, captcha=None, captcha_format=None, captcha_id=None):
        self.captcha = captcha
        self.captcha_format = captcha_format
        self.captcha_id = captcha_id

    def validate(self):
        self.validate_required(self.captcha, 'captcha')
        self.validate_required(self.captcha_format, 'captcha_format')
        self.validate_required(self.captcha_id, 'captcha_id')

    def to_map(self):
        result = {}
        result['captcha'] = self.captcha
        result['captcha_format'] = self.captcha_format
        result['captcha_id'] = self.captcha_id
        return result

    def from_map(self, map={}):
        self.captcha = map.get('captcha')
        self.captcha_format = map.get('captcha_format')
        self.captcha_id = map.get('captcha_id')
        return self


class ConfirmLinkRequest(TeaModel):
    """
    *
    """
    def __init__(self, temporary_token=None):
        self.temporary_token = temporary_token

    def validate(self):
        self.validate_required(self.temporary_token, 'temporary_token')

    def to_map(self):
        result = {}
        result['temporary_token'] = self.temporary_token
        return result

    def from_map(self, map={}):
        self.temporary_token = map.get('temporary_token')
        return self


class CorsRule(TeaModel):
    """
    *
    """
    def __init__(self, allowed_header=None, allowed_method=None, allowed_origin=None, expose_header=None, max_age_seconds=None):
        self.allowed_header = []
        self.allowed_method = []
        self.allowed_origin = []
        self.expose_header = []
        self.max_age_seconds = max_age_seconds

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['allowed_header'] = []
        if self.allowed_header is not None:
            for k in self.allowed_header:
                result['allowed_header'].append(k)
        else:
            result['allowed_header'] = None
        result['allowed_method'] = []
        if self.allowed_method is not None:
            for k in self.allowed_method:
                result['allowed_method'].append(k)
        else:
            result['allowed_method'] = None
        result['allowed_origin'] = []
        if self.allowed_origin is not None:
            for k in self.allowed_origin:
                result['allowed_origin'].append(k)
        else:
            result['allowed_origin'] = None
        result['expose_header'] = []
        if self.expose_header is not None:
            for k in self.expose_header:
                result['expose_header'].append(k)
        else:
            result['expose_header'] = None
        result['max_age_seconds'] = self.max_age_seconds
        return result

    def from_map(self, map={}):
        self.allowed_header = []
        if map.get('allowed_header') is not None:
            for k in map.get('allowed_header'):
                self.allowed_header.append(k)
        else:
            self.allowed_header = None
        self.allowed_method = []
        if map.get('allowed_method') is not None:
            for k in map.get('allowed_method'):
                self.allowed_method.append(k)
        else:
            self.allowed_method = None
        self.allowed_origin = []
        if map.get('allowed_origin') is not None:
            for k in map.get('allowed_origin'):
                self.allowed_origin.append(k)
        else:
            self.allowed_origin = None
        self.expose_header = []
        if map.get('expose_header') is not None:
            for k in map.get('expose_header'):
                self.expose_header.append(k)
        else:
            self.expose_header = None
        self.max_age_seconds = map.get('max_age_seconds')
        return self


class CreateDriveResponse(TeaModel):
    """
    Create drive response
    """
    def __init__(self, domain_id=None, drive_id=None):
        self.domain_id = domain_id
        self.drive_id = drive_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        return result

    def from_map(self, map={}):
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        return self


class CreateShareResponse(TeaModel):
    """
    Create share response
    """
    def __init__(self, domain_id=None, share_id=None):
        self.domain_id = domain_id
        self.share_id = share_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['domain_id'] = self.domain_id
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.domain_id = map.get('domain_id')
        self.share_id = map.get('share_id')
        return self


class DefaultChangePasswordRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, encrypted_key=None, new_password=None, phone_number=None, phone_region=None, state=None):
        self.app_id = app_id
        self.encrypted_key = encrypted_key
        self.new_password = new_password
        self.phone_number = phone_number
        self.phone_region = phone_region
        self.state = state

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.encrypted_key, 'encrypted_key')
        self.validate_required(self.new_password, 'new_password')
        self.validate_required(self.phone_number, 'phone_number')
        self.validate_required(self.state, 'state')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['encrypted_key'] = self.encrypted_key
        result['new_password'] = self.new_password
        result['phone_number'] = self.phone_number
        result['phone_region'] = self.phone_region
        result['state'] = self.state
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.encrypted_key = map.get('encrypted_key')
        self.new_password = map.get('new_password')
        self.phone_number = map.get('phone_number')
        self.phone_region = map.get('phone_region')
        self.state = map.get('state')
        return self


class DefaultSetPasswordRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, encrypted_key=None, new_password=None, state=None):
        self.app_id = app_id
        self.encrypted_key = encrypted_key
        self.new_password = new_password
        self.state = state

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.encrypted_key, 'encrypted_key')
        self.validate_required(self.new_password, 'new_password')
        self.validate_required(self.state, 'state')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['encrypted_key'] = self.encrypted_key
        result['new_password'] = self.new_password
        result['state'] = self.state
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.encrypted_key = map.get('encrypted_key')
        self.new_password = map.get('new_password')
        self.state = map.get('state')
        return self


class DeleteDriveResponse(TeaModel):
    """
    delete drive response
    """
    def __init__(self):
        pass

    def validate(self):
        pass

    def to_map(self):
        result = {}
        return result

    def from_map(self, map={}):
        return self


class DeviceAuthorizeRequest(TeaModel):
    """
    *
    """
    def __init__(self, client_id=None, device_info=None, device_name=None, login_type=None, scope=None):
        self.client_id = client_id
        self.device_info = device_info
        self.device_name = device_name
        self.login_type = login_type
        self.scope = []

    def validate(self):
        self.validate_required(self.client_id, 'client_id')
        self.validate_required(self.device_name, 'device_name')

    def to_map(self):
        result = {}
        result['ClientID'] = self.client_id
        result['DeviceInfo'] = self.device_info
        result['DeviceName'] = self.device_name
        result['LoginType'] = self.login_type
        result['Scope'] = []
        if self.scope is not None:
            for k in self.scope:
                result['Scope'].append(k)
        else:
            result['Scope'] = None
        return result

    def from_map(self, map={}):
        self.client_id = map.get('ClientID')
        self.device_info = map.get('DeviceInfo')
        self.device_name = map.get('DeviceName')
        self.login_type = map.get('LoginType')
        self.scope = []
        if map.get('Scope') is not None:
            for k in map.get('Scope'):
                self.scope.append(k)
        else:
            self.scope = None
        return self


class FileDeltaResponse(TeaModel):
    """
    the file op info
    """
    def __init__(self, current_category=None, file=None, file_id=None, op=None):
        self.current_category = current_category
        self.file = file
        self.file_id = file_id
        self.op = op

    def validate(self):
        if self.file:
            self.file.validate()

    def to_map(self):
        result = {}
        result['current_category'] = self.current_category
        if self.file is not None:
            result['file'] = self.file.to_map()
        else:
            result['file'] = None
        result['file_id'] = self.file_id
        result['op'] = self.op
        return result

    def from_map(self, map={}):
        self.current_category = map.get('current_category')
        if map.get('file') is not None:
            temp_model = BaseCCPFileResponse()
            self.file = temp_model.from_map(map['file'])
        else:
            self.file = None
        self.file_id = map.get('file_id')
        self.op = map.get('op')
        return self


class GetAccessTokenByLinkInfoRequest(TeaModel):
    """
    *
    """
    def __init__(self, extra=None, identity=None, type=None):
        self.extra = extra
        self.identity = identity
        self.type = type

    def validate(self):
        self.validate_required(self.identity, 'identity')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['extra'] = self.extra
        result['identity'] = self.identity
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.extra = map.get('extra')
        self.identity = map.get('identity')
        self.type = map.get('type')
        return self


class GetAppPublicKeyRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None):
        self.app_id = app_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        return self


class GetByLinkInfoRequest(TeaModel):
    """
    *
    """
    def __init__(self, extra=None, identity=None, type=None):
        self.extra = extra
        self.identity = identity
        self.type = type

    def validate(self):
        self.validate_required(self.identity, 'identity')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['extra'] = self.extra
        result['identity'] = self.identity
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.extra = map.get('extra')
        self.identity = map.get('identity')
        self.type = map.get('type')
        return self


class GetCaptchaRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None):
        self.app_id = app_id

    def validate(self):
        self.validate_required(self.app_id, 'app_id')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        return self


class GetDriveResponse(TeaModel):
    """
    Get drive response
    """
    def __init__(self, creator=None, description=None, domain_id=None, drive_id=None, drive_name=None, drive_type=None, encrypt_data_access=None, encrypt_mode=None, owner=None, relative_path=None, status=None, store_id=None, total_size=None, used_size=None):
        self.creator = creator
        self.description = description
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.drive_name = drive_name
        self.drive_type = drive_type
        self.encrypt_data_access = encrypt_data_access
        self.encrypt_mode = encrypt_mode
        self.owner = owner
        self.relative_path = relative_path
        self.status = status
        self.store_id = store_id
        self.total_size = total_size
        self.used_size = used_size

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['creator'] = self.creator
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['drive_name'] = self.drive_name
        result['drive_type'] = self.drive_type
        result['encrypt_data_access'] = self.encrypt_data_access
        result['encrypt_mode'] = self.encrypt_mode
        result['owner'] = self.owner
        result['relative_path'] = self.relative_path
        result['status'] = self.status
        result['store_id'] = self.store_id
        result['total_size'] = self.total_size
        result['used_size'] = self.used_size
        return result

    def from_map(self, map={}):
        self.creator = map.get('creator')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.drive_name = map.get('drive_name')
        self.drive_type = map.get('drive_type')
        self.encrypt_data_access = map.get('encrypt_data_access')
        self.encrypt_mode = map.get('encrypt_mode')
        self.owner = map.get('owner')
        self.relative_path = map.get('relative_path')
        self.status = map.get('status')
        self.store_id = map.get('store_id')
        self.total_size = map.get('total_size')
        self.used_size = map.get('used_size')
        return self


class GetLastCursorResponse(TeaModel):
    """
    get last file op cursor response
    """
    def __init__(self, cursor=None):
        self.cursor = cursor

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['cursor'] = self.cursor
        return result

    def from_map(self, map={}):
        self.cursor = map.get('cursor')
        return self


class GetLinkInfoByUserIDRequest(TeaModel):
    """
    *
    """
    def __init__(self, user_id=None):
        self.user_id = user_id

    def validate(self):
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.user_id = map.get('user_id')
        return self


class GetPublicKeyResponse(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, key_pair_id=None, public_key=None):
        self.app_id = app_id
        self.key_pair_id = key_pair_id
        self.public_key = public_key

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.public_key, 'public_key')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['key_pair_id'] = self.key_pair_id
        result['public_key'] = self.public_key
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.key_pair_id = map.get('key_pair_id')
        self.public_key = map.get('public_key')
        return self


class GetShareResponse(TeaModel):
    """
    Get share response
    """
    def __init__(self, created_at=None, creator=None, description=None, domain_id=None, drive_id=None, expiration=None, expired=None, owner=None, permissions=None, share_file_path=None, share_id=None, share_name=None, share_policy=None, status=None, updated_at=None):
        self.created_at = created_at
        self.creator = creator
        self.description = description
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.expiration = expiration
        self.expired = expired
        self.owner = owner
        self.permissions = []
        self.share_file_path = share_file_path
        self.share_id = share_id
        self.share_name = share_name
        self.share_policy = []
        self.status = status
        self.updated_at = updated_at

    def validate(self):
        if self.share_policy:
            for k in self.share_policy:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['created_at'] = self.created_at
        result['creator'] = self.creator
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['expiration'] = self.expiration
        result['expired'] = self.expired
        result['owner'] = self.owner
        result['permissions'] = []
        if self.permissions is not None:
            for k in self.permissions:
                result['permissions'].append(k)
        else:
            result['permissions'] = None
        result['share_file_path'] = self.share_file_path
        result['share_id'] = self.share_id
        result['share_name'] = self.share_name
        result['share_policy'] = []
        if self.share_policy is not None:
            for k in self.share_policy:
                result['share_policy'].append(k.to_map() if k else None)
        else:
            result['share_policy'] = None
        result['status'] = self.status
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.created_at = map.get('created_at')
        self.creator = map.get('creator')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.expiration = map.get('expiration')
        self.expired = map.get('expired')
        self.owner = map.get('owner')
        self.permissions = []
        if map.get('permissions') is not None:
            for k in map.get('permissions'):
                self.permissions.append(k)
        else:
            self.permissions = None
        self.share_file_path = map.get('share_file_path')
        self.share_id = map.get('share_id')
        self.share_name = map.get('share_name')
        self.share_policy = []
        if map.get('share_policy') is not None:
            for k in map.get('share_policy'):
                temp_model = SharePermissionPolicy()
                temp_model = temp_model.from_map(k)
                self.share_policy.append(temp_model)
        else:
            self.share_policy = None
        self.status = map.get('status')
        self.updated_at = map.get('updated_at')
        return self


class ImageMediaResponse(TeaModel):
    """
    *
    """
    def __init__(self, address_line=None, city=None, country=None, district=None, exif=None, faces=None, height=None, location=None, province=None, story_image_score=None, time=None, township=None, width=None):
        self.address_line = address_line
        self.city = city
        self.country = country
        self.district = district
        self.exif = exif
        self.faces = faces
        self.height = height
        self.location = location
        self.province = province
        self.story_image_score = story_image_score
        self.time = time
        self.township = township
        self.width = width

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['address_line'] = self.address_line
        result['city'] = self.city
        result['country'] = self.country
        result['district'] = self.district
        result['exif'] = self.exif
        result['faces'] = self.faces
        result['height'] = self.height
        result['location'] = self.location
        result['province'] = self.province
        result['story_image_score'] = self.story_image_score
        result['time'] = self.time
        result['township'] = self.township
        result['width'] = self.width
        return result

    def from_map(self, map={}):
        self.address_line = map.get('address_line')
        self.city = map.get('city')
        self.country = map.get('country')
        self.district = map.get('district')
        self.exif = map.get('exif')
        self.faces = map.get('faces')
        self.height = map.get('height')
        self.location = map.get('location')
        self.province = map.get('province')
        self.story_image_score = map.get('story_image_score')
        self.time = map.get('time')
        self.township = map.get('township')
        self.width = map.get('width')
        return self


class LinkInfo(TeaModel):
    """
    *
    """
    def __init__(self, extra=None, identity=None, type=None):
        self.extra = extra
        self.identity = identity
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['extra'] = self.extra
        result['identity'] = self.identity
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.extra = map.get('extra')
        self.identity = map.get('identity')
        self.type = map.get('type')
        return self


class LinkInfoListResponse(TeaModel):
    """
    *
    """
    def __init__(self, items=None):
        self.items = []

    def validate(self):
        self.validate_required(self.items, 'items')
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = LinkInfoResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        return self


class LinkInfoResponse(TeaModel):
    """
    *
    """
    def __init__(self, authentication_type=None, created_at=None, domain_id=None, extra=None, identity=None, last_login_time=None, status=None, user_id=None):
        self.authentication_type = authentication_type
        self.created_at = created_at
        self.domain_id = domain_id
        self.extra = extra
        self.identity = identity
        self.last_login_time = last_login_time
        self.status = status
        self.user_id = user_id

    def validate(self):
        self.validate_required(self.authentication_type, 'authentication_type')
        self.validate_required(self.created_at, 'created_at')
        self.validate_required(self.domain_id, 'domain_id')
        self.validate_required(self.identity, 'identity')
        self.validate_required(self.last_login_time, 'last_login_time')
        self.validate_required(self.status, 'status')
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['authentication_type'] = self.authentication_type
        result['created_at'] = self.created_at
        result['domain_id'] = self.domain_id
        result['extra'] = self.extra
        result['identity'] = self.identity
        result['last_login_time'] = self.last_login_time
        result['status'] = self.status
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.authentication_type = map.get('authentication_type')
        self.created_at = map.get('created_at')
        self.domain_id = map.get('domain_id')
        self.extra = map.get('extra')
        self.identity = map.get('identity')
        self.last_login_time = map.get('last_login_time')
        self.status = map.get('status')
        self.user_id = map.get('user_id')
        return self


class ListDriveResponse(TeaModel):
    """
    list drive response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseDriveResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class ListFileDeltaResponse(TeaModel):
    """
    list file op response
    """
    def __init__(self, cursor=None, has_more=None, items=None):
        self.cursor = cursor
        self.has_more = has_more
        self.items = []

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['cursor'] = self.cursor
        result['has_more'] = self.has_more
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        return result

    def from_map(self, map={}):
        self.cursor = map.get('cursor')
        self.has_more = map.get('has_more')
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = FileDeltaResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        return self


class ListShareResponse(TeaModel):
    """
    List share response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseShareResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class ListStoreFileResponse(TeaModel):
    """
    List storage file
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = StoreFile()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class ListStoreResponse(TeaModel):
    """
    List storage
    """
    def __init__(self, items=None):
        self.items = []

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = StoreItemResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        return self


class LoginByCodeRequest(TeaModel):
    """
    *
    """
    def __init__(self, access_token=None, app_id=None, auth_code=None, type=None):
        self.access_token = access_token
        self.app_id = app_id
        self.auth_code = auth_code
        self.type = type

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['access_token'] = self.access_token
        result['app_id'] = self.app_id
        result['auth_code'] = self.auth_code
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.access_token = map.get('access_token')
        self.app_id = map.get('app_id')
        self.auth_code = map.get('auth_code')
        self.type = map.get('type')
        return self


class MobileCheckExistRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, phone_number=None, phone_region=None):
        self.app_id = app_id
        self.phone_number = phone_number
        self.phone_region = phone_region

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.phone_number, 'phone_number')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['phone_number'] = self.phone_number
        result['phone_region'] = self.phone_region
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.phone_number = map.get('phone_number')
        self.phone_region = map.get('phone_region')
        return self


class MobileCheckExistResponse(TeaModel):
    """
    *
    """
    def __init__(self, is_exist=None, phone_number=None, phone_region=None):
        self.is_exist = is_exist
        self.phone_number = phone_number
        self.phone_region = phone_region

    def validate(self):
        self.validate_required(self.is_exist, 'is_exist')
        self.validate_required(self.phone_number, 'phone_number')

    def to_map(self):
        result = {}
        result['is_exist'] = self.is_exist
        result['phone_number'] = self.phone_number
        result['phone_region'] = self.phone_region
        return result

    def from_map(self, map={}):
        self.is_exist = map.get('is_exist')
        self.phone_number = map.get('phone_number')
        self.phone_region = map.get('phone_region')
        return self


class MobileLoginRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, auto_register=None, captcha_id=None, captcha_text=None, encrypted_key=None, password=None, phone_number=None, phone_region=None, sms_code=None, sms_code_id=None):
        self.app_id = app_id
        self.auto_register = auto_register
        self.captcha_id = captcha_id
        self.captcha_text = captcha_text
        self.encrypted_key = encrypted_key
        self.password = password
        self.phone_number = phone_number
        self.phone_region = phone_region
        self.sms_code = sms_code
        self.sms_code_id = sms_code_id

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.phone_number, 'phone_number')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['auto_register'] = self.auto_register
        result['captcha_id'] = self.captcha_id
        result['captcha_text'] = self.captcha_text
        result['encrypted_key'] = self.encrypted_key
        result['password'] = self.password
        result['phone_number'] = self.phone_number
        result['phone_region'] = self.phone_region
        result['sms_code'] = self.sms_code
        result['sms_code_id'] = self.sms_code_id
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.auto_register = map.get('auto_register')
        self.captcha_id = map.get('captcha_id')
        self.captcha_text = map.get('captcha_text')
        self.encrypted_key = map.get('encrypted_key')
        self.password = map.get('password')
        self.phone_number = map.get('phone_number')
        self.phone_region = map.get('phone_region')
        self.sms_code = map.get('sms_code')
        self.sms_code_id = map.get('sms_code_id')
        return self


class MobileRegisterRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, phone_number=None, phone_region=None, sms_code=None, sms_code_id=None):
        self.app_id = app_id
        self.phone_number = phone_number
        self.phone_region = phone_region
        self.sms_code = sms_code
        self.sms_code_id = sms_code_id

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.phone_number, 'phone_number')
        self.validate_required(self.sms_code, 'sms_code')
        self.validate_required(self.sms_code_id, 'sms_code_id')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['phone_number'] = self.phone_number
        result['phone_region'] = self.phone_region
        result['sms_code'] = self.sms_code
        result['sms_code_id'] = self.sms_code_id
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.phone_number = map.get('phone_number')
        self.phone_region = map.get('phone_region')
        self.sms_code = map.get('sms_code')
        self.sms_code_id = map.get('sms_code_id')
        return self


class MobileSendSmsCodeRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, captcha_id=None, captcha_text=None, phone_number=None, phone_region=None, type=None):
        self.app_id = app_id
        self.captcha_id = captcha_id
        self.captcha_text = captcha_text
        self.phone_number = phone_number
        self.phone_region = phone_region
        self.type = type

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.phone_number, 'phone_number')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['captcha_id'] = self.captcha_id
        result['captcha_text'] = self.captcha_text
        result['phone_number'] = self.phone_number
        result['phone_region'] = self.phone_region
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.captcha_id = map.get('captcha_id')
        self.captcha_text = map.get('captcha_text')
        self.phone_number = map.get('phone_number')
        self.phone_region = map.get('phone_region')
        self.type = map.get('type')
        return self


class MobileSendSmsCodeResponse(TeaModel):
    """
    *
    """
    def __init__(self, sms_code_id=None):
        self.sms_code_id = sms_code_id

    def validate(self):
        self.validate_required(self.sms_code_id, 'sms_code_id')

    def to_map(self):
        result = {}
        result['sms_code_id'] = self.sms_code_id
        return result

    def from_map(self, map={}):
        self.sms_code_id = map.get('sms_code_id')
        return self


class OSSCompleteFileResponse(TeaModel):
    """
    complete file response
    """
    def __init__(self, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, file_extension=None, file_path=None, name=None, parent_file_path=None, share_id=None, size=None, status=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None, crc=None):
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.file_extension = file_extension
        self.file_path = file_path
        self.name = name
        self.parent_file_path = parent_file_path
        self.share_id = share_id
        self.size = size
        self.status = status
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url
        self.crc = crc

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_path:
            self.validate_pattern(self.parent_file_path, 'parent_file_path', '[a-z0-9]{1,50}')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['file_extension'] = self.file_extension
        result['file_path'] = self.file_path
        result['name'] = self.name
        result['parent_file_path'] = self.parent_file_path
        result['share_id'] = self.share_id
        result['size'] = self.size
        result['status'] = self.status
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        result['crc'] = self.crc
        return result

    def from_map(self, map={}):
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.file_extension = map.get('file_extension')
        self.file_path = map.get('file_path')
        self.name = map.get('name')
        self.parent_file_path = map.get('parent_file_path')
        self.share_id = map.get('share_id')
        self.size = map.get('size')
        self.status = map.get('status')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        self.crc = map.get('crc')
        return self


class OSSCopyFileResponse(TeaModel):
    """
    文件拷贝 response
    """
    def __init__(self, async_task_id=None, domain_id=None, drive_id=None, file_path=None, share_id=None):
        self.async_task_id = async_task_id
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_path = file_path
        self.share_id = share_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z-]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[a-z0-9A-Z]+')

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.share_id = map.get('share_id')
        return self


class OSSCreateFileResponse(TeaModel):
    """
    Create file response
    """
    def __init__(self, domain_id=None, drive_id=None, file_path=None, part_info_list=None, share_id=None, type=None, upload_id=None):
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_path = file_path
        self.part_info_list = []
        self.share_id = share_id
        self.type = type
        self.upload_id = upload_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9]{1,50}')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['share_id'] = self.share_id
        result['type'] = self.type
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.share_id = map.get('share_id')
        self.type = map.get('type')
        self.upload_id = map.get('upload_id')
        return self


class OSSDeleteFileResponse(TeaModel):
    """
    删除文件 response
    """
    def __init__(self, async_task_id=None, domain_id=None, drive_id=None, file_path=None, share_id=None):
        self.async_task_id = async_task_id
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_path = file_path
        self.share_id = share_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[a-z0-9A-Z]+')

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.share_id = map.get('share_id')
        return self


class OSSDeleteFilesResponse(TeaModel):
    """
    批量删除文件 response
    """
    def __init__(self, deleted_file_id_list=None, domain_id=None, drive_id=None, share_id=None):
        self.deleted_file_id_list = []
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.share_id = share_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['deleted_file_id_list'] = []
        if self.deleted_file_id_list is not None:
            for k in self.deleted_file_id_list:
                result['deleted_file_id_list'].append(k)
        else:
            result['deleted_file_id_list'] = None
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.deleted_file_id_list = []
        if map.get('deleted_file_id_list') is not None:
            for k in map.get('deleted_file_id_list'):
                self.deleted_file_id_list.append(k)
        else:
            self.deleted_file_id_list = None
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.share_id = map.get('share_id')
        return self


class OSSGetDownloadUrlResponse(TeaModel):
    """
    获取download url response
    """
    def __init__(self, expiration=None, method=None, url=None):
        self.expiration = expiration
        self.method = method
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['expiration'] = self.expiration
        result['method'] = self.method
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.expiration = map.get('expiration')
        self.method = map.get('method')
        self.url = map.get('url')
        return self


class OSSGetFileResponse(TeaModel):
    """
    获取文件元数据response
    """
    def __init__(self, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, file_extension=None, file_path=None, name=None, parent_file_path=None, share_id=None, size=None, status=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None):
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.file_extension = file_extension
        self.file_path = file_path
        self.name = name
        self.parent_file_path = parent_file_path
        self.share_id = share_id
        self.size = size
        self.status = status
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_path:
            self.validate_pattern(self.parent_file_path, 'parent_file_path', '[a-z0-9]{1,50}')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['file_extension'] = self.file_extension
        result['file_path'] = self.file_path
        result['name'] = self.name
        result['parent_file_path'] = self.parent_file_path
        result['share_id'] = self.share_id
        result['size'] = self.size
        result['status'] = self.status
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.file_extension = map.get('file_extension')
        self.file_path = map.get('file_path')
        self.name = map.get('name')
        self.parent_file_path = map.get('parent_file_path')
        self.share_id = map.get('share_id')
        self.size = map.get('size')
        self.status = map.get('status')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        return self


class OSSGetSecureUrlResponse(TeaModel):
    """
    获取secure url response
    """
    def __init__(self, expiration=None, url=None):
        self.expiration = expiration
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['expiration'] = self.expiration
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.expiration = map.get('expiration')
        self.url = map.get('url')
        return self


class OSSGetUploadUrlResponse(TeaModel):
    """
    Get UploadUrl Response
    """
    def __init__(self, create_at=None, domain_id=None, drive_id=None, file_path=None, part_info_list=None, upload_id=None):
        self.create_at = create_at
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_path = file_path
        self.part_info_list = []
        self.upload_id = upload_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['create_at'] = self.create_at
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.create_at = map.get('create_at')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.upload_id = map.get('upload_id')
        return self


class OSSListFileResponse(TeaModel):
    """
    List file response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseOSSFileResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class OSSListUploadedPartResponse(TeaModel):
    """
    获取签名 response
    """
    def __init__(self, file_path=None, next_part_number_marker=None, upload_id=None, uploaded_parts=None):
        self.file_path = file_path
        self.next_part_number_marker = next_part_number_marker
        self.upload_id = upload_id
        self.uploaded_parts = []

    def validate(self):
        if self.uploaded_parts:
            for k in self.uploaded_parts:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['file_path'] = self.file_path
        result['next_part_number_marker'] = self.next_part_number_marker
        result['upload_id'] = self.upload_id
        result['uploaded_parts'] = []
        if self.uploaded_parts is not None:
            for k in self.uploaded_parts:
                result['uploaded_parts'].append(k.to_map() if k else None)
        else:
            result['uploaded_parts'] = None
        return result

    def from_map(self, map={}):
        self.file_path = map.get('file_path')
        self.next_part_number_marker = map.get('next_part_number_marker')
        self.upload_id = map.get('upload_id')
        self.uploaded_parts = []
        if map.get('uploaded_parts') is not None:
            for k in map.get('uploaded_parts'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.uploaded_parts.append(temp_model)
        else:
            self.uploaded_parts = None
        return self


class OSSMoveFileResponse(TeaModel):
    """
    文件移动 response
    """
    def __init__(self, async_task_id=None, domain_id=None, drive_id=None, file_path=None, share_id=None):
        self.async_task_id = async_task_id
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.file_path = file_path
        self.share_id = share_id

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z-]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[a-z0-9A-Z]+')

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.share_id = map.get('share_id')
        return self


class OSSSearchFileResponse(TeaModel):
    """
    search file response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseOSSFileResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class OSSUpdateFileMetaResponse(TeaModel):
    """
    更新文件元数据 response
    """
    def __init__(self, content_hash=None, content_hash_name=None, content_type=None, crc_64hash=None, created_at=None, description=None, domain_id=None, download_url=None, drive_id=None, file_extension=None, file_path=None, name=None, parent_file_path=None, share_id=None, size=None, status=None, thumbnail=None, trashed_at=None, type=None, updated_at=None, upload_id=None, url=None):
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_type = content_type
        self.crc_64hash = crc_64hash
        self.created_at = created_at
        self.description = description
        self.domain_id = domain_id
        self.download_url = download_url
        self.drive_id = drive_id
        self.file_extension = file_extension
        self.file_path = file_path
        self.name = name
        self.parent_file_path = parent_file_path
        self.share_id = share_id
        self.size = size
        self.status = status
        self.thumbnail = thumbnail
        self.trashed_at = trashed_at
        self.type = type
        self.updated_at = updated_at
        self.upload_id = upload_id
        self.url = url

    def validate(self):
        if self.domain_id:
            self.validate_pattern(self.domain_id, 'domain_id', '[a-z0-9A-Z]+')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')
        if self.parent_file_path:
            self.validate_pattern(self.parent_file_path, 'parent_file_path', '[a-z0-9]{1,50}')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_type'] = self.content_type
        result['crc64_hash'] = self.crc_64hash
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['download_url'] = self.download_url
        result['drive_id'] = self.drive_id
        result['file_extension'] = self.file_extension
        result['file_path'] = self.file_path
        result['name'] = self.name
        result['parent_file_path'] = self.parent_file_path
        result['share_id'] = self.share_id
        result['size'] = self.size
        result['status'] = self.status
        result['thumbnail'] = self.thumbnail
        result['trashed_at'] = self.trashed_at
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        result['upload_id'] = self.upload_id
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_type = map.get('content_type')
        self.crc_64hash = map.get('crc64_hash')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.download_url = map.get('download_url')
        self.drive_id = map.get('drive_id')
        self.file_extension = map.get('file_extension')
        self.file_path = map.get('file_path')
        self.name = map.get('name')
        self.parent_file_path = map.get('parent_file_path')
        self.share_id = map.get('share_id')
        self.size = map.get('size')
        self.status = map.get('status')
        self.thumbnail = map.get('thumbnail')
        self.trashed_at = map.get('trashed_at')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        self.upload_id = map.get('upload_id')
        self.url = map.get('url')
        return self


class OSSVideoDRMLicenseResponse(TeaModel):
    """
    DRM License response
    """
    def __init__(self, data=None, states=None):
        self.data = data
        self.states = states

    def validate(self):
        self.validate_required(self.data, 'data')
        self.validate_required(self.states, 'states')

    def to_map(self):
        result = {}
        result['data'] = self.data
        result['states'] = self.states
        return result

    def from_map(self, map={}):
        self.data = map.get('data')
        self.states = map.get('states')
        return self


class OSSVideoDefinitionResponse(TeaModel):
    """
    转码接口response
    """
    def __init__(self, definition_list=None, frame_rate=None):
        self.definition_list = []
        self.frame_rate = frame_rate

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['definition_list'] = []
        if self.definition_list is not None:
            for k in self.definition_list:
                result['definition_list'].append(k)
        else:
            result['definition_list'] = None
        result['frame_rate'] = self.frame_rate
        return result

    def from_map(self, map={}):
        self.definition_list = []
        if map.get('definition_list') is not None:
            for k in map.get('definition_list'):
                self.definition_list.append(k)
        else:
            self.definition_list = None
        self.frame_rate = map.get('frame_rate')
        return self


class OSSVideoTranscodeResponse(TeaModel):
    """
    转码接口response
    """
    def __init__(self, definition_list=None, duration=None, hls_time=None):
        self.definition_list = []
        self.duration = duration
        self.hls_time = hls_time

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['definition_list'] = []
        if self.definition_list is not None:
            for k in self.definition_list:
                result['definition_list'].append(k)
        else:
            result['definition_list'] = None
        result['duration'] = self.duration
        result['hls_time'] = self.hls_time
        return result

    def from_map(self, map={}):
        self.definition_list = []
        if map.get('definition_list') is not None:
            for k in map.get('definition_list'):
                self.definition_list.append(k)
        else:
            self.definition_list = None
        self.duration = map.get('duration')
        self.hls_time = map.get('hls_time')
        return self


class PreHashCheckSuccessResponse(TeaModel):
    """
    Pre hash check Response
    """
    def __init__(self, code=None, file_name=None, message=None, parent_file_id=None, pre_hash=None):
        self.code = code
        self.file_name = file_name
        self.message = message
        self.parent_file_id = parent_file_id
        self.pre_hash = pre_hash

    def validate(self):
        self.validate_required(self.parent_file_id, 'parent_file_id')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')

    def to_map(self):
        result = {}
        result['code'] = self.code
        result['file_name'] = self.file_name
        result['message'] = self.message
        result['parent_file_id'] = self.parent_file_id
        result['pre_hash'] = self.pre_hash
        return result

    def from_map(self, map={}):
        self.code = map.get('code')
        self.file_name = map.get('file_name')
        self.message = map.get('message')
        self.parent_file_id = map.get('parent_file_id')
        self.pre_hash = map.get('pre_hash')
        return self


class RevokeRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, refresh_token=None):
        self.app_id = app_id
        self.refresh_token = refresh_token

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.refresh_token, 'refresh_token')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['refresh_token'] = self.refresh_token
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.refresh_token = map.get('refresh_token')
        return self


class SharePermissionPolicy(TeaModel):
    """
    *
    """
    def __init__(self, file_path=None, permission_inheritable=None, permission_list=None, permission_type=None):
        self.file_path = file_path
        self.permission_inheritable = permission_inheritable
        self.permission_list = []
        self.permission_type = permission_type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['file_path'] = self.file_path
        result['permission_inheritable'] = self.permission_inheritable
        result['permission_list'] = []
        if self.permission_list is not None:
            for k in self.permission_list:
                result['permission_list'].append(k)
        else:
            result['permission_list'] = None
        result['permission_type'] = self.permission_type
        return result

    def from_map(self, map={}):
        self.file_path = map.get('file_path')
        self.permission_inheritable = map.get('permission_inheritable')
        self.permission_list = []
        if map.get('permission_list') is not None:
            for k in map.get('permission_list'):
                self.permission_list.append(k)
        else:
            self.permission_list = None
        self.permission_type = map.get('permission_type')
        return self


class StoreFile(TeaModel):
    """
    *
    """
    def __init__(self, domain_id=None, name=None, parent_file_path=None, store_id=None, type=None):
        self.domain_id = domain_id
        self.name = name
        self.parent_file_path = parent_file_path
        self.store_id = store_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['domain_id'] = self.domain_id
        result['name'] = self.name
        result['parent_file_path'] = self.parent_file_path
        result['store_id'] = self.store_id
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.domain_id = map.get('domain_id')
        self.name = map.get('name')
        self.parent_file_path = map.get('parent_file_path')
        self.store_id = map.get('store_id')
        self.type = map.get('type')
        return self


class StoreItemResponse(TeaModel):
    """
    *
    """
    def __init__(self, accelerate_endpoint=None, base_path=None, bucket=None, customized_endpoint=None, domain_id=None, endpoint=None, internal_endpoint=None, ownership=None, policy=None, role_arn=None, store_id=None, type=None):
        self.accelerate_endpoint = accelerate_endpoint
        self.base_path = base_path
        self.bucket = bucket
        self.customized_endpoint = customized_endpoint
        self.domain_id = domain_id
        self.endpoint = endpoint
        self.internal_endpoint = internal_endpoint
        self.ownership = ownership
        self.policy = policy
        self.role_arn = role_arn
        self.store_id = store_id
        self.type = type

    def validate(self):
        self.validate_required(self.bucket, 'bucket')
        self.validate_required(self.endpoint, 'endpoint')
        self.validate_required(self.ownership, 'ownership')
        self.validate_required(self.policy, 'policy')
        self.validate_required(self.store_id, 'store_id')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['accelerate_endpoint'] = self.accelerate_endpoint
        result['base_path'] = self.base_path
        result['bucket'] = self.bucket
        result['customized_endpoint'] = self.customized_endpoint
        result['domain_id'] = self.domain_id
        result['endpoint'] = self.endpoint
        result['internal_endpoint'] = self.internal_endpoint
        result['ownership'] = self.ownership
        result['policy'] = self.policy
        result['role_arn'] = self.role_arn
        result['store_id'] = self.store_id
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.accelerate_endpoint = map.get('accelerate_endpoint')
        self.base_path = map.get('base_path')
        self.bucket = map.get('bucket')
        self.customized_endpoint = map.get('customized_endpoint')
        self.domain_id = map.get('domain_id')
        self.endpoint = map.get('endpoint')
        self.internal_endpoint = map.get('internal_endpoint')
        self.ownership = map.get('ownership')
        self.policy = map.get('policy')
        self.role_arn = map.get('role_arn')
        self.store_id = map.get('store_id')
        self.type = map.get('type')
        return self


class StreamInfo(TeaModel):
    """
    *
    """
    def __init__(self, crc_64hash=None, download_url=None, thumbnail=None, url=None):
        self.crc_64hash = crc_64hash
        self.download_url = download_url
        self.thumbnail = thumbnail
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['crc64_hash'] = self.crc_64hash
        result['download_url'] = self.download_url
        result['thumbnail'] = self.thumbnail
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.crc_64hash = map.get('crc64_hash')
        self.download_url = map.get('download_url')
        self.thumbnail = map.get('thumbnail')
        self.url = map.get('url')
        return self


class StreamUploadInfo(TeaModel):
    """
    *
    """
    def __init__(self, part_info_list=None, pre_rapid_upload=None, rapid_upload=None, upload_id=None):
        self.part_info_list = []
        self.pre_rapid_upload = pre_rapid_upload
        self.rapid_upload = rapid_upload
        self.upload_id = upload_id

    def validate(self):
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['pre_rapid_upload'] = self.pre_rapid_upload
        result['rapid_upload'] = self.rapid_upload
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.pre_rapid_upload = map.get('pre_rapid_upload')
        self.rapid_upload = map.get('rapid_upload')
        self.upload_id = map.get('upload_id')
        return self


class TokenRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, grant_type=None, refresh_token=None):
        self.app_id = app_id
        self.grant_type = grant_type
        self.refresh_token = refresh_token

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.grant_type, 'grant_type')
        self.validate_required(self.refresh_token, 'refresh_token')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['grant_type'] = self.grant_type
        result['refresh_token'] = self.refresh_token
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.grant_type = map.get('grant_type')
        self.refresh_token = map.get('refresh_token')
        return self


class UpdateDriveResponse(TeaModel):
    """
    Update drive response
    """
    def __init__(self, creator=None, description=None, domain_id=None, drive_id=None, drive_name=None, drive_type=None, encrypt_data_access=None, encrypt_mode=None, owner=None, relative_path=None, status=None, store_id=None, total_size=None, used_size=None):
        self.creator = creator
        self.description = description
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.drive_name = drive_name
        self.drive_type = drive_type
        self.encrypt_data_access = encrypt_data_access
        self.encrypt_mode = encrypt_mode
        self.owner = owner
        self.relative_path = relative_path
        self.status = status
        self.store_id = store_id
        self.total_size = total_size
        self.used_size = used_size

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['creator'] = self.creator
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['drive_name'] = self.drive_name
        result['drive_type'] = self.drive_type
        result['encrypt_data_access'] = self.encrypt_data_access
        result['encrypt_mode'] = self.encrypt_mode
        result['owner'] = self.owner
        result['relative_path'] = self.relative_path
        result['status'] = self.status
        result['store_id'] = self.store_id
        result['total_size'] = self.total_size
        result['used_size'] = self.used_size
        return result

    def from_map(self, map={}):
        self.creator = map.get('creator')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.drive_name = map.get('drive_name')
        self.drive_type = map.get('drive_type')
        self.encrypt_data_access = map.get('encrypt_data_access')
        self.encrypt_mode = map.get('encrypt_mode')
        self.owner = map.get('owner')
        self.relative_path = map.get('relative_path')
        self.status = map.get('status')
        self.store_id = map.get('store_id')
        self.total_size = map.get('total_size')
        self.used_size = map.get('used_size')
        return self


class UpdateShareResponse(TeaModel):
    """
    Update share response
    """
    def __init__(self, created_at=None, creator=None, description=None, domain_id=None, drive_id=None, expiration=None, expired=None, owner=None, permissions=None, share_file_path=None, share_id=None, share_name=None, share_policy=None, status=None, updated_at=None):
        self.created_at = created_at
        self.creator = creator
        self.description = description
        self.domain_id = domain_id
        self.drive_id = drive_id
        self.expiration = expiration
        self.expired = expired
        self.owner = owner
        self.permissions = []
        self.share_file_path = share_file_path
        self.share_id = share_id
        self.share_name = share_name
        self.share_policy = []
        self.status = status
        self.updated_at = updated_at

    def validate(self):
        if self.share_policy:
            for k in self.share_policy:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['created_at'] = self.created_at
        result['creator'] = self.creator
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['drive_id'] = self.drive_id
        result['expiration'] = self.expiration
        result['expired'] = self.expired
        result['owner'] = self.owner
        result['permissions'] = []
        if self.permissions is not None:
            for k in self.permissions:
                result['permissions'].append(k)
        else:
            result['permissions'] = None
        result['share_file_path'] = self.share_file_path
        result['share_id'] = self.share_id
        result['share_name'] = self.share_name
        result['share_policy'] = []
        if self.share_policy is not None:
            for k in self.share_policy:
                result['share_policy'].append(k.to_map() if k else None)
        else:
            result['share_policy'] = None
        result['status'] = self.status
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.created_at = map.get('created_at')
        self.creator = map.get('creator')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.drive_id = map.get('drive_id')
        self.expiration = map.get('expiration')
        self.expired = map.get('expired')
        self.owner = map.get('owner')
        self.permissions = []
        if map.get('permissions') is not None:
            for k in map.get('permissions'):
                self.permissions.append(k)
        else:
            self.permissions = None
        self.share_file_path = map.get('share_file_path')
        self.share_id = map.get('share_id')
        self.share_name = map.get('share_name')
        self.share_policy = []
        if map.get('share_policy') is not None:
            for k in map.get('share_policy'):
                temp_model = SharePermissionPolicy()
                temp_model = temp_model.from_map(k)
                self.share_policy.append(temp_model)
        else:
            self.share_policy = None
        self.status = map.get('status')
        self.updated_at = map.get('updated_at')
        return self


class UploadPartInfo(TeaModel):
    """
    *
    """
    def __init__(self, etag=None, part_number=None, part_size=None, upload_url=None):
        self.etag = etag
        self.part_number = part_number
        self.part_size = part_size
        self.upload_url = upload_url

    def validate(self):
        if self.part_number:
            self.validate_pattern(self.part_number, 'part_number', '[0-9]+')

    def to_map(self):
        result = {}
        result['etag'] = self.etag
        result['part_number'] = self.part_number
        result['part_size'] = self.part_size
        result['upload_url'] = self.upload_url
        return result

    def from_map(self, map={}):
        self.etag = map.get('etag')
        self.part_number = map.get('part_number')
        self.part_size = map.get('part_size')
        self.upload_url = map.get('upload_url')
        return self


class UserAuthentication(TeaModel):
    """
    *
    """
    def __init__(self, authentication_type=None, created_at=None, detail=None, domain_id=None, identity=None, last_login_time=None, status=None, user_id=None, extra=None):
        self.authentication_type = authentication_type
        self.created_at = created_at
        self.detail = detail
        self.domain_id = domain_id
        self.identity = identity
        self.last_login_time = last_login_time
        self.status = status
        self.user_id = user_id
        self.extra = extra

    def validate(self):
        self.validate_required(self.authentication_type, 'authentication_type')
        self.validate_required(self.created_at, 'created_at')
        self.validate_required(self.detail, 'detail')
        self.validate_required(self.domain_id, 'domain_id')
        self.validate_required(self.identity, 'identity')
        self.validate_required(self.last_login_time, 'last_login_time')
        self.validate_required(self.status, 'status')
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['AuthenticationType'] = self.authentication_type
        result['CreatedAt'] = self.created_at
        result['Detail'] = self.detail
        result['DomainID'] = self.domain_id
        result['Identity'] = self.identity
        result['LastLoginTime'] = self.last_login_time
        result['Status'] = self.status
        result['UserID'] = self.user_id
        result['extra'] = self.extra
        return result

    def from_map(self, map={}):
        self.authentication_type = map.get('AuthenticationType')
        self.created_at = map.get('CreatedAt')
        self.detail = map.get('Detail')
        self.domain_id = map.get('DomainID')
        self.identity = map.get('Identity')
        self.last_login_time = map.get('LastLoginTime')
        self.status = map.get('Status')
        self.user_id = map.get('UserID')
        self.extra = map.get('extra')
        return self


class VerifyCodeRequest(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, phone_number=None, phone_region=None, sms_code=None, sms_code_id=None, verify_type=None):
        self.app_id = app_id
        self.phone_number = phone_number
        self.phone_region = phone_region
        self.sms_code = sms_code
        self.sms_code_id = sms_code_id
        self.verify_type = verify_type

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.phone_number, 'phone_number')
        self.validate_required(self.sms_code, 'sms_code')
        self.validate_required(self.sms_code_id, 'sms_code_id')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['phone_number'] = self.phone_number
        result['phone_region'] = self.phone_region
        result['sms_code'] = self.sms_code
        result['sms_code_id'] = self.sms_code_id
        result['verify_type'] = self.verify_type
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.phone_number = map.get('phone_number')
        self.phone_region = map.get('phone_region')
        self.sms_code = map.get('sms_code')
        self.sms_code_id = map.get('sms_code_id')
        self.verify_type = map.get('verify_type')
        return self


class VerifyCodeResponse(TeaModel):
    """
    *
    """
    def __init__(self, state=None):
        self.state = state

    def validate(self):
        self.validate_required(self.state, 'state')

    def to_map(self):
        result = {}
        result['state'] = self.state
        return result

    def from_map(self, map={}):
        self.state = map.get('state')
        return self


class VideoMediaResponse(TeaModel):
    """
    *
    """
    def __init__(self, address_line=None, city=None, country=None, district=None, duration=None, height=None, location=None, province=None, time=None, township=None, width=None):
        self.address_line = address_line
        self.city = city
        self.country = country
        self.district = district
        self.duration = duration
        self.height = height
        self.location = location
        self.province = province
        self.time = time
        self.township = township
        self.width = width

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['address_line'] = self.address_line
        result['city'] = self.city
        result['country'] = self.country
        result['district'] = self.district
        result['duration'] = self.duration
        result['height'] = self.height
        result['location'] = self.location
        result['province'] = self.province
        result['time'] = self.time
        result['township'] = self.township
        result['width'] = self.width
        return result

    def from_map(self, map={}):
        self.address_line = map.get('address_line')
        self.city = map.get('city')
        self.country = map.get('country')
        self.district = map.get('district')
        self.duration = map.get('duration')
        self.height = map.get('height')
        self.location = map.get('location')
        self.province = map.get('province')
        self.time = map.get('time')
        self.township = map.get('township')
        self.width = map.get('width')
        return self


class VideoPreviewResponse(TeaModel):
    """
    *
    """
    def __init__(self, audio_format=None, bitrate=None, duration=None, frame_rate=None, height=None, sprite_info=None, template_list=None, thumbnail=None, video_format=None, width=None):
        self.audio_format = audio_format
        self.bitrate = bitrate
        self.duration = duration
        self.frame_rate = frame_rate
        self.height = height
        self.sprite_info = sprite_info
        self.template_list = []
        self.thumbnail = thumbnail
        self.video_format = video_format
        self.width = width

    def validate(self):
        if self.sprite_info:
            self.sprite_info.validate()
        if self.template_list:
            for k in self.template_list:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['audio_format'] = self.audio_format
        result['bitrate'] = self.bitrate
        result['duration'] = self.duration
        result['frame_rate'] = self.frame_rate
        result['height'] = self.height
        if self.sprite_info is not None:
            result['sprite_info'] = self.sprite_info.to_map()
        else:
            result['sprite_info'] = None
        result['template_list'] = []
        if self.template_list is not None:
            for k in self.template_list:
                result['template_list'].append(k.to_map() if k else None)
        else:
            result['template_list'] = None
        result['thumbnail'] = self.thumbnail
        result['video_format'] = self.video_format
        result['width'] = self.width
        return result

    def from_map(self, map={}):
        self.audio_format = map.get('audio_format')
        self.bitrate = map.get('bitrate')
        self.duration = map.get('duration')
        self.frame_rate = map.get('frame_rate')
        self.height = map.get('height')
        if map.get('sprite_info') is not None:
            temp_model = VideoPreviewSprite()
            self.sprite_info = temp_model.from_map(map['sprite_info'])
        else:
            self.sprite_info = None
        self.template_list = []
        if map.get('template_list') is not None:
            for k in map.get('template_list'):
                temp_model = VideoPreviewTranscode()
                temp_model = temp_model.from_map(k)
                self.template_list.append(temp_model)
        else:
            self.template_list = None
        self.thumbnail = map.get('thumbnail')
        self.video_format = map.get('video_format')
        self.width = map.get('width')
        return self


class VideoPreviewSprite(TeaModel):
    """
    *
    """
    def __init__(self, col=None, count=None, frame_count=None, frame_height=None, frame_width=None, row=None, status=None):
        self.col = col
        self.count = count
        self.frame_count = frame_count
        self.frame_height = frame_height
        self.frame_width = frame_width
        self.row = row
        self.status = status

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['col'] = self.col
        result['count'] = self.count
        result['frame_count'] = self.frame_count
        result['frame_height'] = self.frame_height
        result['frame_width'] = self.frame_width
        result['row'] = self.row
        result['status'] = self.status
        return result

    def from_map(self, map={}):
        self.col = map.get('col')
        self.count = map.get('count')
        self.frame_count = map.get('frame_count')
        self.frame_height = map.get('frame_height')
        self.frame_width = map.get('frame_width')
        self.row = map.get('row')
        self.status = map.get('status')
        return self


class VideoPreviewTranscode(TeaModel):
    """
    *
    """
    def __init__(self, status=None, template_id=None):
        self.status = status
        self.template_id = template_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['status'] = self.status
        result['template_id'] = self.template_id
        return result

    def from_map(self, map={}):
        self.status = map.get('status')
        self.template_id = map.get('template_id')
        return self


class AdminListStoresRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AdminListStoresRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class AdminListStoresModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListStoresResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetUserAccessTokenRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetUserAccessTokenRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetUserAccessTokenModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = AccessTokenResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class AddStoreResponse(TeaModel):
    """
    *
    """
    def __init__(self, accelerate_endpoint=None, base_path=None, bucket=None, customized_endpoint=None, domain_id=None, endpoint=None, internal_endpoint=None, ownership=None, policy=None, role_arn=None, store_id=None, type=None):
        self.accelerate_endpoint = accelerate_endpoint
        self.base_path = base_path
        self.bucket = bucket
        self.customized_endpoint = customized_endpoint
        self.domain_id = domain_id
        self.endpoint = endpoint
        self.internal_endpoint = internal_endpoint
        self.ownership = ownership
        self.policy = policy
        self.role_arn = role_arn
        self.store_id = store_id
        self.type = type

    def validate(self):
        self.validate_required(self.bucket, 'bucket')
        self.validate_required(self.domain_id, 'domain_id')
        self.validate_required(self.endpoint, 'endpoint')
        self.validate_required(self.ownership, 'ownership')
        self.validate_required(self.policy, 'policy')
        self.validate_required(self.store_id, 'store_id')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['accelerate_endpoint'] = self.accelerate_endpoint
        result['base_path'] = self.base_path
        result['bucket'] = self.bucket
        result['customized_endpoint'] = self.customized_endpoint
        result['domain_id'] = self.domain_id
        result['endpoint'] = self.endpoint
        result['internal_endpoint'] = self.internal_endpoint
        result['ownership'] = self.ownership
        result['policy'] = self.policy
        result['role_arn'] = self.role_arn
        result['store_id'] = self.store_id
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.accelerate_endpoint = map.get('accelerate_endpoint')
        self.base_path = map.get('base_path')
        self.bucket = map.get('bucket')
        self.customized_endpoint = map.get('customized_endpoint')
        self.domain_id = map.get('domain_id')
        self.endpoint = map.get('endpoint')
        self.internal_endpoint = map.get('internal_endpoint')
        self.ownership = map.get('ownership')
        self.policy = map.get('policy')
        self.role_arn = map.get('role_arn')
        self.store_id = map.get('store_id')
        self.type = map.get('type')
        return self


class AdminListStoresRequest(TeaModel):
    """
    *
    """
    def __init__(self):
        pass

    def validate(self):
        pass

    def to_map(self):
        result = {}
        return result

    def from_map(self, map={}):
        return self


class AppAccessStrategy(TeaModel):
    """
    *
    """
    def __init__(self, effect=None, except_app_id_list=None):
        self.effect = effect
        self.except_app_id_list = []

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['effect'] = self.effect
        result['except_app_id_list'] = []
        if self.except_app_id_list is not None:
            for k in self.except_app_id_list:
                result['except_app_id_list'].append(k)
        else:
            result['except_app_id_list'] = None
        return result

    def from_map(self, map={}):
        self.effect = map.get('effect')
        self.except_app_id_list = []
        if map.get('except_app_id_list') is not None:
            for k in map.get('except_app_id_list'):
                self.except_app_id_list.append(k)
        else:
            self.except_app_id_list = None
        return self


class AuthConfig(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, app_secret=None, callback_security=None, enable=None, endpoint=None, enterprise_id=None):
        self.app_id = app_id
        self.app_secret = app_secret
        self.callback_security = callback_security
        self.enable = enable
        self.endpoint = endpoint
        self.enterprise_id = enterprise_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['app_secret'] = self.app_secret
        result['callback_security'] = self.callback_security
        result['enable'] = self.enable
        result['endpoint'] = self.endpoint
        result['enterprise_id'] = self.enterprise_id
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.app_secret = map.get('app_secret')
        self.callback_security = map.get('callback_security')
        self.enable = map.get('enable')
        self.endpoint = map.get('endpoint')
        self.enterprise_id = map.get('enterprise_id')
        return self


class BaseDomainResponse(TeaModel):
    """
    base domain response
    """
    def __init__(self, auth_alipay_app_id=None, auth_alipay_enable=None, auth_alipay_private_key=None, auth_config=None, auth_dingding_app_id=None, auth_dingding_app_secret=None, auth_dingding_enable=None, auth_endpoint_enable=None, auth_ram_app_id=None, auth_ram_app_secret=None, auth_ram_enable=None, created_at=None, data_hash_name=None, description=None, domain_id=None, domain_name=None, event_filename_matches=None, event_mns_endpoint=None, event_mns_topic=None, event_names=None, event_role_arn=None, init_drive_enable=None, init_drive_size=None, init_drive_store_id=None, path_type=None, published_app_access_strategy=None, sharable=None, store_level=None, store_region_list=None, updated_at=None):
        self.auth_alipay_app_id = auth_alipay_app_id
        self.auth_alipay_enable = auth_alipay_enable
        self.auth_alipay_private_key = auth_alipay_private_key
        self.auth_config = auth_config
        self.auth_dingding_app_id = auth_dingding_app_id
        self.auth_dingding_app_secret = auth_dingding_app_secret
        self.auth_dingding_enable = auth_dingding_enable
        self.auth_endpoint_enable = auth_endpoint_enable
        self.auth_ram_app_id = auth_ram_app_id
        self.auth_ram_app_secret = auth_ram_app_secret
        self.auth_ram_enable = auth_ram_enable
        self.created_at = created_at
        self.data_hash_name = data_hash_name
        self.description = description
        self.domain_id = domain_id
        self.domain_name = domain_name
        self.event_filename_matches = event_filename_matches
        self.event_mns_endpoint = event_mns_endpoint
        self.event_mns_topic = event_mns_topic
        self.event_names = []
        self.event_role_arn = event_role_arn
        self.init_drive_enable = init_drive_enable
        self.init_drive_size = init_drive_size
        self.init_drive_store_id = init_drive_store_id
        self.path_type = path_type
        self.published_app_access_strategy = published_app_access_strategy
        self.sharable = sharable
        self.store_level = store_level
        self.store_region_list = []
        self.updated_at = updated_at

    def validate(self):
        if self.published_app_access_strategy:
            self.published_app_access_strategy.validate()

    def to_map(self):
        result = {}
        result['auth_alipay_app_id'] = self.auth_alipay_app_id
        result['auth_alipay_enable'] = self.auth_alipay_enable
        result['auth_alipay_private_key'] = self.auth_alipay_private_key
        result['auth_config'] = self.auth_config
        result['auth_dingding_app_id'] = self.auth_dingding_app_id
        result['auth_dingding_app_secret'] = self.auth_dingding_app_secret
        result['auth_dingding_enable'] = self.auth_dingding_enable
        result['auth_endpoint_enable'] = self.auth_endpoint_enable
        result['auth_ram_app_id'] = self.auth_ram_app_id
        result['auth_ram_app_secret'] = self.auth_ram_app_secret
        result['auth_ram_enable'] = self.auth_ram_enable
        result['created_at'] = self.created_at
        result['data_hash_name'] = self.data_hash_name
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['domain_name'] = self.domain_name
        result['event_filename_matches'] = self.event_filename_matches
        result['event_mns_endpoint'] = self.event_mns_endpoint
        result['event_mns_topic'] = self.event_mns_topic
        result['event_names'] = []
        if self.event_names is not None:
            for k in self.event_names:
                result['event_names'].append(k)
        else:
            result['event_names'] = None
        result['event_role_arn'] = self.event_role_arn
        result['init_drive_enable'] = self.init_drive_enable
        result['init_drive_size'] = self.init_drive_size
        result['init_drive_store_id'] = self.init_drive_store_id
        result['path_type'] = self.path_type
        if self.published_app_access_strategy is not None:
            result['published_app_access_strategy'] = self.published_app_access_strategy.to_map()
        else:
            result['published_app_access_strategy'] = None
        result['sharable'] = self.sharable
        result['store_level'] = self.store_level
        result['store_region_list'] = []
        if self.store_region_list is not None:
            for k in self.store_region_list:
                result['store_region_list'].append(k)
        else:
            result['store_region_list'] = None
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.auth_alipay_app_id = map.get('auth_alipay_app_id')
        self.auth_alipay_enable = map.get('auth_alipay_enable')
        self.auth_alipay_private_key = map.get('auth_alipay_private_key')
        self.auth_config = map.get('auth_config')
        self.auth_dingding_app_id = map.get('auth_dingding_app_id')
        self.auth_dingding_app_secret = map.get('auth_dingding_app_secret')
        self.auth_dingding_enable = map.get('auth_dingding_enable')
        self.auth_endpoint_enable = map.get('auth_endpoint_enable')
        self.auth_ram_app_id = map.get('auth_ram_app_id')
        self.auth_ram_app_secret = map.get('auth_ram_app_secret')
        self.auth_ram_enable = map.get('auth_ram_enable')
        self.created_at = map.get('created_at')
        self.data_hash_name = map.get('data_hash_name')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.domain_name = map.get('domain_name')
        self.event_filename_matches = map.get('event_filename_matches')
        self.event_mns_endpoint = map.get('event_mns_endpoint')
        self.event_mns_topic = map.get('event_mns_topic')
        self.event_names = []
        if map.get('event_names') is not None:
            for k in map.get('event_names'):
                self.event_names.append(k)
        else:
            self.event_names = None
        self.event_role_arn = map.get('event_role_arn')
        self.init_drive_enable = map.get('init_drive_enable')
        self.init_drive_size = map.get('init_drive_size')
        self.init_drive_store_id = map.get('init_drive_store_id')
        self.path_type = map.get('path_type')
        if map.get('published_app_access_strategy') is not None:
            temp_model = AppAccessStrategy()
            self.published_app_access_strategy = temp_model.from_map(map['published_app_access_strategy'])
        else:
            self.published_app_access_strategy = None
        self.sharable = map.get('sharable')
        self.store_level = map.get('store_level')
        self.store_region_list = []
        if map.get('store_region_list') is not None:
            for k in map.get('store_region_list'):
                self.store_region_list.append(k)
        else:
            self.store_region_list = None
        self.updated_at = map.get('updated_at')
        return self


class CreateDomainResponse(TeaModel):
    """
    create domain response
    """
    def __init__(self, auth_alipay_app_id=None, auth_alipay_enable=None, auth_alipay_private_key=None, auth_config=None, auth_dingding_app_id=None, auth_dingding_app_secret=None, auth_dingding_enable=None, auth_endpoint_enable=None, auth_ram_app_id=None, auth_ram_app_secret=None, auth_ram_enable=None, created_at=None, data_hash_name=None, description=None, domain_id=None, domain_name=None, event_filename_matches=None, event_mns_endpoint=None, event_mns_topic=None, event_names=None, event_role_arn=None, init_drive_enable=None, init_drive_size=None, init_drive_store_id=None, path_type=None, published_app_access_strategy=None, sharable=None, store_level=None, store_region_list=None, updated_at=None):
        self.auth_alipay_app_id = auth_alipay_app_id
        self.auth_alipay_enable = auth_alipay_enable
        self.auth_alipay_private_key = auth_alipay_private_key
        self.auth_config = auth_config
        self.auth_dingding_app_id = auth_dingding_app_id
        self.auth_dingding_app_secret = auth_dingding_app_secret
        self.auth_dingding_enable = auth_dingding_enable
        self.auth_endpoint_enable = auth_endpoint_enable
        self.auth_ram_app_id = auth_ram_app_id
        self.auth_ram_app_secret = auth_ram_app_secret
        self.auth_ram_enable = auth_ram_enable
        self.created_at = created_at
        self.data_hash_name = data_hash_name
        self.description = description
        self.domain_id = domain_id
        self.domain_name = domain_name
        self.event_filename_matches = event_filename_matches
        self.event_mns_endpoint = event_mns_endpoint
        self.event_mns_topic = event_mns_topic
        self.event_names = []
        self.event_role_arn = event_role_arn
        self.init_drive_enable = init_drive_enable
        self.init_drive_size = init_drive_size
        self.init_drive_store_id = init_drive_store_id
        self.path_type = path_type
        self.published_app_access_strategy = published_app_access_strategy
        self.sharable = sharable
        self.store_level = store_level
        self.store_region_list = []
        self.updated_at = updated_at

    def validate(self):
        if self.published_app_access_strategy:
            self.published_app_access_strategy.validate()

    def to_map(self):
        result = {}
        result['auth_alipay_app_id'] = self.auth_alipay_app_id
        result['auth_alipay_enable'] = self.auth_alipay_enable
        result['auth_alipay_private_key'] = self.auth_alipay_private_key
        result['auth_config'] = self.auth_config
        result['auth_dingding_app_id'] = self.auth_dingding_app_id
        result['auth_dingding_app_secret'] = self.auth_dingding_app_secret
        result['auth_dingding_enable'] = self.auth_dingding_enable
        result['auth_endpoint_enable'] = self.auth_endpoint_enable
        result['auth_ram_app_id'] = self.auth_ram_app_id
        result['auth_ram_app_secret'] = self.auth_ram_app_secret
        result['auth_ram_enable'] = self.auth_ram_enable
        result['created_at'] = self.created_at
        result['data_hash_name'] = self.data_hash_name
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['domain_name'] = self.domain_name
        result['event_filename_matches'] = self.event_filename_matches
        result['event_mns_endpoint'] = self.event_mns_endpoint
        result['event_mns_topic'] = self.event_mns_topic
        result['event_names'] = []
        if self.event_names is not None:
            for k in self.event_names:
                result['event_names'].append(k)
        else:
            result['event_names'] = None
        result['event_role_arn'] = self.event_role_arn
        result['init_drive_enable'] = self.init_drive_enable
        result['init_drive_size'] = self.init_drive_size
        result['init_drive_store_id'] = self.init_drive_store_id
        result['path_type'] = self.path_type
        if self.published_app_access_strategy is not None:
            result['published_app_access_strategy'] = self.published_app_access_strategy.to_map()
        else:
            result['published_app_access_strategy'] = None
        result['sharable'] = self.sharable
        result['store_level'] = self.store_level
        result['store_region_list'] = []
        if self.store_region_list is not None:
            for k in self.store_region_list:
                result['store_region_list'].append(k)
        else:
            result['store_region_list'] = None
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.auth_alipay_app_id = map.get('auth_alipay_app_id')
        self.auth_alipay_enable = map.get('auth_alipay_enable')
        self.auth_alipay_private_key = map.get('auth_alipay_private_key')
        self.auth_config = map.get('auth_config')
        self.auth_dingding_app_id = map.get('auth_dingding_app_id')
        self.auth_dingding_app_secret = map.get('auth_dingding_app_secret')
        self.auth_dingding_enable = map.get('auth_dingding_enable')
        self.auth_endpoint_enable = map.get('auth_endpoint_enable')
        self.auth_ram_app_id = map.get('auth_ram_app_id')
        self.auth_ram_app_secret = map.get('auth_ram_app_secret')
        self.auth_ram_enable = map.get('auth_ram_enable')
        self.created_at = map.get('created_at')
        self.data_hash_name = map.get('data_hash_name')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.domain_name = map.get('domain_name')
        self.event_filename_matches = map.get('event_filename_matches')
        self.event_mns_endpoint = map.get('event_mns_endpoint')
        self.event_mns_topic = map.get('event_mns_topic')
        self.event_names = []
        if map.get('event_names') is not None:
            for k in map.get('event_names'):
                self.event_names.append(k)
        else:
            self.event_names = None
        self.event_role_arn = map.get('event_role_arn')
        self.init_drive_enable = map.get('init_drive_enable')
        self.init_drive_size = map.get('init_drive_size')
        self.init_drive_store_id = map.get('init_drive_store_id')
        self.path_type = map.get('path_type')
        if map.get('published_app_access_strategy') is not None:
            temp_model = AppAccessStrategy()
            self.published_app_access_strategy = temp_model.from_map(map['published_app_access_strategy'])
        else:
            self.published_app_access_strategy = None
        self.sharable = map.get('sharable')
        self.store_level = map.get('store_level')
        self.store_region_list = []
        if map.get('store_region_list') is not None:
            for k in map.get('store_region_list'):
                self.store_region_list.append(k)
        else:
            self.store_region_list = None
        self.updated_at = map.get('updated_at')
        return self


class GetAppPublicKeyResponse(TeaModel):
    """
    *
    """
    def __init__(self, app_id=None, public_key=None):
        self.app_id = app_id
        self.public_key = public_key

    def validate(self):
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.public_key, 'public_key')

    def to_map(self):
        result = {}
        result['app_id'] = self.app_id
        result['public_key'] = self.public_key
        return result

    def from_map(self, map={}):
        self.app_id = map.get('app_id')
        self.public_key = map.get('public_key')
        return self


class GetAppResponse(TeaModel):
    """
    *
    """
    def __init__(self, ali_owner_id=None, app_id=None, app_name=None, app_secret=None, created_at=None, description=None, logo=None, provider=None, redirect_uri=None, scope=None, screenshots=None, stage=None, type=None, updated_at=None):
        self.ali_owner_id = ali_owner_id
        self.app_id = app_id
        self.app_name = app_name
        self.app_secret = app_secret
        self.created_at = created_at
        self.description = description
        self.logo = logo
        self.provider = provider
        self.redirect_uri = redirect_uri
        self.scope = []
        self.screenshots = []
        self.stage = stage
        self.type = type
        self.updated_at = updated_at

    def validate(self):
        self.validate_required(self.ali_owner_id, 'ali_owner_id')
        self.validate_required(self.app_id, 'app_id')
        self.validate_required(self.app_name, 'app_name')
        if self.app_name:
            self.validate_pattern(self.app_name, 'app_name', '[0-9a-zA-Z]+')
        self.validate_required(self.app_secret, 'app_secret')
        self.validate_required(self.created_at, 'created_at')
        self.validate_required(self.description, 'description')
        if self.description:
            self.validate_max_length(self.description, 'description', 128)
        self.validate_required(self.logo, 'logo')
        self.validate_required(self.provider, 'provider')
        self.validate_required(self.redirect_uri, 'redirect_uri')
        self.validate_required(self.scope, 'scope')
        self.validate_required(self.screenshots, 'screenshots')
        self.validate_required(self.stage, 'stage')
        self.validate_required(self.type, 'type')
        self.validate_required(self.updated_at, 'updated_at')

    def to_map(self):
        result = {}
        result['ali_owner_id'] = self.ali_owner_id
        result['app_id'] = self.app_id
        result['app_name'] = self.app_name
        result['app_secret'] = self.app_secret
        result['created_at'] = self.created_at
        result['description'] = self.description
        result['logo'] = self.logo
        result['provider'] = self.provider
        result['redirect_uri'] = self.redirect_uri
        result['scope'] = []
        if self.scope is not None:
            for k in self.scope:
                result['scope'].append(k)
        else:
            result['scope'] = None
        result['screenshots'] = []
        if self.screenshots is not None:
            for k in self.screenshots:
                result['screenshots'].append(k)
        else:
            result['screenshots'] = None
        result['stage'] = self.stage
        result['type'] = self.type
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.ali_owner_id = map.get('ali_owner_id')
        self.app_id = map.get('app_id')
        self.app_name = map.get('app_name')
        self.app_secret = map.get('app_secret')
        self.created_at = map.get('created_at')
        self.description = map.get('description')
        self.logo = map.get('logo')
        self.provider = map.get('provider')
        self.redirect_uri = map.get('redirect_uri')
        self.scope = []
        if map.get('scope') is not None:
            for k in map.get('scope'):
                self.scope.append(k)
        else:
            self.scope = None
        self.screenshots = []
        if map.get('screenshots') is not None:
            for k in map.get('screenshots'):
                self.screenshots.append(k)
        else:
            self.screenshots = None
        self.stage = map.get('stage')
        self.type = map.get('type')
        self.updated_at = map.get('updated_at')
        return self


class GetDomainResponse(TeaModel):
    """
    get domain response
    """
    def __init__(self, auth_alipay_app_id=None, auth_alipay_enable=None, auth_alipay_private_key=None, auth_config=None, auth_dingding_app_id=None, auth_dingding_app_secret=None, auth_dingding_enable=None, auth_endpoint_enable=None, auth_ram_app_id=None, auth_ram_app_secret=None, auth_ram_enable=None, created_at=None, data_hash_name=None, description=None, domain_id=None, domain_name=None, event_filename_matches=None, event_mns_endpoint=None, event_mns_topic=None, event_names=None, event_role_arn=None, init_drive_enable=None, init_drive_size=None, init_drive_store_id=None, path_type=None, published_app_access_strategy=None, sharable=None, store_level=None, store_region_list=None, updated_at=None):
        self.auth_alipay_app_id = auth_alipay_app_id
        self.auth_alipay_enable = auth_alipay_enable
        self.auth_alipay_private_key = auth_alipay_private_key
        self.auth_config = auth_config
        self.auth_dingding_app_id = auth_dingding_app_id
        self.auth_dingding_app_secret = auth_dingding_app_secret
        self.auth_dingding_enable = auth_dingding_enable
        self.auth_endpoint_enable = auth_endpoint_enable
        self.auth_ram_app_id = auth_ram_app_id
        self.auth_ram_app_secret = auth_ram_app_secret
        self.auth_ram_enable = auth_ram_enable
        self.created_at = created_at
        self.data_hash_name = data_hash_name
        self.description = description
        self.domain_id = domain_id
        self.domain_name = domain_name
        self.event_filename_matches = event_filename_matches
        self.event_mns_endpoint = event_mns_endpoint
        self.event_mns_topic = event_mns_topic
        self.event_names = []
        self.event_role_arn = event_role_arn
        self.init_drive_enable = init_drive_enable
        self.init_drive_size = init_drive_size
        self.init_drive_store_id = init_drive_store_id
        self.path_type = path_type
        self.published_app_access_strategy = published_app_access_strategy
        self.sharable = sharable
        self.store_level = store_level
        self.store_region_list = []
        self.updated_at = updated_at

    def validate(self):
        if self.published_app_access_strategy:
            self.published_app_access_strategy.validate()

    def to_map(self):
        result = {}
        result['auth_alipay_app_id'] = self.auth_alipay_app_id
        result['auth_alipay_enable'] = self.auth_alipay_enable
        result['auth_alipay_private_key'] = self.auth_alipay_private_key
        result['auth_config'] = self.auth_config
        result['auth_dingding_app_id'] = self.auth_dingding_app_id
        result['auth_dingding_app_secret'] = self.auth_dingding_app_secret
        result['auth_dingding_enable'] = self.auth_dingding_enable
        result['auth_endpoint_enable'] = self.auth_endpoint_enable
        result['auth_ram_app_id'] = self.auth_ram_app_id
        result['auth_ram_app_secret'] = self.auth_ram_app_secret
        result['auth_ram_enable'] = self.auth_ram_enable
        result['created_at'] = self.created_at
        result['data_hash_name'] = self.data_hash_name
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['domain_name'] = self.domain_name
        result['event_filename_matches'] = self.event_filename_matches
        result['event_mns_endpoint'] = self.event_mns_endpoint
        result['event_mns_topic'] = self.event_mns_topic
        result['event_names'] = []
        if self.event_names is not None:
            for k in self.event_names:
                result['event_names'].append(k)
        else:
            result['event_names'] = None
        result['event_role_arn'] = self.event_role_arn
        result['init_drive_enable'] = self.init_drive_enable
        result['init_drive_size'] = self.init_drive_size
        result['init_drive_store_id'] = self.init_drive_store_id
        result['path_type'] = self.path_type
        if self.published_app_access_strategy is not None:
            result['published_app_access_strategy'] = self.published_app_access_strategy.to_map()
        else:
            result['published_app_access_strategy'] = None
        result['sharable'] = self.sharable
        result['store_level'] = self.store_level
        result['store_region_list'] = []
        if self.store_region_list is not None:
            for k in self.store_region_list:
                result['store_region_list'].append(k)
        else:
            result['store_region_list'] = None
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.auth_alipay_app_id = map.get('auth_alipay_app_id')
        self.auth_alipay_enable = map.get('auth_alipay_enable')
        self.auth_alipay_private_key = map.get('auth_alipay_private_key')
        self.auth_config = map.get('auth_config')
        self.auth_dingding_app_id = map.get('auth_dingding_app_id')
        self.auth_dingding_app_secret = map.get('auth_dingding_app_secret')
        self.auth_dingding_enable = map.get('auth_dingding_enable')
        self.auth_endpoint_enable = map.get('auth_endpoint_enable')
        self.auth_ram_app_id = map.get('auth_ram_app_id')
        self.auth_ram_app_secret = map.get('auth_ram_app_secret')
        self.auth_ram_enable = map.get('auth_ram_enable')
        self.created_at = map.get('created_at')
        self.data_hash_name = map.get('data_hash_name')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.domain_name = map.get('domain_name')
        self.event_filename_matches = map.get('event_filename_matches')
        self.event_mns_endpoint = map.get('event_mns_endpoint')
        self.event_mns_topic = map.get('event_mns_topic')
        self.event_names = []
        if map.get('event_names') is not None:
            for k in map.get('event_names'):
                self.event_names.append(k)
        else:
            self.event_names = None
        self.event_role_arn = map.get('event_role_arn')
        self.init_drive_enable = map.get('init_drive_enable')
        self.init_drive_size = map.get('init_drive_size')
        self.init_drive_store_id = map.get('init_drive_store_id')
        self.path_type = map.get('path_type')
        if map.get('published_app_access_strategy') is not None:
            temp_model = AppAccessStrategy()
            self.published_app_access_strategy = temp_model.from_map(map['published_app_access_strategy'])
        else:
            self.published_app_access_strategy = None
        self.sharable = map.get('sharable')
        self.store_level = map.get('store_level')
        self.store_region_list = []
        if map.get('store_region_list') is not None:
            for k in map.get('store_region_list'):
                self.store_region_list.append(k)
        else:
            self.store_region_list = None
        self.updated_at = map.get('updated_at')
        return self


class GetUserAccessTokenRequest(TeaModel):
    """
    *
    """
    def __init__(self, role=None, user_id=None):
        self.role = role
        self.user_id = user_id

    def validate(self):
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['role'] = self.role
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.role = map.get('role')
        self.user_id = map.get('user_id')
        return self


class ListAppsResponse(TeaModel):
    """
    *
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        self.validate_required(self.items, 'items')
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = GetAppResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class ListDomainCORSRuleResponse(TeaModel):
    """
    list domain cors response
    """
    def __init__(self, cors_rule_list=None, domain_id=None):
        self.cors_rule_list = []
        self.domain_id = domain_id

    def validate(self):
        if self.cors_rule_list:
            for k in self.cors_rule_list:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['cors_rule_list'] = []
        if self.cors_rule_list is not None:
            for k in self.cors_rule_list:
                result['cors_rule_list'].append(k.to_map() if k else None)
        else:
            result['cors_rule_list'] = None
        result['domain_id'] = self.domain_id
        return result

    def from_map(self, map={}):
        self.cors_rule_list = []
        if map.get('cors_rule_list') is not None:
            for k in map.get('cors_rule_list'):
                temp_model = CorsRule()
                temp_model = temp_model.from_map(k)
                self.cors_rule_list.append(temp_model)
        else:
            self.cors_rule_list = None
        self.domain_id = map.get('domain_id')
        return self


class ListDomainsResponse(TeaModel):
    """
    list domain response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseDomainResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class ListStoresResponse(TeaModel):
    """
    *
    """
    def __init__(self, items=None):
        self.items = []

    def validate(self):
        self.validate_required(self.items, 'items')
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = Store()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        return self


class Store(TeaModel):
    """
    *
    """
    def __init__(self, accelerate_endpoint=None, base_path=None, bucket=None, customized_endpoint=None, endpoint=None, internal_endpoint=None, ownership=None, policy=None, role_arn=None, store_id=None, type=None):
        self.accelerate_endpoint = accelerate_endpoint
        self.base_path = base_path
        self.bucket = bucket
        self.customized_endpoint = customized_endpoint
        self.endpoint = endpoint
        self.internal_endpoint = internal_endpoint
        self.ownership = ownership
        self.policy = policy
        self.role_arn = role_arn
        self.store_id = store_id
        self.type = type

    def validate(self):
        self.validate_required(self.bucket, 'bucket')
        self.validate_required(self.endpoint, 'endpoint')
        self.validate_required(self.ownership, 'ownership')
        self.validate_required(self.policy, 'policy')
        self.validate_required(self.store_id, 'store_id')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['accelerate_endpoint'] = self.accelerate_endpoint
        result['base_path'] = self.base_path
        result['bucket'] = self.bucket
        result['customized_endpoint'] = self.customized_endpoint
        result['endpoint'] = self.endpoint
        result['internal_endpoint'] = self.internal_endpoint
        result['ownership'] = self.ownership
        result['policy'] = self.policy
        result['role_arn'] = self.role_arn
        result['store_id'] = self.store_id
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.accelerate_endpoint = map.get('accelerate_endpoint')
        self.base_path = map.get('base_path')
        self.bucket = map.get('bucket')
        self.customized_endpoint = map.get('customized_endpoint')
        self.endpoint = map.get('endpoint')
        self.internal_endpoint = map.get('internal_endpoint')
        self.ownership = map.get('ownership')
        self.policy = map.get('policy')
        self.role_arn = map.get('role_arn')
        self.store_id = map.get('store_id')
        self.type = map.get('type')
        return self


class UpdateDomainResponse(TeaModel):
    """
    create domain response
    """
    def __init__(self, auth_alipay_app_id=None, auth_alipay_enable=None, auth_alipay_private_key=None, auth_config=None, auth_dingding_app_id=None, auth_dingding_app_secret=None, auth_dingding_enable=None, auth_endpoint_enable=None, auth_ram_app_id=None, auth_ram_app_secret=None, auth_ram_enable=None, created_at=None, data_hash_name=None, description=None, domain_id=None, domain_name=None, event_filename_matches=None, event_mns_endpoint=None, event_mns_topic=None, event_names=None, event_role_arn=None, init_drive_enable=None, init_drive_size=None, init_drive_store_id=None, path_type=None, published_app_access_strategy=None, sharable=None, store_level=None, store_region_list=None, updated_at=None):
        self.auth_alipay_app_id = auth_alipay_app_id
        self.auth_alipay_enable = auth_alipay_enable
        self.auth_alipay_private_key = auth_alipay_private_key
        self.auth_config = auth_config
        self.auth_dingding_app_id = auth_dingding_app_id
        self.auth_dingding_app_secret = auth_dingding_app_secret
        self.auth_dingding_enable = auth_dingding_enable
        self.auth_endpoint_enable = auth_endpoint_enable
        self.auth_ram_app_id = auth_ram_app_id
        self.auth_ram_app_secret = auth_ram_app_secret
        self.auth_ram_enable = auth_ram_enable
        self.created_at = created_at
        self.data_hash_name = data_hash_name
        self.description = description
        self.domain_id = domain_id
        self.domain_name = domain_name
        self.event_filename_matches = event_filename_matches
        self.event_mns_endpoint = event_mns_endpoint
        self.event_mns_topic = event_mns_topic
        self.event_names = []
        self.event_role_arn = event_role_arn
        self.init_drive_enable = init_drive_enable
        self.init_drive_size = init_drive_size
        self.init_drive_store_id = init_drive_store_id
        self.path_type = path_type
        self.published_app_access_strategy = published_app_access_strategy
        self.sharable = sharable
        self.store_level = store_level
        self.store_region_list = []
        self.updated_at = updated_at

    def validate(self):
        if self.published_app_access_strategy:
            self.published_app_access_strategy.validate()

    def to_map(self):
        result = {}
        result['auth_alipay_app_id'] = self.auth_alipay_app_id
        result['auth_alipay_enable'] = self.auth_alipay_enable
        result['auth_alipay_private_key'] = self.auth_alipay_private_key
        result['auth_config'] = self.auth_config
        result['auth_dingding_app_id'] = self.auth_dingding_app_id
        result['auth_dingding_app_secret'] = self.auth_dingding_app_secret
        result['auth_dingding_enable'] = self.auth_dingding_enable
        result['auth_endpoint_enable'] = self.auth_endpoint_enable
        result['auth_ram_app_id'] = self.auth_ram_app_id
        result['auth_ram_app_secret'] = self.auth_ram_app_secret
        result['auth_ram_enable'] = self.auth_ram_enable
        result['created_at'] = self.created_at
        result['data_hash_name'] = self.data_hash_name
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['domain_name'] = self.domain_name
        result['event_filename_matches'] = self.event_filename_matches
        result['event_mns_endpoint'] = self.event_mns_endpoint
        result['event_mns_topic'] = self.event_mns_topic
        result['event_names'] = []
        if self.event_names is not None:
            for k in self.event_names:
                result['event_names'].append(k)
        else:
            result['event_names'] = None
        result['event_role_arn'] = self.event_role_arn
        result['init_drive_enable'] = self.init_drive_enable
        result['init_drive_size'] = self.init_drive_size
        result['init_drive_store_id'] = self.init_drive_store_id
        result['path_type'] = self.path_type
        if self.published_app_access_strategy is not None:
            result['published_app_access_strategy'] = self.published_app_access_strategy.to_map()
        else:
            result['published_app_access_strategy'] = None
        result['sharable'] = self.sharable
        result['store_level'] = self.store_level
        result['store_region_list'] = []
        if self.store_region_list is not None:
            for k in self.store_region_list:
                result['store_region_list'].append(k)
        else:
            result['store_region_list'] = None
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.auth_alipay_app_id = map.get('auth_alipay_app_id')
        self.auth_alipay_enable = map.get('auth_alipay_enable')
        self.auth_alipay_private_key = map.get('auth_alipay_private_key')
        self.auth_config = map.get('auth_config')
        self.auth_dingding_app_id = map.get('auth_dingding_app_id')
        self.auth_dingding_app_secret = map.get('auth_dingding_app_secret')
        self.auth_dingding_enable = map.get('auth_dingding_enable')
        self.auth_endpoint_enable = map.get('auth_endpoint_enable')
        self.auth_ram_app_id = map.get('auth_ram_app_id')
        self.auth_ram_app_secret = map.get('auth_ram_app_secret')
        self.auth_ram_enable = map.get('auth_ram_enable')
        self.created_at = map.get('created_at')
        self.data_hash_name = map.get('data_hash_name')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.domain_name = map.get('domain_name')
        self.event_filename_matches = map.get('event_filename_matches')
        self.event_mns_endpoint = map.get('event_mns_endpoint')
        self.event_mns_topic = map.get('event_mns_topic')
        self.event_names = []
        if map.get('event_names') is not None:
            for k in map.get('event_names'):
                self.event_names.append(k)
        else:
            self.event_names = None
        self.event_role_arn = map.get('event_role_arn')
        self.init_drive_enable = map.get('init_drive_enable')
        self.init_drive_size = map.get('init_drive_size')
        self.init_drive_store_id = map.get('init_drive_store_id')
        self.path_type = map.get('path_type')
        if map.get('published_app_access_strategy') is not None:
            temp_model = AppAccessStrategy()
            self.published_app_access_strategy = temp_model.from_map(map['published_app_access_strategy'])
        else:
            self.published_app_access_strategy = None
        self.sharable = map.get('sharable')
        self.store_level = map.get('store_level')
        self.store_region_list = []
        if map.get('store_region_list') is not None:
            for k in map.get('store_region_list'):
                self.store_region_list.append(k)
        else:
            self.store_region_list = None
        self.updated_at = map.get('updated_at')
        return self


class GetAsyncTaskInfoRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetAsyncTaskRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetAsyncTaskInfoModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetAsyncTaskResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class BatchOperationRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPBatchRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class BatchOperationModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPBatchResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CreateDriveRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CreateDriveRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CreateDriveModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CreateDriveResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class DeleteDriveRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = DeleteDriveRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class DeleteDriveModel(TeaModel):
    def __init__(self, headers=None):
        self.headers = {}

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        return self


class GetDriveRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetDriveRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetDriveModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetDriveResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetDefaultDriveRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetDefaultDriveRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetDefaultDriveModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetDriveResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListDrivesRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListDriveRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListDrivesModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListDriveResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListMyDrivesRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListMyDriveRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListMyDrivesModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListDriveResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class UpdateDriveRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = UpdateDriveRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class UpdateDriveModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = UpdateDriveResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CompleteFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPCompleteFileRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CompleteFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPCompleteFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CopyFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPCopyFileRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CopyFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPCopyFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CreateFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPCreateFileRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CreateFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPCreateFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class DeleteFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPDeleteFileRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class DeleteFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPDeleteFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class DownloadFileQuery(TeaModel):
    def __init__(self, drive_id=None, file_id=None, image_thumbnail_process=None, video_thumbnail_process=None):
        self.drive_id = drive_id
        self.file_id = file_id
        self.image_thumbnail_process = image_thumbnail_process
        self.video_thumbnail_process = video_thumbnail_process

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        self.validate_required(self.file_id, 'file_id')

    def to_map(self):
        result = {}
        result['DriveID'] = self.drive_id
        result['FileID'] = self.file_id
        result['ImageThumbnailProcess'] = self.image_thumbnail_process
        result['VideoThumbnailProcess'] = self.video_thumbnail_process
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('DriveID')
        self.file_id = map.get('FileID')
        self.image_thumbnail_process = map.get('ImageThumbnailProcess')
        self.video_thumbnail_process = map.get('VideoThumbnailProcess')
        return self


class DownloadFileRequestModel(TeaModel):
    def __init__(self, headers=None, query=None):
        self.headers = {}
        self.query = query

    def validate(self):
        self.validate_required(self.query, 'query')
        if self.query:
            self.query.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.query is not None:
            result['query'] = self.query.to_map()
        else:
            result['query'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('query') is not None:
            temp_model = DownloadFileQuery()
            self.query = temp_model.from_map(map['query'])
        else:
            self.query = None
        return self


class DownloadFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetDownloadUrlRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetFileRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetFileByPathRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetFileByPathRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetFileByPathModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetFileByPathResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetDownloadUrlRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetDownloadUrlRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetDownloadUrlModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetDownloadUrlResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetLastCursorRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetLastCursorRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetLastCursorModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetLastCursorResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetUploadUrlRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetUploadUrlRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetUploadUrlModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetUploadUrlResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetVideoPreviewSpriteUrlRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetVideoPreviewSpriteURLRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetVideoPreviewSpriteUrlModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetVideoPreviewSpriteURLResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetVideoPreviewUrlRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetVideoPreviewURLRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetVideoPreviewUrlModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPGetVideoPreviewURLResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPListFileRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPListFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListFileByCustomIndexKeyRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPListFileByCustomIndexKeyRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListFileByCustomIndexKeyModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPListFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListFileDeltaRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListFileDeltaRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListFileDeltaModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListFileDeltaResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListUploadedPartsRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPListUploadedPartRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListUploadedPartsModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPListUploadedPartResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class MoveFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPMoveFileRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class MoveFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPMoveFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ScanFileMetaRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPScanFileMetaRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ScanFileMetaModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPScanFileMetaResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class SearchFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPSearchFileRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class SearchFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPSearchFileResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class UpdateFileRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPUpdateFileMetaRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class UpdateFileModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CCPUpdateFileMetaResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class BaseCompleteFileRequest(TeaModel):
    """
    complete file request
    """
    def __init__(self, drive_id=None, part_info_list=None, upload_id=None):
        self.drive_id = drive_id
        self.part_info_list = []
        self.upload_id = upload_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.upload_id = map.get('upload_id')
        return self


class BaseCreateFileRequest(TeaModel):
    """
    create file request
    """
    def __init__(self, content_md_5=None, content_type=None, name=None, part_info_list=None, size=None, type=None):
        self.content_md_5 = content_md_5
        self.content_type = content_type
        self.name = name
        self.part_info_list = []
        self.size = size
        self.type = type

    def validate(self):
        self.validate_required(self.content_md_5, 'content_md_5')
        self.validate_required(self.content_type, 'content_type')
        self.validate_required(self.name, 'name')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        self.validate_required(self.size, 'size')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['content_md5'] = self.content_md_5
        result['content_type'] = self.content_type
        result['name'] = self.name
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['size'] = self.size
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.content_md_5 = map.get('content_md5')
        self.content_type = map.get('content_type')
        self.name = map.get('name')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.size = map.get('size')
        self.type = map.get('type')
        return self


class BaseGetUploadUrlRequest(TeaModel):
    """
    获取文件上传URL
    """
    def __init__(self, content_md_5=None, drive_id=None, part_info_list=None, upload_id=None):
        self.content_md_5 = content_md_5
        self.drive_id = drive_id
        self.part_info_list = []
        self.upload_id = upload_id

    def validate(self):
        if self.content_md_5:
            self.validate_max_length(self.content_md_5, 'content_md_5', 32)
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = {}
        result['content_md5'] = self.content_md_5
        result['drive_id'] = self.drive_id
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.content_md_5 = map.get('content_md5')
        self.drive_id = map.get('drive_id')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.upload_id = map.get('upload_id')
        return self


class BaseListFileRequest(TeaModel):
    """
    list file request
    """
    def __init__(self, drive_id=None, image_thumbnail_process=None, image_url_process=None, limit=None, marker=None, video_thumbnail_process=None):
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.limit = limit
        self.marker = marker
        self.video_thumbnail_process = video_thumbnail_process

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.limit:
            self.validate_pattern(self.limit, 'limit', '[0-9]{1,3}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['video_thumbnail_process'] = self.video_thumbnail_process
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.video_thumbnail_process = map.get('video_thumbnail_process')
        return self


class BaseMoveFileRequest(TeaModel):
    """
    文件移动请求
    """
    def __init__(self, drive_id=None, new_name=None, overwrite=None):
        self.drive_id = drive_id
        self.new_name = new_name
        self.overwrite = overwrite

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['new_name'] = self.new_name
        result['overwrite'] = self.overwrite
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.new_name = map.get('new_name')
        self.overwrite = map.get('overwrite')
        return self


class BatchSubRequest(TeaModel):
    """
    *
    """
    def __init__(self, body=None, headers=None, id=None, method=None, url=None):
        self.body = body
        self.headers = headers
        self.id = id
        self.method = method
        self.url = url

    def validate(self):
        self.validate_required(self.id, 'id')
        self.validate_required(self.method, 'method')
        self.validate_required(self.url, 'url')

    def to_map(self):
        result = {}
        result['body'] = self.body
        result['headers'] = self.headers
        result['id'] = self.id
        result['method'] = self.method
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.body = map.get('body')
        self.headers = map.get('headers')
        self.id = map.get('id')
        self.method = map.get('method')
        self.url = map.get('url')
        return self


class CCPBatchRequest(TeaModel):
    """
    批处理
    """
    def __init__(self, requests=None, resource=None):
        self.requests = []
        self.resource = resource

    def validate(self):
        self.validate_required(self.requests, 'requests')
        if self.requests:
            for k in self.requests:
                if k :
                    k.validate()
        self.validate_required(self.resource, 'resource')

    def to_map(self):
        result = {}
        result['requests'] = []
        if self.requests is not None:
            for k in self.requests:
                result['requests'].append(k.to_map() if k else None)
        else:
            result['requests'] = None
        result['resource'] = self.resource
        return result

    def from_map(self, map={}):
        self.requests = []
        if map.get('requests') is not None:
            for k in map.get('requests'):
                temp_model = BatchSubRequest()
                temp_model = temp_model.from_map(k)
                self.requests.append(temp_model)
        else:
            self.requests = None
        self.resource = map.get('resource')
        return self


class CCPCompleteFileRequest(TeaModel):
    """
    合并文件上传任务
    """
    def __init__(self, drive_id=None, part_info_list=None, upload_id=None, file_id=None):
        self.drive_id = drive_id
        self.part_info_list = []
        self.upload_id = upload_id
        self.file_id = file_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['upload_id'] = self.upload_id
        result['file_id'] = self.file_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.upload_id = map.get('upload_id')
        self.file_id = map.get('file_id')
        return self


class CCPCopyFileRequest(TeaModel):
    """
    文件拷贝
    """
    def __init__(self, auto_rename=None, drive_id=None, file_id=None, new_name=None, to_drive_id=None, to_parent_file_id=None):
        self.auto_rename = auto_rename
        self.drive_id = drive_id
        self.file_id = file_id
        self.new_name = new_name
        self.to_drive_id = to_drive_id
        self.to_parent_file_id = to_parent_file_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')
        if self.to_drive_id:
            self.validate_pattern(self.to_drive_id, 'to_drive_id', '[0-9]+')
        self.validate_required(self.to_parent_file_id, 'to_parent_file_id')
        if self.to_parent_file_id:
            self.validate_pattern(self.to_parent_file_id, 'to_parent_file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['auto_rename'] = self.auto_rename
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['new_name'] = self.new_name
        result['to_drive_id'] = self.to_drive_id
        result['to_parent_file_id'] = self.to_parent_file_id
        return result

    def from_map(self, map={}):
        self.auto_rename = map.get('auto_rename')
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.new_name = map.get('new_name')
        self.to_drive_id = map.get('to_drive_id')
        self.to_parent_file_id = map.get('to_parent_file_id')
        return self


class CCPCreateFileRequest(TeaModel):
    """
    创建文件
    """
    def __init__(self, content_md_5=None, content_type=None, name=None, part_info_list=None, size=None, type=None, auto_rename=None, check_name_mode=None, content_hash=None, content_hash_name=None, description=None, drive_id=None, encrypt_mode=None, file_id=None, hidden=None, image_media_metadata=None, labels=None, last_updated_at=None, meta=None, parent_file_id=None, pre_hash=None, streams_info=None, user_meta=None, video_media_metadata=None):
        self.content_md_5 = content_md_5
        self.content_type = content_type
        self.name = name
        self.part_info_list = []
        self.size = size
        self.type = type
        self.auto_rename = auto_rename
        self.check_name_mode = check_name_mode
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.description = description
        self.drive_id = drive_id
        self.encrypt_mode = encrypt_mode
        self.file_id = file_id
        self.hidden = hidden
        self.image_media_metadata = image_media_metadata
        self.labels = []
        self.last_updated_at = last_updated_at
        self.meta = meta
        self.parent_file_id = parent_file_id
        self.pre_hash = pre_hash
        self.streams_info = streams_info
        self.user_meta = user_meta
        self.video_media_metadata = video_media_metadata

    def validate(self):
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        if self.description:
            self.validate_max_length(self.description, 'description', 0)
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.image_media_metadata:
            self.image_media_metadata.validate()
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')
        if self.video_media_metadata:
            self.video_media_metadata.validate()

    def to_map(self):
        result = {}
        result['content_md5'] = self.content_md_5
        result['content_type'] = self.content_type
        result['name'] = self.name
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['size'] = self.size
        result['type'] = self.type
        result['auto_rename'] = self.auto_rename
        result['check_name_mode'] = self.check_name_mode
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['description'] = self.description
        result['drive_id'] = self.drive_id
        result['encrypt_mode'] = self.encrypt_mode
        result['file_id'] = self.file_id
        result['hidden'] = self.hidden
        if self.image_media_metadata is not None:
            result['image_media_metadata'] = self.image_media_metadata.to_map()
        else:
            result['image_media_metadata'] = None
        result['labels'] = []
        if self.labels is not None:
            for k in self.labels:
                result['labels'].append(k)
        else:
            result['labels'] = None
        result['last_updated_at'] = self.last_updated_at
        result['meta'] = self.meta
        result['parent_file_id'] = self.parent_file_id
        result['pre_hash'] = self.pre_hash
        result['streams_info'] = self.streams_info
        result['user_meta'] = self.user_meta
        if self.video_media_metadata is not None:
            result['video_media_metadata'] = self.video_media_metadata.to_map()
        else:
            result['video_media_metadata'] = None
        return result

    def from_map(self, map={}):
        self.content_md_5 = map.get('content_md5')
        self.content_type = map.get('content_type')
        self.name = map.get('name')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.size = map.get('size')
        self.type = map.get('type')
        self.auto_rename = map.get('auto_rename')
        self.check_name_mode = map.get('check_name_mode')
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.description = map.get('description')
        self.drive_id = map.get('drive_id')
        self.encrypt_mode = map.get('encrypt_mode')
        self.file_id = map.get('file_id')
        self.hidden = map.get('hidden')
        if map.get('image_media_metadata') is not None:
            temp_model = ImageMediaMetadata()
            self.image_media_metadata = temp_model.from_map(map['image_media_metadata'])
        else:
            self.image_media_metadata = None
        self.labels = []
        if map.get('labels') is not None:
            for k in map.get('labels'):
                self.labels.append(k)
        else:
            self.labels = None
        self.last_updated_at = map.get('last_updated_at')
        self.meta = map.get('meta')
        self.parent_file_id = map.get('parent_file_id')
        self.pre_hash = map.get('pre_hash')
        self.streams_info = map.get('streams_info')
        self.user_meta = map.get('user_meta')
        if map.get('video_media_metadata') is not None:
            temp_model = VideoMediaMetadata()
            self.video_media_metadata = temp_model.from_map(map['video_media_metadata'])
        else:
            self.video_media_metadata = None
        return self


class CCPDeleteFileRequest(TeaModel):
    """
    删除文件请求
    """
    def __init__(self, drive_id=None, file_id=None, permanently=None):
        self.drive_id = drive_id
        self.file_id = file_id
        self.permanently = permanently

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['permanently'] = self.permanently
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.permanently = map.get('permanently')
        return self


class CCPDeleteFilesRequest(TeaModel):
    """
    批量删除文件请求
    """
    def __init__(self, drive_id=None, file_id_list=None):
        self.drive_id = drive_id
        self.file_id_list = []

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id_list, 'file_id_list')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_id_list'] = []
        if self.file_id_list is not None:
            for k in self.file_id_list:
                result['file_id_list'].append(k)
        else:
            result['file_id_list'] = None
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_id_list = []
        if map.get('file_id_list') is not None:
            for k in map.get('file_id_list'):
                self.file_id_list.append(k)
        else:
            self.file_id_list = None
        return self


class CCPGetAsyncTaskRequest(TeaModel):
    """
    获取异步人去信息
    """
    def __init__(self, async_task_id=None):
        self.async_task_id = async_task_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        return self


class CCPGetDownloadUrlRequest(TeaModel):
    """
    获取文件下载地址的请求body
    """
    def __init__(self, drive_id=None, expire_sec=None, file_id=None, file_name=None):
        self.drive_id = drive_id
        self.expire_sec = expire_sec
        self.file_id = file_id
        self.file_name = file_name

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')
        if self.file_name:
            self.validate_max_length(self.file_name, 'file_name', 1024)

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['expire_sec'] = self.expire_sec
        result['file_id'] = self.file_id
        result['file_name'] = self.file_name
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.expire_sec = map.get('expire_sec')
        self.file_id = map.get('file_id')
        self.file_name = map.get('file_name')
        return self


class CCPGetFileByPathRequest(TeaModel):
    """
    根据路径获取 File 接口 body
    """
    def __init__(self, drive_id=None, fields=None, file_id=None, file_path=None, image_thumbnail_process=None, image_url_process=None, url_expire_sec=None, video_thumbnail_process=None):
        self.drive_id = drive_id
        self.fields = fields
        self.file_id = file_id
        self.file_path = file_path
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.url_expire_sec = url_expire_sec
        self.video_thumbnail_process = video_thumbnail_process

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['fields'] = self.fields
        result['file_id'] = self.file_id
        result['file_path'] = self.file_path
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['url_expire_sec'] = self.url_expire_sec
        result['video_thumbnail_process'] = self.video_thumbnail_process
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.fields = map.get('fields')
        self.file_id = map.get('file_id')
        self.file_path = map.get('file_path')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.url_expire_sec = map.get('url_expire_sec')
        self.video_thumbnail_process = map.get('video_thumbnail_process')
        return self


class CCPGetFileRequest(TeaModel):
    """
    获取文件元数据
    """
    def __init__(self, drive_id=None, fields=None, file_id=None, image_thumbnail_process=None, image_url_process=None, url_expire_sec=None, video_thumbnail_process=None):
        self.drive_id = drive_id
        self.fields = fields
        self.file_id = file_id
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.url_expire_sec = url_expire_sec
        self.video_thumbnail_process = video_thumbnail_process

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['fields'] = self.fields
        result['file_id'] = self.file_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['url_expire_sec'] = self.url_expire_sec
        result['video_thumbnail_process'] = self.video_thumbnail_process
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.fields = map.get('fields')
        self.file_id = map.get('file_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.url_expire_sec = map.get('url_expire_sec')
        self.video_thumbnail_process = map.get('video_thumbnail_process')
        return self


class CCPGetUploadUrlRequest(TeaModel):
    """
    获取文件上传URL
    """
    def __init__(self, content_md_5=None, drive_id=None, part_info_list=None, upload_id=None, file_id=None):
        self.content_md_5 = content_md_5
        self.drive_id = drive_id
        self.part_info_list = []
        self.upload_id = upload_id
        self.file_id = file_id

    def validate(self):
        if self.content_md_5:
            self.validate_max_length(self.content_md_5, 'content_md_5', 32)
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')

    def to_map(self):
        result = {}
        result['content_md5'] = self.content_md_5
        result['drive_id'] = self.drive_id
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['upload_id'] = self.upload_id
        result['file_id'] = self.file_id
        return result

    def from_map(self, map={}):
        self.content_md_5 = map.get('content_md5')
        self.drive_id = map.get('drive_id')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.upload_id = map.get('upload_id')
        self.file_id = map.get('file_id')
        return self


class CCPGetVideoPreviewSpriteURLRequest(TeaModel):
    """
    获取视频雪碧图地址的请求body
    """
    def __init__(self, drive_id=None, expire_sec=None, file_id=None):
        self.drive_id = drive_id
        self.expire_sec = expire_sec
        self.file_id = file_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['expire_sec'] = self.expire_sec
        result['file_id'] = self.file_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.expire_sec = map.get('expire_sec')
        self.file_id = map.get('file_id')
        return self


class CCPGetVideoPreviewURLRequest(TeaModel):
    """
    获取视频文件播放地址的请求body
    """
    def __init__(self, drive_id=None, expire_sec=None, file_id=None, template_id=None):
        self.drive_id = drive_id
        self.expire_sec = expire_sec
        self.file_id = file_id
        self.template_id = template_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['expire_sec'] = self.expire_sec
        result['file_id'] = self.file_id
        result['template_id'] = self.template_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.expire_sec = map.get('expire_sec')
        self.file_id = map.get('file_id')
        self.template_id = map.get('template_id')
        return self


class CCPListFileByCustomIndexKeyRequest(TeaModel):
    """
    列举文件
    """
    def __init__(self, drive_id=None, image_thumbnail_process=None, image_url_process=None, limit=None, marker=None, video_thumbnail_process=None, starred=None, category=None, custom_index_key=None, encrypt_mode=None, fields=None, order_direction=None, status=None, type=None, url_expire_sec=None):
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.limit = limit
        self.marker = marker
        self.video_thumbnail_process = video_thumbnail_process
        self.starred = starred
        self.category = category
        self.custom_index_key = custom_index_key
        self.encrypt_mode = encrypt_mode
        self.fields = fields
        self.order_direction = order_direction
        self.status = status
        self.type = type
        self.url_expire_sec = url_expire_sec

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.limit:
            self.validate_pattern(self.limit, 'limit', '[0-9]{1,3}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['video_thumbnail_process'] = self.video_thumbnail_process
        result['Starred'] = self.starred
        result['category'] = self.category
        result['custom_index_key'] = self.custom_index_key
        result['encrypt_mode'] = self.encrypt_mode
        result['fields'] = self.fields
        result['order_direction'] = self.order_direction
        result['status'] = self.status
        result['type'] = self.type
        result['url_expire_sec'] = self.url_expire_sec
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.video_thumbnail_process = map.get('video_thumbnail_process')
        self.starred = map.get('Starred')
        self.category = map.get('category')
        self.custom_index_key = map.get('custom_index_key')
        self.encrypt_mode = map.get('encrypt_mode')
        self.fields = map.get('fields')
        self.order_direction = map.get('order_direction')
        self.status = map.get('status')
        self.type = map.get('type')
        self.url_expire_sec = map.get('url_expire_sec')
        return self


class CCPListFileRequest(TeaModel):
    """
    列举文件
    """
    def __init__(self, drive_id=None, image_thumbnail_process=None, image_url_process=None, limit=None, marker=None, video_thumbnail_process=None, starred=None, all=None, category=None, fields=None, order_by=None, order_direction=None, parent_file_id=None, status=None, type=None, url_expire_sec=None):
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.limit = limit
        self.marker = marker
        self.video_thumbnail_process = video_thumbnail_process
        self.starred = starred
        self.all = all
        self.category = category
        self.fields = fields
        self.order_by = order_by
        self.order_direction = order_direction
        self.parent_file_id = parent_file_id
        self.status = status
        self.type = type
        self.url_expire_sec = url_expire_sec

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.limit:
            self.validate_pattern(self.limit, 'limit', '[0-9]{1,3}')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['video_thumbnail_process'] = self.video_thumbnail_process
        result['Starred'] = self.starred
        result['all'] = self.all
        result['category'] = self.category
        result['fields'] = self.fields
        result['order_by'] = self.order_by
        result['order_direction'] = self.order_direction
        result['parent_file_id'] = self.parent_file_id
        result['status'] = self.status
        result['type'] = self.type
        result['url_expire_sec'] = self.url_expire_sec
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.video_thumbnail_process = map.get('video_thumbnail_process')
        self.starred = map.get('Starred')
        self.all = map.get('all')
        self.category = map.get('category')
        self.fields = map.get('fields')
        self.order_by = map.get('order_by')
        self.order_direction = map.get('order_direction')
        self.parent_file_id = map.get('parent_file_id')
        self.status = map.get('status')
        self.type = map.get('type')
        self.url_expire_sec = map.get('url_expire_sec')
        return self


class CCPListUploadedPartRequest(TeaModel):
    """
    列举uploadID对应的已上传分片
    """
    def __init__(self, drive_id=None, file_id=None, limit=None, part_number_marker=None, upload_id=None):
        self.drive_id = drive_id
        self.file_id = file_id
        self.limit = limit
        self.part_number_marker = part_number_marker
        self.upload_id = upload_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')
        self.validate_required(self.limit, 'limit')
        if self.limit:
            self.validate_pattern(self.limit, 'limit', '[0-9]+')
        if self.part_number_marker:
            self.validate_pattern(self.part_number_marker, 'part_number_marker', '[0-9]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['limit'] = self.limit
        result['part_number_marker'] = self.part_number_marker
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.limit = map.get('limit')
        self.part_number_marker = map.get('part_number_marker')
        self.upload_id = map.get('upload_id')
        return self


class CCPMoveFileRequest(TeaModel):
    """
    文件移动请求
    """
    def __init__(self, drive_id=None, new_name=None, overwrite=None, file_id=None, to_parent_file_id=None):
        self.drive_id = drive_id
        self.new_name = new_name
        self.overwrite = overwrite
        self.file_id = file_id
        self.to_parent_file_id = to_parent_file_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')
        if self.to_parent_file_id:
            self.validate_max_length(self.to_parent_file_id, 'to_parent_file_id', 50)

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['new_name'] = self.new_name
        result['overwrite'] = self.overwrite
        result['file_id'] = self.file_id
        result['to_parent_file_id'] = self.to_parent_file_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.new_name = map.get('new_name')
        self.overwrite = map.get('overwrite')
        self.file_id = map.get('file_id')
        self.to_parent_file_id = map.get('to_parent_file_id')
        return self


class CCPScanFileMetaRequest(TeaModel):
    """
    全量获取file元信息的请求body
    """
    def __init__(self, category=None, drive_id=None, limit=None, marker=None):
        self.category = category
        self.drive_id = drive_id
        self.limit = limit
        self.marker = marker

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['category'] = self.category
        result['drive_id'] = self.drive_id
        result['limit'] = self.limit
        result['marker'] = self.marker
        return result

    def from_map(self, map={}):
        self.category = map.get('category')
        self.drive_id = map.get('drive_id')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        return self


class CCPSearchFileRequest(TeaModel):
    """
    搜索文件元数据
    """
    def __init__(self, drive_id=None, image_thumbnail_process=None, image_url_process=None, limit=None, marker=None, order_by=None, query=None, url_expire_sec=None, video_thumbnail_process=None):
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.limit = limit
        self.marker = marker
        self.order_by = order_by
        self.query = query
        self.url_expire_sec = url_expire_sec
        self.video_thumbnail_process = video_thumbnail_process

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.query:
            self.validate_max_length(self.query, 'query', 4096)

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['order_by'] = self.order_by
        result['query'] = self.query
        result['url_expire_sec'] = self.url_expire_sec
        result['video_thumbnail_process'] = self.video_thumbnail_process
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.order_by = map.get('order_by')
        self.query = map.get('query')
        self.url_expire_sec = map.get('url_expire_sec')
        self.video_thumbnail_process = map.get('video_thumbnail_process')
        return self


class CCPUpdateFileMetaRequest(TeaModel):
    """
    更新文件元数据
    """
    def __init__(self, custom_index_key=None, description=None, drive_id=None, encrypt_mode=None, file_id=None, hidden=None, labels=None, meta=None, name=None, starred=None, user_meta=None):
        self.custom_index_key = custom_index_key
        self.description = description
        self.drive_id = drive_id
        self.encrypt_mode = encrypt_mode
        self.file_id = file_id
        self.hidden = hidden
        self.labels = []
        self.meta = meta
        self.name = name
        self.starred = starred
        self.user_meta = user_meta

    def validate(self):
        if self.description:
            self.validate_max_length(self.description, 'description', 1024)
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')
        if self.name:
            self.validate_max_length(self.name, 'name', 1024)

    def to_map(self):
        result = {}
        result['custom_index_key'] = self.custom_index_key
        result['description'] = self.description
        result['drive_id'] = self.drive_id
        result['encrypt_mode'] = self.encrypt_mode
        result['file_id'] = self.file_id
        result['hidden'] = self.hidden
        result['labels'] = []
        if self.labels is not None:
            for k in self.labels:
                result['labels'].append(k)
        else:
            result['labels'] = None
        result['meta'] = self.meta
        result['name'] = self.name
        result['starred'] = self.starred
        result['user_meta'] = self.user_meta
        return result

    def from_map(self, map={}):
        self.custom_index_key = map.get('custom_index_key')
        self.description = map.get('description')
        self.drive_id = map.get('drive_id')
        self.encrypt_mode = map.get('encrypt_mode')
        self.file_id = map.get('file_id')
        self.hidden = map.get('hidden')
        self.labels = []
        if map.get('labels') is not None:
            for k in map.get('labels'):
                self.labels.append(k)
        else:
            self.labels = None
        self.meta = map.get('meta')
        self.name = map.get('name')
        self.starred = map.get('starred')
        self.user_meta = map.get('user_meta')
        return self


class CompleteFileRequest(TeaModel):
    """
    complete file request
    """
    def __init__(self, drive_id=None, file_id=None, file_path=None, part_info_list=None, share_id=None, upload_id=None):
        self.drive_id = drive_id
        self.file_id = file_id
        self.file_path = file_path
        self.part_info_list = []
        self.share_id = share_id
        self.upload_id = upload_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['file_path'] = self.file_path
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['share_id'] = self.share_id
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.file_path = map.get('file_path')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.share_id = map.get('share_id')
        self.upload_id = map.get('upload_id')
        return self


class CopyFileRequest(TeaModel):
    """
    copy file request
    """
    def __init__(self, drive_id=None, file_id=None, file_path=None, new_name=None, overwrite=None, share_id=None, to_drive_id=None, to_parent_file_id=None, to_parent_file_path=None, to_share_id=None):
        self.drive_id = drive_id
        self.file_id = file_id
        self.file_path = file_path
        self.new_name = new_name
        self.overwrite = overwrite
        self.share_id = share_id
        self.to_drive_id = to_drive_id
        self.to_parent_file_id = to_parent_file_id
        self.to_parent_file_path = to_parent_file_path
        self.to_share_id = to_share_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')
        self.validate_required(self.new_name, 'new_name')
        if self.new_name:
            self.validate_pattern(self.new_name, 'new_name', '[a-zA-Z0-9.-]{1,1000}')
        self.validate_required(self.to_drive_id, 'to_drive_id')
        if self.to_drive_id:
            self.validate_pattern(self.to_drive_id, 'to_drive_id', '[0-9]+')
        self.validate_required(self.to_parent_file_id, 'to_parent_file_id')
        if self.to_parent_file_id:
            self.validate_pattern(self.to_parent_file_id, 'to_parent_file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['file_path'] = self.file_path
        result['new_name'] = self.new_name
        result['overwrite'] = self.overwrite
        result['share_id'] = self.share_id
        result['to_drive_id'] = self.to_drive_id
        result['to_parent_file_id'] = self.to_parent_file_id
        result['to_parent_file_path'] = self.to_parent_file_path
        result['to_share_id'] = self.to_share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.file_path = map.get('file_path')
        self.new_name = map.get('new_name')
        self.overwrite = map.get('overwrite')
        self.share_id = map.get('share_id')
        self.to_drive_id = map.get('to_drive_id')
        self.to_parent_file_id = map.get('to_parent_file_id')
        self.to_parent_file_path = map.get('to_parent_file_path')
        self.to_share_id = map.get('to_share_id')
        return self


class CreateDriveRequest(TeaModel):
    """
    create drive request
    """
    def __init__(self, default_=None, description=None, drive_name=None, drive_type=None, encrypt_mode=None, owner=None, relative_path=None, status=None, store_id=None, total_size=None):
        self.default_ = default_
        self.description = description
        self.drive_name = drive_name
        self.drive_type = drive_type
        self.encrypt_mode = encrypt_mode
        self.owner = owner
        self.relative_path = relative_path
        self.status = status
        self.store_id = store_id
        self.total_size = total_size

    def validate(self):
        self.validate_required(self.drive_name, 'drive_name')
        self.validate_required(self.owner, 'owner')

    def to_map(self):
        result = {}
        result['default'] = self.default_
        result['description'] = self.description
        result['drive_name'] = self.drive_name
        result['drive_type'] = self.drive_type
        result['encrypt_mode'] = self.encrypt_mode
        result['owner'] = self.owner
        result['relative_path'] = self.relative_path
        result['status'] = self.status
        result['store_id'] = self.store_id
        result['total_size'] = self.total_size
        return result

    def from_map(self, map={}):
        self.default_ = map.get('default')
        self.description = map.get('description')
        self.drive_name = map.get('drive_name')
        self.drive_type = map.get('drive_type')
        self.encrypt_mode = map.get('encrypt_mode')
        self.owner = map.get('owner')
        self.relative_path = map.get('relative_path')
        self.status = map.get('status')
        self.store_id = map.get('store_id')
        self.total_size = map.get('total_size')
        return self


class CreateFileRequest(TeaModel):
    """
    create file request
    """
    def __init__(self, content_hash=None, content_hash_name=None, content_md_5=None, content_type=None, description=None, drive_id=None, hidden=None, meta=None, name=None, parent_file_id=None, parent_file_path=None, part_info_list=None, pre_hash=None, share_id=None, size=None, tags=None, type=None):
        self.content_hash = content_hash
        self.content_hash_name = content_hash_name
        self.content_md_5 = content_md_5
        self.content_type = content_type
        self.description = description
        self.drive_id = drive_id
        self.hidden = hidden
        self.meta = meta
        self.name = name
        self.parent_file_id = parent_file_id
        self.parent_file_path = parent_file_path
        self.part_info_list = []
        self.pre_hash = pre_hash
        self.share_id = share_id
        self.size = size
        self.tags = tags
        self.type = type

    def validate(self):
        if self.content_md_5:
            self.validate_max_length(self.content_md_5, 'content_md_5', 32)
        self.validate_required(self.content_type, 'content_type')
        if self.description:
            self.validate_max_length(self.description, 'description', 0)
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.name, 'name')
        self.validate_required(self.parent_file_id, 'parent_file_id')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9]{1,50}')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        self.validate_required(self.size, 'size')
        self.validate_required(self.type, 'type')

    def to_map(self):
        result = {}
        result['content_hash'] = self.content_hash
        result['content_hash_name'] = self.content_hash_name
        result['content_md5'] = self.content_md_5
        result['content_type'] = self.content_type
        result['description'] = self.description
        result['drive_id'] = self.drive_id
        result['hidden'] = self.hidden
        result['meta'] = self.meta
        result['name'] = self.name
        result['parent_file_id'] = self.parent_file_id
        result['parent_file_path'] = self.parent_file_path
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['pre_hash'] = self.pre_hash
        result['share_id'] = self.share_id
        result['size'] = self.size
        result['tags'] = self.tags
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.content_hash = map.get('content_hash')
        self.content_hash_name = map.get('content_hash_name')
        self.content_md_5 = map.get('content_md5')
        self.content_type = map.get('content_type')
        self.description = map.get('description')
        self.drive_id = map.get('drive_id')
        self.hidden = map.get('hidden')
        self.meta = map.get('meta')
        self.name = map.get('name')
        self.parent_file_id = map.get('parent_file_id')
        self.parent_file_path = map.get('parent_file_path')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.pre_hash = map.get('pre_hash')
        self.share_id = map.get('share_id')
        self.size = map.get('size')
        self.tags = map.get('tags')
        self.type = map.get('type')
        return self


class CreateShareRequest(TeaModel):
    """
    create share request
    """
    def __init__(self, description=None, drive_id=None, expiration=None, owner=None, permissions=None, share_file_path=None, share_name=None, share_policy=None, status=None):
        self.description = description
        self.drive_id = drive_id
        self.expiration = expiration
        self.owner = owner
        self.permissions = []
        self.share_file_path = share_file_path
        self.share_name = share_name
        self.share_policy = []
        self.status = status

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.owner, 'owner')
        self.validate_required(self.share_file_path, 'share_file_path')
        if self.share_policy:
            for k in self.share_policy:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['description'] = self.description
        result['drive_id'] = self.drive_id
        result['expiration'] = self.expiration
        result['owner'] = self.owner
        result['permissions'] = []
        if self.permissions is not None:
            for k in self.permissions:
                result['permissions'].append(k)
        else:
            result['permissions'] = None
        result['share_file_path'] = self.share_file_path
        result['share_name'] = self.share_name
        result['share_policy'] = []
        if self.share_policy is not None:
            for k in self.share_policy:
                result['share_policy'].append(k.to_map() if k else None)
        else:
            result['share_policy'] = None
        result['status'] = self.status
        return result

    def from_map(self, map={}):
        self.description = map.get('description')
        self.drive_id = map.get('drive_id')
        self.expiration = map.get('expiration')
        self.owner = map.get('owner')
        self.permissions = []
        if map.get('permissions') is not None:
            for k in map.get('permissions'):
                self.permissions.append(k)
        else:
            self.permissions = None
        self.share_file_path = map.get('share_file_path')
        self.share_name = map.get('share_name')
        self.share_policy = []
        if map.get('share_policy') is not None:
            for k in map.get('share_policy'):
                temp_model = SharePermissionPolicy()
                temp_model = temp_model.from_map(k)
                self.share_policy.append(temp_model)
        else:
            self.share_policy = None
        self.status = map.get('status')
        return self


class DeleteDriveRequest(TeaModel):
    """
    Delete drive request
    """
    def __init__(self, drive_id=None):
        self.drive_id = drive_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        return self


class DeleteFileRequest(TeaModel):
    """
    删除文件请求
    """
    def __init__(self, drive_id=None, file_id=None, file_path=None, permanently=None, share_id=None):
        self.drive_id = drive_id
        self.file_id = file_id
        self.file_path = file_path
        self.permanently = permanently
        self.share_id = share_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['file_path'] = self.file_path
        result['permanently'] = self.permanently
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.file_path = map.get('file_path')
        self.permanently = map.get('permanently')
        self.share_id = map.get('share_id')
        return self


class DeleteShareRequest(TeaModel):
    """
    delete share request
    """
    def __init__(self, share_id=None):
        self.share_id = share_id

    def validate(self):
        self.validate_required(self.share_id, 'share_id')

    def to_map(self):
        result = {}
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.share_id = map.get('share_id')
        return self


class DownloadRequest(TeaModel):
    """
    下载文件请求body
    """
    def __init__(self, drive_id=None, file_id=None, image_process=None, share_id=None):
        self.drive_id = drive_id
        self.file_id = file_id
        self.image_process = image_process
        self.share_id = share_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['DriveID'] = self.drive_id
        result['FileID'] = self.file_id
        result['ImageProcess'] = self.image_process
        result['ShareID'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('DriveID')
        self.file_id = map.get('FileID')
        self.image_process = map.get('ImageProcess')
        self.share_id = map.get('ShareID')
        return self


class GetAsyncTaskRequest(TeaModel):
    """
    获取异步人去信息
    """
    def __init__(self, async_task_id=None):
        self.async_task_id = async_task_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['async_task_id'] = self.async_task_id
        return result

    def from_map(self, map={}):
        self.async_task_id = map.get('async_task_id')
        return self


class GetDefaultDriveRequest(TeaModel):
    """
    Get default drive request
    """
    def __init__(self, user_id=None):
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.user_id = map.get('user_id')
        return self


class GetDownloadUrlRequest(TeaModel):
    """
    获取文件下载地址的请求body
    """
    def __init__(self, drive_id=None, expire_sec=None, file_id=None, file_name=None, file_path=None, share_id=None):
        self.drive_id = drive_id
        self.expire_sec = expire_sec
        self.file_id = file_id
        self.file_name = file_name
        self.file_path = file_path
        self.share_id = share_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')
        if self.file_name:
            self.validate_pattern(self.file_name, 'file_name', '[a-zA-Z0-9.-]{1,1000}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['expire_sec'] = self.expire_sec
        result['file_id'] = self.file_id
        result['file_name'] = self.file_name
        result['file_path'] = self.file_path
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.expire_sec = map.get('expire_sec')
        self.file_id = map.get('file_id')
        self.file_name = map.get('file_name')
        self.file_path = map.get('file_path')
        self.share_id = map.get('share_id')
        return self


class GetDriveRequest(TeaModel):
    """
    Get drive request
    """
    def __init__(self, drive_id=None):
        self.drive_id = drive_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        return self


class GetFileRequest(TeaModel):
    """
    获取文件元数据
    """
    def __init__(self, drive_id=None, file_id=None, file_path=None, image_thumbnail_process=None, image_url_process=None, share_id=None):
        self.drive_id = drive_id
        self.file_id = file_id
        self.file_path = file_path
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.share_id = share_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['file_path'] = self.file_path
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.file_path = map.get('file_path')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.share_id = map.get('share_id')
        return self


class GetLastCursorRequest(TeaModel):
    """
    获取最新游标
    """
    def __init__(self, drive_id=None):
        self.drive_id = drive_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        return self


class GetShareRequest(TeaModel):
    """
    get share request
    """
    def __init__(self, share_id=None):
        self.share_id = share_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.share_id = map.get('share_id')
        return self


class GetUploadUrlRequest(TeaModel):
    """
    获取文件上传URL
    """
    def __init__(self, content_md_5=None, drive_id=None, file_id=None, file_path=None, part_info_list=None, share_id=None, upload_id=None):
        self.content_md_5 = content_md_5
        self.drive_id = drive_id
        self.file_id = file_id
        self.file_path = file_path
        self.part_info_list = []
        self.share_id = share_id
        self.upload_id = upload_id

    def validate(self):
        if self.content_md_5:
            self.validate_max_length(self.content_md_5, 'content_md_5', 32)
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9]{1,50}')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        self.validate_required(self.upload_id, 'upload_id')

    def to_map(self):
        result = {}
        result['content_md5'] = self.content_md_5
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['file_path'] = self.file_path
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['share_id'] = self.share_id
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.content_md_5 = map.get('content_md5')
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.file_path = map.get('file_path')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.share_id = map.get('share_id')
        self.upload_id = map.get('upload_id')
        return self


class ImageMediaMetadata(TeaModel):
    """
    *
    """
    def __init__(self, height=None, width=None):
        self.height = height
        self.width = width

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['height'] = self.height
        result['width'] = self.width
        return result

    def from_map(self, map={}):
        self.height = map.get('height')
        self.width = map.get('width')
        return self


class ListDriveRequest(TeaModel):
    """
    List drive request
    """
    def __init__(self, limit=None, marker=None, owner=None):
        self.limit = limit
        self.marker = marker
        self.owner = owner

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['owner'] = self.owner
        return result

    def from_map(self, map={}):
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.owner = map.get('owner')
        return self


class ListFileDeltaRequest(TeaModel):
    """
    获取增量文件操作记录
    """
    def __init__(self, cursor=None, drive_id=None, limit=None):
        self.cursor = cursor
        self.drive_id = drive_id
        self.limit = limit

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['cursor'] = self.cursor
        result['drive_id'] = self.drive_id
        result['limit'] = self.limit
        return result

    def from_map(self, map={}):
        self.cursor = map.get('cursor')
        self.drive_id = map.get('drive_id')
        self.limit = map.get('limit')
        return self


class ListFileRequest(TeaModel):
    """
    list file request
    """
    def __init__(self, all=None, drive_id=None, image_thumbnail_process=None, image_url_process=None, limit=None, marker=None, parent_file_id=None, parent_file_path=None, share_id=None, status=None):
        self.all = all
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.limit = limit
        self.marker = marker
        self.parent_file_id = parent_file_id
        self.parent_file_path = parent_file_path
        self.share_id = share_id
        self.status = status

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.limit:
            self.validate_pattern(self.limit, 'limit', '[0-9]{1,3}')
        self.validate_required(self.parent_file_id, 'parent_file_id')
        if self.parent_file_id:
            self.validate_pattern(self.parent_file_id, 'parent_file_id', '[a-z0-9.-_]{1,50}')

    def to_map(self):
        result = {}
        result['all'] = self.all
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['parent_file_id'] = self.parent_file_id
        result['parent_file_path'] = self.parent_file_path
        result['share_id'] = self.share_id
        result['status'] = self.status
        return result

    def from_map(self, map={}):
        self.all = map.get('all')
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.parent_file_id = map.get('parent_file_id')
        self.parent_file_path = map.get('parent_file_path')
        self.share_id = map.get('share_id')
        self.status = map.get('status')
        return self


class ListMyDriveRequest(TeaModel):
    """
    List my drive request
    """
    def __init__(self, limit=None, marker=None):
        self.limit = limit
        self.marker = marker

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['limit'] = self.limit
        result['marker'] = self.marker
        return result

    def from_map(self, map={}):
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        return self


class ListShareRequest(TeaModel):
    """
    list share request
    """
    def __init__(self, creator=None, drive_id=None, limit=None, marker=None, owner=None, share_file_path=None):
        self.creator = creator
        self.drive_id = drive_id
        self.limit = limit
        self.marker = marker
        self.owner = owner
        self.share_file_path = share_file_path

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.limit, 'limit')

    def to_map(self):
        result = {}
        result['creator'] = self.creator
        result['drive_id'] = self.drive_id
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['owner'] = self.owner
        result['share_file_path'] = self.share_file_path
        return result

    def from_map(self, map={}):
        self.creator = map.get('creator')
        self.drive_id = map.get('drive_id')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.owner = map.get('owner')
        self.share_file_path = map.get('share_file_path')
        return self


class ListStoreFileRequest(TeaModel):
    """
    list store file
    """
    def __init__(self, limit=None, marker=None, parent_file_path=None, store_id=None, type=None):
        self.limit = limit
        self.marker = marker
        self.parent_file_path = parent_file_path
        self.store_id = store_id
        self.type = type

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['parent_file_path'] = self.parent_file_path
        result['store_id'] = self.store_id
        result['type'] = self.type
        return result

    def from_map(self, map={}):
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.parent_file_path = map.get('parent_file_path')
        self.store_id = map.get('store_id')
        self.type = map.get('type')
        return self


class ListStoreRequest(TeaModel):
    """
    list storage file
    """
    def __init__(self, domain_id=None):
        self.domain_id = domain_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['domain_id'] = self.domain_id
        return result

    def from_map(self, map={}):
        self.domain_id = map.get('domain_id')
        return self


class OSSCompleteFileRequest(TeaModel):
    """
    complete file request
    """
    def __init__(self, drive_id=None, part_info_list=None, upload_id=None, file_path=None, share_id=None):
        self.drive_id = drive_id
        self.part_info_list = []
        self.upload_id = upload_id
        self.file_path = file_path
        self.share_id = share_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['upload_id'] = self.upload_id
        result['file_path'] = self.file_path
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.upload_id = map.get('upload_id')
        self.file_path = map.get('file_path')
        self.share_id = map.get('share_id')
        return self


class OSSCopyFileRequest(TeaModel):
    """
    copy file request
    """
    def __init__(self, drive_id=None, file_path=None, new_name=None, overwrite=None, share_id=None, to_drive_id=None, to_parent_file_path=None, to_share_id=None):
        self.drive_id = drive_id
        self.file_path = file_path
        self.new_name = new_name
        self.overwrite = overwrite
        self.share_id = share_id
        self.to_drive_id = to_drive_id
        self.to_parent_file_path = to_parent_file_path
        self.to_share_id = to_share_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.new_name:
            self.validate_pattern(self.new_name, 'new_name', '[a-zA-Z0-9.-]{1,1000}')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')
        self.validate_required(self.to_drive_id, 'to_drive_id')
        if self.to_drive_id:
            self.validate_pattern(self.to_drive_id, 'to_drive_id', '[0-9]+')
        self.validate_required(self.to_parent_file_path, 'to_parent_file_path')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['new_name'] = self.new_name
        result['overwrite'] = self.overwrite
        result['share_id'] = self.share_id
        result['to_drive_id'] = self.to_drive_id
        result['to_parent_file_path'] = self.to_parent_file_path
        result['to_share_id'] = self.to_share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.new_name = map.get('new_name')
        self.overwrite = map.get('overwrite')
        self.share_id = map.get('share_id')
        self.to_drive_id = map.get('to_drive_id')
        self.to_parent_file_path = map.get('to_parent_file_path')
        self.to_share_id = map.get('to_share_id')
        return self


class OSSCreateFileRequest(TeaModel):
    """
    create file request
    """
    def __init__(self, content_md_5=None, content_type=None, name=None, part_info_list=None, size=None, type=None, drive_id=None, parent_file_path=None, share_id=None):
        self.content_md_5 = content_md_5
        self.content_type = content_type
        self.name = name
        self.part_info_list = []
        self.size = size
        self.type = type
        self.drive_id = drive_id
        self.parent_file_path = parent_file_path
        self.share_id = share_id

    def validate(self):
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['content_md5'] = self.content_md_5
        result['content_type'] = self.content_type
        result['name'] = self.name
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['size'] = self.size
        result['type'] = self.type
        result['drive_id'] = self.drive_id
        result['parent_file_path'] = self.parent_file_path
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.content_md_5 = map.get('content_md5')
        self.content_type = map.get('content_type')
        self.name = map.get('name')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.size = map.get('size')
        self.type = map.get('type')
        self.drive_id = map.get('drive_id')
        self.parent_file_path = map.get('parent_file_path')
        self.share_id = map.get('share_id')
        return self


class OSSDeleteFileRequest(TeaModel):
    """
    删除文件请求
    """
    def __init__(self, drive_id=None, file_path=None, permanently=None, share_id=None):
        self.drive_id = drive_id
        self.file_path = file_path
        self.permanently = permanently
        self.share_id = share_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_path, 'file_path')
        if self.file_path:
            self.validate_max_length(self.file_path, 'file_path', 1000)
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['permanently'] = self.permanently
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.permanently = map.get('permanently')
        self.share_id = map.get('share_id')
        return self


class OSSGetDownloadUrlRequest(TeaModel):
    """
    获取文件下载地址的请求body
    """
    def __init__(self, drive_id=None, expire_sec=None, file_name=None, file_path=None, share_id=None):
        self.drive_id = drive_id
        self.expire_sec = expire_sec
        self.file_name = file_name
        self.file_path = file_path
        self.share_id = share_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_path, 'file_path')
        if self.file_path:
            self.validate_max_length(self.file_path, 'file_path', 1000)
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['expire_sec'] = self.expire_sec
        result['file_name'] = self.file_name
        result['file_path'] = self.file_path
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.expire_sec = map.get('expire_sec')
        self.file_name = map.get('file_name')
        self.file_path = map.get('file_path')
        self.share_id = map.get('share_id')
        return self


class OSSGetFileRequest(TeaModel):
    """
    获取文件元数据
    """
    def __init__(self, drive_id=None, file_path=None, image_thumbnail_process=None, image_url_process=None, share_id=None, url_expire_sec=None):
        self.drive_id = drive_id
        self.file_path = file_path
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.share_id = share_id
        self.url_expire_sec = url_expire_sec

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_path, 'file_path')
        if self.file_path:
            self.validate_max_length(self.file_path, 'file_path', 1000)
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['share_id'] = self.share_id
        result['url_expire_sec'] = self.url_expire_sec
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.share_id = map.get('share_id')
        self.url_expire_sec = map.get('url_expire_sec')
        return self


class OSSGetSecureUrlRequest(TeaModel):
    """
    获取文件安全地址的请求body
    """
    def __init__(self, drive_id=None, expire_sec=None, file_path=None, secure_ip=None, share_id=None):
        self.drive_id = drive_id
        self.expire_sec = expire_sec
        self.file_path = file_path
        self.secure_ip = secure_ip
        self.share_id = share_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_path, 'file_path')
        if self.file_path:
            self.validate_max_length(self.file_path, 'file_path', 1000)
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['expire_sec'] = self.expire_sec
        result['file_path'] = self.file_path
        result['secure_ip'] = self.secure_ip
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.expire_sec = map.get('expire_sec')
        self.file_path = map.get('file_path')
        self.secure_ip = map.get('secure_ip')
        self.share_id = map.get('share_id')
        return self


class OSSGetUploadUrlRequest(TeaModel):
    """
    获取文件上传URL
    """
    def __init__(self, content_md_5=None, drive_id=None, part_info_list=None, upload_id=None, file_path=None, share_id=None):
        self.content_md_5 = content_md_5
        self.drive_id = drive_id
        self.part_info_list = []
        self.upload_id = upload_id
        self.file_path = file_path
        self.share_id = share_id

    def validate(self):
        if self.content_md_5:
            self.validate_max_length(self.content_md_5, 'content_md_5', 32)
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.part_info_list:
            for k in self.part_info_list:
                if k :
                    k.validate()
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['content_md5'] = self.content_md_5
        result['drive_id'] = self.drive_id
        result['part_info_list'] = []
        if self.part_info_list is not None:
            for k in self.part_info_list:
                result['part_info_list'].append(k.to_map() if k else None)
        else:
            result['part_info_list'] = None
        result['upload_id'] = self.upload_id
        result['file_path'] = self.file_path
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.content_md_5 = map.get('content_md5')
        self.drive_id = map.get('drive_id')
        self.part_info_list = []
        if map.get('part_info_list') is not None:
            for k in map.get('part_info_list'):
                temp_model = UploadPartInfo()
                temp_model = temp_model.from_map(k)
                self.part_info_list.append(temp_model)
        else:
            self.part_info_list = None
        self.upload_id = map.get('upload_id')
        self.file_path = map.get('file_path')
        self.share_id = map.get('share_id')
        return self


class OSSListFileRequest(TeaModel):
    """
    list file request
    """
    def __init__(self, drive_id=None, image_thumbnail_process=None, image_url_process=None, limit=None, marker=None, parent_file_path=None, share_id=None, url_expire_sec=None, video_thumbnail_process=None):
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process
        self.image_url_process = image_url_process
        self.limit = limit
        self.marker = marker
        self.parent_file_path = parent_file_path
        self.share_id = share_id
        self.url_expire_sec = url_expire_sec
        self.video_thumbnail_process = video_thumbnail_process

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        if self.limit:
            self.validate_pattern(self.limit, 'limit', '[0-9]{1,3}')
        self.validate_required(self.parent_file_path, 'parent_file_path')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['image_url_process'] = self.image_url_process
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['parent_file_path'] = self.parent_file_path
        result['share_id'] = self.share_id
        result['url_expire_sec'] = self.url_expire_sec
        result['video_thumbnail_process'] = self.video_thumbnail_process
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.image_url_process = map.get('image_url_process')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.parent_file_path = map.get('parent_file_path')
        self.share_id = map.get('share_id')
        self.url_expire_sec = map.get('url_expire_sec')
        self.video_thumbnail_process = map.get('video_thumbnail_process')
        return self


class OSSListUploadedPartRequest(TeaModel):
    """
    列举uploadID对应的已上传分片
    """
    def __init__(self, drive_id=None, file_path=None, limit=None, part_number_marker=None, share_id=None, upload_id=None):
        self.drive_id = drive_id
        self.file_path = file_path
        self.limit = limit
        self.part_number_marker = part_number_marker
        self.share_id = share_id
        self.upload_id = upload_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_path, 'file_path')
        self.validate_required(self.limit, 'limit')
        if self.limit:
            self.validate_pattern(self.limit, 'limit', '[0-9]+')
        if self.part_number_marker:
            self.validate_pattern(self.part_number_marker, 'part_number_marker', '[0-9]+')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['limit'] = self.limit
        result['part_number_marker'] = self.part_number_marker
        result['share_id'] = self.share_id
        result['upload_id'] = self.upload_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.limit = map.get('limit')
        self.part_number_marker = map.get('part_number_marker')
        self.share_id = map.get('share_id')
        self.upload_id = map.get('upload_id')
        return self


class OSSMoveFileRequest(TeaModel):
    """
    文件移动请求
    """
    def __init__(self, drive_id=None, file_path=None, new_name=None, overwrite=None, share_id=None, to_parent_file_path=None):
        self.drive_id = drive_id
        self.file_path = file_path
        self.new_name = new_name
        self.overwrite = overwrite
        self.share_id = share_id
        self.to_parent_file_path = to_parent_file_path

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.new_name, 'new_name')
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['new_name'] = self.new_name
        result['overwrite'] = self.overwrite
        result['share_id'] = self.share_id
        result['to_parent_file_path'] = self.to_parent_file_path
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.new_name = map.get('new_name')
        self.overwrite = map.get('overwrite')
        self.share_id = map.get('share_id')
        self.to_parent_file_path = map.get('to_parent_file_path')
        return self


class OSSVideoDRMLicenseRequest(TeaModel):
    """
    获取视频DRM License
    """
    def __init__(self, drm_type=None, license_request=None):
        self.drm_type = drm_type
        self.license_request = license_request

    def validate(self):
        self.validate_required(self.drm_type, 'drm_type')
        self.validate_required(self.license_request, 'license_request')

    def to_map(self):
        result = {}
        result['drmType'] = self.drm_type
        result['licenseRequest'] = self.license_request
        return result

    def from_map(self, map={}):
        self.drm_type = map.get('drmType')
        self.license_request = map.get('licenseRequest')
        return self


class OSSVideoDefinitionRequest(TeaModel):
    """
    获取视频分辨率列表
    """
    def __init__(self, drive_id=None, file_path=None, protection_scheme=None, share_id=None):
        self.drive_id = drive_id
        self.file_path = file_path
        self.protection_scheme = protection_scheme
        self.share_id = share_id

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_path, 'file_path')
        if self.file_path:
            self.validate_max_length(self.file_path, 'file_path', 1000)
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['protection_scheme'] = self.protection_scheme
        result['share_id'] = self.share_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.protection_scheme = map.get('protection_scheme')
        self.share_id = map.get('share_id')
        return self


class OSSVideoM3U8Request(TeaModel):
    """
    获取视频的m3u8文件
    """
    def __init__(self, definition=None, drive_id=None, expire_sec=None, file_path=None, protection_scheme=None, share_id=None, sign_token=None):
        self.definition = definition
        self.drive_id = drive_id
        self.expire_sec = expire_sec
        self.file_path = file_path
        self.protection_scheme = protection_scheme
        self.share_id = share_id
        self.sign_token = sign_token

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_path, 'file_path')
        if self.file_path:
            self.validate_max_length(self.file_path, 'file_path', 1000)
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')
        self.validate_required(self.sign_token, 'sign_token')

    def to_map(self):
        result = {}
        result['definition'] = self.definition
        result['drive_id'] = self.drive_id
        result['expire_sec'] = self.expire_sec
        result['file_path'] = self.file_path
        result['protection_scheme'] = self.protection_scheme
        result['share_id'] = self.share_id
        result['sign_token'] = self.sign_token
        return result

    def from_map(self, map={}):
        self.definition = map.get('definition')
        self.drive_id = map.get('drive_id')
        self.expire_sec = map.get('expire_sec')
        self.file_path = map.get('file_path')
        self.protection_scheme = map.get('protection_scheme')
        self.share_id = map.get('share_id')
        self.sign_token = map.get('sign_token')
        return self


class OSSVideoTranscodeRequest(TeaModel):
    """
    启动视频转码请求
    """
    def __init__(self, drive_id=None, file_path=None, hls_time=None, protection_scheme=None, remarks=None, share_id=None, transcode=None):
        self.drive_id = drive_id
        self.file_path = file_path
        self.hls_time = hls_time
        self.protection_scheme = protection_scheme
        self.remarks = remarks
        self.share_id = share_id
        self.transcode = transcode

    def validate(self):
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_path, 'file_path')
        if self.file_path:
            self.validate_max_length(self.file_path, 'file_path', 1000)
        if self.share_id:
            self.validate_pattern(self.share_id, 'share_id', '[0-9a-zA-Z-]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['file_path'] = self.file_path
        result['hls_time'] = self.hls_time
        result['protection_scheme'] = self.protection_scheme
        result['remarks'] = self.remarks
        result['share_id'] = self.share_id
        result['transcode'] = self.transcode
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.file_path = map.get('file_path')
        self.hls_time = map.get('hls_time')
        self.protection_scheme = map.get('protection_scheme')
        self.remarks = map.get('remarks')
        self.share_id = map.get('share_id')
        self.transcode = map.get('transcode')
        return self


class UCGetObjectInfoByObjectKeyRequest(TeaModel):
    """
    UCGetObjectInfoByObjectKeyRequest
    """
    def __init__(self, object_key=None):
        self.object_key = object_key

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['object_key'] = self.object_key
        return result

    def from_map(self, map={}):
        self.object_key = map.get('object_key')
        return self


class UCGetObjectInfoBySha1Request(TeaModel):
    """
    UCGetObjectInfoBySha1Request
    """
    def __init__(self, sha_1=None):
        self.sha_1 = sha_1

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['sha1'] = self.sha_1
        return result

    def from_map(self, map={}):
        self.sha_1 = map.get('sha1')
        return self


class UpdateDriveRequest(TeaModel):
    """
    Update drive request
    """
    def __init__(self, description=None, drive_id=None, drive_name=None, encrypt_data_access=None, encrypt_mode=None, status=None, total_size=None):
        self.description = description
        self.drive_id = drive_id
        self.drive_name = drive_name
        self.encrypt_data_access = encrypt_data_access
        self.encrypt_mode = encrypt_mode
        self.status = status
        self.total_size = total_size

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')

    def to_map(self):
        result = {}
        result['description'] = self.description
        result['drive_id'] = self.drive_id
        result['drive_name'] = self.drive_name
        result['encrypt_data_access'] = self.encrypt_data_access
        result['encrypt_mode'] = self.encrypt_mode
        result['status'] = self.status
        result['total_size'] = self.total_size
        return result

    def from_map(self, map={}):
        self.description = map.get('description')
        self.drive_id = map.get('drive_id')
        self.drive_name = map.get('drive_name')
        self.encrypt_data_access = map.get('encrypt_data_access')
        self.encrypt_mode = map.get('encrypt_mode')
        self.status = map.get('status')
        self.total_size = map.get('total_size')
        return self


class UpdateFileMetaRequest(TeaModel):
    """
    更新文件元数据
    """
    def __init__(self, description=None, drive_id=None, file_id=None, hidden=None, meta=None, name=None, share_id=None, starred=None, tags=None):
        self.description = description
        self.drive_id = drive_id
        self.file_id = file_id
        self.hidden = hidden
        self.meta = meta
        self.name = name
        self.share_id = share_id
        self.starred = starred
        self.tags = tags

    def validate(self):
        if self.description:
            self.validate_max_length(self.description, 'description', 1000)
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.file_id, 'file_id')
        if self.file_id:
            self.validate_pattern(self.file_id, 'file_id', '[a-z0-9.-_]{1,50}')
        self.validate_required(self.name, 'name')
        if self.name:
            self.validate_pattern(self.name, 'name', '[a-zA-Z0-9.-]{1,1000}')

    def to_map(self):
        result = {}
        result['description'] = self.description
        result['drive_id'] = self.drive_id
        result['file_id'] = self.file_id
        result['hidden'] = self.hidden
        result['meta'] = self.meta
        result['name'] = self.name
        result['share_id'] = self.share_id
        result['starred'] = self.starred
        result['tags'] = self.tags
        return result

    def from_map(self, map={}):
        self.description = map.get('description')
        self.drive_id = map.get('drive_id')
        self.file_id = map.get('file_id')
        self.hidden = map.get('hidden')
        self.meta = map.get('meta')
        self.name = map.get('name')
        self.share_id = map.get('share_id')
        self.starred = map.get('starred')
        self.tags = map.get('tags')
        return self


class UpdateShareRequest(TeaModel):
    """
    update share request
    """
    def __init__(self, description=None, expiration=None, permissions=None, share_id=None, share_name=None, share_policy=None, status=None):
        self.description = description
        self.expiration = expiration
        self.permissions = []
        self.share_id = share_id
        self.share_name = share_name
        self.share_policy = []
        self.status = status

    def validate(self):
        if self.description:
            self.validate_max_length(self.description, 'description', 1024)
        self.validate_required(self.share_id, 'share_id')
        if self.share_policy:
            for k in self.share_policy:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['description'] = self.description
        result['expiration'] = self.expiration
        result['permissions'] = []
        if self.permissions is not None:
            for k in self.permissions:
                result['permissions'].append(k)
        else:
            result['permissions'] = None
        result['share_id'] = self.share_id
        result['share_name'] = self.share_name
        result['share_policy'] = []
        if self.share_policy is not None:
            for k in self.share_policy:
                result['share_policy'].append(k.to_map() if k else None)
        else:
            result['share_policy'] = None
        result['status'] = self.status
        return result

    def from_map(self, map={}):
        self.description = map.get('description')
        self.expiration = map.get('expiration')
        self.permissions = []
        if map.get('permissions') is not None:
            for k in map.get('permissions'):
                self.permissions.append(k)
        else:
            self.permissions = None
        self.share_id = map.get('share_id')
        self.share_name = map.get('share_name')
        self.share_policy = []
        if map.get('share_policy') is not None:
            for k in map.get('share_policy'):
                temp_model = SharePermissionPolicy()
                temp_model = temp_model.from_map(k)
                self.share_policy.append(temp_model)
        else:
            self.share_policy = None
        self.status = map.get('status')
        return self


class VideoMediaMetadata(TeaModel):
    """
    *
    """
    def __init__(self, duration=None):
        self.duration = duration

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['duration'] = self.duration
        return result

    def from_map(self, map={}):
        self.duration = map.get('duration')
        return self


class CreateUserRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CreateUserRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CreateUserModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CreateUserResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class DeleteUserRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = DeleteUserRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class DeleteUserModel(TeaModel):
    def __init__(self, headers=None):
        self.headers = {}

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        return self


class GetUserRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetUserRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetUserModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetUserResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListUsersRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListUserRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListUsersModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListUserResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class SearchUserRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = SearchUserRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class SearchUserModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListUserResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class UpdateUserRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = UpdateUserRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class UpdateUserModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = UpdateUserResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class BaseMediaResponse(TeaModel):
    """
    *
    """
    def __init__(self, address_line=None, city=None, country=None, district=None, height=None, location=None, province=None, time=None, township=None, width=None):
        self.address_line = address_line
        self.city = city
        self.country = country
        self.district = district
        self.height = height
        self.location = location
        self.province = province
        self.time = time
        self.township = township
        self.width = width

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['address_line'] = self.address_line
        result['city'] = self.city
        result['country'] = self.country
        result['district'] = self.district
        result['height'] = self.height
        result['location'] = self.location
        result['province'] = self.province
        result['time'] = self.time
        result['township'] = self.township
        result['width'] = self.width
        return result

    def from_map(self, map={}):
        self.address_line = map.get('address_line')
        self.city = map.get('city')
        self.country = map.get('country')
        self.district = map.get('district')
        self.height = map.get('height')
        self.location = map.get('location')
        self.province = map.get('province')
        self.time = map.get('time')
        self.township = map.get('township')
        self.width = map.get('width')
        return self


class BaseUserResponse(TeaModel):
    """
    Base user response
    """
    def __init__(self, avatar=None, created_at=None, default_drive_id=None, description=None, domain_id=None, email=None, nick_name=None, phone=None, role=None, status=None, updated_at=None, user_data=None, user_id=None, user_name=None):
        self.avatar = avatar
        self.created_at = created_at
        self.default_drive_id = default_drive_id
        self.description = description
        self.domain_id = domain_id
        self.email = email
        self.nick_name = nick_name
        self.phone = phone
        self.role = role
        self.status = status
        self.updated_at = updated_at
        self.user_data = user_data
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['avatar'] = self.avatar
        result['created_at'] = self.created_at
        result['default_drive_id'] = self.default_drive_id
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['email'] = self.email
        result['nick_name'] = self.nick_name
        result['phone'] = self.phone
        result['role'] = self.role
        result['status'] = self.status
        result['updated_at'] = self.updated_at
        result['user_data'] = self.user_data
        result['user_id'] = self.user_id
        result['user_name'] = self.user_name
        return result

    def from_map(self, map={}):
        self.avatar = map.get('avatar')
        self.created_at = map.get('created_at')
        self.default_drive_id = map.get('default_drive_id')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.email = map.get('email')
        self.nick_name = map.get('nick_name')
        self.phone = map.get('phone')
        self.role = map.get('role')
        self.status = map.get('status')
        self.updated_at = map.get('updated_at')
        self.user_data = map.get('user_data')
        self.user_id = map.get('user_id')
        self.user_name = map.get('user_name')
        return self


class CreateUserRequest(TeaModel):
    """
    Create user request
    """
    def __init__(self, avatar=None, description=None, email=None, nick_name=None, phone=None, role=None, status=None, user_data=None, user_id=None, user_name=None):
        self.avatar = avatar
        self.description = description
        self.email = email
        self.nick_name = nick_name
        self.phone = phone
        self.role = role
        self.status = status
        self.user_data = user_data
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['avatar'] = self.avatar
        result['description'] = self.description
        result['email'] = self.email
        result['nick_name'] = self.nick_name
        result['phone'] = self.phone
        result['role'] = self.role
        result['status'] = self.status
        result['user_data'] = self.user_data
        result['user_id'] = self.user_id
        result['user_name'] = self.user_name
        return result

    def from_map(self, map={}):
        self.avatar = map.get('avatar')
        self.description = map.get('description')
        self.email = map.get('email')
        self.nick_name = map.get('nick_name')
        self.phone = map.get('phone')
        self.role = map.get('role')
        self.status = map.get('status')
        self.user_data = map.get('user_data')
        self.user_id = map.get('user_id')
        self.user_name = map.get('user_name')
        return self


class CreateUserResponse(TeaModel):
    """
    Create user response
    """
    def __init__(self, avatar=None, created_at=None, default_drive_id=None, description=None, domain_id=None, email=None, nick_name=None, phone=None, role=None, status=None, updated_at=None, user_data=None, user_id=None, user_name=None):
        self.avatar = avatar
        self.created_at = created_at
        self.default_drive_id = default_drive_id
        self.description = description
        self.domain_id = domain_id
        self.email = email
        self.nick_name = nick_name
        self.phone = phone
        self.role = role
        self.status = status
        self.updated_at = updated_at
        self.user_data = user_data
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['avatar'] = self.avatar
        result['created_at'] = self.created_at
        result['default_drive_id'] = self.default_drive_id
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['email'] = self.email
        result['nick_name'] = self.nick_name
        result['phone'] = self.phone
        result['role'] = self.role
        result['status'] = self.status
        result['updated_at'] = self.updated_at
        result['user_data'] = self.user_data
        result['user_id'] = self.user_id
        result['user_name'] = self.user_name
        return result

    def from_map(self, map={}):
        self.avatar = map.get('avatar')
        self.created_at = map.get('created_at')
        self.default_drive_id = map.get('default_drive_id')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.email = map.get('email')
        self.nick_name = map.get('nick_name')
        self.phone = map.get('phone')
        self.role = map.get('role')
        self.status = map.get('status')
        self.updated_at = map.get('updated_at')
        self.user_data = map.get('user_data')
        self.user_id = map.get('user_id')
        self.user_name = map.get('user_name')
        return self


class DeleteUserRequest(TeaModel):
    """
    Delete user request
    """
    def __init__(self, user_id=None):
        self.user_id = user_id

    def validate(self):
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.user_id = map.get('user_id')
        return self


class DeleteUserResponse(TeaModel):
    """
    Delete user response
    """
    def __init__(self):
        pass

    def validate(self):
        pass

    def to_map(self):
        result = {}
        return result

    def from_map(self, map={}):
        return self


class GetUserRequest(TeaModel):
    """
    Get user request
    """
    def __init__(self, user_id=None):
        self.user_id = user_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.user_id = map.get('user_id')
        return self


class GetUserResponse(TeaModel):
    """
    Get user response
    """
    def __init__(self, avatar=None, created_at=None, default_drive_id=None, description=None, domain_id=None, email=None, nick_name=None, phone=None, role=None, status=None, updated_at=None, user_data=None, user_id=None, user_name=None):
        self.avatar = avatar
        self.created_at = created_at
        self.default_drive_id = default_drive_id
        self.description = description
        self.domain_id = domain_id
        self.email = email
        self.nick_name = nick_name
        self.phone = phone
        self.role = role
        self.status = status
        self.updated_at = updated_at
        self.user_data = user_data
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['avatar'] = self.avatar
        result['created_at'] = self.created_at
        result['default_drive_id'] = self.default_drive_id
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['email'] = self.email
        result['nick_name'] = self.nick_name
        result['phone'] = self.phone
        result['role'] = self.role
        result['status'] = self.status
        result['updated_at'] = self.updated_at
        result['user_data'] = self.user_data
        result['user_id'] = self.user_id
        result['user_name'] = self.user_name
        return result

    def from_map(self, map={}):
        self.avatar = map.get('avatar')
        self.created_at = map.get('created_at')
        self.default_drive_id = map.get('default_drive_id')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.email = map.get('email')
        self.nick_name = map.get('nick_name')
        self.phone = map.get('phone')
        self.role = map.get('role')
        self.status = map.get('status')
        self.updated_at = map.get('updated_at')
        self.user_data = map.get('user_data')
        self.user_id = map.get('user_id')
        self.user_name = map.get('user_name')
        return self


class ListUserRequest(TeaModel):
    """
    List user request
    """
    def __init__(self, limit=None, marker=None):
        self.limit = limit
        self.marker = marker

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['limit'] = self.limit
        result['marker'] = self.marker
        return result

    def from_map(self, map={}):
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        return self


class ListUserResponse(TeaModel):
    """
    List user response
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseUserResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class SearchUserRequest(TeaModel):
    """
    Search user request
    """
    def __init__(self, email=None, limit=None, marker=None, nick_name=None, phone=None, role=None, status=None, user_name=None):
        self.email = email
        self.limit = limit
        self.marker = marker
        self.nick_name = nick_name
        self.phone = phone
        self.role = role
        self.status = status
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['email'] = self.email
        result['limit'] = self.limit
        result['marker'] = self.marker
        result['nick_name'] = self.nick_name
        result['phone'] = self.phone
        result['role'] = self.role
        result['status'] = self.status
        result['user_name'] = self.user_name
        return result

    def from_map(self, map={}):
        self.email = map.get('email')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        self.nick_name = map.get('nick_name')
        self.phone = map.get('phone')
        self.role = map.get('role')
        self.status = map.get('status')
        self.user_name = map.get('user_name')
        return self


class UpdateUserRequest(TeaModel):
    """
    Update user request
    """
    def __init__(self, avatar=None, description=None, email=None, nick_name=None, phone=None, role=None, status=None, user_data=None, user_id=None):
        self.avatar = avatar
        self.description = description
        self.email = email
        self.nick_name = nick_name
        self.phone = phone
        self.role = role
        self.status = status
        self.user_data = user_data
        self.user_id = user_id

    def validate(self):
        self.validate_required(self.user_id, 'user_id')

    def to_map(self):
        result = {}
        result['avatar'] = self.avatar
        result['description'] = self.description
        result['email'] = self.email
        result['nick_name'] = self.nick_name
        result['phone'] = self.phone
        result['role'] = self.role
        result['status'] = self.status
        result['user_data'] = self.user_data
        result['user_id'] = self.user_id
        return result

    def from_map(self, map={}):
        self.avatar = map.get('avatar')
        self.description = map.get('description')
        self.email = map.get('email')
        self.nick_name = map.get('nick_name')
        self.phone = map.get('phone')
        self.role = map.get('role')
        self.status = map.get('status')
        self.user_data = map.get('user_data')
        self.user_id = map.get('user_id')
        return self


class UpdateUserResponse(TeaModel):
    """
    Update user response
    """
    def __init__(self, avatar=None, created_at=None, default_drive_id=None, description=None, domain_id=None, email=None, nick_name=None, phone=None, role=None, status=None, updated_at=None, user_data=None, user_id=None, user_name=None):
        self.avatar = avatar
        self.created_at = created_at
        self.default_drive_id = default_drive_id
        self.description = description
        self.domain_id = domain_id
        self.email = email
        self.nick_name = nick_name
        self.phone = phone
        self.role = role
        self.status = status
        self.updated_at = updated_at
        self.user_data = user_data
        self.user_id = user_id
        self.user_name = user_name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['avatar'] = self.avatar
        result['created_at'] = self.created_at
        result['default_drive_id'] = self.default_drive_id
        result['description'] = self.description
        result['domain_id'] = self.domain_id
        result['email'] = self.email
        result['nick_name'] = self.nick_name
        result['phone'] = self.phone
        result['role'] = self.role
        result['status'] = self.status
        result['updated_at'] = self.updated_at
        result['user_data'] = self.user_data
        result['user_id'] = self.user_id
        result['user_name'] = self.user_name
        return result

    def from_map(self, map={}):
        self.avatar = map.get('avatar')
        self.created_at = map.get('created_at')
        self.default_drive_id = map.get('default_drive_id')
        self.description = map.get('description')
        self.domain_id = map.get('domain_id')
        self.email = map.get('email')
        self.nick_name = map.get('nick_name')
        self.phone = map.get('phone')
        self.role = map.get('role')
        self.status = map.get('status')
        self.updated_at = map.get('updated_at')
        self.user_data = map.get('user_data')
        self.user_id = map.get('user_id')
        self.user_name = map.get('user_name')
        return self


class CreateStoryRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CreateStoryRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class CreateStoryModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = CreateStoryResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetPhotoCountRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetImageCountRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetPhotoCountModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetImageCountResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetStoryDetailRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetStoryDetailRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class GetStoryDetailModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetStoryDetailResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListAddressGroupsRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListImageAddressGroupsRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListAddressGroupsModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListImageAddressGroupsResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListFaceGroupsRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListImageFaceGroupsRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListFaceGroupsModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListImageFaceGroupsResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListStoryRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListStoryRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListStoryModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListStoryResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListTagsRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListImageTagsRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class ListTagsModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = ListImageTagsResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class SearchAddressGroupsRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = SearchImageAddressGroupsRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class SearchAddressGroupsModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = SearchImageAddressGroupsResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class UpdateFacegroupInfoRequestModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = UpdateFaceGroupInfoRequest()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class UpdateFacegroupInfoModel(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = {}
        self.body = body

    def validate(self):
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        else:
            result['body'] = None
        return result

    def from_map(self, map={}):
        self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = UpdateFaceGroupInfoResponse()
            self.body = temp_model.from_map(map['body'])
        else:
            self.body = None
        return self


class Address(TeaModel):
    """
    *
    """
    def __init__(self, city=None, country=None, district=None, province=None, township=None):
        self.city = city
        self.country = country
        self.district = district
        self.province = province
        self.township = township

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['city'] = self.city
        result['country'] = self.country
        result['district'] = self.district
        result['province'] = self.province
        result['township'] = self.township
        return result

    def from_map(self, map={}):
        self.city = map.get('city')
        self.country = map.get('country')
        self.district = map.get('district')
        self.province = map.get('province')
        self.township = map.get('township')
        return self


class CreateStoryRequest(TeaModel):
    """
    Create story request
    """
    def __init__(self, drive_id=None):
        self.drive_id = drive_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        return self


class CreateStoryResponse(TeaModel):
    """
    生成故事
    """
    def __init__(self, drive_id=None):
        self.drive_id = drive_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        return self


class GetImageCountRequest(TeaModel):
    """
    Get photo count request
    """
    def __init__(self, drive_id=None):
        self.drive_id = drive_id

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        return self


class GetImageCountResponse(TeaModel):
    """
    获取云照片个数结果
    """
    def __init__(self, image_count=None):
        self.image_count = image_count

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['image_count'] = self.image_count
        return result

    def from_map(self, map={}):
        self.image_count = map.get('image_count')
        return self


class GetStoryDetailRequest(TeaModel):
    """
    Get story detail request
    """
    def __init__(self, drive_id=None, story_id=None, video_url_expire_sec=None):
        self.drive_id = drive_id
        self.story_id = story_id
        self.video_url_expire_sec = video_url_expire_sec

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.story_id, 'story_id')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['story_id'] = self.story_id
        result['video_url_expire_sec'] = self.video_url_expire_sec
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.story_id = map.get('story_id')
        self.video_url_expire_sec = map.get('video_url_expire_sec')
        return self


class GetStoryDetailResponse(TeaModel):
    """
    故事详情
    """
    def __init__(self, cover_file_id=None, created_at=None, score=None, story_id=None, story_images_date_range=None, sub_title=None, title=None, updated_at=None, video_status=None, video_url=None, items=None):
        self.cover_file_id = cover_file_id
        self.created_at = created_at
        self.score = score
        self.story_id = story_id
        self.story_images_date_range = []
        self.sub_title = sub_title
        self.title = title
        self.updated_at = updated_at
        self.video_status = video_status
        self.video_url = video_url
        self.items = []

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['cover_file_id'] = self.cover_file_id
        result['created_at'] = self.created_at
        result['score'] = self.score
        result['story_id'] = self.story_id
        result['story_images_date_range'] = []
        if self.story_images_date_range is not None:
            for k in self.story_images_date_range:
                result['story_images_date_range'].append(k)
        else:
            result['story_images_date_range'] = None
        result['sub_title'] = self.sub_title
        result['title'] = self.title
        result['updated_at'] = self.updated_at
        result['video_status'] = self.video_status
        result['video_url'] = self.video_url
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        return result

    def from_map(self, map={}):
        self.cover_file_id = map.get('cover_file_id')
        self.created_at = map.get('created_at')
        self.score = map.get('score')
        self.story_id = map.get('story_id')
        self.story_images_date_range = []
        if map.get('story_images_date_range') is not None:
            for k in map.get('story_images_date_range'):
                self.story_images_date_range.append(k)
        else:
            self.story_images_date_range = None
        self.sub_title = map.get('sub_title')
        self.title = map.get('title')
        self.updated_at = map.get('updated_at')
        self.video_status = map.get('video_status')
        self.video_url = map.get('video_url')
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = BaseCCPFileResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        return self


class ImageAddressResponse(TeaModel):
    """
    *
    """
    def __init__(self, address_detail=None, count=None, cover_file_id=None, cover_url=None, location=None, name=None):
        self.address_detail = address_detail
        self.count = count
        self.cover_file_id = cover_file_id
        self.cover_url = cover_url
        self.location = location
        self.name = name

    def validate(self):
        if self.address_detail:
            self.address_detail.validate()

    def to_map(self):
        result = {}
        if self.address_detail is not None:
            result['address_detail'] = self.address_detail.to_map()
        else:
            result['address_detail'] = None
        result['count'] = self.count
        result['cover_file_id'] = self.cover_file_id
        result['cover_url'] = self.cover_url
        result['location'] = self.location
        result['name'] = self.name
        return result

    def from_map(self, map={}):
        if map.get('address_detail') is not None:
            temp_model = Address()
            self.address_detail = temp_model.from_map(map['address_detail'])
        else:
            self.address_detail = None
        self.count = map.get('count')
        self.cover_file_id = map.get('cover_file_id')
        self.cover_url = map.get('cover_url')
        self.location = map.get('location')
        self.name = map.get('name')
        return self


class ImageFaceGroupResponse(TeaModel):
    """
    *
    """
    def __init__(self, cover_file_id=None, created_at=None, face_count=None, group_cover_url=None, group_id=None, group_name=None, image_count=None, updated_at=None):
        self.cover_file_id = cover_file_id
        self.created_at = created_at
        self.face_count = face_count
        self.group_cover_url = group_cover_url
        self.group_id = group_id
        self.group_name = group_name
        self.image_count = image_count
        self.updated_at = updated_at

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['cover_file_id'] = self.cover_file_id
        result['created_at'] = self.created_at
        result['face_count'] = self.face_count
        result['group_cover_url'] = self.group_cover_url
        result['group_id'] = self.group_id
        result['group_name'] = self.group_name
        result['image_count'] = self.image_count
        result['updated_at'] = self.updated_at
        return result

    def from_map(self, map={}):
        self.cover_file_id = map.get('cover_file_id')
        self.created_at = map.get('created_at')
        self.face_count = map.get('face_count')
        self.group_cover_url = map.get('group_cover_url')
        self.group_id = map.get('group_id')
        self.group_name = map.get('group_name')
        self.image_count = map.get('image_count')
        self.updated_at = map.get('updated_at')
        return self


class ImageTagResponse(TeaModel):
    """
    *
    """
    def __init__(self, count=None, cover_file_id=None, cover_url=None, name=None):
        self.count = count
        self.cover_file_id = cover_file_id
        self.cover_url = cover_url
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['count'] = self.count
        result['cover_file_id'] = self.cover_file_id
        result['cover_url'] = self.cover_url
        result['name'] = self.name
        return result

    def from_map(self, map={}):
        self.count = map.get('count')
        self.cover_file_id = map.get('cover_file_id')
        self.cover_url = map.get('cover_url')
        self.name = map.get('name')
        return self


class ListImageAddressGroupsRequest(TeaModel):
    """
    List image address groups request
    """
    def __init__(self, drive_id=None, image_thumbnail_process=None, limit=None, marker=None):
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process
        self.limit = limit
        self.marker = marker

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['limit'] = self.limit
        result['marker'] = self.marker
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        return self


class ListImageAddressGroupsResponse(TeaModel):
    """
    展示地点分组集合
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = ImageAddressResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class ListImageFaceGroupsRequest(TeaModel):
    """
    List image face groups request
    """
    def __init__(self, drive_id=None, limit=None, marker=None):
        self.drive_id = drive_id
        self.limit = limit
        self.marker = marker

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['limit'] = self.limit
        result['marker'] = self.marker
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        return self


class ListImageFaceGroupsResponse(TeaModel):
    """
    展示人脸分组集合
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = ImageFaceGroupResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class ListImageTagsRequest(TeaModel):
    """
    List image tags request
    """
    def __init__(self, drive_id=None, image_thumbnail_process=None):
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        return self


class ListImageTagsResponse(TeaModel):
    """
    展示标签集合
    """
    def __init__(self, tags=None):
        self.tags = []

    def validate(self):
        if self.tags:
            for k in self.tags:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['tags'] = []
        if self.tags is not None:
            for k in self.tags:
                result['tags'].append(k.to_map() if k else None)
        else:
            result['tags'] = None
        return result

    def from_map(self, map={}):
        self.tags = []
        if map.get('tags') is not None:
            for k in map.get('tags'):
                temp_model = ImageTagResponse()
                temp_model = temp_model.from_map(k)
                self.tags.append(temp_model)
        else:
            self.tags = None
        return self


class ListStoryRequest(TeaModel):
    """
    List story request
    """
    def __init__(self, drive_id=None, limit=None, marker=None):
        self.drive_id = drive_id
        self.limit = limit
        self.marker = marker

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['limit'] = self.limit
        result['marker'] = self.marker
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.limit = map.get('limit')
        self.marker = map.get('marker')
        return self


class ListStoryResponse(TeaModel):
    """
    故事列表
    """
    def __init__(self, items=None, next_marker=None):
        self.items = []
        self.next_marker = next_marker

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        result['next_marker'] = self.next_marker
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = StoryResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        self.next_marker = map.get('next_marker')
        return self


class SearchImageAddressGroupsRequest(TeaModel):
    """
    Search image address groups request
    """
    def __init__(self, address_level=None, address_names=None, br_geo_point=None, drive_id=None, image_thumbnail_process=None, tl_geo_point=None):
        self.address_level = address_level
        self.address_names = []
        self.br_geo_point = br_geo_point
        self.drive_id = drive_id
        self.image_thumbnail_process = image_thumbnail_process
        self.tl_geo_point = tl_geo_point

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')

    def to_map(self):
        result = {}
        result['address_level'] = self.address_level
        result['address_names'] = []
        if self.address_names is not None:
            for k in self.address_names:
                result['address_names'].append(k)
        else:
            result['address_names'] = None
        result['br_geo_point'] = self.br_geo_point
        result['drive_id'] = self.drive_id
        result['image_thumbnail_process'] = self.image_thumbnail_process
        result['tl_geo_point'] = self.tl_geo_point
        return result

    def from_map(self, map={}):
        self.address_level = map.get('address_level')
        self.address_names = []
        if map.get('address_names') is not None:
            for k in map.get('address_names'):
                self.address_names.append(k)
        else:
            self.address_names = None
        self.br_geo_point = map.get('br_geo_point')
        self.drive_id = map.get('drive_id')
        self.image_thumbnail_process = map.get('image_thumbnail_process')
        self.tl_geo_point = map.get('tl_geo_point')
        return self


class SearchImageAddressGroupsResponse(TeaModel):
    """
    展示地点分组列表
    """
    def __init__(self, items=None):
        self.items = []

    def validate(self):
        if self.items:
            for k in self.items:
                if k :
                    k.validate()

    def to_map(self):
        result = {}
        result['items'] = []
        if self.items is not None:
            for k in self.items:
                result['items'].append(k.to_map() if k else None)
        else:
            result['items'] = None
        return result

    def from_map(self, map={}):
        self.items = []
        if map.get('items') is not None:
            for k in map.get('items'):
                temp_model = ImageAddressResponse()
                temp_model = temp_model.from_map(k)
                self.items.append(temp_model)
        else:
            self.items = None
        return self


class StoryResponse(TeaModel):
    """
    *
    """
    def __init__(self, cover_file_id=None, created_at=None, score=None, story_id=None, story_images_date_range=None, sub_title=None, title=None, updated_at=None, video_status=None, video_url=None):
        self.cover_file_id = cover_file_id
        self.created_at = created_at
        self.score = score
        self.story_id = story_id
        self.story_images_date_range = []
        self.sub_title = sub_title
        self.title = title
        self.updated_at = updated_at
        self.video_status = video_status
        self.video_url = video_url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['cover_file_id'] = self.cover_file_id
        result['created_at'] = self.created_at
        result['score'] = self.score
        result['story_id'] = self.story_id
        result['story_images_date_range'] = []
        if self.story_images_date_range is not None:
            for k in self.story_images_date_range:
                result['story_images_date_range'].append(k)
        else:
            result['story_images_date_range'] = None
        result['sub_title'] = self.sub_title
        result['title'] = self.title
        result['updated_at'] = self.updated_at
        result['video_status'] = self.video_status
        result['video_url'] = self.video_url
        return result

    def from_map(self, map={}):
        self.cover_file_id = map.get('cover_file_id')
        self.created_at = map.get('created_at')
        self.score = map.get('score')
        self.story_id = map.get('story_id')
        self.story_images_date_range = []
        if map.get('story_images_date_range') is not None:
            for k in map.get('story_images_date_range'):
                self.story_images_date_range.append(k)
        else:
            self.story_images_date_range = None
        self.sub_title = map.get('sub_title')
        self.title = map.get('title')
        self.updated_at = map.get('updated_at')
        self.video_status = map.get('video_status')
        self.video_url = map.get('video_url')
        return self


class UpdateFaceGroupInfoRequest(TeaModel):
    """
    Update face group info request
    """
    def __init__(self, drive_id=None, group_id=None, group_name=None):
        self.drive_id = drive_id
        self.group_id = group_id
        self.group_name = group_name

    def validate(self):
        self.validate_required(self.drive_id, 'drive_id')
        if self.drive_id:
            self.validate_pattern(self.drive_id, 'drive_id', '[0-9]+')
        self.validate_required(self.group_id, 'group_id')

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['group_id'] = self.group_id
        result['group_name'] = self.group_name
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.group_id = map.get('group_id')
        self.group_name = map.get('group_name')
        return self


class UpdateFaceGroupInfoResponse(TeaModel):
    """
    更新人脸分组信息结果
    """
    def __init__(self, drive_id=None, group_id=None):
        self.drive_id = drive_id
        self.group_id = group_id

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['drive_id'] = self.drive_id
        result['group_id'] = self.group_id
        return result

    def from_map(self, map={}):
        self.drive_id = map.get('drive_id')
        self.group_id = map.get('group_id')
        return self


class UrlInfo(TeaModel):
    """
    *
    """
    def __init__(self, download_url=None, thumbnail=None, url=None):
        self.download_url = download_url
        self.thumbnail = thumbnail
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        result = {}
        result['download_url'] = self.download_url
        result['thumbnail'] = self.thumbnail
        result['url'] = self.url
        return result

    def from_map(self, map={}):
        self.download_url = map.get('download_url')
        self.thumbnail = map.get('thumbnail')
        self.url = map.get('url')
        return self
