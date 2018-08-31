namespace LeetCode.Solutions.Low
{
    public class ValidPalindromeSolution
    {
        //https://leetcode.com/problems/valid-palindrome/description/
        public bool IsPalindrome(string s)
        {
            var j = s.Length - 1;
            var i = 0;

            while (i < j)
            {
                while (i < j && !char.IsLetterOrDigit(s[i])) { ++i; }
                while (j > i && !char.IsLetterOrDigit(s[j])) { --j; }

                if (char.ToUpperInvariant(s[i]) != char.ToUpperInvariant(s[j]))
                {
                    return false;
                }
                i++;
                --j; 
            }

            return true;
        }
    }
}