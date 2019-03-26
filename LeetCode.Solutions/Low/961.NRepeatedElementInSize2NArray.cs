using System;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
    public class NRepeatedElementInSize2NArray
    {
        public int RepeatedNTimes(int[] A)
        {
            for (var i = 1; i <= 3; i++)
            {
                for (var j = 0; j < A.Length - i; j++)
                {
                    if (A[j] == A[j + i])
                    {
                        return A[j];
                    }
                }
            }

            throw new ArgumentException();
        }
    }
}