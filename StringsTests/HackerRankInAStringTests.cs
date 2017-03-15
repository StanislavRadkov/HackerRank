using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringsTests
{
    [TestClass]
    public class HackerRankInAStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, HackerRankInAString.Is("haacckkerrannkk"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, HackerRankInAString.Is("haacckkerannk"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, HackerRankInAString.Is("hereiamstackerrank"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, HackerRankInAString.Is("hackerworld"));
        }
    }
}
