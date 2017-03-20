using System;
using Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinimumAbsoluteDifferenceInAnArrayTests
{
    [TestClass]
    public class MinimumAbsoluteDifferenceInAnArrayTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, MinimumAbsoluteDifferenceInAnArray.Get(new int[] { 3, -7, 0 }));
        }
    }
}
