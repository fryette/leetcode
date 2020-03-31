using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class NumberOfRecentCallsTests
    {
        [Fact]
        public void CommonCase()
        {
            var solution = new RecentCounter();

            var result = solution.Ping(1);
            Assert.Equal(1, result);

            result = solution.Ping(100);
            Assert.Equal(2, result);

            result = solution.Ping(3001);
            Assert.Equal(3, result);

            result = solution.Ping(3002);
            Assert.Equal(3, result);
        }
    }
}