using LeetCode.Solutions.High;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class BinarySearchTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new BinarySearch();

            //act
            var result = solution.Search(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 8);

            //Assert
            Assert.Equal(7, result);
        }
    }
}