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
    static bool comp(const vector<int>& a, const vector<int>& b) {
        return (a[2] < b[2]);
    }
    int minimumCost(int n, vector<vector<int>>& connections) {
        UnionFind u(n+1);
        sort(begin(connections),end(connections),comp);
        int res=0;
        for (int i = 0; i < connections.size(); i++)
        {
            if(u.unionn(connections[i][0],connections[i][1])){
                n-=1;
                res+=connections[i][2];
            }
        }
        return u.components-1 == 1 ? res : -1;
    }
};