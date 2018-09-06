namespace LeetCode.Solutions.Low
{
    public class TwoSum2InputArrayIsSortedSolution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                var binarySearchResult = BinarySearch(numbers, target - numbers[i], i + 1);

                if (binarySearchResult != -1)
                {
                    return new int[] { i + 1, ++binarySearchResult };
                }
            }

            return null;
        }

        private static int BinarySearch(int[] array, int x, int start)
        {
            var first = start;
            var last = array.Length - 1;

            while (first < last)
            {
                var mid = first + (last - first) / 2;

                if (x <= array[mid])
                {
                    last = mid;
                }
                else
                {
                    first = mid + 1;
                }
            }

            if (array[last] == x)
            {
                return last;
            }

            return -1;
        }
    }
}
