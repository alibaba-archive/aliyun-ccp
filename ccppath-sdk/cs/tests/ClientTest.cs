using System;
using Aliyun.SDK.CCP.CCPClient;
using Aliyun.SDK.CCP.CCPClient.Models;
using Xunit;

namespace tests
{
    public class ClientTest
    {
        [Fact]
        public void Test_ListDrives()
        {
            Config config = new Config();
            config.DomainId = "sz16";
            config.Protocol = "http";
            config.AccessKeyId = Environment.GetEnvironmentVariable("ACCESS_KEY_ID");
            config.AccessKeySecret = Environment.GetEnvironmentVariable("ACCESS_KEY_SECRET");
            Client client = new Client(config);
            ListDriveRequest request = new ListDriveRequest();
            RuntimeOptions runtime = new RuntimeOptions();
            ListDriveResponse result = client.ListDrives(request, runtime);
            Assert.Equal(2, result.Items.Count);
            Assert.Equal("", result.NextMarker);
        }
    }
}
