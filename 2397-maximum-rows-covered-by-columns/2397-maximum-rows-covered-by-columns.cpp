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
    int res=0;
    int g(vector<vector<int>> &mat){
        int c=0;
        for (int i = 0; i < mat.size(); i++)
        {
            int flag=1;
            for (int j = 0; j < mat[0].size(); j++)
            {
                if(mat[i][j]==1)flag=0;
            }
            if(flag)c++;
        }
        return c;        
    }
    int h(vector<vector<int>> &mat, int cols,int i){
        if(i==mat[0].size() || cols==0){
            int c = g(mat);
            res=max(res,c);
            return c;
        }
        int x = h(mat,cols,i+1);
        vector<vector<int>> temp = mat;
        for (int j = 0; j < mat.size(); j++)
        {
            temp[j][i]=0;
        }
        int y = h(temp,cols-1,i+1);
        return max(x,y);        
    }
    int maximumRows(vector<vector<int>>& mat, int cols) {
        h(mat,cols,0);
        return res;
    }
};