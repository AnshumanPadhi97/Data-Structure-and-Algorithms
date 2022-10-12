class Solution {
public:
    
    int dfs(int u,vector<int> *g,vector<int>& dp,vector<int>& time){
        if(dp[u]!=-1) return dp[u];
        
        int curr=0;
        for(auto i:g[u])
        {
            curr=max(curr,dfs(i,g,dp,time));
        }
        
        return dp[u]=curr+time[u];
    }
    
    int minimumTime(int n, vector<vector<int>>& relations, vector<int>& time) {
        vector<int> g[n+1];
        set<int> s;
        
        for (int i = 0; i < n; i++)
        {
            s.insert(i);
        }
        
        for(auto i:relations)
        {
            g[i[0]-1].push_back(i[1]-1);
            s.erase(i[1]-1);
        }

        int res=0;
        
        vector<int> dp(n,-1);
        for(auto i: s){
            res=max(res,dfs(i,g,dp,time));
        }
        
        return res;
    }
};