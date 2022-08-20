public class Solution {
    public int MinimumRecolors(string blocks, int k) {
            int i = 0, j = 0, l = blocks.Length, res = int.MaxValue, w = 0;
            while (j < l)
            {
                if (blocks[j] == 'W')
                {
                    w++;
                }
                while (i < l && j - i + 1 == k)
                {
                    res = Math.Min(res, w);
                    w -= blocks[i] == 'W' ? 1 : 0;
                    i++;
                }
                j++;
            }
            return res;
    }
}