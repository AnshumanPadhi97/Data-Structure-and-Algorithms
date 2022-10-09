public class Solution {
    
        int mod = (int)(Math.Pow(10, 9) + 7);
        int res = 0;
        public int dfs(int i, int j, int[][] grid, int k, int curr, int[,,] dp)
        {
            if (i == grid.Length || j == grid[0].Length)
            {
                return 0;
            }
            if (i == grid.Length-1 && j == grid[0].Length-1)
            {
                curr += grid[i][j];
                return curr % k == 0 ? 1 : 0;
            }
            if (dp[i, j, curr % k] > 0)
            {
                return dp[i, j, curr % k];
            }
            int a = dfs(i + 1, j, grid, k, curr + grid[i][j], dp) + dfs(i, j + 1, grid, k, curr + grid[i][j], dp);
            return dp[i, j, curr % k] = a % mod;
        }
        public int NumberOfPaths(int[][] grid, int k)
        {   
            var dp = new int[grid.Length + 1, grid[0].Length + 1, k + 1];
            res = dfs(0, 0, grid, k, 0, dp);
            return res % mod;
        }
}