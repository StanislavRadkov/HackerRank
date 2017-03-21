using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/two-arrays
    public static class TwoArrays
    {
        public static bool PermutationExists(int[] a, int[] b, int k)
        {
            var c = new int[a.Length + b.Length];

            a.CopyTo(c, 0);
            b.CopyTo(c, b.Length);

            Array.Sort(c);

            for (var i = 0; i < a.Length; i++)
            {
                if ((c[i] + c[c.Length - i - 1]) < k)
                    return false;
            }

            return true;
        }
    }
}
