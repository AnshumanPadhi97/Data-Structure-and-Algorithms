class Solution {
public:
    int orangesRotting(vector<vector<int>>& grid) {
        int m = grid.size();
        int n = grid[0].size();
        int fresh=0;
        queue<pair<int,int>> q;
        for(int i=0;i<m;i++){
            for (int j = 0; j < n; j++)
            {
                if(grid[i][j]==1)fresh++;
                if(grid[i][j]==2){
                    q.push({i,j});
                }
            }            
        }
        if(fresh==0)return 0;
        int res=-1;
        int dir[]={0,1,0,-1,0};
        while (!q.empty())
        {
            int l = q.size();
            while (l-->0)
            {
                pair<int,int> a = q.front();
                q.pop();
                for(int i=0;i<4;i++){
                    int nx = a.first+dir[i];
                    int ny = a.second+dir[i+1];
                    if(nx<0||ny<0||nx>=m||ny>=n||grid[nx][ny]!=1)continue;
                    grid[nx][ny]=2;
                    q.push({nx,ny});
                    fresh--;
                }
            }
            res++;
        }
        if(fresh>0)return -1;
        if(res==-1)return 0;
        return res;
    }
};