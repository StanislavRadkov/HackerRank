using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/countingsort3
    public class CountingSort3
    {
        public static int[] GetSums(int[] arr)
        {
            var count = new int[100];

            foreach (var value in arr)
            {
                count[value]++;
            }

            var sums = new int[100];

            var sum = 0;
            for (var i = 0; i < sums.Length; i++)
            {
                sum += count[i];

                sums[i] = sum;
            }

            return sums;
        }
    }
}
