using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/robot-return-to-origin
    public class RobotReturnToOriginSolution
    {
        public bool JudgeCircle(string moves)
        {
            var x = 0;
            var y = 0;

            foreach (var move in moves)
            {
                if (move == 'L')
                {
                    x--;
                }
                else if (move == 'R')
                {
                    x++;
                }
                else if (move == 'U')
                {
                    y++;
                }
                else
                {
                    y--;
                }
            }

            return x == 0 && y == 0;
        }
    }
}