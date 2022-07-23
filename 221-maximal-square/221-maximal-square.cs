public class Solution {
    public int MaximalSquare(char[][] matrix) {
            var res = 0;
            int m = matrix.Length;
            int n = matrix[0].Length;
            var dp = new int[m+1,n+1];
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (matrix[i-1][j-1] == '1')
                    {
                        dp[i, j] = 1 + Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1]));
                        res = Math.Max(res, dp[i, j]);
                    }
                }
            }
            return res*res;
    }
}