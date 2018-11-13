using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Low
{
    public class PeakIndexInAMountainArraySolution
    {
        public int PeakIndexInMountainArray(int[] a)
        {
            var first = 0;
            var last = a.Length;

            while (first < last)
            {
                var mid = first + (last - first) / 2;

                if (a[mid] < a[mid + 1])
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid;
                }
            }

            return last;
        }
    }
}