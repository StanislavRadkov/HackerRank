using System.Collections.Generic;
using System.Linq;

namespace Queues
{
    // https://www.hackerrank.com/challenges/queue-using-two-stacks
    public class QueueUsingTwoStacks<T>
    {
        private Stack<T> stack1;
        private Stack<T> stack2;

        public QueueUsingTwoStacks()
            : this(1024)
        {
            
        }

        public QueueUsingTwoStacks(int size)
        {
            stack1 = new Stack<T>(size);
            stack2 = new Stack<T>(size);
        }

        public void Enqueue(T item)
        {
            stack2.Push(item);
        }

        public T Dequeue()
        {
            if (!stack1.Any())
            {
                while (stack2.Any())
                {
                    stack1.Push(stack2.Pop());
                }
            }

            return stack1.Pop();
        }

        public T Peek()
        {
            if (!stack1.Any())
            {
                while (stack2.Any())
                {
                    stack1.Push(stack2.Pop());
                }
            }

            return stack1.Peek();
        }
    }
}
