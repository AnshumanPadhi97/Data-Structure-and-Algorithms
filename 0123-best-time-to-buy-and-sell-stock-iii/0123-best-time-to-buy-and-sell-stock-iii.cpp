class Solution {
public:
    int dp[100001][2][3];
    int h(vector<int>& prices,int i,int buy,int cap){
        if(i>=prices.size()) return 0;
        if(cap==0) return 0;
        if(dp[i][buy][cap]!=-1)return dp[i][buy][cap];
        int profit=0;
        if(buy){
            profit=max(-prices[i]+h(prices,i+1,0,cap),h(prices,i+1,1,cap));
        }
        else{
            profit=max(prices[i]+h(prices,i+1,1,cap-1),h(prices,i+1,0,cap));
        }
        return dp[i][buy][cap]=profit;
    }
    int maxProfit(vector<int>& prices) {
        memset(dp,-1,sizeof(dp));
        return h(prices,0,1,2);
    }
};