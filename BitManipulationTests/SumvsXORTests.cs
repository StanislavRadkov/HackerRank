using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitManipulation;

namespace BitManipulationTests
{
    [TestClass]
    public class SumvsXORTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, SumvsXOR.Solve(5));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, SumvsXOR.Solve(10));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1099511627776, SumvsXOR.Solve(1099511627776));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(1, SumvsXOR.Solve(0));
        }
    }
}
