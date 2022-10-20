#include<bits/stdc++.h>
using namespace std;

#define ll long long
typedef unsigned long long ull;
typedef long double lld;
#define all(v) v.begin(), v.end()
#define revall(v) v.rbegin(), v.rend()
#define setbits __builtin_popcountll
#define nline "\n"
#define MOD (int)1000000007

class Solution {
public:
    int findCheapestPrice(int n, vector<vector<int>>& f, int src, int dst, int k) {
        vector<pair<int,int>> g[n];
        for (auto &&i : f)
        {
            g[i[0]].push_back({i[1],i[2]});
        }
        queue<pair<int,int>> q;
        q.push({src,0});
        vector<int> dist(n,INT_MAX);
        dist[src]=0;
        k++;
        while (!q.empty() && k-->0)
        {
            int l = q.size();
            while (l--)
            {
                auto a = q.front();
                q.pop();
                for (auto &&i : g[a.first])
                {
                    if(i.second+a.second<dist[i.first]){
                        dist[i.first]=i.second+a.second;
                        q.push({i.first,i.second+a.second});
                    }
                }                
            }            
        }
        return dist[dst] == INT_MAX ? -1 : dist[dst];
    }
};