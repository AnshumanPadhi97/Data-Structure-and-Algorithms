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

class Solution {
public:

    unordered_map<string,vector<pair<string,double>>> g;
    unordered_map<string,bool> vis;
    double ans;

    bool dfs(string u, string v, double prod){
        if(u==v && g.find(u)!=g.end()){
            ans=prod;
            return true;
        }

        bool temp = false;
        vis[u]=true;
        for (int i = 0; i < g[u].size(); i++)
        {
            if(!vis[g[u][i].first]){
                temp = dfs(g[u][i].first, v, prod * g[u][i].second);
                if(temp){
                    break;
                }
            }
        }
        vis[u]=false;
        return temp;      
    }

    vector<double> calcEquation(vector<vector<string>>& equations, vector<double>& values, vector<vector<string>>& queries) {
        int n = equations.size(), m = queries.size();
        vector<double> res(m);
        
        for (int i = 0; i < n; i++)
        {
            g[equations[i][0]].push_back({equations[i][1],values[i]});   
            g[equations[i][1]].push_back({equations[i][0],1/values[i]});   
        } 

        for (int i = 0; i < m; i++)
        {
            ans=1;
            bool found = dfs(queries[i][0],queries[i][1],1);
            if(found){
                res[i]=ans;
            }else{
                res[i]=-1;
            }
        }
        return res;   
    }
};