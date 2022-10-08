class Solution {
public:
    int threeSumClosest(vector<int>& nums, int target) {
        sort(nums.begin(),nums.end());
        
        int n = nums.size();
        int res = nums[0] + nums[1] + nums[2];
        
        for (int i = 0; i < n-2; i++)
        {
            int l = i+1, r = n-1;
            while (l<r)
            {
                int curr = nums[l]+nums[r]+nums[i];
                if(abs(curr-target)<abs(res-target))
                {
                    res=curr;
                }
                else if(curr==target) break;
                
                if(curr>target){
                    r--;
                }else{
                    l++;
                }
            }                        
        }        
        return res;
    }
};