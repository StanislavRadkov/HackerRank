using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/game-of-thrones
    public static class GameOfThronesI
    {
        public static bool Validate(string a)
        {
            var letters = new int[26];

            foreach (var c in a)
            {
                letters[c - 'a']++;
            }

            return letters.Count(c => c % 2 != 0) <= 1;
        }
    }
}
