using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitManipulation;

namespace BitManipulationTests
{
    [TestClass]
    public class FlippingBitsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new uint[] { 2147483648, 4294967294, 4294967295 }, FlippingBits.Solve(new uint[] { 2147483647, 1, 0}));
        }
    }
}
