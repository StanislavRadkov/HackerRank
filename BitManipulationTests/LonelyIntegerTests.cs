using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitManipulation;

namespace BitManipulationTests
{
    [TestClass]
    public class LonelyIntegerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, LonelyInteger.Solve(new int[] { 1 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, LonelyInteger.Solve(new int[] { 1, 1, 2 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(2, LonelyInteger.Solve(new int[] { 0, 0, 1, 2, 1 }));
        }
    }
}
