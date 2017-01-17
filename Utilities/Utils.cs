using System;

namespace Utilities
{
    public static class Utils
    {
        public static bool IsPrime(long n)
        {
            checked
            {
                if (n < 2)
                {
                    return false;
                }

                if (n % 2 == 0)
                {
                    return (n == 2);
                }

                var m = Math.Sqrt(n);

                for (var i = 3; i <= m; i += 2)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static int NumberOfSetBits(int i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }

        public static int GetMSB(int n)
        {
            for (var i = 31; i >= 0; i--)
            {
                if ((n & (1 << i)) != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
