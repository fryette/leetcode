using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Medium
{
    public class TreeNode
    {
        public readonly int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class MaximumBinaryTreeSolution
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            var stack = new Stack<TreeNode>();

            foreach (var num in nums)
            {
                var curr = new TreeNode(num);
                while (stack.Count != 0 && stack.Peek().val < num)
                {
                    curr.left = stack.Pop();
                }

                if (stack.Count != 0)
                {
                    stack.Peek().right = curr;
                }

                stack.Push(curr);
            }

            return stack.Count == 0 ? null : stack.LastOrDefault();
        }
    }
}