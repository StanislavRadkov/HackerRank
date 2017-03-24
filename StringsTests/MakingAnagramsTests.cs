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
    public class MakingAnagramsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, MakingAnagrams.Count("cde", "abc"));
        }
    }
}
