using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class TreeNode<T>
    {
        public TreeNode(T value)
            : this(value, Enumerable.Empty<T>())
        {
        }

        public TreeNode(T value, IEnumerable<T> children)
        {
            Value = value;
            Children = new List<TreeNode<T>>();

            foreach (var child in children)
            {
                Children.Add(new TreeNode<T>(child));
            }
        }

        public void AddChild(T value)
        {
            Children.Add(new TreeNode<T>(value));
        }

        public T Value { get; set; }

        public List<TreeNode<T>> Children { get; set; }
    }
}
