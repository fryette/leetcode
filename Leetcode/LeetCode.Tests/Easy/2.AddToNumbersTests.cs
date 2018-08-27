using LeetCode.Solutions.Medium;
using Xunit;

namespace Leetcode.Tests.Easy
{
    public class AddTwoNumbersTests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new AddTwoNumbersSolution();
            var expected = new ListNode(7) { next = new ListNode(0) { next = new ListNode(8) { next = new ListNode(6) } } };
            //act
            var result = solution.AddTwoNumbers(new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) } },
                                                new ListNode(5) { next = new ListNode(6) { next = new ListNode(4) { next = new ListNode(6) } } });

            //Assert
            while (result != null || expected != null)
            {
                Assert.Equal(expected.val, result.val);

                result = result.next;
                expected = expected.next;
            }
        }

        [Fact]
        public void First_Argument_Is_Null()
        {
            // Arrange
            var solution = new AddTwoNumbersSolution();
            var expected = new ListNode(5) { next = new ListNode(6) { next = new ListNode(4) } };

            //act
            var result = solution.AddTwoNumbers(null, new ListNode(5) { next = new ListNode(6) { next = new ListNode(4) } });

            //Assert
            while (result != null || expected != null)
            {
                Assert.Equal(expected.val, result.val);

                result = result.next;
                expected = expected.next;
            }
        }

        [Fact]
        public void Both_Arguments_Null()
        {
            // Arrange
            var solution = new AddTwoNumbersSolution();
            ListNode expected = null;

            //act
            var result = solution.AddTwoNumbers(null, null);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Zero_Condition()
        {
            // Arrange
            var solution = new AddTwoNumbersSolution();
            var expected = new ListNode(0) { next = new ListNode(1) };

            //act
            var result = solution.AddTwoNumbers(new ListNode(5), new ListNode(5));

            //Assert
            while (result != null || expected != null)
            {
                Assert.Equal(expected.val, result.val);

                result = result.next;
                expected = expected.next;
            }
        }

        [Fact]
        public void Zero_Condition2()
        {
            // Arrange
            var solution = new AddTwoNumbersSolution();
            var expected = new ListNode(0) { next = new ListNode(0) { next = new ListNode(1) } };

            //act
            var result = solution.AddTwoNumbers(new ListNode(1), new ListNode(9) { next = new ListNode(9) });

            //Assert
            while (result != null || expected != null)
            {
                Assert.Equal(expected.val, result.val);

                result = result.next;
                expected = expected.next;
            }
        }
    }
}