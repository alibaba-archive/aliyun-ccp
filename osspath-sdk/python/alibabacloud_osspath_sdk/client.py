# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
import time

from alibabacloud_ccp_credentials.client import Client as AccessTokenCredentialClient
from alibabacloud_credentials.client import Client as CredentialClient
from alibabacloud_osspath_sdk import models as osspath_models
from alibabacloud_tea_util.client import Client as UtilClient
from Tea.exceptions import TeaException
from alibabacloud_ccp_credentials import models as access_token_credential_models
from alibabacloud_credentials import models as credential_models
from Tea.request import TeaRequest
from Tea.core import TeaCore
from Tea.response import TeaResponse
from alibabacloud_roa_util.client import Client as ROAUtilClient
from Tea.exceptions import UnretryableException


class Client(object):
    """
    *
    """
    def __init__(self, config, _domain_id=None, _access_token_credential=None, _endpoint=None, _protocol=None,
                 _nickname=None, _user_agent=None, _credential=None):
        self._domain_id = _domain_id
        self._access_token_credential = _access_token_credential
        self._endpoint = _endpoint
        self._protocol = _protocol
        self._nickname = _nickname
        self._user_agent = _user_agent
        self._credential = _credential
        if UtilClient.is_unset(config.to_map()):
            raise TeaException({
                "name": "ParameterMissing",
                "message": "'config' can not be unset"
            })
        if not UtilClient.empty(config.access_token) or not UtilClient.empty(config.refresh_token):
            access_config = access_token_credential_models.Config(
                access_token=config.access_token,
                endpoint=config.endpoint,
                domain_id=config.domain_id,
                client_id=config.client_id,
                refresh_token=config.refresh_token,
                client_secret=config.client_secret,
                expire_time=config.expire_time
            )
            self._access_token_credential = AccessTokenCredentialClient(access_config)
        if not UtilClient.empty(config.access_key_id):
            if UtilClient.empty(config.type):
                config.type = "access_key"
            credential_config = credential_models.Config(
                access_key_id=config.access_key_id,
                type=config.type,
                access_key_secret=config.access_key_secret,
                security_token=config.security_token
            )
            self._credential = CredentialClient(credential_config)
        self._endpoint = config.endpoint
        self._protocol = config.protocol
        self._user_agent = config.user_agent
        self._nickname = config.nickname
        self._domain_id = config.domain_id

    def cancel_link(self, request, runtime):
        """
        取消绑定关系，生成新用户，返回访问令牌
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/cancel_link")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.CancelLinkModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def confirm_link(self, request, runtime):
        """
        确认绑定关系, 成功后返回访问令牌
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/confirm_link")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ConfirmLinkModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def change_password(self, request, runtime):
        """
        修改手机登录密码，密码必须包含数字和字母，长度8-20个字符
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/default/change_password")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ChangePasswordModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def set_password(self, request, runtime):
        """
        设置手机登录密码，密码必须包含数字和字母，长度8-20个字符
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/default/set_password")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 204):
                    return osspath_models.SetPasswordModel().from_map({
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def verify_code(self, request, runtime):
        """
        校验手机短信验证码，用于重置密码时校验手机，通过校验后返回state，可通过state重新设置密码
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/default/verify_code")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.VerifyCodeModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_access_token_by_link_info(self, request, runtime):
        """
        管理员通过账号信息直接获取用户的访问令牌
        @tags account
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/get_access_token_by_link_info")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetAccessTokenByLinkInfoModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_captcha(self, request, runtime):
        """
        获取图片验证码，用于人机校验，默认不需要
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/get_captcha")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetCaptchaModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_link_info(self, request, runtime):
        """
        获取用户认证方式详情
        @tags account
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/get_link_info")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetLinkInfoModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_link_info_by_user_id(self, request, runtime):
        """
        获取用户的所有绑定信息
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/get_link_info_by_user_id")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetLinkInfoByUserIdModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_public_key(self, request, runtime):
        """
        获取公钥，用于加密对称密钥
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/get_public_key")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetPublicKeyModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def link(self, request, runtime):
        """
        绑定用户认证方式
        @tags account
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error AlreadyExist {resource} has already exists. {extra_msg}
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/link")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.LinkModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def check_exist(self, request, runtime):
        """
        查询手机号是否已被注册
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/mobile/check_exist")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.CheckExistModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def login(self, request, runtime):
        """
        通过手机号+短信或密码登录，返回刷新令牌和访问令牌
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/mobile/login")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.LoginModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def register(self, request, runtime):
        """
        通过手机号+短信验证码注册账号
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error AlreadyExist {resource} has already exists. {extra_msg}
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/mobile/register")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.RegisterModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def mobile_send_sms_code(self, request, runtime):
        """
        发送短信验证码，用于登录、注册、修改密码、绑定等
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/mobile/send_sms_code")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.MobileSendSmsCodeModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def account_revoke(self, request, runtime):
        """
        用户退出登录
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/revoke")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 204):
                    return osspath_models.AccountRevokeModel().from_map({
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def account_token(self, request, runtime):
        """
        用户通过刷新令牌（refresh_token）获取访问令牌（access_token）
        @tags account
        @error InvalidParameterMissing The input parameter {parameter_name} is missing.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/account/token")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.AccountTokenModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def admin_list_stores(self, request, runtime):
        """
        列举Store列表
        @tags admin
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error Forbidden User not authorized to operate on the specified APIs.
        @error InternalError The request has been failed due to some unknown error.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/domain/list_stores")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.AdminListStoresModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_user_access_token(self, request, runtime):
        """
        获取用户的accessToken
        @tags admin
        @error undefined undefined
        @error undefined undefined
        @error undefined undefined
        @error undefined undefined
        @error undefined undefined
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/user/get_access_token")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetUserAccessTokenModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def create_drive(self, request, runtime):
        """
        支持normal和large两种drive，
        large类型的drive用于文件数多的场景，不支持list操作，
        当drive的文件数量大于1亿时，建议使用large类型。
        @tags drive
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/drive/create")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 201):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.CreateDriveModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_drive(self, request, runtime):
        """
        删除指定drive_id对应的Drive
        @tags drive
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/drive/delete")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 204):
                    return osspath_models.DeleteDriveModel().from_map({
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_drive(self, request, runtime):
        """
        获取指定drive_id对应的Drive详细信息。
        @tags drive
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/drive/get")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetDriveModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_default_drive(self, request, runtime):
        """
        一个用户可拥有多个drive，在创建drive时通过参数指定是否为这个用户的默认drive，
        每个用户只能设置一个默认drive。
        @tags drive
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/drive/get_default_drive")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetDefaultDriveModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_drives(self, request, runtime):
        """
        管理员列举指定用户的Drive
        @tags drive
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/drive/list")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ListDrivesModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_my_drives(self, request, runtime):
        """
        列举当前用户（访问令牌）的Drive
        @tags drive
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/drive/list_my_drives")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ListMyDrivesModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def update_drive(self, request, runtime):
        """
        更新指定drive_id的Drive信息
        @tags drive
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/drive/update")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.UpdateDriveModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def complete_file(self, request, runtime):
        """
        完成文件上传
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/complete")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.CompleteFileModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def copy_file(self, request, runtime):
        """
        指定源文件或文件夹路径，拷贝到指定的文件夹。
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/copy")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 201):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.CopyFileModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def create_file(self, request, runtime):
        """
        创建文件或者文件夹。
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error AlreadyExist {resource} has already exists. {extra_msg}
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/create")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 201):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.CreateFileModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_file(self, request, runtime):
        """
        指定文件或文件夹路径，删除文件或文件夹
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/delete")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 204):
                    return osspath_models.DeleteFileModel().from_map({
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_file(self, request, runtime):
        """
        获取指定文件或文件夹路径，获取文件或文件夹信息。
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/get")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetFileModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_download_url(self, request, runtime):
        """
        指定文件路径，获取文件下载地址
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/get_download_url")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetDownloadUrlModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_secure_url(self, request, runtime):
        """
        指定文件路径，获取文件安全地址
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/get_secure_url")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetSecureUrlModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_upload_url(self, request, runtime):
        """
        可指定分片信息，一次获取多个分片的上传地址。
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/get_upload_url")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetUploadUrlModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_file(self, request, runtime):
        """
        指定父文件夹路径，列举文件夹下的文件或者文件夹
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/list")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ListFileModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_uploaded_parts(self, request, runtime):
        """
        列举UploadID对应的已上传分片。
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/list_uploaded_parts")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ListUploadedPartsModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def move_file(self, request, runtime):
        """
        指定源文件或文件夹路径，移动到指定的文件夹。
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/move")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.MoveFileModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def video_definition(self, request, runtime):
        """
        获取视频支持的分辨率
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/video_definition")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.VideoDefinitionModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def video_license(self, request, runtime):
        """
        获取视频的DRM License
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/video_license")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.VideoLicenseModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def video_m3u_8(self, request, runtime):
        """
        获取视频转码后的m3u8文件
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/video_m3u8")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    byt = UtilClient.read_as_bytes(_response.body)
                    return osspath_models.VideoM3u8Model().from_map({
                        "body": byt,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def video_transcode(self, request, runtime):
        """
        将mp4格式的视频文件，转为m3u8
        @tags file
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/file/video_transcode")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.VideoTranscodeModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if UtilClient.equal_number(_response.status_code, 204):
                    return osspath_models.VideoTranscodeModel().from_map({
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def create_share(self, request, runtime):
        """
        创建共享。
        @tags share
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/share/create")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 201):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.CreateShareModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_share(self, request, runtime):
        """
        删除指定共享
        @tags share
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/share/delete")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 204):
                    return osspath_models.DeleteShareModel().from_map({
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_share(self, request, runtime):
        """
        获取共享信息。
        @tags share
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/share/get")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetShareModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_share(self, request, runtime):
        """
        列举指定用户的共享
        @tags share
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/share/list")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ListShareModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def update_share(self, request, runtime):
        """
        修改指定共享
        @tags share
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/share/update")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.UpdateShareModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_storefile(self, request, runtime):
        """
        列举指定store下的所有文件。
        @tags store
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/osspath/store_file/list")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ListStorefileModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def create_user(self, request, runtime):
        """
        创建用户，只有管理员可以调用
        @tags user
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/user/create")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 201):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.CreateUserModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def delete_user(self, request, runtime):
        """
        只有管理员可以调用
        @tags user
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/user/delete")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 204):
                    return osspath_models.DeleteUserModel().from_map({
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_user(self, request, runtime):
        """
        获取用户详细信息，普通用户只能获取自己的信息，管理员可以获取任意用户的信息。
        @tags user
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/user/get")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.GetUserModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def list_users(self, request, runtime):
        """
        只有管理员可以调用
        @tags user
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/user/list")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.ListUsersModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def search_user(self, request, runtime):
        """
        该接口将会根据条件查询用户，只有管理员可以调用
        @tags user
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/user/search")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.SearchUserModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def update_user(self, request, runtime):
        """
        用户可以修改自己的description，nick_name，avatar；
        管理员在用户基础上还可修改status（可以修改任意用户）；
        超级管理员在管理员基础上还可修改role（可以修改任意用户）。
        @tags user
        @error InvalidParameter The input parameter {parameter_name} is not valid.
        @error AccessTokenInvalid AccessToken is invalid. {message}
        @error ForbiddenNoPermission No Permission to access resource {resource_name}.
        @error NotFound The resource {resource_name} cannot be found. Please check.
        @error InternalError The request has been failed due to some unknown error.
        @error ServiceUnavailable The request has failed due to a temporary failure of the server.
        """
        request.validate()
        runtime.validate()
        _runtime = {
            "timeouted": "retry",
            "readTimeout": runtime.read_timeout,
            "connectTimeout": runtime.connect_timeout,
            "localAddr": runtime.local_addr,
            "httpProxy": runtime.http_proxy,
            "httpsProxy": runtime.https_proxy,
            "noProxy": runtime.no_proxy,
            "maxIdleConns": runtime.max_idle_conns,
            "socks5Proxy": runtime.socks_5proxy,
            "socks5NetWork": runtime.socks_5net_work,
            "retry": {
                "retryable": runtime.autoretry,
                "maxAttempts": UtilClient.default_number(runtime.max_attempts, 3)
            },
            "backoff": {
                "policy": UtilClient.default_string(runtime.backoff_policy, "no"),
                "period": UtilClient.default_number(runtime.backoff_period, 1)
            },
            "ignoreSSL": runtime.ignore_ssl
        }
        _last_request = None
        _last_exception = None
        _now = time.time()
        _retry_times = 0
        while TeaCore.allow_retry(_runtime.get('retry'), _retry_times, _now):
            if _retry_times > 0:
                _backoff_time = TeaCore.get_backoff_time(_runtime.get('backoff'), _retry_times)
                if _backoff_time > 0:
                    TeaCore.sleep(_backoff_time)
            _retry_times = _retry_times + 1
            try:
                _request = TeaRequest()
                accesskey_id = self.get_access_key_id()
                access_key_secret = self.get_access_key_secret()
                security_token = self.get_security_token()
                access_token = self.get_access_token()
                _request.protocol = UtilClient.default_string(self._protocol, "https")
                _request.method = "POST"
                _request.pathname = self.get_pathname(self._nickname, "/v2/user/update")
                _request.headers = TeaCore.merge({
                    "user-agent": self.get_user_agent(),
                    "host": UtilClient.default_string(self._endpoint, "" + str(self._domain_id) + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                }, request.headers)
                if not UtilClient.empty(access_token):
                    _request.headers["authorization"] = "Bearer " + str(access_token) + ""
                elif not UtilClient.empty(accesskey_id) and not UtilClient.empty(access_key_secret):
                    if not UtilClient.empty(security_token):
                        _request.headers["x-acs-security-token"] = security_token
                    _request.headers["date"] = UtilClient.get_date_utcstring()
                    _request.headers["accept"] = "application/json"
                    _request.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    _request.headers["x-acs-signature-version"] = "1.0"
                    string_to_sign = ROAUtilClient.get_string_to_sign(_request)
                    _request.headers["authorization"] = "acs " + str(accesskey_id) + ":" + str(ROAUtilClient.get_signature(string_to_sign, access_key_secret)) + ""
                _request.body = UtilClient.to_jsonstring(request.body.to_map())
                _last_request = _request
                _response = TeaCore.do_action(_request, _runtime)
                resp_map = None
                obj = None
                if UtilClient.equal_number(_response.status_code, 200):
                    obj = UtilClient.read_as_json(_response.body)
                    resp_map = UtilClient.assert_as_map(obj)
                    return osspath_models.UpdateUserModel().from_map({
                        "body": resp_map,
                        "headers": _response.headers
                    })

                if not UtilClient.empty(_response.headers.get('x-ca-error-message')):
                    raise TeaException({
                        "data": {
                            "requestId": _response.headers.get('x-ca-request-id'),
                            "statusCode": _response.status_code,
                            "statusMessage": _response.status_message
                        },
                        "message": _response.headers.get('x-ca-error-message')
                    })
                obj = UtilClient.read_as_json(_response.body)
                resp_map = UtilClient.assert_as_map(obj)
                raise TeaException(TeaCore.merge({
                    "data": {
                        "requestId": _response.headers.get('x-ca-request-id'),
                        "statusCode": _response.status_code,
                        "statusMessage": _response.status_message
                    }
                }, resp_map))
            except Exception as e:
                if TeaCore.is_retryable(e):
                    _last_exception = e
                    continue
                raise e
        raise UnretryableException(_last_request, _last_exception)

    def get_pathname(self, nickname, path):
        if UtilClient.empty(nickname):
            return path
        return "/" + str(nickname) + "" + str(path) + ""

    def set_expire_time(self, expire_time):
        if UtilClient.is_unset(self._access_token_credential):
            return
        self._access_token_credential.set_expire_time(expire_time)

    def get_expire_time(self):
        if UtilClient.is_unset(self._access_token_credential):
            return ''
        expire_time = self._access_token_credential.get_expire_time()
        return expire_time

    def set_refresh_token(self, token):
        if UtilClient.is_unset(self._access_token_credential):
            return
        self._access_token_credential.set_refresh_token(token)

    def get_refresh_token(self):
        if UtilClient.is_unset(self._access_token_credential):
            return ''
        token = self._access_token_credential.get_refresh_token()
        return token

    def set_access_token(self, token):
        if UtilClient.is_unset(self._access_token_credential):
            return
        self._access_token_credential.set_access_token(token)

    def get_access_token(self):
        if UtilClient.is_unset(self._access_token_credential):
            return ''
        token = self._access_token_credential.get_access_token()
        return token

    def set_user_agent(self, user_agent):
        self._user_agent = user_agent

    def append_user_agent(self, user_agent):
        self._user_agent = "" + str(self._user_agent) + " " + str(user_agent) + ""

    def get_user_agent(self):
        user_agent = UtilClient.get_user_agent(self._user_agent)
        return user_agent

    def get_access_key_id(self):
        if UtilClient.is_unset(self._credential):
            return ''
        access_key_id = self._credential.get_access_key_id()
        return access_key_id

    def get_access_key_secret(self):
        if UtilClient.is_unset(self._credential):
            return ''
        secret = self._credential.get_access_key_secret()
        return secret

    def get_security_token(self):
        if UtilClient.is_unset(self._credential):
            return ''
        token = self._credential.get_security_token()
        return token
