using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks;

namespace StacksTests
{
    [TestClass]
    public class MaximumElementTests
    {
        private MaximumElement element;

        [TestInitialize]
        public void Initialize()
        {
            element = new MaximumElement();
        }

        [TestMethod]
        public void Test1()
        {
            var queries = new[]
                {
                    new int[] {1, 97},
                    new int[] {2},
                    new int[] {1, 20},
                    new int[] {2},
                    new int[] {1, 26},
                    new int[] {1, 20},
                    new int[] {2},
                    new int[] {3},
                    new int[] {1, 91},
                    new int[] {3}
                };

            var expectedOutput = new Stack<int>(new int[]{91, 26});

            foreach (var query in queries)
            {
                var result = element.Parse(query);
                if (result.HasValue)
                {
                    Assert.AreEqual(expectedOutput.Pop(), result);
                }
            }
        }
    }
}
