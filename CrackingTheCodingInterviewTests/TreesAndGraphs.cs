using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingTheCodingInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterviewTests
{
    [TestClass]
    public class TreesAndGraphs
    {
        [TestMethod]
        public void TestFindPath1()
        {
            var graph = new Graph();
            graph.AddVertex(1, new List<int> { 2, 3 });
            graph.AddVertex(2, new List<int> { 4 });
            graph.AddVertex(3, new List<int> { 5 });
            graph.AddVertex(4, new List<int> { 1 });
            graph.AddVertex(5, new List<int> { 2, 8 });
            graph.AddVertex(6, new List<int> { 7 });
            graph.AddVertex(7, new List<int> { });
            graph.AddVertex(8, new List<int> { 9 });
            graph.AddVertex(9, new List<int> { 3 });
            graph.AddVertex(10, new List<int> { 5 });

            Assert.AreEqual(true, graph.Path(1, 9));

        }
    } 
}
