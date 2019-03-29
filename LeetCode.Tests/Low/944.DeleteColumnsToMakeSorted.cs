using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class DeleteColumnsToMakeSortedTests
    {
        [Fact]
        public void Single_String_Should_Return_0()
        {
            var solution = new DeleteColumnsToMakeSortedSolution();

            var result = solution.MinDeletionSize(new[] {"lkfjhlsdhljk"});

            Assert.Equal(0, result);
        }

        [Fact]
        public void Already_Sorted_Columns_Should_Return_0()
        {
            var solution = new DeleteColumnsToMakeSortedSolution();

            var result = solution.MinDeletionSize(new[] {"a", "b"});

            Assert.Equal(0, result);
        }

        [Fact]
        public void Unsorted_Strings()
        {
            var solution = new DeleteColumnsToMakeSortedSolution();

            var result = solution.MinDeletionSize(new[] {"zyx", "wvu", "tsr"});

            Assert.Equal(3, result);
        }
    }
}