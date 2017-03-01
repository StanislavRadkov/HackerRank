using System;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class QuicksortInPlaceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var array = new int[] { 1, 3, 9, 8, 2, 7, 5 };
            QuicksortInPlace.Sort(array);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 7, 8, 9 }, array);
        }
    }
}
