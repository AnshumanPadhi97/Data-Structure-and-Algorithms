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
    public IList<IList<int>> PathSum(TreeNode root, int t) {
        dfs(root,t,new List<int>());
        return res;
    }
    public void dfs(TreeNode root, int t, List<int> temp){
        if(root==null)return;
        temp.Add(root.val);
        if(root.left == null && root.right == null && temp.Sum() == t){
            res.Add(temp.ToList()); 
        }
        dfs(root.left,t,temp);
        dfs(root.right,t,temp);
        temp.RemoveAt(temp.Count-1);
    }
}