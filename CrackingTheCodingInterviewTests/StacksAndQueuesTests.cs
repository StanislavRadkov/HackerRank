using System;
using CrackingTheCodingInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterviewTests
{
    [TestClass]
    public class StacksAndQueuesTests
    {
        [TestMethod]
        public void TesMinStack()
        {
            var stack = new MinStack();
            stack.Push(new int[] {10, 9, 11, 8, 12, 7});
            Assert.AreEqual(stack.Min, 7);
            stack.Pop();
            Assert.AreEqual(stack.Min, 8);
            stack.Pop();
            stack.Pop();
            Assert.AreEqual(stack.Min, 9);
        }

        [TestMethod]
        public void TestMyQueue()
        {
            var queue = new MyQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(1, queue.Peek());

            queue.Enqueue(4);
            Assert.AreEqual(1, queue.Peek());

            queue.Enqueue(5);
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Peek());
        }
    }
}
