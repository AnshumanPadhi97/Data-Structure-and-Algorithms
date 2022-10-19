class Solution {
public:
    void nextPermutation(vector<int>& nums) {
        int l = nums.size();
        int ind=-1;
        for(int i=l-2;i>=0;i--){
            if(nums[i]<nums[i+1]){
                ind=i;
                break;
            }
        }
        if(ind==-1){
            reverse(nums.begin(),nums.end());
            return;
        }
        else{
            int j;
            for(j=l-1;j>ind;j--){
                if(nums[j]>nums[ind]){
                    break;
                }
            }
            swap(nums[ind],nums[j]);
            reverse(nums.begin()+ind+1,nums.end());
        }
    }
};