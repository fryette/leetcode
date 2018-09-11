using System;

namespace LeetCode.Solutions.Medium
{
    public class LongestPalindromicSubstringSolution
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 0)
            {
                return s;
            }

            var start = 0;
            var end = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var len1 = ExpandAroundCenter(s, i, i);
                var len2 = ExpandAroundCenter(s, i, i + 1);
                var len = Math.Max(len1, len2);

                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private int ExpandAroundCenter(string s, int left, int right)
        {
            var l = left;
            var r = right;

            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }

            return r - l - 1;
        }
    }
}