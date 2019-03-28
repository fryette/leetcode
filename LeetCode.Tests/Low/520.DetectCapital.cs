using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class DetectCapitalTests
    {
        [Fact]
        public void First_Character_Upper_Other_Lower()
        {
            var solution = new DetectCapital();

            var result = solution.DetectCapitalUse("Asupertest");

            Assert.True(result);
        }

        [Fact]
        public void All_Characters_Upper()
        {
            var solution = new DetectCapital();

            var result = solution.DetectCapitalUse("USA");

            Assert.True(result);
        }

        [Fact]
        public void All_Characters_Lower()
        {
            var solution = new DetectCapital();

            var result = solution.DetectCapitalUse("usa");

            Assert.True(result);
        }

        [Fact]
        public void One_Character_Upper_Case()
        {
            var solution = new DetectCapital();

            var result = solution.DetectCapitalUse("A");

            Assert.True(result);
        }

        [Fact]
        public void One_Character_Lower_Case()
        {
            var solution = new DetectCapital();

            var result = solution.DetectCapitalUse("a");

            Assert.True(result);
        }

        [Fact]
        public void First_Character_Upper_Last_Character_Upper()
        {
            var solution = new DetectCapital();

            var result = solution.DetectCapitalUse("AsupertestB");

            Assert.False(result);
        }

        [Fact]
        public void First_Character_Upper_Center_Character_Upper()
        {
            var solution = new DetectCapital();

            var result = solution.DetectCapitalUse("AsupeRtestb");

            Assert.False(result);
        }

        [Fact]
        public void Last_Character_Upper()
        {
            var solution = new DetectCapital();

            var result = solution.DetectCapitalUse("asupertestB");

            Assert.False(result);
        }
    }
}