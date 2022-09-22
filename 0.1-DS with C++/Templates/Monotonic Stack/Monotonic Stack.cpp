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

int main(){
    vector<int> nums{3,5,8,7,10,1};
    int n = nums.size();

    vector<int> minPrev(n,-1), minNext(n,n), maxPrev(n,-1), maxNext(n,n);
    
    stack<int> st;
    //for min prev
    for (int i = 0; i < n; i++)
    {
        while (!st.empty() && nums[st.top()]>=nums[i])
        {
            st.pop();
        }
        if(!st.empty())
        {
            minPrev[i] = st.top();
        }
        st.push(i);
    }

    while (!st.empty()){st.pop();}    

    //for min next
    for (int i = n-1; i >= 0; i--)
    {
        while (!st.empty() && nums[st.top()]>nums[i])
        {
            st.pop();
        }
        if(!st.empty())
        {
            minNext[i] = st.top();
        }
        st.push(i);
    }

    while (!st.empty()){st.pop();}

    //for max prev
    for (int i = 0; i < n; i++)
    {
        while (!st.empty() && nums[st.top()]<=nums[i])
        {
            st.pop();
        }
        if(!st.empty())
        {
            maxPrev[i] = st.top();
        }
        st.push(i);        
    }
    
    while (!st.empty()){st.pop();}
    
    //for max next
    for (int i = n-1; i >= 0; i--)
    {
        while (!st.empty() && nums[st.top()]<nums[i])
        {
            st.pop();
        }
        if(!st.empty())
        {
            maxNext[i] = st.top();
        }
        st.push(i);
    }

    for (int i = 0; i < n; i++)
    {
        cout<<maxNext[i]<<" ";
    }

    return 0;
}