using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation
{
    // https://www.hackerrank.com/challenges/maximizing-xor
    public static class MaximizingXOR
    {
        public static int Solve(int l, int r)
        {
            var max = -1;

            for (var a = l; a <= r - 1; a++)
            {
                for (var b = a + 1; b <= r; b++)
                {
                    var value = a ^ b;
                    if (value > max)
                    {
                        max = value;
                    }
                }
            }

            return max;
        }
    }
}
