using System;

namespace LeetCode.Solutions.Low
{
    //for description please see https://leetcode.com/problems/median-of-two-sorted-arrays/description/
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] arr1, int[] arr2)
        {
            if (arr1 == null && arr2 == null)
            {
                return -1;
            }
            if (arr1.Length == 0 && arr2.Length == 0)
            {
                return -1;
            }

            int x = arr1.Length;
            int y = arr2.Length;

            if (x > y)
            {
                return FindMedianSortedArrays(arr2, arr1);
            }

            int low = 0;
            int high = x;

            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (x + y + 1) / 2 - partitionX;

                int maxX = partitionX == 0 ? int.MinValue : arr1[partitionX - 1];
                int minX = partitionX == x ? int.MaxValue : arr1[partitionX];

                int maxY = partitionY == 0 ? int.MinValue : arr2[partitionY - 1];
                int minY = partitionY == y ? int.MaxValue : arr2[partitionY];

                if (maxX <= minY && maxY <= minX)
                {
                    if ((x + y) % 2 == 0)
                    {
                        return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
                    }
                    return Math.Max(maxX, maxY);
                }
                if (maxX > minY)
                {
                    high = partitionX - 1;
                }
                else
                {
                    low = partitionX + 1;
                }
            }
            return -1;
        }
    }
}