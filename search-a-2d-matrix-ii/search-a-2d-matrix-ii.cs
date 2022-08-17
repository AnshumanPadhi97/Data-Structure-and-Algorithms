public class Solution {
    public bool SearchMatrix(int[][] grid, int t) {
        int m=grid.Length;
        int n=grid[0].Length;
        int i=0,j=n-1;
        while(i<m && j>=0){
            if(grid[i][j]==t){
                return true;
            }else{
                if(grid[i][j]>t){
                    j--;
                }else{
                    i++;
                }
            }
        }
        return false;
    }
}