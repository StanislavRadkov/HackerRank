using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitManipulation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitManipulationTests
{
    [TestClass]
    public class MaximizingXORTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(7, MaximizingXOR.Solve(10, 15));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, MaximizingXOR.Solve(5, 6));
        }
    }
}
