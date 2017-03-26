using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/string-construction
    public static class StringConstruction
    {
        public static int Count(string a)
        {
            var hash = new HashSet<char>(a.ToCharArray());
            return hash.Count;
        }
    }
}
