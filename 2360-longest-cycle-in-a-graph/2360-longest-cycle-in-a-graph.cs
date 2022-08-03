public class Solution {
    public int LongestCycle(int[] edges) {
            int res = -1;
            var vis = new HashSet<int>();
            int n = edges.Length;
            for (int i = 0; i < n; i++)
            {
                if (!vis.Contains(edges[i]))
                {
                    var map = new Dictionary<int, int>();
                    var node = i;
                    var dist = 0;
                    while (node != -1)
                    {
                        if (map.ContainsKey(node))
                        {
                            res = Math.Max(res, dist - map[node]);
                            break;
                        }
                        if (vis.Contains(node)) break;

                        vis.Add(node);
                        map.Add(node, dist);
                        node = edges[node];
                        dist++;
                    }
                }
            }
            return res;
    }
}