using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Low
{
    //problem description link: https://leetcode.com/problems/plus-one/description/
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    ++digits[i];
                    return digits;
                }

                digits[i] = 0;
            }

            var result = new int[digits.Length + 1];
            result[0] = 1;

            for (var i = 1; i < result.Length; i++)
            {
                result[i] = digits[i - 1];
            }

            return result;
        }
    }
}