using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitManipulation;

namespace BitManipulationTests
{
    [TestClass]
    public class CounterGameTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Richard", CounterGame.Solve(6));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Richard", CounterGame.Solve(6703734870638684097));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Richard", CounterGame.Solve(7597026128958891522));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("Louise", CounterGame.Solve(13174607262084689114));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("Louise", CounterGame.Solve(6959712971461184279));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("Louise", CounterGame.Solve(12572864054437627553));
        }
    }
}
