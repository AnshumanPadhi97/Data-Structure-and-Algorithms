class Solution {
public:
    vector<int> topo(vector<vector<int>>& g,int k){
        vector<int> cnt(k+1,0);
        vector<int> adj[k+1];
        vector<int> res;
        queue<int> q;
        for (auto &&i : g)
        {
            cnt[i[1]]++;
            adj[i[0]].push_back(i[1]);
        }
        for (int i = 1; i <= k; i++)
        {
            if(cnt[i]==0){
                q.push(i);
            }
        }

        while (!q.empty())
        {
            int t = q.front();
            q.pop();
            res.push_back(t);
            for (auto &&i : adj[t])
            {
                cnt[i]--;
                if(cnt[i]==0){
                    q.push(i);
                }
            }
        }
        return res;
}

vector<vector<int>> buildMatrix(int k, vector<vector<int>>& rowConditions, vector<vector<int>>& colConditions) {
        vector<vector<int>> res(k,vector<int> (k,0));

        vector<int> row = topo(rowConditions,k);
        if(row.size()!=k)return {};

        vector<int> col = topo(colConditions,k);
        if(col.size()!=k)return {};

        vector<int> idx(k+1,0);
        for (int j = 0; j < col.size(); j++)
        {
            idx[col[j]]=j;
        }

        for (int i = 0; i < k; i++)
        {
            res[i][idx[row[i]]]=row[i];
        }		

        return res;
    }
};