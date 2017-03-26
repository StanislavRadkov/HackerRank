using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/sherlock-and-valid-string
    public static class SherlockAndValidString
    {
        public static bool CanBeConverted(string a)
        {
            int[] count = new int[26];

            int max = int.MinValue;
            for (var i = 0; i < a.Length; i++)
            {
                var index = a[i] - 'a';
                count[index]++;
                if (count[index] > max)
                {
                    max = count[index];
                }
            }

            var diff = 0;
            for (var i = 0; i < count.Length; i++)
            {
                if(count[i] > 0)
                    diff += Math.Abs(max - count[i]);
            }

            return diff <= 1;
        }
    }
}
