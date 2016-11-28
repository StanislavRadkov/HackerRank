using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    [TestClass]
    public class RunningTimeOfAlgorithmsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Int32 i = 0;
            Action<int> increment = (a) => i++;
            var output = InsertionSortPart2.Sort(new int[] { 2, 1, 3, 1, 2 }, increment).ToArray();

            Assert.AreEqual(4, i);
        }
    }
}
