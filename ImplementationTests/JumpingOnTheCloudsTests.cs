using System;
using Implementation;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class JumpingOnTheCloudsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, JumpingOnTheClouds.Solve(Array.ConvertAll(new int[] { 0, 0, 1, 0, 0, 1, 0 }, Convert.ToBoolean).ToArray()));
        }
    }
}
