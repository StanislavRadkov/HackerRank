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
    public class PangramsTests
    {
        [TestMethod]
        public void TestMethod1() 
        {
            Assert.AreEqual(true, Pangrams.Is("The quick brown fox jumps over the lazy dog"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, Pangrams.Is("We promptly judged antique ivory buckles for the next prize"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(false, Pangrams.Is("We promptly judged antique ivory buckles for the prize"));
        }
    }
}
