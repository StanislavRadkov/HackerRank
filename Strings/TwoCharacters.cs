using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/two-characters
    public static class TwoCharacters
    {
        public static int CountMax(string a)
        {
            if (a.Length <= 1)
            {
                return 0;
            }

            const int numerOfLetters = 26;

            var pairs = new int[numerOfLetters, numerOfLetters];
            var count = new int[numerOfLetters, numerOfLetters];

            for (var i = 0; i < a.Length; i++)
            {
                var letter = (int) a[i];
                var num = (int) a[i] -'a';

                for (var col = 0; col < numerOfLetters; col++)
                {
                    if (pairs[num, col] == letter)
                    {
                        count[num, col] = -1;
                    }

                    if (count[num, col] != -1)
                    {
                        pairs[num, col] = letter;
                        count[num, col]++;
                    }
                }

                for (var row = 0; row < numerOfLetters; row++)
                {
                    if (pairs[row, num] == letter)
                    {
                        count[row, num] = -1;
                    }

                    if (count[row, num] != -1)
                    {
                        pairs[row, num] = letter;
                        count[row, num]++;
                    }
                }
            }

            return Math.Max(0, count.Cast<int>().Max());
        }
    }
}
