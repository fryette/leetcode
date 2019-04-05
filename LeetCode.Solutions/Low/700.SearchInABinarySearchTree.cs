namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/search-in-a-binary-search-tree/
    public class SearchInABinarySearchTreeSolution
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

        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }

            return SearchBST(root.left, val) ?? SearchBST(root.right, val);
        }
    }
}