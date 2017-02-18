using System;
using System.Collections.Generic;
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
        public void TestMyQueue1()
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

            Assert.AreEqual(2, queue.Dequeue());
            Assert.AreEqual(3, queue.Dequeue());
            Assert.AreEqual(4, queue.Dequeue());
            Assert.AreEqual(5, queue.Dequeue());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMyQueue2()
        {
            var queue = new MyQueue<int>();
            queue.Peek();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMyQueue3()
        {
            var queue = new MyQueue<int>();
            queue.Dequeue();
        }

        [TestMethod]
        public void SortStackWithOneAdditionalStack1()
        {
            var stack = new Stack<int> (new int[] {1, 10, 2, 9, 3, 8, 4, 7, 5, 6});

            StacksAndQueues.SortStackWithOneAdditionalStack(stack);

            CollectionAssert.AreEqual(new int[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1}, stack.ToArray());
        }

        [TestMethod]
        public void SortStackWithOneAdditionalStack2()
        {
            var stack = new Stack<int>(new int[0]);

            StacksAndQueues.SortStackWithOneAdditionalStack(stack);

            CollectionAssert.AreEqual(new int[0] , stack.ToArray());
        }
    }
}
