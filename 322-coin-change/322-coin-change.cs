public class Solution {
    int[,] dp = new int[10001,14];
    public int CoinChange(int[] coins, int t) {
        Array.Sort(coins);
        var a = h(coins,t,coins.Length);
        if(a==int.MaxValue-1)return -1;
        return a;
    }
    public int h(int[] coins,int t,int i){
        if(i==0||t==0){
            if(t==0)return 0;
            return int.MaxValue-1;
        }
        if(dp[t,i]>0)return dp[t,i];
        if(coins[i-1]>t){
            return h(coins,t,i-1);
        }else{
            return dp[t,i]=Math.Min(h(coins,t,i-1),1+h(coins,t-coins[i-1],i));
        }
    }
}