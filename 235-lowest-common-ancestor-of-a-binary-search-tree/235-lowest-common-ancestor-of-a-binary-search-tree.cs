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
        var res = root;
        while(true){
            if(res.val<p.val && res.val<q.val){
                res=res.right;
            }
            else if(res.val>p.val && res.val>q.val){
                res=res.left;
            }
            else{
                break;
            }
        }
        return res;
    }
}