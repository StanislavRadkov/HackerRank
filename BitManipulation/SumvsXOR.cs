using System;
using System.Linq;

namespace BitManipulation
{
    // https://www.hackerrank.com/challenges/sum-vs-xor
    public static class SumvsXOR
    {

        /* If you think about what XOR does, the solution makes more sense.
         * So the only way XOR and plus can result in an equal number is when 
         * they do not interfere with each other on a bitwise level, so you could say
                num1 + num2 == num1 ^ num2
            only if
                num1 & num2 == 0
        Now lets say your num1 has 3 zeros in it(in binary) then there are 2^3 
        different combinations that obey the above defined rule or in other words, 
        there are 8 different combinations of 1 and 0 that could fit within these three 
        zeros and could thus be added to your number without interfering with it.
        */
        public static long Solve(long n)
        {
            if (n == 0) // 2 ^ 1 = 2
            {
                return 1;
            }

            return (long)Math.Pow(2, Convert.ToString(n, 2).Count(x => x == '0'));
        }
    }
}
