// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;

using Aliyun.SDK.CCP.CCPClient.Models;

namespace Aliyun.SDK.CCP.CCPClient
{
    public class Client 
    {
        private string _domainId;
        private string _endpoint;
        private string _protocol;
        private string _nickname;
        private string _userAgent;
        private Aliyun.Credentials.Client _credential;
        private AlibabaCloud.AccessTokenCredential.Client _accessTokenCredential;

        public Client(Config config)
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(config.ToMap()))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"name", "ParameterMissing"},
                    {"message", "'config' can not be unset"},
                });
            }
            if (AlibabaCloud.TeaUtil.Common.Empty(config.DomainId))
            {
                throw new TeaException(new Dictionary<string, string>
                {
                    {"name", "ParameterMissing"},
                    {"message", "'config.domainId' can not be empty"},
                });
            }
            if (!AlibabaCloud.TeaUtil.Common.Empty(config.AccessToken) || !AlibabaCloud.TeaUtil.Common.Empty(config.RefreshToken))
            {
                AlibabaCloud.AccessTokenCredential.Models.Config accessConfig = new AlibabaCloud.AccessTokenCredential.Models.Config
                {
                    AccessToken = config.AccessToken,
                    Endpoint = config.Endpoint,
                    DomainId = config.DomainId,
                    ClientId = config.ClientId,
                    RefreshToken = config.RefreshToken,
                    ClientSecret = config.ClientSecret,
                    ExpireTime = config.ExpireTime,
                };
                this._accessTokenCredential = new AlibabaCloud.AccessTokenCredential.Client(accessConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.Empty(config.AccessKeyId))
            {
                if (AlibabaCloud.TeaUtil.Common.Empty(config.CredentialType))
                {
                    config.CredentialType = "access_key";
                }
                Aliyun.Credentials.Models.Config credentialConfig = new Aliyun.Credentials.Models.Config
                {
                    AccessKeyId = config.AccessKeyId,
                    Type = config.CredentialType,
                    AccessKeySecret = config.AccessKeySecret,
                    SecurityToken = config.SecurityToken,
                };
                this._credential = new Aliyun.Credentials.Client(credentialConfig);
            }
            this._endpoint = config.Endpoint;
            this._protocol = config.Protocol;
            this._domainId = config.DomainId;
            this._userAgent = config.UserAgent;
            this._nickname = config.Nickname;
        }

        public AccountAccessTokenResponse CancelLink(CancelLinkRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/cancel_link");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/cancel_link");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/confirm_link");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/confirm_link");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/default/change_password");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return ;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/default/change_password");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return ;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/default/set_password");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return ;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/default/set_password");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return ;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/get_access_token_by_link_info");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/get_access_token_by_link_info");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/get_captcha");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<Captcha>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/get_captcha");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<Captcha>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/get_link_info");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<LinkInfoResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/get_link_info");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<LinkInfoResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/get_link_info_by_user_id");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<LinkInfoListResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/get_link_info_by_user_id");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<LinkInfoListResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/link");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/link");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/mobile/check_exist");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<MobileCheckExistResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/mobile/check_exist");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<MobileCheckExistResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/mobile/login");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/mobile/login");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/mobile/register");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/mobile/register");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/mobile/send_sms_code");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<MobileSendSmsCodeResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/mobile/send_sms_code");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<MobileSendSmsCodeResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/token");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/account/token");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AccountAccessTokenResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPGetAsyncTaskResponse GetAsyncTaskInfo(CCPGetAsyncTaskRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/async_task/get");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPGetAsyncTaskResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPGetAsyncTaskResponse> GetAsyncTaskInfoAsync(CCPGetAsyncTaskRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/async_task/get");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPGetAsyncTaskResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPBatchResponse Operation(CCPBatchRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/batch");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPBatchResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPBatchResponse> OperationAsync(CCPBatchRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/batch");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPBatchResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/create");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/create");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/delete");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return ;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/delete");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return ;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/get");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/get");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/get_default_drive");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/get_default_drive");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/list");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/list");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/list_my_drives");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/list_my_drives");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/update");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/drive/update");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateDriveResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPCompleteFileResponse CompleteFile(CCPCompleteFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/complete");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPCompleteFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPCompleteFileResponse> CompleteFileAsync(CCPCompleteFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/complete");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPCompleteFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPCopyFileResponse CopyFile(CCPCopyFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/copy");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPCopyFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 202))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPCopyFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPCopyFileResponse> CopyFileAsync(CCPCopyFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/copy");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPCopyFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 202))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPCopyFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPCreateFileResponse CreateFile(CCPCreateFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/create");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPCreateFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPCreateFileResponse> CreateFileAsync(CCPCreateFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/create");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPCreateFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPDeleteFileResponse DeleteFile(CCPDeleteFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/delete");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 202))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPDeleteFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return null;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPDeleteFileResponse> DeleteFileAsync(CCPDeleteFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/delete");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 202))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPDeleteFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return null;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPGetDownloadUrlRequest DownloadFile(DownloadFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "GET";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/download");
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header"));
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPGetDownloadUrlRequest> DownloadFileAsync(DownloadFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "GET";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/download");
                    request_.Query = AlibabaCloud.TeaUtil.Common.StringifyMapValue(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header"));
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPGetFileResponse GetFile(CCPGetFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/get");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPGetFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPGetFileResponse> GetFileAsync(CCPGetFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/get");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPGetFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPGetDownloadUrlResponse GetDownloadUrl(CCPGetDownloadUrlRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/get_download_url");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPGetDownloadUrlResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPGetDownloadUrlResponse> GetDownloadUrlAsync(CCPGetDownloadUrlRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/get_download_url");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPGetDownloadUrlResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPGetUploadUrlResponse GetUploadUrl(CCPGetUploadUrlRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/get_upload_url");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPGetUploadUrlResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPGetUploadUrlResponse> GetUploadUrlAsync(CCPGetUploadUrlRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/get_upload_url");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPGetUploadUrlResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPListFileResponse ListFile(CCPListFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/list");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPListFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPListFileResponse> ListFileAsync(CCPListFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/list");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPListFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPListUploadedPartResponse ListUploadedParts(CCPListUploadedPartRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/list_uploaded_parts");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPListUploadedPartResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPListUploadedPartResponse> ListUploadedPartsAsync(CCPListUploadedPartRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/list_uploaded_parts");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPListUploadedPartResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPMoveFileResponse MoveFile(CCPMoveFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/move");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPMoveFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPMoveFileResponse> MoveFileAsync(CCPMoveFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/move");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPMoveFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPSearchFileResponse SearchFile(CCPSearchFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/search");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPSearchFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPSearchFileResponse> SearchFileAsync(CCPSearchFileRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/search");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPSearchFileResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public CCPUpdateFileMetaResponse UpdateFile(CCPUpdateFileMetaRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/update");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPUpdateFileMetaResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<CCPUpdateFileMetaResponse> UpdateFileAsync(CCPUpdateFileMetaRequest request, RuntimeOptions runtime)
        {
            request.Validate();
            runtime.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/file/update");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CCPUpdateFileMetaResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/create");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/create");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/delete");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return ;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/delete");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return ;
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/get");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/get");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/list");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/list");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/search");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/search");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = GetAccessKeyId();
                    string accessKeySecret = GetAccessKeySecret();
                    string securityToken = GetAccessKeySecret();
                    string accessToken = GetAccessToken();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/update");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
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
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
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
                {"retry", new Dictionary<string, object>
                {
                    {"retryable", runtime.Autoretry},
                    {"maxAttempts", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.MaxAttempts, 3)},
                }},
                {"backoff", new Dictionary<string, object>
                {
                    {"policy", AlibabaCloud.TeaUtil.Common.DefaultString(runtime.BackoffPolicy, "no")},
                    {"period", AlibabaCloud.TeaUtil.Common.DefaultNumber(runtime.BackoffPeriod, 1)},
                }},
                {"ignoreSSL", runtime.IgnoreSSL},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    string accesskeyId = await GetAccessKeyIdAsync();
                    string accessKeySecret = await GetAccessKeySecretAsync();
                    string securityToken = await GetAccessKeySecretAsync();
                    string accessToken = await GetAccessTokenAsync();
                    request_.Protocol = AlibabaCloud.TeaUtil.Common.DefaultString(_protocol, "https");
                    request_.Method = "POST";
                    request_.Pathname = GetPathname(_nickname, "/v2/user/update");
                    request_.Headers = AlibabaCloud.TeaUtil.Common.StringifyMapValue(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Header
                    ));
                    if (!AlibabaCloud.TeaUtil.Common.Empty(accessToken))
                    {
                        request_.Headers["authorization"] = "Bearer " + accessToken;
                    }
                    else if (!AlibabaCloud.TeaUtil.Common.Empty(accesskeyId) && !AlibabaCloud.TeaUtil.Common.Empty(accessKeySecret))
                    {
                        if (!AlibabaCloud.TeaUtil.Common.Empty(securityToken))
                        {
                            request_.Headers["x-acs-security-token"] = securityToken;
                        }
                        request_.Headers["date"] = AlibabaCloud.TeaUtil.Common.GetDateUTCString();
                        request_.Headers["accept"] = "application/json";
                        request_.Headers["x-acs-signature-method"] = "HMAC-SHA1";
                        request_.Headers["x-acs-signature-version"] = "1.0";
                        string stringToSign = AlibabaCloud.ROAUtil.Common.GetStringToSign(request_);
                        request_.Headers["authorization"] = "acs " + accesskeyId + ":" + AlibabaCloud.ROAUtil.Common.GetSignature(stringToSign, accessKeySecret);
                    }
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(AlibabaCloud.ROAUtil.Common.DeleteSpecialKey(request.ToMap(), "header")));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateUserResponse>(TeaConverter.merge<object>
                        (
                            new Dictionary<string, object>()
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                            },
                            respMap
                        ));
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers["x-ca-error-message"]))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers["x-ca-error-message"]},
                        });
                    }
                    obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                    respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                    throw new TeaException(TeaConverter.merge<object>
                    (
                        new Dictionary<string, object>()
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers["x-ca-request-id"]},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                        },
                        respMap
                    ));
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public string GetPathname(string nickname, string path)
        {
            if (AlibabaCloud.TeaUtil.Common.Empty(nickname))
            {
                return path;
            }
            return "/" + nickname + path;
        }

        public void SetExpireTime(string expireTime)
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_accessTokenCredential))
            {
                return ;
            }
            this._accessTokenCredential.SetExpireTime(expireTime);
        }

        public async Task SetExpireTimeAsync(string expireTime)
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_accessTokenCredential))
            {
                return ;
            }
            await this._accessTokenCredential.SetExpireTimeAsync(expireTime);
        }

        public string GetExpireTime()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_accessTokenCredential))
            {
                return "";
            }
            string expireTime = this._accessTokenCredential.GetExpireTime();
            return expireTime;
        }

        public void SetUserAgent(string userAgent)
        {
            this._userAgent = userAgent;
        }

        public void AppendUserAgent(string userAgent)
        {
            this._userAgent = _userAgent + " " + userAgent;
        }

        public string GetUserAgent()
        {
            string userAgent = AlibabaCloud.TeaUtil.Common.GetUserAgent(_userAgent);
            return userAgent;
        }

        public void SetRefreshToken(string token)
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_accessTokenCredential))
            {
                return ;
            }
            this._accessTokenCredential.SetRefreshToken(token);
        }

        public string GetRefreshToken()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_accessTokenCredential))
            {
                return "";
            }
            string token = this._accessTokenCredential.GetRefreshToken();
            return token;
        }

        public void SetAccessToken(string token)
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_accessTokenCredential))
            {
                return ;
            }
            this._accessTokenCredential.SetAccessToken(token);
        }

        public string GetAccessToken()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_accessTokenCredential))
            {
                return "";
            }
            string token = this._accessTokenCredential.GetAccessToken();
            return token;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_accessTokenCredential))
            {
                return "";
            }
            string token = await this._accessTokenCredential.GetAccessTokenAsync();
            return token;
        }

        public string GetAccessKeyId()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                return "";
            }
            string accessKeyId = this._credential.GetAccessKeyId();
            return accessKeyId;
        }

        public async Task<string> GetAccessKeyIdAsync()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                return "";
            }
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            return accessKeyId;
        }

        public string GetAccessKeySecret()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                return "";
            }
            string secret = this._credential.GetAccessKeySecret();
            return secret;
        }

        public async Task<string> GetAccessKeySecretAsync()
        {
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_credential))
            {
                return "";
            }
            string secret = await this._credential.GetAccessKeySecretAsync();
            return secret;
        }

    }
}
