using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/insertionsort2
    public static class InsertionSortPart2
    {
        public static IEnumerable<int[]> Sort(int[] data)
        {
            for (var i = 1; i < data.Length; i++)
            {
                var value = data[i];
                var j = i - 1;

                while (j >= 0 && data[j] > value)
                {
                    data[j + 1] = data[j];
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
