using System;
using Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementationTests
{
    [TestClass]
    public class AngryProfessorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, AngryProfessor.IsClassCanceled(3, new int[] { -1, -3, 4, 3 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, AngryProfessor.IsClassCanceled(2, new int[] { 0, -1, 2, 1 }));
        }
    }
}
