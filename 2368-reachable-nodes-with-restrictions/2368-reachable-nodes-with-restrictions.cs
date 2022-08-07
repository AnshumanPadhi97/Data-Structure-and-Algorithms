public class Solution {
        public int ReachableNodes(int n, int[][] edges, int[] restricted)
        {
            var g = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                g.Add(new List<int>());
            }
            foreach (var item in edges)
            {
                g[item[0]].Add(item[1]);
                g[item[1]].Add(item[0]);
            }
            var h = new HashSet<int>();
            dfs(0, g, restricted, h);
            return h.Count;
        }
        public void dfs(int u, List<List<int>> g, int[] restricted, HashSet<int> vis)
        {
            vis.Add(u);
            foreach (var item in g[u])
            {
                if(!vis.Contains(item) && !restricted.Contains(item))
                {
                    dfs(item, g, restricted, vis);
                }
            }
        }
}