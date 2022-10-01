public class Solution {
    int[] dp = new int[101];
    public int NumDecodings(string s) {
        return s.Length == 0 ? 0 : h(s,0);
    }
    public int h(string s,int i){
        if(dp[i]>0)return dp[i];
        int n = s.Length;
        if(i==n)return dp[i]=1;
        if(s[i]=='0')return dp[i]=0;
        int res = h(s,i+1);
        if(i<n-1 && (s[i]=='1' || (s[i]=='2' && s[i+1]<'7'))){
            res+=h(s,i+2);
        }
        return dp[i]=res;
    }
}