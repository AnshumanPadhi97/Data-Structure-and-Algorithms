class Solution {
public:
    int dp[10001];
    
    int h(vector<int>& sum,int i)
    {
        if(i>=sum.size())return 0;
        
        if(dp[i]!=-1)return dp[i];

        return dp[i] = max(h(sum,i+1),h(sum,i+2)+sum[i]);
    }
    
    int deleteAndEarn(vector<int>& nums) {
        
        int n = 10001;
        
        vector<int> sum(n,0);//sum of all same numbers
        for (auto &&i : nums)
        {
            sum[i]+=i;
        }
        
        memset(dp,-1,sizeof(dp));
        
        return h(sum,0);
    }
};