namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/univalued-binary-tree/
    public class UnivaluedBinaryTreeSolution
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

        public bool IsUnivalTree(TreeNode root)
        {
            return IsUnivalInternal(root, root.val);
        }

        private bool IsUnivalInternal(TreeNode root, int val)
        {
            if (root == null)
            {
                return true;
            }

            if (root.val != val)
            {
                return false;
            }

            if (root.left == null && root.right == null)
            {
                return true;
            }

            return IsUnivalInternal(root.left, root.val) && IsUnivalInternal(root.right, root.val);
        }
    }
}