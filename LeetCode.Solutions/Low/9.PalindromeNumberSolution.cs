namespace LeetCode.Solutions.Low
{
    //for problem description check https://leetcode.com/problems/palindrome-number/description/
    public class PalindromeNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            var strX = x.ToString();

            for (var i = 0; i <= (strX.Length - 1) / 2; i++)
            {
                if (strX[i] == strX[strX.Length - i - 1])
                {
                    continue;
                }

                return false;
            }

            return true;
        }

          // without allocating memory solution
//        public bool IsPalindrome(int x)
//        {
//            if (x < 0)
//            {
//                return false;
//            }
//
//            var div = 1;
//            while (x / div >= 10)
//            {
//                div *= 10;
//            }
//
//            while (x != 0)
//            {
//                var left = x / div;
//                var right = x % 10;
//
//                if (left != right)
//                {
//                    return false;
//                }
//
//                x = (x % div) / 10;
//                div /= 100;
//            }
//
//            return true;
//        }
    }
}