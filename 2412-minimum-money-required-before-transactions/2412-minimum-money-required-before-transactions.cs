public class Solution {
    public long MinimumMoney(int[][] transactions) {
            long res = 0;
            foreach (var item in transactions)
            {
                var a = Math.Min(item[0], item[1]);
                res = Math.Max(res, a);
            }
            foreach (var item in transactions)
            {
                res += Math.Max(item[0] - item[1], 0);
            }
            return res;
    }
}