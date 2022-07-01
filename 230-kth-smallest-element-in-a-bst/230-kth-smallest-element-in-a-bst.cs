public class Solution {
    int a=0;
    int res=0;
    public int KthSmallest(TreeNode root, int k) {
        a=k;
        h(root);
        return res;
    }
    public void h(TreeNode root){
        if(root==null)return;
        h(root.left);
        a--;
        if(a==0){
            res=root.val;
            return;
        }
        h(root.right);
    }
}