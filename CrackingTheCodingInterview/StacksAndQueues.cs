using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class StacksAndQueues
    {
        /* Write a program to sort a stack in ascending order (with biggest items on top). 
         * You may use at most one additional stack to hold items, but you may not copy the 
         * elements into any other data structure (such as an array). The stack supports the
         * following operations: push, pop, peek, and isEmpty */

        public static void SortStackWithOneAdditionalStack(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                return;
            }

            var stack2 = new Stack<int>();

            int? min = null;

            while (stack.Count > 0)
            {
                var value = stack.Pop();

                if (!min.HasValue || min.Value > value)
                {
                    min = value;
                }

                if (stack.Count > 0)
                {
                    stack2.Push(value);
                };
            }

            stack.Push(min.Value);

            do
            {
                var value = stack2.Pop();

                while (value < stack.Peek())
                {
                    stack2.Push(stack.Pop());
                }

                stack.Push(value);
            } while (stack2.Count > 0);
        }
    }
}
