using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class FindKClosestElementsTests
    {
        [Fact]
        public void Common_Case()
        {
            // Arrange
            var solution = new FindKClosestElementsSolution();

            //act
            var result = solution.FindClosestElements(new[] { 1, 2, 3, 4, 5 }, 4, 3);

            //Assert
            Assert.Equal(new int[] { 1, 2, 3, 4 }, result);
        }

        [Fact]
        public void X_Not_Present()
        {
            // Arrange
            var solution = new FindKClosestElementsSolution();

            //act
            var result = solution.FindClosestElements(new[] { 0, 1, 1, 1, 2, 3, 6, 7, 8, 9 }, 9, 4);

            //Assert
            Assert.Equal(new int[] { 0, 1, 1, 1, 2, 3, 6, 7, 8 }, result);
        }

        [Fact]
        public void X_Not_Present_Left_And_Right_Has_Same_Equality()
        {
            // Arrange
            var solution = new FindKClosestElementsSolution();

            //act
            var result = solution.FindClosestElements(new[] { 0, 0, 1, 2, 3, 3, 4, 7, 7, 8 }, 3, 5);

            //Assert
            Assert.Equal(new int[] { 3, 3, 4 }, result);
        }

        [Fact]
        public void Small_List_X_Not_Present()
        {
            // Arrange
            var solution = new FindKClosestElementsSolution();

            //act
            var result = solution.FindClosestElements(new[] { 1, 2 }, 2, 5);

            //Assert
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void Small_List_X_Present()
        {
            // Arrange
            var solution = new FindKClosestElementsSolution();

            //act
            var result = solution.FindClosestElements(new[] { 1, 2 }, 2, 2);

            //Assert
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void X_Not_Present_3_Zeros_From_Start()
        {
            // Arrange
            var solution = new FindKClosestElementsSolution();

            //act
            var result = solution.FindClosestElements(new[] { 0, 0, 0, 1, 3, 5, 6, 7, 8, 8 }, 2, 2);

            //Assert
            Assert.Equal(new int[] { 1, 3 }, result);
        }

        [Fact]
        public void X_Present_Few_Times()
        {
            // Arrange
            var solution = new FindKClosestElementsSolution();

            //act
            var result = solution.FindClosestElements(new[] { 1,2,5,5,6,6,7,7,8,9 }, 7, 7);

            //Assert
            Assert.Equal(new int[] { 5,5,6,6,7,7,8 }, result);
        }
    }
}