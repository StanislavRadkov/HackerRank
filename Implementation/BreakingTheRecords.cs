using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/breaking-best-and-worst-records
    public static class BreakingTheRecords
    {
        public static Tuple<int, int> Count(int[] input)
        {
            var min = input[0];
            var max = input[0];
            var minCount = 0;
            var maxCount = 0;

            for (var i = 1; i < input.Length; i++)
            {
                var value = input[i];
                if (value < min)
                {
                    min = value;
                    minCount++;
                }
                else if (value > max)
                {
                    max = value;
                    maxCount++;
                }
            }

            return new Tuple<int, int>(maxCount, minCount);
        }
    }
}
