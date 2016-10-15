using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class DivisibleSusmPairsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, DivisibleSumPairs.Solve(3, new int[] { 1, 3, 2, 6, 1, 2 }));
        }
    }
}
