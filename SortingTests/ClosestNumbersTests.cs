using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    [TestClass]
    public class ClosestNumbersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854 };
            var expectedOutput = new Tuple<int, int>[]
            {
                new Tuple<int, int>(-20, 30)
            };

            var output = ClosestNumbers.GetPairs(input);

            CollectionAssert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470 };
            var expectedOutput = new Tuple<int, int>[]
            {
                new Tuple<int, int>(-520, -470),
                new Tuple<int, int>(-20, 30)
            };

            var output = ClosestNumbers.GetPairs(input);
            
            CollectionAssert.AreEqual(expectedOutput, output);
        }
    }
}
