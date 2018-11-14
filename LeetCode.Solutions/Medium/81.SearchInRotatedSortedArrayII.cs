using System;

namespace LeetCode.Solutions.Medium
{
    public class SearchInRotatedSortedArrayIISolution
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            var left = 0;
            var right = nums.Length - 1;
            
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                
                //target and mid are on different sides
                if ((nums[mid] - nums[nums.Length - 1]) * (target - nums[nums.Length - 1]) > 0)
                {
                    if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                else if (target > nums[nums.Length - 1])
                {
                    right = mid; // target on the left side
                }
                else
                {
                    left = mid + 1; // target on the right side
                }
            }

            // now hi == lo
            if (nums[left] == target)
            {
                return left;
            }

            return -1;
        }
    }
}