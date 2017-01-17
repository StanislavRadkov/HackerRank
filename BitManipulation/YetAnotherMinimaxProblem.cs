using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BitManipulationTests
{
    public static class YetAnotherMinimaxProblem
    {   
        public static int Get(int[] data)
        {
            var msb1 = new List<int>(data.Length);
            var msb0 = new List<int>(data.Length);

            var positionOfMSB = data.Select(x => Utils.GetMSB(x)).Max();

            int msb = 1 << positionOfMSB;

            foreach (var n in data)
            {
                if ((msb & n) != 0)
                {
                    msb1.Add(n);
                }
                else
                {
                    msb0.Add(n);
                }
            }

            msb1.Sort();
            msb0.Sort();
            var min = int.MaxValue;
            for (var i = 0; i < msb1.Count; i++)
            {
                for (var j = 0; j < msb0.Count; j++)
                {
                    if (min > (msb1[i] ^ msb0[j]))
                    {
                        min = (msb1[i] ^ msb0[j]);

                    }

                }
            }

            var a = msb1.Last();
            var b = msb0.Last();

            var c = msb1.First();
            var d = msb0.First();

            return Math.Min(a ^ b, c ^ d);
        }
    }
}
