class Solution {
public:
    pair<int,int> h(int x,int n){
        int r = n-(x-1)/n-1;
        int c = (x-1)%n;
        if(r%2==n%2)
            return {r,n-c-1};
        return {r,c};
    }

int snakesAndLadders(vector<vector<int>>& board) {
	int n = board.size();
	vector<vector<bool>> vis(n,vector<bool>(n));
	queue<int> q;
	q.push(1);
	vis[n-1][0]=true;
	int res=0;
	while (!q.empty())
	{
		int l = q.size();
		while (l--)
		{
			int u=q.front();
			q.pop();
			if(u==n*n)return res;
			for (int i = 1; i <= 6; i++)
			{
				int next= u+i;
				if(next>n*n){
					break;
				}
				auto p = h(next,n);

				if(vis[p.first][p.second])continue;
				vis[p.first][p.second]=true;

				if(board[p.first][p.second]!=-1)
				{
					q.push(board[p.first][p.second]);
				}
				else
				{
					q.push(next);
				}
			}
		}
		res++;		
	}
	return -1;
}

};