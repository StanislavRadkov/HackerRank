using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class MiniMaxSumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new long[] { 10, 14 }, MiniMaxSum.Solve(new long[] { 1, 2, 3, 4, 5 }));
        }
    }
}