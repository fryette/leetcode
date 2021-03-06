﻿namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/detect-capital/
    public class DetectCapitalSolution
    {
        public bool DetectCapitalUse(string word)
        {
            //is Upper
            var firstIsUpper = word[0] <= 90;
            var upperCount = firstIsUpper ? 1 : 0;

            for (var i = 1; i < word.Length; i++)
            {
                if (word[i] <= 90)
                {
                    upperCount++;
                }
            }

            return firstIsUpper && upperCount == 1 || upperCount == word.Length || upperCount == 0;
        }
    }
}