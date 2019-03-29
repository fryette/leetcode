namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/delete-columns-to-make-sorted/
    public class DeleteColumnsToMakeSortedSolution
    {
        public int MinDeletionSize(string[] A)
        {
            var result = 0;

            for (var i = 0; i < A[0].Length; i++)
            {
                for (var j = 1; j < A.Length - 1; j++)
                {
                    if (A[j][i] > A[j + 1][i])
                    {
                        ++result;
                        break;
                    }
                }
            }

            return result;
        }
    }
}