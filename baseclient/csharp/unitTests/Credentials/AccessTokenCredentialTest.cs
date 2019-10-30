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
            config.Add("RefreshToken", "refreshToken");
            config.Add("DomainId", "domainId");
            config.Add("ClientId", "clientId");
            config.Add("ClientSecret", "clientSecret");
            config.Add("ExpireTime", "2019-10-01T00:00:00");
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
            configTokenNull.Add("RefreshToken", "");
            configTokenNull.Add("DomainId", "domainId");
            configTokenNull.Add("ClientId", "clientId");
            configTokenNull.Add("ClientSecret", "clientSecret");
            configTokenNull.Add("ExpireTime", "2019-10-01T00:00:00");
            AccessTokenCredential accessTokenCredentialTokenNull = new AccessTokenCredential(configTokenNull);
            Assert.False(accessTokenCredentialTokenNull.WithShouldRefresh());

            Dictionary<string, object> configExpireTimeNull = new Dictionary<string, object>();
            configExpireTimeNull.Add("RefreshToken", "RefreshToken");
            configExpireTimeNull.Add("DomainId", "domainId");
            configExpireTimeNull.Add("ClientId", "clientId");
            configExpireTimeNull.Add("ClientSecret", "clientSecret");
            configExpireTimeNull.Add("ExpireTime", "");
            AccessTokenCredential accessTokenCredentialExpireTimeNull = new AccessTokenCredential(configExpireTimeNull);
            Assert.False(accessTokenCredentialExpireTimeNull.WithShouldRefresh());
        }
    }
}
