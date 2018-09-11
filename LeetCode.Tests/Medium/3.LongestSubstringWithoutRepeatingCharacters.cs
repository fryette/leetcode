using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new LongestSubstringWithoutRepeatingCharactersSolution();
            var expected = 6;

            //act
            var result = solution.LengthOfLongestSubstring("abcdefdc");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void One_Letter_Result()
        {
            // Arrange
            var solution = new LongestSubstringWithoutRepeatingCharactersSolution();
            var expected = 1;

            //act
            var result = solution.LengthOfLongestSubstring("bbbbbbb");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Zero_Length()
        {
            // Arrange
            var solution = new LongestSubstringWithoutRepeatingCharactersSolution();
            var expected = 0;

            //act
            var result = solution.LengthOfLongestSubstring("");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Second_Part_Is_Right_Sub_String()
        {
            // Arrange
            var solution = new LongestSubstringWithoutRepeatingCharactersSolution();
            var expected = 5;

            //act
            var result = solution.LengthOfLongestSubstring("abcdabcde");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_With_Duplicate_Chars()
        {
            // Arrange
            var solution = new LongestSubstringWithoutRepeatingCharactersSolution();
            var expected = 3;

            //act
            var result = solution.LengthOfLongestSubstring("pwwkew");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Duplications_In_Beginning()
        {
            // Arrange
            var solution = new LongestSubstringWithoutRepeatingCharactersSolution();
            var expected = 2;

            //act
            var result = solution.LengthOfLongestSubstring("aab");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Last_Part_Is_Longest_Substring()
        {
            // Arrange
            var solution = new LongestSubstringWithoutRepeatingCharactersSolution();
            var expected = 8;

            //act
            var result = solution.LengthOfLongestSubstring("abcabcdefrabcdefrt");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Last_Part_Is_Longest_Substring2()
        {
            // Arrange
            var solution = new LongestSubstringWithoutRepeatingCharactersSolution();
            var expected = 3;

            //act
            var result = solution.LengthOfLongestSubstring("abac");

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
