using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    public class CountingSort3Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new[] { 4, 3, 0, 1, 5, 1, 2, 4, 2, 4 };

            var expectedOutput = new int[]
            {
                1,3,5,6,9,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10
            };

            var output = CountingSort3.GetSums(input);

            CollectionAssert.AreEqual(expectedOutput, output);
        }
    }
}
