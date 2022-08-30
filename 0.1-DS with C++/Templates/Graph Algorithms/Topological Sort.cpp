vector<int> TopologicalSort_BFS(vector<vector<int>> &g, int n)
{
    vector<int> indegree(n + 1, 0);
    queue<int> q;
    vector<int> res;
    for (auto &&i : g)
    {
        indegree[i[1]]++;
    }
    for (int i = 1; i <= n; i++)
    {
        if (indegree[i] == 0)
        {
            q.push(i);
        }
    }
    while (!q.empty())
    {
        int a = q.front();
        q.pop();
        res.push_back(a);
        for (auto &&i : g[a])
        {
            indegree[i]--;
            if (indegree[i] == 0)
            {
                q.push(i);
            }
        }
    }
    if (res.size() != n)
        return {};
    return res;
}

void topo_dfs(int u, vector<vector<int>> &g, vector<bool> &vis, vector<int> &res)
{
    vis[u] = true;
    for (auto &&i : g[u])
    {
        if (vis[i])
            continue;
        topo_dfs(i, g, vis, res);
    }
    res.push_back(u);
}

vector<int> TopologicalSort_DFS(vector<vector<int>> &g, int n)
{
    vector<int> res;
    vector<bool> vis(n);
    for (int i = 0; i < n; i++)
    {
        if (vis[i])
            continue;
        topo_dfs(i, g, vis, res);
    }
    reverse(all(res));
    return res;
}