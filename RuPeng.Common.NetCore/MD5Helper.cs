using System.IO;
using System.Security.Cryptography;

namespace RuPeng.Common.NetCore
{
    public static class MD5Helper
    {
        /// <summary>
        ///计算字符串的md5值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ComputeMd5(this string str)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
            return ComputeMd5(bytes);
        }

        /// <summary>
        /// 计算byte[]的md5值
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ComputeMd5(this byte[] bytes)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] computeBytes = md5.ComputeHash(bytes);
                return GetHexString(computeBytes);
            }
        }

        /// <summary>
        /// 计算Stream的md5值
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>

        public static string ComputeMd5(this Stream stream)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] computeBytes = md5.ComputeHash(stream);
                return GetHexString(computeBytes);
            }
        }

        private static string GetHexString(byte[] bytes)
        {
            char[] hexArray = new char[bytes.Length << 1];
            for (int i = 0; i < hexArray.Length; i += 2)
            {
                byte b = bytes[i >> 1];
                hexArray[i] = GetHexValue(b >> 4);       // b / 16
                hexArray[i + 1] = GetHexValue(b & 0xF);  // b % 16
            }
            return new string(hexArray, 0, hexArray.Length);

            char GetHexValue(int i)
            {
                if (i < 10)
                {
                    return (char)(i + '0');
                }
                return (char)(i - 10 + 'a');
            }
        }
    }
}
