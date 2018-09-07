using LeetCode.Solutions.High;
using Xunit;

namespace LeetCode.Tests.High
{
    public class MedianOfTwoSortedArraysTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new MedianOfTwoSortedArrays();
            var expected = 2;

            //act
            var result = solution.FindMedianSortedArrays(new[] { 1,2,3 }, new[] { 1,2,4,5 });

            //Assert
            Assert.Equal(expected, result);
        }
    }
}