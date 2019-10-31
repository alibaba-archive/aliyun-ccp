
using System.Collections.Generic;
using Aliyun.SDK.CCP.Utils;
using Xunit;

namespace baseClientUnitTests.Utils
{
    public class DictUtilsTest
    {
        [Fact]
        public void TestGetDicValue()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("testKey", "testValue");
            Assert.Null(DictUtils.GetDicValue(dict, "testNull"));
            Assert.Equal("testValue", DictUtils.GetDicValue(dict, "testKey"));
        }
    }
}
