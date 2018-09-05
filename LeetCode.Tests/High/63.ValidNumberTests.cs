using LeetCode.Solutions.High;
using Xunit;

namespace LeetCode.Tests.High
{
    public class ValidNumberTests
    {
        [Fact]
        public void Zero_Number_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("0");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Empty_String_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Double_Zero_Number_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("00");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Number_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("1");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Number_Starting_From_Zero_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("01");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Number_Starting_With_WhiteSpaces_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("   123");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Decimal_Number_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber(" 0.234");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Number_With_Exponent_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("2e234");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Number_With_Character_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("2a");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Character_Presence_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("abc243");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Dot_Presence_In_Exponent_Value_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("1.2e1.2");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Dot_Presence_Withhout_Leading_Digit_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber(".2");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Dot_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber(".");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Exponent_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("e");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Leading_Exponent_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("e123");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Exponent_Without_Numbers_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("e");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Number_With_Dot_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("3.");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Dot_With_Exponent_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber(".e123");

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Minus_Number_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("-10");

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Minus_Number_And_Minus_Exponent_Should_Return_True()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("-10.0e-3");

            //Assert
            Assert.True(result);
        }
        
        [Fact]
        public void Minus_Number_And_Minus_Exponent_Should_Return_True1()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("-10.e-3");

            //Assert
            Assert.True(result);
        }
        
        [Fact]
        public void Minus_Exponent_Should_Return_False()
        {
            // Arrange
            var solution = new ValidNumberSolution();

            //act
            var result = solution.IsNumber("-e58 ");

            //Assert
            Assert.False(result);
        }
    }
}