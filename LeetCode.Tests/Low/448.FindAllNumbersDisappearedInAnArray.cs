using System.Collections.Generic;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class FindAllNumbersDisappearedInAnArrayTests
    {
        [Fact]
        public void Common_Case()
        {
            var solution = new FindAllNumbersDisappearedInAnArray();
            var expectedResult = new List<int> { 5, 6 };

            var result = solution.FindDisappearedNumbers(new[] { 4, 3, 2, 7, 8, 2, 3, 1 });

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}
