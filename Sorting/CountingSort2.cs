using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/countingsort2
    public class CountingSort2
    {
        public static int[] Count(int[] arr)
        {
            var count = new int[100];

            foreach (var value in arr)
            {
                count[value]++;
            }

            var result = new int[arr.Length];
            var r = 0;

            for (var i = 0; i < count.Length; i++)
            {
                for (var k = 0; k < count[i]; k++)
                {
                    result[r++] = i;
                }
            }

            return result;
        }
    }
}
