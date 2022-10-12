class Solution {
public:
    int minimumTime(int n, vector<vector<int>>& relations, vector<int>& time) {
        vector<vector<int>> g(n,vector<int>());
        vector<int> indegree(n);
        
        for(auto i:relations){
            indegree[i[1]-1]++;
            g[i[0]-1].push_back(i[1]-1);
        }
        
        vector<int> dist(n);
        queue<int> q;
        
        for (int i = 0; i < n; i++)
        {
            if(indegree[i]==0){
                q.push(i);
                dist[i]=time[i];
            }
        }
        
        while (!q.empty())
        {
            int x = q.front();
            q.pop();
            for(auto v:g[x]){
                dist[v]=max(dist[v],dist[x]+time[v]);//update distance
                indegree[v]--;
                if(indegree[v]==0){
                    q.push(v);
                }
            }
        }
        return *max_element(dist.begin(),dist.end());
    }
};