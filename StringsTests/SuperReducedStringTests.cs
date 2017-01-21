using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringsTests
{
    [TestClass]
    public class SuperReducedStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("abd", SuperReducedString.Reduce("aaabccddd"));
        }
    }
}
