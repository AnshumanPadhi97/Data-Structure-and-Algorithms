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
    bool canCross(vector<int>& stones) {
        unordered_map<int,unordered_set<int>> m;
        for (auto &&i : stones)
        {
            m[i]=unordered_set<int>{};
        }
        m[stones[0]].insert(1);
        int t = stones[stones.size()-1];
        for (int i = 0; i < stones.size()-1; i++)
        {
            int stone = stones[i];
            for (auto &&step : m[stone])
            {
                int reach = stone + step;
                if(reach == t){
                    return true;
                }   
                if(m.count(reach)){
                    m[reach].insert(step);
                    m[reach].insert(step+1);
                    if(step>0) m[reach].insert(step-1);
                }
            }            
        }
        return false;
    }
};