using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class BulbSwitcherTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new BulbSwitcherSolution();

            //act
            var result = solution.BulbSwitch(3);

            //Assert
            Assert.Equal(1, result);
        }
    }
}