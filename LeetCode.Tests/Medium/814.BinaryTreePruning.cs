using LeetCode.Solutions.Medium;
using Xunit;
using TreeNode = LeetCode.Solutions.Medium.MergeTwoBinaryTreesSolution.TreeNode;

namespace LeetCode.Tests.Medium
{
    public class BinaryTreePruningTests
    {
        [Fact]
        public void Common_Case()
        {
            // Arrange
            var solution = new MergeTwoBinaryTreesSolution();

            var treeNode = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(7)
            };

            var treeNode1 = new TreeNode(4)
            {
                left = new TreeNode(2),
                right = new TreeNode(7)
                {
                    left = new TreeNode(9),
                    right = new TreeNode(3)
                },
            };
            //act
            var result = solution.MergeTrees(treeNode, treeNode1);

            //Assert
            //Assert.Equal("aba", result);
        }
    }
}