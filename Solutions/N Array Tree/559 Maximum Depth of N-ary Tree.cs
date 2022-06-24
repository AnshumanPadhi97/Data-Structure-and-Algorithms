
 //Definition for a Node.
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

//bfs
public class Solution559
{
    public int MaxDepthBFS(Node root)
    {
        if (root == null) return 0;
        var q = new Queue<Node>();
        int d = 0;
        q.Enqueue(root);
        while (q.Count > 0)
        {
            d += 1;
            var l = q.Count;
            while (l-- > 0)
            {
                var a = q.Dequeue();
                foreach (var item in a.children)
                {
                    q.Enqueue(item);
                }
            }
        }
        return d;
    }
    
    public int MaxDepthDFS(Node root)
    {
        return h(root);
    }
    public int h(Node root)
    {
        if (root == null) return 0;
        int l = 0;
        foreach (var item in root.children)
        {
            l = Math.Max(l, h(item));
        }
        return 1 + l;
    }
}
