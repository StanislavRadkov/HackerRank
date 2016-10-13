using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;

namespace StacksTests
{
    [TestClass]
    public class WaiterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[]{4, 6, 3, 7, 5}, Waiter.Solve(1, new Stack<int>(new int[]{3, 4, 7, 6, 5})));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var expected = new int[] { 2, 4, 6, 8, 10, 9, 3, 5, 1, 7 };

            CollectionAssert.AreEqual(expected, Waiter.Solve(3, new Stack<int>(input)));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = new int[] {80, 37, 86, 79, 8, 39, 43, 41, 15, 33, 30, 15, 45, 55, 61, 74, 49, 49, 20, 66, 77, 19, 85, 44, 81, 82, 27, 5, 36, 83, 91, 45, 39, 44, 19, 44, 71, 49, 8, 66, 81, 40, 29, 60, 35, 31, 44 };
            var expected = new int[] {80, 86, 8, 30, 74, 20, 66, 44, 82, 36, 44, 44, 8, 66, 40, 60, 44, 81, 39, 45, 27, 81, 45, 15, 33, 15, 39, 55, 85, 5, 35, 49, 91, 77, 49, 49, 19, 19, 29, 31, 37, 41, 43, 61, 71, 79, 83 };

            CollectionAssert.AreEqual(expected, Waiter.Solve(21, new Stack<int>(input)));
        }
    }
}
