using System;
using CrackingTheCodingInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterviewTests
{
    [TestClass]
    public class BitManipulationTests
    {
        [TestMethod]
        public void UpdateBitsTests1()
        {
            Assert.AreEqual(1100, BitManipulation.UpdateBits(1024, 19, 2, 6));
        }
    }
}
