using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/funny-string
    public static class FunnyString
    {
        public static bool Is(string a)
        {
            for (int i = 1, k = a.Length - 2; i < a.Length; i++, k--)
            {
                if (Math.Abs(a[i] - a[i - 1]) != Math.Abs(a[k] - a[k + 1]))
                    return false;
            }

            return true;
        }
    }
}
