using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class StrangeCounterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, StrangeCounter.Solve(4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, StrangeCounter.Solve(9));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(12, StrangeCounter.Solve(10));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, StrangeCounter.Solve(21));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(24, StrangeCounter.Solve(22));
        }


        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(649267441662, StrangeCounter.Solve(1000000000000));
        }
    }
}
