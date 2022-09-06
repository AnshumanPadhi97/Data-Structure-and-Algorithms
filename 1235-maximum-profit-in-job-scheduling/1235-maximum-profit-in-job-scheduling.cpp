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
    int maxProfit(vector<vector<int>> &jobs,int ind,vector<int>& dp){
        if(ind==jobs.size())return 0;
        if(dp[ind]!=-1)return dp[ind];

        int skipNow = maxProfit(jobs,ind+1,dp);
        // binary search for the next non-overlapping job, if we decide to do current job
        int currend = jobs[ind][1];
        int lo = ind+1, hi = jobs.size();
        while (lo<hi)
        {
            int mid=(lo+hi)>>1;
            if(jobs[mid][0]<currend){
                lo=mid+1;
            }else{
                hi=mid;
            }
        }
        
        //use now
        int now = jobs[ind][2]+maxProfit(jobs,lo,dp);
        return dp[ind] = max(skipNow,now);
    }
    int jobScheduling(vector<int>& startTime, vector<int>& endTime, vector<int>& profit) {
        int n = profit.size();
        vector<vector<int>> jobs;
        for (int i = 0; i < n; i++)
        {
            jobs.push_back({startTime[i],endTime[i],profit[i]});
        }
        sort(all(jobs));
        vector<int> dp(n,-1);
        return maxProfit(jobs,0,dp);
    }
};