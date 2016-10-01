using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks
{
    public static class EqualStacks
    {
        private class SumStack
        {
            private Stack<int> _stack { get; set; }

            public int Sum { get; private set; }

            public SumStack(IList<int> values)
            {
                _stack = new Stack<int>(values.Count);
                for (var i = values.Count - 1; i >= 0; i--)
                {
                    _stack.Push(values[i]);
                    Sum += values[i];
                }
            }

            public int Height()
            {
                return _stack.Count;
            }

            public int Pop()
            {
                var value = _stack.Pop();
                Sum -= value;

                return value;
            }
        }

        public static int Solve(IEnumerable<int[]> data)
        {
            var stacks = data.Select(d => new SumStack(d)).ToList();

            var height = 0;

            while (stacks.Select(s => s.Sum).Distinct().Count() != 1)
            {
                stacks.Sort((s1,s2) => s2.Sum.CompareTo(s1.Sum));

                var first = stacks.First();
                if (first.Height() > 0)
                {
                    first.Pop();
                }
            }

            if (stacks.First().Height() > 0)
            {
                height = stacks.First().Sum;
            }

            return height;
        }
    }
}
