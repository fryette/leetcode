using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class PeakIndexInAMountainArrayTests
    {
        [Fact]
        public void Should_Return_Proper_Index()
        {
            // Arrange
            var solution = new PeakIndexInAMountainArraySolution();

            //act
            var result = solution.PeakIndexInMountainArray(new[] {1,2,3,4,5,6,8,7,6,5,4,3,2,1,0});

            //Assert
            Assert.Equal(6, result);
        }
    }
}