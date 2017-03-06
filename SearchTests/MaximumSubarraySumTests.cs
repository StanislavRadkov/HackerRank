using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTests
{
    [TestClass]
    public class MaximumSubarraySumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6ul, MaximumSubarraySum.Get(new ulong[] { 3, 3, 9, 9, 5 }, 7));
        }
    }
}
