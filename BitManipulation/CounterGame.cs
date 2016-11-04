using System;

namespace BitManipulation
{
    // https://www.hackerrank.com/challenges/counter-game
    public static class CounterGame
    {
        public static string Solve(UInt64 n)
        {
            var counter = 0;

            while (n > 1)
            {                
                // If N is a power of 2, reduce the counter by half of N.
                if ((n & (n-1)) == 0)
                {
                    n = n >> 1;
                }
                else // If N is not a power of 2, reduce the counter by the largest power of 2 less than N.
                {
                    var k = 63;
                    while ((n & (1UL << k)) == 0)
                    {
                        k--;
                    }

                    n &= ~(1UL << k);
                }

                counter++;
            }

            return counter % 2 == 0 ? "Richard" : "Louise";
        }
    }
}
