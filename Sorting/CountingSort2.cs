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
                count[value-1]++;
            }

            return count;
        }
    }
}
