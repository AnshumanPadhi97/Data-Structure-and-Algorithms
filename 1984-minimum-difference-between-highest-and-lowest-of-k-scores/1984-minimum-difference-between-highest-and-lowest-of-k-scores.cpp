class Solution {
public:
    int minimumDifference(vector<int>& nums, int k) {
        int n = nums.size();
        sort(begin(nums),end(nums));
        int res=INT_MAX;
        for(int i=k-1;i<n;i++){
            res=min(res,nums[i]-nums[i-k+1]);
        }
        return res;
    }
};