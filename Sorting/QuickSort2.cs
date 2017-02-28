using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/quicksort2
    public static class QuickSort2
    {
        public static List<int> Sort(List<int> arr, List<List<int>> results)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            var pivot = arr[0];
            var equal = new List<int>();
            var left = new List<int>();
            var right = new List<int>();

            foreach (var value in arr)
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

            left = Sort(left, results);
            right = Sort(right, results);
    
            left.AddRange(equal);
            left.AddRange(right);

            results.Add(left.ToList());

            return left;
        }
    }
}
