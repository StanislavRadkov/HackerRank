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
    }
}
