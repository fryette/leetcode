using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class SearchInRotatedSortedArrayII
    {
        [Fact]
        public void Search_In_Rotated_Array()
        {
            // Arrange
            var solution = new SearchInRotatedSortedArrayIISolution();

            //act
            var result = solution.Search(new[] {4, 5, 6, 1, 2, 3}, 5);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Search_In_Sorted_Array()
        {
            // Arrange
            var solution = new SearchInRotatedSortedArrayIISolution();

            //act
            var result = solution.Search(new[] {1, 2, 3, 4, 5, 6}, 5);

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Search_In_Sorted_Array_Without_Proper_Value()
        {
            // Arrange
            var solution = new SearchInRotatedSortedArrayIISolution();

            //act
            var result = solution.Search(new[] {1, 2, 3, 4, 5, 6}, 7);

            //Assert
            Assert.Equal(-1, result);
        }
        
        [Fact]
        public void Search_In_Rotated_Array_Proper_Value_In_Right_Part_Of_Array()
        {
            // Arrange
            var solution = new SearchInRotatedSortedArrayIISolution();

            //act
            var result = solution.Search(new[] {4,5,6,7,0,1,2}, 0);

            //Assert
            Assert.Equal(4, result);
        }
    }
}