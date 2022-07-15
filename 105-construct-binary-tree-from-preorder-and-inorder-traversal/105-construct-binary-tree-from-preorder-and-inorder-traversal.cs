public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return h(preorder,inorder,0,preorder.Length-1,0,inorder.Length-1);
    }
    public TreeNode h(int[] p,int[] ino,int pi,int pe,int ii,int ie){
        if(pi>pe){
            return null;
        }
        TreeNode root = new TreeNode(p[pi]);
        int ind = 0;
        for(int i=ii;i<=ie;i++){
            if(ino[i]==root.val){
                ind=i;
                break;
            }
        }
        
        var numsLeft = ind-ii;//left of ind in inorder array
        
        root.left = h(p,ino,pi+1,pi+numsLeft,ii,ind-1);
        
        root.right = h(p,ino,pi+numsLeft+1,pe,ind+1,ie);
        
        return root;
    }
}