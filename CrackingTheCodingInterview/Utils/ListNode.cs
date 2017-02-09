using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }
        public ListNode<T> Previous { get; set; }

        public ListNode(T value)
        {
            Value = value;
        }

        public ListNode(T value, ListNode<T> next)
            :this(value)
        {
            Next = next;
        }

        public ListNode(T value, ListNode<T> next, ListNode<T> previous)
            :this(value)
        {
            Next = next;
            Previous = previous;
        }
    }
}
