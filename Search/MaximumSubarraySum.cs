using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/maximum-subarray-sum
    public class MaximumSubarraySum
    {
        public static ulong Get(ulong[] input, ulong m)
        {
            ulong[] prefix = new ulong[input.Length];
            ulong curr = 0;
            for (int i = 0; i < input.Length; i++)
            {
                curr = (input[i] % m + curr) % m;
                prefix[i] = curr;
            }

            ulong ret = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    ret = Math.Max(ret, (prefix[i] - prefix[j] + m) % m);
                }
                ret = Math.Max(ret, prefix[i]);
            }

            return ret;
        }
    }
}
