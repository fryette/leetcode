using System;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class FindTheDifferenceTests
    {
		[Fact]
        public void Common_Test()
        {
            // Arrange
			var solution = new FindTheDifferenceSolution();
            var expected = 'e';

            //act
			var result = solution.FindTheDifference("abcd", "abecd");

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
