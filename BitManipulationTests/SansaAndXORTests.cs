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
    public class SansaAndXORTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, SansaAndXOR.XOR(new int[] { 1, 2, 3 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, SansaAndXOR.XOR(new int[] { 4, 5, 7, 5 }));
        }
    }
}
