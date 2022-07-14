public class Solution {
    Dictionary<int,int> d = new Dictionary<int,int>();
    int pid=0;
    
    public TreeNode BuildTree(int[] a, int[] b) {
        
        for(int i=0;i<b.Length;i++){
            if(!d.ContainsKey(b[i])){
                d.Add(b[i],-1);
            }
            d[b[i]]=i;
        }
        
        return build(a,0,b.Length-1);
    }
    
    public TreeNode build(int[] a,int lid,int rid){
        
        if(lid>rid){
            return null;
        }
        
        var root = new TreeNode(a[pid++]);
        
        root.left = build(a,lid,d[root.val]-1);
        
        root.right = build(a,d[root.val]+1,rid);
        
        return root;
    }
}