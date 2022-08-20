#include<bits/stdc++.h>
using namespace std;
#define fastread() (ios_base:: sync_with_stdio(false),cin.tie(NULL));

#define ll long long
#define forn(i, n) for(int i=0;i<n;++i)
#define fore(i, l, r) for(int i = int(l); i <= int(r); ++i)
#define sz(v) int(v.size())
#define all(v) v.begin(), v.end()
#define pb push_back
#define mp make_paird
#define pt pair<int, int>
#define popcount __builtin_popcount
#define popcountll __builtin_popcountll

void test(){
    //calc a^n;
    ll a=2,n=13;
    ll res=1;

    while (n)
    {
        if(n%2){
            res*=a;
            n--;
        }
        a*=a;
        n/=2;
    }
    
    cout<<res;
    cout<<endl;
}

int main()
{
    fastread();
    test();
    return 0;
}