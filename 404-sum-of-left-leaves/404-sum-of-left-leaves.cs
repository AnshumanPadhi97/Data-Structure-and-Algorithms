/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int SumOfLeftLeaves(TreeNode root) {
        return h(root);
    }
    public int h(TreeNode root){
        if(root==null)return 0;
        int res=0;
        if(root.left!=null){
            if(root.left.left==null && root.left.right==null){
                res+=root.left.val;
            }else{
                res+=h(root.left);
            }
        }
        res+=h(root.right);
        return res;
    }
}