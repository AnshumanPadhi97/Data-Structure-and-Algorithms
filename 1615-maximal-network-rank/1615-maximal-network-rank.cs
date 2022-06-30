public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
            bool[,] conn = new bool[n,n];
            int[] cnt = new int[n];
            foreach (var item in roads)
            {
                conn[item[0],item[1]] = true;
                conn[item[1],item[0]] = true;
                cnt[item[0]]++;
                cnt[item[1]]++;
            }
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    res = Math.Max(res, cnt[i] + cnt[j] - (conn[i, j] == true ? 1 : 0));
                }
            }
            return res;
    }
}