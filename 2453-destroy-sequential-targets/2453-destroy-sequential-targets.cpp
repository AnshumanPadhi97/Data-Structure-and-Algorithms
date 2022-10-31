class Solution {
public:
    int destroyTargets(vector<int>& nums, int space) {
        unordered_map<int,int> m;
        
        int res = INT_MAX;
        int mx = INT_MIN;
        
        for(auto i:nums)
        {
            int r = i%space;
            m[r]++;
            mx=max(mx,m[r]);
        }
        
        for(auto i:nums)
        {
            if(mx==m[i%space])
            {
                res=min(res,i);
            }
        }
        return res;
    }
};