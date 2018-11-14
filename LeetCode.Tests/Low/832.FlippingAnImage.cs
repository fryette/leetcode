using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class FlippingAnImage
    {
        [Fact]
        public void Image_Should_Flipped_Properly()
        {
            // Arrange
            var solution = new FlippingAnImageSolution();
            var expected = new[] {new[] {1, 1, 0, 0}, new[] {0, 1, 1, 0}, new[] {0, 0, 0, 1}, new[] {1, 0, 1, 0}};
            
            //act
            var result = solution.FlipAndInvertImage(new[]
                {new[] {1, 1, 0, 0}, new[] {1, 0, 0, 1}, new[] {0, 1, 1, 1}, new[] {1, 0, 1, 0}});

            //Assert
            Assert.Equal(expected, result);
        }
    }
}