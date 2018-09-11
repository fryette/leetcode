using System;
using LeetCode.Solutions.Low;
using LeetCode.Solutions.Medium;
using Xunit;

namespace LeetCode.Tests.Medium
{
    public class StringToIntegerAtoiTests
    {
        [Fact]
        public void Common_Test()
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
        public void Empty_String_Return_Zero()
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
        public void Common_Test_With_Minis_Sign()
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
        public void String_With_Spaces()
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
        public void String_With_Spaces_And_Letters()
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
        public void String_With_First_Letters_Should_Return_Zero_Value()
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
        public void Max_Int_Should_Return_Max_Int()
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
        public void Min_Int_Should_Return_Min_Int()
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
        public void Less_Then_Max_Int_Should_Return_Proper_Value1()
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
        public void Overflow_Should_Return_Max_Int()
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
        public void Plus_Sigh_Should_Be_Handled_Properly()
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
        public void Few_Plus_Sighs_Should_Be_Handled_Properly()
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
        public void Few_Plus_Sighs_Should_Be_Handled_Properly1()
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