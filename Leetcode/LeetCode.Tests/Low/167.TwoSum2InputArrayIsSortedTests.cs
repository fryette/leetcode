using System.Linq;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class TwoSum2InputArrayIsSortedTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new TwoSum2InputArrayIsSortedSolution();
            var expected = new[] { 1, 2 };

            //act
            var result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);

            //Assert
            Assert.True(Enumerable.SequenceEqual(expected, result));
        }

        [Fact]
        public void Different_positions_should_not_affect_result()
        {
            // Arrange
            var solution = new TwoSum2InputArrayIsSortedSolution();
            var expected = new[] { 1, 3 };

            //act
            var result = solution.TwoSum(new[] { 2, 5, 7, 11, 15 }, 9);

            //Assert
            Assert.True(Enumerable.SequenceEqual(expected, result));
        }

        [Fact]
        public void Duplications_in_array_should_not_affect_result()
        {
            // Arrange
            var solution = new TwoSum2InputArrayIsSortedSolution();
            var expected = new[] { 1, 3 };

            //act
            var result = solution.TwoSum(new[] { 2, 2, 7, 11, 15 }, 9);

            //Assert
            Assert.True(Enumerable.SequenceEqual(expected, result));
        }

        [Fact]
        public void Right_numbers_at_the_boarder()
        {
            // Arrange
            var solution = new TwoSum2InputArrayIsSortedSolution();
            var expected = new[] { 2, 3 };

            //act
            var result = solution.TwoSum(new[] { 5, 25, 75 }, 100);

            //Assert
            Assert.True(Enumerable.SequenceEqual(expected, result));
        }
    }
}
