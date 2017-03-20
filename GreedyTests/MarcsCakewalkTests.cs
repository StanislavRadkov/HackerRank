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
    public class MarcsCakewalkTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(11, MarcsCakewalk.Miles(new[] { 1, 3, 2 }));
        }
    }
}
