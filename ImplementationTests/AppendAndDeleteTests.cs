using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class AppendAndDeleteTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, AppendAndDelete.CanBeConverted("hackerhappy", "hackerrank", 9));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, AppendAndDelete.CanBeConverted("abc", "abc", 7));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, AppendAndDelete.CanBeConverted("aaaaaaaaaa", "aaaaa", 7));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, AppendAndDelete.CanBeConverted("y", "yu", 2));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, AppendAndDelete.CanBeConverted("aaa", "a", 5));
        }
    }
}
