using System;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/squares-of-a-sorted-array
    public class SquaresOfASortedArraySolution
    {
        public int[] SortedSquares(int[] A)
        {
            var i = A.Length - 1;
            var j = 0;
            var resultIndex = A.Length;
            var result = new int[A.Length];

            while (resultIndex > 0)
            {
                int temp;

                if (Math.Abs(A[i]) > Math.Abs(A[j]))
                {
                    temp = i;
                    --i;
                }
                else
                {
                    temp = j;
                    ++j;
                }

                result[resultIndex - 1] = A[temp] * A[temp];
                --resultIndex;
            }

            return result;
        }
    }
}