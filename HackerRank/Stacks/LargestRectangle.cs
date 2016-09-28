using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Stacks
{
    /// https://www.hackerrank.com/challenges/largest-rectangle
    public static class LargestRectangle
    {
        public static BigInteger Solve(int[] buildings)
        {
            var indexes = new Stack<int>();
            BigInteger max = 0;

            for (var i = 0; i < buildings.Length; i++)
            {

                while (indexes.Any() && buildings[indexes.Peek()] > buildings[i])
                {
                    var k = indexes.Pop();
                    BigInteger area = 0;

                    if (indexes.Any())
                    {
                        area = BigInteger.Multiply(buildings[k], (i - indexes.Peek() - 1));
                    }
                    else
                    {
                        area = BigInteger.Multiply(buildings[k], i);
                    }

                    if (area > max)
                    {
                        max = area;
                    }
                }

                if (!indexes.Any() || buildings[indexes.Peek()] <= buildings[i])
                {
                    indexes.Push(i);
                }
            }

            while (indexes.Any())
            {
                var k = indexes.Pop();
                BigInteger area = 0;

                if (indexes.Any())
                {
                    area = BigInteger.Multiply(buildings[k], (buildings.Length - 1 - indexes.Peek()));
                }
                else
                {
                    area = BigInteger.Multiply(buildings[k], buildings.Length);
                }

                if (area > max)
                {
                    max = area;
                }
            }

            return max;
        }
    }
}
