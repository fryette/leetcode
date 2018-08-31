using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class LongestCommonPrefixTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new LongestCommonPrefixSolution();

            //act
            var result = solution.LongestCommonPrefix(new string[] { "aa", "a" });

            //Assert
            Assert.Equal("a", result);
        }

        [Fact]
        public void Empty_first_massive_item_result_should_be_empty_string()
        {
            // Arrange
            var solution = new LongestCommonPrefixSolution();

            //act
            var result = solution.LongestCommonPrefix(new string[] { "" });

            //Assert
            Assert.Equal(string.Empty, result);
        }
    }
}
