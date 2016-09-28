using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stacks
{
    // https://www.hackerrank.com/challenges/simple-text-editor
    public class SimpleTextEditor
    {
        private enum Type
        {
            Addition,
            Deletion
        }

        private class Operation
        {
            public Operation(string s, Type type)
            {
                Type = type;
                Value = s;
            }

            public Type Type { get; set; }
            public String Value { get; set; }
        }

        private StringBuilder text;
        private Stack<Operation> operations;

        public SimpleTextEditor()
        {
            text = new StringBuilder(1024 * 1024);
            operations = new Stack<Operation>();
        }

        public void Append(string s)
        {
            
            operations.Push(new Operation(s, Type.Addition));
            
            _append(s);
        }

        private void _append(string s)
        {
            text.Append(s);
        }

        public void Delete(int k)
        {
            var value = text.ToString(text.Length - k, k);
            operations.Push(new Operation(value, Type.Deletion));
            
            _delete(k);
        }

        private void _delete(int k)
        {
            text.Remove(text.Length - k, k);
        }

        public char Print(int k)
        {
            return text[k-1];
        }

        public void Undo()
        {
            if (!operations.Any())
            {
                return;
            }

            var last = operations.Pop();

            switch (last.Type)
            {
                case Type.Addition:
                    _delete(last.Value.Length);
                    break;

                case Type.Deletion:
                    _append(last.Value);
                    break;
            }
        }
    }
}
