using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;

namespace StacksTests
{
    [TestClass]
    public class ANDxorORTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new List<int>() {9, 6, 3, 5, 2};

            Assert.AreEqual(15, ANDxorOR.Solve(input));
        }
    }
}
