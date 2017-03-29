using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BotBuilding;
using System.Collections.Generic;

namespace BotBuildingTests
{
    [TestClass]
    public class BotSavesPrincessTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expectedOutput = new List<Tuple<String, int>>()
            {
                new Tuple<string, int>("DOWN", 1),
                new Tuple<string, int>("LEFT", 1),
            };

            CollectionAssert.AreEqual(expectedOutput, BotSavesPrincess.DisplayPathtoPrincess(new Tuple<int, int>(1, 1), new Tuple<int, int>(2, 0)));
        }
    }
}
