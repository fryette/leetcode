namespace LeetCode.Solutions.Medium
{
    public class ReverseLinkedListIISolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }

        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null) return null;
            var dummy = new ListNode(0) {next = head}; // create a dummy node to mark the head of this list
            var pre = dummy; // make a pointer pre as a marker for the node before reversing
            
            for (var i = 1; i < m; i++)
            {
                pre = pre.next;
            }

            var start = pre.next; // a pointer to the beginning of a sub-list that will be reversed
            var then = start.next; // a pointer to a node that will be reversed

            // 1 - 2 -3 - 4 - 5 ; m=2; n =4 ---> pre = 1, start = 2, then = 3
            // dummy-> 1 -> 2 -> 3 -> 4 -> 5

            for (var i = 0; i < n - m; i++)
            {
                start.next = then.next;
                then.next = pre.next;
                pre.next = then;
                then = start.next;
            }

            // first reversing : dummy->1 - 3 - 2 - 4 - 5; pre = 1, start = 2, then = 4
            // second reversing: dummy->1 - 4 - 3 - 2 - 5; pre = 1, start = 2, then = 5 (finish)

            return dummy.next;
        }
    }
}