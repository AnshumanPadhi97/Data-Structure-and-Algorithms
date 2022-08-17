public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        
            var pq = new PriorityQueue<string, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            pq.Enqueue("a", a);
            pq.Enqueue("b", b);
            pq.Enqueue("c", c);
            StringBuilder sb = new StringBuilder();
            string prev = "";
            int prevc = 0;

            while (pq.Count > 0)
            {
                if(pq.TryDequeue(out string ele,out int count) && count > 0)
                {
                    int max = 0;
                    if (count >= prevc)
                    {
                        while (count != 0 && max != 2)
                        {
                            sb.Append(ele);
                            count--;
                            max++;
                        }
                    }
                    else
                    {
                        sb.Append(ele);
                        count--;
                    }
                    if (prevc > 0)
                    {
                        pq.Enqueue(prev, prevc);
                    }
                    prev = ele;
                    prevc = count;
                }
            }
            return sb.ToString();
    }
}