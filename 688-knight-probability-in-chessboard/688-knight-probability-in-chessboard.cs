public class Solution {
        double[,,] dp = new double[26, 26, 101];
        public double KnightProbability(int n, int k, int row, int column)
        {
            return h(n, k, row, column);
        }
        List<int[]> dir = new List<int[]>()
        {
            new int[] {-1,2},
            new int[] {1,2},
            new int[] {1,-2},
            new int[] {-1,-2},
            new int[] {2,1},
            new int[] {2,-1},
            new int[] {-2,1},
            new int[] {-2,-1},
        };
        public double h(int n,int k,int r,int c)
        {
            if (r < 0 || c < 0 || r >= n || c >= n) return 0;
            
            if (k == 0) return 1;
            if (dp[r, c, k] > 0) return dp[r, c, k];

            double sum = 0;
            for (int i = 0; i < 8; i++)
            {
                sum += 0.125 * h(n, k - 1, r + dir[i][0], c + dir[i][1]);
            }
            return dp[r, c, k] = sum;
        }
}