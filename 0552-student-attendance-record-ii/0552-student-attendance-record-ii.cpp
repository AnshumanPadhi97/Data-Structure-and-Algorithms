#define MOD (int)1000000007

class Solution {
public:
    int checkRecord(int n) {
        int dp[n+1][2][3];
        for (int i = 0; i < 2; i++)//base condition
        {
            for (int j = 0; j < 3; j++)
            {
                dp[n][i][j]=1;
            }            
        }
        for (int i = n-1; i >= 0; i--)
        {
            for (int a = 0; a < 2; a++)
            {
                for (int l = 0; l < 3; l++)
                {
                    dp[i][a][l] = dp[i+1][a][0];
                    if(a==0){
                        dp[i][0][l] = (dp[i][0][l] + dp[i+1][1][0])%MOD;
                    }
                    if(l<2){
                        dp[i][a][l] = (dp[i][a][l] + dp[i+1][a][l+1])%MOD;
                    }
                }                
            }            
        }
        return dp[0][0][0];
    }
};