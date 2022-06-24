using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Graph
{
    public void addEdgeDirectedWeighted(List<Tuple<int, int>>[] adj, int src, int dest, int weight)
    {
        adj[src].Add(new Tuple<int, int>(dest, weight));
    }
    public void addEdgeDirected(List<int>[] adj, int src, int dest)
    {
        adj[src].Add(dest);
    }
    public void addEdgeUndirected(List<int>[] adj, int src, int dest)
    {
        adj[src].Add(dest);
        //adj[dest].Add(src);
    }
    public void printGragh(List<int>[] adj)
    {
        for (int i = 0; i < adj.Length; i++)
        {
            Console.WriteLine("\nAdjacency list of vertex " + i);
            Console.Write("head");

            foreach (var item in adj[i])
            {
                Console.Write(" -> " + item);
            }
            Console.WriteLine();
        }
    }
    public bool checkEdge(List<int>[] adj, int src, int dest)
    {
        if (adj[src].Contains(dest))
        {
            return true;
        }
        return false;
    }
    public bool bfs(List<int>[] adj, int src, int dest)
    {
        int l = adj.Length;
        bool[] visited = new bool[l];
        int[] distance = new int[l];
        int[] parent = new int[l];

        Queue<int> q = new Queue<int>();

        q.Enqueue(src);
        visited[src] = true;
        distance[src] = 0;
        parent[src] = src;

        while (q.Count != 0)
        {
            int u = q.Peek();
            if (u == dest)
            {
                shortestPath(dest, parent);
                return true;
            }
            q.Dequeue();
            for (int i = 0; i < adj[u].Count; i++)
            {
                int v = adj[u][i];
                if (visited[v] == false)
                {
                    q.Enqueue(v);
                    visited[v] = true;
                    distance[v] = distance[u] + 1;
                    parent[v] = u;
                }
            }
        }
        return visited[dest];
    }
    public void shortestPath(int dest, int[] parent)
    {
        while (dest != parent[dest])
        {
            Console.WriteLine(dest);
            dest = parent[dest];
        }
        Console.WriteLine(dest);
    }
    public bool dfs(List<int>[] adj, int src, int dest, bool[] visited)
    {
        if (visited[src] == true)
            return true;

        visited[src] = true;

        for (int i = 0; i < adj[src].Count; i++)
        {
            int v = adj[src][i];
            dfs(adj, v, dest, visited);
        }

        return visited[src];
    }
    public int connectedComponents(List<int>[] adj)
    {
        int count = 0;
        bool[] visited = new bool[adj.Length];
        for (int i = 1; i < adj.Length; i++)
        {
            if (adj[i].Count != 0 && visited[i] == false)
            {
                int src = adj[i][0];
                int dest = adj[i][adj[i].Count - 1];
                visited[src] = dfs(adj, src, dest, visited);
                count++;
            }
        }
        return count;
    }
    public bool cycle(List<int>[] adj, int nodes)
    {
        int noOfComps = connectedComponents(adj);
        int edges = nodes - noOfComps;
        if (noOfComps == edges)
        {
            return false;
        }
        return true;
    }
    public int FindCenter(int[][] edges)
    {
        int a = edges[0][0];
        int b = edges[0][1];
        int c = edges[1][0];
        int d = edges[1][1];

        if (a == c || a == d)
        {
            return a;
        }
        return b;
    }
    public bool checkCycleInDirectedGraph(List<int>[] adj)
    {
        int[] vis = new int[12];
        Stack st = new Stack();

        for (int i = 1; i <= 11; i++)
        {
            if (vis[i] == 1)
            {
                continue;
            }
            else
            {
                st.Push(i);
                bool ch = helper(i, adj, vis, st);
                if (ch)
                    return true;
                st.Pop();
            }
        }
        return false;
    }
    public bool helper(int u, List<int>[] adj, int[] vis, Stack st)
    {
        if (vis[u] == 1)
            return false;

        vis[u] = 1;
        foreach (var v in adj[u])
        {
            if (st.Contains(v))
            {
                return true;
            }
            else
            {
                st.Push(v);
                bool ch = helper(v, adj, vis, st);
                st.Pop();
                if (ch)
                    return true;
            }
        }
        return false;
    }
    public void topoSort(int s, bool[] vis, List<int>[] adj, List<int> topo)//simple dfs//reverse topo is ans
    {
        if (vis[s] == true)
            return;

        vis[s] = true;
        foreach (var v in adj[s])
        {
            topoSort(v, vis, adj, topo);
        }
        topo.Add(s);
    }
    public void intit()
    {
        int v = 12;

        //for unweighted
        List<int>[] adj = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }


        //printGragh(adj);

        //for weighted
        //List<Tuple<int, int>>[] adj = new List<Tuple<int, int>>[v];
        //for (int i = 0; i < v; i++)
        //{
        //    adj[i] = new List<Tuple<int,int>>();
        //}
    }
    public void printGragh(List<Tuple<int, int>>[] adj)
    {
        for (int i = 0; i < adj.Length; i++)
        {
            Console.WriteLine("\nAdjacency list of vertex " + i);
            Console.Write("head");

            foreach (var item in adj[i])
            {
                Console.Write(" -> " + item);
            }
            Console.WriteLine();
        }
    }
    public void dijkstra(List<Tuple<int, int>>[] adj)
    {
        int l = adj.Length;
        int[] dist = new int[l];
        for (int i = 1; i < l; i++)
        {
            dist[i] = int.MaxValue;
        }
        List<Tuple<int, int>> nums = new List<Tuple<int, int>>();
        nums.Add(new Tuple<int, int>(0, 1));
        dist[1] = 0;

        while (nums.Count > 0)
        {
            nums.Sort();
            Tuple<int, int> data = nums[0];
            nums.RemoveAt(0);
            int u = data.Item2;
            int d = data.Item1;
            if (d > dist[u])
            {
                continue;
            }
            foreach (var item in adj[u])
            {
                int v = item.Item1;
                int w = item.Item2;
                if (dist[v] > dist[u] + w)
                {
                    dist[v] = dist[u] + w;
                    nums.Add(new Tuple<int, int>(dist[v], v));
                }
            }
        }

        for (int i = 1; i < dist.Length; i++)
        {
            Console.WriteLine(i.ToString() + ' ' + dist[i].ToString());
        }
    }
    public void intite()
    {
        int v = 11;

        List<Tuple<int, int>>[] adj = new List<Tuple<int, int>>[v];
        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<Tuple<int, int>>();
        }

        //addEdgeDirectedWeighted(adj, 1, 2, 4);
        //addEdgeDirectedWeighted(adj, 1, 7, 2);
        //addEdgeDirectedWeighted(adj, 1, 4, 8);
        //addEdgeDirectedWeighted(adj, 2, 4, 1);
        //addEdgeDirectedWeighted(adj, 2, 1, 4);
        //addEdgeDirectedWeighted(adj, 2, 7, 1);
        //addEdgeDirectedWeighted(adj, 2, 3, 5);
        //addEdgeDirectedWeighted(adj, 2, 8, 9);
        //addEdgeDirectedWeighted(adj, 3, 2, 5);
        //addEdgeDirectedWeighted(adj, 3, 8, 2);
        //addEdgeDirectedWeighted(adj, 3, 10, 1);
        //addEdgeDirectedWeighted(adj, 4, 1, 8);
        //addEdgeDirectedWeighted(adj, 4, 2, 1);
        //addEdgeDirectedWeighted(adj, 4, 7, 3);
        //addEdgeDirectedWeighted(adj, 5, 8, 6);
        //addEdgeDirectedWeighted(adj, 6, 8, 3);
        //addEdgeDirectedWeighted(adj, 6, 9, 5);
        //addEdgeDirectedWeighted(adj, 7, 4, 3);
        //addEdgeDirectedWeighted(adj, 7, 1, 2);
        //addEdgeDirectedWeighted(adj, 7, 8, 4);
        //addEdgeDirectedWeighted(adj, 7, 2, 1);
        //addEdgeDirectedWeighted(adj, 8, 5, 6);
        //addEdgeDirectedWeighted(adj, 8, 3, 2);
        //addEdgeDirectedWeighted(adj, 8, 2, 9);
        //addEdgeDirectedWeighted(adj, 8, 7, 4);
        //addEdgeDirectedWeighted(adj, 8, 6, 3);
        //addEdgeDirectedWeighted(adj, 9, 6, 5);
        //addEdgeDirectedWeighted(adj, 9, 10, 4);
        //addEdgeDirectedWeighted(adj, 10, 9, 4);
        //addEdgeDirectedWeighted(adj, 10, 3, 1);

        dijkstra(adj);
        //printGragh(adj);
    }
}
