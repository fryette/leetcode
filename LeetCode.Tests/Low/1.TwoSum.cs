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
            var expected = new[] {0, 1};

            //act
            var result = solution.TwoSum(new[] {2, 7, 11, 15}, 9);

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void Different_Positions_Should_Not_Affect_Result()
        {
            // Arrange
            var solution = new TwoSumSolution();
            var expected = new[] {0, 3};

            //act
            var result = solution.TwoSum(new[] {2, 11, 15, 7}, 9);

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void Duplications_In_Array_Should_Not_Affect_Result()
        {
            // Arrange
            var solution = new TwoSumSolution();
            var expected = new[] {0, 4};

            //act
            var result = solution.TwoSum(new[] {2, 2, 11, 15, 7}, 9);

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }
    }
}