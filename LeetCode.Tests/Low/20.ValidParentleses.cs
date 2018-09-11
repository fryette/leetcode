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
        public void Empty_String_Should_Return_True()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void One_Symbol_Should_Return_False()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("{");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void One_Closed_Bracket_Should_Return_False()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("]");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Invalid_Open_Close_Brackets_Should_Return_False()
        {
            // Arrange
            var solution = new ValidParenthesesSolution();

            //act
            var result = solution.IsValid("{(})");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Nested_Brackets_Should_Return_True()
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