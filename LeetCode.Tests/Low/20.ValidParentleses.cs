using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class ValidParentlesesTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("[](){}");

            //Assert
            Assert.True(result);
        }
        [Fact]
        public void Empty_string_should_return_true()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void One_sumbol_should_return_false()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("{");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void One_closed_bracket_should_return_false()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("]");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Invalid_open_close_brackets_should_return_false()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("{(})");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Nested_brackets_should_return_true()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("{()}");

            //Assert
            Assert.True(result);
        }
    }
}