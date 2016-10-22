using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class RepeatedStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(7, RepeatedString.Solve("aba", 10));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(16481469408, RepeatedString.Solve("epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq", 549382313570));
        }
    }
}
