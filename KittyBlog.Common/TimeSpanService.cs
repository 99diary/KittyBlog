﻿using System;

namespace KittyBlog.Common
{
    public class TimeSpanService
    {
        public static Int64 GetCurrentTimeUnix()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }
    }
}