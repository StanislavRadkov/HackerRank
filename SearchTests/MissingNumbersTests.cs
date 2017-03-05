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
    public class MissingNumbersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new int[] { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            var b = new int[] { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };

            CollectionAssert.AreEqual(new int[] { 204, 205, 206 }, MissingNumbers.Get(a, b).ToList());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = new int[] { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            var b = new int[] { 203, 204, 204, 205, 206, 204, 207, 205, 208, 203, 206, 205, 204, 206, 204 };

            CollectionAssert.AreEqual(new int[] { 204, 205, 206 }, MissingNumbers.Get(a, b).ToList());
        }
    }
}
