using System;
using CrackingTheCodingInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterviewTests
{
    [TestClass]
    public class BitManipulationTests
    {
        [TestMethod]
        public void CountBitsTests1()
        {
            Assert.AreEqual(4, BitManipulation.CountBits(15));
        }

        [TestMethod]
        public void CountBitsTests2()
        {
            Assert.AreEqual(0, BitManipulation.CountBits(0));
        }

        [TestMethod]
        public void CountBitsTests3()
        {
            Assert.AreEqual(32, BitManipulation.CountBits(uint.MaxValue));
        }

        [TestMethod]
        public void UpdateBitsTests1()
        {
            Assert.AreEqual(1100, BitManipulation.UpdateBits(1024, 19, 2, 6));
        }

        [TestMethod]
        public void UpdateBitsTests2()
        {
            Assert.AreEqual(255, BitManipulation.UpdateBits(240, 15, 0, 3));
        }

        [TestMethod]
        public void GetNextNumbersWithSameNumberBruteForceTest1()
        {
            var result = BitManipulation.GetNextNumbersWithSameNumberBruteForce(61);

            Assert.AreEqual(result.Item1, 59u);
            Assert.AreEqual(result.Item2, 62u);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GetNextNumbersWithSameNumberBruteForceTest2()
        {
            BitManipulation.GetNextNumbersWithSameNumberBruteForce(15);
        }

        [TestMethod]
        public void GetNextNumbersWithSameNumberTest1()
        {
            var result = BitManipulation.GetNextNumbersWithSameNumber(61);

            Assert.AreEqual(result.Item1, 59u);
            Assert.AreEqual(result.Item2, 62u);
        }

        [TestMethod]
        public void CountBitsToConvertTests1()
        {
            Assert.AreEqual(7, BitManipulation.CountBitsToConvert(1, 255));
        }

        [TestMethod]
        public void CountBitsToConvertTests2()
        {
            Assert.AreEqual(0, BitManipulation.CountBitsToConvert(0, 0));
        }
    }
}
