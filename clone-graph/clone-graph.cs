/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node==null)return null;
        var vis = new Node[101];
        var curr = new Node(node.val);
        dfs(curr,node,vis);
        return curr;
    }
    public void dfs(Node curr,Node node,Node[] vis){
        vis[curr.val]=curr;
        foreach(var item in node.neighbors){
            if(vis[item.val]==null){
                var a = new Node(item.val);
                curr.neighbors.Add(a);
                dfs(a,item,vis);
            }else{
                curr.neighbors.Add(vis[item.val]);
            }
        }
    }
}