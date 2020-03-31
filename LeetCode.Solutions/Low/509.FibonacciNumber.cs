namespace LeetCode.Solutions.Low
{
    public class FibonacciNumber
    {
        public int Fib(int N)
        {
            if (N <= 0)
            {
                return 0;
            }

            if (N <= 2)
            {
                return 1;
            }

            var left = 1;
            var right = 1;
            var sum = 1;

            for (var i = 3; i < N - 1; i++)
            {
                sum += left + right;
                left = right;
                right = sum;
            }

            return sum + left + right;
        }
    }
}