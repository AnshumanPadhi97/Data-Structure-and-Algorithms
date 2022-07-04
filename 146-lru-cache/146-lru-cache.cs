public class LRUCache
        {
            public class Node
            {
                public int Key { get; set; }
                public int Val { get; set; }
            }
            int l = 0;
            Dictionary<int, LinkedListNode<Node>> h = new Dictionary<int, LinkedListNode<Node>>();
            LinkedList<Node> q = new LinkedList<Node>();

            public LRUCache(int capacity)
            {
                l = capacity;
            }

            public int Get(int key)
            {
                if (!h.ContainsKey(key))
                {
                    return -1;
                }
                var a = h[key];
                q.Remove(a);
                q.AddFirst(a);
                return a.Value.Val;
            }

            public void Put(int key, int value)
            {
                if (h.ContainsKey(key))
                {
                    var a = h[key];
                    q.Remove(a);
                    a.Value.Val = value;
                    q.AddFirst(a);
                    return;
                }

                if (l == h.Count)
                {
                    h.Remove(q.Last.Value.Key);
                    q.RemoveLast();
                }

                q.AddFirst(new Node { Key = key, Val = value });
                h.Add(key, q.First);
            }
        }