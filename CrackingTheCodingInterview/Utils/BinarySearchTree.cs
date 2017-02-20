using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class BinarySearchTree<T> where T:IComparable
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; private set; }

        public void Insert(T value)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(value);
                Count++;
            }
            else
            {
                var node = Root;
                while (node != null)
                {
                    if (value.CompareTo(node.Value) < 0)
                    {
                        if (node.Left == null)
                        {
                            node.Left = new BinaryTreeNode<T>(value);
                            Count++;
                            return;
                        }
                        else
                        {
                            node = node.Left;
                        }
                    }
                    else
                    {
                        if (node.Right == null)
                        {
                            node.Right = new BinaryTreeNode<T>(value);
                            Count++;
                            return;
                        }
                        else
                        {
                            node = node.Right;
                        }
                    }
                }
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
