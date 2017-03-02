using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    [TestClass]
    public class RunningTimeOfQuicksortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var quickSortOperationsCount = 0;
            var insertionSortOperationsCount = 0;

            var a = new int[] { 1, 3, 9, 8, 2, 7, 5 };
            var b = (int[])a.Clone();

            QuicksortInPlace.Sort(a, ref quickSortOperationsCount);
            InsertionSortPart2.Sort(b, ref insertionSortOperationsCount);

            Assert.AreEqual(8, quickSortOperationsCount);
            Assert.AreEqual(9, insertionSortOperationsCount);
        }
    }
}
