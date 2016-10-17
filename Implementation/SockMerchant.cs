using System.Collections.Generic;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/sock-merchant
    public static class SockMerchant
    {
        public static int Solve(int[] socks)
        {
            var count = 0;
            var pairs = new HashSet<int>();

            foreach (var sock in socks)
            {
                if (pairs.Contains(sock))
                {
                    count++;
                    pairs.Remove(sock);
                }
                else
                {
                    pairs.Add(sock);
                }
            }

            return count;
        }
    }
}
