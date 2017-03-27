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
            var dict = new Dictionary<int, int>();
                   
            for (var i = 0; i < a.Length; i++)
            {
                var v = a[i] - 'a';
                if (dict.ContainsKey(v))
                {
                    dict[v]++;
                }
                else
                {
                    dict.Add(a[i] - 'a', 1);
                }
            }

            var count = new Dictionary<int, int>();

            foreach (var v in dict)
            {
                if (count.ContainsKey(v.Value))
                {
                    count[v.Value]++;
                }
                else
                {
                    count.Add(v.Value, 1);
                }
            }

            var mostCommonCount = count.OrderByDescending(v => v.Value).First().Key;

            var diff = dict.Values.Where(x => x != mostCommonCount).Select(x => x > mostCommonCount ? Math.Abs(x - mostCommonCount) : x).Sum();

            return diff <= 1;
        }
    }
}
