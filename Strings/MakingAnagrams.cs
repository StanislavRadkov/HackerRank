using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/making-anagrams
    public static class MakingAnagrams
    {
        public static int Count(string a, string b)
        {
            var count = new int[26];

            foreach (char c in a)
            {
                count[c - 'a']++;
            }

            foreach (char c in b)
            {
                count[c - 'a']--;
            }

            var diff = 0;

            for (var i = 0; i < 26; i++)
            {
                diff += Math.Abs(count[i]);
            }

            return diff;
        }
    }
}
