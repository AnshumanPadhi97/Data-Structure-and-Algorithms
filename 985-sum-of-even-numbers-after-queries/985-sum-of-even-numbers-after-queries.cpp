class Solution {
public:
    vector<int> sumEvenAfterQueries(vector<int>& nums, vector<vector<int>>& queries) {
        int sum=0;
        for (auto &&i : nums)
        {
            if(i%2==0)sum+=i;
        }
        vector<int> res(queries.size());
        for (int i = 0; i < queries.size(); i++)
        {
            int val = queries[i][0], ind = queries[i][1];
            if(nums[ind]%2==0){
                sum-=nums[ind];
            }
            nums[ind]+=val;
            if(nums[ind]%2==0){
                sum+=nums[ind];
            }
            res[i] = sum;
        }        
        return res;
    }
};