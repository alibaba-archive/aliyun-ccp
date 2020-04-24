// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient;

import com.aliyun.tea.*;
import com.aliyun.ccp.ccpclient.models.*;

public class Client {

    public String _domainId;
    public com.aliyun.ccpcredentials.Client _accessTokenCredential;
    public String _endpoint;
    public String _protocol;
    public String _nickname;
    public String _userAgent;
    public com.aliyun.credentials.Client _credential;
    public Client(Config config) throws Exception {
        if (com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(config))) {
            throw new TeaException(TeaConverter.buildMap(
                new TeaPair("name", "ParameterMissing"),
                new TeaPair("message", "'config' can not be unset")
            ));
        }

        if (!com.aliyun.teautil.Common.empty(config.accessToken) || !com.aliyun.teautil.Common.empty(config.refreshToken)) {
            com.aliyun.ccpcredentials.models.Config accessConfig = com.aliyun.ccpcredentials.models.Config.build(TeaConverter.buildMap(
                new TeaPair("accessToken", config.accessToken),
                new TeaPair("endpoint", config.endpoint),
                new TeaPair("domainId", config.domainId),
                new TeaPair("clientId", config.clientId),
                new TeaPair("refreshToken", config.refreshToken),
                new TeaPair("clientSecret", config.clientSecret),
                new TeaPair("expireTime", config.expireTime)
            ));
            this._accessTokenCredential = new com.aliyun.ccpcredentials.Client(accessConfig);
        }

        if (!com.aliyun.teautil.Common.empty(config.accessKeyId)) {
            if (com.aliyun.teautil.Common.empty(config.type)) {
                config.type = "access_key";
            }

            com.aliyun.credentials.models.Config credentialConfig = com.aliyun.credentials.models.Config.build(TeaConverter.buildMap(
                new TeaPair("accessKeyId", config.accessKeyId),
                new TeaPair("type", config.type),
                new TeaPair("accessKeySecret", config.accessKeySecret),
                new TeaPair("securityToken", config.securityToken)
            ));
            this._credential = new com.aliyun.credentials.Client(credentialConfig);
        }

