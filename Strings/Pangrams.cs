using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/pangrams
    public static class Pangrams
    {
        private static readonly HashSet<char> alphabet = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");

        public static bool Is(string a)
        {
            return alphabet.Except(a.ToLower()).Count() == 0;
        }
    }
}
