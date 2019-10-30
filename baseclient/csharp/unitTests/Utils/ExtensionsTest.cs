using Aliyun.SDK.CCP.Utils;
using Xunit;

namespace baseClientUnitTests.Utils
{
    public class ExtensionsTest
    {
        [Fact]
        public void TestToSafeString()
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
