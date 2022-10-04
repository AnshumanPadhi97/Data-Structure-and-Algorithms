public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        return h(root,targetSum);
    }
    public bool h(TreeNode root,int t){
        if(root==null)return false;
        if(root.left==null && root.right==null){
            if(t-root.val==0){
                return true;
            }else{
                return false;
            }
        }
        return h(root.left,t-root.val) || h(root.right,t-root.val);
    }
}