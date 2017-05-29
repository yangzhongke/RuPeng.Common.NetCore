using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RuPeng.Common.NetCore
{
    public static class StringHelper
    {
        /// <summary>
        /// 截取字符串str中最大长度为maxLen的子字符串
        /// </summary>
        /// <param name="str"></param>
        /// <param name="maxLen"></param>
        /// <returns></returns>
        public static string Cut(this string str, int maxLen)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            int len = Math.Min(str.Length, maxLen);
            return str.Substring(0, len);
        }

        /// <summary>
        /// 移除所有非中文字符
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveNonChineseChars(this string str)
        {
            return Regex.Replace(str, @"[^\u4e00-\u9fa5]", "");
        }

        /// <summary>
        /// 创建长度为len的随机字符串
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string CreateVerifyCode(int len)
        {
            //不包含易混淆的字符
            char[] data = { 'a','c','d','e','f','h','k','m',
                'n','r','s','t','w','x','y','3','4','5','7','8'};
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                int index = rand.Next(data.Length);//[0,data.length)
                char ch = data[index];
                sb.Append(ch);
            }
            //勤测！
            return sb.ToString();
        }

    }
}
