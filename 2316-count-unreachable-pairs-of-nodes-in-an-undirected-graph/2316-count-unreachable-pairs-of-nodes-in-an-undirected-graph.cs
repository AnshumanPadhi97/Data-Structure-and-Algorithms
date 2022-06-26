public class Solution {
    public long CountPairs(int n, int[][] edges)
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
        long res = 0;
        bool[] vis = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (!vis[i])
            {
                var a = dfs(g, i, vis);
                res += a * (n - a);
            }
        }
        return res/2;
    }
    public long dfs(List<List<int>> g, int u, bool[] vis)
    {
        vis[u] = true;
        long res = 1;
        foreach (var item in g[u])
        {
            if (!vis[item])
            {
                vis[item] = true;
                res += dfs(g, item, vis);
            }
        }
        return res;
    }
}