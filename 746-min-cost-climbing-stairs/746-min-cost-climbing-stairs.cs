public class Solution {
    public int MinCostClimbingStairs(int[] c) {
        var n = c.Length;
        int[] dp =new int[n];
        for(int i=0;i<n;i++){
            if(i<2)dp[i]=c[i];
            else dp[i]=Math.Min(dp[i-1],dp[i-2])+c[i];
        }
        return Math.Min(dp[n-1],dp[n-2]);
    }
}