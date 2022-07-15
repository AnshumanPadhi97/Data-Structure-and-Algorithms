public class Solution {
    IList<string> res = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root) {
        gen(root,"");
        return res;
    }
    public void gen(TreeNode root,string temp){
        if(root.left==null && root.right==null){
            temp+=root.val.ToString();
            res.Add(new string(temp));
            return;
        }
        if(root.left!=null){
            gen(root.left,temp+root.val.ToString()+"->");
        }
        if(root.right!=null){
            gen(root.right,temp+root.val.ToString()+"->");
        }
    }
}