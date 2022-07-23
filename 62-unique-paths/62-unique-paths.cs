public class Solution {
        int[,] dp = new int[101,101];
        public int UniquePaths(int m, int n)
        {
            return h(new int[m, n], 0, 0,m,n);
        }
        public int h(int[,] g,int i,int j,int m,int n)
        {
            if (i >= m || j >= n ) return 0;
            if (i == m - 1 && j == n - 1) return 1;
            if(dp[i,j]>0)return dp[i,j];
            return dp[i,j]=h(g, i+1, j, m, n) + h(g, i, j+1, m, n);
        }
}