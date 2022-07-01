public class Solution {
    
    Dictionary<int,List<int>> d = new Dictionary<int,List<int>>();
    List<int> res = new List<int>();
    
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        build(root);
        dfs(target.val,k,new HashSet<int>());
        return res;
    }
    //build graph
    public void build(TreeNode root){
        if(root==null)return;
        if(!d.ContainsKey(root.val)){
            d.Add(root.val,new List<int>());
        }
        if(root.left!=null){
            d[root.val].Add(root.left.val);
            d.Add(root.left.val,new List<int>());
            d[root.left.val].Add(root.val);
            build(root.left);
        }
        if(root.right!=null){
            d[root.val].Add(root.right.val);
            d.Add(root.right.val,new List<int>());
            d[root.right.val].Add(root.val);
            build(root.right);
        }
    }
    
    public void dfs(int u,int k,HashSet<int> h){
        h.Add(u);
        if(k==0){
            res.Add(u);
            return;
        }
        foreach(var item in d[u]){
            if(!h.Contains(item)){
                dfs(item,k-1,h);
            }
        }
    }
}