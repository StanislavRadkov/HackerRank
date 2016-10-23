using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/strange-code
    public static class StrangeCounter
    {
        public static long Solve(long t) 
        {
            checked
            {
                long n = 1;
                while (3 * (n - 1) < t) 
                {
                    n = 2 * n;
                };

                return (3 * (n - 1) - t + 1);
            }
        }
    }
}
