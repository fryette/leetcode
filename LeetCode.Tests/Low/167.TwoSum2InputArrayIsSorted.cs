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
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void Different_Positions_Should_Not_Affect_Result()
        {
            // Arrange
            var solution = new TwoSum2InputArrayIsSortedSolution();
            var expected = new[] { 1, 3 };

            //act
            var result = solution.TwoSum(new[] { 2, 5, 7, 11, 15 }, 9);

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void Duplications_In_Array_Should_Not_Affect_Result()
        {
            // Arrange
            var solution = new TwoSum2InputArrayIsSortedSolution();
            var expected = new[] { 1, 3 };

            //act
            var result = solution.TwoSum(new[] { 2, 2, 7, 11, 15 }, 9);

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void Right_Numbers_At_The_Boarder()
        {
            // Arrange
            var solution = new TwoSum2InputArrayIsSortedSolution();
            var expected = new[] { 2, 3 };

            //act
            var result = solution.TwoSum(new[] { 5, 25, 75 }, 100);

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }
    }
}
