// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Tea;

using Aliyun.SDK.CCP;
using Aliyun.SDK.CCP.OSSClient.Models;

namespace Aliyun.SDK.CCP.OSSClient
{
    public class Client : BaseClient
    {

        public Client(Config config): base(TeaModel.BuildMap(config))
        { }

        public AccountAccessTokenResponse CancelLink(CancelLinkRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/cancel_link");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<AccountAccessTokenResponse> CancelLinkAsync(CancelLinkRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/cancel_link");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public AccountAccessTokenResponse ConfirmLink(ConfirmLinkRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/confirm_link");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<AccountAccessTokenResponse> ConfirmLinkAsync(ConfirmLinkRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/confirm_link");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public void ChangePassword(DefaultChangePasswordRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/default/change_password");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task ChangePasswordAsync(DefaultChangePasswordRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/default/change_password");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public void SetPassword(DefaultSetPasswordRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/default/set_password");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task SetPasswordAsync(DefaultSetPasswordRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/default/set_password");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public AccountAccessTokenResponse GetAccessTokenByLinkInfo(GetAccessTokenByLinkInfoRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/get_access_token_by_link_info");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<AccountAccessTokenResponse> GetAccessTokenByLinkInfoAsync(GetAccessTokenByLinkInfoRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/get_access_token_by_link_info");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public Captcha GetCaptcha(GetCaptchaRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/get_captcha");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<Captcha>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<Captcha> GetCaptchaAsync(GetCaptchaRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/get_captcha");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<Captcha>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public LinkInfoResponse GetLinkInfo(GetByLinkInfoRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/get_link_info");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<LinkInfoResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<LinkInfoResponse> GetLinkInfoAsync(GetByLinkInfoRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/get_link_info");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<LinkInfoResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public LinkInfoListResponse GetLinkInfoByUserId(GetLinkInfoByUserIDRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/get_link_info_by_user_id");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<LinkInfoListResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<LinkInfoListResponse> GetLinkInfoByUserIdAsync(GetLinkInfoByUserIDRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/get_link_info_by_user_id");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<LinkInfoListResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public AccountAccessTokenResponse Link(AccountLinkRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/link");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<AccountAccessTokenResponse> LinkAsync(AccountLinkRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/link");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public MobileCheckExistResponse CheckExist(MobileCheckExistRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/mobile/check_exist");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<MobileCheckExistResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<MobileCheckExistResponse> CheckExistAsync(MobileCheckExistRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/mobile/check_exist");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<MobileCheckExistResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public AccountAccessTokenResponse Login(MobileLoginRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/mobile/login");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<AccountAccessTokenResponse> LoginAsync(MobileLoginRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/mobile/login");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public AccountAccessTokenResponse Register(MobileRegisterRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/mobile/register");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<AccountAccessTokenResponse> RegisterAsync(MobileRegisterRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/mobile/register");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public MobileSendSmsCodeResponse MobileSendSmsCode(MobileSendSmsCodeRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/mobile/send_sms_code");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<MobileSendSmsCodeResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<MobileSendSmsCodeResponse> MobileSendSmsCodeAsync(MobileSendSmsCodeRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/mobile/send_sms_code");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<MobileSendSmsCodeResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public AccountAccessTokenResponse Token(TokenRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/token");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<AccountAccessTokenResponse> TokenAsync(TokenRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/account/token");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".auth.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public ListStoresResponse AdminListStores(AdminListStoresRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/domain/list_stores");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListStoresResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<ListStoresResponse> AdminListStoresAsync(AdminListStoresRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/domain/list_stores");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListStoresResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public AccessTokenResponse GetUserAccessToken(GetUserAccessTokenRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/get_access_token");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<AccessTokenResponse> GetUserAccessTokenAsync(GetUserAccessTokenRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/get_access_token");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<AccessTokenResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public CreateDriveResponse CreateDrive(CreateDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/create");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<CreateDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<CreateDriveResponse> CreateDriveAsync(CreateDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/create");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<CreateDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public void DeleteDrive(DeleteDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/delete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task DeleteDriveAsync(DeleteDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/delete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public GetDriveResponse GetDrive(GetDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/get");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<GetDriveResponse> GetDriveAsync(GetDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/get");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public GetDriveResponse GetDefaultDrive(GetDefaultDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/get_default_drive");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<GetDriveResponse> GetDefaultDriveAsync(GetDefaultDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/get_default_drive");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public ListDriveResponse ListDrives(ListDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<ListDriveResponse> ListDrivesAsync(ListDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public ListDriveResponse ListMyDrives(ListMyDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/list_my_drives");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<ListDriveResponse> ListMyDrivesAsync(ListMyDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/list_my_drives");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public UpdateDriveResponse UpdateDrive(UpdateDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/update");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<UpdateDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<UpdateDriveResponse> UpdateDriveAsync(UpdateDriveRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/drive/update");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<UpdateDriveResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSCompleteFileResponse CompleteFile(OSSCompleteFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/complete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSCompleteFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSCompleteFileResponse> CompleteFileAsync(OSSCompleteFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/complete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSCompleteFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSCopyFileResponse CopyFile(OSSCopyFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/copy");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSCopyFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSCopyFileResponse> CopyFileAsync(OSSCopyFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/copy");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSCopyFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSCreateFileResponse CreateFile(OSSCreateFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/create");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSCreateFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSCreateFileResponse> CreateFileAsync(OSSCreateFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/create");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSCreateFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public void DeleteFile(OSSDeleteFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/delete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task DeleteFileAsync(OSSDeleteFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/delete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSGetFileResponse GetFile(OSSGetFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/get");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSGetFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSGetFileResponse> GetFileAsync(OSSGetFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/get");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSGetFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSGetDownloadUrlResponse GetDownloadUrl(OSSGetDownloadUrlRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/get_download_url");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSGetDownloadUrlResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSGetDownloadUrlResponse> GetDownloadUrlAsync(OSSGetDownloadUrlRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/get_download_url");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSGetDownloadUrlResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSGetUploadUrlResponse GetUploadUrl(OSSGetUploadUrlRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/get_upload_url");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSGetUploadUrlResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSGetUploadUrlResponse> GetUploadUrlAsync(OSSGetUploadUrlRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/get_upload_url");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSGetUploadUrlResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSListFileResponse ListFile(OSSListFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSListFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSListFileResponse> ListFileAsync(OSSListFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSListFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSListUploadedPartResponse ListUploadedParts(OSSListUploadedPartRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/list_uploaded_parts");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSListUploadedPartResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSListUploadedPartResponse> ListUploadedPartsAsync(OSSListUploadedPartRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/list_uploaded_parts");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSListUploadedPartResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public OSSMoveFileResponse MoveFile(OSSMoveFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/move");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSMoveFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<OSSMoveFileResponse> MoveFileAsync(OSSMoveFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/file/move");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<OSSMoveFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public CreateShareResponse CreateShare(CreateShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/create");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<CreateShareResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<CreateShareResponse> CreateShareAsync(CreateShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/create");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<CreateShareResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public void DeleteShare(DeleteShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/delete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task DeleteShareAsync(DeleteShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/delete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public GetShareResponse GetShare(GetShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/get");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<GetShareResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<GetShareResponse> GetShareAsync(GetShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/get");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<GetShareResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public ListShareResponse ListShare(ListShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListShareResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<ListShareResponse> ListShareAsync(ListShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListShareResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public UpdateShareResponse UpdateShare(UpdateShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/update");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<UpdateShareResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<UpdateShareResponse> UpdateShareAsync(UpdateShareRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/share/update");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<UpdateShareResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public ListStoreFileResponse ListStorefile(ListStoreFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/store_file/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListStoreFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<ListStoreFileResponse> ListStorefileAsync(ListStoreFileRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/osspath/store_file/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListStoreFileResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public CreateUserResponse CreateUser(CreateUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/create");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<CreateUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/create");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 201)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<CreateUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public void DeleteUser(DeleteUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/delete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task DeleteUserAsync(DeleteUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/delete");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 204)) {
                        return ;
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public GetUserResponse GetUser(GetUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/get");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<GetUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/get");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<GetUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public ListUserResponse ListUsers(ListUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<ListUserResponse> ListUsersAsync(ListUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/list");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public ListUserResponse SearchUser(SearchUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/search");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<ListUserResponse> SearchUserAsync(SearchUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/search");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public UpdateUserResponse UpdateUser(UpdateUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/update");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<UpdateUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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

        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, RuntimeOptions runtime)
        {
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
                    {"maxAttempts", _defaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>(){
                    {"policy", _default(runtime.BackoffPolicy, "no")},
                    {"period", _defaultNumber(runtime.BackoffPeriod, 1)},
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
                    string accesskeyId = _getAccessKeyId();
                    string accessKeySecret = _getAccessKeySecret();
                    string accessToken = _getAccessToken();
                    request_.Protocol = _getProtocol(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = _getPathname(_nickname, "/v2/user/update");
                    request_.Headers = new Dictionary<string, string>(){
                        {"user-agent", _getUserAgent()},
                        {"host", _getHost(_endpoint, _domainId + ".api.alicloudccp.com")},
                        {"content-type", "application/json; charset=utf-8"},
                    };
                    if (_notEmpty(accessToken)) {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    } else if (_notEmpty(accesskeyId) && _notEmpty(accessKeySecret)) {
                        request_.Headers["date"] = _getRFC2616Date();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + _getSignature(request_);
                    }
                    request_.Body = TeaCore.BytesReadable(_toJSONString(TeaModel.BuildMap(request)));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    if (_isStatusCode(response_, 200)) {
                        respMap = _readAsJSON(response_);
                        return TeaModel.ToObject<UpdateUserResponse>(TeaConverter.merge<object>(
                            new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (_notEmpty(response_.Headers["x-ca-error-message"])) {
                        throw new TeaException(new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    respMap = _readAsJSON(response_);
                    throw new TeaException(TeaConverter.merge<object>(
                        new Dictionary<string, object>(){
                            {"data", new Dictionary<string, object>(){
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
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
