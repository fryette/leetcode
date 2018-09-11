using System;

namespace LeetCode.Solutions.Low
{
    //problem description link https://leetcode.com/problems/to-lower-case/description/
    public class ToLowerCaseSolution
    {
        public string ToLowerCase(string str)
        {
            var chars = new char[str.Length];

            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    chars[i] = (char) (str[i] + 32);
                }
                else
                {
                    chars[i] = str[i];
                }
            }

            return new string(chars);
        }
    }
}