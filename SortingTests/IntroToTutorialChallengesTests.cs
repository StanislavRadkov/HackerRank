using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    [TestClass]
    public class IntroToTutorialChallengesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, IntroToTutorialChallenges.Solve(new int[] { 1, 4, 5, 7, 9, 12 }, 4));
        }
    }
}
