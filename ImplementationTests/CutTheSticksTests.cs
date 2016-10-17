using System.Collections.Generic;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class CutTheSticksTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[]{6, 4, 2, 1}, CutTheSticks.Solve(new List<int>(){ 5, 4, 4, 2, 2, 8}));
        }

        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new int[] { 8, 6, 4, 1 }, CutTheSticks.Solve(new List<int>() { 1, 2, 3, 4, 3, 3, 2, 1 }));
        }
    }
}
