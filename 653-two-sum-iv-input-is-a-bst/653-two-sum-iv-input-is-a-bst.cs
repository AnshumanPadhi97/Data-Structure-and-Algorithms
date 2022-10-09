public class Solution {
    HashSet<int> h = new HashSet<int>();
    public bool FindTarget(TreeNode root, int k) {
        return he(root,k);
    }
    public bool he(TreeNode root, int k){
        if(root==null)return false;
        if(h.Contains(k-root.val)){
            return true;
        }
        h.Add(root.val);
        return he(root.left,k) || he(root.right,k);
        
    }
}