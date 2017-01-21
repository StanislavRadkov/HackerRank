using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/reduced-string
    public static class SuperReducedString
    {
        public static string Reduce(string input)
        {
            const string pattern = "(.)\\1{1}";

            while (Regex.Match(input, pattern).Length > 0)
            {
                input = Regex.Replace(input, pattern, String.Empty);
            }

            return input;
        }
    }
}
