using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/angry-children
    public static class AngryChildren
    {
        public static int GetMinUnfairness(int[] values, int k)
        {
            Array.Sort(values);
            var min = int.MaxValue;

            for (var i = k - 1; i < values.Length; i++)
            {
                var diff = values[i] - values[i - (k - 1)];

                if (diff < min)
                {
                    min = diff;
                }
            }

            return min;
        }
    }
}
