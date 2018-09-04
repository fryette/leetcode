using System;
using LeetCode.Solutions.Low;
using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class StringToIntegerAtoiTests
    {
        [Fact]
        public void Common_test()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 42;

            //act
            var result = solution.MyAtoi("42");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Empty_string_return_zero()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 0;

            //act
            var result = solution.MyAtoi(string.Empty);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Common_test_with_munis_sign()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = -42;

            //act
            var result = solution.MyAtoi("-42");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void String_with_spaces()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 42;

            //act
            var result = solution.MyAtoi("  42   ");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void String_with_spaces_and_letters()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 42;

            //act
            var result = solution.MyAtoi(" 42 fdsfsf");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void String_with_first_letters_should_return_zero_value()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 0;

            //act
            var result = solution.MyAtoi("a 42");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Max_int_should_return_max_int()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = Int32.MaxValue;

            //act
            var result = solution.MyAtoi("2147483647");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Min_int_should_return_min_int()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = Int32.MaxValue;

            //act
            var result = solution.MyAtoi("2147483647");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Less_then_Max_int_should_return_proper_value()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 214748364;

            //act
            var result = solution.MyAtoi("214748364");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Less_then_Max_int_should_return_proper_value1()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 2147483646;

            //act
            var result = solution.MyAtoi("2147483646");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Overflow_should_return_max_int()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = Int32.MaxValue;

            //act
            var result = solution.MyAtoi("21474836478");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Plus_sigh_should_be_handled_properly()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 42;

            //act
            var result = solution.MyAtoi("+42");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Few_plus_sighs_should_be_handled_properly()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 4;

            //act
            var result = solution.MyAtoi("+4+2");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Few_plus_sighs_should_be_handled_properly1()
        {
            // Arrange
            var solution = new StringToIntegerAtoiSolution();
            var expected = 0;

            //act
            var result = solution.MyAtoi("++4+2");

            //Assert
            Assert.Equal(expected, result);
        }
    }
}