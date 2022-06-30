public class Solution {
    public int UniquePaths(int m, int n) {
        int[][] dp = new int[101][];
        for(int i=0;i<101;i++){
            dp[i]=new int[101];
            for(int j=0;j<101;j++){
                dp[i][j]=1;
            }
        }
        for(int i=1;i<m;i++){
            for(int j=1;j<n;j++){
                dp[i][j]=dp[i-1][j]+dp[i][j-1];
            }   
        }
        return dp[m-1][n-1];
    }
}