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
    public class PairsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new int[] { 1, 5, 3, 4, 2 };

            Assert.AreEqual(3, Pairs.CountPairs(input, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = new int[] { 363374326, 364147530, 61825163, 1073065718, 1281246024, 1399469912, 428047635, 491595254, 879792181, 1069262793 };

            Assert.AreEqual(0, Pairs.CountPairs(input, 1));
        }
    }
}
