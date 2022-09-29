class Solution {
public:
    int minSwaps(vector<int>& nums) {
        
        int total = accumulate(nums.begin(),nums.end(),0);

        nums.insert(nums.end(),nums.begin(),nums.end());

        int i=0,j=0,l=nums.size();
        int res=INT_MAX,curr=0;
        
        while (j<l)
        {
            curr+=nums[j]==1;
            while (j-i+1==total)
            {
                res=min(res,total-curr);
                curr-=nums[i++]==1;
            }
            j++;
        }
        
        return res==INT_MAX?0:res;
    }
};