public class Solution {
    int res=0;
    public int SumNumbers(TreeNode root) {
        h(root,0);
        return res;
    }
    public void h(TreeNode root,int temp){
        if(root==null)return;
        temp=temp*10+root.val;
        if(root.left==null && root.right==null){
            res+=temp;
            return;
        }
        h(root.left,temp);
        h(root.right,temp);
    }
}