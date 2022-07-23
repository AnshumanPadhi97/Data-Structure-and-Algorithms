public class Solution {
    int res=0;
    public int MaxAreaOfIsland(int[][] grid) {
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j]==1){
                    res = Math.Max(res,dfs(grid,i,j));
                }
            }
        }
        return res;
    }
    public int dfs(int[][] grid,int i,int j){
        if(i<0||j<0||i>=grid.Length||j>=grid[0].Length||grid[i][j]==0){
            return 0;
        }
        grid[i][j]=0;
        return 1+dfs(grid,i+1,j)+dfs(grid,i-1,j)+dfs(grid,i,j+1)+dfs(grid,i,j-1);
    }
}