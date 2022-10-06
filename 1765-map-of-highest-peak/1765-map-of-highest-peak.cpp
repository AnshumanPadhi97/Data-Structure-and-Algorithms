class Solution {
public:
    vector<vector<int>> highestPeak(vector<vector<int>>& grid) {
        int m = grid.size();
        int n = grid[0].size();
        
        queue<pair<int,int>> q;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(grid[i][j]==1){
                    q.push({i,j});
                    grid[i][j]=0;
                }else{
                    grid[i][j]=-1;
                }
            }            
        }
        
        int dir[]={0,1,0,-1,0};
        int step=1;
        while (!q.empty())
        {
            int l = q.size();
            while (l--)
            {
                pair<int,int> a = q.front();
                q.pop();
                for (int i = 0; i < 4; i++)
                {
                    int nx = a.first+dir[i];
                    int ny = a.second+dir[i+1];
                    if(nx<0||ny<0||nx>=m||ny>=n||grid[nx][ny]!=-1){
                        continue;
                    }else{
                        grid[nx][ny]=step;
                        q.push({nx,ny});
                    }
                }                
            }
            step++;
        }
        return grid;        
    }
};