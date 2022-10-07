class Solution {
public:
    void dfs(vector<vector<int>>&grid,int i,int j,vector<vector<bool>>& vis){
        if(i<0||j<0||i>=grid.size()||j>=grid[0].size()||vis[i][j]||grid[i][j]==0) return;
        vis[i][j]=1;
        dfs(grid,i+1,j,vis);
        dfs(grid,i-1,j,vis);
        dfs(grid,i,j+1,vis);
        dfs(grid,i,j-1,vis);
    }
    int h(vector<vector<int>>& grid){
        int res=0;
        vector<vector<bool>> vis(grid.size(),vector<bool>(grid[0].size(),false));
        for (int i = 0; i < grid.size(); i++)
        {
            for (int j = 0; j < grid[0].size(); j++)
            {
                if(!vis[i][j] && grid[i][j]==1){
                    dfs(grid,i,j,vis);
                    res++;
                }
            }            
        }        
        return res;
    }
    int minDays(vector<vector<int>>& grid) {
        int islands = h(grid);//count islands
        if(islands > 1 || islands == 0){//already disconnected
            return 0;
        }else{
            for (int i = 0; i < grid.size(); i++)
            {
                for (int j = 0; j < grid[0].size(); j++)
                {
                    if(grid[i][j]){
                        grid[i][j]=0;//remove a land and check islands
                        islands = h(grid);
                        grid[i][j]=1;//re-add land
                        if(islands>1 || islands==0){
                            return 1;
                        }
                    }       
                }                
            }            
        }
        return 2;
    }
};