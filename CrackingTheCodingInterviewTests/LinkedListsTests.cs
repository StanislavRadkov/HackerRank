using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections;
using CrackingTheCodingInterview;

namespace CrackingTheCodingInterviewTests
{
    [TestClass]
    public class LinkedListsTests
    {
        [TestMethod]
        public void RemoveDuplicatesTest1()
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 4, 5, 12, 4 };
            var list = data.ToLinkedList();
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 12 };


            CollectionAssert.AreEqual(expected, LinkedLists.RemoveDuplicates(list).ToEnumerable().ToArray());
        }

        [TestMethod]
        public void RemoveDuplicatesTest2()
        {
            var data = new int[0] ;
            var list = data.ToLinkedList();
            var expected = new int[0];

            CollectionAssert.AreEqual(expected, LinkedLists.RemoveDuplicates(list).ToEnumerable().ToArray());
        }

        [TestMethod]
        public void RemoveDuplicatesTest3()
        {
            var data = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var list = data.ToLinkedList();
            var expected = new int[] { 1 };


            CollectionAssert.AreEqual(expected, LinkedLists.RemoveDuplicates(list).ToEnumerable().ToArray());
        }


            [TestMethod]
        public void RemoveDuplicatesNoBufferTest1()
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 4, 5, 12, 4 };
            var list = data.ToLinkedList();
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 12 };


            CollectionAssert.AreEqual(expected, LinkedLists.RemoveDuplicatesNoBuffer(list).ToEnumerable().ToArray());
        }

        [TestMethod]
        public void RemoveDuplicatesNoBufferTest2()
        {
            var data = new int[0];
            var list = data.ToLinkedList();
            var expected = new int[0];

            CollectionAssert.AreEqual(expected, LinkedLists.RemoveDuplicatesNoBuffer(list).ToEnumerable().ToArray());
        }

        [TestMethod]
        public void RemoveDuplicatesNoBufferTest3()
        {
            var data = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            var list = data.ToLinkedList();
            var expected = new int[] { 1 };


            CollectionAssert.AreEqual(expected, LinkedLists.RemoveDuplicatesNoBuffer(list).ToEnumerable().ToArray());
        }

    }
}
