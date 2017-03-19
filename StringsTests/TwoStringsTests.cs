using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTests
{
    [TestClass]
    public class TwoStringsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, TwoStrings.HaveSubstrings("hello", "world"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, TwoStrings.HaveSubstrings("hi", "world"));
        }
    }
}
