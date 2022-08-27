class Solution {
public:
    int networkDelayTime(vector<vector<int>>& times, int n, int k) {
        vector<vector<int>> dist(n+1,vector<int>(n+1,1e9));
        for (auto &&i : times)
        {
            dist[i[0]][i[1]]=i[2];
        }
        for (int i = 1; i <= n; i++)
        {
            dist[i][i]=0;
        }
        for (int k = 1; k <= n; k++)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    dist[i][j] = min(dist[i][j],dist[i][k]+dist[k][j]);
                }
            }
        }
        int res=0;
        for (int i = 1; i <= n; i++)
        {
            if(dist[k][i]==1e9){
                return -1;
            }
            res=max(res,dist[k][i]);
        }    
        return res;
    }
};