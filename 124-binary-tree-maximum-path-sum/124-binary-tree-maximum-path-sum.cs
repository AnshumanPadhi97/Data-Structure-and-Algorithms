public class Solution {
    int res=int.MinValue;
    public int MaxPathSum(TreeNode root) {
        h(root);
        return res;
    }
    public int h(TreeNode root){
        if(root==null)return 0;
        int l = Math.Max(h(root.left),0);
        int r = Math.Max(h(root.right),0);
        res = Math.Max(res,root.val+l+r);
        return root.val+Math.Max(r,l);
    }
}