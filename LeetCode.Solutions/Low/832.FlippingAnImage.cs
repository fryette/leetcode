using System;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/flipping-an-image/
    public class FlippingAnImageSolution
    {
        public int[][] FlipAndInvertImage(int[][] a)
        {
            foreach (var arr in a)
            {
                for (int i = 0, j = arr.Length - 1; i < arr.Length && j >= 0 && j >= i; i++, j--)
                {
                    var temp = arr[i];
                    arr[i] = arr[j] = 1 - arr[j];
                    arr[j] = 1 - temp;
                }
            }

            return a;
        }
    }
}