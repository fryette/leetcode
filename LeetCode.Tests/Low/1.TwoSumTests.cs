using System.Linq;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class TwoSumTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new TwoSumSolution();
            var expected = new[] { 0, 1 };

            //act
            var result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);

            //Assert
            Assert.True(Enumerable.SequenceEqual(expected, result));
        }

        [Fact]
        public void Different_positions_should_not_affect_result()
        {
            // Arrange
            var solution = new TwoSumSolution();
            var expected = new[] { 0, 3 };

            //act
            var result = solution.TwoSum(new[] { 2, 11, 15, 7 }, 9);

            //Assert
            Assert.True(Enumerable.SequenceEqual(expected, result));
        }

        [Fact]
        public void Duplications_in_array_should_not_affect_result()
        {
            // Arrange
            var solution = new TwoSumSolution();
            var expected = new[] { 0, 4 };

            //act
            var result = solution.TwoSum(new[] { 2,2, 11, 15, 7 }, 9);

            //Assert
            Assert.True(Enumerable.SequenceEqual(expected, result));
        }
    }
}
