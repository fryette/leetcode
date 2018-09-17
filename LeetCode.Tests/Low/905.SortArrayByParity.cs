using System.Linq;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class SortArrayByParityTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new SortArrayByParitySolution();

            //act
            var result = solution.SortArrayByParity(new[] {3, 1, 2, 4});

            //Assert
            Assert.True(result.SequenceEqual(new[] {2, 4, 3, 1}));
        }

        [Fact]
        public void Empty_Array()
        {
            // Arrange
            var solution = new SortArrayByParitySolution();

            //act
            var result = solution.SortArrayByParity(new int[] { });

            //Assert
            Assert.True(result.SequenceEqual(new int[] { }));
        }
    }
}