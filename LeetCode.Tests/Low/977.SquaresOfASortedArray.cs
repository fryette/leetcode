using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class SquaresOfASortedArrayTests
    {
        [Fact]
        public void Different_Positions_Should_Not_Affect_Result()
        {
            // Arrange
            var solution = new SquaresOfASortedArraySolution();
            var expected = new[] {1, 1, 4, 9};

            //act
            var result = solution.SortedSquares(new[] {-1, 1, 2, 3});

            //Assert
            for (var i = 0; i < result.Length; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}