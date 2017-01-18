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

            for (; positionOfMSB >= 0 && (msb1.Count == 0 || msb0.Count == 0); positionOfMSB--)
            {
                int msb = 1 << positionOfMSB;

                msb1.Clear();
                msb0.Clear();

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

            return min == int.MaxValue ? 0 : min;
        }
    }
}
