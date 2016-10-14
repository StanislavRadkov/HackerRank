using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class KangarooTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Kangaroo.Solve(0, 3, 4, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, Kangaroo.Solve(0, 2, 5, 3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(false, Kangaroo.Solve(43, 2, 70, 2));
        }
    }
}
