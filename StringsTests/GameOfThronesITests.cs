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
    public class GameOfThronesITests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, GameOfThronesI.Validate("aaabbbb"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, GameOfThronesI.Validate("cdefghmnopqrstuvw"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, GameOfThronesI.Validate("cdcdcdcdeeeef"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(true, GameOfThronesI.Validate("a"));
        }
    }
}
