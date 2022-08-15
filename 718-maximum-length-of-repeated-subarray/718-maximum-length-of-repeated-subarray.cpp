class Solution {
public:
    int dp[1001][1001];
    int res=0;

    int findLength(vector<int>& nums1, vector<int>& nums2) {
        memset(dp,-1,sizeof(dp));
        h(nums1,nums2,0,0);
        return res;    
    }

    int h(vector<int> &nums1,vector<int> &nums2,int i,int j){
        if(i>=nums1.size() || j>=nums2.size())return 0;
        if(dp[i][j]!=-1)return dp[i][j];
        h(nums1,nums2,i+1,j);
        h(nums1,nums2,i,j+1);
        dp[i][j] = nums1[i]==nums2[j] ? 1 + h(nums1,nums2,i+1,j+1) : 0;
        res=max(res,dp[i][j]);
        return dp[i][j];
    }
};