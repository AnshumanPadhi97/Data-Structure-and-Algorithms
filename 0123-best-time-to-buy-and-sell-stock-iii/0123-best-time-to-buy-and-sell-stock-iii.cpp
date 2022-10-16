class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int n = prices.size();
        
        int dp[n+1][2][3];
        memset(dp,0,sizeof(dp));
        
        for (int i = n-1; i >= 0; i--)
        {
            for (int buy = 0; buy < 2; buy++)
            {
                for (int cap = 1; cap <= 2; cap++)
                {
                    if(buy){
                        dp[i][buy][cap]=max(-prices[i]+dp[i+1][0][cap],dp[i+1][1][cap]);
                    }
                    else{
                        dp[i][buy][cap]=max(prices[i]+dp[i+1][1][cap-1],dp[i+1][0][cap]);
                    }
                }                
            }            
        }
        
        return dp[0][1][2];
    }
};