using System.Linq;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class FindCommonCharactersTests
    {
        [Fact]
        public void Common_Case()
        {
            var solution = new FindCommonCharactersSolution();
            var expected = new[] {"e", "l", "l"};

            var result = solution.CommonChars(new[] {"bella", "label", "roller"});

            foreach (var s in result)
            {
                Assert.True(expected.Contains(s));
            }

            Assert.Equal(expected.Length, result.Count);
        }
    }
}