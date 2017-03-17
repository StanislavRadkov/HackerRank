using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/the-love-letter-mystery
    public static class TheLoveLetterMystery
    {
        public static int Count(string a)
        {
            var count = 0;
            for (var i = 0; i < a.Length/2; i++)
            {
                count += Math.Abs(a[i] - a[a.Length - i - 1]);
            }

            return count;
        }
    }
}
