using System;
using System.Collections.Generic;

using Aliyun.SDK.CCP.Utils;

using Newtonsoft.Json;

using Tea;

namespace Aliyun.SDK.CCP.Credentials
{
    public class AccessTokenCredential
    {
        private string accessToken;
        private string expireTime;
        private string refreshToken;
        private string domainId;
        private string clientId;
        private string clientSecret;
        private string endpoint;

        public AccessTokenCredential(Dictionary<string, object> config)
        {
            this.refreshToken = DictUtils.GetDicValue(config, "RefreshToken").ToSafeString();
            this.domainId = DictUtils.GetDicValue(config, "DomainId").ToSafeString();
            this.endpoint = DictUtils.GetDicValue(config, "Endpoint").ToSafeString();
            this.clientId = DictUtils.GetDicValue(config, "ClientId").ToSafeString();
            this.clientSecret = DictUtils.GetDicValue(config, "ClientSecret").ToSafeString();
            this.accessToken = DictUtils.GetDicValue(config, "AccessToken").ToSafeString();
            this.expireTime = DictUtils.GetDicValue(config, "ExpireTime").ToSafeString();
        }

        public void RefreshAccessToken()
        {
            TeaRequest request = new TeaRequest();
            request.Protocol = "http";
            request.Method = "POST";
            request.Pathname = "/v2/oauth/token";
            request.Headers = new Dictionary<string, string>();
            request.Headers.Add("host", GetHost(this.endpoint, this.domainId + ".api.alicloudccp.com"));
            request.Headers.Add("content-type", "application/x-www-form-urlencoded; charset=utf-8");
            request.Headers.Add("date", TimeUtils.GetGMTDate());
            request.Headers.Add("accept", "application/json");
            request.Headers.Add("x-acs-signature-method", "HMAC-SHA1");
            request.Headers.Add("x-acs-signature-version", "1.0");
            request.Body = string.Format("grant_type=refresh_token&refresh_token={0}&client_id={1}&client_secret={2}",
                this.refreshToken, this.clientId, this.clientSecret);
            TeaResponse response = TeaCore.DoAction(request, new Dictionary<string, object>());
            string body = TeaCore.GetResponseBody(response);
            Dictionary<string, object> bodyDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(body);
            if (response.StatusCode == 200)
            {
                this.expireTime = DictUtils.GetDicValue(bodyDict, "expire_time").ToSafeString();
                this.accessToken = DictUtils.GetDicValue(bodyDict, "access_token").ToSafeString();
                this.refreshToken = DictUtils.GetDicValue(bodyDict, "refresh_token").ToSafeString();
            }
        }

        public bool WithShouldRefresh()
        {
            if (string.IsNullOrWhiteSpace(this.refreshToken) || string.IsNullOrWhiteSpace(this.expireTime))
            {
                return false;
            }
            string expireTimeStr = this.expireTime.Replace('T', ' ').Replace('Z', ' ');
            DateTime expireDate = Convert.ToDateTime(expireTimeStr);
            long expireTimeMillis = expireDate.GetTimeMillis();
            return DateTime.UtcNow.GetTimeMillis() >= (expireTimeMillis - 180);
        }

        public string AccessToken
        {
            get
            {
                if (null == this.accessToken || WithShouldRefresh())
                {
                    RefreshAccessToken();
                }
                return this.accessToken;
            }
            set
            {
                this.accessToken = value;
            }
        }

        public string ExpireTime
        {
            get
            {
                return this.expireTime;
            }
            set
            {
                this.expireTime = value;
            }
        }

        public string GetHost(string endpoint, string domain)
        {
            if (!string.IsNullOrWhiteSpace(endpoint))
            {
                return endpoint;
            }
            else
            {
                return domain;
            }
        }
    }
}
