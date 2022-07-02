public class Solution {
    public int PathSum(TreeNode root, int t) {
        if(root==null) return 0;
        return h(root,t)+PathSum(root.left,t)+PathSum(root.right,t);
    }
    public int h(TreeNode root,int t){
        if(root==null)return 0;
        return (root.val == t ? 1 : 0) + h(root.left,t-root.val) + h(root.right,t-root.val);
    }
}