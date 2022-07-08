public class Solution {
    public bool IsBalanced(TreeNode root) {
        return h(root) == -1? false:true;
    }
    public int h(TreeNode root){
        if(root==null)return 0;
        int l = h(root.left);
        if(l==-1)return -1;
        int r = h(root.right);
        if(r==-1)return -1;
        if(Math.Abs(l-r)<=1)return 1+Math.Max(l,r);
        return -1;
    }
}