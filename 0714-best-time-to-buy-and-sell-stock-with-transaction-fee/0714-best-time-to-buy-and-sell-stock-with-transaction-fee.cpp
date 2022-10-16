class Solution {
public:
    int dp[50001][2];
    int h(vector<int>& prices,int ind,int buy,int fee){
        
        if(ind>=prices.size()) return 0;
        if(dp[ind][buy]!=-1) return dp[ind][buy];
        
        int profit=0;
        if(buy)
        {
            profit=max(-prices[ind]+h(prices,ind+1,0,fee),h(prices,ind+1,1,fee));
        }
        else
        {
            profit=max(prices[ind]-fee+h(prices,ind+1,1,fee),h(prices,ind+1,0,fee));
        }
        
        return dp[ind][buy]=profit;
    }
    int maxProfit(vector<int>& prices,int fee) {
        memset(dp,-1,sizeof(dp));
        return h(prices,0,1,fee);
    }
};