using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;
using System.Collections.Generic;

namespace StacksTests
{
    [TestClass]
    public class PoisonousPlantsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new LinkedList<int>(new int[] { 6, 5, 8, 4, 7, 10, 9 });
            Assert.AreEqual(2, PoisonousPlants.Solve(data));
        }
    }
}
