using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/find-common-characters/
    public class FindCommonCharactersSolution
    {
        public IList<string> CommonChars(string[] A)
        {
            var originalString = A[0];

            for (var i = 1; i < A.Length; i++)
            {
                var tempOriginal = string.Empty;

                for (var j = 0; j < A[i].Length; j++)
                {
                    var index = originalString.IndexOf(A[i][j]);
                    if (index >= 0)
                    {
                        originalString = originalString.Remove(index, 1);
                        tempOriginal += A[i][j];
                    }
                }

                originalString = tempOriginal;
            }

            return originalString.Select(x => x.ToString()).ToArray();
        }
    }
}