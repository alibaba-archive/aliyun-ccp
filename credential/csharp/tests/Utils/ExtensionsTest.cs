using AlibabaCloud.AccessTokenCredential.Utils;
using Xunit;

namespace tests.Utils
{
    public class ExtensionsTest
    {
        [Fact]
        public void Test_ToSafeString()
        {
            string strNull = null;
            Assert.Null(strNull.ToSafeString());
            Assert.Empty(strNull.ToSafeString(string.Empty));

            string strTest = "test";
            Assert.Equal("test", strTest.ToSafeString());
            Assert.Equal("test", strTest.ToSafeString(string.Empty));
        }
    }
}
