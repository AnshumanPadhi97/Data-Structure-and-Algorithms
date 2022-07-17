public class Solution {
    public int KInversePairs(int n, int k) {
            var dp = new int[n + 1, k + 1];
            int mod = 1000000007;
            dp[0, 0] = 1;

            for (int i = 1; i < n + 1; i++)
            {
                int sum = 0;
                for (int j = 0; j < k + 1; j++)
                {
                    if (j == 0)
                    {
                        dp[i, j] = 1;
                        sum = 1;
                    }
                    else
                    {
                        sum = (sum + dp[i - 1, j]) % mod;
                        if (j - i >= 0)
                        {
                            sum = (sum + mod - dp[i - 1, j - i]) % mod;
                        }
                        dp[i, j] = sum;
                    }
                }
            }

            return dp[n, k];
    }
}