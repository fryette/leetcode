using System;
using System.Linq;

namespace LeetCode.Solutions.Low
{
    public class HammingDistanceSolution
    {
        public int HammingDistance(int x, int y)
        {
            var binaryStr = Convert.ToString(x ^ y, 2);
            return binaryStr.Count(d => d == '1');
        }
    }
}