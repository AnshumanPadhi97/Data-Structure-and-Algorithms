/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> LevelOrder(Node root) {
        if(root==null)return res;
        var q = new Queue<Node>();
        q.Enqueue(root);
        while(q.Count>0){
            var l = q.Count;
            var ls = new List<int>();
            while(l-->0){
                var a = q.Dequeue();
                ls.Add(a.val);
                foreach(var item in a.children){
                    q.Enqueue(item);
                }
            }
            res.Add(ls.ToList());
        }
        return res;
    }
}