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
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> LevelOrder(TreeNode root) {
        h(root,0);
        return res;
    }
    public void h(TreeNode root,int l){
        if(root==null)return;
        if(res.Count==l){
            res.Add(new List<int>());
        }
        res[l].Add(root.val);
        h(root.left,l+1);
        h(root.right,l+1);
    }
}