class Solution {
public:
    vector<int> findMinHeightTrees(int n, vector<vector<int>>& edges) {
        
        int l = edges.size();
        if(n==1) return vector<int>{0};

        vector<int> degree(n,0);
        vector<vector<int>> g(n);
        for (auto &&i : edges)
        {
            degree[i[0]]++;
            degree[i[1]]++;
            g[i[0]].push_back(i[1]);
            g[i[1]].push_back(i[0]);
        }
        
        queue<int> q;
        for (int i = 0; i < n; i++)
        {
            if(degree[i]==1){
                q.push(i);
            }
        }
        
        vector<int> res;
        while (!q.empty())
        {
            int l = q.size();
            res.clear();
            //circle inwards like topo sort to get root node(which will finally have less height)
            while (l--)
            {
                int x = q.front();
                q.pop();
                res.push_back(x);
                
                for(auto v:g[x])
                {
                    degree[v]--;
                    if(degree[v]==1){
                        q.push(v);
                    }
                }
            }            
        }        
        return res;
    }
};