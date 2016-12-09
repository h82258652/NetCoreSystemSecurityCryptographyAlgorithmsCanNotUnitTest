using System;
using System.Security.Cryptography;
using System.Text;

namespace Library
{
    public static class HashHelper
    {
        public static string GetStringMD5(string str)
        {
            using (var md5 = MD5.Create())
            {
                var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
                return BitConverter.ToString(bytes).Replace("-", "");
            }
        }
    }
}