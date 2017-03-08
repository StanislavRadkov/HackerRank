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
    public class ConnectedCellsInAGridTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[][]
            {
                new int[] { 1, 1, 0, 0 },
                new int[] { 0, 1, 1, 0 },
                new int[] { 0, 0, 1, 0 },
                new int[] { 1, 0, 0, 0 }
            };

            Assert.AreEqual(5, ConnectedCellsInAGrid.MaxCount(input));
        }
    }
}
