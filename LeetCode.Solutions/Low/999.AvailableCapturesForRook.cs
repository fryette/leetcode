namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/available-captures-for-rook/
    public class AvailableCapturesForRookSolution
    {
        public int NumRookCaptures(char[][] board)
        {
            var iPos = 0;
            var jPos = 0;
            var result = 0;
            for (var i = 0; i < board.Length; i++)
            {
                for (var j = 0; j < board.Length; j++)
                {
                    if (board[i][j] != 'R') continue;

                    iPos = i;
                    jPos = j;
                    break;
                }
            }

            for (var i = iPos + 1; i < 8; i++)
            {
                if (char.IsUpper(board[i][jPos]))
                {
                    break;
                }

                if (char.IsLower(board[i][jPos]))
                {
                    result++;
                    break;
                }
            }

            for (var i = iPos - 1; i >= 0; i--)
            {
                if (char.IsUpper(board[i][jPos]))
                {
                    break;
                }

                if (char.IsLower(board[i][jPos]))
                {
                    result++;
                    break;
                }
            }

            for (var j = jPos - 1; j >= 0; j--)
            {
                if (char.IsUpper(board[iPos][j]))
                {
                    break;
                }

                if (char.IsLower(board[iPos][j]))
                {
                    result++;
                    break;
                }
            }

            for (var j = jPos + 1; j < 8; j++)
            {
                if (char.IsUpper(board[iPos][j]))
                {
                    break;
                }

                if (char.IsLower(board[iPos][j]))
                {
                    result++;
                    break;
                }
            }

            return result;
        }
    }
}