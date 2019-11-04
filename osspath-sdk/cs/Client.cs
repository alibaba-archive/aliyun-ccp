// This file is auto-generated, don't edit it. Thanks.
using System;
using System.Collections.Generic;

using Tea;

using Aliyun.SDK.CCP.OSSClient.Models;

namespace Aliyun.SDK.CCP.OSSClient
{
    public class Client : BaseClient
    {

        public Client(Config config): base(config.ToMap())
        { }

        public AccountAccessTokenResponse cancelLink(CancelLinkRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/cancel_link";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AccountAccessTokenResponse confirmLink(ConfirmLinkRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/confirm_link";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public void changePassword(DefaultChangePasswordRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/default/change_password";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return ;
                    }
                    return ;
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public void setPassword(DefaultSetPasswordRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/default/set_password";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return ;
                    }
                    return ;
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AccountAccessTokenResponse getAccessTokenByLinkInfo(GetAccessTokenByLinkInfoRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/get_access_token_by_link_info";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public Captcha getCaptcha(GetCaptchaRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/get_captcha";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<Captcha>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<Captcha>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<Captcha>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public LinkInfoResponse getLinkInfo(GetByLinkInfoRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/get_link_info";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<LinkInfoResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<LinkInfoResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<LinkInfoResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public LinkInfoListResponse getLinkInfoByUserId(GetLinkInfoByUserIDRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/get_link_info_by_user_id";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<LinkInfoListResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<LinkInfoListResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<LinkInfoListResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AccountAccessTokenResponse link(AccountLinkRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/link";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public MobileCheckExistResponse checkExist(MobileCheckExistRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/mobile/check_exist";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<MobileCheckExistResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<MobileCheckExistResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<MobileCheckExistResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AccountAccessTokenResponse login(MobileLoginRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/mobile/login";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AccountAccessTokenResponse register(MobileRegisterRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/mobile/register";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public MobileSendSmsCodeResponse mobileSendSmsCode(MobileSendSmsCodeRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/mobile/send_sms_code";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<MobileSendSmsCodeResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<MobileSendSmsCodeResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<MobileSendSmsCodeResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AccountAccessTokenResponse token(TokenRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/account/token";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<AccountAccessTokenResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListStoresResponse adminListStores(AdminListStoresRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/domain/list_stores";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<ListStoresResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<ListStoresResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<ListStoresResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AccessTokenResponse getUserAccessToken(GetUserAccessTokenRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/user/get_access_token";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<AccessTokenResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<AccessTokenResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<AccessTokenResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CreateDriveResponse createDrive(CreateDriveRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/drive/create";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 201)) {
                        return TeaModel.ToObject<CreateDriveResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<CreateDriveResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<CreateDriveResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public void deleteDrive(DeleteDriveRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/drive/delete";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return ;
                    }
                    return ;
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetDriveResponse getDrive(GetDriveRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/drive/get";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<GetDriveResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetDriveResponse getDefaultDrive(GetDefaultDriveRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/drive/get_default_drive";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<GetDriveResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListDriveResponse listDrives(ListDriveRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/drive/list";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<ListDriveResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListDriveResponse listMyDrives(ListMyDriveRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/drive/list_my_drives";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<ListDriveResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public UpdateDriveResponse updateDrive(UpdateDriveRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/drive/update";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<UpdateDriveResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<UpdateDriveResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<UpdateDriveResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSCompleteFileResponse completeFile(OSSCompleteFileRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/complete";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<OSSCompleteFileResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSCompleteFileResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSCompleteFileResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSCopyFileResponse copyFile(OSSCopyFileRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/copy";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 201)) {
                        return TeaModel.ToObject<OSSCopyFileResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSCopyFileResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSCopyFileResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSCreateFileResponse createFile(OSSCreateFileRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/create";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 201)) {
                        return TeaModel.ToObject<OSSCreateFileResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSCreateFileResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSCreateFileResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public void deleteFile(OSSDeleteFileRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/delete";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return ;
                    }
                    return ;
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSGetFileResponse getFile(OSSGetFileRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/get";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<OSSGetFileResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSGetFileResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSGetFileResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSGetDownloadUrlResponse getDownloadUrl(OSSGetDownloadUrlRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/get_download_url";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<OSSGetDownloadUrlResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSGetDownloadUrlResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSGetDownloadUrlResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSGetUploadUrlResponse getUploadUrl(OSSGetUploadUrlRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/get_upload_url";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<OSSGetUploadUrlResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSGetUploadUrlResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSGetUploadUrlResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSListFileResponse listFile(OSSListFileRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/list";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<OSSListFileResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSListFileResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSListFileResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSListUploadedPartResponse listUploadedParts(OSSListUploadedPartRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/list_uploaded_parts";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<OSSListUploadedPartResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSListUploadedPartResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSListUploadedPartResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public OSSMoveFileResponse moveFile(OSSMoveFileRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/file/move";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<OSSMoveFileResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<OSSMoveFileResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<OSSMoveFileResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CreateShareResponse createShare(CreateShareRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/share/create";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 201)) {
                        return TeaModel.ToObject<CreateShareResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<CreateShareResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<CreateShareResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public void deleteShare(DeleteShareRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/share/delete";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return ;
                    }
                    return ;
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetShareResponse getShare(GetShareRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/share/get";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<GetShareResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<GetShareResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<GetShareResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListShareResponse listShare(ListShareRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/share/list";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<ListShareResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<ListShareResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<ListShareResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public UpdateShareResponse updateShare(UpdateShareRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/share/update";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<UpdateShareResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<UpdateShareResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<UpdateShareResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListStoreFileResponse listStorefile(ListStoreFileRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/osspath/store_file/list";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<ListStoreFileResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<ListStoreFileResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<ListStoreFileResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CreateUserResponse createUser(CreateUserRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/user/create";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 201)) {
                        return TeaModel.ToObject<CreateUserResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<CreateUserResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<CreateUserResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public void deleteUser(DeleteUserRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/user/delete";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return ;
                    }
                    return ;
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public GetUserResponse getUser(GetUserRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/user/get";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<GetUserResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<GetUserResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<GetUserResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListUserResponse listUsers(ListUserRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/user/list";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<ListUserResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public ListUserResponse searchUser(SearchUserRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/user/search";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<ListUserResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public UpdateUserResponse updateUser(UpdateUserRequest request, RuntimeOptions runtime) {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>(){
                {"timeouted", "retry"},
                {"readTimeout", runtime.ReadTimeout},
                {"connectTimeout", runtime.ConnectTimeout},
                {"localAddr", runtime.LocalAddr},
                {"httpProxy", runtime.HttpProxy},
                {"httpsProxy", runtime.HttpsProxy},
                {"noProxy", runtime.NoProxy},
                {"maxIdleConns", runtime.MaxIdleConns},
                {"socks5Proxy", runtime.Socks5Proxy},
                {"socks5NetWork", runtime.Socks5NetWork},
                {"retry", new Dictionary<string, object>(){
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", this._defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", this._default(runtime.BackoffPolicy, "no")},
                    {"period", this._defaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((Dictionary<string, object>) runtime_["retry"], _retryTimes, _now)) {
                if (_retryTimes > 0) {
                    int backoffTime = TeaCore.GetBackoffTime((Dictionary<string, object>)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0) {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = this._getAccessKeyId();
                    string accessKeySecret = this._getAccessKeySecret();
                    string accessToken = this._getAccessToken();
                    request_.Protocol = this._getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = "/v2/user/update";
                    request_.Headers = new Dictionary<string, string>(){
                        {"host", this._getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (this._notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (this._notEmpty(accesskeyId) && this._notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = this._getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + this._getSignature(request_);
                    }
                    request_.Body = this._toJSONString(request);
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    if (this._isStatusCode(response_, 200)) {
                        return TeaModel.ToObject<UpdateUserResponse>(TeaConverter.merge(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            this._readAsJSON(response_)
                        ));
                    }
                    if (this._notEmpty(response_.Headers["x-ca-error-message"])) {
                        return TeaModel.ToObject<UpdateUserResponse>(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    return TeaModel.ToObject<UpdateUserResponse>(TeaConverter.merge(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        this._readAsJSON(response_)
                    ));
                } catch (Exception e) {
                    if (TeaCore.IsRetryable(e)) {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

    }
}
