using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/repeated-string
    public static class RepeatedString
    {
        public static long Solve(string a, long n)
        {
            checked
            {
                Func<char, bool> f = c => c == 'a';

                return a.Count(f) * (n/a.Length) + a.Substring(0, (int)(n % a.Length)).Count(f);
            }
        }
    }
}
