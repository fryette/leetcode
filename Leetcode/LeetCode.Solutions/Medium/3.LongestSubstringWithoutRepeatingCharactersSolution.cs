using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Medium
{
    public class LongestSubstringWithoutRepeatingCharactersSolution
    {
        //description of problem link: https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
        public int LengthOfLongestSubstring(string s)
        {
            var dic = new Dictionary<char, int>(s.Length);
            var maxResult = 0;
            var count = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    maxResult = count > maxResult ? count : maxResult;
                    count = Math.Min(count + 1, i - dic[s[i]]);
                    dic[s[i]] = i;
                }
                else
                {
                    ++count;
                    dic.Add(s[i], i);
                }
            }

            maxResult = count > maxResult ? count : maxResult;

            return maxResult;
        }
    }
}
