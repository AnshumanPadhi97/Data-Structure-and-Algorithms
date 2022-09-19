
    public class LRUCache
    {
        public class Node
        {
            public int key { get; set; }
            public int value { get; set; }
        }
        int l = 0;
        LinkedList<Node> q = new LinkedList<Node>();
        Dictionary<int, LinkedListNode<Node>> d = new Dictionary<int, LinkedListNode<Node>>();

        public LRUCache(int capacity)
        {
            l = capacity;
        }

        public int Get(int key)
        {
            if (!d.ContainsKey(key))
            {
                return -1;
            }
            var a = d[key];
            q.Remove(a);
            q.AddFirst(a);
            return a.Value.value;
        }

        public void Put(int key, int value)
        {
            if (d.ContainsKey(key))
            {
                var a = d[key];
                q.Remove(a);
                a.Value.value = value;
                q.AddFirst(a);
                return;
            }
            if (l == d.Count)
            {
                d.Remove(q.Last.Value.key);
                q.RemoveLast();
            }
            q.AddFirst(new Node() { key = key, value = value });
            d.Add(key, q.First);
        }
    }