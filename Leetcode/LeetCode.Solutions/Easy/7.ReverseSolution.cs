using System.Collections.Generic;

namespace LeetCode.Solutions.Easy
{
    //description of problem link: https://leetcode.com/problems/reverse-integer/description/
    public class ReverseSolution
    {
        public int Reverse(int x)
        {
            var sign = 1;

            if (x < 10 && x > -10)
            {
                return x;
            }

            if (x < 0)
            {
                sign = -1;
                x *= -1;
            }

            var num = new List<int>();

            while (x >= 1)
            {
                num.Add(x % 10);
                x /= 10;
            }

            var result = 0;
            var carry = 1;
            for (var i = num.Count - 1; i >= 0; i--)
            {
                try
                {
                    result = checked(result + num[i] * carry);
                }
                catch
                {
                    return 0;
                }


                carry *= 10;
            }

            return result * sign;
        }
    }
}
