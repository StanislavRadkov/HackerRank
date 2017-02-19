using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class BinarySearchTree<T>: BinaryTree<T> where T:IComparable
    {
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
    }
}
