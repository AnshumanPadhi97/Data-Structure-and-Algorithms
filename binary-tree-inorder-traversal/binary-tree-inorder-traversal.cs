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
    List<int> res = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        h(root);
        return res;
    }
    public void h(TreeNode root){
        if(root==null)return;
        h(root.left);
        res.Add(root.val);
        h(root.right);
    }
}