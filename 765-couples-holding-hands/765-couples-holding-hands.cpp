class UnionFind{
    public :
        vector<int> rank;
        vector<int> parent;
        UnionFind(int n){
            rank = vector<int>(n,1);
            parent = vector<int>(n);
        }
        void setParent(int a,int b){
            parent[a]=b;
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
            return true;
        }
};

class Solution {
public:
    int minSwapsCouples(vector<int>& row) {
        int l = row.size();
        UnionFind u(l);
        for (int i = 0; i < l; i+=2)
        {
            u.setParent(row[i],row[i]);
            u.setParent(row[i+1],row[i]);
        }
        int res=0;
        for (int i = 0; i < l; i+=2)
        {
            if(u.unionn(i,i+1)){
                res++;
            }
        }
        return res;
    }
};