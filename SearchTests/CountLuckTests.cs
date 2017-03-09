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
    public class CountLuckTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var wood = new char[][]
            {
                "*.M".ToCharArray(),
                ".X.".ToCharArray()
            };

            Assert.AreEqual(true, CountLuck.Count(wood, 1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var wood = new char[][]
            {
                ".X.X......X".ToCharArray(),
                ".X*.X.XXX.X".ToCharArray(),
                ".XX.X.XM...".ToCharArray(),
                "......XXXX.".ToCharArray()
            };

            Assert.AreEqual(true, CountLuck.Count(wood, 3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            var wood = new char[][]
            {
                ".X.X......X".ToCharArray(),
                ".X*.X.XXX.X".ToCharArray(),
                ".XX.X.XM...".ToCharArray(),
                "......XXXX.".ToCharArray()
            };

            Assert.AreEqual(false, CountLuck.Count(wood, 4));
        }
    }
}
