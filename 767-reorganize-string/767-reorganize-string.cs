public class Solution {
    public string ReorganizeString(string s) {
            var f = s.GroupBy(x => x);
            var pq = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            foreach (var item in f)
            {
                pq.Enqueue(item.Key, item.Count());
            }

            char? prev = null;
            int prevCount = 0;
            StringBuilder a = new StringBuilder();
            while (pq.Count > 0)
            {
                char c;
                int count;
                pq.TryDequeue(out c, out count);
                a.Append(c);
                
                if(prev.HasValue && prevCount > 0)
                {
                    pq.Enqueue(prev.Value, prevCount);
                }
                prev = c;
                prevCount = count - 1;
            }
            return prevCount > 0 ? "" : a.ToString();
    }
}