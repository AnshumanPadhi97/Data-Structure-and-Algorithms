class Solution {
public:
    int lengthOfLIS(vector<int>& nums) {
        
        int l = nums.size();
        int dp[l];
        for(int i=0;i<l;i++)dp[i]=1;
        
        for(int i=1;i<l;i++){
            for(int j=0;j<i;j++){
                if(nums[j]<nums[i]){
                    dp[i]=max(dp[i],dp[j]+1);
                }
            }
        }
        
        int res=0;
        for(int i=0;i<l;i++){
            res=max(res,dp[i]);
        }
        return res;
    }
};