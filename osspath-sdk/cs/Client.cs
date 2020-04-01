// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using Aliyun.SDK.CCP.OSSClient.Models;

namespace Aliyun.SDK.CCP.OSSClient
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
                if (AlibabaCloud.TeaUtil.Common.Empty(config.Type))
                {
                    config.Type = "access_key";
                }
                Aliyun.Credentials.Models.Config credentialConfig = new Aliyun.Credentials.Models.Config
                {
                    AccessKeyId = config.AccessKeyId,
                    Type = config.Type,
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

        /**
         * 取消绑定关系，生成新用户，返回访问令牌
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public CancelLinkModel CancelLink(CancelLinkRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CancelLinkModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 取消绑定关系，生成新用户，返回访问令牌
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<CancelLinkModel> CancelLinkAsync(CancelLinkRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CancelLinkModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 确认绑定关系, 成功后返回访问令牌
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public ConfirmLinkModel ConfirmLink(ConfirmLinkRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ConfirmLinkModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 确认绑定关系, 成功后返回访问令牌
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<ConfirmLinkModel> ConfirmLinkAsync(ConfirmLinkRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ConfirmLinkModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 修改手机登录密码，密码必须包含数字和字母，长度8-32个字符
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public ChangePasswordModel ChangePassword(DefaultChangePasswordRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<ChangePasswordModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 修改手机登录密码，密码必须包含数字和字母，长度8-32个字符
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<ChangePasswordModel> ChangePasswordAsync(DefaultChangePasswordRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<ChangePasswordModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 设置手机登录密码，密码必须包含数字和字母，长度8-32个字符
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public SetPasswordModel SetPassword(DefaultSetPasswordRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<SetPasswordModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 设置手机登录密码，密码必须包含数字和字母，长度8-32个字符
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<SetPasswordModel> SetPasswordAsync(DefaultSetPasswordRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<SetPasswordModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 管理员通过账号信息直接获取用户的访问令牌
         * @tags account
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public GetAccessTokenByLinkInfoModel GetAccessTokenByLinkInfo(GetAccessTokenByLinkInfoRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetAccessTokenByLinkInfoModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 管理员通过账号信息直接获取用户的访问令牌
         * @tags account
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<GetAccessTokenByLinkInfoModel> GetAccessTokenByLinkInfoAsync(GetAccessTokenByLinkInfoRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetAccessTokenByLinkInfoModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取图片验证码，用于人机校验，默认不需要
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public GetCaptchaModel GetCaptcha(GetCaptchaRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetCaptchaModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取图片验证码，用于人机校验，默认不需要
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<GetCaptchaModel> GetCaptchaAsync(GetCaptchaRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetCaptchaModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取用户认证方式详情
         * @tags account
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public GetLinkInfoModel GetLinkInfo(GetByLinkInfoRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetLinkInfoModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取用户认证方式详情
         * @tags account
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<GetLinkInfoModel> GetLinkInfoAsync(GetByLinkInfoRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetLinkInfoModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取用户的所有绑定信息
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public GetLinkInfoByUserIdModel GetLinkInfoByUserId(GetLinkInfoByUserIDRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetLinkInfoByUserIdModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取用户的所有绑定信息
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<GetLinkInfoByUserIdModel> GetLinkInfoByUserIdAsync(GetLinkInfoByUserIDRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetLinkInfoByUserIdModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 绑定用户认证方式
         * @tags account
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error AlreadyExist {resource} has already exists. {extra_msg}
         * @error InternalError The request has been failed due to some unknown error.
         */
        public LinkModel Link(AccountLinkRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<LinkModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 绑定用户认证方式
         * @tags account
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error AlreadyExist {resource} has already exists. {extra_msg}
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<LinkModel> LinkAsync(AccountLinkRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<LinkModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 查询手机号是否已被注册
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public CheckExistModel CheckExist(MobileCheckExistRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CheckExistModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 查询手机号是否已被注册
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<CheckExistModel> CheckExistAsync(MobileCheckExistRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CheckExistModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 通过手机号+短信或密码登录，返回刷新令牌和访问令牌
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public LoginModel Login(MobileLoginRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<LoginModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 通过手机号+短信或密码登录，返回刷新令牌和访问令牌
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<LoginModel> LoginAsync(MobileLoginRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<LoginModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 通过手机号+短信验证码注册账号
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error AlreadyExist {resource} has already exists. {extra_msg}
         * @error InternalError The request has been failed due to some unknown error.
         */
        public RegisterModel Register(MobileRegisterRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<RegisterModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 通过手机号+短信验证码注册账号
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error AlreadyExist {resource} has already exists. {extra_msg}
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<RegisterModel> RegisterAsync(MobileRegisterRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<RegisterModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 发送短信验证码，用于登录、注册、修改密码、绑定等
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public MobileSendSmsCodeModel MobileSendSmsCode(MobileSendSmsCodeRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<MobileSendSmsCodeModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 发送短信验证码，用于登录、注册、修改密码、绑定等
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<MobileSendSmsCodeModel> MobileSendSmsCodeAsync(MobileSendSmsCodeRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<MobileSendSmsCodeModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 用户通过刷新令牌（refresh_token）获取访问令牌（access_token）
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public TokenModel Token(TokenRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<TokenModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 用户通过刷新令牌（refresh_token）获取访问令牌（access_token）
         * @tags account
         * @error InvalidParameterMissing The input parameter {parameter_name} is missing.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<TokenModel> TokenAsync(TokenRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".auth.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<TokenModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举Store列表
         * @tags admin
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public AdminListStoresModel AdminListStores(AdminListStoresRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/domain/list_stores");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AdminListStoresModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举Store列表
         * @tags admin
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error Forbidden User not authorized to operate on the specified APIs.
         * @error InternalError The request has been failed due to some unknown error.
         */
        public async Task<AdminListStoresModel> AdminListStoresAsync(AdminListStoresRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/domain/list_stores");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<AdminListStoresModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取用户的accessToken
         * @tags admin
         * @error undefined undefined
         * @error undefined undefined
         * @error undefined undefined
         * @error undefined undefined
         * @error undefined undefined
         */
        public GetUserAccessTokenModel GetUserAccessToken(GetUserAccessTokenRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/user/get_access_token");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetUserAccessTokenModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取用户的accessToken
         * @tags admin
         * @error undefined undefined
         * @error undefined undefined
         * @error undefined undefined
         * @error undefined undefined
         * @error undefined undefined
         */
        public async Task<GetUserAccessTokenModel> GetUserAccessTokenAsync(GetUserAccessTokenRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/user/get_access_token");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetUserAccessTokenModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 支持normal和large两种drive，
        large类型的drive用于文件数多的场景，不支持list操作，
        当drive的文件数量大于1亿时，建议使用large类型。
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public CreateDriveModel CreateDrive(CreateDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateDriveModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 支持normal和large两种drive，
        large类型的drive用于文件数多的场景，不支持list操作，
        当drive的文件数量大于1亿时，建议使用large类型。
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<CreateDriveModel> CreateDriveAsync(CreateDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateDriveModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 删除指定drive_id对应的Drive
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public DeleteDriveModel DeleteDrive(DeleteDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<DeleteDriveModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 删除指定drive_id对应的Drive
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<DeleteDriveModel> DeleteDriveAsync(DeleteDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<DeleteDriveModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取指定drive_id对应的Drive详细信息。
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public GetDriveModel GetDrive(GetDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDriveModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取指定drive_id对应的Drive详细信息。
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<GetDriveModel> GetDriveAsync(GetDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDriveModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 一个用户可拥有多个drive，在创建drive时通过参数指定是否为这个用户的默认drive，
        每个用户只能设置一个默认drive。
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public GetDefaultDriveModel GetDefaultDrive(GetDefaultDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDefaultDriveModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 一个用户可拥有多个drive，在创建drive时通过参数指定是否为这个用户的默认drive，
        每个用户只能设置一个默认drive。
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<GetDefaultDriveModel> GetDefaultDriveAsync(GetDefaultDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDefaultDriveModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 管理员列举指定用户的Drive
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public ListDrivesModel ListDrives(ListDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListDrivesModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 管理员列举指定用户的Drive
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<ListDrivesModel> ListDrivesAsync(ListDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListDrivesModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举当前用户（访问令牌）的Drive
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public ListMyDrivesModel ListMyDrives(ListMyDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListMyDrivesModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举当前用户（访问令牌）的Drive
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<ListMyDrivesModel> ListMyDrivesAsync(ListMyDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListMyDrivesModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 更新指定drive_id的Drive信息
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public UpdateDriveModel UpdateDrive(UpdateDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateDriveModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 更新指定drive_id的Drive信息
         * @tags drive
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<UpdateDriveModel> UpdateDriveAsync(UpdateDriveRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateDriveModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 完成文件上传
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public CompleteFileModel CompleteFile(OSSCompleteFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/complete");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CompleteFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 完成文件上传
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<CompleteFileModel> CompleteFileAsync(OSSCompleteFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/complete");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CompleteFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定源文件或文件夹路径，拷贝到指定的文件夹。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public CopyFileModel CopyFile(OSSCopyFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/copy");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CopyFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定源文件或文件夹路径，拷贝到指定的文件夹。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<CopyFileModel> CopyFileAsync(OSSCopyFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/copy");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CopyFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 创建文件或者文件夹。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error AlreadyExist {resource} has already exists. {extra_msg}
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public CreateFileModel CreateFile(OSSCreateFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/create");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 创建文件或者文件夹。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error AlreadyExist {resource} has already exists. {extra_msg}
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<CreateFileModel> CreateFileAsync(OSSCreateFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/create");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定文件或文件夹路径，删除文件或文件夹
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public DeleteFileModel DeleteFile(OSSDeleteFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/delete");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<DeleteFileModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定文件或文件夹路径，删除文件或文件夹
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<DeleteFileModel> DeleteFileAsync(OSSDeleteFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/delete");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<DeleteFileModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取指定文件或文件夹路径，获取文件或文件夹信息。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public GetFileModel GetFile(OSSGetFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/get");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取指定文件或文件夹路径，获取文件或文件夹信息。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<GetFileModel> GetFileAsync(OSSGetFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/get");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定文件路径，获取文件下载地址
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public GetDownloadUrlModel GetDownloadUrl(OSSGetDownloadUrlRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/get_download_url");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDownloadUrlModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定文件路径，获取文件下载地址
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<GetDownloadUrlModel> GetDownloadUrlAsync(OSSGetDownloadUrlRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/get_download_url");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetDownloadUrlModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定文件路径，获取文件安全地址
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public GetSecureUrlModel GetSecureUrl(OSSGetSecureUrlRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/get_secure_url");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetSecureUrlModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定文件路径，获取文件安全地址
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<GetSecureUrlModel> GetSecureUrlAsync(OSSGetSecureUrlRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/get_secure_url");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetSecureUrlModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 可指定分片信息，一次获取多个分片的上传地址。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public GetUploadUrlModel GetUploadUrl(OSSGetUploadUrlRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/get_upload_url");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetUploadUrlModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 可指定分片信息，一次获取多个分片的上传地址。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<GetUploadUrlModel> GetUploadUrlAsync(OSSGetUploadUrlRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/get_upload_url");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetUploadUrlModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定父文件夹路径，列举文件夹下的文件或者文件夹
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public ListFileModel ListFile(OSSListFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/list");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定父文件夹路径，列举文件夹下的文件或者文件夹
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<ListFileModel> ListFileAsync(OSSListFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/list");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举UploadID对应的已上传分片。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public ListUploadedPartsModel ListUploadedParts(OSSListUploadedPartRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/list_uploaded_parts");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListUploadedPartsModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举UploadID对应的已上传分片。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<ListUploadedPartsModel> ListUploadedPartsAsync(OSSListUploadedPartRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/list_uploaded_parts");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListUploadedPartsModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定源文件或文件夹路径，移动到指定的文件夹。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public MoveFileModel MoveFile(OSSMoveFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/move");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<MoveFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 指定源文件或文件夹路径，移动到指定的文件夹。
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<MoveFileModel> MoveFileAsync(OSSMoveFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/move");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<MoveFileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取视频支持的分辨率
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public VideoDefinitionModel VideoDefinition(OSSVideoDefinitionRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/video_definition");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<VideoDefinitionModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取视频支持的分辨率
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<VideoDefinitionModel> VideoDefinitionAsync(OSSVideoDefinitionRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/video_definition");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<VideoDefinitionModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取视频转码后的m3u8文件
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public VideoM3u8Model VideoM3u8(OSSVideoM3U8RequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/video_m3u8");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        byte[] byt = AlibabaCloud.TeaUtil.Common.ReadAsBytes(response_.Body);
                        return TeaModel.ToObject<VideoM3u8Model>(new Dictionary<string, object>
                        {
                            {"body", byt},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取视频转码后的m3u8文件
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<VideoM3u8Model> VideoM3u8Async(OSSVideoM3U8RequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/video_m3u8");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        byte[] byt = AlibabaCloud.TeaUtil.Common.ReadAsBytes(response_.Body);
                        return TeaModel.ToObject<VideoM3u8Model>(new Dictionary<string, object>
                        {
                            {"body", byt},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 将mp4格式的视频文件，转为m3u8
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public VideoTranscodeModel VideoTranscode(OSSVideoTranscodeRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/video_transcode");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<VideoTranscodeModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<VideoTranscodeModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 将mp4格式的视频文件，转为m3u8
         * @tags file
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<VideoTranscodeModel> VideoTranscodeAsync(OSSVideoTranscodeRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/file/video_transcode");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<VideoTranscodeModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<VideoTranscodeModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 创建共享。
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public CreateShareModel CreateShare(CreateShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/create");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateShareModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 创建共享。
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<CreateShareModel> CreateShareAsync(CreateShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/create");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateShareModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 删除指定共享
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public DeleteShareModel DeleteShare(DeleteShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/delete");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<DeleteShareModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 删除指定共享
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<DeleteShareModel> DeleteShareAsync(DeleteShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/delete");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<DeleteShareModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取共享信息。
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public GetShareModel GetShare(GetShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/get");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetShareModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 获取共享信息。
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<GetShareModel> GetShareAsync(GetShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/get");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetShareModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举指定用户的共享
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public ListShareModel ListShare(ListShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/list");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListShareModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举指定用户的共享
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<ListShareModel> ListShareAsync(ListShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/list");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListShareModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 修改指定共享
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public UpdateShareModel UpdateShare(UpdateShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/update");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateShareModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 修改指定共享
         * @tags share
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<UpdateShareModel> UpdateShareAsync(UpdateShareRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/share/update");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateShareModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举指定store下的所有文件。
         * @tags store
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public ListStorefileModel ListStorefile(ListStoreFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/store_file/list");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListStorefileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 列举指定store下的所有文件。
         * @tags store
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error AccessTokenInvalid AccessToken is invalid. {message}
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<ListStorefileModel> ListStorefileAsync(ListStoreFileRequestModel request, RuntimeOptions runtime)
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
                    request_.Pathname = GetPathname(_nickname, "/v2/osspath/store_file/list");
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListStorefileModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会创建用户， 只有管理员可以调用
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public CreateUserModel CreateUser(CreateUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateUserModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会创建用户， 只有管理员可以调用
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<CreateUserModel> CreateUserAsync(CreateUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 201))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<CreateUserModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会删除用户
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public DeleteUserModel DeleteUser(DeleteUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<DeleteUserModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会删除用户
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<DeleteUserModel> DeleteUserAsync(DeleteUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 204))
                    {
                        return TeaModel.ToObject<DeleteUserModel>(new Dictionary<string, Dictionary<string, string>>
                        {
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会查看用户详细信息
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public GetUserModel GetUser(GetUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetUserModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会查看用户详细信息
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<GetUserModel> GetUserAsync(GetUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<GetUserModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会展示用户列表
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public ListUsersModel ListUsers(ListUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListUsersModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会展示用户列表
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<ListUsersModel> ListUsersAsync(ListUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<ListUsersModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会根据条件查询用户
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public SearchUserModel SearchUser(SearchUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<SearchUserModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会根据条件查询用户
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<SearchUserModel> SearchUserAsync(SearchUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<SearchUserModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会更新用户信息
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public UpdateUserModel UpdateUser(UpdateUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateUserModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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

        /**
         * 该接口将会更新用户信息
         * @tags user
         * @error InvalidParameter The input parameter {parameter_name} is not valid.
         * @error ForbiddenNoPermission No Permission to access resource {resource_name}.
         * @error NotFound The resource {resource_name} cannot be found. Please check.
         * @error InternalError The request has been failed due to some unknown error.
         * @error ServiceUnavailable The request has failed due to a temporary failure of the server.
         */
        public async Task<UpdateUserModel> UpdateUserAsync(UpdateUserRequestModel request, RuntimeOptions runtime)
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
                    request_.Headers = TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"user-agent", GetUserAgent()},
                            {"host", AlibabaCloud.TeaUtil.Common.DefaultString(_endpoint, _domainId + ".api.alicloudccp.com")},
                            {"content-type", "application/json; charset=utf-8"},
                        },
                        request.Headers
                    );
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
                    request_.Body = TeaCore.BytesReadable(AlibabaCloud.TeaUtil.Common.ToJSONString(request.Body.ToMap()));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = null;
                    object obj = null;
                    if (AlibabaCloud.TeaUtil.Common.EqualNumber(response_.StatusCode, 200))
                    {
                        obj = AlibabaCloud.TeaUtil.Common.ReadAsJSON(response_.Body);
                        respMap = AlibabaCloud.TeaUtil.Common.AssertAsMap(obj);
                        return TeaModel.ToObject<UpdateUserModel>(new Dictionary<string, object>
                        {
                            {"body", respMap},
                            {"headers", response_.Headers},
                        });
                    }
                    if (!AlibabaCloud.TeaUtil.Common.Empty(response_.Headers.Get("x-ca-error-message")))
                    {
                        throw new TeaException(new Dictionary<string, object>
                        {
                            {"data", new Dictionary<string, object>
                            {
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
                                {"statusCode", response_.StatusCode},
                                {"statusMessage", response_.StatusMessage},
                            }},
                            {"message", response_.Headers.Get("x-ca-error-message")},
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
                                {"requestId", response_.Headers.Get("x-ca-request-id")},
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
