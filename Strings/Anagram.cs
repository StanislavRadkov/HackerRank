using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/anagram
    public static class Anagram
    {
        public static int Changes(string a)
        {
            if (a.Length % 2 != 0)
            {
                return -1;
            }

            var letters = new int[26];

            for (var i = a.Length - 1; i >= a.Length / 2; i--)
            {
                letters[a[i] - 'a']++;
            }

            for (var i = 0; i < a.Length / 2; i++)
            {
                if (letters[a[i] - 'a'] > 0)
                {
                    letters[a[i] - 'a']--;
                }
            }

            return letters.Sum();
        }
    }
}
