class Solution {
public:
    int numberOfArithmeticSlices(vector<int>& nums) {
        if(nums.size() < 3)
            return 0;
        
        int cnt = 0, ind = 0;
        int a = nums[1] - nums[0];
        
        for(int i = 1; i<nums.size()-1 ; ++i)
        {
            int b = nums[i+1] - nums[i];
            if(b == a)
            {
                ind++;
            }            
            else
            {
                a = b;
                ind = 0;
            }
            cnt += ind;
        }
        return cnt;
    }
};