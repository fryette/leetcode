namespace LeetCode.Solutions.Medium
{
    public class InsertIntoABinarySearchTreeSolution
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
        
        //https://leetcode.com/problems/insert-into-a-binary-search-tree
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }

            if (root.val == val)
            {
                return root;
            }

            if (root.val > val)
            {
                root.left = InsertIntoBST(root.left, val);
            }
            else
            {
                root.right = InsertIntoBST(root.right, val);
            }

            return root;
        }
    }
}