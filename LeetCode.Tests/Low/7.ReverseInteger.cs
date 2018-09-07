using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class ReverseIntegerTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new ReverseIntegerSolution();
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
            var solution = new ReverseIntegerSolution();
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
            var solution = new ReverseIntegerSolution();
            var expected = 21;

            //act
            var result = solution.Reverse(120);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Zero_Number()
        {
            // Arrange
            var solution = new ReverseIntegerSolution();
            var expected = 0;

            //act
            var result = solution.Reverse(0);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Reversed_number_bigger_then_max_int_should_return_zero()
        {
            // Arrange
            var solution = new ReverseIntegerSolution();
            var expected = 0;

            //act
            var result = solution.Reverse(1534236469);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
