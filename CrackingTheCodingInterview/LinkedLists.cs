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

            do
            {
                if (hashset.Contains(node.Value))
                {
                    node = node.Previous;
                    node.Next = node.Next.Next;
                    if (node.Next != null)
                    {
                        node.Next.Previous = node;
                    }
                }
                else
                {
                    hashset.Add(node.Value);
                }

                node = node.Next;

            } while (node != null);

            return head;
        }
    }
}
