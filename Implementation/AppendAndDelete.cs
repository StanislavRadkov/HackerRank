using System;

namespace Implementation
{
    // https://www.hackerrank.com/challenges/append-and-delete
    public static class AppendAndDelete
    {
        public static bool CanBeConverted(string a, string b, int k)
        {
            var index = IndexOfFirstDifference(a, b);

            if (a.Length == b.Length)
            {
                if (index == -1)
                {
                    return true;
                }
            }
            else if (a.Length != b.Length && index == -1)
            {
                var diff = Math.Abs(a.Length - b.Length);

                if (k < diff)
                {
                    return false;
                }

                if (k > a.Length + b.Length)
                {
                    return true;
                }

                return (k - diff) % 2 == 0;
            }

            return ((a.Length - index) + (b.Length - index)) <= k;
        }

        private static int IndexOfFirstDifference(string a, string b)
        {
            var index = -1;
            var minLength = Math.Min(a.Length, b.Length);

            for (int i = 0; i < minLength; i++)
            {
                if(a[i] != b[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
