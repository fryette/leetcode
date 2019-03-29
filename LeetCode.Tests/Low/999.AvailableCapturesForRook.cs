using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class AvailableCapturesForRookTests
    {
        [Fact]
        public void Common_Case()
        {
            var solution = new AvailableCapturesForRookSolution();
            var board = new[]
            {
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'R', '.', '.', '.', 'p'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'}
            };

            var result = solution.NumRookCaptures(board);

            Assert.Equal(3, result);
        }
    }
}