using System.Collections.Generic;

namespace Sorting
{
    // https://www.hackerrank.com/challenges/countingsort4
    public class CountingSort4
    {
        public static string[] Sort(KeyValuePair<int, string>[] arr)
        {
            var count = new int[100];

            // Store count of each value
            for (int i = 0; i < arr.Length; i++)
            {
                ++count[arr[i].Key];
            }

            // Change count[i] so that count[i] now contains actual
            // position of this character in output array
            for (var i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            // Build the output string array
            var output = new string[arr.Length];
            for (var i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i].Key] - 1] = arr[i].Value;
                --count[arr[i].Key];
            }

            return output;
        }
    }
}
