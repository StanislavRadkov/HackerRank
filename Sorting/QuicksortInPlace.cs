﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class QuicksortInPlace
    {
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

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
                    i++;
                }
            }

            swap(i, right);

            Trace.WriteLine(String.Join(" ", arr));

            Sort(arr, left, i - 1);
            Sort(arr, i + 1, right);
        }
    }
}
