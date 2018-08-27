using ReverseInteger;
using Xunit;

namespace Leetcode.UnitTests
{
    public class ReverseIntegerTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new ReverseSolution();
            var expected = 321;

            //act
            var result = solution.Reverse(123);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Negative_Number()
        {
            // Arrange
            var solution = new ReverseSolution();
            var expected = -321;

            //act
            var result = solution.Reverse(-123);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Zero_End()
        {
            // Arrange
            var solution = new ReverseSolution();
            var expected = 21;

            //act
            var result = solution.Reverse(120);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Zer_Number()
        {
            // Arrange
            var solution = new ReverseSolution();
            var expected = 0;

            //act
            var result = solution.Reverse(0);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}