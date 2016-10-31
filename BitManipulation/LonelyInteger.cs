using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation
{
    // https://www.hackerrank.com/challenges/lonely-integer
    public static class LonelyInteger
    {
        public static int Solve(int[] input)
        {
            var unique = 0;

            foreach (var i in input)
            {
                unique ^= i;
            }

            return unique;
        }
    }
}
