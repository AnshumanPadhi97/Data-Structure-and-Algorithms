class Solution {
public:
    bool h(TreeNode* root, int val,string&path){
        if(!root)return false;
        if(root->val==val){
            return true;
        }
        if(root->left && h(root->left,val,path)){
            path+='L';
        }
        else if(root->right && h(root->right,val,path)){
            path+='R';
        }
        return !path.empty();
    }
    string getDirections(TreeNode* root, int startValue, int destValue) {
        string a,b;
        h(root,startValue,a);
        h(root,destValue,b);
        while(!a.empty() && !b.empty() && a.back()==b.back()){
            a.pop_back();
            b.pop_back();
        }
        return string(a.size(),'U') + string(rbegin(b),rend(b));
    }
};