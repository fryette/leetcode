using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class JewelsAndStonesTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new JewelsAndStonesSolution();

            //act
            var result = solution.NumJewelsInStones("aA", "aAAbbbb");

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void No_Matched_Items_Should_Return_Zero()
        {
            // Arrange
            var solution = new JewelsAndStonesSolution();

            //act
            var result = solution.NumJewelsInStones("z", "ZZ");

            //Assert
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Empty_String_For_First_Argument_Should_Return_Zero()
        {
            // Arrange
            var solution = new JewelsAndStonesSolution();

            //act
            var result = solution.NumJewelsInStones(string.Empty, "ZZ");

            //Assert
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Empty_String_For_Second_Argument_Should_Return_Zero()
        {
            // Arrange
            var solution = new JewelsAndStonesSolution();

            //act
            var result = solution.NumJewelsInStones("z", string.Empty);

            //Assert
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Empty_String_For_Both_Arguments_Should_Return_Zero()
        {
            // Arrange
            var solution = new JewelsAndStonesSolution();

            //act
            var result = solution.NumJewelsInStones(string.Empty,string.Empty);

            //Assert
            Assert.Equal(0, result);
        }
    }
}