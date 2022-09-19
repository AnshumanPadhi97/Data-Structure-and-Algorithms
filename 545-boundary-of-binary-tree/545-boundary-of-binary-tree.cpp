class Solution {
public:
    vector<int> boundaryOfBinaryTree(TreeNode* root) {
        vector<int> res;
        
        if(!root)return res;
        res.push_back(root->val);
        
        vector<int> lefts,leaves,rights;
        
        left(root->left,lefts);
        down(root->left,leaves);
        down(root->right,leaves);
        right(root->right,rights);
        
        reverse(rights.begin(),rights.end());
        
        for(auto l:lefts) res.push_back(l);
        for(auto leave:leaves) res.push_back(leave);
        for(auto r:rights) res.push_back(r);
        
        return res;
    }
    void left(TreeNode* root,vector<int>& lefts){
        if(root==NULL)return;
        if(root->left==NULL && root->right==NULL)return;
        
        lefts.push_back(root->val);
        
        if(root->left!=NULL){
            left(root->left,lefts);
        }else{
            left(root->right,lefts);
        }
    }
    void right(TreeNode* root,vector<int>& rights){
        if(root==NULL)return;
        if(root->left==NULL && root->right==NULL)return;
        
        rights.push_back(root->val);
        
        if(root->right!=NULL){
            right(root->right,rights);
        }else{
            right(root->left,rights);
        }
    }
    void down(TreeNode* root,vector<int>&leaves){
        if(root==NULL)return;
        if(root->left==NULL && root->right==NULL){
            leaves.push_back(root->val);
        }
        down(root->left,leaves);
        down(root->right,leaves);
    }
};