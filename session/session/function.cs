using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace session
{
    class function
    {

        public static string funMD5(string input)
        {
            MD5 mD5 = MD5.Create();
            byte[] inputByte = Encoding.UTF8.GetBytes(input);
            byte[] hash = mD5.ComputeHash(inputByte);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {

                stringBuilder.Append(hash[i].ToString("x2"));
            }
            return stringBuilder.ToString();


        }
    }
}
