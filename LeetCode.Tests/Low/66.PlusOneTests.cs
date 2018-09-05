using System.Linq;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class PlusOneTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new PlusOneSolution();
            var expected = new[] {1, 2, 4};

            //act
            var result = solution.PlusOne(new[] {1, 2, 3});

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void Last_Digit_Is_9()
        {
            // Arrange
            var solution = new PlusOneSolution();
            var expected = new[] {1, 3, 0};

            //act
            var result = solution.PlusOne(new[] {1, 2, 9});

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void All_Values_Is_9()
        {
            // Arrange
            var solution = new PlusOneSolution();
            var expected = new[] {1, 0, 0, 0};

            //act
            var result = solution.PlusOne(new[] {9, 9, 9});

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }

        [Fact]
        public void One_Values_Is_0()
        {
            // Arrange
            var solution = new PlusOneSolution();
            var expected = new[] {1};

            //act
            var result = solution.PlusOne(new[] {0});

            //Assert
            Assert.True(expected.SequenceEqual(result));
        }
    }
}