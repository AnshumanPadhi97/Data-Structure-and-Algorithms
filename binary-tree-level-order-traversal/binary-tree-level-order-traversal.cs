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
        if(root==null)return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            var l = q.Count;
            var temp = new List<int>();
            while(l-->0){
                var a = q.Dequeue();
                temp.Add(a.val);
                if(a.left!=null){
                    q.Enqueue(a.left);
                }
                if(a.right!=null){
                    q.Enqueue(a.right);
                }
            }
            res.Add(temp.ToList());
        }
        return res;
    }
}