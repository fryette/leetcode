using LeetCode.Solutions.Medium;
using Xunit;
using ListNode = LeetCode.Solutions.Medium.ReverseLinkedListIISolution.ListNode;

namespace LeetCode.Tests.Medium
{
    public class ReverseLinkedListIITests
    {
        [Fact]
        public void Common_Test()
        {
            // Arrange
            var solution = new ReverseLinkedListIISolution();

            //act
            var result = solution.ReverseBetween(new ListNode(5) {next = new ListNode(2) {next = new ListNode(3)}}, 1, 2);
        }
    }
}