using System;
using System.Collections.Generic;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/closest-numbers
    public class ClosestNumbers
    {
        public static List<Tuple<int, int>> GetPairs(int[] input)
        {
            var tuples = new List<Tuple<int, int>>();
            var minDiff = int.MaxValue;

            Array.Sort(input);

            for (var i = 0; i < input.Length - 2; i++)
            {
                var diff = Math.Abs(input[i] - input[i + 1]);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    tuples.Clear();
                    tuples.Add(new Tuple<int, int>(input[i], input[i + 1]));
                }
                else if (diff == minDiff)
                {
                    tuples.Add(new Tuple<int, int>(input[i], input[i+1]));
                }
            }

            return tuples;
        }
    }
}
