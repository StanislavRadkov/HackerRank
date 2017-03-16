using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringsTests
{
    [TestClass]
    public class GemstonesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new string[] 
            {
                "abcdde",
                "baccd",
                "eeabg"
            };

            Assert.AreEqual(2, Gemstones.Count(input));
        }
    }
}
