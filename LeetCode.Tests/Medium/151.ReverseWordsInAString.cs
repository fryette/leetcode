using System;
using LeetCode.Solutions.Low;
using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class ReverseWordsInAStringTests
    {
        [Fact]
        public void Common_test_should_return_proper_result()
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
        public void String_with_few_leading_and_trailing_spaces()
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
        public void String_with_few_spaces_in_the_middle_of_the_string()
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
        public void One_word_int_string()
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
        public void Empty_string_should_return_empty_string()
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