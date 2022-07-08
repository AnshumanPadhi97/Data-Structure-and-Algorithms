public class Solution {
        int MAX_COST = 1000001;
        int[,,] dp = new int[100, 100, 21];
        public int MinCost(int[] houses, int[][] cost, int m, int n, int target)
        {
            int res = h(houses, cost, target, 0, 0, 0);
            return res == MAX_COST ? -1 : res;
        }
        public int h(int[] houses, int[][] cost, int t,int i,int nc,int prevCol)
        {
            if (i == houses.Length)
            {
                return nc == t ? 0 : MAX_COST;
            }
            if (nc > t)
            {
                return MAX_COST;
            }
            if (dp[i, nc, prevCol] > 0)
            {
                return dp[i, nc, prevCol];
            }
            int ans = MAX_COST;
            if (houses[i] != 0)
            {
                var nnc = nc + (houses[i] != prevCol ? 1 : 0);
                ans = h(houses, cost, t, i + 1, nnc, houses[i]);
            }
            else
            {
                int total = cost[0].Length;
                for (int color = 1; color <= total; color++)
                {
                    var nnc = nc + (color != prevCol ? 1 : 0);
                    int curr = cost[i][color - 1] + h(houses, cost, t, i + 1, nnc, color);
                    ans = Math.Min(ans, curr);
                }
            }
            return dp[i, nc, prevCol] = ans;
        }
}