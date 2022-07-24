public class Solution {
    public int EqualPairs(int[][] grid) {
            var n = grid.Length;
            int res = 0;
            List<List<int>> r = new List<List<int>>(n);
            List<List<int>> c = new List<List<int>>(n);
            int i, j;
            for (i = 0; i < n; i++)
            {
                r.Add(new List<int>());
                c.Add(new List<int>());
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    r[i].Add(grid[i][j]);
                    c[i].Add(grid[j][i]);
                }
            }
            for (i = 0; i < r.Count; i++)
            {
                var a = c.Where(x => x.SequenceEqual(r[i])).Count();
                res += a;
            }
            return res;
    }
}