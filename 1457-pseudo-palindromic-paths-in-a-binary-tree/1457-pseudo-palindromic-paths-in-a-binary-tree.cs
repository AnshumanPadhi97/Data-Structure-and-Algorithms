public class Solution {
    int res=0;
    public int PseudoPalindromicPaths (TreeNode root) {
        if(root==null)return 0;
        dfs(root,new int[10]);
        return res;
    }
    public void dfs(TreeNode root, int[] temp){
        if(root==null)return;
        
        temp[root.val]+=1;
        
        if(root.left==null && root.right==null){
            if(check(temp)){
                res++;
            }
        }
        
        dfs(root.left,temp);
        dfs(root.right,temp);
        
        temp[root.val]-=1;
    }
    public bool check(int[] temp){
        int a=0;
        for(int i=0;i<10;i++){
            if(temp[i]%2!=0){
                a++;
            if(a>1)return false;
            }
        }
        return true;
    }
}