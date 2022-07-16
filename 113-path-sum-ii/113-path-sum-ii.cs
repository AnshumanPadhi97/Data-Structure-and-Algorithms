public class Solution {
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        dfs(root,targetSum,new List<int>());
        return res;
    }
    public void dfs(TreeNode root,int t,List<int> temp){
        if(root==null)return;
        
        temp.Add(root.val);
        
        if(root.val==t && root.left==null&&root.right==null)
        {
            res.Add(temp.ToList());
        }
        
        dfs(root.left,t-root.val,temp);
        dfs(root.right,t-root.val,temp);
        
        temp.RemoveAt(temp.Count-1);
    }
}