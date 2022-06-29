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
    TreeNode prev = null;
    public bool IsValidBST(TreeNode root) {
        
        if(root==null) return true;
        
        if(!IsValidBST(root.left)){
            return false;
        }
        
        if(prev!=null && prev.val>=root.val){
            return false;
        }
        
        prev = root;
        
        if(!IsValidBST(root.right)){
            return false;
        }
        
        return true;
    }
}