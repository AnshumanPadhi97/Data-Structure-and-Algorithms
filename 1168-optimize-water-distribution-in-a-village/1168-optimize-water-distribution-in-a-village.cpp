#include<bits/stdc++.h>
using namespace std;

#define ll long long
typedef unsigned long long ull;
typedef long double lld;
#define all(v) v.begin(), v.end()
#define revall(v) v.rbegin(), v.rend()
#define setbits __builtin_popcountll
#define nline "\n"
#define MOD1 (int)998244353
#define INF64 (ll)1e18
#define INF32 (int)1e9+7
#define yes cout<<"YES"
#define no cout<<"NO"

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
    int minCostToSupplyWater(int n, vector<int>& wells, vector<vector<int>>& pipes) {
        for (int i = 1; i <= n; i++)
        {
            pipes.push_back({0,i,wells[i-1]});
        }
        sort(begin(pipes),end(pipes),[](auto &a,auto &b){
            return a[2]<b[2];
        });
        UnionFind u(n+1);
        int res=0;
        for (auto &&i : pipes)
        {
            int x = i[0];
            int y = i[1];
            int z = i[2];
            if(u.unionn(x,y)){
                res+=z;
            }
        }
        return res;
    }
};