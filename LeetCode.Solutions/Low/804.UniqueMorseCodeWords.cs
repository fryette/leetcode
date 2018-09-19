using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solutions.Low
{
    public class UniqueMorseCodeWordsSolution
    {
        private static readonly string[] Morse = new[]
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
            ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        public int UniqueMorseRepresentations(string[] words)
        {
            var hash = new HashSet<string>();
            var builder = new StringBuilder();

            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    builder.Append(Morse[c - 'a']);
                }

                hash.Add(builder.ToString());
                builder.Length = 0;
            }

            return hash.Count;
        }
    }
}