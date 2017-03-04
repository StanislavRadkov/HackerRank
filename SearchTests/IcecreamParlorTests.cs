using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchTests
{
    [TestClass]
    public class IcecreamParlorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = IcecreamParlor.Get(new int[] {1, 4, 5, 3, 2}, 4);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(4, result.Item2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = IcecreamParlor.Get(new int[] { 2, 2, 4, 3 }, 4);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = IcecreamParlor.Get(new int[] { 5, 75, 25 }, 100);
            Assert.AreEqual(2, result.Item1);
            Assert.AreEqual(3, result.Item2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var result = IcecreamParlor.Get(new int[] { 150, 24, 79, 50, 88, 345, 3 }, 200);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(4, result.Item2);
        }
    }
}
