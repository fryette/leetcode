using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class RomanTointegerTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new RomanToIntegerSolution();
            var expected = 4;

            //act
            var result = solution.RomanToInt("IV");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Case_with_next_symbol_checking()
        {
            // Arrange
            var solution = new RomanToIntegerSolution();
            var expected = 1695;

            //act
            var result = solution.RomanToInt("MDCXCV");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_increment_by_one()
        {
            // Arrange
            var solution = new RomanToIntegerSolution();
            var expected = 3;

            //act
            var result = solution.RomanToInt("III");

            //Assert
            Assert.Equal(expected, result);
        }
    }
}