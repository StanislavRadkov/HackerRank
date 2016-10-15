using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/divisible-sum-pairs
    public static class DivisibleSumPairs
    {
        public static int Solve(int k, int[] numbers)
        {
            var count = 0;

            for (var i = 0; i < numbers.Length - 1; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if ((numbers[i] + numbers[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
