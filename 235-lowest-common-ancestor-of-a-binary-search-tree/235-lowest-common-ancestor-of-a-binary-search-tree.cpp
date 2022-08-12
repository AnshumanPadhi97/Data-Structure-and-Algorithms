class Solution {
public:
    TreeNode* lowestCommonAncestor(TreeNode* root, TreeNode* p, TreeNode* q) {
        if(root==NULL)return NULL;
        TreeNode* res=root;
        while(true){
            if(res->val<p->val && res->val<q->val){
                res=res->right;
            }
            else if(res->val>p->val && res->val>q->val){
                res=res->left;
            }else{
                break;
            }
        }
        return res;
    }
};