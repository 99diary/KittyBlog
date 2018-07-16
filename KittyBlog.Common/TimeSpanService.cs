using System;

namespace KittyBlog.Common
{
    public class TimeSpanService
    {
        /// <summary>
        /// 当前时间转为时间戳
        /// </summary>
        /// <returns></returns>
        public static Int64 GetCurrentTimeUnix()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }
        ///// <summary>
        ///// 时间戳转时间
        ///// </summary>
        ///// <param name="timeunix"></param>
        ///// <returns></returns>
        //public static DateTime TimeUnixToDateTime(Int64 timeUnix,Int32 timeZone)
        //{
        //    return new DateTime();
        //}
    }
}
