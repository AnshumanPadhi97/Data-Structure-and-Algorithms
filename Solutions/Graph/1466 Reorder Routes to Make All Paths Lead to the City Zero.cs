//reorder all routes to point node 0
public class Solution1466
{
    public int MinReorder(int n, int[][] connections)
    {
        var g = new List<List<int>>();
        for (int i = 0; i < n; i++)
        {
            g.Add(new List<int>());
        }
        foreach (var item in connections)
        {
            g[item[0]].Add(item[1]);
            g[item[1]].Add(-item[0]);
        }
        return dfs(g, new bool[n], 0);
    }
    public int dfs(List<List<int>> g, bool[] vis, int u)
    {
        int res = 0;
        vis[u] = true;
        foreach (var item in g[u])
        {
            if (!vis[Math.Abs(item)])
            {
                res += dfs(g, vis, Math.Abs(item)) + (item > 0 ? 1 : 0);
            }
        }
        return res;
    }
}