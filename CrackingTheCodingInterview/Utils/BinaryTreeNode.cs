using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Parent { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> parent)
            :this(value)
        {
            Parent = parent;
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
            :this(value)
        {
            Left = left;
            Right = right;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
