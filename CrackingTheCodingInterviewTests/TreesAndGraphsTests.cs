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
            tree.AddValue(15, 13);
            tree.AddValue(15, 17);

            Assert.AreEqual(true, TreesAndGraphs.IsBinarySearchTree(tree));
        }

        [TestMethod]
        public void InOrderSuccessorTests1()
        {
            var values = Enumerable.Range(1, 100).ToArray();

            var tree = TreesAndGraphs.GenerateTreeFromSortedArray(values);
            var node = tree.FindNode(50);

            Assert.AreEqual(51, TreesAndGraphs.InOrderSuccessor(node).Value);
        }

        [TestMethod]
        public void InOrderSuccessorTests2()
        {
            var values = Enumerable.Range(1, 100).ToArray();

            var tree = TreesAndGraphs.GenerateTreeFromSortedArray(values);
            var node = tree.FindNode(25);

            Assert.AreEqual(26, TreesAndGraphs.InOrderSuccessor(node).Value);
        }

        [TestMethod]
        public void InOrderSuccessorTest3()
        {
            var values = Enumerable.Range(1, 100).ToArray();

            var tree = TreesAndGraphs.GenerateTreeFromSortedArray(values);
            var node = tree.FindNode(76);

            Assert.AreEqual(77, TreesAndGraphs.InOrderSuccessor(node).Value);
        }

        [TestMethod]
        public void InOrderSuccessorTests4()
        {
            var values = Enumerable.Range(1, 10000).ToArray();

            var tree = TreesAndGraphs.GenerateTreeFromSortedArray(values);
            var node = tree.FindNode(8888);

            Assert.AreEqual(8889, TreesAndGraphs.InOrderSuccessor(node).Value);
        }

        [TestMethod]
        public void InOrderSuccessorTests5()
        {
            var tree = new BinarySearchTree<int>();
            tree.Root = new BinaryTreeNode<int>(5);
            tree.Insert(4);
            tree.Insert(3);

            Assert.AreEqual(null, TreesAndGraphs.InOrderSuccessor(tree.Root));
        }

        [TestMethod]
        public void FindCommonAncestorTests1()
        {
            var tree = new BinaryTree<string>();

            Assert.AreEqual(null, tree.FindCommonAncestor(String.Empty, String.Empty));
        }

        [TestMethod]
        public void FindCommonAncestorTests2()
        {
            var tree = new BinaryTree<string>();

            tree.AddValue("a", "b");

            Assert.AreEqual("a", tree.FindCommonAncestor("a", "b").Value);
        }

        [TestMethod]
        public void FindCommonAncestorTests3()
        {
            var tree = new BinaryTree<string>();

            tree.AddValue("a", "b");
            tree.AddValue("a", "c");

            Assert.AreEqual("a", tree.FindCommonAncestor("b", "c").Value);
        }

        [TestMethod]
        public void FindCommonAncestorTests4()
        {
            var tree = new BinaryTree<string>();

            tree.AddValue("a", "b");
            tree.AddValue("a", "c");

            Assert.AreEqual("a", tree.FindCommonAncestor("a", "b").Value);
        }

        [TestMethod]
        public void FindCommonAncestorTests5()
        {
            var tree = new BinaryTree<string>();

            tree.AddValue("a", "b");
            tree.AddValue("a", "c");

            Assert.AreEqual("a", tree.FindCommonAncestor("a", "c").Value);
        }

        [TestMethod]
        public void FindCommonAncestorTests6()
        {
            var tree = new BinaryTree<string>();

            tree.AddValue("a", "b");
            tree.AddValue("a", "c");
            tree.AddValue("c", "k");
            tree.AddValue("b", "x");

            Assert.AreEqual("a", tree.FindCommonAncestor("x", "k").Value);
        }

        [TestMethod]
        public void FindCommonAncestorTests7()
        {
            var tree = new BinaryTree<string>();

            tree.AddValue("a", "b");
            tree.AddValue("a", "c");
            tree.AddValue("c", "k");
            tree.AddValue("c", "x");

            Assert.AreEqual("c", tree.FindCommonAncestor("x", "k").Value);
        }

        [TestMethod]
        public void FindCommonAncestorTests8()
        {
            var tree = new BinaryTree<string>();

            tree.AddValue("a", "b");
            tree.AddValue("a", "c");
            tree.AddValue("c", "k");
            tree.AddValue("k", "x");

            Assert.AreEqual("k", tree.FindCommonAncestor("x", "k").Value);
            Assert.AreEqual("k", tree.FindCommonAncestor("k", "x").Value);
        }

        [TestMethod]
        public void FindCommonAncestorTests9()
        {
            var tree = new BinaryTree<string>();

            tree.AddValue("a", "b");
            tree.AddValue("a", "c");
            tree.AddValue("c", "k");
            tree.AddValue("k", "z");
            tree.AddValue("z", "x");

            Assert.AreEqual("k", tree.FindCommonAncestor("x", "k").Value);
            Assert.AreEqual("k", tree.FindCommonAncestor("k", "x").Value);
        }

        [TestMethod]
        public void IsSubtreeTreesTests1()
        {
            var tree1 = new BinaryTree<string>();

            tree1.AddValue("a", "b");
            tree1.AddValue("a", "c");
            tree1.AddValue("c", "k");
            tree1.AddValue("k", "z");
            tree1.AddValue("z", "x");

            var tree2 = new BinaryTree<string>();

            tree2.AddValue("k", "z");
            tree2.AddValue("z", "x");

            Assert.AreEqual(true, TreesAndGraphs.IsSubtree(tree1, tree2));
        }

        [TestMethod]
        public void IsSubtreeTreesTests2()
        {
            var tree1 = new BinaryTree<string>();

            tree1.AddValue("a", "b");
            tree1.AddValue("a", "c");
            tree1.AddValue("c", "k");
            tree1.AddValue("k", "z");
            tree1.AddValue("z", "x");

            var tree2 = new BinaryTree<string>();

            tree2.AddValue("k", "z");
            tree2.AddValue("z", "x");
            tree2.AddValue("x", "t");

            Assert.AreEqual(false, TreesAndGraphs.IsSubtree(tree1, tree2));
        }

        [TestMethod]
        public void IsSubtreeTreesTests3()
        {
            var tree1 = new BinaryTree<string>();

            tree1.AddValue("a", "b");
            tree1.AddValue("a", "c");
            tree1.AddValue("c", "k");
            tree1.AddValue("k", "z");
            tree1.AddValue("z", "x");

            var tree2 = new BinaryTree<string>();

            tree2.AddValue("a", "b");
            tree2.AddValue("a", "c");
            tree2.AddValue("c", "k");
            tree2.AddValue("k", "z");
            tree2.AddValue("z", "x");

            Assert.AreEqual(true, TreesAndGraphs.IsSubtree(tree1, tree2));
        }

        [TestMethod]
        public void IsSubtreeTreesTests4()
        {
            var tree1 = new BinaryTree<string>();

            tree1.AddValue("a", "b");
            tree1.AddValue("a", "c");
            tree1.AddValue("c", "k");
            tree1.AddValue("k", "z");
            tree1.AddValue("z", "x");

            var tree2 = new BinaryTree<string>();

            tree2.Root = new BinaryTreeNode<string>("k");

            Assert.AreEqual(false, TreesAndGraphs.IsSubtree(tree1, tree2));
        }
    }
}
