﻿namespace Addtwonumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var result = new Solution().AddTwoNumbers(new ListNode(1), new ListNode(9) { next = new ListNode(9) });
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode node = new ListNode(0);
            var next = node;

            int remain = 0;

            while (l1 != null || l2 != null)
            {
                int sum = remain;
                remain = 0;

                if (l1 == null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                else
                {
                    sum += l1.val + l2.val;
                    l1 = l1.next;
                    l2 = l2.next;
                }

                if (sum >= 10)
                {
                    sum = sum % 10;
                    remain = 1;
                }

                next.next = new ListNode(sum);
                next = next.next;
            }

            if (remain != 0)
            {
                next.next = new ListNode(1);
                next = next.next;
            }


            return node.next;
        }

    }
}