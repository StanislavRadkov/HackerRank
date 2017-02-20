using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class TreesAndGraphs
    {
        /* Given a sorted (increasing order) array with unique integer elements,
         *  write an algorithm to create a binary search tree with minimal height */
        public static BinarySearchTree<int> GenerateTreeFromSortedArray(int[] values)
        {
            var tree = new BinarySearchTree<int>();

            var middle = values.Length/2;
            tree.Insert(values[middle]);

            for (var i = 1; i <= middle; i++)
            {
                if (middle - i >= 0)
                {
                    tree.Insert(values[middle - i]);
                }

                if (middle + i < values.Length)
                {
                    tree.Insert(values[middle + i]);
                }
            }

            return tree;
        }

        /* Implemen t a function to check if a binary tree isa binary search tree. */
        public static bool IsBinarySearchTree(BinaryTree<int> tree)
        {
            return IsBinarySearchTree(tree.Root, int.MinValue, int.MaxValue);
        }

        private static bool IsBinarySearchTree(BinaryTreeNode<int> node, int min, int max)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Value <= min || node.Value > max)
            {
                return false;
            }

            var leftSubtreeValid = IsBinarySearchTree(node.Left, min, node.Value);
            var rightSubtreeValid = IsBinarySearchTree(node.Right, node.Value, max);

            return leftSubtreeValid && rightSubtreeValid;
        }
    }
}
