#include<bits/stdc++.h>
using namespace std;
#define fastread() (ios_base:: sync_with_stdio(false),cin.tie(NULL));

#define ll long long
#define all(v) v.begin(), v.end()
#define popcount __builtin_popcount
#define popcountll __builtin_popcountll
#define inf 1000000007

ll bpow(ll a, ll n, ll p = 1e9+7){ll res = 1; while (n) { if(n%2){ res=(res*a*1ll)%p; } a=(a*a*1ll)%p; n>>=1; } return res; }
bool checkprime(ll n){ if(n<=1) return false; for (int i = 2; i*i <= n; i++) { if(n%i==0) return false; } return true; }
ll gcd(ll a,ll b){ if(b==0)return a; return gcd(b,a%b); }
int fact[1000001]; 
void factorial(){ fact[0]=fact[1]=1; for (int i = 2; i <= 1000001; i++) { fact[i]=(i*fact[i-1]*1ll)%inf; } }
ll nck(ll n, ll k){ if(k>n)return 0; ll res = fact[n]; res = (res * 1ll * bpow(fact[k],inf-2))%inf; res = (res * 1ll * bpow(fact[n-k],inf-2))%inf; return res; }



int main()
{
    fastread();



    return 0;
}

