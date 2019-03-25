namespace LeetCode.Solutions.Medium
{
    public class MergeTwoBinaryTreesSolution
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
        
        //https://leetcode.com/problems/merge-two-binary-trees
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }

            if (t2 == null)
            {
                return t1;
            }

            return new TreeNode(t1.val + t2.val) {left = MergeTrees(t1.left, t2.left), right = MergeTrees(t1.right, t2.right)};
        }
    }
}