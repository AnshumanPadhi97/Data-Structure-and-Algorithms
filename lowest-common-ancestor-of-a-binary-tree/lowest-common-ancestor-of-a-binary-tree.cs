/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null)return null;
        if(p==root||q==root)return root;
        var l = LowestCommonAncestor(root.left,p,q);
        var r = LowestCommonAncestor(root.right,p,q);
        if(l==null){
            return r;
        }else{
            if(r==null){
                return l;
            }else{
                return root;
            }
        }
    }
}