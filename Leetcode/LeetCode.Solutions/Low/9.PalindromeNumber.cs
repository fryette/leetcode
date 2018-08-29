namespace LeetCode.Solutions.Low
{
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