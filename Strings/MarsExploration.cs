using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // https://www.hackerrank.com/challenges/mars-exploration
    public static class MarsExploration
    {
        public static string sos = "SOS";

        public static int CountAlteredLetters(string k)
        {
            int count = 0;

            for (int i = 0, p = 0; i < k.Length; i++, p = ++p % sos.Length)
            {
                if (k[i] != sos[p])
                    count++;
            }

            return count;
        }
    }
}
