using System;
using System.Collections.Generic;

namespace Stacks
{
    // https://www.hackerrank.com/challenges/and-xor-or
    public static class ANDxorOR
    {
        public static int Solve(List<int> data)
        {
            Func<int, int, int> calc = (m1, m2) => ((m1 & m2) ^ (m1 | m2)) & (m1 ^ m2);

            var maxValue = 0;

            for (var i = 0; i < data.Count - 1; i++)
            {
                for (var k = i + 1; k < data.Count; k++)
                {
                    int? a = null;
                    int? b = null;

                    for (var j = i; j <= k; j++)
                    {
                        if (b == null || data[j] < b)
                        {
                            a = b;
                            b = data[j];
                        }
                        else if (a == null || data[j] < a)
                        {
                            a = data[j];
                        }
                    }

                    var value = calc(a.Value, b.Value);

                    if (value > maxValue)
                    {
                        maxValue = value;
                    }
                }
            }

            return maxValue;
        }
    }
}