class UnionFind{
    public :
        int components;
        vector<int> rank;
        vector<int> parent;
        UnionFind(int n){
            rank = vector<int>(n,1);
            parent = vector<int>(n);
            components = n;
            for (int i = 0; i < n; i++)
            {
                parent[i]=i;
            }
        }
        int find(int p){
            if(p==parent[p]){
                return p;
            }else{
                return parent[p] = find(parent[p]);
            }
        }
        bool unionn(int u,int v){
            u = find(u);
            v = find(v);
            if(u==v) return false;
            if(rank[u]>rank[v]){
                parent[v] = u;
                rank[u]+=rank[v];
            }else{
                parent[u]=v;
                rank[v]+=rank[u];
            }
            components-=1;
            return true;
        }
};

class Solution {
public:
    int numberOfGoodPaths(vector<int>& vals, vector<vector<int>>& edges) {
        int n = vals.size(), res=0;
        vector<vector<int>> g(n);
        map<int,vector<int>> sameVals;
        
        for (int i = 0; i < n; i++)
        {
            sameVals[vals[i]].push_back(i);
        }
        for (auto &&e : edges)
        {
            int u = e[0], v = e[1];
            if(vals[u]>=vals[v]){
                g[u].push_back(v);
            }
            else if(vals[v]>=vals[u]){
                g[v].push_back(u);
            }
        }
        
        UnionFind u(n);

        for (auto a : sameVals)
        {
            vector<int> allNodes = a.second;
            int val = a.first;
            for (auto &&i : allNodes)
            {
                for (auto &&j : g[i])
                {
                    u.unionn(i,j);
                }                
            }            
            unordered_map<int,int> group;
            for (auto &&i : allNodes)
            {
                group[u.find(i)]++;
            }

            res+=allNodes.size();
            for (auto &&i : group)
            {
                int l = i.second;
                res+=(l*(l-1))/2;
            }
        }
        return res;
    }
};