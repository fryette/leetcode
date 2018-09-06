using System.Linq;
using System.Text;

namespace LeetCode.Solutions.Medium
{
    //description of the problem link https://leetcode.com/problems/reverse-words-in-a-string/description/
    public class ReverseWordsInAStringSolution
    {
        public string ReverseWords(string s)
        {
            var builder = new StringBuilder(s.Length);
            s = s.Trim();
            var j = s.Length;
            var i = s.Length - 1;

            for (; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    j = i;
                }
                else if (i == 0 || s[i - 1] == ' ')
                {
                    if (builder.Length != 0)
                    {
                        builder.Append(' ');
                    }

                    builder.Append(s.Substring(i, j - i));
                }
            }

            return builder.ToString();
        }
    }
}