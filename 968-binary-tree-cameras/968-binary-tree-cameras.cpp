class Solution {
public:
    int res=0;
    int needCamera = -1, covered = 0, haveCamera = 1;

    int dfs(TreeNode* root){
        if(!root) return covered;
        
        int l = dfs(root->left);
        int r = dfs(root->right);

        if(l==covered && r==covered){
            return needCamera;
        }

        if(l==needCamera || r==needCamera){
            res++;
            return haveCamera;
        }

        if(l==haveCamera || r==haveCamera){
            return covered;
        }

        return -1;
    }
    int minCameraCover(TreeNode* root) {
        res=0;
        int a = dfs(root);
        if(a==needCamera){
            res++;
        }
        return res;
    }
};