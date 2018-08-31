using System;

namespace LeetCode.Solutions.Low
{
    //description of problem link: https://leetcode.com/problems/reverse-integer/description/
    public class ReverseIntegerSolution
    {
        public int Reverse(int x)
        {
            var result = 0;

            while (x != 0)
            {
                if (Math.Abs(result) > 214748364)
                {
                    return 0;
                }
                var lastDigit = x % 10;
                result = result * 10 + lastDigit;
                x = x / 10;
            }

            return result;
        }
    }
}
