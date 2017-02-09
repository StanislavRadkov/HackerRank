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
    }
}
