public class Solution {
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            int m = heights.Length;
            int n = heights[0].Length;
            var p = new bool[m, n];
            var a = new bool[m, n];
            var q = new Queue<(int,int)>();
            var q1 = new Queue<(int,int)>();
            for (int i = 0; i < m; i++)
            {
                q.Enqueue((i,0));
                q1.Enqueue((i,n-1));
                p[i, 0] = true;
                a[i, n - 1] = true;
            }
            for (int j = 0; j < n; j++)
            {
                q.Enqueue((0,j));
                q1.Enqueue((m-1,j));
                p[0, j] = true;
                a[m - 1, j] = true;
            }
            bfs(q, heights, p);
            bfs(q1, heights, a);
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (p[i, j] && a[i, j])
                    {
                        res.Add(new List<int>() { i, j });
                    }
                }
            }
            return res;
        }
        public void bfs(Queue<(int,int)> q, int[][] grid, bool[,] tbl)
        {
            var dir = new int[] { 0, 1, 0, -1, 0 };
            while (q.Count > 0)
            {
                var a = q.Dequeue();
                var ai = a.Item1;
                var aj = a.Item2;
                for (int k = 0; k < 4; k++)
                {
                    var nai = ai + dir[k];
                    var naj = aj + dir[k + 1];
                    if (nai < 0 || naj < 0 || nai >= grid.Length || naj >= grid[0].Length || grid[ai][aj] > grid[nai][naj] || tbl[nai,naj])
                        continue;
                    tbl[nai,naj]=true;
                    q.Enqueue((nai, naj));
                }
            }
        }
}