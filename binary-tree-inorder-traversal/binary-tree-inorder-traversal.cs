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
    public IList<int> InorderTraversal(TreeNode root) {
        var res=new List<int>();
        if(root==null) return res;
        var st = new Stack<TreeNode>();
        while(root!=null || st.Count>0){
            while(root!=null){
                st.Push(root);
                root=root.left;
            }
            root = st.Pop();
            res.Add(root.val);
            root=root.right;
        }
        return res;
    }
}