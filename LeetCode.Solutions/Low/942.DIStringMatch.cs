namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/di-string-match/
    public class DIStringMatchSolution
    {
        public int[] DiStringMatch(string S)
        {
            var max = S.Length;
            var min = 0;
            var result = new int[S.Length + 1];

            for (var i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I')
                {
                    result[i] = min;
                    ++min;
                }
                else
                {
                    result[i] = max;
                    --max;
                }
            }

            result[S.Length] = min;

            return result;
        }
    }
}