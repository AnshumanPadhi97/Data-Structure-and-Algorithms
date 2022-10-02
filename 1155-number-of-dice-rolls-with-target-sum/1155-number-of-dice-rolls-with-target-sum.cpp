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
    int dp[31][1001]={};
    int numRollsToTarget(int d, int f, int target,int res = 0 ) {
        if(d==0 || target<=0) return d==target;
        if(dp[d][target]) return dp[d][target] - 1;
        for (int i = 1; i <= f; i++)
        {
            res=(res+numRollsToTarget(d-1,f,target-i))%1000000007;
        }
        dp[d][target]=res+1;
        return res;
    }
};