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

        private bool AddValue(BinaryTreeNode<T> node, T parent, T value)
        {
            if (node.Value.Equals(parent))
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
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
                node.Left = new BinaryTreeNode<T>(value);
            }
            else if (node.Right == null)
            {
                node.Right = new BinaryTreeNode<T>(value);
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
