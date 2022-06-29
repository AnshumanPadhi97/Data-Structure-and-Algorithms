public class Solution {
    int[] dp = new int[46];
    public int ClimbStairs(int n) {
        return h(n);
    }
    public int h(int n){
        if(n==1)return 1;
        if(n==2)return 2;
        if(dp[n]>0)return dp[n];
        return dp[n] = h(n-1)+h(n-2);
    }
}