using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/caesar-cipher-1
    public static class CaesarCipher
    {
        public static string Decode(string a, int k)
        {
            var sb = new StringBuilder(a.Length);

            for(var i = 0; i < a.Length; i++)
            {
                if (Char.IsLetter(a[i]))
                {
                    var code = (int)a[i];

                    if (code >= 65 && code <= 90)
                    {
                        code = (code - 65 + k) % 26 + 65;
                    }
                    else if(code >= 97 && code <= 122)
                    {
                        code = (code - 97 + k) % 26 + 97;
                    }

                    sb.Append((char)(code));
                }
                else
                {
                    sb.Append(a[i]);
                }
            }

            return sb.ToString();
        }
    }
}
