public class Solution {
    int[,] dp = new int[10001,14];
    public int CoinChange(int[] c, int t) {
        var a = h(c,t,c.Length);
        if(a==int.MaxValue-1)return -1;
        return a;
    }
    public int h(int[] c,int t,int i){
        if(i==0||t==0){
            if(t==0)return 0;
            return int.MaxValue-1;
        }
        if(dp[t,i]>0){
            return dp[t,i];
        }
        if(c[i-1]>t){
            return dp[t,i]=h(c,t,i-1);
        }else{
            return dp[t,i]=Math.Min(h(c,t,i-1),1+h(c,t-c[i-1],i));
        }
    }
}