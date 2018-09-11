using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class ToLowerCaseTests
    {
        [Fact]
        public void Only_First_Character_Is_Capital_Should_Return_All_LowerCase()
        {
            // Arrange
            var solution = new ToLowerCaseSolution();

            //act
            var result = solution.ToLowerCase("Hello");

            //Assert
            Assert.Equal("hello", result);
        }

        [Fact]
        public void All_Characters_Is_LowerCase_Should_Return_All_LowerCase()
        {
            // Arrange
            var solution = new ToLowerCaseSolution();

            //act
            var result = solution.ToLowerCase("hello");

            //Assert
            Assert.Equal("hello", result);
        }

        [Fact]
        public void All_Characters_Is_Capital_Should_Return_All_LowerCase()
        {
            // Arrange
            var solution = new ToLowerCaseSolution();

            //act
            var result = solution.ToLowerCase("HELLO");

            //Assert
            Assert.Equal("hello", result);
        }

        [Fact]
        public void Empty_String_Should_Return_Empty_String()
        {
            // Arrange
            var solution = new ToLowerCaseSolution();

            //act
            var result = solution.ToLowerCase(string.Empty);

            //Assert
            Assert.Equal(string.Empty, result);
        }
    }
}