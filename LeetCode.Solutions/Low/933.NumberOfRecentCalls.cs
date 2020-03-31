using System.Collections.Generic;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/number-of-recent-calls/
    public class RecentCounter
    {
        private readonly Queue<int> _queue;

        public RecentCounter()
        {
            _queue = new Queue<int>(3000);
        }

        public int Ping(int t)
        {
            _queue.Enqueue(t);

            while (_queue.Peek() < t - 3000)
            {
                _queue.Dequeue();
            }

            return _queue.Count;
        }
    }
}