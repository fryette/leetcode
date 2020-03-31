using System;
namespace LeetCode.Solutions.Low
{
    public class FindPuckElementSolution
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums.Length == 1) return 0;

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
