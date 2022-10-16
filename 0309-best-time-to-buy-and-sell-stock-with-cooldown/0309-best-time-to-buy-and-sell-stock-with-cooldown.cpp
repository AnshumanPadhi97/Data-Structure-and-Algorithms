class Solution {
public:
    int dp[5001][2];
    int h(vector<int>& prices,int ind,int buy){
        if(ind>=prices.size()) return 0;
        
        if(dp[ind][buy]!=-1) return dp[ind][buy];
        
        int profit=0;
        
        if(buy)
        {
            profit=max(-prices[ind]+h(prices,ind+1,0),h(prices,ind+1,1));
        }
        else
        {
            profit=max(prices[ind]+h(prices,ind+2,1),h(prices,ind+1,0));
        }
        
        return dp[ind][buy]=profit;
    }
    
    int maxProfit(vector<int>& prices) {
        memset(dp,-1,sizeof(dp));
        return h(prices,0,1);
    }
};