using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public static class Utils
    {
        public static ListNode<T> ToLinkedList<T>(this IEnumerable<T> collection)
        {
            ListNode<T> head = null;
            ListNode<T> node = null;

            foreach (var value in collection)
            {
                if (head == null)
                {
                    head = new ListNode<T>(value);
                    node = head;
                }
                else
                {
                    node.Next = new ListNode<T>(value);
                    node = node.Next;
                }

            }

            return head;
        }

        public static IEnumerable<T> ToEnumerable<T>(this ListNode<T> node)
        {
            if (node == null)
            {
                return Enumerable.Empty<T>();
            }

            var list = new List<T>();

            do
            {
                list.Add(node.Value);
                node = node.Next;
            } while (node != null);

            return list;
        }
    }
}
