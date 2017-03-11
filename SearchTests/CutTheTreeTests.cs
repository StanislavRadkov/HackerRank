using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchTests
{
    [TestClass]
    public class CutTheTreeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var values = new[] { 100, 200, 100, 500, 100, 600 };
            var edges = new[]
            {
                new[] { 1, 2 },
                new[] { 2, 3 },
                new[] { 2, 5 },
                new[] { 4, 5 },
                new[] { 5, 6 }
            };

            //Get vertex values and tree sum
            Vertex[] verts = new Vertex[values.Length];
            var n = 0;
            int sum = 0;
            foreach (var value in values)
            {
                sum += value;
                verts[n++] = new Vertex(value);
            }

            foreach (var edge in edges)
            {
                verts[edge[0] - 1].AddEdge(verts[edge[1] - 1], sum);
                verts[edge[1] - 1].AddEdge(verts[edge[0] - 1], sum);
            }

            //Initialize
            verts[0].Init();

            //Find smallest diff
            int min = int.MaxValue;
            foreach(var vertex in verts)
            {
                int curMin = vertex.GetMinDiff(sum);
                //Update min
                min = Math.Min(curMin, min);
            }

            Assert.AreEqual(400, min);
        }
    }
}
