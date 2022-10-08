class Solution {
public:
    double frogPosition(int n, vector<vector<int>>& edges, int t, int target) {
        vector<vector<int>> graph(n+1);
        for (auto &&i : edges)
        {
            graph[i[0]].push_back(i[1]);
            graph[i[1]].push_back(i[0]);
        }
        vector<double> prob(n+1,0);
        queue<int> q;
        q.push(1);
        vector<bool> vis(n+1,0);
        vis[1]=1;
        prob[1] = 1.0;
        while (!q.empty() && t--)
        {
            int l = q.size();
            while (l--)
            {
                int u = q.front(); q.pop();
                int unvis = 0;
                for (auto &&i : graph[u])
                {
                    if(!vis[i]){
                        unvis++;
                    }
                }
                for (auto &&i : graph[u])
                {
                    if(!vis[i]){
                        q.push(i);
                        vis[i]=1;
                        prob[i] = prob[u] / unvis;
                    }
                }
                if(unvis>0){
                    prob[u]=0;
                }
            }
        }
        return prob[target];
    }
};