using System;
using System.Collections.Generic;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/insertionsort2
    public static class InsertionSortPart2
    {
        public static IEnumerable<int[]> Sort(int[] data, Action<int> swap = null)
        {
            for (var i = 1; i < data.Length; i++)
            {
                var value = data[i];
                var j = i - 1;

                while (j >= 0 && data[j] > value)
                {
                    data[j + 1] = data[j];

                    #region Debug Code
                    swap?.Invoke(data[j]);
                    #endregion

                    j--;
                }
                
                data[j + 1] = value;

                var result = new int[data.Length];
                Array.Copy(data, result, data.Length);
                yield return result;
            }
        }
    }
}
