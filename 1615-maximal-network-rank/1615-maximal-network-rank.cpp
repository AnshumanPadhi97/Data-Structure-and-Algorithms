class Solution {
public:
    int maximalNetworkRank(int n, vector<vector<int>>& roads) {
        bool vis[n][n];
        memset(vis,false,sizeof(vis));
        int count[n];
        memset(count,0,sizeof(count));
        for (int i = 0; i < roads.size(); i++)
        {
            int u = roads[i][0];
            int v = roads[i][1];
            vis[u][v]=true;
            vis[v][u]=true;
            count[u]++;
            count[v]++;
        }
        int res=0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i+1; j < n; j++)
            {
                int curr = count[i]+count[j]-vis[i][j];
                res=max(res,curr);
            }
        }
        return res;
    }
};