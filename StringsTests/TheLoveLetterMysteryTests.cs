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
    public class TheLoveLetterMysteryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, TheLoveLetterMystery.Count("abc"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, TheLoveLetterMystery.Count("abcba"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, TheLoveLetterMystery.Count("abcd"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(2, TheLoveLetterMystery.Count("cba"));
        }
    }
}
