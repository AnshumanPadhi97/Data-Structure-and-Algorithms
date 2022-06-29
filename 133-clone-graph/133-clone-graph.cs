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
        var copy = new Node(node.val);
        var vis = new Node[101];
        dfs(copy,node,vis);
        return copy;
    }
    public void dfs(Node copy,Node node,Node[] vis){
        vis[copy.val]=copy;
        foreach(var item in node.neighbors){
            if(vis[item.val]==null){
                var a = new Node(item.val);
                copy.neighbors.Add(a);
                dfs(a,item,vis);
            }else{
                copy.neighbors.Add(vis[item.val]);
            }
        }
    }
}