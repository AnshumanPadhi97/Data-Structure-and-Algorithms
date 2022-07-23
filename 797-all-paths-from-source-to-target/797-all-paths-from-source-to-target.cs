public class Solution {
        IList<IList<int>> res = new List<IList<int>>();
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            dfs(graph, 0,new List<int>() { 0});
            return res;
        }
        public void dfs(int[][] graph,int u, List<int> temp)
        {
            if (u == graph.Length - 1)
            {
                res.Add(temp.ToList());
                return;
            }
            foreach (var item in graph[u])
            {
                temp.Add(item);
                dfs(graph, item, temp);
                temp.RemoveAt(temp.Count - 1);
            }
        }
}