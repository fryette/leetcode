using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class FindAndReplacePatternTests
    {
        [Fact]
        public void Pattern_Has_Few_Same_Letters()
        {
            // Arrange
            var solution = new FindAndReplacePatternSolution();

            //act
            var result = solution.FindAndReplacePattern(new[] {"abc", "deq", "mee", "aqq", "dkd", "ccc"}, "abb");

            //Assert
            Assert.Equal(new[] {"mee", "aqq"}, result);
        }
        
        [Fact]
        public void All_Letters_In_Pattern_Different()
        {
            // Arrange
            var solution = new FindAndReplacePatternSolution();

            //act
            var result = solution.FindAndReplacePattern(new[] {"abc","cba","xyx","yxx","yyx"}, "abc");

            //Assert
            Assert.Equal(new[] {"abc","cba"}, result);
        }
    }
}