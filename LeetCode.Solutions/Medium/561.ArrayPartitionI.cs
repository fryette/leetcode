using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Medium
{
    //https://leetcode.com/problems/array-partition-i
    public class ArrayPartitionISolution
    {
        public int ArrayPairSum(int[] nums)
        {
            var exist = new int[20001];
            foreach (var num in nums)
            {
                exist[num + 10000]++;
            }
            var sum = 0;
            var odd = true;

            for (var i = 0; i < exist.Length; i++)
            {
                while (exist[i] > 0)
                {
                    if (odd)
                    {
                        sum += i - 10000;
                    }
                    odd = !odd;
                    exist[i]--;
                }
            }
            return sum;
        }
    }
}