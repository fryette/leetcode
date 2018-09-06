using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class ValidPalindromeTests
    {
        [Fact]
        public void Palindrome_Should_Return_True()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("A man, a plan, a canal: Panama");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void String_Should_Return_False()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("race a car");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Empty_String_Should_Return_False()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome(string.Empty);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Two_Different_Symbols_Should_Return_False()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("ab");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Two_Different_NonAlphanumeric_Symbols_Should_Return_True()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("..");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Two_Different_Symbols_Where_One_Of_Them_Non_Letter_Should_Return_True()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome("a.");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void One_Empty_Symbol_Should_Return_True()
        {
            // Arrange
            var solution = new ValidPalindromeSolution();

            //act
            var result = solution.IsPalindrome(" ");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Only_NonAlphaNumeric_Symbols_In_String_Should_Return_True()
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