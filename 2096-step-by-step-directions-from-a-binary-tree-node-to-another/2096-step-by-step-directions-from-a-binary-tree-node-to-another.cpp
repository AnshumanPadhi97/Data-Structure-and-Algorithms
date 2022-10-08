class Solution {
public:
    bool dfs(TreeNode* root,int s,string& p){
        if(root->val==s){
            return true;
        }
        if(root->left && dfs(root->left,s,p)){
            p.push_back('L');
        }
        else if(root->right && dfs(root->right,s,p)){
            p.push_back('R');
        }
        return !p.empty();
    }
    string getDirections(TreeNode* root, int s, int d) {
        string sp, dp;
        
        dfs(root,s,sp);
        dfs(root,d,dp);
        
        while(!sp.empty() && !dp.empty() && sp.back()==dp.back()){
            sp.pop_back();
            dp.pop_back();
        }
        return string(sp.size(), 'U') + string(rbegin(dp), rend(dp));
    }
};