using System;

namespace Aliyun.SDK.CCP.Utils
{
    public static class TimeUtils
    {
        private static readonly DateTime DayZero = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long GetTimeMillis(this DateTime d)
        {
            return (long) (d - DayZero).TotalMilliseconds;
        }

        public static string GetGMTDate()
        {
            return DateTime.UtcNow.ToUniversalTime().GetDateTimeFormats('r') [0];
        }
    }
}