using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public static class ArrayAndStrings
    {
        public static bool AllUniqueCharactersASCII(string a)
        {
            var chars = new bool[256];

            for (var i = 0; i < a.Length; i++)
            {
                if (chars[a[i]])
                {
                    return false;
                }

                chars[a[i]] = true;
            }

            return true;
        }

        public static bool AllUniqueCharactersUnicode(string a)
        {
            var hashSet = new HashSet<char>();

            for (var i = 0; i < a.Length; i++)
            {
                if (hashSet.Contains(a[i]))
                {
                    return false;
                }

                hashSet.Add(a[i]);
            }

            return true;
        }
    }
}
