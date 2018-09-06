using System.Linq;

namespace LeetCode.Solutions.Low
{
    //problem description link https://leetcode.com/problems/implement-strstr/description/
    public class ImplementStrStrSolution
    {
        //Rabin-Carp Algorithm

        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            var hashNeedle = needle;
            var tempHash = haystack.Substring(0, needle.Length);
            var i = 0;
            
            for (i = 0; i < haystack.Length - needle.Length; i++)
            {
                if (hashNeedle.Equals(tempHash))
                {
                    return i;
                }

                tempHash = tempHash.Remove(0, 1) + haystack[i + needle.Length].ToString();
            }

            return hashNeedle.Equals(tempHash) ? i : -1;
        }
        
        //Brute-force approach
        
        //        public int StrStr(string haystack, string needle)
//        {
//            for (var i = 0;; i++)
//            {
//                for (var j = 0;; j++)
//                {
//                    if (j == needle.Length)
//                    {
//                        return i;
//                    }
//
//                    if (i + j == haystack.Length)
//                    {
//                        return -1;
//                    }
//
//                    if (haystack[i + j] != needle[j])
//                    {
//                        break;
//                    }
//                }
//            }
    }
}