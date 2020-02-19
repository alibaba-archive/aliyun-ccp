namespace AlibabaCloud.AccessTokenCredential.Utils
{
    internal static class Extensions
    {
        internal static string ToSafeString(this object obj, string defaultStr = null)
        {
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
