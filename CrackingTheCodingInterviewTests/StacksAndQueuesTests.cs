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
    }
}
