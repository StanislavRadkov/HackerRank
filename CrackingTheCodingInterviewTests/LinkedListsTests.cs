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

        [TestMethod]
        public void GetNthToLastRecursiveTest1()
        {
            var data = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var list = data.ToLinkedList();

            int? number = null;

            LinkedLists.GetNthToLastRecursive(list, ref number, 4);

            Assert.AreEqual(4, number);
        }

        [TestMethod]
        public void GetNthToLastRecursiveTest2()
        {
            var data = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var list = data.ToLinkedList();

            int? number = null;

            LinkedLists.GetNthToLastRecursive(list, ref number, 25);

            Assert.AreEqual(false, number.HasValue);
        }

        [TestMethod]
        public void GetNthToLastRecursiveTest3()
        {
            var data = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var list = data.ToLinkedList();

            int? number = null;

            LinkedLists.GetNthToLastRecursive(list, ref number, 7);

            Assert.AreEqual(7, number);
        }

        [TestMethod]
        public void GetNthToLastIterativeTest1()
        {
            var data = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var list = data.ToLinkedList();

            Assert.AreEqual(4, LinkedLists.GetNthToLastIterative(list, 4).Value);
        }

        [TestMethod]
        public void GetNthToLastIterativeTest2()
        {
            var data = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var list = data.ToLinkedList();

            Assert.AreEqual(null, LinkedLists.GetNthToLastIterative(list, 25));
        }

        [TestMethod]
        public void GetNthToLastIterativeTest3()
        {
            var data = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var list = data.ToLinkedList();

            Assert.AreEqual(7, LinkedLists.GetNthToLastIterative(list, 7).Value);
        }

        [TestMethod]
        public void RemoveNodeTests1()
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var list = data.ToLinkedList();
            var element = list;
            while (element.Value != 8)
            {
                element = element.Next;
            }
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15 };
            LinkedLists.RemoveNode(element);

            CollectionAssert.AreEqual(expected, list.ToEnumerable().ToArray());
        }

        [TestMethod]
        public void RemoveNodeTests2()
        {
            var data = new int[] { 1 };
            var list = data.ToLinkedList();
            var expected = new int[] { 1 };
            LinkedLists.RemoveNode(list);

            CollectionAssert.AreEqual(expected, list.ToEnumerable().ToArray());
        }

        [TestMethod]
        public void PartitionListTests1()
        {
            var data = new int[] { 5, 1, 6, 2, 7, 3, 8, 4, 9, 10 };
            var list = data.ToLinkedList();
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            CollectionAssert.AreEqual(expected, LinkedLists.PartitionList(list, 5).ToEnumerable().ToArray());
        }

        [TestMethod]
        public void PartitionListTests2()
        {
            CollectionAssert.AreEqual(new int[0], LinkedLists.PartitionList(null, 5).ToEnumerable().ToArray());
        }
    }
}
