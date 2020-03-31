namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/sort-array-by-parity-ii/
    public class SortArrayByParityIISolution
    {
        public int[] SortArrayByParityII(int[] A)
        {
            var j = 1;

            for (var i = 0; i < A.Length; i += 2)
            {
                if (A[i] % 2 == 1)
                {
                    while (A[j] % 2 == 1)
                    {
                        j += 2;
                    }

                    var temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }

            return A;
        }
    }
}