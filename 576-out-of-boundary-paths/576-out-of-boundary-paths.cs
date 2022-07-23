public class Solution {
    
        private int MOD = 1000000007;
        int[] dir = new int[] { 0, 1, 0, -1, 0 };
        Dictionary<(int, int, int), int> dp = new Dictionary<(int, int, int), int>();
    
        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            return h(m, n, maxMove, startRow, startColumn);
        }
    
        public int h(int m,int n,int maxMove,int r,int c)
        {
            if (r < 0 || c < 0 || r == m || c == n) return 1;
            if (maxMove == 0) return 0;

            if (dp.ContainsKey((r,c,maxMove))) 
                return dp[(r, c, maxMove)];

            int res = 0;
            for (int i = 0; i < 4; i++)
            {
                res = (res + h(m, n, maxMove - 1, r + dir[i], c + dir[i + 1])) % MOD;
            }
            return dp[(r, c, maxMove)] = res;
        }
}