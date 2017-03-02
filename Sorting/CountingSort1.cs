using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/countingsort1
    public class CountingSort1
    {
        public static int[] Count(int[] arr)
        {
            var count = new int[100];

            foreach (var value in arr)
            {
                count[value]++;
            }

            return count;
        }
    }
}
