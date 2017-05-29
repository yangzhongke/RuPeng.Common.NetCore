using System;
using System.Collections.Generic;
using System.Text;

namespace RuPeng.Common.NetCore
{
    public static class CommonHelper
    {
        /// <summary>
        /// 得到当前时间的Unix时间戳
        /// </summary>
        /// <returns></returns>
        public static long GetUnixTimeStamp()
        {
            System.DateTime startTime = TimeZoneInfo.ConvertTime(new System.DateTime(1970, 1, 1),TimeZoneInfo.Local);
            return (long)((DateTime.Now - startTime).TotalSeconds * 1000);
        }

    }
}
