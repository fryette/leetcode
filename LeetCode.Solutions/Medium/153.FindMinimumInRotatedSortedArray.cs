//https://leetcode.com/problems/find-minimum-in-rotated-sorted-array
public class FindMinimumInRotatedSortedArraySolution
{
    // public int FindMin(int[] nums)
    // {
    //     var left = 0;
    //     var right = nums.Length - 1;

    //     while (left < right)
    //     {
    //         var middle = left + (right - left) / 2;

    //         if (nums[middle] > nums[right])
    //         {
    //             if (nums[right] > nums[left])
    //             {
    //                 right = middle - 1;
    //             }
    //             else
    //             {
    //                 left = middle + 1;
    //             }
    //         }
    //         else
    //         {
    //             right = middle;
    //         }
    //     }

    //     return nums[left];
    // }
  
    public int FindMin(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var middle = (left + right) / 2;

            if (nums[middle] > nums[right])
            {

                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }

        return nums[left];
    }
}