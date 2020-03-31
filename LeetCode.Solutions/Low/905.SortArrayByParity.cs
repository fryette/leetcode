namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/sort-array-by-parity/
    public class SortArrayByParitySolution
    {
        public int[] SortArrayByParity(int[] array)
        {
            var j = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    var temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    j++;
                }
            }

            return array;
        }
    }
}