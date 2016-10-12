using System;
using System.Collections.Generic;

namespace Stacks
{
    // https://www.hackerrank.com/challenges/and-xor-or
    public static class ANDxorOR
    {
        public static int Solve(List<int> data)
        {
            var maxValue = 0;
            var stack = new Stack<int>(data.Count);

            foreach (var i in data)
            {
                while (stack.Count > 0)
                {
                    var value = i ^ stack.Peek();
                    if (value > maxValue)
                    {
                        maxValue = value;
                    }

                    if (i < stack.Peek())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                stack.Push(i);
            }

            return maxValue;
        }
    }
}