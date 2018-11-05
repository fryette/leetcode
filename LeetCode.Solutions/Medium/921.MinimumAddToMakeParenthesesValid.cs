using System;

namespace LeetCode.Solutions.Medium
{
    //https://leetcode.com/problems/minimum-add-to-make-parentheses-valid
    public class MinimumAddToMakeParenthesesValidSolution
    {
        public int MinAddToMakeValid(string s)
        {
            var stillValidOpenBracesCount = 0;
            var missedBrackets = 0;

            foreach (var c in s)
            {
                if (c == '(')
                {
                    stillValidOpenBracesCount++;
                }
                else if (stillValidOpenBracesCount > 0)
                {
                    stillValidOpenBracesCount--;
                }
                else
                {
                    missedBrackets++;
                }
            }

            return missedBrackets + stillValidOpenBracesCount;
        }
    }
}