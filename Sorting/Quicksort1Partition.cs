using System.Collections.Generic;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/quicksort2
    public static class Quicksort1Partition
    {
        public static List<int> Partion(int[] data)
        {
            var pivot = data[0];
            var equal = new List<int>();
            var left = new List<int>();
            var right = new List<int>();

            foreach (var value in data)
            {
                if (value < pivot)
                {
                    left.Add(value);
                }
                else if (value > pivot)
                {
                    right.Add(value);
                }
                else
                {
                    equal.Add(value);
                }
            }

            left.AddRange(equal);
            left.AddRange(right);

            return left;
        }
    }
}
