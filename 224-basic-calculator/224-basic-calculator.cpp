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
    int calculate(string s) {
        ll res=0,curr=0,sign=1;
        stack<ll> st;
        for (int i = 0; i < s.length(); i++)
        {
            auto a = s[i];
            if(isdigit(a)){
                curr=curr*10+a-'0';
            }
            else if(a=='+'){
                res+=sign*curr;
                curr=0;
                sign=1;
            }
            else if(a=='-'){
                res+=sign*curr;
                curr=0;
                sign=-1;
            }
            else if(a=='('){
                st.push(res);
                st.push(sign);
                sign=1;
                res=0;
            }
            else if(a==')'){
                res+=sign*curr;
                curr=0;
                res *= st.top(); st.pop();
                res += st.top(); st.pop();                
            }
        }
        if(curr!=0){
            res+=sign*curr;
        }
        return res;
    }
};