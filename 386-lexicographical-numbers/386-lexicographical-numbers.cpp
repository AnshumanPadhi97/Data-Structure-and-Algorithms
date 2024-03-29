class Solution {
public:
    
    void dfs(int i,int n,vector<int>& res){
        if(i>n){
            return;
        }
        res.push_back(i);
        for (int j = 0; j < 10; j++)
        {
            dfs(i*10+j,n,res);
        }        
    }
    
    vector<int> lexicalOrder(int n) {
        vector<int> res;
        for (int i = 1; i < 10; i++)
        {
            dfs(i,n,res);
        }        
        return res;
    }
};