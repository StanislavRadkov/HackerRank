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

        public void AddValue(T parent, T value)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(parent);
                Root.Left = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddValue(Root, parent, value);
            }
        }

        /* Design an algorithm and write code to find the first common ancestor of two nodes 
         * in a binary tree. Avoid storing additional nodes in a data structure. NOTE: This is not
         * necessarily a binary search tree. */
        public BinaryTreeNode<T> FindCommonAncestor(T a, T b)
        {
            return FindCommonAncestor(Root, a, b);
        }

        private BinaryTreeNode<T> FindCommonAncestor(BinaryTreeNode<T> node, T a, T b)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Value.Equals(a) || node.Value.Equals(b))
            {
                return node;
            }

            var aInLeftSubtree = Find(node.Left, a);
            var bInRightSubtree = Find(node.Left, b);

            /* If a and b are on different sides, return root. */
            if (aInLeftSubtree != bInRightSubtree)
            {
                return node;
            }

            /* Else, they are on the same side. Traverse this side. */
            BinaryTreeNode<T> child = aInLeftSubtree ? node.Left : node.Right;

            return FindCommonAncestor(child, a, b);
        }

        private bool Find(BinaryTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return false;
            }

            if (node.Value.Equals(value))
            {
                return true;
            }

            var inLeftSubtree = Find(node.Left, value);
            if (inLeftSubtree)
            {
                return true;
            }

            return Find(node.Right, value);
        }

        private bool AddValue(BinaryTreeNode<T> node, T parent, T value)
        {
            if (node == null)
            {
                return false;
            }

            if (node.Value.Equals(parent))
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value, node);
                }
                else if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value, node);
                }
                else
                {
                    AddValue(node.Left, value);
                }

                return true;
            }

            var lefSubtree = AddValue(node.Left, parent, value);
            if (lefSubtree)
            {
                return true;
            }

            return AddValue(node.Right, parent, value);
        }

        private void AddValue(BinaryTreeNode<T> node, T value)
        {
            if (node.Left == null)
            {
                node.Left = new BinaryTreeNode<T>(value, node);
            }
            else if (node.Right == null)
            {
                node.Right = new BinaryTreeNode<T>(value, node);
            }
            else
            {
                AddValue(node.Left, value);
            }
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
