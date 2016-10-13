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
    }
}
