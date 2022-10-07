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
    int minFlips(vector<vector<int>>& mat) {
        int dir[6]={0,0,1,0,-1,0};
        int start=0, m = mat.size(), n = mat[0].size();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                start |= mat[i][j] << (i*n+j);
            }
        }
        set<int> seen;
        queue<int> q;
        q.push(start);
        int res=0;
        while (!q.empty())
        {
            int l = q.size();
            while (l--)
            {
                int a = q.front(); q.pop();
                if(a==0) return res;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int next = a;
                        for (int k = 0; k < 5; k++)
                        {
                            int r = i + dir[k];
                            int c = j + dir[k+1];
                            if(r<0||r>=m||c<0||c>=n) continue;
                            next ^= 1 << (r*n+c);
                        }
                        if(seen.find(next)==seen.end()){
                            seen.insert(next);
                            q.push(next);
                        }
                    }                    
                }                
            }
            res+=1;           
        }
        return -1;
    }
};