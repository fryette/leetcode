using System;
using LeetCode.Solutions.Low;
using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class FindFirstAndLastPositionOfElementInSortedArrayTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new FindFirstAndLastPositionOfElementInSortedArraySolution();
            var expected = new int[] { 3, 4 };

            //act
            var result = solution.SearchRange(new int[] { 5, 7, 7, 8, 8, 10 }, 8);


            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Two_Number_Length_First_Right()
        {
            // Arrange
            var solution = new FindFirstAndLastPositionOfElementInSortedArraySolution();
            var expected = new int[] { 0, 0 };

            //act
            var result = solution.SearchRange(new int[] { 0, 1 }, 0);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Two_Number_Length_Second_Right()
        {
            // Arrange
            var solution = new FindFirstAndLastPositionOfElementInSortedArraySolution();
            var expected = new int[] { 1, 1 };

            //act
            var result = solution.SearchRange(new int[] { 0, 1 }, 1);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Two_Number_Length_Both_Right()
        {
            // Arrange
            var solution = new FindFirstAndLastPositionOfElementInSortedArraySolution();
            var expected = new int[] { 0, 1 };

            //act
            var result = solution.SearchRange(new int[] { 1, 1 }, 1);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Not_Found()
        {
            // Arrange
            var solution = new FindFirstAndLastPositionOfElementInSortedArraySolution();
            var expected = new int[] { -1, -1 };

            //act
            var result = solution.SearchRange(new int[] { 0, 1, 2, 3, 4, 5, 7, 7, 8, 8 }, 6);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Not_Found_In_Small_Array()
        {
            // Arrange
            var solution = new FindFirstAndLastPositionOfElementInSortedArraySolution();
            var expected = new int[] { -1, -1 };

            //act
            var result = solution.SearchRange(new int[] { 2, 2 }, 6);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}