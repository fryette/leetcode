using System;

namespace LeetCode.Solutions.Low
{
    public class MissingNumberSolution
    {
        public int MissingNumber(int[] nums)
        {
            var sum = 0;
            var min = int.MaxValue;
            var max = int.MinValue;

            foreach (var num in nums)
            {
                sum += num;
                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }
            }

            if (min == 1)
            {
                return 0;
            }

            var idealSum = nums.Length * (2 * min + nums.Length - 1) / 2;

            if (idealSum == sum)
            {
                return max + 1;
            }

            idealSum = nums.Length * (2 * min + nums.Length + 1) / 2;

            return idealSum - sum;
        }
    }
}