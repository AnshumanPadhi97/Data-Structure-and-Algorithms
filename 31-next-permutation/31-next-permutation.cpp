class Solution {
public:
    void nextPermutation(vector<int>& nums) {
        int n = nums.size();
        int ind=-1;
        int val = 0;
        for(int i=n-2;i>=0;i--){
            if(nums[i]<nums[i+1]){
                ind=i;
                val=nums[i];
                break;
            }
        }
        if(ind==-1){
            reverse(begin(nums),end(nums));
            return;
        }
        int j;
        for(j=n-1;j>ind;j--){
            if(nums[j]>nums[ind]){
                break;
            }
        }
        swap(nums[j],nums[ind]);
        reverse(begin(nums)+ind+1,end(nums));
    }
};