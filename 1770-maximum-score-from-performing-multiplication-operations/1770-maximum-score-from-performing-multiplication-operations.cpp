class Solution {
public:
    int dp[1001][1001];
    int dfs(vector<int>& nums, vector<int>& mults, int i, int l, int r)
    {
        if(i>=mults.size()) return 0;
        
        if(dp[l][i]!=1e9){
            return dp[l][i];
        }
        
        int a = (mults[i] * nums[l]) + dfs(nums,mults,i+1,l+1,r);
        int b = (mults[i] * nums[r]) + dfs(nums,mults,i+1,l,r-1);
        
        return dp[l][i] = max(a,b);
    }
    int maximumScore(vector<int>& nums, vector<int>& multipliers) {
        
        for(int i=0; i<1000; i++)
        {
             for(int j=0; j<1000; j++)
             {
                 dp[i][j] = 1e9;
             }
        }
        
        return dfs(nums,multipliers,0,0,nums.size()-1);
    }
};