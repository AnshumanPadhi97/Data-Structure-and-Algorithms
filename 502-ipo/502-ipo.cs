public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {        
            var pqCapital = new PriorityQueue<(int,int), (int, int)>(Comparer<(int, int)>.Create((a, b) => a.Item1.CompareTo(b.Item1)));
            var pqProfit = new PriorityQueue<(int, int), (int, int)>(Comparer<(int, int)>.Create((a, b) => b.Item2.CompareTo(a.Item2)));
            
            for (int i = 0; i < profits.Length; i++)
            {
                var a = (capital[i], profits[i]);
                pqCapital.Enqueue(a, a);
            }

            for (int i = 0; i < k; i++)
            {
                while (pqCapital.Count>0 && pqCapital.Peek().Item1<=w)
                {
                    var a = pqCapital.Dequeue();
                    pqProfit.Enqueue(a, a);
                }
                if (pqProfit.Count == 0) break;
                w += pqProfit.Dequeue().Item2;
            }

            return w;
    }
}