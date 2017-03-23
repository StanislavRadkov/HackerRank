using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation
{
    // https://www.hackerrank.com/challenges/sansa-and-xor/forum
    public static class SansaAndXOR
    {
        public static int XOR(int[] a)
        {
            // The xor of array with even length is always 0.
            if (a.Length%2 == 0)
            {
                return 0;
            }

            var result = 0;

            // when it is even the number appears odd times and hence will be considered in the xor sum
            for (var i = 0; i < a.Length; i += 2)
            {
                result ^= a[i];
            }

            return result;
        }
    }
}
