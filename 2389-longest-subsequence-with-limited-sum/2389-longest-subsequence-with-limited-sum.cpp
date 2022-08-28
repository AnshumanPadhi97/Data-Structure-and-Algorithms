class Solution {
public:
    vector<int> answerQueries(vector<int>& nums, vector<int>& queries) {
        int n = nums.size();
        int m = queries.size();

        vector<int> res(m);
        sort(nums.begin(),nums.end());

        partial_sum(begin(nums),end(nums),begin(nums));

        for (int i = 0; i < m; i++)
        {
            res[i] = upper_bound(nums.begin(),nums.end(),queries[i]) - nums.begin();
        }

        //output_vector(res);
        return res;
    }
};