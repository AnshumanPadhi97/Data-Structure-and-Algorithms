public class Solution {
    int mod = (int)(Math.Pow(10, 9) + 7);
        int res = 0;
        public int dfs(int i, int j, int[][] grid, int k, int curr, int[,,] dp)
        {
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length)
            {
                return 0;
            }
            if (dp[i, j, curr % k] > 0)
            {
                return dp[i, j, curr % k];
            }
            if (i == 0 && j == 0)
            {
                curr+=grid[0][0]%k;
                return curr%k==0?1:0;
            }
            int a = dfs(i - 1, j, grid, k, curr + grid[i][j], dp) + dfs(i, j - 1, grid, k, curr + grid[i][j], dp);
            return dp[i, j, curr % k] = a % mod;
        }
        public int NumberOfPaths(int[][] grid, int k)
        {
            res = 0;
            if (grid.Length == 1 || grid[0].Length == 1)
            {
                var sum = 0;
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        sum += grid[i][j];
                    }
                }
                if (sum % k == 0)
                {
                    return 1;
                }
                return 0;
            }

            int m = grid.Length, n = grid[0].Length;

            var dp = new int[grid.Length, grid[0].Length, k];
            res = dfs(m-1, n-1, grid, k, 0, dp);
            return res % mod;
        }
}