using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Medium
{
    public class FindAndReplacePatternSolution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var ans = new List<string>();
            foreach (var word in words)
            {
                if (Match(word, pattern))
                {
                    ans.Add(word);
                }
            }

            return ans;
        }

        private bool Match(string word, string pattern)
        {
            var dictionary = new Dictionary<char, char>();
            for (var i = 0; i < word.Length; ++i)
            {
                var wordChar = word[i];
                if (!dictionary.ContainsKey(wordChar))
                {
                    dictionary.Add(wordChar, pattern[i]);
                }

                if (dictionary[wordChar] != pattern[i])
                {
                    return false;
                }
            }

            var seen = new bool[26];
            foreach (var p in dictionary.Values)
            {
                if (seen[p - 'a'])
                {
                    return false;
                }

                seen[p - 'a'] = true;
            }

            return true;
        }
    }
}