class Solution {
public:
    int res=0;
    
    int longestZigZag(TreeNode* root) {
        dfs(root,0,0);
        return res;
    }
    
    void dfs(TreeNode* root,int l,int r){
        
        if(!root) return;
        
        res=max(res,l);
        res=max(res,r);
        
        dfs(root->left,0,l+1);
        dfs(root->right,r+1,0);
    }
};