using System.Collections.Generic;

namespace Stacks
{
    // https://www.hackerrank.com/challenges/maximum-element
    public class MaximumElement
    {
        private Stack<int> _stack;
        private Stack<int> _maxStack;

        public MaximumElement()
        {
            _stack = new Stack<int>();
            _maxStack = new Stack<int>();
        }
        
        public int? Parse(int[] query)
        {
            switch (query[0])
            {
                case 1:
                    _stack.Push(query[1]);
                    if (_maxStack.Count == 0 || (_maxStack.Count > 0 && query[1] >= _maxStack.Peek()))
                    {
                        _maxStack.Push(query[1]);
                    }
                    break;

                case 2:
                    var value = _stack.Pop();
                    if (value == _maxStack.Peek())
                    {
                        _maxStack.Pop();
                    }
                    break;

                case 3:
                    return _maxStack.Peek();
            }

            return null;
        }
    }
}
