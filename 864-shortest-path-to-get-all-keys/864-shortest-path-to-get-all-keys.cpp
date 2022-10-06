class Solution {
public:
    int shortestPathAllKeys(vector<string>& grid) {
        int m = grid.size();
        int n = grid[0].size();
        int K=0;
        int res=0;
        vector<int> dir{0,1,0,-1,0};
        vector<vector<vector<bool>>> vis(m,vector<vector<bool>>(n,vector<bool>(64,0)));//state for traversing the grid (additional keys state)
        queue<pair<int,int>> q;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(grid[i][j]=='@'){
                    q.push({i*n+j,0});
                    vis[i][j][0]=1;
                }
                if(grid[i][j]>='A'&&grid[i][j]<='F'){
                    K++;
                }
            }            
        }
        while (!q.empty())
        {
            int l = q.size();
            while (l--)
            {
                pair<int,int> a = q.front();
                q.pop();
                int x = a.first/n;
                int y = a.first%n;
                int carrying = a.second;
                if(carrying == (1<<K)-1){//have all the keys i.e 64(111111)
                    return res;
                }
                for (int j = 0; j < 4; j++)
                {
                    int nx = x+dir[j];
                    int ny = y+dir[j+1];
                    int k = carrying;
                    if(nx<0||ny<0||nx>=m||ny>=n){
                        continue;
                    }
                    if(grid[nx][ny]=='#'){
                        continue;
                    }
                    if(grid[nx][ny]>='a'&&grid[nx][ny]<='f'){//collect the key
                        k=k|(1<<(grid[nx][ny]-'a'));
                    }
                    if(grid[nx][ny]>='A'&&grid[nx][ny]<='F'){
                        if(!(carrying & (1<<(grid[nx][ny]-'A')))){//if we are not carrying that key
                            continue;
                        }
                    }
                    if(!vis[nx][ny][k]){
                        vis[nx][ny][k]=1;
                        q.push({nx*n+ny,k});
                    }
                }
            }
            res++;        
        }
        return -1;
    }
};