using System;
using LeetCode.Solutions.Low;
using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class FindMinimumInRotatedSortedArray
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new FindMinimumInRotatedSortedArraySolution();
            var expected = 1;

            //act
            var result = solution.FindMin(new int[] { 3, 4, 5, 1, 2 });

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Common_Test2()
        {
            // Arrange
            var solution = new FindMinimumInRotatedSortedArraySolution();
            var expected = 0;

            //act
            var result = solution.FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 });

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Two_Values()
        {
            // Arrange
            var solution = new FindMinimumInRotatedSortedArraySolution();
            var expected = 0;

            //act
            var result = solution.FindMin(new int[] { 0, 1 });

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Even_Number_Count()
        {
            // Arrange
            var solution = new FindMinimumInRotatedSortedArraySolution();
            var expected = 0;

            //act
            var result = solution.FindMin(new int[] { 0, 1, 2, 3 });

            //Assert
            Assert.Equal(expected, result);
        }

                [Fact]
        public void Odd_Number_Count()
        {
            // Arrange
            var solution = new FindMinimumInRotatedSortedArraySolution();
            var expected = 0;

            //act
            var result = solution.FindMin(new int[] { 0, 1, 2, 5, 3 });

            //Assert
            Assert.Equal(expected, result);
        }
    }
}