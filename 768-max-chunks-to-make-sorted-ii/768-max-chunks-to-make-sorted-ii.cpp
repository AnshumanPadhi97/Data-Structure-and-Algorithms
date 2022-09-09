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
    int maxChunksToSorted(vector<int>& arr) {
        ll sum1=0,sum2=0,res=0;
        vector<int> t = arr;
        sort(all(t));
        for (int i = 0; i < t.size(); i++)
        {
            sum1+=arr[i];
            sum2+=t[i];
            if(sum1==sum2){
                res++;
            }   
        }        
        return res;
    }
};