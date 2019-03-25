using System.Collections.Generic;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/self-dividing-numbers
    public class SelfDividingNumbersSolution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var result = new List<int>(right - left);

            for (var i = left; i <= right; i++)
            {
                if (IsSelfDividingNumber(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        private bool IsSelfDividingNumber(int num)
        {
            var digitCounter = num;

            while (digitCounter > 0)
            {
                var digit = digitCounter % 10;
                if (digit == 0 || num % digit != 0)
                {
                    return false;
                }

                digitCounter /= 10;
            }

            return true;
        }
    }
}