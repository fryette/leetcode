using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class UniqMorseCodeWordsTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new UniqueMorseCodeWordsSolution();

            //act
            var result = solution.UniqueMorseRepresentations(new[] {"gin", "zen", "gig", "msg"});

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Empty_Array_Should_Return_Zero()
        {
            // Arrange
            var solution = new UniqueMorseCodeWordsSolution();

            //act
            var result = solution.UniqueMorseRepresentations(new string[] { });

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Array_With_Empty_Strings_Should_Return_1()
        {
            // Arrange
            var solution = new UniqueMorseCodeWordsSolution();

            //act
            var result = solution.UniqueMorseRepresentations(new[] {string.Empty, string.Empty});

            //Assert
            Assert.Equal(1, result);
        }
    }
}