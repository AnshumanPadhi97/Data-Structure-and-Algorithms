public class Solution {
    int[] dp = new int[100];
    public int Fib(int n) {
        if(n==0||n==1)return n;
        if(dp[n]>0)return dp[n];
        return Fib(n-1)+Fib(n-2);
    }
}