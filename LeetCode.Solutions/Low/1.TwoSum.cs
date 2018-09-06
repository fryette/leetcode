using System.Collections.Generic;

namespace LeetCode.Solutions.Low
{
    //description of problem link: https://leetcode.com/problems/two-sum/description/
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var difference = target - nums[i];

                if (dictionary.ContainsKey(difference))
                {
                    return new[] { dictionary[difference], i };
                }
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
            } 

            return null;
        }
    }
}
