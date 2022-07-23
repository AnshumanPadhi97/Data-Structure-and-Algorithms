public class Solution {
    public int ShortestSequence(int[] rolls, int k) {
            var h = new HashSet<int>();
            int res = 1;
            foreach (var item in rolls)
            {
                h.Add(item);
                if(h.Count == k)
                {
                    res++;
                    h.Clear();
                }
            }
            return res;
    }
}