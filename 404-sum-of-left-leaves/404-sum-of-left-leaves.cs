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
    public int SumOfLeftLeaves(TreeNode root) {
        return h(root);
    }
    public int h(TreeNode root){
        int res=0;
        if(root==null)return res;
        var st = new Stack<TreeNode>();
        st.Push(root);
        while(st.Count>0){
            var a = st.Pop();
            if(a.left!=null){
                if(a.left.left==null&&a.left.right==null){
                    res+=a.left.val;
                }else{
                    st.Push(a.left);
                }
            }
            if(a.right!=null){
                st.Push(a.right);
            }
        }
        return res;
    }
}