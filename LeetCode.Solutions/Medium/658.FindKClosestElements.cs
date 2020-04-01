using System.Collections.Generic;

//https://leetcode.com/problems/find-k-closest-elements/
public class FindKClosestElementsSolution
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        var left = 0;
        var right = arr.Length - 1;
        var result = new List<int>();

        while (left + 1 < right)
        {
            var mid = left + (right - left) / 2;
            if (arr[mid] > x)
            {
                right = mid - 1;
            }
            else
            {
                left = mid;
            }
        }

        int lIndex = left;
        int rIndex = left + 1;

        while (result.Count != k)
        {
            if (rIndex != arr.Length && (lIndex < 0 || x - arr[lIndex] > arr[rIndex] - x))
            {
                result.Add(arr[rIndex]);
                rIndex++;
                continue;
            }

            result.Insert(0, arr[lIndex]);
            lIndex--;
        }

        return result;
    }
}