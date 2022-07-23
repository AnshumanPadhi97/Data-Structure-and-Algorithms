public class Solution {
    int[,] dp = new int[501,501];
    public int MinDistance(string word1, string word2) {
        int a = word1.Length;
        int b = word2.Length;
        return h(word1,word2,a,b);
    }
    public int h(string s,string p,int i,int j){
        if(i==0)return j;
        if(j==0)return i;
        if(dp[i,j]>0)return dp[i,j];
        if(s[i-1]==p[j-1]){
            return dp[i,j]=h(s,p,i-1,j-1);
        }else{
            return dp[i,j]=1+Math.Min(h(s,p,i-1,j-1),Math.Min(h(s,p,i-1,j),h(s,p,i,j-1)));
        }
    }
}