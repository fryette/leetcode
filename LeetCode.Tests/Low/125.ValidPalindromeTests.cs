using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class ValidPalindromeTests
    {
        [Fact]
        public void Palindrome_should_return_true()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("A man, a plan, a canal: Panama");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void String_should_return_false()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("race a car");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Empty_string_should_return_false()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome(string.Empty);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Two_different_symbols_should_return_false()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("ab");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Two_different_NonAphanumeric_symbols_should_return_true()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("..");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Two_different_symbols_where_one_of_them_non_letter_should_return_true()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("a.");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void One_empty_symbol_should_return_true()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome(" ");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Only_NonAlphaNumeric_symbols_in__string_should_return_true()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("... . .");

            //Assert
            Assert.True(result);
        }
    }
}
