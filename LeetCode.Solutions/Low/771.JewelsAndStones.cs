using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Low
{
    public class JewelsAndStonesSolution
    {
        public int NumJewelsInStones(string j, string s)
        {
            var hashMap = new HashSet<char>(j);
            var result = 0;

            foreach (var c in s)
            {
                if (hashMap.Contains(c))
                {
                    result++;
                }
            }

            return result;
        }
    }
}