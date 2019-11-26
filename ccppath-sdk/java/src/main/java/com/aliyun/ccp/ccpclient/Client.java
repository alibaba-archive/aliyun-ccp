// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient;

import com.aliyun.tea.*;
import com.aliyun.ccp.ccpclient.models.*;
import com.aliyun.ccp.baseclient.BaseClient;

public class Client extends BaseClient {

    public Client(Config config) throws Exception {
        super(config.toMap());
    }

    public AccountAccessTokenResponse cancelLink(CancelLinkRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/cancel_link");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new AccountAccessTokenResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public AccountAccessTokenResponse confirmLink(ConfirmLinkRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/confirm_link");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new AccountAccessTokenResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public void changePassword(DefaultChangePasswordRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/default/change_password");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 204)) {
                    return ;
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public void setPassword(DefaultSetPasswordRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/default/set_password");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 204)) {
                    return ;
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public AccountAccessTokenResponse getAccessTokenByLinkInfo(GetAccessTokenByLinkInfoRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/get_access_token_by_link_info");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new AccountAccessTokenResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public Captcha getCaptcha(GetCaptchaRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/get_captcha");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new Captcha());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public LinkInfoResponse getLinkInfo(GetByLinkInfoRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/get_link_info");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new LinkInfoResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public LinkInfoListResponse getLinkInfoByUserId(GetLinkInfoByUserIDRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/get_link_info_by_user_id");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new LinkInfoListResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public AccountAccessTokenResponse link(AccountLinkRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/link");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new AccountAccessTokenResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public MobileCheckExistResponse checkExist(MobileCheckExistRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/mobile/check_exist");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new MobileCheckExistResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public AccountAccessTokenResponse login(MobileLoginRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/mobile/login");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new AccountAccessTokenResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public AccountAccessTokenResponse register(MobileRegisterRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/mobile/register");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new AccountAccessTokenResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public MobileSendSmsCodeResponse mobileSendSmsCode(MobileSendSmsCodeRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/mobile/send_sms_code");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new MobileSendSmsCodeResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public AccountAccessTokenResponse token(TokenRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/account/token");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".auth.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new AccountAccessTokenResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPGetAsyncTaskResponse getAsyncTaskInfo(CCPGetAsyncTaskRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/async_task/get");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPGetAsyncTaskResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPBatchResponse operation(CCPBatchRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/batch");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPBatchResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CreateDriveResponse createDrive(CreateDriveRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/drive/create");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 201)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CreateDriveResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public void deleteDrive(DeleteDriveRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/drive/delete");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 204)) {
                    return ;
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public GetDriveResponse getDrive(GetDriveRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/drive/get");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new GetDriveResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public GetDriveResponse getDefaultDrive(GetDefaultDriveRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/drive/get_default_drive");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new GetDriveResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public ListDriveResponse listDrives(ListDriveRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/drive/list");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new ListDriveResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public ListDriveResponse listMyDrives(ListMyDriveRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/drive/list_my_drives");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new ListDriveResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public UpdateDriveResponse updateDrive(UpdateDriveRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/drive/update");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new UpdateDriveResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPCompleteFileResponse completeFile(CCPCompleteFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/complete");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPCompleteFileResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPCopyFileResponse copyFile(CCPCopyFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/copy");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 201)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPCopyFileResponse());
                }

                if (this._isStatusCode(response_, 202)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPCopyFileResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPCreateFileResponse createFile(CCPCreateFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/create");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 201)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPCreateFileResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPDeleteFileResponse deleteFile(CCPDeleteFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/delete");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 202)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPDeleteFileResponse());
                }

                if (this._isStatusCode(response_, 204)) {
                    return null;
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPGetDownloadUrlRequest downloadFile(DownloadFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "GET";
                request_.pathname = this._getPathname(_nickname, "/v2/file/download");
                request_.query = this._toQuery(request.toMap());
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com"))
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPGetFileResponse getFile(CCPGetFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/get");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPGetFileResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPGetDownloadUrlResponse getDownloadUrl(CCPGetDownloadUrlRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/get_download_url");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPGetDownloadUrlResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPGetUploadUrlResponse getUploadUrl(CCPGetUploadUrlRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/get_upload_url");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPGetUploadUrlResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPListFileResponse listFile(CCPListFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/list");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPListFileResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPListUploadedPartResponse listUploadedParts(CCPListUploadedPartRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/list_uploaded_parts");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPListUploadedPartResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPMoveFileResponse moveFile(CCPMoveFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/move");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPMoveFileResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPSearchFileResponse searchFile(CCPSearchFileRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/search");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPSearchFileResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CCPUpdateFileMetaResponse updateFile(CCPUpdateFileMetaRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/file/update");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CCPUpdateFileMetaResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public CreateUserResponse createUser(CreateUserRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/user/create");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 201)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new CreateUserResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public void deleteUser(DeleteUserRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/user/delete");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 204)) {
                    return ;
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public GetUserResponse getUser(GetUserRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/user/get");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new GetUserResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public ListUserResponse listUsers(ListUserRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/user/list");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new ListUserResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public ListUserResponse searchUser(SearchUserRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/user/search");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new ListUserResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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

    public UpdateUserResponse updateUser(UpdateUserRequest request, RuntimeOptions runtime) throws Exception {
        request.validate();
        runtime.validate();
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
                new TeaPair("maxAttempts", this._defaultNumber(runtime.maxAttempts, 3))
            )),
            new TeaPair("backoff", TeaConverter.buildMap(
                new TeaPair("policy", this._default(runtime.backoffPolicy, "no")),
                new TeaPair("period", this._defaultNumber(runtime.backoffPeriod, 1))
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
                String accesskeyId = this._getAccessKeyId();
                String accessKeySecret = this._getAccessKeySecret();
                String accessToken = this._getAccessToken();
                request_.protocol = this._getProtocol(_protocol, "https");
                request_.method = "POST";
                request_.pathname = this._getPathname(_nickname, "/v2/user/update");
                request_.headers = TeaConverter.buildMap(
                    new TeaPair("user-agent", this._getUserAgent()),
                    new TeaPair("host", this._getHost(_endpoint, "" + _domainId + ".api.alicloudccp.com")),
                    new TeaPair("content-type", "application/json; charset=utf-8")
                );
                if (this._notEmpty(accessToken)) {
                    request_.headers.put("authorization", "Bearer " + accessToken + "");
                } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                    request_.headers.put("date", this._getRFC2616Date());
                    request_.headers.put("accept", "application/json");
                    request_.headers.put("x-acs-signature-method", "HMAC-SHA1");
                    request_.headers.put("x-acs-signature-version", "1.0");
                    request_.headers.put("authorization", "acs " + accesskeyId + ":" + this._getSignature(request_) + "");
                }

                request_.body = Tea.toReadable(this._toJSONString(request.toMap()));
                _lastRequest = request_;
                TeaResponse response_ = Tea.doAction(request_, runtime_);

                if (this._isStatusCode(response_, 200)) {
                    return TeaModel.toModel(TeaConverter.merge(Object.class, 
                        TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id"))
                        ),
                        this._readAsJSON(response_)
                    ), new UpdateUserResponse());
                }

                if (this._notEmpty(response_.headers.get("x-ca-error-message"))) {
                    throw new TeaException(TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        )),
                        new TeaPair("message", response_.headers.get("x-ca-error-message"))
                    ));
                }

                throw new TeaException(TeaConverter.merge(Object.class, 
                    TeaConverter.buildMap(
                        new TeaPair("data", TeaConverter.buildMap(
                            new TeaPair("requestId", response_.headers.get("x-ca-request-id")),
                            new TeaPair("statusCode", response_.statusCode),
                            new TeaPair("statusMessage", response_.statusMessage)
                        ))
                    ),
                    this._readAsJSON(response_)
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
}

