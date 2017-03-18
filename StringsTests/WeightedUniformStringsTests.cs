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
    public class WeightedUniformStringsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var w = new WeightedUniformStrings("abccddde");

            w.Init();

            Assert.AreEqual(true, w.In(1));
            Assert.AreEqual(true, w.In(3));
            Assert.AreEqual(true, w.In(12));
            Assert.AreEqual(true, w.In(5));
            Assert.AreEqual(false, w.In(9));
            Assert.AreEqual(false, w.In(10));
        }
    }
}
