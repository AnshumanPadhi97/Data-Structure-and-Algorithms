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
    vector<vector<string>> suggestedProducts(vector<string>& products, string searchWord) {
        sort(products.begin(),products.end());
        vector<vector<string>> res;
        string pref = "";
        int n = products.size();
        int b=0;
        for (auto &&c : searchWord)
        {
            pref+=c;
            int a = lower_bound(begin(products)+b,end(products),pref)-begin(products);
            res.push_back({});

            for (int i = a; i < min(a+3,n) && !products[i].compare(0,pref.size(),pref); i++)
            {
                res.back().push_back(products[i]);
            }
            b=a;
        }
        return res;
    }
};