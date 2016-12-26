using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    // https://www.hackerrank.com/challenges/longest-increasing-subsequent
    public static class LongestIncreasingSubsequence
    {
        // http://stackoverflow.com/questions/2631726/how-to-determine-the-longest-increasing-subsequence-using-dynamic-programming
        // https://www.youtube.com/watch?v=S9oUiVYEq7E
        public static int GetLongestIncreasingSubsequenceNLogN(int[] values)
        {
            var from = Enumerable.Repeat(-1, values.Length).ToArray();
            var results = new int[values.Length];
            results[0] = 0;
            var length = 0;

            // Start from 1
            for (var i = 1; i < values.Length; i++)
            {
                if (values[results[0]] == values[i] || values[results[length]] == values[i])
                {
                    continue;
                }

                if (values[results[0]] > values[i])
                {
                    results[0] = i;
                }
                else if (values[results[length]] < values[i])
                {
                    results[++length] = i;
                    from[i] = results[length - 1];
                }
                else
                // Otherwise find the smallest element in S, which is >= than X, and change it to X.
                // Because S is sorted at any time, the element can be found using binary search in log(N).
                {
                    var index = CeilIndex(values, results, length, values[i]);
                    results[index] = i;
                    from[i] = results[index - 1];
                }
            }

            var lis = GetLongestIncreasingSubsequence(values, from, results[length]);

            return length + 1;
        }

        private static int[] GetLongestIncreasingSubsequence(int[] values, int[] from, int indexOfMaxValue)
        {
            var index = indexOfMaxValue;
            var sequence = new Stack<int>(values.Length);

            do
            {
                sequence.Push(values[index]);
                index = from[index];
            } while (index != -1);

            return sequence.ToArray();
        }

        private static int CeilIndex(int[] values, int[] results, int length, int currentValue)
        {
            int start = 0;
            int middle;
            int end = length;

            while (start <= end)
            {
                middle = (start + end) / 2;

                if (middle < length &&
                    values[results[middle]] < currentValue &&
                    currentValue <= values[results[middle + 1]])
                {
                    return middle + 1;
                }

                if (values[results[middle]] < currentValue)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

            return -1;
        }

        public static int GetLongestIncreasingSubsequenceLength(int[] data)
        {
            var count = Enumerable.Repeat(1, data.Length).ToArray();

            for (var i = 1; i < data.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (data[j] < data[i] && count[j] + 1 > count[i])
                    {
                        count[i] = count[j] + 1;
                    }
                }
            }

            return count.Max();
        }

        public static int[] GetLongestIncreasingSubsequence(int[] data)
        {
            var count = Enumerable.Repeat(1, data.Length).ToArray();
            var from = Enumerable.Range(0, data.Length).ToArray();

            for (var i = 1; i < data.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (data[j] < data[i] && count[j] + 1 > count[i])
                    {
                        count[i] = count[j] + 1;
                        from[i] = j;
                    }
                }
            }

            var index = IndexOfMaxValue(count);
            var newIndex = index;
            var sequence = new Stack<int>(data.Length);

            do
            {
                index = newIndex;
                sequence.Push(data[index]);
                newIndex = from[index];
            } while (index != newIndex); 

            return sequence.ToArray();
        }

        private static int IndexOfMaxValue(int[] array)
        {
            var index = -1;
            var maxValue = int.MinValue;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
