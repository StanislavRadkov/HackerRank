using System;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class Quicksort1PartitionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 3, 2, 4, 5, 7 }, Quicksort1Partition.Partion(new int[] { 4, 5, 3, 7, 2 }));
        }
    }
}
