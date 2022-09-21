class Solution {
public:
    int res=0;
    int dir[5]{0,1,0,-1,0};
    void dfs(vector<vector<int>>& grid,int x,int y,int vis){
        if(x<0||y<0||x>=grid.size()||y>=grid[0].size()||grid[x][y]==-1||grid[x][y]==3)return;
        if(grid[x][y]==2){
            if(vis==0){
                res++;
            }
            return;
        }
        grid[x][y]=3;
        for (int i = 0; i < 4; i++)
        {
            dfs(grid,x+dir[i],y+dir[i+1],vis-1);
        }
        grid[x][y]=0;        
    }
    int uniquePathsIII(vector<vector<int>>& grid) {
        int m=grid.size();
        int n=grid[0].size();
        int x=0,y=0;
        int vis=0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(grid[i][j]==1){
                    x=i;y=j;
                }
                else if(grid[i][j]!=-1)vis++;
            }            
        }
        dfs(grid,x,y,vis);
        return res;
    }
};