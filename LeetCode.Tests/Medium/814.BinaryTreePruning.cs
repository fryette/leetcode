using LeetCode.Solutions.Medium;
using Xunit;
using TreeNode=LeetCode.Solutions.Medium.BinaryTreePruning.TreeNode;
namespace LeetCode.Tests.Medium
{
    public class BinaryTreePruningTests
    {
        [Fact]
        public void Common_Case()
        {
            // Arrange
            var solution = new BinaryTreePruning();

            var treeNode = new TreeNode(1)
            {
                left = new TreeNode(0)
                {
                    left = new TreeNode(1)
                    {
                        left = new TreeNode(1),
                        right = new TreeNode(0)
                        {
                            left = new TreeNode(0)
                            {
                                left = new TreeNode(1),
                                right = new TreeNode(0)
                            }
                        }
                    },
                    right = new TreeNode(0)
                },
                right = new TreeNode(1)
                {
                    left = new TreeNode(1)
                    {
                        left = new TreeNode(0),
                        right = new TreeNode(1)
                    },
                    right = new TreeNode(0)
                    {
                        left = new TreeNode(0)
                        {
                            left = new TreeNode(0),
                            right = new TreeNode(0)
                        },
                        right = new TreeNode(0)
                        {
                            left = new TreeNode(0),
                            right = new TreeNode(0)
                        }
                    }
                }
            };
            //act
            var result = solution.PruneTree(treeNode);

            //Assert
            //Assert.Equal("aba", result);
        }
    }
}