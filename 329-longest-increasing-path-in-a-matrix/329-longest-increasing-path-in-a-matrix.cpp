class Solution {
public:
    int longestIncreasingPath(vector<vector<int>>& matrix) {
        int m=matrix.size(),n=matrix[0].size();

        //create indegree array
        int indegree[m][n];
	    memset(indegree,0,sizeof(indegree));
        int dir[]={1,0,-1,0,1};
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int nx = dir[k] + i;	
                    int ny = dir[k+1] + j;	
                    if(nx>=0 && nx<m && ny>=0 && ny<n){
                        if(matrix[nx][ny]>matrix[i][j]){//lower -> higher
                            indegree[nx][ny]++;
                        }
                    }
                }			
            }		
        }

        queue<pair<int,int>> q;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(indegree[i][j]==0){
                    q.push({i,j});
                }
            }		
        }

        //topo sort
        int res=0;
        while (!q.empty())
        {
            res++;
            int l = q.size();
            while (l--)
            {
                auto u = q.front();
                q.pop();
                for (int i = 0; i < 4; i++)
                {
                    int nx = u.first + dir[i];	
                    int ny = u.second + dir[i+1];
                    if(nx>=0 && nx<m && ny>=0 && ny<n){
                        if(matrix[nx][ny]>matrix[u.first][u.second]){
                            indegree[nx][ny]--;
                            if(indegree[nx][ny]==0){
                                q.push({nx,ny});
                            }
                        }
                    }
                }			
            }

        }
        return res;        
    }
};