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
    public class AlternatingCharactersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, AlternatingCharacters.Count("AAAA"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, AlternatingCharacters.Count("BBBBB"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, AlternatingCharacters.Count("ABABABAB"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, AlternatingCharacters.Count("BABABA"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(4, AlternatingCharacters.Count("AAABBB"));
        }
    }
}
