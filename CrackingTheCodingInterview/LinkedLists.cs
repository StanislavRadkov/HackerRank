using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class LinkedLists
    {
        /* Write code to remove duplicates from an unsorted linked list. 
         * FOLLOW UP 
         * How would you solve this problem if a temporary buffer is not allowed? */
        public static ListNode<int> RemoveDuplicates(ListNode<int> head)
        {
            if (head == null)
            {
                return null;
            }

            var hashset = new HashSet<int>();

            var node = head;
            ListNode<int> previous = null;

            while(node != null)
            {
                if (hashset.Contains(node.Value))
                {
                    previous.Next = node.Next;
                }
                else
                {
                    hashset.Add(node.Value);
                    previous = node;
                }

                node = node.Next;

            } while (node != null);

            return head;
        }

        public static ListNode<int> RemoveDuplicatesNoBuffer(ListNode<int> head)
        {
            if (head == null)
            {
                return null;
            }

            var node = head;
            ListNode<int> previous = null;

            while (node != null)
            {
                var runner = node;
                while(runner.Next != null)
                {
                    if (runner.Next.Value == node.Value)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }

                node = node.Next;

            } while (node != null) ;

            return head;
        }

        /* Implement an algorithm to find the kth to last element of a singly linked list */
        public static int GetNthToLastRecursive(ListNode<int> head, ref int? element, int k)
        {
            if (head == null)
            {
                return 0;
            }

            var i = GetNthToLastRecursive(head.Next, ref element, k) + 1;

            if (i == k)
            {
                element = head.Value;
            }

            return i;
        }

        public static ListNode<int> GetNthToLastIterative(ListNode<int> head, int k)
        {
            var p1 = head;
            var p2 = head;

            for (var i = 0; i < k - 1; i++)
            {
                p2 = p2.Next;
                if (p2 == null) return null;
            }

            while (p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p1;
        }

        /* Implementan algorithm to delete a node in the middle of a singly linked list, given 
         * only access to that node */
        public static void RemoveNode(ListNode<int> node)
        {
            if (node.Next == null)
            {
                return;
            }

            node.Value = node.Next.Value;
            node.Next = node.Next.Next;
        }

        /*  Write code to partition a linked list around a value x, such that all nodes less than x 
         *  come before alt nodes greater than or equal to  */
        public static ListNode<int> PartitionList(ListNode<int> head, int value)
        {
            if (head == null)
            {
                return null;
            }

            ListNode<int> lessStart = null;
            ListNode<int> lessEnd = null;
            ListNode<int> greaterOrEqualStart = null;
            ListNode<int> greaterOrEqualEnd = null;

            do
            {
                if (head.Value < value)
                {
                    if (lessStart == null)
                    {
                        lessStart = head;
                        lessEnd = head;
                    }
                    else
                    {
                        lessEnd.Next = head;
                        lessEnd = head;
                    }
                }
                else
                {
                    if (greaterOrEqualStart == null)
                    {
                        greaterOrEqualStart = head;
                        greaterOrEqualEnd = head;
                    }
                    else
                    {
                        greaterOrEqualEnd.Next = head;
                        greaterOrEqualEnd = head;
                    }
                }

                head = head.Next;
            } while (head != null);

            lessEnd.Next = greaterOrEqualStart;

            return lessStart;
        }

        /* You have two numbers represented by a linked list, where each node contains a 
         * single digit. The digits are stored in reverse order, such that the 1 's digit is at the head 
         * of the list. Write a function that adds the two numbers and returns the sum as a 
         * linked list. 
         * FOLLOW UP 
         * Suppose the digits are stored in forward order. Repeat the above problem. */
        public static ListNode<int> Sum(ListNode<int> a, ListNode<int> b)
        {
            ListNode<int> sumStart = null;
            ListNode<int> sumEnd = null;

            var carryOn = 0;
            while (a != null || b != null)
            {
                var s = 0;
                if (a != null)
                {
                    s += a.Value;
                    a = a.Next;
                }
                if (b != null)
                {
                    s += b.Value;
                    b = b.Next;
                }

                s += carryOn;
                carryOn = 0;

                carryOn = s / 10;
                s = s % 10;

                if (sumStart == null)
                {
                    sumStart = new ListNode<int>(s);
                    sumEnd = sumStart;
                }
                else
                {
                    sumEnd.Next = new ListNode<int>(s);
                    sumEnd = sumEnd.Next;
                }
            }

            return sumStart;
        }

        public static ListNode<int> ReverseList(ListNode<int> head)
        {
            ListNode<int> reversedList = null;

            while (head != null)
            {
                var itemToInsert = head.Clone() as ListNode<int>;
                head = head.Next;

                itemToInsert.Next = reversedList;
                reversedList = itemToInsert;
            }

            return reversedList;
        }

        public static ListNode<int> SumReversedOrderedLists(ListNode<int> a, ListNode<int> b)
        {
            var reversedA = ReverseList(a);
            var reversedB = ReverseList(b);

            return ReverseList(Sum(reversedA, reversedB));
        }

        /* Given a circular linked list, implement an algorithm which returns the node at the 
         * beginning of the loop */
        public static ListNode<int> FindLoopBeginning(ListNode<int> head)
        {
            var slowRunner = head;
            var fastRunner = head;

            // Find meeting point
            while (fastRunner != null && fastRunner.Next != null)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next.Next;

                if (slowRunner == fastRunner)
                {
                    break;
                }
            }

            // No loop
            if (fastRunner == null || fastRunner.Next == null)
            {
                return null;
            }

            /* Move slow to Head. Keep fast at Meeting Point. Each are k steps
            /* from the Loop Start. If they move at the same pace, they must
             * meet at Loop Start. */
            slowRunner = head;
            while (slowRunner != fastRunner)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next;
            }

            // Both now point to the start of the loop.
            return fastRunner;
        }

        /* Implementa function to check if a linked list is apalindrome, */
        public static bool IsPalindromeByReversing(ListNode<int> list)
        {
            var reversed = ReverseList(list);

            while (reversed != null)
            {
                if (reversed.Value != list.Value)
                {
                    return false;
                }

                reversed = reversed.Next;
                list = list.Next;
            }

            return true;
        }

        public static bool IsPalindromeIterative(ListNode<int> head)
        {
            var slowRunner = head;
            var fastRunner = head;

            var stack = new Stack<int>();

            while (fastRunner != null && fastRunner.Next != null)
            {
                stack.Push(slowRunner.Value);
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next.Next;
            }

            /* Has odd number of elements, so skip the middle element */
            if (fastRunner != null)
            {
                slowRunner = slowRunner.Next;
            }

            while (slowRunner != null)
            {
                var top = stack.Pop();
                
                /* If values are different, then it's not a palindrome */
                if (top != slowRunner.Value)
                {
                    return false;
                }
                slowRunner = slowRunner.Next;
            }

            return true;
        }
    }
}
