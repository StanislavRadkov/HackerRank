using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    /* Implement a MyQueue class which implements a queue using two stacks. */
    public class MyQueue<T>
    {
        private Stack<T> _enqueueStack;
        private Stack<T> _dequeueStack;

        public MyQueue()
        {
            _enqueueStack = new Stack<T>();
            _dequeueStack = new Stack<T>();
        }

        public void Enqueue(T value)
        {
            _enqueueStack.Push(value);
        }

        public T Dequeue()
        {
            if (_dequeueStack.Count == 0 && _enqueueStack.Count == 0)
            {
                throw new InvalidOperationException();
            }

            if (_dequeueStack.Count == 0)
            {
                while (_enqueueStack.Count > 0)
                {
                    _dequeueStack.Push(_enqueueStack.Pop());
                }
            }

            return _dequeueStack.Pop();
        }

        public T Peek()
        {
            if (_dequeueStack.Count == 0 && _enqueueStack.Count == 0)
            {
                throw new InvalidOperationException();
            }

            if (_dequeueStack.Count == 0)
            {
                while (_enqueueStack.Count > 0)
                {
                    _dequeueStack.Push(_enqueueStack.Pop());
                }
            }

            return _dequeueStack.Peek();
        }
    }
}
