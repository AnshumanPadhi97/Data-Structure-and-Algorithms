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
    public int DistributeCoins(TreeNode root) {
        
        int moves=0;
        h(root,ref moves);
        
        return moves;
    }
    public int h(TreeNode root,ref int moves){
        if(root==null)return 0;
        
        var l = h(root.left,ref moves);
        var r = h(root.right,ref moves);
        
        moves+= Math.Abs(l) + Math.Abs(r);
        
        return root.val+l+r-1;
    }
}