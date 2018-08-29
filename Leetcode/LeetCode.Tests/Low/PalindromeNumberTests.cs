using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class PalindromeNumberTests
    {
        [Fact]
        public void Common_case_should_be_true()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(121);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Common_case_should_be_false()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(1211);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Max_int_should_be_false()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(int.MaxValue);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Odd_polindrome_number_should_return_true()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(1212121);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void If_value_is_10_should_return_false()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(10);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void If_positive_value_less_then_10_should_return_false()
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
        public void If_negative_value_should_return_false()
        {
            // Arrange
            var solution = new PalindromeNumberSolution();

            //act
            var result = solution.IsPalindrome(int.MinValue);

            //Assert
            Assert.False(result);
        }
    }
}
