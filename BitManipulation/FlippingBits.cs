using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulation
{
    public static class FlippingBits
    {
        public static uint[] Solve(uint[] input)
        {
            var numbers = input.Clone() as uint[];
            for (var n = 0; n < numbers.Length; n++)
            {
                numbers[n] = ~numbers[n];
            }

            return numbers;
        }
    }
}
