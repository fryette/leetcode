using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Low
{
    //problem description link https://leetcode.com/problems/valid-parentheses/description/
    public class ValidParenthesesSolution
    {
        private readonly Dictionary<char, char> _dictionary = new Dictionary<char, char> { { '[', ']' }, { '(', ')' }, { '{', '}' } };

        public bool IsValid(string s)
        {
            var nextClosedBracket = '\0';
            var openedracketsStack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (!_dictionary.ContainsKey(s[i]))
                {
                    //Handle is it proper closed character
                    if (nextClosedBracket != s[i])
                    {
                        return false;
                    }
                }
                //if it not a closed - this is open bracket
                if (s[i] != nextClosedBracket)
                {
                    openedracketsStack.Push(s[i]);
                    nextClosedBracket = _dictionary[s[i]];
                }
                else
                {
                    openedracketsStack.Pop();
                    nextClosedBracket = openedracketsStack.Count != 0 ? _dictionary[openedracketsStack.Peek()] : '\0';
                }
            }

            return !openedracketsStack.Any();
        }
    }
}