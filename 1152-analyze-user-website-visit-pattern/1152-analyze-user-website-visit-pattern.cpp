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
    vector<string> mostVisitedPattern(vector<string>& username, vector<int>& timestamp, vector<string>& website) {
        unordered_map<string,vector<pair<int,string>>> m1;
        set<vector<string>> seqs;
        map<vector<string>,int> m2;
        for (int i = 0; i < username.size(); i++)
        {
            m1[username[i]].push_back({timestamp[i],website[i]});
        }
        for(auto i:m1){
            vector<pair<int,string>> a = i.second;
            sort(a.begin(),a.end(),[](pair<int,string> &x, pair<int,string>&y){
                return x.first<y.first;
            });//sort a user entry based on time

            seqs.clear();
            for (int i = 0; i < a.size(); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        seqs.insert({a[k].second,a[j].second,a[i].second});
                    }
                }
            }//create all 3 based sequences

            for (auto &&w : seqs)
            {
                m2[w]++;
            }//increment count of each seqnce
        }
        
        return max_element(m2.begin(),m2.end(),[](auto& p,auto &q){
            return (p.second == q.second) ? (p.first > q.first) : p.second < q.second;
        })->first;
        //get max based on count
    }
};