        this._endpoint = config.endpoint;
        this._protocol = config.protocol;
        this._userAgent = config.userAgent;
        this._nickname = config.nickname;
        this._domainId = config.domainId;
    }

    public CancelLinkModel cancelLink(CancelLinkRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/cancel_link");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new CancelLinkModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ConfirmLinkModel confirmLink(ConfirmLinkRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/confirm_link");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ConfirmLinkModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ChangePasswordModel changePassword(ChangePasswordRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/default/change_password");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 204)) {
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("headers", response_.headers)
                    ), new ChangePasswordModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public SetPasswordModel setPassword(SetPasswordRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/default/set_password");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 204)) {
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("headers", response_.headers)
                    ), new SetPasswordModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetAccessTokenByLinkInfoModel getAccessTokenByLinkInfo(GetAccessTokenByLinkInfoRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/get_access_token_by_link_info");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetAccessTokenByLinkInfoModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetCaptchaModel getCaptcha(GetCaptchaRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/get_captcha");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetCaptchaModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetLinkInfoModel getLinkInfo(GetLinkInfoRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/get_link_info");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetLinkInfoModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetLinkInfoByUserIdModel getLinkInfoByUserId(GetLinkInfoByUserIdRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/get_link_info_by_user_id");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetLinkInfoByUserIdModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public LinkModel link(LinkRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/link");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new LinkModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CheckExistModel checkExist(CheckExistRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/mobile/check_exist");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new CheckExistModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public LoginModel login(LoginRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/mobile/login");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new LoginModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public RegisterModel register(RegisterRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/mobile/register");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new RegisterModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public MobileSendSmsCodeModel mobileSendSmsCode(MobileSendSmsCodeRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/mobile/send_sms_code");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new MobileSendSmsCodeModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public TokenModel token(TokenRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/account/token");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new TokenModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetAsyncTaskInfoModel getAsyncTaskInfo(GetAsyncTaskInfoRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/async_task/get");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetAsyncTaskInfoModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public BatchOperationModel batchOperation(BatchOperationRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/batch");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new BatchOperationModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CreateDriveModel createDrive(CreateDriveRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/drive/create");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 201)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new CreateDriveModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteDriveModel deleteDrive(DeleteDriveRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/drive/delete");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 204)) {
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("headers", response_.headers)
                    ), new DeleteDriveModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetDriveModel getDrive(GetDriveRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/drive/get");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetDriveModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetDefaultDriveModel getDefaultDrive(GetDefaultDriveRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/drive/get_default_drive");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetDefaultDriveModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListDrivesModel listDrives(ListDrivesRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/drive/list");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListDrivesModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListMyDrivesModel listMyDrives(ListMyDrivesRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/drive/list_my_drives");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListMyDrivesModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public UpdateDriveModel updateDrive(UpdateDriveRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/drive/update");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new UpdateDriveModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CompleteFileModel completeFile(CompleteFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/complete");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new CompleteFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CopyFileModel copyFile(CopyFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/copy");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 201)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new CopyFileModel());
                }

                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 202)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new CopyFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CreateFileModel createFile(CreateFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/create");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 201)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new CreateFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteFileModel deleteFile(DeleteFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/delete");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 202)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new DeleteFileModel());
                }

                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 204)) {
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("headers", response_.headers)
                    ), new DeleteFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DownloadFileModel downloadFile(DownloadFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "GET";
                request_.pathname = this.getPathname(_nickname, "/v2/file/download");
                request_.query = com.aliyun.teautil.Common.stringifyMapValue(TeaModel.buildMap(request.query));
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com"))
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetFileModel getFile(GetFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/get");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetFileByPathModel getFileByPath(GetFileByPathRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/get_by_path");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetFileByPathModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetDownloadUrlModel getDownloadUrl(GetDownloadUrlRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/get_download_url");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetDownloadUrlModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetLastCursorModel getLastCursor(GetLastCursorRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/get_last_cursor");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetLastCursorModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetUploadUrlModel getUploadUrl(GetUploadUrlRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/get_upload_url");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetUploadUrlModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListFileModel listFile(ListFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/list");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListFileByCustomIndexKeyModel listFileByCustomIndexKey(ListFileByCustomIndexKeyRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/list_by_custom_index_key");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListFileByCustomIndexKeyModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListFileDeltaModel listFileDelta(ListFileDeltaRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/list_delta");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListFileDeltaModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListUploadedPartsModel listUploadedParts(ListUploadedPartsRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/list_uploaded_parts");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListUploadedPartsModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public MoveFileModel moveFile(MoveFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/move");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new MoveFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ScanFileMetaModel scanFileMeta(ScanFileMetaRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/scan");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ScanFileMetaModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public SearchFileModel searchFile(SearchFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/search");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new SearchFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public UpdateFileModel updateFile(UpdateFileRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/file/update");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new UpdateFileModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public CreateUserModel createUser(CreateUserRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/user/create");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 201)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new CreateUserModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public DeleteUserModel deleteUser(DeleteUserRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/user/delete");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 204)) {
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("headers", response_.headers)
                    ), new DeleteUserModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetUserModel getUser(GetUserRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/user/get");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetUserModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListUsersModel listUsers(ListUsersRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/user/list");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListUsersModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public SearchUserModel searchUser(SearchUserRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/user/search");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new SearchUserModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public UpdateUserModel updateUser(UpdateUserRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/user/update");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new UpdateUserModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public GetPhotoCountModel getPhotoCount(GetPhotoCountRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/image/get_photo_count");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new GetPhotoCountModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListAddressGroupsModel listAddressGroups(ListAddressGroupsRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/image/list_address_groups");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListAddressGroupsModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListFaceGroupsModel listFaceGroups(ListFaceGroupsRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/image/list_face_groups");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListFaceGroupsModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public ListTagsModel listTags(ListTagsRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/image/list_tags");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new ListTagsModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public SearchAddressGroupsModel searchAddressGroups(SearchAddressGroupsRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/image/search_address_groups");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new SearchAddressGroupsModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public UpdateFacegroupInfoModel updateFacegroupInfo(UpdateFacegroupInfoRequestModel request, RuntimeOptions runtime) throws Exception {
        TeaModel.validateParams(request, "request");
        TeaModel.validateParams(runtime, "runtime");
        java.util.Map<String, Object> runtime_ = TeaConverter.buildMap(
            new TeaPair("timeouted", "retry"),
            new TeaPair("readTimeout", runtime.readTimeout),
            new TeaPair("connectTimeout", runtime.connectTimeout),
            new TeaPair("localAddr", runtime.localAddr),
            new TeaPair("httpProxy", runtime.httpProxy),
            new TeaPair("httpsProxy", runtime.httpsProxy),
            new TeaPair("noProxy", runtime.noProxy),
            new TeaPair("maxIdleConns", runtime.maxIdleConns),
            new TeaPair("socks5Proxy", runtime.socks5Proxy),
            new TeaPair("socks5NetWork", runtime.socks5NetWork),
            new TeaPair("retry", TeaConverter.buildMap(
                new TeaPair("retryable", runtime.autoretry),
                new TeaPair("maxAttempts", com.aliyun.teautil.Common.defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", com.aliyun.teautil.Common.defaultString(runtime.backoffPolicy, "no")),
                new TeaPair("period", com.aliyun.teautil.Common.defaultNumber(runtime.backoffPeriod, 1))
            )),
            new TeaPair("ignoreSSL", runtime.ignoreSSL)
        );

        TeaRequest _lastRequest = null;
        long _now = System.currentTimeMillis();
        int _retryTimes = 0;
        while (Tea.allowRetry((java.util.Map<String, Object>) runtime_.get("retry"), _retryTimes, _now)) {
            if (_retryTimes > 0) {
                int backoffTime = Tea.getBackoffTime(runtime_.get("backoff"), _retryTimes);
                if (backoffTime > 0) {
                    Tea.sleep(backoffTime);
                }
            }
            _retryTimes = _retryTimes + 1;
            try {
                TeaRequest request_ = new TeaRequest();
                String accesskeyId = this.getAccessKeyId();
                String accessKeySecret = this.getAccessKeySecret();
                String securityToken = this.getSecurityToken();
                String accessToken = this.getAccessToken();
                request_.protocol = com.aliyun.teautil.Common.defaultString(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this.getPathname(_nickname, "/v2/image/update_facegroup_info");
                request_.headers = TeaConverter.merge(String.class,
                    TeaConverter.buildMap(
                        new TeaPair("user-agent", this.getUserAgent()),
                        new TeaPair("host", com.aliyun.teautil.Common.defaultString(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                        new TeaPair("content-type", "application/json; charset=utf-8")
                    ),
                    request.headers
                );
                if (!com.aliyun.teautil.Common.empty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (!com.aliyun.teautil.Common.empty(accesskeyId) && !com.aliyun.teautil.Common.empty(accessKeySecret)) {
                    if (!com.aliyun.teautil.Common.empty(securityToken)) {
                        request_.headers.put("x-acs-security-token", securityToken);
                    }

                    request_.headers.put("date", com.aliyun.teautil.Common.getDateUTCString());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    String stringToSign = com.aliyun.roautil.Client.getStringToSign(request_);
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + com.aliyun.roautil.Client.getSignature(stringToSign, accessKeySecret) + "");
                }

                request_.body = Tea.toReadable(com.aliyun.teautil.Common.toJSONString(TeaModel.buildMap(request.body)));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                java.util.Map<String, Object> respMap = null;
                Object obj = null;
                if (com.aliyun.teautil.Common.equalNumber(response_.statusCode, 200)) {
                    obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                    respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                    return TeaModel.toModel(TeaConverter.buildMap(
                        new TeaPair("body", respMap),
                        new TeaPair("headers", response_.headers)
                    ), new UpdateFacegroupInfoModel());
                }

                if (!com.aliyun.teautil.Common.empty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                obj = com.aliyun.teautil.Common.readAsJSON(response_.body);
                respMap = com.aliyun.teautil.Common.assertAsMap(obj);
                throw new TeaException(TeaConverter.merge(Object.class,
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    respMap
                ));
            } catch (Exception e) {
                if (Tea.isRetryable(e)) {
                    continue;
                }
                throw e;
            }
        }

        throw new TeaUnretryableException(_lastRequest);
    }

    public String getPathname(String nickname, String path) throws Exception {
        if (com.aliyun.teautil.Common.empty(nickname)) {
            return path;
        }

        return "/" + nickname + "" + path + "";
    }

    public void setExpireTime(String expireTime) throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_accessTokenCredential)) {
            return ;
        }

        _accessTokenCredential.setExpireTime(expireTime);
    }

    public String getExpireTime() throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_accessTokenCredential)) {
            return "";
        }

        String expireTime = _accessTokenCredential.getExpireTime();
        return expireTime;
    }

    public void setRefreshToken(String token) throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_accessTokenCredential)) {
            return ;
        }

        _accessTokenCredential.setRefreshToken(token);
    }

    public String getRefreshToken() throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_accessTokenCredential)) {
            return "";
        }

        String token = _accessTokenCredential.getRefreshToken();
        return token;
    }

    public void setAccessToken(String token) throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_accessTokenCredential)) {
            return ;
        }

        _accessTokenCredential.setAccessToken(token);
    }

    public String getAccessToken() throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_accessTokenCredential)) {
            return "";
        }

        String token = _accessTokenCredential.getAccessToken();
        return token;
    }

    public void setUserAgent(String userAgent) throws Exception {
        this._userAgent = userAgent;
    }

    public void appendUserAgent(String userAgent) throws Exception {
        this._userAgent = "" + _userAgent + " " + userAgent + "";
    }

    public String getUserAgent() throws Exception {
        String userAgent = com.aliyun.teautil.Common.getUserAgent(_userAgent);
        return userAgent;
    }

    public String getAccessKeyId() throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_credential)) {
            return "";
        }

        String accessKeyId = _credential.getAccessKeyId();
        return accessKeyId;
    }

    public String getAccessKeySecret() throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_credential)) {
            return "";
        }

        String secret = _credential.getAccessKeySecret();
        return secret;
    }

    public String getSecurityToken() throws Exception {
        if (com.aliyun.teautil.Common.isUnset(_credential)) {
            return "";
        }

        String token = _credential.getSecurityToken();
        return token;
    }
}
