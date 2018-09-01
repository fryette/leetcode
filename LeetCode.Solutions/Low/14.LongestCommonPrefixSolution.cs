namespace LeetCode.Solutions.Low
{
    //problem description link https://leetcode.com/problems/longest-common-prefix/description/
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            string s = strs[0];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                    {
                        return s.Substring(0, i);
                    }
                }
            }

            return s;
        }
    }
}