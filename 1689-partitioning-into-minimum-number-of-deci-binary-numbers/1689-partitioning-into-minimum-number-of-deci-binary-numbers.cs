public class Solution {
    public int MinPartitions(string n) {
            int res = int.MinValue;
            for (int i = 0; i < n.Length; i++)
            {
                res = Math.Max(res, n[i] - '0');
            }
            return res;
    }
}