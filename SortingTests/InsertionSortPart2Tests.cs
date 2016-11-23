using System;
using System.Text;
using System.Collections.Generic;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SortingTests
{    
    [TestClass]
    public class InsertionSortPart2Tests
    {       
        [TestMethod]
        public void TestMethod1()
        {
            var expected = new[] 
            {
                new int[] {1, 4, 3, 5, 6, 2 },
                new int[] {1, 3, 4, 5, 6, 2 },
                new int[] {1, 3, 4, 5, 6, 2 },
                new int[] {1, 3, 4, 5, 6, 2 },
                new int[] {1, 2, 3, 4, 5, 6 }
            };

            var output = InsertionSortPart2.Sort(new int[] { 1, 4, 3, 5, 6, 2 }).ToArray();

            for (var i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], output[i]);
            }
        }
    }
}
