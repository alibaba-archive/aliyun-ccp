using AlibabaCloud.AccessTokenCredential.Models;
using Xunit;

namespace tests.Models
{
    public class ConfigTest
    {
        [Fact]
        public void Test_Config()
        {
            Config config = new Config();
            config.AccessToken = "AccessToken";
            config.ClientId = "ClientId";
            config.ClientSecret = "ClientSecret";
            config.DomainId = "DomainId";
            config.Endpoint = "Endpoint";
            config.ExpireTime = "ExpireTime";
            config.RefreshToken = "RefreshToken";

            Assert.Equal("AccessToken", config.AccessToken);
            Assert.Equal("ClientId", config.ClientId);
            Assert.Equal("ClientSecret", config.ClientSecret);
            Assert.Equal("DomainId", config.DomainId);
            Assert.Equal("Endpoint", config.Endpoint);
            Assert.Equal("ExpireTime", config.ExpireTime);
            Assert.Equal("RefreshToken", config.RefreshToken);
        }
    }
}
