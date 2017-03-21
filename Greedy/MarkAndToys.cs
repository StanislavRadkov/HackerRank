using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    // https://www.hackerrank.com/challenges/mark-and-toys
    public static class MarkAndToys
    {
        public static int Max(int[] toys, int money)
        {
            Array.Sort(toys);

            return toys.TakeWhile(x => (money -= x) > 0).Count();                
        }
    }
}
