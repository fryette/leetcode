using LeetCode.Solutions.Medium;
using Xunit;
using TreeNode = LeetCode.Solutions.Medium.InsertIntoABinarySearchTreeSolution.TreeNode;

namespace LeetCode.Tests.Medium
{
    public class BinaryTreePruningTests
    {
        [Fact]
        public void Common_Case()
        {
            // Arrange
            var solution = new InsertIntoABinarySearchTreeSolution();

            var treeNode = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(7)
            };
            //act
            var result = solution.InsertIntoBST(treeNode, 5);

            //Assert
            //Assert.Equal("aba", result);
        }
    }
}