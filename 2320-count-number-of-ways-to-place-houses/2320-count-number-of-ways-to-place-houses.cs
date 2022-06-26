public class Solution {
    public int CountHousePlacements(int n) {
            var dp = new long[n + 10];
            dp[0] = 1;
            dp[1] = 2;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2]) % 1000000007;
            }
            return (int)((dp[n] * dp[n]) % 1000000007);
    }
}