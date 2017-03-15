using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/hackerrank-in-a-string
    public static class HackerRankInAString
    {
        private static readonly string hackerrank = "hackerrank";

        public static bool Is(string a)
        {
            var p = 0;
            for (var i = 0; i < a.Length && p < hackerrank.Length; i++)
            {
                if (a[i] == hackerrank[p])
                    p++;
            }

            return p == hackerrank.Length;
        }
    }
}
