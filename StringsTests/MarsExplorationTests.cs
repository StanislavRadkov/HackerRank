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
    public class MarsExplorationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, MarsExploration.CountAlteredLetters("SOSSPSSQSSOR"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, MarsExploration.CountAlteredLetters("SOSSOT"));
        }
    }
}
