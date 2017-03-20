using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Greedy;

namespace GreedyTests
{
    [TestClass]
    public class GridChallengeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var grid = new GridChallenge();
            Assert.AreEqual(true, grid.Line("ebacd"));
            Assert.AreEqual(true, grid.Line("fghij"));
            Assert.AreEqual(true, grid.Line("olmkn"));
            Assert.AreEqual(true, grid.Line("trpqs"));
            Assert.AreEqual(true, grid.Line("xywuv"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var grid = new GridChallenge();
            Assert.AreEqual(true, grid.Line("ppp"));
            Assert.AreEqual(true, grid.Line("ypp"));
            Assert.AreEqual(true, grid.Line("wyw"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var grid = new GridChallenge();
            Assert.AreEqual(true, grid.Line("lyivr"));
            Assert.AreEqual(false, grid.Line("jgfew"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var grid = new GridChallenge();
            Assert.AreEqual(true, grid.Line("1"));
        }
    }
}
