using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class SockMerchantTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, SockMerchant.Solve(new int[]{ 10, 20, 20, 10, 10, 30, 50, 10, 20 }));
        }
    }
}
