using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class MinimumAddToMakeParenthesesValidTests
    {
        [Fact]
        public void All_Parentheses_Closed()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid("()");

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Parentheses_With_Internal_Closed()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid("(())");

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void One_Open_Brace_Lacking()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid(")");

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void One_Close_Brace_Lacking()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid("(");

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Start_With_Close_Brace()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid(")()");

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Lacking_One_Open_And_Close_Bracket()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid(")(()");

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Open_Brace_After_Few_Parentheses()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid("()(((");

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Closed_Brace_After_Few_Parentheses()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid("(()(");

            //Assert
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void Few_Parentheses_In_Parentheses()
        {
            // Arrange
            var solution = new MinimumAddToMakeParenthesesValidSolution();

            //act
            var result = solution.MinAddToMakeValid("(()())((");

            //Assert
            Assert.Equal(2, result);
        }
    }
}