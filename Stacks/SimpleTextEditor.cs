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

        private StringBuilder _text;
        private Stack<Operation> _operations;

        public SimpleTextEditor()
        {
            _text = new StringBuilder(1024 * 1024);
            _operations = new Stack<Operation>();
        }

        public void Append(string s)
        {
            
            _operations.Push(new Operation(s, Type.Addition));
            
            _append(s);
        }

        private void _append(string s)
        {
            _text.Append(s);
        }

        public void Delete(int k)
        {
            var value = _text.ToString(_text.Length - k, k);
            _operations.Push(new Operation(value, Type.Deletion));
            
            _delete(k);
        }

        private void _delete(int k)
        {
            _text.Remove(_text.Length - k, k);
        }

        public char Print(int k)
        {
            return _text[k-1];
        }

        public void Undo()
        {
            if (!_operations.Any())
            {
                return;
            }

            var last = _operations.Pop();

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
