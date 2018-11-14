using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class AssignCookiesTests
    {
        [Fact]
        public void Children_Greed_Equals_Cookies_Size()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {1, 2, 3, 4}, new[] {1, 2, 3, 4});

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void All_Cookies_Have_Same_Size()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {1, 2, 3, 4}, new[] {1, 1, 1, 1});

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Some_Children_Have_Same_Greed()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {1, 1, 1, 4}, new[] {1, 1, 2, 1});

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Greed_Bigger_Then_Cookie_Size()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {4, 4, 4, 4}, new[] {1, 1, 2, 1});

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Cookie_Size_Bigger_Then_Greed()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {1, 1, 1, 1}, new[] {4, 4, 4, 4});

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Array_Of_Greed_Is_Empty()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new int[] { }, new[] {4, 4, 4, 4});

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Array_Of_Cookie_Is_Empty()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {1, 1, 1, 1}, new int[] { });

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Different_Number_Of_Cookies_And_Children_Greed()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {1, 1}, new[] {1, 2, 3, 4});

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Different_Number_Of_Cookies_And_Children_Greed1()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {1, 2, 3}, new[] {1, 2});

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Greed_And_Cookie_Size_Intersect_In_Center()
        {
            // Arrange
            var solution = new AssignCookiesSolution();

            //act
            var result = solution.FindContentChildren(new[] {10, 9, 8, 7}, new[] {5, 6, 7, 8});

            //Assert
            Assert.Equal(2, result);
        }
    }
}