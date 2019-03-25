using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Medium
{
    public class TreeNode
    {
        public readonly int Val;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int x)
        {
            Val = x;
        }
    }

    public class MaximumBinaryTree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            var stack = new Stack<TreeNode>();

            foreach (var num in nums)
            {
                var curr = new TreeNode(num);
                while (stack.Count != 0 && stack.Peek().Val < num)
                {
                    curr.Left = stack.Pop();
                }

                if (stack.Count != 0)
                {
                    stack.Peek().Right = curr;
                }

                stack.Push(curr);
            }

            return stack.Count == 0 ? null : stack.LastOrDefault();
        }
    }
}