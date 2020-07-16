using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AlibabaCloud.AccessTokenCredential.Models;
using AlibabaCloud.AccessTokenCredential.Utils;
using Newtonsoft.Json;
using Tea;

namespace AlibabaCloud.AccessTokenCredential
{
    public class Client
    {
        private string endpoint;

        private string domainId;

        private string clientId;

        private string refreshToken;

        private string clientSecret;

        private string accessToken;

        private string expireTime;

        public Client(Config config)
        {
            endpoint = config.Endpoint;
            domainId = config.DomainId;
            clientId = config.ClientId;
            refreshToken = config.RefreshToken;
            clientSecret = config.ClientSecret;
            accessToken = config.AccessToken;
            expireTime = config.ExpireTime;
        }

        public void SetExpireTime(string expireTime)
        {
            this.expireTime = expireTime;
        }

        public async Task SetExpireTimeAsync(string expireTime)
        {
            await Task.Run(() =>
            {
                this.expireTime = expireTime;
            });
        }

        public string GetExpireTime()
        {
            return expireTime;
        }

        public string GetRefreshToken()
        {
            return refreshToken;
        }

        public void SetRefreshToken(string refreshToken)
        {
            this.refreshToken = refreshToken;
        }

        public void SetAccessToken(string accessToken)
        {
            this.accessToken = accessToken;
        }

        public string GetAccessToken()
        {
            if (accessToken == null || WithShouldRefresh())
            {
                RefreshAccessToken();
            }
            return this.accessToken;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            if (accessToken == null || WithShouldRefresh())
            {
                await RefreshAccessTokenAsync();
            }
            return this.accessToken;
        }

        internal void RefreshAccessToken()
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
            string bodyStr = string.Format("grant_type=refresh_token&refresh_token={0}&client_id={1}&client_secret={2}",
                this.refreshToken, this.clientId, this.clientSecret);
            MemoryStream stream = new MemoryStream();
            byte[] bytes = Encoding.UTF8.GetBytes(bodyStr);
            stream.Write(bytes, 0, bytes.Length);
            request.Body = stream;
            TeaResponse response = TeaCore.DoAction(request, new Dictionary<string, object>());
            string body = TeaCore.GetResponseBody(response);
            Dictionary<string, object> bodyDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(body);
            if (response.StatusCode == 200)
            {
                expireTime = DictUtils.GetDicValue(bodyDict, "expire_time").ToSafeString();
                accessToken = DictUtils.GetDicValue(bodyDict, "access_token").ToSafeString();
                refreshToken = DictUtils.GetDicValue(bodyDict, "refresh_token").ToSafeString();
            }
            else
            {
                throw new WebException("http request is failed.");
            }
        }

        internal async Task RefreshAccessTokenAsync()
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
            string bodyStr = string.Format("grant_type=refresh_token&refresh_token={0}&client_id={1}&client_secret={2}",
                this.refreshToken, this.clientId, this.clientSecret);
            MemoryStream stream = new MemoryStream();
            byte[] bytes = Encoding.UTF8.GetBytes(bodyStr);
            await stream.WriteAsync(bytes, 0, bytes.Length);
            request.Body = stream;
            TeaResponse response = await TeaCore.DoActionAsync(request, new Dictionary<string, object>());
            string body = TeaCore.GetResponseBody(response);
            Dictionary<string, object> bodyDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(body);
            if (response.StatusCode == 200)
            {
                expireTime = DictUtils.GetDicValue(bodyDict, "expire_time").ToSafeString();
                accessToken = DictUtils.GetDicValue(bodyDict, "access_token").ToSafeString();
                refreshToken = DictUtils.GetDicValue(bodyDict, "refresh_token").ToSafeString();
            }
            else
            {
                throw new WebException("http request is failed.");
            }
        }

        internal bool WithShouldRefresh()
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

        internal string GetHost(string endpoint, string domain)
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
