public class Solution {
    public TreeNode AddOneRow(TreeNode root, int val, int d) {
        if(d==1){
            var n = new TreeNode(val);
            n.left=root;
            return n;
        }
        h(val,root,1,d);
        return root;
    }
    public void h(int val,TreeNode node, int d,int n){
        if(node==null){
            return;
        }
        if(d==n-1){
            var t = node.left;
            node.left=new TreeNode(val);
            node.left.left=t;
            t=node.right;
            node.right=new TreeNode(val);
            node.right.right=t;
        }else{
            h(val,node.left,d+1,n);
            h(val,node.right,d+1,n);
        }
    }
}