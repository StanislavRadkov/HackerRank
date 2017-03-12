using System;
using GraphTheory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GraphTheoryTests
{
    [TestClass]
    public class JourneyToTheMoonTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var n = 5;
            var k = 3;
            var input = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 2, 3 },
                new int[] { 0, 4 }
            };

            var journey = new JourneyToTheMoon(n);
            for (var i = 0; i < k; i++)
            {
                journey.Add(input[i][0], input[i][1]);
            }

            Assert.AreEqual(6, journey.GetPossibleCombinations());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var n = 4;
            var k = 1;
            var input = new int[][]
            {
                new int[] { 0, 2 }
            };

            var journey = new JourneyToTheMoon(n);
            for (var i = 0; i < k; i++)
            {
                journey.Add(input[i][0], input[i][1]);
            }

            Assert.AreEqual(5, journey.GetPossibleCombinations());
        }

        [TestMethod]
        public void TestMethod3()
        {
            var n = 10;
            var k = 7;
            var input = new int[][]
            {
                new[] { 0, 2 }, //1
                new[] { 1, 8 }, //1
                new[] { 1, 4 }, //1
                new[] { 2, 8 }, //1
                new[] { 2, 6 }, //1
                new[] { 3, 5 }, //2
                new[] { 6, 9 }  //3
            };

            var journey = new JourneyToTheMoon(n);
            for (var i = 0; i < k; i++)
            {
                journey.Add(input[i][0], input[i][1]);
            }

            Assert.AreEqual(23, journey.GetPossibleCombinations());
        }

        [TestMethod]
        public void TestMethod4()
        {
            var n = 7;
            var k = 3;
            var input = new int[][]
            {
                new[] { 0, 1 },
                new[] { 1, 2 },
                new[] { 3, 4 }
            };

            var journey = new JourneyToTheMoon(n);
            for (var i = 0; i < k; i++)
            {
                journey.Add(input[i][0], input[i][1]);
            }

            Assert.AreEqual(17, journey.GetPossibleCombinations());
        }

        [TestMethod]
        public void TestMethod5()
        {
            var n = 100000;
            var k = 2;
            var input = new int[][]
            {
                new[] { 1, 2 },
                new[] { 3, 4 }
            };

            var journey = new JourneyToTheMoon(n);
            for (var i = 0; i < k; i++)
            {
                journey.Add(input[i][0], input[i][1]);
            }

            Assert.AreEqual(4999949998L, journey.GetPossibleCombinations());
        }
    }
}
