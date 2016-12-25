using System;
using System.Linq;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/mini-max-sum
    public static class MiniMaxSum
    {
        public static long[] Solve(long[] data)
        {
            Array.Sort(data);

            var min = data.Take(4).Sum();
            var max = data.Skip(1).Take(4).Sum();

            return new long[] { min, max };
        }
    }
}
