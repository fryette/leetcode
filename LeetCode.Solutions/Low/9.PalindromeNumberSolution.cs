namespace LeetCode.Solutions.Low
{
    //for problem description check https://leetcode.com/problems/palindrome-number/description/
    public class PalindromeNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            var strX = x.ToString();

            for (int i = 0; i <= (strX.Length - 1) / 2; i++)
            {
                if (strX[i] == strX[strX.Length - i - 1])
                {
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}