using System;

namespace LeetCode.Solutions.Low
{
    public class SqrtX
    {
        public int MySqrt(int x)
        {
            long r = x;
            
            while (r * r > x)
            {
                r = (r + x / r) / 2;
            }

            return (int) r;
        }
    }
}