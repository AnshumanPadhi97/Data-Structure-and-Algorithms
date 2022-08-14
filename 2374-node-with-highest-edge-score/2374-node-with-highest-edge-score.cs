public class Solution {
    public int EdgeScore(int[] edges) {
            long n = edges.Length;
            long[] score = new long[edges.Length];
            for (long i = 0; i < n; i++)
            {
                score[edges[i]] += i;
            }
            var pq = new PriorityQueue<long, long>(Comparer<long>.Create((a, b) => b.CompareTo(a)));
            for (long i = 0; i < n; i++)
            {
                pq.Enqueue(i, score[i]);
            }
        return (int)pq.Dequeue();
    }
}