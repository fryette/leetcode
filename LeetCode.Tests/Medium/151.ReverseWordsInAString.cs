using System;
using LeetCode.Solutions.Low;
using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class ReverseWordsInAStringTests
    {
        [Fact]
        public void Common_Test_Should_Return_Proper_Result()
        {
            // Arrange
            var solution = new ReverseWordsInAStringSolution();
            var expected = "blue is sky the";

            //act
            var result = solution.ReverseWords("the sky is blue");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void String_With_Few_Leading_And_Trailing_Spaces()
        {
            // Arrange
            var solution = new ReverseWordsInAStringSolution();
            var expected = "blue is sky the";

            //act
            var result = solution.ReverseWords(" the sky is blue ");

            //Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void String_With_Few_Spaces_In_The_Middle_Of_The_String()
        {
            // Arrange
            var solution = new ReverseWordsInAStringSolution();
            var expected = "blue is sky the";

            //act
            var result = solution.ReverseWords("the sky is   blue");

            //Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void One_Word_Int_String()
        {
            // Arrange
            var solution = new ReverseWordsInAStringSolution();
            var expected = "blue";

            //act
            var result = solution.ReverseWords("blue");

            //Assert
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Empty_String_Should_Return_Empty_String()
        {
            // Arrange
            var solution = new ReverseWordsInAStringSolution();
            var expected = string.Empty;

            //act
            var result = solution.ReverseWords(string.Empty);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}