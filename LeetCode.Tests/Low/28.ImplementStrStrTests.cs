using System.Collections.Generic;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class ImplementStrStrTests
    {
        [Fact]
        public void Common_test_should_return_proper_result()
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
        public void Common_test_should_return_not_found_result()
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
        public void Empty_string_should_return_zero()
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
        public void Empty_haystack_should_return_not_found()
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
        public void One_character_in_both_strings_should_return_proper_result()
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
        public void Common_case_2_should_return_proper_result()
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