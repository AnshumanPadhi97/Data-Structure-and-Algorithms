class Solution {
public:
    int countServers(vector<vector<int>>& grid) {
        int m = grid.size();
        int n = grid[0].size();
        vector<int> rc(m,0);
        vector<int> cc(n,0);
        int res=0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(grid[i][j]!=1)continue;
                rc[i]++;
                cc[j]++;
            }            
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(grid[i][j] && (rc[i]>1 || cc[j]>1)){
                    res++;
                }
            }            
        }
        return res;
    }
};