using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynamicProgrammingTests
{
    [TestClass]
    public class TheCoinChangeProblemTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, TheCoinChangeProblem.Count(new int[] { 1, 2, 3}, 4));
        }
    }
}
