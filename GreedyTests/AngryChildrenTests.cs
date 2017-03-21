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
    public class AngryChildrenTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(20, AngryChildren.GetMinUnfairness(new int[] { 10, 100, 300, 200, 1000, 20, 30 }, 3));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, AngryChildren.GetMinUnfairness(new int[] { 1, 2, 3, 4, 10, 20, 30, 40, 100, 200 }, 4));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(2, AngryChildren.GetMinUnfairness(new int[] { 10, 20, 30, 100, 101, 102 }, 3));
        }
    }
}
