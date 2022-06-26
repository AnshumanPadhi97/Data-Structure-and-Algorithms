/*
 There is a street with n * 2 plots, where there are n plots on each side of the street. The plots on each side are numbered from 1 to n. On each plot, a house can be placed.

Return the number of ways houses can be placed such that no two houses are adjacent to each other on the same side of the street. 
Since the answer may be very large, return it modulo 109 + 7.

Note that if a house is placed on the ith plot on one side of the street, a house can also be placed on the ith plot on the other side of the street.
 */

public class Solution2320
{
    public int CountHousePlacements(int n)
    {
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