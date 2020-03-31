using System;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class FindPickElementTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new FindPuckElementSolution();
            var expectedResult = new int[] { 1, 5 };
            //act
            var result = solution.FindPeakElement(new int[] { 1, 2, 1, 3, 5, 6, 4 });

            //Assert
            Assert.Contains(result, expectedResult);
        }
    }
}
