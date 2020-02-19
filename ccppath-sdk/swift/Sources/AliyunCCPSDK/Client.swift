// This file is auto-generated, don't edit it. Thanks.

import Foundation
import Tea

open class Client : BaseClient {
    public init(config:Config) {
        super.init(config.toMap())
    }

    public func cancelLink(request:CancelLinkRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/cancel_link")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), AccountAccessTokenResponse()) as? AccountAccessTokenResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func confirmLink(request:ConfirmLinkRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/confirm_link")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), AccountAccessTokenResponse()) as? AccountAccessTokenResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func changePassword(request:DefaultChangePasswordRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/default/change_password")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 204) {
                    return nil
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func setPassword(request:DefaultSetPasswordRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/default/set_password")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 204) {
                    return nil
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getAccessTokenByLinkInfo(request:GetAccessTokenByLinkInfoRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/get_access_token_by_link_info")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), AccountAccessTokenResponse()) as? AccountAccessTokenResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getCaptcha(request:GetCaptchaRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/get_captcha")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), Captcha()) as? Captcha
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getLinkInfo(request:GetByLinkInfoRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/get_link_info")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), LinkInfoResponse()) as? LinkInfoResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getLinkInfoByUserId(request:GetLinkInfoByUserIDRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/get_link_info_by_user_id")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), LinkInfoListResponse()) as? LinkInfoListResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func link(request:AccountLinkRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/link")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), AccountAccessTokenResponse()) as? AccountAccessTokenResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func checkExist(request:MobileCheckExistRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/mobile/check_exist")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), MobileCheckExistResponse()) as? MobileCheckExistResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func login(request:MobileLoginRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/mobile/login")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), AccountAccessTokenResponse()) as? AccountAccessTokenResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func register(request:MobileRegisterRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/mobile/register")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), AccountAccessTokenResponse()) as? AccountAccessTokenResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func mobileSendSmsCode(request:MobileSendSmsCodeRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/mobile/send_sms_code")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), MobileSendSmsCodeResponse()) as? MobileSendSmsCodeResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func token(request:TokenRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/account/token")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".auth.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), AccountAccessTokenResponse()) as? AccountAccessTokenResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getAsyncTaskInfo(request:CCPGetAsyncTaskRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/async_task/get")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPGetAsyncTaskResponse()) as? CCPGetAsyncTaskResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func operation(request:CCPBatchRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/batch")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPBatchResponse()) as? CCPBatchResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func createDrive(request:CreateDriveRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/drive/create")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 201) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CreateDriveResponse()) as? CreateDriveResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func deleteDrive(request:DeleteDriveRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/drive/delete")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 204) {
                    return nil
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getDrive(request:GetDriveRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/drive/get")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), GetDriveResponse()) as? GetDriveResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getDefaultDrive(request:GetDefaultDriveRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/drive/get_default_drive")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), GetDriveResponse()) as? GetDriveResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func listDrives(request:ListDriveRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/drive/list")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), ListDriveResponse()) as? ListDriveResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func listMyDrives(request:ListMyDriveRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/drive/list_my_drives")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), ListDriveResponse()) as? ListDriveResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func updateDrive(request:UpdateDriveRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/drive/update")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), UpdateDriveResponse()) as? UpdateDriveResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func completeFile(request:CCPCompleteFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/complete")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPCompleteFileResponse()) as? CCPCompleteFileResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func copyFile(request:CCPCopyFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/copy")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 201) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPCopyFileResponse()) as? CCPCopyFileResponse
                }
                if super._isStatusCode(response_, 202) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPCopyFileResponse()) as? CCPCopyFileResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func createFile(request:CCPCreateFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/create")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 201) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPCreateFileResponse()) as? CCPCreateFileResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func deleteFile(request:CCPDeleteFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/delete")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 202) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPDeleteFileResponse()) as? CCPDeleteFileResponse
                }
                if super._isStatusCode(response_, 204) {
                    return nil
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func downloadFile(request:DownloadFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "GET"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/download")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com")
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getFile(request:CCPGetFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/get")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPGetFileResponse()) as? CCPGetFileResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getDownloadUrl(request:CCPGetDownloadUrlRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/get_download_url")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPGetDownloadUrlResponse()) as? CCPGetDownloadUrlResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getUploadUrl(request:CCPGetUploadUrlRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/get_upload_url")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPGetUploadUrlResponse()) as? CCPGetUploadUrlResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func listFile(request:CCPListFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/list")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPListFileResponse()) as? CCPListFileResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func listUploadedParts(request:CCPListUploadedPartRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/list_uploaded_parts")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPListUploadedPartResponse()) as? CCPListUploadedPartResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func moveFile(request:CCPMoveFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/move")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPMoveFileResponse()) as? CCPMoveFileResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func searchFile(request:CCPSearchFileRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/search")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPSearchFileResponse()) as? CCPSearchFileResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func updateFile(request:CCPUpdateFileMetaRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/file/update")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CCPUpdateFileMetaResponse()) as? CCPUpdateFileMetaResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func createUser(request:CreateUserRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/user/create")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 201) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), CreateUserResponse()) as? CreateUserResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func deleteUser(request:DeleteUserRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/user/delete")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 204) {
                    return nil
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func getUser(request:GetUserRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/user/get")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), GetUserResponse()) as? GetUserResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func listUsers(request:ListUserRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/user/list")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), ListUserResponse()) as? ListUserResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func searchUser(request:SearchUserRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/user/search")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), ListUserResponse()) as? ListUserResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }

    public func updateUser(request:UpdateUserRequest, runtime:RuntimeOptions) throws {
        try! request.validate()
        try! runtime.validate()
        var runtime_:[String:Any] = [
            "timeouted": "retry",
            "readTimeout": runtime.readTimeout,
            "connectTimeout": runtime.connectTimeout,
            "localAddr": runtime.localAddr,
            "httpProxy": runtime.httpProxy,
            "httpsProxy": runtime.httpsProxy,
            "noProxy": runtime.noProxy,
            "maxIdleConns": runtime.maxIdleConns,
            "socks5Proxy": runtime.socks5Proxy,
            "socks5NetWork": runtime.socks5NetWork,
            "retry": [
                "retryable": runtime.autoretry,
                "maxAttempts": super._defaultNumber(runtime.maxAttempts, 3)
            ],
            "backoff": [
                "policy": super._default(runtime.backoffPolicy, "no"),
                "period": super._defaultNumber(runtime.backoffPeriod, 1)
            ],
            "ignoreSSL": runtime.ignoreSSL
        ]
        var _lastRequest:TeaRequest? = nil
        var _now:Int32 = Int32(Date().timeIntervalSince1970)
        var _retryTimes:Int = 0
        while TeaCore.allowRetry(runtime_["retry"], _retryTimes, _now) {
            if _retryTimes > 0 {
                var _backoffTime:Int = TeaCore.getBackoffTime(runtime_["backoff"], _retryTimes)
                if _backoffTime > 0 {
                    TeaCore.sleep(_backoffTime)
                }
            }
            _retryTimes = _retryTimes + 1
            do {
                var request_ = TeaRequest()
                var accesskeyId:String = super._getAccessKeyId()
                var accessKeySecret:String = super._getAccessKeySecret()
                var accessToken:String = super._getAccessToken()
                request_.protocol_ = super._getProtocol(super._protocol, "https")
                request_.method = "POST"
                request_.pathname = super._getPathname(super._nickname, "/v2/user/update")
                request_.headers = [
                    "user-agent": super._getUserAgent(),
                    "host": super._getHost(super._endpoint, "" + super._domainId + ".api.alicloudccp.com"),
                    "content-type": "application/json; charset=utf-8"
                ]
                if super._notEmpty(accessToken) {
                    request_.headers["authorization"] = "Bearer " + accessToken + ""
                }
                else if super._notEmpty(accesskeyId) && super._notEmpty(accessKeySecret) {
                    request_.headers["date"] = super._getRFC2616Date()
                    request_.headers["accept"] = "application/json"
                    request_.headers["x-acs-signature-method"] = "HMAC-SHA1"
                    request_.headers["x-acs-signature-version"] = "1.0"
                    request_.headers["authorization"] = "acs " + accesskeyId + ":" + super._getSignature(request_) + ""
                }
                request_.body = super._toJSONString([request])
                _lastRequest = request_
                let response_ = TeaCore.doAction(request_, runtime_)
                var respMap:[String:AnyObject]? = nil
                if super._isStatusCode(response_, 200) {
                    respMap = super._readAsJSON(response_)
                    return TeaModel.toModel(TeaConverter.merge(
                        [
                            "requestId": response_.headers["x-ca-request-id"]
                        ],
                        respMap!
                    ), UpdateUserResponse()) as? UpdateUserResponse
                }
                if super._notEmpty(response_.headers["x-ca-error-message"]) {
                    throw TeaException.Error([
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ],
                        "message": response_.headers["x-ca-error-message"]
                    ])
                }
                respMap = super._readAsJSON(response_)
                throw TeaException.Error([                    [
                        "data": [
                            "requestId": response_.headers["x-ca-request-id"],
                            "statusCode": response_.statusCode,
                            "statusMessage": response_.statusMessage
                        ]
                    ],
                    respMap
                ])
            }
            catch let e as TeaException {
                if TeaCore.isRetryable(e) {
                    continue
                }
                throw e
            }
        }
        throw TeaException.Unretryable(_lastRequest)
    }
}
