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
    long long numberOfWays(string s) {
        int n = s.length();
        ll n0 = 0;
        ll n1 = 0;
        ll n01 = 0;
        ll n10 = 0;
        ll n010 = 0;
        ll n101 = 0;

        for (int i = 0; i < n; i++)
        {
            if(s[i]=='0'){
                n0++;
                n10+=n1;
                n010+=n01;
            }else{
                n1++;
                n01+=n0;
                n101+=n10;
            }
        }        

        return n010+n101;
    }
};