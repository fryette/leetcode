using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class PalindromeNumberTests
    {
        [Fact]
        public void Common_Case_Should_Be_True()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(121);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Common_Case_Should_Be_False()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(1211);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Max_Int_Should_Be_False()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(int.MaxValue);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Odd_Palindrome_Number_Should_Return_True()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(1212121);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void If_Value_Is_10_Should_Return_False()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(10);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void If_Positive_Value_Less_Then_10_Should_Return_True()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var oneResult = solution.IsPalindrome(1);
            var twoResult = solution.IsPalindrome(2);
            var sevenResult = solution.IsPalindrome(7);
            var nineResult = solution.IsPalindrome(9);

            //Assert
            Assert.True(oneResult);
            Assert.True(twoResult);
            Assert.True(sevenResult);
            Assert.True(nineResult);
        }

        [Fact]
        public void If_Negative_Value_Should_Return_False()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(-11);

            //Assert
            Assert.False(result);
        }
        
        [Fact]
        public void If_Negative_One_Digit_Value_Should_Return_False()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(-1);

            //Assert
            Assert.False(result);
        }
    }
}
