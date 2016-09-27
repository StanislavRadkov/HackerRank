using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks
{
    /// https://www.hackerrank.com/challenges/balanced-brackets
    public static class BalancedBrackets
    {
        public static bool ValiedateBrackets(string input)
        {
            var brackets = input.ToCharArray();
            var stack = new Stack<Char>();

            if (brackets.Length % 2 != 0)
            {
                return false;
            }

            var openingBrackets = new[] { '(','{','[' };
            var closingBrackets = new[] { ')', '}', ']'};

            foreach (var bracket in brackets)
            {
                if (openingBrackets.Contains(bracket))
                {
                    stack.Push(bracket);
                }
                else
                {
                    if (stack.Count == 0 || 
                        (stack.Count > 0 && Array.IndexOf(closingBrackets, bracket) != Array.IndexOf(openingBrackets, stack.Pop()))) {
                        return false;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }

            return true;
        }
    }
}
