using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingTheCodingInterview;

namespace CrackingTheCodingInterviewTests
{
    [TestClass]
    public class ArraysLeftRotationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("5 1 2 3 4", ArraysLeftRotation.RotateLeft(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4 }).ToString());
        }
    }
}
