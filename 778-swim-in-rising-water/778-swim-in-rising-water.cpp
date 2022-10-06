class Solution {
public:
    int dir[5]={0,1,0,-1,0};
    int n;
    bool h(vector<vector<int>>& grid, bool vis[][50],int i,int j,int lvl){
        if(i<0||j<0||i>=n||j>=n||vis[i][j]||grid[i][j]>lvl){
            return false;
        }
        if(i==n-1 && j==n-1){
            return true;
        }
        vis[i][j]=true;
        for (int k = 0; k < 4; k++)
        {
            if(h(grid,vis,i+dir[k],j+dir[k+1],lvl)){
                return true;
            }
        }
        return false;
    }
    int swimInWater(vector<vector<int>>& grid) {
        n=grid.size();
        int l=0,r=n*n-1;
        bool vis[50][50];
        while (l<=r)
        {
            memset(vis,false,sizeof(vis));
            int mid = (l+r)/2;
            if(h(grid,vis,0,0,mid)){
                r=mid-1;
            }else{
                l=mid+1;
            }
        }
        return l;
    }
};