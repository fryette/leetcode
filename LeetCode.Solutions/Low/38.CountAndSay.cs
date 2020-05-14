using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/count-and-say/
    public class CountAndSaySolution
    {
        static List<string> numbers = new List<String>
        {
            "1",
                "11",
                "21",
                "1211",
                "111221"
        };

        public string CountAndSay(int n)
        {
            string result = String.Empty;
            if (n <= 5)
            {
                result = numbers[n - 1];
                return result;
            }

            result = numbers[4];

            for (int i = 5; i <= n - 1; i++)
            {
                result = say(result);
            }

            return result;
        }

        private String say(String str)
        {
            int i = 0;
            var result = String.Empty;
            while (i < str.Length)
            {
                int counter = 1;
                for (int j = i; j < str.Length; j++)
                {
                    i = j;

                    if (j + 1 != str.Length && str[j] == str[j + 1])
                    {
                        counter++;
                        continue;
                    }
                    else
                    {
                        ++i;
                        result += $"{counter}{str[j]}";
                        break;
                    }

                }
            }

            return result;
        }
    }
}