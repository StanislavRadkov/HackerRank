using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/insertionsort1
    public static class InsertionSortPart1
    {
        public static IEnumerable<int[]> Sort(int[] data)
        {
            var value = data[data.Length - 1];
            var go = true;

            for (var i = data.Length - 2; i >= 0 && go; i--)
            {
                if (data[i] > value)
                {
                    data[i + 1] = data[i];
                }
                else
                {
                    data[i + 1] = value;
                    go = false;
                }

                Trace.WriteLine(String.Join(" ", data));

                var result = new int[data.Length];
                Array.Copy(data, result, data.Length);

                yield return result;
            }

            if (go)
            {
                data[0] = value;

                var result = new int[data.Length];
                Array.Copy(data, result, data.Length);

                yield return result;
            }
        }
    }
}
