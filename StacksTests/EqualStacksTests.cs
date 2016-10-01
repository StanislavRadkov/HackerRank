using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;

namespace StacksTests
{
    [TestClass]
    public class EqualStacksTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var stacks = new[]
                {
                    new int[]{ 3, 2, 1, 1, 1, },
                    new int[]{ 4, 3, 2 },
                    new int[]{ 1, 1, 4, 1 },
                };

            Assert.AreEqual(5, EqualStacks.Solve(stacks));
        }
    }
}
