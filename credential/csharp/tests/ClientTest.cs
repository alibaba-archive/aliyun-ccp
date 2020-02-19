using System;
using System.Net;
using AlibabaCloud.AccessTokenCredential;
using AlibabaCloud.AccessTokenCredential.Models;
using Xunit;

namespace tests
{
    public class ClientTest
    {
        [Fact]
        public void Test_GetHost()
        {
            Config config = new Config
            {
                RefreshToken = "refreshToken",
                DomainId = "domainId",
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                ExpireTime = "2019-10-01T00:00:00"
            };
            
            Client accessTokenCredential = new Client(config);
            Assert.Equal("domainId", accessTokenCredential.GetHost(null, "domainId"));
            Assert.Equal("endpoint", accessTokenCredential.GetHost("endpoint", "domainId"));
        }

        [Fact]
        public void Test_ShouldRefresh()
        {
            Config configTokenNull = new Config
            {
                RefreshToken = "",
                DomainId = "domainId",
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                ExpireTime = "2019-10-01T00:00:00"
            };
            
            Client accessTokenCredentialTokenNull = new Client(configTokenNull);
            Assert.False(accessTokenCredentialTokenNull.WithShouldRefresh());

            Config configExpireTimeNull = new Config
            {
                RefreshToken = "RefreshToken",
                DomainId = "domainId",
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                ExpireTime = ""
            };
            Client accessTokenCredentialExpireTimeNull = new Client(configExpireTimeNull);
            Assert.False(accessTokenCredentialExpireTimeNull.WithShouldRefresh());
        }

        [Fact]
        public void TestAccessTokenCredential()
        {
            Config config = new Config
            {
                RefreshToken = "refreshToken",
                DomainId = "domainId",
                ClientId = "clientId",
                ClientSecret = "clientSecret",
                ExpireTime = "2019-10-01T00:00:00"
            };
            Client accessTokenCredential = new Client(config);
            Assert.Equal("2019-10-01T00:00:00", accessTokenCredential.GetExpireTime());
            Assert.Throws<WebException>(() => { string accessToken = accessTokenCredential.GetAccessToken(); });

            accessTokenCredential.SetAccessToken("accessToken");
            Assert.Throws<WebException>(() => { string accessToken = accessTokenCredential.GetAccessToken(); });

            string dateFuture = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");
            accessTokenCredential.SetExpireTime(dateFuture);
            Assert.Equal("accessToken", accessTokenCredential.GetAccessToken());

            accessTokenCredential.SetRefreshToken("test");
            Assert.Equal("test", accessTokenCredential.GetRefreshToken());
        }
    }
}
