using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/gem-stones
    public static class Gemstones
    {
        public static int Count(IEnumerable<string> a)
        {
            var hash = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");

            foreach (var s in a)
            {
                hash.IntersectWith(s);
            }

            return hash.Count;
        }
    }
}
