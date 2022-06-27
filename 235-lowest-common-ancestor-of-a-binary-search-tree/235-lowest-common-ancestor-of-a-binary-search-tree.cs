public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null)return null;
        if(p.val>root.val && q.val>root.val){
            return LowestCommonAncestor(root.right,p,q);
        }else if(p.val<root.val && q.val<root.val){
            return LowestCommonAncestor(root.left,p,q);
        }
        return root;
    }
}