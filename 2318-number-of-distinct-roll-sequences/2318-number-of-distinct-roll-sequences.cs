public class Solution {
    private int MOD = 1000000007;
    long gcd(long a, long b)
    {
        if (a == 0)
            return b;

        return gcd(b % a, a);
    }
    int[,,] dp = new int[10001, 7, 7];
    public int DistinctSequences(int n, int prev1 = 0, int prev2 = 0)
    {
        if (n == 0) return 1;
        if (dp[n, prev1, prev2] == 0)
        {
            for (int i = 1; i < 7; i++)
            {
                if(i!=prev1 && i!=prev2 && (prev1==0 || gcd(i, prev1) == 1))
                {
                    dp[n, prev1, prev2] = (dp[n, prev1, prev2] + DistinctSequences(n - 1, i, prev1)) % MOD;
                }
            }
        }
        return dp[n, prev1, prev2];
    }
}