public class Solution {
    int res=0;
    public int DiameterOfBinaryTree(TreeNode root) {
        h(root);
        return res;
    }
    public int h(TreeNode root){
        if(root==null)return 0;
        int l = h(root.left);
        int r = h(root.right);
        res=Math.Max(l+r,res);
        return 1+Math.Max(l,r);
    }
}