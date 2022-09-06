/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    bool h(TreeNode *root){
        if(root==NULL){
            return false;
        }
        auto l = h(root->left);
        auto r = h(root->right);
        if(!l) root->left=NULL;
        if(!r) root->right=NULL;
        
        return root->val == 1 || l || r;
    }
    TreeNode* pruneTree(TreeNode* root) {
        return h(root)?root:NULL;
    }
};