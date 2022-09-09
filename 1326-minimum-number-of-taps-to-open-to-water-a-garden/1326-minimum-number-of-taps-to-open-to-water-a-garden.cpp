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
    int stich(vector<vector<int>>& clips,int n){
        int res=0;
        int end=0;
        int i=0;
        for (int st = 0; st < n; st = end, ++res)
        {
            while (i<clips.size() && clips[i][0]<=st)
            {
                end=max(end,clips[i++][1]);
            }
            if(st==end) return -1;
        }        
        return res;
    }
    int minTaps(int n, vector<int>& ranges) {
        vector<vector<int>> clips;
        for (int i = 0; i < ranges.size(); i++)
        {
            clips.push_back({i-ranges[i],i+ranges[i]});
        }
        sort(all(clips));
        return stich(clips,n);
    }
};