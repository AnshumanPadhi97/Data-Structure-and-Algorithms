class Solution {
public:
    
    unordered_set<TreeNode*> s;
    int res=0;
    
    void dfs(TreeNode* root,TreeNode* parent){
        
        if(root==NULL) return;
        
        dfs(root->left,root);
        dfs(root->right,root);
        
        if(parent==NULL && s.find(root)==s.end() || s.find(root->left)==s.end() || s.find(root->right)==s.end()){
            res++;
            s.insert(root->left);
            s.insert(root->right);
            s.insert(parent);
            s.insert(root);
        }
    }
    
    int minCameraCover(TreeNode* root) {
        s.insert(NULL);//leaf node is covered
        dfs(root,NULL);
        return res;
    }
};