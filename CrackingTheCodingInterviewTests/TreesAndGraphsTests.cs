using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingTheCodingInterview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingTheCodingInterviewTests
{

    [TestClass]
    public class TreesAndGraphsTests
    {
        [TestMethod]
        public void TestBalancedTree1()
        {
            var tree = new BinaryTree<int>();
            tree.Root = new BinaryTreeNode<int>(1);
            tree.Root.Left = new BinaryTreeNode<int>(2);
            tree.Root.Right = new BinaryTreeNode<int>(3);

            tree.Root.Left.Left = new BinaryTreeNode<int>(4);
            tree.Root.Left.Right = new BinaryTreeNode<int>(5);

            tree.Root.Left.Left.Left = new BinaryTreeNode<int>(8);

            tree.Root.Right.Left = new BinaryTreeNode<int>(6);
            tree.Root.Right.Right = new BinaryTreeNode<int>(7);

            Assert.AreEqual(true, tree.IsBalanced());
        }

        [TestMethod]
        public void TestBalancedTree2()
        {
            var tree = new BinaryTree<int>();
            tree.Root = new BinaryTreeNode<int>(1);
            tree.Root.Left = new BinaryTreeNode<int>(2);
            tree.Root.Right = new BinaryTreeNode<int>(3);

            tree.Root.Left.Left = new BinaryTreeNode<int>(4);
            tree.Root.Left.Right = new BinaryTreeNode<int>(5);

            tree.Root.Left.Left.Left = new BinaryTreeNode<int>(8);
            tree.Root.Left.Left.Left.Left = new BinaryTreeNode<int>(9);

            tree.Root.Right.Left = new BinaryTreeNode<int>(6);
            tree.Root.Right.Right = new BinaryTreeNode<int>(7);
            
            Assert.AreEqual(false, tree.IsBalanced());
        }

        [TestMethod]
        public void TestFindPath1()
        {
            var graph = new Graph();
            graph.AddVertex(1, new List<int> { 2, 3 });
            graph.AddVertex(2, new List<int> { 4 });
            graph.AddVertex(3, new List<int> { 5 });
            graph.AddVertex(4, new List<int> { 1 });
            graph.AddVertex(5, new List<int> { 2, 8 });
            graph.AddVertex(6, new List<int> { 7 });
            graph.AddVertex(7, new List<int> { });
            graph.AddVertex(8, new List<int> { 9 });
            graph.AddVertex(9, new List<int> { 3 });
            graph.AddVertex(10, new List<int> { 5 });

            Assert.AreEqual(true, graph.Path(1, 9));
        }

        [TestMethod]
        public void GenerateTreeFromSortedArrayTests1()
        {
            var values = Enumerable.Range(1, 8).ToArray();

            var tree = TreesAndGraphs.GenerateTreeFromSortedArray(values);

            Assert.AreEqual(values.Length, tree.Count);
            Assert.AreEqual(true, tree.IsBalanced());
        }

        [TestMethod]
        public void GenerateTreeFromSortedArrayTests2()
        {
            var values = Enumerable.Range(1, 7).ToArray();

            var tree = TreesAndGraphs.GenerateTreeFromSortedArray(values);

            Assert.AreEqual(values.Length, tree.Count);
            Assert.AreEqual(true, tree.IsBalanced());
        }

        [TestMethod]
        public void GenerateTreeFromSortedArrayTests3()
        {
            var values = Enumerable.Range(1, 10000).ToArray();

            var tree = TreesAndGraphs.GenerateTreeFromSortedArray(values);

            Assert.AreEqual(values.Length, tree.Count);
            Assert.AreEqual(true, tree.IsBalanced());
        }

        [TestMethod]
        public void GetListOfDepthsTests1()
        {
            var tree = new Tree<int>();
            tree.Root = new TreeNode<int>(1);
            tree.AddValue(1, 2);
            tree.AddValue(1, 3);

            tree.AddValue(2, 4);
            tree.AddValue(2, 5);

            tree.AddValue(3, 6);
            tree.AddValue(3, 7);

            var levels = tree.GetListOfDepths();

            CollectionAssert.AreEqual(levels[0], new List<int> { 1 });
            CollectionAssert.AreEqual(levels[1], new List<int> { 2, 3 });
            CollectionAssert.AreEqual(levels[2], new List<int> { 4, 5, 6, 7 });
        }

        [TestMethod]
        public void GetListOfDepthsTests2()
        {
            var tree = new Tree<int>();

            var levels = tree.GetListOfDepths();

            CollectionAssert.AreEqual(levels, new List<List<int>>());
        }

        [TestMethod]
        public void GetListOfDepthsTests3()
        {
            var tree = new Tree<int>();
            tree.Root = new TreeNode<int>(1);

            var levels = tree.GetListOfDepths();

            CollectionAssert.AreEqual(levels[0], new List<int> {1});
        }

        [TestMethod]
        public void IsBinarySearchTreeTests1()
        {
            var tree = new BinaryTree<int>();
            tree.Root = new BinaryTreeNode<int>(1);

            Assert.AreEqual(true, TreesAndGraphs.IsBinarySearchTree(tree));
        }

        [TestMethod]
        public void IsBinarySearchTreeTests2()
        {
            var tree = new BinaryTree<int>();
            tree.Root = new BinaryTreeNode<int>(20);
            tree.AddValue(20, 10);
            tree.AddValue(10, 25);
            tree.AddValue(20, 30);

            Assert.AreEqual(false, TreesAndGraphs.IsBinarySearchTree(tree));
        }

        [TestMethod]
        public void IsBinarySearchTreeTests3()
        {
            var tree = new BinaryTree<int>();
            tree.Root = new BinaryTreeNode<int>(20);
            tree.AddValue(20, 10);
            tree.AddValue(20, 30);
            tree.AddValue(10, 5);
            tree.AddValue(5, 3);
            tree.AddValue(5, 7);
            tree.AddValue(10, 15);
            tree.AddValue(15, 17);

            Assert.AreEqual(true, TreesAndGraphs.IsBinarySearchTree(tree));
        }
    }
}
