namespace LeetCode.Solutions.Medium
{
    //description problem link https://leetcode.com/problems/string-to-integer-atoi/description/
    public class StringToIntegerAtoiSolution
    {
        public int MyAtoi(string str)
        {
            int result = 0, i = 0;
            var sign = 1;

            str = str.TrimStart();

            if (i < str.Length)
            {
                if (str[0] == '-')
                {
                    i = 1;
                    sign = -1;
                }
                else if (str[0] == '+')
                {
                    i = 1;
                }
            }

            for (; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    var digit = (int) char.GetNumericValue(str[i]);

                    if (result > 214748364 || result == 214748364 && digit >= 8)
                    {
                        return sign == -1 ? int.MinValue : int.MaxValue;
                    }

                    result = result * 10 + digit;
                }
                else
                {
                    break;
                }
            }

            return result * sign;
        }
    }
}