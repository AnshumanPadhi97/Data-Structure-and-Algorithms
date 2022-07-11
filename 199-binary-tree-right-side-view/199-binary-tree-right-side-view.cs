public class Solution {
    List<int> res = new List<int>();
    public IList<int> RightSideView(TreeNode root) {
        h(root,0);
        return res;
    }
    public void h(TreeNode root,int l){
        if(root==null)return;
        if(res.Count==l)
            res.Add(root.val);
        h(root.right,l+1);
        h(root.left,l+1);
    }
}