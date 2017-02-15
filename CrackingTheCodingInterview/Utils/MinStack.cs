using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    /* How would you design a stack which, in addition to push and pop, also has a 
    * function min which returns the minimum element? Push, pop and min should all 
    * operate in 0(1) time.
    */
    public class MinStack
    {
        private Stack<int> _stack;
        private Stack<int> _minStack;

        public MinStack()
        {
            _stack = new Stack<int>();
            _minStack = new Stack<int>();
        }

        public void Push(int value)
        {
            _stack.Push(value);

            if (_minStack.Count == 0 || value <= _minStack.Peek())
            {
                _minStack.Push(value);
            }
        }

        public void Push(IEnumerable<int> values)
        {
            foreach (var value in values)
            {
                this.Push(value);
            }
        }

        public int Pop()
        {
            if (_minStack.Peek() == _stack.Peek())
            {
                _minStack.Pop();
            }

            return _stack.Pop();
        }

        public int Min => _minStack.Peek();

        public int Count => _stack.Count;
    }
}
