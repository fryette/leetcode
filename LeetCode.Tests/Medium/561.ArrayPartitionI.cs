using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class ArrayPartitionITests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new ArrayPartitionISolution();

            //act
            var result = solution.ArrayPairSum(new[] {5, 1, 6, 2, 4, 3});

            //Assert
            Assert.Equal(9, result);
        }
    }
}