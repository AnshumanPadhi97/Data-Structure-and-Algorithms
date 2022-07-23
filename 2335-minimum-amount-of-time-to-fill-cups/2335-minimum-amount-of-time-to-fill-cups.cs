public class Solution {
    public int FillCups(int[] amount) {
            
            var q = new PriorityQueue<int, int>(Comparer<int>.Create((a,b)=>b.CompareTo(a)));
            
            for (int i = 0; i < amount.Length; i++)
            {
                if(amount[i]>0)q.Enqueue(amount[i], amount[i]);
            }
            int res = 0;
            while (q.Count > 1)
            {
                var a = q.Dequeue() - 1;
                var b = q.Dequeue() - 1;
                res++;
                if(a>0)q.Enqueue(a,a);
                if(b>0)q.Enqueue(b,b);
            }
            if (q.Count > 0) res += q.Dequeue();
            return res;
    }
}