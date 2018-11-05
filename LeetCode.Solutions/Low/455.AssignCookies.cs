using System;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/assign-cookies/description/
    public class AssignCookiesSolution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);

            var child = g.Length - 1;
            var cookie = s.Length - 1;
            var result = 0;

            while (child >= 0 && cookie >= 0)
            {
                if (s[cookie] >= g[child])
                {
                    cookie--;
                    result++;
                }

                child--;
            }

            return result;
        }
    }
}