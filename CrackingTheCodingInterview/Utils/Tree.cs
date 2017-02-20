using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }

        public bool AddValue(T parent, T value)
        {
            if (Root == null)
            {
                return false;
            }

            var nodesToVisit = new Queue<TreeNode<T>>();
            nodesToVisit.Enqueue(Root);

            while (nodesToVisit.Count > 0)
            {
                var node = nodesToVisit.Dequeue();
                if (node.Value.Equals(parent))
                {
                    node.AddChild(value);

                    return true;
                }

                foreach (var child in node.Children)
                {
                    nodesToVisit.Enqueue(child);
                }
            }

            return false;
        }

        public List<List<T>> GetListOfDepths()
        {
            if (Root == null)
            {
                return new List<List<T>>();
            }

            var lists = new List<List<T>>();
            var currentLevel = new List<T>();
            var nodesToVisit = new Queue<TreeNode<T>>();
            var level = 1;
            var itemsPerLevel = 1;

            nodesToVisit.Enqueue(Root);

            while (nodesToVisit.Count > 0)
            {
                var node = nodesToVisit.Dequeue();
                currentLevel.Add(node.Value);

                foreach (var child in node.Children)
                {
                    nodesToVisit.Enqueue(child);
                }

                itemsPerLevel--;
                if (itemsPerLevel == 0)
                {
                    lists.Add(currentLevel);
                    currentLevel = new List<T>();

                    level++;
                    itemsPerLevel = nodesToVisit.Count;
                }
            }

            return lists;
        }
    }
}
