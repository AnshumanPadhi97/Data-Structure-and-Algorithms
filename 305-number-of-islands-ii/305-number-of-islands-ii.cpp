class UnionFind{
    public :
        int components;
        vector<int> rank;
        vector<int> parent;
        UnionFind(int n){
            rank = vector<int>(n,1);
            parent = vector<int>(n);
            components = 0;
            for (int i = 0; i < n; i++)
            {
                parent[i]=-1;
            }
        }
        int find(int p){
            if(p==parent[p]){
                return p;
            }else{
                return parent[p] = find(parent[p]);
            }
        }
        void union1(int u){
            parent[u]=u;
            components+=1;
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
    vector<int> numIslands2(int m, int n, vector<vector<int>>& positions) {
        vector<int> res;
        UnionFind u(m*n);
        vector<vector<int>> indexMap(m,vector<int>(n));
        int k=0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                indexMap[i][j] = k++;
            }            
        }
        int dir[]={0,1,0,-1,0};
        vector<bool> vis(m*n,false);
        for (auto &&pos : positions)
        {
            int x = pos[0];   
            int y = pos[1];   
            int indexMap1 = indexMap[x][y];
            if(!vis[indexMap1]){
                u.union1(indexMap1);
                vis[indexMap1]=true;
            }
            for (int i = 0; i < 4; i++)
            {
                int nx = x + dir[i];
                int ny = y + dir[i+1];
                if(nx>=0 && nx<m && ny>=0 &&ny<n){
                    int indexMap2 = indexMap[nx][ny];
                    if(vis[indexMap2]){
                        u.unionn(indexMap1,indexMap2);
                    }
                }
            }
            int c = u.components;
            res.push_back(c);
        }        
        return res;
    }
};