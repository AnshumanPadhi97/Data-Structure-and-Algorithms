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
    vector<int> res;
    void h(TreeNode* root){
        if(root==NULL){
            return;
        }
        h(root->left);
        res.push_back(root->val);
        h(root->right);
    }
    vector<int> inorderTraversal(TreeNode* root) {
        h(root);
        return res;
    }
};