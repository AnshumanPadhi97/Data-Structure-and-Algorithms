public class Solution {
        public int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[,] dp = new int[m+1,n+1];
            return h(grid, m, n, m-1, n-1, dp);
        }
        public int h(int[][] grid,int m,int n,int i, int j, int[,] dp)
        {
            if (i <0 || j <0) return int.MaxValue;
            if (i == 0 && j == 0) return grid[0][0];
            if (dp[i, j] > 0) return dp[i, j];
            return dp[i, j] = grid[i][j] + Math.Min(h(grid, m, n, i - 1, j, dp), h(grid, m, n, i, j - 1, dp));
        }
}