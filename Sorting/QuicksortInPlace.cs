using System;
using System.Diagnostics;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/quicksort3
    // https://www.hackerrank.com/challenges/quicksort4
    public static class QuicksortInPlace
    {
        public static void Sort(int[] arr, ref int count)
        {
            Sort(arr, 0, arr.Length - 1, ref count);
        }

        public static void Sort(int[] arr)
        {
            var count = 0;
            Sort(arr, 0, arr.Length - 1, ref count);
        }

        private static void Sort(int[] arr, int left, int right, ref int count)
        {
            if (left >= right)
            {
                return;
            }

            var p = Partition(arr, left, right, ref count);
            Trace.WriteLine(String.Join(" ", arr));

            Sort(arr, left, p - 1, ref count);
            Sort(arr, p + 1, right, ref count);
        }

        private static int Partition(int[] arr, int left, int right, ref int count)
        {
            Action<int, int> swap = (a, b) =>
            {
                var temp = arr[a];
                arr[a] = arr[b];
                arr[b] = temp;
            };

            var pivot = arr[right];
            var i = left;

            for (var j = left; j <= right - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    swap(i, j);
                    count++;
                    i++;
                }
            }

            swap(i, right);
            count++;

            return i;
        }
    }
}
