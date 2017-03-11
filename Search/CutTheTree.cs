using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    // https://www.hackerrank.com/challenges/cut-the-tree
    public class Edge
    {
        public int value;
        public Vertex vertex;
        public Edge(Vertex vertex, int value)
        {
            this.value = value;
            this.vertex = vertex;
        }
    }

    public class Vertex
    {
        private int MinDiff;
        private int Value;
        private bool IsInit;
        private List<Edge> Edges;

        public Vertex(int value)
        {
            Value = value;
            Edges = new List<Edge>();
        }

        public void AddEdge(Vertex vertex, int value)
        {
            Edges.Add(new Edge(vertex, value));
        }

        public int GetMinDiff(int sum)
        {
            int min = sum;
            foreach (var edge in Edges)
            {
                //Get difference of both possible trees
                int currentMin = Math.Abs(sum - 2 * edge.value);
                //Update min
                min = Math.Min(currentMin, min);
            }

            return min;
        }

        public int Init()
        {
            this.IsInit = true;
            Edge caller = null;
            int sum = this.Value;
            //For each edge
            foreach (var edge in Edges)
            {
                //If it's the caller, save for later
                if (edge.vertex.IsInit)
                {
                    caller = edge;
                    //Otherwise, get the sum of
                    //all vertices for that edge
                }
                else
                {
                    sum += edge.value = edge.vertex.Init();
                }
            }
            //If it's the caller
            //subtract this vertex's
            //sum from the tree's sum
            if (caller != null)
            {
                caller.value -= sum;
            }
            return sum;
        }
    }
}
