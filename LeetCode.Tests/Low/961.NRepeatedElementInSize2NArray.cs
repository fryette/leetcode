using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class NRepeatedElementInSize2NArrayTests
    {
        [Fact]
        public void Repeated_Number_At_Start_And_End()
        {
            // Arrange
            var solution = new NRepeatedElementInSize2NArray();

            //act
            var result = solution.RepeatedNTimes(new[] {9,5,6,9});

            //Assert
            Assert.Equal(9, result);
        }
    }
}