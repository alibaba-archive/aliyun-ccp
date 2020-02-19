using System.Collections.Generic;
using AlibabaCloud.CCPUtil;
using Tea;
using tests.Models;
using Xunit;

namespace tests
{
    public class CommonTest
    {
        [Fact]
        public void Test_GetPathname()
        {
            string nickName = "nickName";
            string path = "/path";
            Assert.Equal("/path", Common.GetPathname(string.Empty, path));
            Assert.Equal("/nickName/path", Common.GetPathname(nickName, path));
        }

        [Fact]
        public void Test_ToQuery()
        {
            TestRegModel testRegModel = new TestRegModel();
            testRegModel.RequestId = "requestId";
            testRegModel.subModel = new TestRegSubModel();
            Dictionary<string, string> dict = Common.ToQuery(testRegModel.ToMap());
            Assert.Equal("requestId", dict["requestId"]);
            Assert.Null(dict["next_marker"]);
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
            Assert.NotNull(Common.GetSignature(teaRequestEmpty, "accessKeySecret"));

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
            Assert.NotNull(Common.GetSignature(teaRequest, "accessKeySecret"));
        }
    }
}
