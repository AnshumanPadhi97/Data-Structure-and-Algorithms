public class Solution {
    
    Dictionary<TreeNode,List<TreeNode>> g = new Dictionary<TreeNode,List<TreeNode>>();
    List<int> res = new List<int>();    
    HashSet<TreeNode> h = new HashSet<TreeNode>();
    
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        build(root, null);
        
        dfs(target,k);
        
        return res;
    }
    
    void dfs(TreeNode u,int k){
        h.Add(u);
        if(k==0){
            res.Add(u.val);
            return;
        }
        foreach(var item in g[u]){
            if(!h.Contains(item)){
                dfs(item,k-1);
            }
        }
    }
    
    void build(TreeNode root, TreeNode prev){
        if(root==null) return;
        
        if(!g.ContainsKey(root)){
            g.Add(root, new List<TreeNode>());
        }
        
        if(prev!=null){
            g[root].Add(prev);
            g[prev].Add(root);
        }
        
        build(root.left,root);
        build(root.right,root);        
    }
    
}