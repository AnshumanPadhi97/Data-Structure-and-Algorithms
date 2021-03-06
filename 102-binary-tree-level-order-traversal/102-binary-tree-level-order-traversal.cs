public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res = new List<IList<int>>();
        if(root==null)return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            var l = q.Count;
            var ls = new List<int>();
            while(l-->0){
                var a = q.Dequeue();
                ls.Add(a.val);
                if(a.left!=null){
                    q.Enqueue(a.left);
                }
                if(a.right!=null){
                    q.Enqueue(a.right);
                }
            }
            res.Add(ls.ToList());
        }
        return res;
    }
}