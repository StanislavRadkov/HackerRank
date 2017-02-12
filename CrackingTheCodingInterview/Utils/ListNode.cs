using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    public class ListNode<T> : ICloneable
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T value)
        {
            Value = value;
        }

        public ListNode(T value, ListNode<T> next)
            : this(value)
        {
            Next = next;
        }

        public object Clone()
        {
            return new ListNode<T>(Value);
        }
    }
}
