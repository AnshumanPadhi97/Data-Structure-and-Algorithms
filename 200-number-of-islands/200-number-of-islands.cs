public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int res=0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]=='1'){
                   res++;
                    dfs(i,j,grid);
                }
            }
        }
        return res;
    }
    public void dfs(int i,int j,char[][] grid){
        if(i<0||j<0||i>=grid.Length||j>=grid[0].Length||grid[i][j]=='0')return;
        grid[i][j]='0';
        dfs(i+1,j,grid);
        dfs(i-1,j,grid);
        dfs(i,j+1,grid);
        dfs(i,j-1,grid);
    }
}