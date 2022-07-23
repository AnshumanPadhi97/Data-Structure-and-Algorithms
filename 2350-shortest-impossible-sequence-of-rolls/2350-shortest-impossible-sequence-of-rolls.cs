public class Solution {
    public int ShortestSequence(int[] rolls, int k) {
            int res = 1;
            var h = new HashSet<int>();
            for (int i = 0; i < rolls.Length; i++)
            {
                h.Add(rolls[i]);
                if (h.Count == k)
                {
                    res++;
                    h.Clear();
                }
            }
            return res;
    }
}