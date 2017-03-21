using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreedyTests
{
    [TestClass]
    public class TwoArraysTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, TwoArrays.PermutationExists(new int[] {2, 1, 3 }, new int[] { 7, 8, 9}, 10));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, TwoArrays.PermutationExists(new int[] { 1, 2, 2, 1 }, new int[] { 3, 3, 3, 4 }, 5));
        }
    }
}
