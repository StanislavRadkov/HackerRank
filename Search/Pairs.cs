using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/pairs
    public class Pairs
    {
        public static int CountPairs(int[] a, int k)
        {
            var dict = new Dictionary<int, int>();

            foreach (var value in a)
            {
                var diff = value - k;
                if (diff <= 0)
                {
                    continue;
                }

                if (!dict.ContainsKey(diff))
                {
                    dict[diff] = 1;
                }
                else
                {
                    dict[diff]++;
                }
            }

            var count = 0;

            foreach (var value in a)
            {
                if (dict.ContainsKey(value))
                {
                    count += dict[value];
                }
            }

            return count;
        }
    }
}
