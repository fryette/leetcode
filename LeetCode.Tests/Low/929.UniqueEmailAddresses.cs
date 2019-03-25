using System;
using System.Linq;
using LeetCode.Solutions.Low;
using Xunit;

namespace LeetCode.Tests.Low
{
    public class UniqueEmailAddressesTests
    {
        [Fact]
        public void Empty_Collection_Should_Return_0()
        {
            // Arrange
            var solution = new UniqueEmailAddressesSolution();

            //act
            var result = solution.NumUniqueEmails(new string[] { });

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void All_Same_Emails_Should_Return_1()
        {
            // Arrange
            var solution = new UniqueEmailAddressesSolution();

            //act
            var result = solution.NumUniqueEmails(new string[]
                {"test.email+alex@leetcode.com", "test.email+alex@leetcode.com", "test.email+alex@leetcode.com"});

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Emails_With_Dots_Should_Handle_Properly()
        {
            // Arrange
            var solution = new UniqueEmailAddressesSolution();

            //act
            var result = solution.NumUniqueEmails(new string[] {"test.email@leetcode.com", "testemail@leetcode.com"});

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Emails_With_Plus_Should_Handle_Properly()
        {
            // Arrange
            var solution = new UniqueEmailAddressesSolution();

            //act
            var result = solution.NumUniqueEmails(new string[] {"testemail+alex@leetcode.com", "testemail@leetcode.com"});

            //Assert
            Assert.Equal(1, result);
        }
        [Fact]

        public void Emails_With_First_Plus_Should_Handle_Properly()
        {
            // Arrange
            var solution = new UniqueEmailAddressesSolution();

            //act
            var result = solution.NumUniqueEmails(new string[]
                {"+test.email+alex@leet.code.com", "testemail@leet+code.com", "tes.tema.il@leet.code.com"});

            //Assert
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void Emails_With_Plus_And_Dots_Should_Handle_Properly()
        {
            // Arrange
            var solution = new UniqueEmailAddressesSolution();

            //act
            var result = solution.NumUniqueEmails(new string[] {"test.email+alex@leetcode.com", "testemail@leetcode.com"});

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Different_Emails_Should_Handle_Properly()
        {
            // Arrange
            var solution = new UniqueEmailAddressesSolution();

            //act
            var result = solution.NumUniqueEmails(new string[]
                {"test.email+alex@leet.code.com", "testemail@leet+code.com", "tes.tema.il@leet.code.com"});

            //Assert
            Assert.Equal(2, result);
        }
    }
}