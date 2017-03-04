using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search;

namespace SearchTests
{
    [TestClass]
    public class GridlandMetroTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new List<Tuple<UInt64, UInt64, UInt64>>
            {
                new Tuple<ulong, ulong, ulong>(2, 2, 3),
                new Tuple<ulong, ulong, ulong>(3, 1, 4),
                new Tuple<ulong, ulong, ulong>(4, 4, 4)
            };
            
            Assert.AreEqual(9ul, GridlandMetro.Count(input, 4, 4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new List<Tuple<UInt64, UInt64, UInt64>>
            {
                new Tuple<ulong, ulong, ulong>(2, 2, 4),
                new Tuple<ulong, ulong, ulong>(2, 1, 3),
                new Tuple<ulong, ulong, ulong>(2, 3, 4),
                new Tuple<ulong, ulong, ulong>(3, 1, 4),
                new Tuple<ulong, ulong, ulong>(4, 4, 4)
            };

            Assert.AreEqual(7ul, GridlandMetro.Count(input, 4, 4));
        }
    }
}
