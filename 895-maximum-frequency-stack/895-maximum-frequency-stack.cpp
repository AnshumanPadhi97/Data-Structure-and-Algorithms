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

class FreqStack {
public:

    unordered_map<int,stack<int>> m;//map of stacks, (maxFreq, stack of elements)
    unordered_map<int,int> freq;//to store freq of each element
    int maxf = 0;//max freq

    FreqStack() {
        
    }
    
    void push(int val) {
        freq[val]++;
        maxf=max(maxf,freq[val]);
        m[freq[val]].push(val);
    }
    
    int pop() {
        int top = m[maxf].top();
        m[maxf].pop();
        freq[top]--;
        if(m[maxf].size()==0){
            maxf--;
        }
        return top;
    }
};