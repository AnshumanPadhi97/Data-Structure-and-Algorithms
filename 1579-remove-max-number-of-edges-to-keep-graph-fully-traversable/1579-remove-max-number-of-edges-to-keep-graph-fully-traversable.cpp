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
    int maxNumEdgesToRemove(int n, vector<vector<int>>& edges) {
        int res=0;
        UnionFind bob(n+1), alice(n+1);
        
        for (auto &&i : edges)
        {
            if(i[0]==3){
                if(!bob.unionn(i[1],i[2]) || !alice.unionn(i[1],i[2])){
                    res++;
                }
            }
        }
        for (auto &&i : edges)
        {
            if(i[0]==1 && !alice.unionn(i[1],i[2])){
                res++;
            }
            if(i[0]==2 && !bob.unionn(i[1],i[2])){
                res++;
            }
        }
        return alice.components-1 == 1  && bob.components-1 == 1 ? res : -1;
    }
};