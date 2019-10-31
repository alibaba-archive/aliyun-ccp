using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;

using Aliyun.SDK.CCP;
using Aliyun.SDK.CCP.Credentials;

using baseClientUnitTests.Models;

using Moq;

using Tea;

using Xunit;

namespace baseClientUnitTests
{
    public class BaseClientTest
    {
        public Dictionary<string, object> config;

        public BaseClient baseClient;

        public BaseClientTest()
        {
            config = new Dictionary<string, object>();
            config.Add("DomainId", "domainId");
            config.Add("Protocol", "protocol");
            config.Add("Endpoint", "endpoint");
            config.Add("UserId", "UserId");
            config.Add("AccessKeyId", "accessKeyId");
            config.Add("AccessKeySecret", "accessKeySecret");
            baseClient = new BaseClient(config);
        }

        [Fact]
        public void TestBaseClientNull()
        {
            Dictionary<string, object> config = new Dictionary<string, object>();
            config.Add("DomainId", "domainId");
            config.Add("Protocol", "protocol");
            config.Add("Endpoint", "endpoint");
            config.Add("UserId", "UserId");
            BaseClient baseClient = new BaseClient(config);

            Assert.Null(TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAccessKeyId", baseClient, null));
            Assert.Null(TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAccessKeySecret", baseClient, null));
            Assert.Null(TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAccessToken", baseClient, null));
        }

        [Fact]
        public void TestBaseClientAK()
        {
            string accesskeyId = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAccessKeyId", baseClient, null);
            string accessKeySecret = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAccessKeySecret", baseClient, null);
            Assert.Equal("accessKeyId", accesskeyId);
            Assert.Equal("accessKeySecret", accessKeySecret);

            string protocol = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_getProtocol", baseClient, new object[] { "_protocol", "protocol" });
            Assert.Equal("_protocol", protocol);

            string protocolEmpty = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_getProtocol", baseClient, new object[] { "", "protocol" });
            Assert.Equal("protocol", protocolEmpty);

            string host = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_getHost", baseClient, new object[] { "_endpoint", "endpoint" });
            Assert.Equal("_endpoint", host);

            string hostEmpty = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_getHost", baseClient, new object[] { "", "endpoint" });
            Assert.Equal("endpoint", hostEmpty);

            Assert.True((bool)TestHelper.RunInstanceMethod(typeof(BaseClient), "_notEmpty", baseClient, new object[] { "endpoint" }));
            Assert.False((bool)TestHelper.RunInstanceMethod(typeof(BaseClient), "_notEmpty", baseClient, new object[] { "" }));

            string RFC2616Date = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_getRFC2616Date", baseClient, null);
            Assert.NotNull(RFC2616Date);
        }

        [Fact]
        public void TestBaseClientAccToken()
        {
            Dictionary<string, object> config = new Dictionary<string, object>();
            config.Add("DomainId", "domainId");
            config.Add("Protocol", "protocol");
            config.Add("Endpoint", "endpoint");
            config.Add("UserId", "UserId");
            config.Add("RefreshToken", "refreshToken");
            BaseClient baseClient = new BaseClient(config);

            AccessTokenCredential accessTokenCredential = new AccessTokenCredential(config);
            accessTokenCredential.AccessToken = "accessToken";
            string dateFuture = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");
            accessTokenCredential.ExpireTime = dateFuture;

            BindingFlags flag = BindingFlags.Instance | BindingFlags.NonPublic;
            Type type = baseClient.GetType();
            var filed = type.GetFields(flag).Where(p => p.Name == "_accessTokenCredential").ToList().FirstOrDefault();
            filed.SetValue(baseClient, accessTokenCredential);

            Assert.Equal("accessToken", (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_getAccessToken", baseClient, null));
        }

        [Fact]
        public void TestGetSignature()
        {
            TeaRequest teaRequestEmpty = new TeaRequest();
            teaRequestEmpty.Method = "GET";
            teaRequestEmpty.Pathname = "Pathname";
            Dictionary<string, string> headersEmpty = new Dictionary<string, string>();
            teaRequestEmpty.Headers = headersEmpty;
            Dictionary<string, string> querysEmpty = new Dictionary<string, string>();
            teaRequestEmpty.Query = querysEmpty;
            Assert.NotNull(TestHelper.RunInstanceMethod(typeof(BaseClient), "_getSignature", baseClient, new object[] { teaRequestEmpty }));

            TeaRequest teaRequest = new TeaRequest();
            teaRequest.Method = "GET";
            teaRequest.Pathname = "Pathname";
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("headerKey", "headerValue");
            headers.Add("accept", "accept");
            headers.Add("content-md5", "content-md5");
            headers.Add("content-type", "content-type");
            headers.Add("date", "date");
            teaRequest.Headers = headers;
            Dictionary<string, string> querys = new Dictionary<string, string>();
            querys.Add("queryKey", "queryValue");
            teaRequest.Query = querys;
            Assert.NotNull(TestHelper.RunInstanceMethod(typeof(BaseClient), "_getSignature", baseClient, new object[] { teaRequest }));
        }

        [Fact]
        public void TestIsStatusCode()
        {
            Mock<HttpWebResponse> mockHttpWebResponse = new Mock<HttpWebResponse>();
            mockHttpWebResponse.Setup(p => p.StatusCode).Returns(HttpStatusCode.OK);
            mockHttpWebResponse.Setup(p => p.StatusDescription).Returns("StatusDescription");
            mockHttpWebResponse.Setup(p => p.Headers).Returns(new WebHeaderCollection());
            TeaResponse teaResponse = new TeaResponse(mockHttpWebResponse.Object);
            Assert.True((bool)TestHelper.RunInstanceMethod(typeof(BaseClient), "_isStatusCode", baseClient, new object[] { teaResponse, 200 }));
        }

        [Fact]
        public void TestToJSONString()
        {
            TeaModel model = new TeaModel();
            Assert.NotNull(TestHelper.RunInstanceMethod(typeof(BaseClient), "_toJSONString", baseClient, new object[] { model }));
        }

        [Fact]
        public void TestReadAsJSON()
        {
            string jsonStr = "{\"items\":[{\"total_size\":18,\"partNumber\":1,\"tags\":[{\"aa\":\"11\"}]},{\"total_size\":20,\"partNumber\":2,\"tags\":[{\"aa\":\"22\"}]}],\"next_marker\":\"\",\"test\":{\"total_size\":19,\"partNumber\":1,\"tags\":[{\"aa\":\"11\"}]}}";
            Mock<HttpWebResponse> mockHttpWebResponse = new Mock<HttpWebResponse>();
            mockHttpWebResponse.Setup(p => p.StatusCode).Returns(HttpStatusCode.OK);
            mockHttpWebResponse.Setup(p => p.StatusDescription).Returns("StatusDescription");
            mockHttpWebResponse.Setup(p => p.Headers).Returns(new WebHeaderCollection());
            byte[] array = Encoding.UTF8.GetBytes(jsonStr);
            MemoryStream stream = new MemoryStream(array);
            mockHttpWebResponse.Setup(p => p.GetResponseStream()).Returns(stream);
            TeaResponse teaResponse = new TeaResponse(mockHttpWebResponse.Object);

            Dictionary<string, object> dict = (Dictionary<string, object>)TestHelper.RunInstanceMethod(typeof(BaseClient), "_readAsJSON", baseClient, new object[] { teaResponse });
            Assert.Empty(dict["next_marker"].ToString());
            Assert.Equal(2, ((List<Dictionary<string, object>>)dict["items"]).Count);
            Assert.Equal(19L, ((Dictionary<string, object>)dict["test"])["total_size"]);
        }

        [Fact]
        public void TestToQuery()
        {
            TestRegModel testRegModel = new TestRegModel();
            testRegModel.RequestId = "requestId";
            testRegModel.subModel = new TestRegSubModel();
            Dictionary<string, string> dict = (Dictionary<string, string>)TestHelper.RunInstanceMethod(typeof(BaseClient), "_toQuery", baseClient, new object[] { testRegModel });
            Assert.Equal("requestId", dict["RequestId"]);
            Assert.Null(dict["NextMarker"]);
        }

        [Fact]
        public void TestGetCanonicalizedHeaders()
        {
            Dictionary<String, String> headers = new Dictionary<string, string>();
            headers.Add("x-acs-test", "test");
            headers.Add("testKey", "testValue");
            string connonicalized = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "getCanonicalizedHeaders", baseClient, new object[] { headers });
            Assert.NotNull(connonicalized);
            Assert.Equal("x-acs-test:test", connonicalized);
        }

        [Fact]
        public void TestGetCanonicalizedResource()
        {
            string pathName = "pathName";
            Assert.Equal("pathName", (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "getCanonicalizedResource", baseClient, new object[] { pathName, null }));

            Dictionary<String, String> query = new Dictionary<string, string>();
            Assert.Equal("pathName", (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "getCanonicalizedResource", baseClient, new object[] { pathName, query }));

            query.Add("key", "value");
            string resultPath = (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "getCanonicalizedResource", baseClient, new object[] { pathName, query });
            Assert.Equal("pathName?key=value", resultPath);
        }

        [Fact]
        public void TestDefault()
        {
            Assert.Equal("default", (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_default", baseClient, new object[] { string.Empty, "default" }));

            Assert.Equal("inputStr", (string)TestHelper.RunInstanceMethod(typeof(BaseClient), "_default", baseClient, new object[] { "inputStr", "default" }));
        }

        [Fact]
        public void TestDefaultNumber()
        {
            Assert.Equal(0, (int)TestHelper.RunInstanceMethod(typeof(BaseClient), "_defaultNumber", baseClient, new object[] { -1, 0 }));

            Assert.Equal(1, (int)TestHelper.RunInstanceMethod(typeof(BaseClient), "_defaultNumber", baseClient, new object[] { 1, 0 }));
        }

    }
}
