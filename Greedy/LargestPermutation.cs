using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/largest-permutation
    public static class LargestPermutation
    {
        public static void Mutate(int[] a, int k)
        {
            var dict = new Dictionary<int, int>(a.Length);

            for (var i = 0; i < a.Length; i++)
            {
                dict[a[i]] = i;
            }

            Action<int, int> swap = (x, y) =>
            {
                dict[a[x]] = y;
                dict[a[y]] = x;

                var temp = a[x];
                a[x] = a[y];
                a[y] = temp;
            };

            for (var i = 0; i < a.Length && k > 0; i++)
            {
                var expected = a.Length - i;
                if (a[i] != expected)
                {
                    swap(i, dict[expected]);
                    --k;
                }
            }
        }
    }
}
