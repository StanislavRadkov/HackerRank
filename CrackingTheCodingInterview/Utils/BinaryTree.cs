using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTree()
        {

        }

        public bool IsBalanced()
        {
            if (Root == null)
            {
                return true;
            }

            var leftSubtreeHeight = Root.Left == null ? 0 : GetHeight(Root.Left);
            var rightSubtreeHeight = Root.Right == null ? 0 : GetHeight(Root.Right);

            return Math.Abs(leftSubtreeHeight - rightSubtreeHeight) <= 1;
        }

        public int GetHeight()
        {
            if (Root == null)
            {
                return 0;
            }

            return GetHeight(Root);
        }

        private int GetHeight(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;
        }
    }
}
