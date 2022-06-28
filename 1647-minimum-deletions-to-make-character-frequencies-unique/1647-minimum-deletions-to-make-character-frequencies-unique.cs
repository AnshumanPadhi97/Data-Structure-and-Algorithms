public class Solution {
    public int MinDeletions(string s) {
            int res = 0;
            int[] a = new int[26];
            foreach (var item in s)
            {
                a[item - 'a']++;
            }
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));
            foreach (var item in a)
            {
                if (item > 0)
                {
                    pq.Enqueue(item, item);
                }
            }
            while (pq.Count > 1)
            {
                int top = pq.Dequeue();
                if(top == pq.Peek())
                {
                    if (top - 1 > 0)
                    {
                        pq.Enqueue(top - 1, top - 1);
                    }
                    res++;
                }
            }
            return res;
    }
}