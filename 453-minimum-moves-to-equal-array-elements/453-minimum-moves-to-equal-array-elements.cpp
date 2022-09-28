class Solution {
public:
    int minMoves(vector<int>& nums) {
        sort(begin(nums),end(nums));
        int res=0;
        for(int i=nums.size()-1;i>=0;i--){
            res+=nums[i]-nums[0];
        }
        return res;
    }
};