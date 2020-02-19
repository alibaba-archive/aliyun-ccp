using System;

namespace AlibabaCloud.AccessTokenCredential.Utils
{
    internal static class TimeUtils
    {
        private static readonly DateTime DayZero = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        internal static long GetTimeMillis(this DateTime d)
        {
            return (long)(d - DayZero).TotalMilliseconds;
        }

        internal static string GetGMTDate()
        {
            return DateTime.UtcNow.ToUniversalTime().GetDateTimeFormats('r')[0];
        }
    }
}
