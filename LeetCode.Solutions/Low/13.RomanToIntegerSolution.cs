namespace LeetCode.Solutions.Low
{
    //description of problem link: https://leetcode.com/problems/roman-to-integer/
    public class RomanToIntegerSolution
    {
        public int RomanToInt(string s)
        {
            int GetBasicNumber(char c)
            {
                switch (c)
                {
                    case 'I': return 1;
                    case 'V': return 5;
                    case 'X': return 10;
                    case 'L': return 50;
                    case 'C': return 100;
                    case 'D': return 500;
                    case 'M': return 1000;
                }

                return -1;
            }

            int total = 0;
            var i = 0;
            int maxLength = s.Length - 1;

            for (i = 0; i < maxLength; i++)
            {
                int num = GetBasicNumber(s[i]);

                int nextNum = GetBasicNumber(s[i + 1]);

                if (num >= nextNum)
                {
                    total += num;
                }
                else
                {
                    total += nextNum - num;
                    ++i;
                }
            }

            if (i == maxLength)
            {
                total += GetBasicNumber(s[s.Length - 1]);
            }

            return total;
        }
    }
}
