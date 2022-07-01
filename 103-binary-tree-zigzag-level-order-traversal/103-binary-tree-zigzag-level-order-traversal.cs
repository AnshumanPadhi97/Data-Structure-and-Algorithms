public class Solution {
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if(root==null)return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count>0){
            var l = q.Count;
            var ls = new List<int>();
            while(l-->0){
                var a = q.Dequeue();
                if(a.left!=null){
                    q.Enqueue(a.left);
                }
                if(a.right!=null){
                    q.Enqueue(a.right);
                }
                ls.Add(a.val);
            }
            if(res.Count%2!=0){
                ls.Reverse();
            }
            res.Add(ls.ToList());
        }
        return res;
    }
}