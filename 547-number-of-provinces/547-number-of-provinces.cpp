class Solution {
public:
    void dfs(vector<vector<int>>& grid,int i){
        for (int j = 0; j < grid.size(); j++)
        {
            if(grid[i][j]){
                grid[i][j]=grid[j][i]=0;
                dfs(grid,j);
            }
        }
    }
    int findCircleNum(vector<vector<int>>& isConnected) {
        int n = isConnected.size();
        int res=0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(isConnected[i][j]){
                    dfs(isConnected,i);
                    res++;
                }
            }
        }
        return res;
    }
};