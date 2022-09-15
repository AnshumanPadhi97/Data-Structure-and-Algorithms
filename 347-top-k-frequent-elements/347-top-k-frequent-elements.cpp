class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        unordered_map<int,int> m;
        for (int i = 0; i < nums.size(); i++)
        {
            m[nums[i]]++;
        }
        vector<int> res;
        priority_queue<pair<int,int>> q;
        for (auto &&i : m)
        {
            q.push({i.second,i.first});
        }
        while (k)
        {
            auto a = q.top();
            q.pop();
            k--;
            res.push_back(a.second);
        }
        return res;
    }
};