using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class MissingNumberTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new MissingNumberSolution();

            //act
            var result = solution.MissingNumber(new[] {1, 2, 3});

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void If_No_Missing_Numbers_Should_Return_Next()
        {
            // Arrange
            var solution = new MissingNumberSolution();

            //act
            var result = solution.MissingNumber(new[] {3, 2, 0, 1});

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Zero_Single_Should_Return_Next()
        {
            // Arrange
            var solution = new MissingNumberSolution();

            //act
            var result = solution.MissingNumber(new[] {0});

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void One_Single_Digit_Which_Less_Then_One_Return_Zero()
        {
            // Arrange
            var solution = new MissingNumberSolution();

            //act
            var result = solution.MissingNumber(new[] {1});

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Sequence_With_Zero_Return_Missed_Item()
        {
            // Arrange
            var solution = new MissingNumberSolution();

            //act
            var result = solution.MissingNumber(new[] {3, 0, 1});

            //Assert
            Assert.Equal(2, result);
        }
    }
}