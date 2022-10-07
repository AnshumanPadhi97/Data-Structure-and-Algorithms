class Solution {
public:
    bool possible(vector<vector<int>>& cells,int row,int col,int day){
        int dir[5]={0,1,0,-1,0};
        vector<vector<int>> grid(row,vector<int>(col,0));
        for (int i = 0; i < day; i++)
        {
            grid[cells[i][0]-1][cells[i][1]-1]=1;
        }
        queue<pair<int,int>> q;
        for (int i = 0; i < col; i++)
        {
            if(grid[0][i]==0){
                q.push({0,i});
                grid[0][i]=1;
            }
        }
        while (!q.empty())
        {
            pair<int,int> a = q.front(); q.pop();
            if(a.first == row-1) return true;
            for (int i = 0; i < 4; i++)
            {
                int nx = a.first+dir[i];   
                int ny = a.second+dir[i+1];   
                if(nx<0||ny<0||nx>=row||ny>=col||grid[nx][ny]==1) continue;
                q.push({nx,ny});
                grid[nx][ny]=1;
            }                       
        }
        return false;
    }

    int latestDayToCross(int row, int col, vector<vector<int>>& cells) {
        int low=1,high=cells.size();
        int res=0;
        while (low<=high)
        {
            int mid=(low+high)/2;
            if(possible(cells,row,col,mid)){
                low=mid+1;
                res=mid;
            }else{
                high=mid-1;
            }
        }
        return res;
    }
};