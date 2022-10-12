class Solution {
public:
    vector<int> loudAndRich(vector<vector<int>>& richer, vector<int>& quiet) {
        int n = quiet.size();
        
        vector<int> degree(n,0);
        vector<vector<int>> g(n);
        
        for (int i = 0; i < richer.size(); i++)
        {
            g[richer[i][0]].push_back(richer[i][1]);
            degree[richer[i][1]]++;
        }
        
        queue<int> q;
        vector<int> res(n,0);
        
        for (int i = 0; i < n; i++)
        {
            res[i]=i;
            if(degree[i]==0){
                q.push(i);
            }
        }
        while (!q.empty())
        {
            int x = q.front();
            q.pop();
            for(auto i:g[x]){
                if(quiet[res[i]]>quiet[res[x]]){
                    res[i]=res[x];
                }
                if(--degree[i]==0){
                    q.push(i);
                }
            }
        }        
        return res;
    }
};