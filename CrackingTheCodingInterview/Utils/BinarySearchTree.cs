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
                            node.Left = new BinaryTreeNode<T>(value, node);
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
                            node.Right = new BinaryTreeNode<T>(value, node);
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

        public T GetInOrderSuccessor(T value)
        {
            var node = FindNode(value);
            if (node == null)
            {
                throw new ArgumentException();
            }

            var successor = InOrderSuccessor(node);

            if (successor != null)
            {
                return successor.Value;
            }

            throw new Exception("No successor!");
        }

        /* Write an algorithm to find the 'next'node (i.e., in-order successor) of a given node in 
         * a binary search tree. Youmay assume that each nodehas a link to its parent. */
        private BinaryTreeNode<T> InOrderSuccessor(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Right != null)
            {
                return LeftMostChild(node.Right);
            }
            else
            {
                BinaryTreeNode<T> q = node;
                BinaryTreeNode<T> x = q.Parent;
                // Go up until we're on left instead of right
                while (x != null && x.Left != q)
                {
                    q = x;
                    x = x.Parent;
                }

                return x;
            }
        }

        private BinaryTreeNode<T> LeftMostChild(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return null;
            }

            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }

        public BinaryTreeNode<T> FindNode(T value)
        {
            if (Root == null)
            {
                return null;
            }

            return Find(Root, value);
        }

        private BinaryTreeNode<T> Find(BinaryTreeNode<T> node, T value)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Value.Equals(value))
            {
                return node;
            }

            if (value.CompareTo(node.Value) <= 0)
            {
                return Find(node.Left, value);
            }
            else
            {
                return Find(node.Right, value);
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
