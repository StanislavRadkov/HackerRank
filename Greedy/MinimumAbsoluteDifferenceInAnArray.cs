using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array
    public static class MinimumAbsoluteDifferenceInAnArray
    {
        public static int Get(int[] input)
        {
            Array.Sort(input);

            var min = int.MaxValue;
            for (var i = 1; i < input.Length; i++)
            {
                var result = Math.Abs(input[i] - input[i - 1]);
                if (result < min)
                {
                    min = result;
                } 
            }

            return min;
        }
    }
}
