//https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
public class FindFirstAndLastPositionOfElementInSortedArraySolution
{
    public int[] SearchRange(int[] nums, int target)
    {
        var result = new int[] { -1, -1 };

        if (nums.Length == 0)
        {
            return result;
        }

        var leftIndex = findTarget(nums, target, true);

        if (nums[leftIndex] != target)
        {
            return result;
        }

        result[0] = leftIndex;

        var rightIndex = findTarget(nums, target, false);

        result[1] = nums[rightIndex] == target ? rightIndex : rightIndex - 1;

        return result;
    }

    private int findTarget(int[] nums, int target, bool isLeft)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left + 1 < right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] > target || (isLeft && nums[mid] == target))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        if (isLeft && nums[left] == target) return left;
        if (nums[right] == target) return right;

        return left;
    }
}