using System;
using System.Text;
using System.Collections.Generic;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace SortingTests
{
    [TestClass]
    public class InsertionSortPart1Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = new[]
            {
                new int[] {2, 4, 6, 8, 8 },
                new int[] {2, 4, 6, 6, 8 },
                new int[] {2, 4, 4, 6, 8 },
                new int[] {2, 3, 4, 6, 8 }
            };

            var output = InsertionSortPart1.Sort(new int[] { 2, 4, 6, 8, 3 }).ToArray();

            for (var i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], output[i]);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            var expected = new[]
            {
                new int[] {1, 3, 5, 9, 13, 22, 27, 35, 46, 51, 55, 83, 87, 87},
                new int[] {1, 3, 5, 9, 13, 22, 27, 35, 46, 51, 55, 83, 83, 87},
                new int[] {1, 3, 5, 9, 13, 22, 27, 35, 46, 51, 55, 55, 83, 87},
                new int[] {1, 3, 5, 9, 13, 22, 27, 35, 46, 51, 51, 55, 83, 87},
                new int[] {1, 3, 5, 9, 13, 22, 27, 35, 46, 46, 51, 55, 83, 87},
                new int[] {1, 3, 5, 9, 13, 22, 27, 35, 35, 46, 51, 55, 83, 87},
                new int[] {1, 3, 5, 9, 13, 22, 27, 27, 35, 46, 51, 55, 83, 87},
                new int[] {1, 3, 5, 9, 13, 22, 23, 27, 35, 46, 51, 55, 83, 87}
            };

            var output = InsertionSortPart1.Sort(new int[] { 1, 3, 5, 9, 13, 22, 27, 35, 46, 51, 55, 83, 87, 23 }).ToArray();

            for (var i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], output[i]);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            var expected = new[]
            {
                new int[] {2, 3, 4, 5, 6, 7, 8, 9, 10, 10},
                new int[] {2, 3, 4, 5, 6, 7, 8, 9, 9, 10},
                new int[] {2, 3, 4, 5, 6, 7, 8, 8, 9, 10},
                new int[] {2, 3, 4, 5, 6, 7, 7, 8, 9, 10},
                new int[] {2, 3, 4, 5, 6, 6, 7, 8, 9, 10},
                new int[] {2, 3, 4, 5, 5, 6, 7, 8, 9, 10},
                new int[] {2, 3, 4, 4, 5, 6, 7, 8, 9, 10},
                new int[] {2, 3, 3, 4, 5, 6, 7, 8, 9, 10},
                new int[] {2, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            };

            var output = InsertionSortPart1.Sort(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 }).ToArray();

            for (var i = 0; i < expected.Length; i++)
            {
                CollectionAssert.AreEqual(expected[i], output[i]);
            }
        }
    }
}
