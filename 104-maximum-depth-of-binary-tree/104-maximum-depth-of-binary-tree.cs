public class Solution {
    public int MaxDepth(TreeNode root) {
        var q = new Queue<TreeNode>();
        if(root==null)return 0;
        q.Enqueue(root);
        int res=0;
        while(q.Count>0){
            res++;
            var l = q.Count;
            while(l-->0){
                var a = q.Dequeue();
                if(a.left!=null){
                    q.Enqueue(a.left);
                }
                if(a.right!=null){
                    q.Enqueue(a.right);
                }
            }
        }
        return res;
    }
}