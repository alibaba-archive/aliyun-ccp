using System;
using System.Collections.Generic;
using System.Net;

using Aliyun.SDK.CCP.Credentials;

using Xunit;

namespace baseClientUnitTests.Credentials
{
    public class AccessTokenCredentialTest
    {
        [Fact]
        public void TestAccessTokenCredential()
        {
            Dictionary<string, object> config = new Dictionary<string, object>();
            config.Add("refreshToken", "refreshToken");
            config.Add("domainId", "domainId");
            config.Add("clientId", "clientId");
            config.Add("clientSecret", "clientSecret");
            config.Add("expireTime", "2019-10-01T00:00:00");
            AccessTokenCredential accessTokenCredential = new AccessTokenCredential(config);
            Assert.Equal("2019-10-01T00:00:00", accessTokenCredential.ExpireTime);
            Assert.Throws<WebException>(() => { string accessToken = accessTokenCredential.AccessToken; });

            accessTokenCredential.AccessToken = "accessToken";
            Assert.Throws<WebException>(() => { string accessToken = accessTokenCredential.AccessToken; });

            string dateFuture = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");
            accessTokenCredential.ExpireTime = dateFuture;
            Assert.Equal("accessToken", accessTokenCredential.AccessToken);

        }

        [Fact]
        public void TestShouldRefresh()
        {
            Dictionary<string, object> configTokenNull = new Dictionary<string, object>();
            configTokenNull.Add("refreshToken", "");
            configTokenNull.Add("domainId", "domainId");
            configTokenNull.Add("clientId", "clientId");
            configTokenNull.Add("clientSecret", "clientSecret");
            configTokenNull.Add("expireTime", "2019-10-01T00:00:00");
            AccessTokenCredential accessTokenCredentialTokenNull = new AccessTokenCredential(configTokenNull);
            Assert.False(accessTokenCredentialTokenNull.WithShouldRefresh());

            Dictionary<string, object> configExpireTimeNull = new Dictionary<string, object>();
            configExpireTimeNull.Add("refreshToken", "RefreshToken");
            configExpireTimeNull.Add("domainId", "domainId");
            configExpireTimeNull.Add("clientId", "clientId");
            configExpireTimeNull.Add("clientSecret", "clientSecret");
            configExpireTimeNull.Add("expireTime", "");
            AccessTokenCredential accessTokenCredentialExpireTimeNull = new AccessTokenCredential(configExpireTimeNull);
            Assert.False(accessTokenCredentialExpireTimeNull.WithShouldRefresh());
        }

        [Fact]
        public void TestGetHost()
        {
            Dictionary<string, object> config = new Dictionary<string, object>();
            config.Add("refreshToken", "refreshToken");
            config.Add("domainId", "domainId");
            config.Add("clientId", "clientId");
            config.Add("clientSecret", "clientSecret");
            config.Add("expireTime", "2019-10-01T00:00:00");
            AccessTokenCredential accessTokenCredential = new AccessTokenCredential(config);
            Assert.Equal("domainId", accessTokenCredential.GetHost(null, "domainId"));
            Assert.Equal("endpoint", accessTokenCredential.GetHost("endpoint", "domainId"));
        }
    }
}
