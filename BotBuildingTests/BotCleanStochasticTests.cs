using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BotBuilding;

namespace BotBuildingTests
{
    [TestClass]
    public class BotCleanStochasticTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new String[]
            {
                "b---d",
                "-d--d",
                "--dd-",
                "--d--",
                "----d"
            };

            Assert.AreEqual("DOWN", BotCleanStochastic.NextMove(0, 0, input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new String[]
            {
                "-b--d",
                "-d--d",
                "--dd-",
                "--d--",
                "----d"
            };

            Assert.AreEqual("DOWN", BotCleanStochastic.NextMove(0, 1, input));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = new String[]
            {
                "-d---",
                "bd---",
                "---d-",
                "---d-",
                "--d-d"
            };

            Assert.AreEqual("RIGHT", BotCleanStochastic.NextMove(1, 0, input));
        }

        [TestMethod]
        public void TestMethod4()
        {
            var input = new String[]
            {
                "-d---",
                "-d---",
                "---d-",
                "---d-",
                "--d-d"
            };

            Assert.AreEqual("CLEAN", BotCleanStochastic.NextMove(0, 1, input));
        }

        [TestMethod]
        public void TestMethod5()
        {
            var input = new String[]
            {
                "-----",
                "-----",
                "-----",
                "-----",
                "--db-"
            };

            Assert.AreEqual("LEFT", BotCleanStochastic.NextMove(4, 3, input));
        }

        [TestMethod]
        public void TestMethod6()
        {
            var input = new String[]
            {
                "----d",
                "-----",
                "-----",
                "b----",
                "-----"
            };

            Assert.AreEqual("UP", BotCleanStochastic.NextMove(3, 0, input));
        }

        [TestMethod]
        public void TestMethod7()
        {
            var input = new String[]
            {
                "-----",
                "-----",
                "-----",
                "---d-",
                "b----"
            };

            Assert.AreEqual("UP", BotCleanStochastic.NextMove(4, 0, input));
        }
    }
}
