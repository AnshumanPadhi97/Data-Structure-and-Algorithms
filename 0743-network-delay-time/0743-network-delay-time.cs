public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        
            var dist = new int[n+1];
            Array.Fill(dist, int.MaxValue);
            dist[k] = 0;
            for (int i = 1; i <= n; i++)
            {
                foreach (var item in times)
                {
                    int u = item[0], v = item[1], w = item[2];
                    if (dist[u]!=int.MaxValue && dist[v] > dist[u] + w)
                    {
                        dist[v] = dist[u] + w;
                    }
                }
            }
            int res = 0;
            for (int i = 1; i <= n; i++)
            {
                res = Math.Max(res, dist[i]);
            }
            return res == int.MaxValue ? -1 : res;
    }
}