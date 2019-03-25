namespace LeetCode.Solutions.Medium
{
    //https://leetcode.com/problems/binary-tree-pruning/
    public class BinaryTreePruningSolution
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

        public TreeNode PruneTree(TreeNode root)
        {
            if (root.left != null)
            {
                root.left = PruneTree(root.left);
            }

            if (root.right != null)
            {
                root.right = PruneTree(root.right);
            }
            
            if (root.val == 0 && root.left == null && root.right == null)
            {
                return null;
            }
            
            return root;
        }
    }
}