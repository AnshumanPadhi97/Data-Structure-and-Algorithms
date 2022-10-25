public class Solution {
    int[][] h;
    int r;
    int c;
    int low;
    int high;
    int mid;
    bool[,] vis;
    public int MinimumEffortPath(int[][] h) {
        this.h = h;
        r = h.Length;
        c = h[0].Length;
        low = 0;
        high = (int)1E6 + 1;
        while(low<high){ 
            vis = new bool[r,c];
            mid = low+(high-low)/2;
            if(check(0,0,h[0][0])){
                high=mid;
            }else{
                low=mid+1;
            }
        }
        return low;
    }
    public bool check(int i,int j,int prev){
        if(i<0||j<0||i>=r||j>=c||vis[i,j]||Math.Abs(prev-h[i][j])>mid) return false;
        
        if(i==r-1 && j==c-1){
            return true;
        }
        
        vis[i,j]=true;
        
        return check(i+1,j,h[i][j]) || check(i,j+1,h[i][j]) || check(i-1,j,h[i][j]) || check(i,j-1,h[i][j]);
    }
}