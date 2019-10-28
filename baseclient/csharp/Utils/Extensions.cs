namespace Aliyun.SDK.CCP.Utils
{
    public static class Extensions
    {
        public static string ToSafeString(this object obj, string defaultStr = null)
        {
            if (obj == null)
            {
                return defaultStr;
            }
            try
            {
                return obj.ToString();
            }
            catch
            {
                return defaultStr;
            }
        }
    }
}