using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/camelcase
    public static class Camelcase
    {
        public static int CountWords(string input)
        {
            if (input.Length == 0)
            {
                return 0;
            }

            return Regex.Matches(input, "[A-Z]").Count + 1;
        }
    }
}
