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
        public void Empty_First_Massive_Item_Result_Should_Be_Empty_String()
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
