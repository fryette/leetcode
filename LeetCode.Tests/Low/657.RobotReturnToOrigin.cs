using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class RobotReturnToOriginTests
    {
        [Fact]
        public void Right_Way_Should_Return_True()
        {
            // Arrange
            var solution = new RobotReturnToOriginSolution();

            //act
            var result = solution.JudgeCircle("URDL");

            //Assert
            Assert.True(result);
        }
        
        [Fact]
        public void Incorrect_Way_Should_Return_False()
        {
            // Arrange
            var solution = new RobotReturnToOriginSolution();

            //act
            var result = solution.JudgeCircle("RDL");

            //Assert
            Assert.False(result);
        }
    }
}