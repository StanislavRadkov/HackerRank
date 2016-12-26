using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicProgramming;
using System.Linq;

namespace DynamicProgrammingTests
{
    [TestClass]
    public class LongestIncreasingSubsequenceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new [] {-1, 0, 2, 3}, LongestIncreasingSubsequence.GetLongestIncreasingSubsequence(new int[] { 3, 4, -1, 0, 6, 2, 3 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, LongestIncreasingSubsequence.GetLongestIncreasingSubsequenceLength(new int[] { 3, 4, -1, 0, 6, 2, 3 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, LongestIncreasingSubsequence.GetLongestIncreasingSubsequenceNLogN(new int[] { 3, 4, -1, 0, 6, 2, 3 }));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(6, LongestIncreasingSubsequence.GetLongestIncreasingSubsequenceNLogN(new int[] { 3, 4, -1, 5, 8, 2, 3, 12, 7, 9, 10 }));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(1, LongestIncreasingSubsequence.GetLongestIncreasingSubsequenceNLogN(Enumerable.Repeat(1, 1000000).ToArray()));
        }
    }
}
