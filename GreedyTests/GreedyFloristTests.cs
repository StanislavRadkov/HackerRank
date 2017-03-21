using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greedy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreedyTests
{
    [TestClass]
    public class GreedyFloristTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(13, GreedyFlorist.GetPrice(new int[] { 2, 5, 6 }, 3, 3));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(15, GreedyFlorist.GetPrice(new int[] { 2, 5, 6 }, 3, 2));
        }
    }
}
