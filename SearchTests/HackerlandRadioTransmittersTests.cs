using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search;

namespace SearchTests
{
    [TestClass]
    public class HackerlandRadioTransmittersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(2, HackerlandRadioTransmitters.Count(input, 1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] { 7, 2, 4, 6, 5, 9, 12, 11 };
            Assert.AreEqual(3, HackerlandRadioTransmitters.Count(input, 2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = new int[] { 9, 5, 4, 2, 6, 15, 12 };
            Assert.AreEqual(4, HackerlandRadioTransmitters.Count(input, 2));
        }
    }
}
