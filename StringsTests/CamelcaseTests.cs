using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringsTests
{
    [TestClass]
    public class CamelcaseTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, Camelcase.CountWords("saveChangesInTheEditor"));
        }
    }
}
