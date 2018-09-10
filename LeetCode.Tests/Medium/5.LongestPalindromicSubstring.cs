using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class LongestPalindromicSubstringTests
    {
        [Fact]
        public void Empty_String_Should_Return_Empty_String()
        {
            // Arrange
            var solution = new LongestPalindromicSubstringSolution();

            //act
            var result = solution.LongestPalindrome("babad");

            //Assert
            Assert.Equal("aba", result);
        }
        
        [Fact]
        public void Common_Test_Should_Return_Proper_Result()
        {
            // Arrange
            var solution = new LongestPalindromicSubstringSolution();

            //act
            var result = solution.LongestPalindrome("babad");

            //Assert
            Assert.Equal("aba", result);
        }

        [Fact]
        public void Common_Test_Should_Return_Proper_Result1()
        {
            // Arrange
            var solution = new LongestPalindromicSubstringSolution();

            //act
            var result = solution.LongestPalindrome("cbbd");

            //Assert
            Assert.Equal("bb", result);
        }
    }
}