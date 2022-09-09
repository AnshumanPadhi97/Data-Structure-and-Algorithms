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
    int maximumRobots(vector<int>& chargeTimes, vector<int>& runningCosts, long long budget) {
        ll i=0,j=0,sum=0,n=chargeTimes.size();
        multiset<int> m;
        ll res=0;
        while (j<n)
        {
            sum+=runningCosts[j];
            m.insert(chargeTimes[j++]);
            ll val = (*m.rbegin())+(j-i)*sum;
            while (val>budget)
            {
                sum-=runningCosts[i];
                m.erase(m.find(chargeTimes[i++]));
                val=m.empty()?0:(*m.begin())+(j-i)*sum;
            }
            res=max(res,j-i);
        }        
        return res;
    }
};