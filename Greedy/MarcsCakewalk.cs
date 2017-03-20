using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/marcs-cakewalk
    public static class MarcsCakewalk
    {
        public static long Miles(int[] cakes)
        {
            long result = 0;

            Array.Sort(cakes, (i1, i2) => i2.CompareTo(i1));

            for (var i = 0; i < cakes.Length; i++)
            {
                result += (long)Math.Pow(2, i) * cakes[i];
            }

            return result;
        }
    }
}
