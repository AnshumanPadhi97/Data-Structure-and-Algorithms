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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return h(preorder,inorder,0,preorder.Length-1,0,inorder.Length-1);
    }
    public TreeNode h(int[] preorder,int[] inorder,int ips,int ipe,int ios,int ioe){
        if(ips>ipe)return null;
        
        var root=new TreeNode(preorder[ips]);
        int ind=-1;
        for(int i=0;i<inorder.Length;i++){
            if(inorder[i]==root.val){
                ind=i;
                break;
            }
        }
        
        int numsLeft = ind-ios;
        
        root.left=h(preorder,inorder,ips+1,ips+numsLeft,ios,ind-1);
        root.right=h(preorder,inorder,numsLeft+ips+1,ipe,ind+1,ioe);
        
        return root;
    }
}