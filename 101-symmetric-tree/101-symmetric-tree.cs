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
    public bool IsSymmetric(TreeNode root) {
        if(root==null)return false;
        return c(root.left,root.right);
    }
    public bool c(TreeNode p, TreeNode q){
        if(p==null && q==null)return true;
        if(p==null || q==null)return false;
        return p.val == q.val && c(p.left,q.right) && c(p.right,q.left);
    }
}