using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class MaximumElement
    {
        private Stack<int> stack;
        private Stack<int> maxStack;

        public MaximumElement()
        {
            stack = new Stack<int>();
            maxStack = new Stack<int>();
        }
        
        public int? Parse(int[] query)
        {
            switch (query[0])
            {
                case 1:
                    stack.Push(query[1]);
                    if (maxStack.Count == 0 || (maxStack.Count > 0 && query[1] >= maxStack.Peek()))
                    {
                        maxStack.Push(query[1]);
                    }
                    break;

                case 2:
                    var value = stack.Pop();
                    if (value == maxStack.Peek())
                    {
                        maxStack.Pop();
                    }
                    break;

                case 3:
                    return maxStack.Peek();
            }

            return null;
        }
    }
}
