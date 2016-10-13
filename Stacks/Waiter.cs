using System;
using System.Collections.Generic;
using Utilities;
using System.Linq;

namespace Stacks
{
    // https://www.hackerrank.com/challenges/waiter
    public static class Waiter
    {
        public static int[] Solve(int q, Stack<int> plates)
        {
            var pileA = new Stack<int>(plates.Count);
            var pileB = new Stack<int>(plates.Count);
            var result = new Queue<int>();
            var primes = new PrimeNumbers();

            for (var i = 0; i < q; i++)
            {
                while (plates.Count > 0)
                {
                    var value = plates.Pop();
                    if (value % primes.Current == 0)
                    {
                        pileA.Push(value);
                    }
                    else
                    {
                        pileB.Push(value);
                    }
                }

                plates = new Stack<int>(pileB.Reverse());
                pileB.Clear();
                primes.MoveNext();

                while (pileA.Count > 0)
                {
                    result.Enqueue(pileA.Pop());
                }
            }

            while (plates.Count > 0)
            {
                result.Enqueue(plates.Pop());
            }

            return result.ToArray();
        }
    }
    
}
