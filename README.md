# RuPeng.Common.NetCore
Common .net library of http://www.rupeng.com

Nuget:  
```
	Install-Package RuPeng.Common.NetCore
```

# CommonHelper.cs
* public static long GetUnixTimeStamp() 返回当前时间Unix时间戳

# MD5Helper.cs
* string ComputeMd5(this string str) 返回字符串的MD5值
* string ComputeMd5(this byte[] bytes) 返回byte[]的MD5值
* string ComputeMd5(this Stream stream) 返回流的MD5值

# StringHelper.cs
* string Cut(this string str, int maxLen)  截取str中最多钱maxLen个字符
* string RemoveNonChineseChars(this string str)  移除str中的非中文字符
* string CreateVerifyCode(int len) 创建长度为len的随机字符串（由字符、数字组成，不包括0、o、1、l等容易混淆的字符）

