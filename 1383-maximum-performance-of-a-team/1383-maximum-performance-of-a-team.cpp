class Solution {
public:
    int maxPerformance(int n, vector<int>& speed, vector<int>& efficiency, int k) {
        int MOD = 1e9 + 7;
        vector<pair<int,int>> candidates(n);
        
        for (int i = 0; i < n; i++)
        {
            candidates[i] = {efficiency[i],speed[i]};
        }
        
        sort(candidates.rbegin(),candidates.rend());
        
        // candidates: [{9, 1}, {7 ,5}, {5, 2}, {4, 10}, {3, 3}, {2, 8}]
        
        long speedSum = 0, ans = 0;
        priority_queue<int,vector<int>,greater<int>> q;
        
        for (auto i : candidates)
        {
            q.push(i.second);
            speedSum+=i.second;
            
            if(q.size()>k)
            {
                speedSum-=q.top();
                q.pop();
            }
            
            ans=max(ans,speedSum*i.first);
        }
        
        return ans%MOD;
    }
};