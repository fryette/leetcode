using System;

namespace LeetCode.Solutions.Low
{
    public class FindTheDifferenceSolution
    {
		public char FindTheDifference(string s, string t)
        {
            var sum1 = 0;
            var sum2 = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum1 += s[i];
                sum2 += t[i];
            }

            sum2 += t[s.Length];

            return (char)(sum2 - sum1);
        }
    }
}
