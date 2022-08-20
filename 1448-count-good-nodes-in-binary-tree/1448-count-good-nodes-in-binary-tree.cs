public class Solution {
    int res=0;
    public int GoodNodes(TreeNode root) {
        h(root,int.MinValue);
        return res;
    }
    public void h(TreeNode root,int max){
        if(root==null)return;
        if(root.val>=max){
            res++;
            max=root.val;
        }
        h(root.left,max);
        h(root.right,max);
    }
}