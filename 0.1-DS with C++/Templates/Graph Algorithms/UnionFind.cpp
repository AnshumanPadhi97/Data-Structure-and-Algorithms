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