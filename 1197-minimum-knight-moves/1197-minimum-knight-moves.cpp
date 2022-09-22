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
    int minKnightMoves(int x, int y) {
        vector<int> dirx{1,2,2,1,-1,-2,-2,-1};
        vector<int> diry{2,1,-1,-2,-2,-1,1,2};
        set<pair<int,int>> s;
        queue<pair<pair<int,int>,int>> q;
        q.push({{0,0},0});
        s.insert({0,0});
        x=abs(x);
        y=abs(y);
        while (!q.empty())
        {
            int l = q.size();
            while (l--)
            {
                pair<pair<int,int>,int> a = q.front();
                q.pop();
                if(a.first.first == x && a.first.second==y){
                    return a.second;
                }
                
                if(a.first.first<-2||a.first.second<-2)continue;
                if(a.first.first>x+2 || a.first.second>y+2) continue;

                for (int i = 0; i < 8; i++)
                {
                    int nx = a.first.first+dirx[i];
                    int ny = a.first.second+diry[i];
                    if(s.count(pair<int,int>(nx,ny))){
                        continue;
                    }else{
                        s.insert({nx,ny});
                        q.push({{nx,ny},a.second+1});
                    }
                }
            }            
        }
        return 0;
    }
};