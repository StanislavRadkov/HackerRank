using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/two-strings
    public static class TwoStrings
    {
        public static bool HaveSubstrings(string a, string b)
        {
            var hashA = new HashSet<char>(a.ToLower());

            return hashA.Intersect(b.ToLower()).Any();
        }
    }
}
