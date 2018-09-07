using System.Collections.Generic;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class ImplementStrStrTests
    {
        [Fact]
        public void Common_Test_Should_Return_Proper_Result()
        {
            // Arrange
            var solution = new ImplementStrStrSolution();
            var expected = 2;

            //act
            var result = solution.StrStr("hello", "ll");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Common_Test_Should_Return_Not_Found_Result()
        {
            // Arrange
            var solution = new ImplementStrStrSolution();
            var expected = -1;

            //act
            var result = solution.StrStr("aaaaa", "bba");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Empty_String_Should_Return_Zero()
        {
            // Arrange
            var solution = new ImplementStrStrSolution();
            var expected = 0;

            //act
            var result = solution.StrStr("bba", string.Empty);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Empty_Haystack_Should_Return_Not_Found()
        {
            // Arrange
            var solution = new ImplementStrStrSolution();
            var expected = -1;

            //act
            var result = solution.StrStr(string.Empty, "bba");

            //Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void One_Character_In_Both_Strings_Should_Return_Proper_Result()
        {
            // Arrange
            var solution = new ImplementStrStrSolution();
            var expected = 0;

            //act
            var result = solution.StrStr("a", "a");

            //Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Common_Case_2_Should_Return_Proper_Result()
        {
            // Arrange
            var solution = new ImplementStrStrSolution();
            var expected = 9;

            //act
            var result = solution.StrStr("mississippi", "pi");

            //Assert
            Assert.Equal(expected, result);
        }
    }
}