public class Solution {
    int[] dp = new int[101];
    public int NumDecodings(string s) {
        if(s.Length==1 && s[0]=='0') return 0;
        
        Array.Fill(dp,-1);
        return h(s,0);
    }
    public int h(string s,int i){
        if(i>s.Length) return 0;
        
        if(i==s.Length) return 1;
        
        if(dp[i]>0) return dp[i];
        
        int res=0;
        
        //single digits
        if(s[i]!='0'){
            res += h(s,i+1);
        }
        
        //2 digits
        if(i+1<s.Length && (s[i]=='1' || (s[i]=='2' && s[i+1]<='6'))){
            res += h(s,i+2);
        }
        
        return dp[i] = res;
    }
}