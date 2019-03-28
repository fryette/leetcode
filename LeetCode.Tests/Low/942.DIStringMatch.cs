using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class DIStringMatchTests
    {
        [Fact]
        public void DDD()
        {
            var solution = new DIStringMatchSolution();
            var expected = new[] {3, 2, 1, 0};

            var result = solution.DiStringMatch("DDD");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void D()
        {
            var solution = new DIStringMatchSolution();
            var expected = new[] {1, 0};

            var result = solution.DiStringMatch("D");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void III()
        {
            var solution = new DIStringMatchSolution();
            var expected = new[] {0, 1, 2, 3};

            var result = solution.DiStringMatch("III");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void I()
        {
            var solution = new DIStringMatchSolution();
            var expected = new[] {0, 1};

            var result = solution.DiStringMatch("I");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DI()
        {
            var solution = new DIStringMatchSolution();
            var expected = new[] {2, 0, 1};

            var result = solution.DiStringMatch("DI");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ID()
        {
            var solution = new DIStringMatchSolution();
            var expected = new[] {0, 2, 1};

            var result = solution.DiStringMatch("ID");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DDDIDIDII()
        {
            var solution = new DIStringMatchSolution();
            var expected = new[] {9, 8, 7, 0, 6, 1, 5, 2, 3, 4};

            var result = solution.DiStringMatch("DDDIDIDII");

            Assert.Equal(expected, result);
        }
    }
}