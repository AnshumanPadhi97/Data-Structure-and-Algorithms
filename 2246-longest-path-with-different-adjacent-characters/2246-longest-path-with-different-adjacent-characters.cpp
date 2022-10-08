class Solution {
public:
    vector<int> tree[100005];
    int res;
    int dfs(int u,string& s){
        int best=0, second_best=0;
        for (auto &&i : tree[u])
        {
            int l = dfs(i,s);
            if(s[i]==s[u]) continue;
            
            if(l>best)
            {
                second_best=best;
                best=l;
            }
            else if(l>second_best){
                second_best=l;
            }
        }
        
        int a = 1+best;
        int b = 1+best+second_best;
        
        res = max({res,a,b});
        
        return a;  
    }
    int longestPath(vector<int>& parent, string s) {
        for (int i = 1; i < parent.size(); i++)
        {
            tree[parent[i]].push_back(i);
        }
        res=0;
        dfs(0,s);
        return res;
    }
};