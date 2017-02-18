using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class Graph
    {
        private Dictionary<int, List<int>> _vertices = new Dictionary<int, List<int>>();

        public void AddVertex(int name, List<int> connectedNodes)
        {
            _vertices[name] = connectedNodes;
        }

        public bool Path(int start, int end)
        {
            var visited = new HashSet<int>();
            var nodesToVisit = new Queue<int>(_vertices[start]);


            while (nodesToVisit.Any())
            {
                var node = nodesToVisit.Dequeue();

                if (node == end)
                {
                    return true;
                }
                else if (visited.Contains(node))
                {
                    continue;
                }
                else
                {
                    visited.Add(node);
                }

                foreach (var nodeToVisit in _vertices[node])
                {
                    nodesToVisit.Enqueue(nodeToVisit);
                }
            }

            return false;
        }
    }
}
