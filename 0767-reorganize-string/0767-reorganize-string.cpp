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
    string reorganizeString(string s) {
        string res="";
        unordered_map<char,int> m;
        priority_queue<pair<int,char>> q;
        for(auto i:s){
            m[i]++;
        }
        for(auto i:m){
            q.push({i.second,i.first});
        }
        while (q.size()>1)
        {
            auto top1 = q.top();
            q.pop();
            auto top2 = q.top();
            q.pop();

            res+=top1.second;
            res+=top2.second;

            top1.first-=1;
            top2.first-=1;

            if(top1.first>0){
                q.push(top1);
            }

            if(top2.first>0){
                q.push(top2);
            }
        }
        if(!q.empty()){
            if(q.top().first>1){
                return "";
            }else{
                res+=q.top().second;
            }
        }
        return res;
    }
};