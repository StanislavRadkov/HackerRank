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

        /* Write an algorithm to find the 'next'node (i.e., in-order successor) of a given node in 
         * a binary search tree. Youmay assume that each nodehas a link to its parent. */
        public static BinaryTreeNode<int> InOrderSuccessor(BinaryTreeNode<int> node)
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
                BinaryTreeNode<int> q = node;
                BinaryTreeNode<int> x = q.Parent;
                // Go up until we're on left instead of right
                while (x != null && x.Left != q)
                {
                    q = x;
                    x = x.Parent;
                }

                return x;
            }
        }

        private static BinaryTreeNode<int> LeftMostChild(BinaryTreeNode<int> node)
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

        /* You have two very large binary trees: Tl, with millions of nodes, and T2, with 
         * hundreds of nodes. Create an algorithm to decide ifT2 is a subtree ofTl. 
         * A tree T2 is a subtree of Tl if there exists a node n in Tl such that the subtree of n
         *  is identical to T2. That is, if you cut off the tree at node n, the two trees would be 
         *  identical. */
        public static bool IsSubtree(BinaryTree<string> tree1, BinaryTree<string> tree2)
        {
            if (tree2.Root == null || tree2.Root == null)
            {
                return true;
            }

            return SubTree(tree1.Root, tree2.Root);
        }

        private static bool SubTree(BinaryTreeNode<String> node1, BinaryTreeNode<String> node2)
        {
            if (node1 == null)
            {
                return false;
            }

            if (node1.Value == node2.Value)
            {
                if (MatchTree(node1, node2))
                {
                    return true;
                }
            }

            return SubTree(node1.Left, node2) || SubTree(node1.Right, node2);
        }

        private static bool MatchTree(BinaryTreeNode<string> node1, BinaryTreeNode<string> node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }

            if (node1 == null || node2 == null)
            {
                return false;
            }

            if (node1.Value != node2.Value)
            {
                return false;
            }

            return MatchTree(node1.Left, node2.Left) && MatchTree(node1.Right, node2.Right);
        }

        /* You are given a binary tree in which each node contains a value. Design an algorithm 
         * to print all paths which sum to a given value. The path does not need to start 
         * or end at the root or a leaf. */
        public static List<List<int>> GetSumPaths(BinaryTree<int> tree, int sum)
        {
            var sums = new List<List<int>>();
            var currentPath = new List<int>();

            FindSum(tree.Root, sums, currentPath, sum);

            return sums;
        }

        private static void FindSum(BinaryTreeNode<int> node, List<List<int>> sums, List<int> currentPath, int sum)
        {
            if (node == null)
            {
                return;
            }

            currentPath.Add(node.Value);

            //check sum
            var currentSum = 0;
            for (var i = currentPath.Count - 1; i >= 0; i--)
            {
                currentSum += currentPath[i];
                if (currentSum == sum)
                {
                    sums.Add(currentPath.GetRange(i, currentPath.Count - i));
                }
            }

            FindSum(node.Left, sums, currentPath, sum);
            FindSum(node.Right, sums, currentPath, sum);

            currentPath.RemoveAt(currentPath.Count - 1);
        }
    }
}
