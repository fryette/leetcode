using System.Collections.Generic;

namespace LeetCode.Solutions.Medium
{
    public class RangeSumOfBSTSolution
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }
        }

        //https://leetcode.com/problems/range-sum-of-bst
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            var sum = 0;

            if (root == null)
            {
                if (root.val >= L && root.val <= R)
                {
                    sum += root.val;
                }

                if (root.val >= L)
                {
                    sum += RangeSumBST(root.left, L, R);
                }

                if (root.val <= R)
                {
                    sum += RangeSumBST(root.right, L, R);
                }
            }

            return sum;
        }
    }
}