using System.Collections.Generic;
using AlibabaCloud.AccessTokenCredential.Utils;
using Xunit;

namespace tests.Utils
{
    public class DictUtilsTest
    {
        [Fact]
        public void Test_GetDicValue()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("testKey", "testValue");
            Assert.Null(DictUtils.GetDicValue(dict, "testNull"));
            Assert.Equal("testValue", DictUtils.GetDicValue(dict, "testKey"));
        }
    }
}
