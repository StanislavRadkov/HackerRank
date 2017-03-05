using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search;

namespace SearchTests
{
    [TestClass]
    public class SherlockАndArrayTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { 1, 2, 3 };
            Assert.AreEqual(false, SherlockАndArray.SumsExist(input));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] { 1, 2, 3, 3 };
            Assert.AreEqual(true, SherlockАndArray.SumsExist(input));
        }
    }
}
