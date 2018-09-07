using System.Text.RegularExpressions;

namespace LeetCode.Solutions.High
{
    //problem description link https://leetcode.com/problems/valid-number/description/
    public class ValidNumberSolution
    {
        //Regex solution
//        public bool IsNumber(string s)
//        {
//            return new Regex(@"^\s*[+-]?(?:\d+|\d+\.\d*|d*\.\d+)(e[+-]?\d+)?\s*$").IsMatch(s);
//        }
        
        public bool IsNumber(string s)
        {
            s = s.Trim();
            var isNumber = false;
            var i = 0;

            if (s.Length == 0)
            {
                return false;
            }

            //parse number sign
            if (s[i] == '-' || s[i] == '+')
            {
                ++i;
            }

            //parse first number part
            while (i < s.Length && char.IsDigit(s[i]))
            {
                ++i;
                isNumber = true;
            }

            //parse dot sign
            if (i < s.Length && s[i] == '.')
            {
                ++i;

                //parse second number part
                while (i < s.Length && char.IsDigit(s[i]))
                {
                    ++i;
                    isNumber = true;
                }
            }

            //parse exponent
            if (isNumber && i < s.Length - 1 && s[i] == 'e')
            {
                ++i;
                isNumber = false;

                //parse exponent sign
                if (s[i] == '-' || s[i] == '+')
                {
                    ++i;
                }

                //parse exponent value
                while (i < s.Length && char.IsDigit(s[i]))
                {
                    ++i;
                    isNumber = true;
                }
            }

            return i == s.Length && isNumber;
        }
    }
}