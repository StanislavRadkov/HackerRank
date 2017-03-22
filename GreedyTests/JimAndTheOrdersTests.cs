using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Greedy;

namespace GreedyTests
{
    [TestClass]
    public class JimAndTheOrdersTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new KeyValuePair<int, int>[]
            {
                new KeyValuePair<int, int>(1, 3),
                new KeyValuePair<int, int>(2, 3),
                new KeyValuePair<int, int>(3, 3),
            };

            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, JimAndTheOrders.Orders(input).ToArray());
        }
    }
}
