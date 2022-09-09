class Solution {
public:
    int shortestPath(vector<vector<int>>& grid, int k) {
    int m = grid.size();
    int n = grid[0].size();
    
    vector<vector<int>> vis(m,vector<int>(n,-1));
    queue<vector<int>> q;
    
        // queue stores (x,y,current path length,number of obstacles we can still remove)
    q.push({0,0,0,k});
    while (!q.empty())
    {
        auto t = q.front();
        int x = t[0];
        int y = t[1];
        q.pop();

        if(x<0 || y<0 || x>=m || y>=n)continue;

        if(x==m-1 && y==n-1)return t[2];

        if(grid[x][y]==1){
            if(t[3]>0){
                t[3]--;
            }else{
                continue;
            }
        }
        // The cell was previously visited by some path and we were able to remove more obstacles from the previous path.
		// Then we don't need to continue on our current path
        if(vis[x][y]!=-1 && vis[x][y]>=t[3]){
            continue;
        }
        vis[x][y]=t[3];
        
        q.push({x+1,y,t[2]+1,t[3]});
        q.push({x,y+1,t[2]+1,t[3]});
        q.push({x-1,y,t[2]+1,t[3]});
        q.push({x,y-1,t[2]+1,t[3]});
    }
    
    return -1;
}
};