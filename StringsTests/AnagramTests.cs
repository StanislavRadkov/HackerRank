using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strings;

namespace StringsTests
{
    [TestClass]
    public class AnagramTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Anagram.Changes("aaabbb"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, Anagram.Changes("ab"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(-1, Anagram.Changes("abc"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(2, Anagram.Changes("mnop"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(0, Anagram.Changes("xyyx"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(1, Anagram.Changes("xaxbbbxx"));
        }
    }
}
