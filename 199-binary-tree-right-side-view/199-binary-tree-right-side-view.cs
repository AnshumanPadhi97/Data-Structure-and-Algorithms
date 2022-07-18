public class Solution {
    public IList<int> RightSideView(TreeNode root) {
        var res=  new List<int>();
        if(root==null)return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            var l = q.Count;
            for(int i=0;i<l;i++){
                var a=q.Dequeue();
                if(i==l-1){
                    res.Add(a.val);
                }
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