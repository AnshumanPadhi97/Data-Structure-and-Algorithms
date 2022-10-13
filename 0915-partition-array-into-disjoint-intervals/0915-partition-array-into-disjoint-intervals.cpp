class Solution {
public:
    int partitionDisjoint(vector<int>& nums) {
        int maxNow = nums[0];
        int maxInLeftPartition = nums[0];
        int res=0;
        for (int i = 1; i < nums.size(); i++)
        {
            maxNow = max(maxNow,nums[i]);
            if(nums[i]<maxInLeftPartition){
                maxInLeftPartition = maxNow;
                res=i;
            }
        }        
        return res+1;
    }
};