using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;

namespace SortingTests
{
    [TestClass]
    public class CountingSort4Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new KeyValuePair<int, string>[]
            {
                new KeyValuePair<int, string>(0, "-"),
                new KeyValuePair<int, string>(6, "-"),
                new KeyValuePair<int, string>(0, "-"),
                new KeyValuePair<int, string>(6, "-"),
                new KeyValuePair<int, string>(4, "-"),
                new KeyValuePair<int, string>(0, "-"),
                new KeyValuePair<int, string>(6, "-"),
                new KeyValuePair<int, string>(0, "-"),
                new KeyValuePair<int, string>(6, "-"),
                new KeyValuePair<int, string>(0, "-"),
                new KeyValuePair<int, string>(4, "that"),
                new KeyValuePair<int, string>(3, "be"),
                new KeyValuePair<int, string>(0, "to"),
                new KeyValuePair<int, string>(1, "be"),
                new KeyValuePair<int, string>(5, "question"),
                new KeyValuePair<int, string>(1, "or"),
                new KeyValuePair<int, string>(2, "not"),
                new KeyValuePair<int, string>(4, "is"),
                new KeyValuePair<int, string>(2, "to"),
                new KeyValuePair<int, string>(4, "the"),
            };

            var expectedOutput = "- - - - - to be or not to be - that is the question - - - -";

            var output = CountingSort4.Sort(input);

            Assert.AreEqual(expectedOutput, String.Join(" ", output));
        }
    }
}
