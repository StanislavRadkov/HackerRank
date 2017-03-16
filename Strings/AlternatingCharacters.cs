using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/alternating-characters
    public static class AlternatingCharacters
    {
        public static int Count(string a)
        {
            var count = 0;
            var p = 0;

            for (var i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    p++;
                }
                else
                {
                    count += p;
                    p = 0;
                }
            }

            count += p;

            return count;
        }
    }
}
