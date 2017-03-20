using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class BreakingTheRecordsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = BreakingTheRecords.Count(new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 });
            Assert.AreEqual(2, result.Item1);
            Assert.AreEqual(4, result.Item2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = BreakingTheRecords.Count(new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 });
            Assert.AreEqual(4, result.Item1);
            Assert.AreEqual(0, result.Item2);
        }
    }
}
