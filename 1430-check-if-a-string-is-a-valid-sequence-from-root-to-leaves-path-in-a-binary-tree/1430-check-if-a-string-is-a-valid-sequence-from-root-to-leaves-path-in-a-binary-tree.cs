public class Solution {
    public bool IsValidSequence(TreeNode root, int[] arr) {
        return h(root,arr,0);
    }
    public bool h(TreeNode root,int[] a,int i){
        
        if(root==null)return false;
        
        if(i>=a.Length || a[i]!=root.val)
            return false;
        
        if(root.left==null && root.right==null && i==a.Length-1)
            return true;
        
        return h(root.left,a,i+1) || h(root.right,a,i+1);
    }
}