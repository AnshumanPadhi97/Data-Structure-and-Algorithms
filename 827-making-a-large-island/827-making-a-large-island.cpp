class Solution {
public:
    unordered_map<int,int> areas;
    void dfs(vector<vector<int>>& grid,int i,int j,int color){
        if(i<0||j<0||i>=grid.size()||j>=grid.size()||grid[i][j]!=1){
            return;
        }
        grid[i][j]=color;
        areas[color]+=1;
        dfs(grid,i+1,j,color);
        dfs(grid,i-1,j,color);
        dfs(grid,i,j+1,color);
        dfs(grid,i,j-1,color);
    }
    int largestIsland(vector<vector<int>>& grid) {
        int res=0;
        int n = grid.size();
        int nextColor = 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(grid[i][j]){
                    dfs(grid,i,j,nextColor++);//create color wise areas
                    res=max(res,areas[nextColor-1]);
                }
            }            
        }
        int dir[5]={0,1,0,-1,0};
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(grid[i][j]==0){
                    unordered_set<int> neighborColors;
                    for (int k = 0; k < 4; k++)
                    {
                        int nx = i + dir[k];
                        int ny = j + dir[k+1];
                        if(nx<0||ny<0||nx>=n||ny>=n||grid[nx][ny]==0) continue;
                        neighborColors.insert(grid[nx][ny]);
                    }
                    //generate max area which can be made
                    //from neighbors
                    int curr = 1;
                    for (auto &&color : neighborColors)
                    {
                        curr += areas[color];
                    }
                    res=max(curr,res);
                }       
            }            
        }        
        return res;
    }
};