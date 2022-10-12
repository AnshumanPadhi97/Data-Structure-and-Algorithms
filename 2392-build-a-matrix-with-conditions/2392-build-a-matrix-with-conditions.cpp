class Solution {
public:

    vector<int> topo(vector<vector<int>>& g,int k){
        vector<int> res;
        queue<int> q;
        vector<int> indegree(k+1,0);
        vector<int> adj[k+1];
        for(auto i:g){
            indegree[i[1]]++;
            adj[i[0]].push_back(i[1]);
        }
        for (int i = 1; i <= k; i++)
        {
            if(indegree[i]==0){
                q.push(i);
            }
        }
        while (!q.empty())
        {
            int t=q.front();
            q.pop();
            res.push_back(t);
            for(auto i:adj[t]){
                indegree[i]--;
                if(indegree[i]==0){
                    q.push(i);
                }
            }
        }        
        return res;
    }
    vector<vector<int>> buildMatrix(int k, vector<vector<int>>& rowConditions, vector<vector<int>>& colConditions) {
        auto topo1 = topo(rowConditions,k);
        if(topo1.size()!=k) return {};

        auto topo2 = topo(colConditions,k);
        if(topo2.size()!=k) return {};
        
        vector<vector<int>> res(k,vector<int>(k,0));
        
        vector<int> ind(k+1,0);
        for (int i = 0; i < topo2.size(); i++)
        {
            ind[topo2[i]]=i;
        }
        
        for (int i = 0; i < k; i++)
        {
            res[i][ind[topo1[i]]]=topo1[i];   
        }        
        
        return res;
    }
};