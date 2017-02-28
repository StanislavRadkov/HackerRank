using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    namespace SortingTests
    {
        [TestClass]
        public class QuickSort2Tests
        {
            [TestMethod]
            public void TestMethod1()
            {
                var data = new List<int> { 5, 8, 1, 3, 7, 9, 2 };
                var results = new List<List<int>>();
                QuickSort2.Sort(data, results);

                var expected = new List<List<int>>
                {
                    new List<int> { 2, 3 },
                    new List<int> { 1, 2, 3 },
                    new List<int> { 7, 8, 9 },
                    new List<int> { 1, 2, 3, 5, 7, 8, 9 },
                };

                for (var i = 0; i < results.Count; i++)
                {
                    CollectionAssert.AreEqual(expected[i], results[i]);
                }
            }
        }
    }
}
